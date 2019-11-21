using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardsMapper.Helpers
{
    internal static class Dialogs
    {
        public static int[] GetDoorsIDs()
        {
            using (Ookii.Dialogs.InputDialog dlg = new Ookii.Dialogs.InputDialog
            {
                Multiline = true,
                MaxLength = 0,
                MainInstruction = "Импорт по номеру DOORS",
                WindowTitle = "Импорт по номеру DOORS",
                Content = "Введите список номеров DOORS/Infopanel."
            })
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var lines = new List<int>();
                    foreach (var line in dlg.InputLines.Where(a => !string.IsNullOrEmpty(a)))
                    {
                        if (int.TryParse(line, out int res))
                            lines.Add(res);
                    }
                    return lines.ToArray();
                }
                return null;
            }
        }
        public static void SaveImage(System.Drawing.Bitmap bmp)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Jpeg файл|*.jpg|Png файл|*.png|Bitmap файл|*.bmp";
                dlg.Title = "Сохранить изображение";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.FileStream fs = (System.IO.FileStream)dlg.OpenFile())
                    {
                        switch (dlg.FilterIndex)
                        {
                            case 1:
                                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case 2:
                                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case 3:
                                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        }
                        fs.Close();
                    }
                }
            }
        }
        public static string GetSaveKmzPath()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Google Maps|*.kmz";
                dlg.Title = "Сохранить KMZ";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.FileName;

                return null;                
            }
        }
    }
}
