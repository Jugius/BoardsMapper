namespace BoardsMapper.Dialogs
{
    partial class GeocoderSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._secondaryPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._primaryPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGeocoder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._secondaryPanel.SuspendLayout();
            this._primaryPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _secondaryPanel
            // 
            this._secondaryPanel.Controls.Add(this._cancelButton);
            this._secondaryPanel.Controls.Add(this._okButton);
            this._secondaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._secondaryPanel.Location = new System.Drawing.Point(0, 143);
            this._secondaryPanel.Name = "_secondaryPanel";
            this._secondaryPanel.Size = new System.Drawing.Size(343, 47);
            this._secondaryPanel.TabIndex = 11;
            this._secondaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._secondaryPanel_Paint);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._cancelButton.Location = new System.Drawing.Point(244, 8);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(87, 27);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._okButton.Location = new System.Drawing.Point(149, 8);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(87, 27);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _primaryPanel
            // 
            this._primaryPanel.Controls.Add(this.groupBox3);
            this._primaryPanel.Controls.Add(this.groupBox1);
            this._primaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._primaryPanel.Location = new System.Drawing.Point(0, 0);
            this._primaryPanel.Name = "_primaryPanel";
            this._primaryPanel.Padding = new System.Windows.Forms.Padding(5);
            this._primaryPanel.Size = new System.Drawing.Size(343, 143);
            this._primaryPanel.TabIndex = 12;
            this._primaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._primaryPanel_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.txtAPIKey);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(240, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Что это такое?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(139, 22);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(187, 23);
            this.txtAPIKey.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ключ GoogleAPI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbGeocoder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Служба геокодирования";
            // 
            // cmbGeocoder
            // 
            this.cmbGeocoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeocoder.FormattingEnabled = true;
            this.cmbGeocoder.Items.AddRange(new object[] {
            "Google Maps"});
            this.cmbGeocoder.Location = new System.Drawing.Point(139, 26);
            this.cmbGeocoder.Name = "cmbGeocoder";
            this.cmbGeocoder.Size = new System.Drawing.Size(187, 23);
            this.cmbGeocoder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Активная служба";
            // 
            // GeocoderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 190);
            this.Controls.Add(this._primaryPanel);
            this.Controls.Add(this._secondaryPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeocoderSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Служба поиска адресов";
            this.Load += new System.EventHandler(this.GeocoderSettings_Load);
            this._secondaryPanel.ResumeLayout(false);
            this._primaryPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _secondaryPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Panel _primaryPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGeocoder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}