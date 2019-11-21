using System;

namespace BoardsMapper.Helpers
{
    static class Doors
    {
        private const string noDoorsPath = "Необходимо указать путь к папке, в которой лежат файлы базы DOORS на вашем компьютере.\nОбычно это папка DATA, которая находится внутри папки Infopanel.\n\nЭто можно сделать в настройках программы.";
        public static string DoorsReadingYear
        {
            get => string.IsNullOrEmpty(Properties.Settings.Default.DoorsReadingYear) ? DateTime.Now.Year.ToString() : Properties.Settings.Default.DoorsReadingYear;
            set => Properties.Settings.Default.DoorsReadingYear = (string.IsNullOrEmpty(value) || value == DateTime.Now.Year.ToString()) ? null : value;
        }
        public static string DoorsDataPath
        {
            get => Properties.Settings.Default.DoorsDataPath ?? string.Empty;
            set => Properties.Settings.Default.DoorsDataPath = string.IsNullOrEmpty(value) ? null : value;            
        }
        public static DataManager.DoorsReadParameters GetParameters(bool pathRequest = true)
        {
            if (string.IsNullOrEmpty(DoorsDataPath))
            {
                if (pathRequest)
                    System.Windows.Forms.MessageBox.Show(noDoorsPath, "База данных Infopanel", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);

                return null;
            }
            DataManager.DoorsReadParameters p = new DataManager.DoorsReadParameters
            {
                DataPath = DoorsDataPath,
                LoadDeleted = false,
                LoadEmpty = false,
                Year = int.Parse(DoorsReadingYear)
            };
            return p;
        }
    }
}
