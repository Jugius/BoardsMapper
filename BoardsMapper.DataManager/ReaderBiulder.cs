using BoardsMapper.DataManager.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.DataManager
{
    public class ReaderBiulder
    {
        IProcessor processor;
        public Ookii.Dialogs.ProgressDialog Build(DoorsReadParameters p)
        {
            string dbFile = $"_{p.Year}nos.dbf";
            if (!System.IO.File.Exists(System.IO.Path.Combine(p.DataPath, dbFile)))
                throw new Exception($"Файл {dbFile} не найден в папке: {p.DataPath}");

            dbFile = "cities.dbf";
            if (!System.IO.File.Exists(System.IO.Path.Combine(p.DataPath, dbFile)))
                throw new Exception($"Файл {dbFile} не найден в папке: {p.DataPath}");

            var connectString = $"Provider = VFPOLEDB.1; Data Source = {p.DataPath}";
            DoorsReader d = new DoorsReader(connectString, p.Year);
            processor = d;
            Ookii.Dialogs.ProgressDialog dlg = new Ookii.Dialogs.ProgressDialog();
            dlg.WindowTitle = dlg.Text = "Чтение плоскостей из базы Doors";
            dlg.DoWork += Dlg_DoWork;
            dlg.ProgressBarStyle = Ookii.Dialogs.ProgressBarStyle.MarqueeProgressBar;
            return dlg;
        }

        private void Dlg_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            processor.StartProcess(sender as Ookii.Dialogs.ProgressDialog, e);
        }
    }
}
