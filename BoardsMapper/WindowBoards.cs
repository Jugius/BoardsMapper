using BoardsMapper.AppModels.Boards;
using BoardsMapper.DataManager;
using BoardsMapper.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BoardsMapper
{
    public partial class WindowBoards : Form
    {
        //private readonly int[] doorsIds = new int[] { 306876, 305235, 308680, 324185, 325444, 326877, 20000, 18948, 2323, 302968, 296352, 305506, 305265, 305301, 306982, 307081, 121634, 167138, 322555, 317658, 236672, 308422, 306788, 290981, 310496, 72230, 315027, 310437, 313648, 311826, 326899, 319398, 313512, 308203, 313463, 310625, 307908, 306720, 311974, 308503, 310681, 318033, 312529, 321028, 310347, 310535, 305213, 308911, 308951, 308837, 8965, 326708, 21106, 307714, 309737, 76798, 312336, 312230, 306592, 50198, 304084, 71445, 304191, 306416, 190715, 308665, 314661, 317378, 321037, 312469, 315792, 308471, 120608, 120639, 320162, 310770, 302271, 302080, 120383, 320432 };
        public List<IBoard> Boards => olvBoards.CollectCheckedObjects<IBoard>(ObjectListViewHelper.ObjectListViewCollector.All);
        private ColorsProvider ColorsProvider { get; set; }
        public WindowBoards()
        {
            InitializeComponent();
            InitializeObjectListView();
            this.Icon = Properties.Resources.Billboard_Icon;
        }        

        private void Dlg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message, "Ошибка чтения плоскостей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<IBoard> list = e.Result as List<IBoard>;
                SetBoards(list);
                MessageBox.Show(owner: this, $"Добавили {list.Count} плоскостей", "Импорт плоскостей", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }            
        }
        
        private void InitializeObjectListView()
        {
            string boardState = Properties.Settings.Default.olvBoardsState;
            if (!string.IsNullOrEmpty(boardState))
            {
                try
                {
                    byte[] array = System.Convert.FromBase64String(Properties.Settings.Default.olvBoardsState);
                    olvBoards.RestoreState(array);
                }
                catch
                {
                    Properties.Settings.Default.olvBoardsState = null;
                }
            }            
            olvColumn_Town.AspectGetter = delegate (object row) { return (row as IBoard).Address.City; };
            olvColumn_Code.AspectGetter = delegate (object row) { return ((IBoard)row).Code; };
            olvColumn_GRP.AspectGetter = delegate (object row) { return (row as IBoard).Metrics.GRP; };
            olvColumn_ID.AspectGetter = delegate (object row) { return (row as IBoard).ID; };
            olvColumn_Light.AspectGetter = delegate (object row) { return (row as IBoard).Lighting ? "+" : null; };
            olvColumn_OTS.AspectGetter = delegate (object row) { return (row as IBoard).Metrics.OTS; };
            olvColumn_Side.AspectGetter = delegate (object row) { return (row as IBoard).Side; };
            olvColumn_Size.AspectGetter = delegate (object row) { return (row as IBoard).Size; };
            olvColumn_Street.AspectGetter = delegate (object row) { return (row as IBoard).Address.Street; };
            olvColumn_StreetNumber.AspectGetter = delegate (object row) { return (row as IBoard).Address.StreetNumber; };
            olvColumn_Supplier.AspectGetter = delegate (object row) { return (row as IBoard).Supplier; };
            olvColumn_Type.AspectGetter = delegate (object row) { return (row as IBoard).Type; };   
        }
        public void SetBoards(List<IBoard> boards)
        {
            if (olvBoards.Objects == null || olvBoards.GetItemCount() == 0)
                olvBoards.SetObjects(boards);
            else
                olvBoards.AddObjects(boards);
        }

        
        
        #region Buttons Clicks
        #region Toolstrip Boards
        private void btnLoadDoors_Click(object sender, EventArgs e)
        {
            var lines = Helpers.Dialogs.GetDoorsIDs();
            if (lines == null || lines.Length < 1) return;         

            var p = Helpers.Doors.GetParameters();
            if (p == null) return;

            var dlg = new DataManager.ReaderBiulder().Build(p);
            dlg.RunWorkerCompleted += Dlg_RunWorkerCompleted;
            dlg.ShowDialog(this, lines);
        }
        private void btnSaveKml_Click(object sender, EventArgs e)
        {
            if (this.Boards.Count == 0 || string.IsNullOrEmpty(Helpers.GoogleApiKey.GetKey())) return;
            string filePath = Helpers.Dialogs.GetSaveKmzPath();
            if (string.IsNullOrEmpty(filePath)) return;

            DataManager.KmlWriteParameters p = new KmlWriteParameters
            {
                Boards = Boards,
                ColorsProvider = this.ColorsProvider ?? DataManager.ColorsProvider.Create(DataManager.ColorsProvider.GroupingBy.Size, Boards),
                FilePath = filePath
            };
            var writer = new DataManager.WriterBuilder().Build(p);
            string path = writer.Write(p);
            System.Diagnostics.Process.Start(path);
        }
        private void btnGeocoderSettings_Click(object sender, EventArgs e)
        {
            using (var dlg = new Dialogs.GeocoderSettings())
            {
                dlg.ShowDialog(this);
            }
        }
        private void btnBoardsReadSettings_Click(object sender, EventArgs e)
        {
            using (var dlg = new Dialogs.BoardsReadSettings())
            {
                dlg.ShowDialog(this);
            }
        }
        #endregion

        #region Toolstrip Map
        private void btnDrawMap_Click(object sender, EventArgs e)
        {
            if (this.Boards.Count == 0) return;
            if (string.IsNullOrEmpty(Helpers.GoogleApiKey.GetKey())) return;
            DataManager.HtmlWriteParameters p = new DataManager.HtmlWriteParameters
            {
                ApiKey = Helpers.GoogleApiKey.GoogleAPIKey,
                Boards = Boards,
                MapSize = new Size(webBrowser1.Width, webBrowser1.Height),
                ColorsProvider = this.ColorsProvider ?? DataManager.ColorsProvider.Create(DataManager.ColorsProvider.GroupingBy.Default, Boards)
            };
            var writer = new DataManager.WriterBuilder().Build(p);

            string html = writer.Write(p);
            this.webBrowser1.DocumentText = html;
        }
        private void btnSaveMapScreen_Click(object sender, EventArgs e)
        {
            var bmp = GetBitmap();
            if (bmp != null)
                Helpers.Dialogs.SaveImage(bmp);
        }
        private void btnSaveMapClipboard_Click(object sender, EventArgs e)
        {
            var bmp = GetBitmap();
            if (bmp != null)
                Clipboard.SetDataObject(bmp);
        }
        private void btnColorProviderDialog_Click(object sender, EventArgs e)
        {
            if (this.Boards.Count == 0) return;
            var provider = this.ColorsProvider ?? DataManager.ColorsProvider.Create(DataManager.ColorsProvider.GroupingBy.Kind, this.Boards);
            using (var dlg = new Dialogs.ColorsProviderDialog(provider, this.Boards))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    this.ColorsProvider = dlg.ColorsProvider;
            }
        }
        #endregion
        #endregion





        private Bitmap GetBitmap()
        {
            if (string.IsNullOrEmpty(webBrowser1.DocumentText))
                return null;

            Bitmap bmp = new Bitmap(webBrowser1.Width, webBrowser1.Height);
            webBrowser1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        
    }
}
