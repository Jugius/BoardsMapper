using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.Helpers
{
    static class GoogleApiKey
    {
        public static string GoogleAPIKey
        {
            get => Properties.Settings.Default.GoogleAPIKey;
            set => Properties.Settings.Default.GoogleAPIKey = value;
        }
        internal static string GetKey(bool keyRequest = true)
        {
            if (string.IsNullOrEmpty(GoogleAPIKey))
            {
                if (keyRequest)
                    System.Windows.Forms.MessageBox.Show(Properties.Resources.GoogleNoApiException, "Ошибка ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                return null;
            }
            else
            {
                return GoogleAPIKey;
            }
        }
    }
}
