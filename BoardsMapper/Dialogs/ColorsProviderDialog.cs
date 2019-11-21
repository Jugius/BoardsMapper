using BoardsMapper.AppModels.Boards;
using BoardsMapper.DataManager;
using BoardsMapper.Helpers;
using Ookii.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardsMapper.Dialogs
{
    public partial class ColorsProviderDialog : Form
    {
        private readonly List<IBoard> Boards;
        public ColorsProvider ColorsProvider => _colorsProvider;
        private ColorsProvider _colorsProvider;
        public ColorsProviderDialog(ColorsProvider provider, List<IBoard> boards)
        {
            InitializeComponent();
            InitializeComboBox();
            Boards = boards;
            cmbGrouping.SelectedValue = provider.GroupKey;
            olvColorGroups.SetObjects(provider.ColorGroups);
            cmbGrouping.SelectedValueChanged += CmbGrouping_SelectedValueChanged;
        }

        private void CmbGrouping_SelectedValueChanged(object sender, EventArgs e)
        {
            var provider = DataManager.ColorsProvider.Create((ColorsProvider.GroupingBy)cmbGrouping.SelectedValue, this.Boards);
            olvColorGroups.SetObjects(provider.ColorGroups);
        }

        private void InitializeComboBox()
        {
            var a = new[]
            {
            new { Name = "По умолчанию", Value = DataManager.ColorsProvider.GroupingBy.Default },
            new { Name = "Тип конструкции", Value = DataManager.ColorsProvider.GroupingBy.Kind },
            new { Name = "Размер", Value = DataManager.ColorsProvider.GroupingBy.Size },
            new { Name = "Владелец", Value = DataManager.ColorsProvider.GroupingBy.Supplier },
            new { Name = "Город", Value = DataManager.ColorsProvider.GroupingBy.City }
            }.ToList();
            cmbGrouping.DataSource = a;
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            var provider = DataManager.ColorsProvider.Create((ColorsProvider.GroupingBy)cmbGrouping.SelectedValue, this.Boards);
            provider.ColorGroups = olvColorGroups.CollectCheckedObjects<ColorGroup>(ObjectListViewHelper.ObjectListViewCollector.All);
            this._colorsProvider = provider;
            this.DialogResult = DialogResult.OK;
        }
        private void _primaryPanel_Paint(object sender, PaintEventArgs e)
        {
            Ookii.Dialogs.DialogHelper.DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.PrimaryPanel, _primaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
        {
            Ookii.Dialogs.DialogHelper.DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.SecondaryPanel, _secondaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void olvColorGroups_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == this.olvColumnColor.Index)
            {
                ColorGroup colorGroup = (ColorGroup)e.Model;
                    e.SubItem.BackColor = colorGroup.Color;
            }
        }

        private void olvColorGroups_DoubleClick(object sender, EventArgs e)
        {
            if (olvColorGroups.SelectedObject == null) return;
            ColorGroup colorGroup = olvColorGroups.SelectedObject as ColorGroup;

            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = colorGroup.Color;
                dlg.SolidColorOnly = true;
                dlg.CustomColors = ColorGroup.GetDefaultColors().Select(a => ColorTranslator.ToOle(a)).ToArray();
                if (dlg.ShowDialog() == DialogResult.OK)
                    colorGroup.Color = dlg.Color;
            }
        }
    }
}
