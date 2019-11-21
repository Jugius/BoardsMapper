using System;
using System.Windows.Forms;

namespace BoardsMapper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UpgradeSettingsIfRequired();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowBoards());
        }
        static void UpgradeSettingsIfRequired()
        {
            if (Properties.Settings.Default.SettingsUpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.SettingsUpgradeRequired = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
