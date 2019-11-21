using Ookii.Dialogs;
using System;
using System.Windows.Forms;

namespace BoardsMapper.Dialogs
{
    public partial class GeocoderSettings : Form
    {
        public GeocoderSettings()
        {
            InitializeComponent();
        }

        private void _primaryPanel_Paint(object sender, PaintEventArgs e)
        {
            Ookii.Dialogs.DialogHelper.DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.PrimaryPanel, _primaryPanel.ClientRectangle, e.ClipRectangle);
        }

        private void _secondaryPanel_Paint(object sender, PaintEventArgs e)
        {
            Ookii.Dialogs.DialogHelper.DrawThemeBackground(e.Graphics, AdditionalVisualStyleElements.TaskDialog.SecondaryPanel, _secondaryPanel.ClientRectangle, e.ClipRectangle);
        }
        private void GeocoderSettings_Load(object sender, EventArgs e)
        {
            cmbGeocoder.SelectedItem = "Google Maps";
            txtAPIKey.Text = Helpers.GoogleApiKey.GoogleAPIKey;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Для использования сервиса Google Maps необходимо наличие API ключа. Вы можете зарегистрировать его на сайте Google Clouds.\n\nПерейти на сайт Google Clouds?";
            if (MessageBox.Show(message, "Google Maps API", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"https://cloud.google.com/maps-platform/");
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            Helpers.GoogleApiKey.GoogleAPIKey = txtAPIKey.Text;            
            this.DialogResult = DialogResult.OK;
        }
    }
}
