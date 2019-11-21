namespace BoardsMapper.Dialogs
{
    partial class ColorsProviderDialog
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
            this.olvColorGroups = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn_Key = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnColor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGrouping = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._secondaryPanel.SuspendLayout();
            this._primaryPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvColorGroups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _secondaryPanel
            // 
            this._secondaryPanel.Controls.Add(this._cancelButton);
            this._secondaryPanel.Controls.Add(this._okButton);
            this._secondaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._secondaryPanel.Location = new System.Drawing.Point(0, 280);
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
            this._primaryPanel.Size = new System.Drawing.Size(343, 280);
            this._primaryPanel.TabIndex = 12;
            this._primaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._primaryPanel_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.olvColorGroups);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 210);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цветовая тема";
            // 
            // olvColorGroups
            // 
            this.olvColorGroups.AllColumns.Add(this.olvColumn_Key);
            this.olvColorGroups.AllColumns.Add(this.olvColumnColor);
            this.olvColorGroups.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.olvColorGroups.BackColor = System.Drawing.Color.White;
            this.olvColorGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvColorGroups.CellEditUseWholeCell = false;
            this.olvColorGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Key,
            this.olvColumnColor});
            this.olvColorGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvColorGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvColorGroups.EmptyListMsg = "";
            this.olvColorGroups.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvColorGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.olvColorGroups.FullRowSelect = true;
            this.olvColorGroups.GridLines = true;
            this.olvColorGroups.HideSelection = false;
            this.olvColorGroups.Location = new System.Drawing.Point(3, 19);
            this.olvColorGroups.MultiSelect = false;
            this.olvColorGroups.Name = "olvColorGroups";
            this.olvColorGroups.RowHeight = 19;
            this.olvColorGroups.ShowGroups = false;
            this.olvColorGroups.ShowImagesOnSubItems = true;
            this.olvColorGroups.Size = new System.Drawing.Size(327, 188);
            this.olvColorGroups.TabIndex = 2;
            this.olvColorGroups.UseCellFormatEvents = true;
            this.olvColorGroups.UseCompatibleStateImageBehavior = false;
            this.olvColorGroups.UseExplorerTheme = true;
            this.olvColorGroups.View = System.Windows.Forms.View.Details;
            this.olvColorGroups.VirtualMode = true;
            this.olvColorGroups.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvColorGroups_FormatCell);
            this.olvColorGroups.DoubleClick += new System.EventHandler(this.olvColorGroups_DoubleClick);
            // 
            // olvColumn_Key
            // 
            this.olvColumn_Key.AspectName = "Key";
            this.olvColumn_Key.FillsFreeSpace = true;
            this.olvColumn_Key.Text = "Группировка";
            this.olvColumn_Key.Width = 25;
            // 
            // olvColumnColor
            // 
            this.olvColumnColor.MaximumWidth = 19;
            this.olvColumnColor.MinimumWidth = 19;
            this.olvColumnColor.Text = "Цв.";
            this.olvColumnColor.Width = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbGrouping);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группировка плоскостей";
            // 
            // cmbGrouping
            // 
            this.cmbGrouping.DisplayMember = "Name";
            this.cmbGrouping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrouping.FormattingEnabled = true;
            this.cmbGrouping.Items.AddRange(new object[] {
            "Google Maps"});
            this.cmbGrouping.Location = new System.Drawing.Point(139, 26);
            this.cmbGrouping.Name = "cmbGrouping";
            this.cmbGrouping.Size = new System.Drawing.Size(187, 23);
            this.cmbGrouping.TabIndex = 3;
            this.cmbGrouping.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группировать по:";
            // 
            // ColorsProviderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 327);
            this.Controls.Add(this._primaryPanel);
            this.Controls.Add(this._secondaryPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorsProviderDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Служба поиска адресов";
            this._secondaryPanel.ResumeLayout(false);
            this._primaryPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvColorGroups)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbGrouping;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.FastObjectListView olvColorGroups;
        private BrightIdeasSoftware.OLVColumn olvColumn_Key;
        private BrightIdeasSoftware.OLVColumn olvColumnColor;
    }
}