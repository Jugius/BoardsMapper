namespace BoardsMapper
{
    partial class WindowBoards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowBoards));
            this.panelBoards = new System.Windows.Forms.Panel();
            this.olvBoards = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn_Town = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Code = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Side = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Supplier = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Street = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_StreetNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_OTS = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_GRP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Type = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_Light = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStripBoards = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoadDoors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnSaveKml = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnGeocoderSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoardsReadSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.panelBoardsInfo = new System.Windows.Forms.Panel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripMap = new System.Windows.Forms.ToolStrip();
            this.btnDrawMap = new System.Windows.Forms.ToolStripButton();
            this.btnSaveMapScreen = new System.Windows.Forms.ToolStripButton();
            this.btnSaveMapClipboard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnColorProviderDialog = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBoards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvBoards)).BeginInit();
            this.toolStripBoards.SuspendLayout();
            this.panelBoardsInfo.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.toolStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoards
            // 
            this.panelBoards.Controls.Add(this.olvBoards);
            this.panelBoards.Controls.Add(this.toolStripBoards);
            this.panelBoards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoards.Location = new System.Drawing.Point(0, 0);
            this.panelBoards.Name = "panelBoards";
            this.panelBoards.Size = new System.Drawing.Size(604, 665);
            this.panelBoards.TabIndex = 1;
            // 
            // olvBoards
            // 
            this.olvBoards.AllColumns.Add(this.olvColumn_Town);
            this.olvBoards.AllColumns.Add(this.olvColumn_Code);
            this.olvBoards.AllColumns.Add(this.olvColumn_Side);
            this.olvBoards.AllColumns.Add(this.olvColumn_Supplier);
            this.olvBoards.AllColumns.Add(this.olvColumn_Street);
            this.olvBoards.AllColumns.Add(this.olvColumn_StreetNumber);
            this.olvBoards.AllColumns.Add(this.olvColumn_OTS);
            this.olvBoards.AllColumns.Add(this.olvColumn_GRP);
            this.olvBoards.AllColumns.Add(this.olvColumn_Type);
            this.olvBoards.AllColumns.Add(this.olvColumn_Size);
            this.olvBoards.AllColumns.Add(this.olvColumn_ID);
            this.olvBoards.AllColumns.Add(this.olvColumn_Light);
            this.olvBoards.AllowColumnReorder = true;
            this.olvBoards.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.olvBoards.BackColor = System.Drawing.Color.White;
            this.olvBoards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvBoards.CellEditUseWholeCell = false;
            this.olvBoards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_Town,
            this.olvColumn_Code,
            this.olvColumn_Side,
            this.olvColumn_Supplier,
            this.olvColumn_Street,
            this.olvColumn_StreetNumber,
            this.olvColumn_OTS,
            this.olvColumn_GRP,
            this.olvColumn_Type,
            this.olvColumn_Size,
            this.olvColumn_ID,
            this.olvColumn_Light});
            this.olvBoards.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvBoards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvBoards.EmptyListMsg = "";
            this.olvBoards.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvBoards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.olvBoards.FullRowSelect = true;
            this.olvBoards.GridLines = true;
            this.olvBoards.HeaderUsesThemes = true;
            this.olvBoards.HideSelection = false;
            this.olvBoards.Location = new System.Drawing.Point(0, 32);
            this.olvBoards.Name = "olvBoards";
            this.olvBoards.RowHeight = 19;
            this.olvBoards.ShowGroups = false;
            this.olvBoards.ShowImagesOnSubItems = true;
            this.olvBoards.Size = new System.Drawing.Size(604, 633);
            this.olvBoards.TabIndex = 1;
            this.olvBoards.UseCellFormatEvents = true;
            this.olvBoards.UseCompatibleStateImageBehavior = false;
            this.olvBoards.View = System.Windows.Forms.View.Details;
            this.olvBoards.VirtualMode = true;
            // 
            // olvColumn_Town
            // 
            this.olvColumn_Town.Text = "Город";
            this.olvColumn_Town.Width = 89;
            // 
            // olvColumn_Code
            // 
            this.olvColumn_Code.HeaderCheckBox = true;
            this.olvColumn_Code.Text = "Номер";
            this.olvColumn_Code.Width = 131;
            // 
            // olvColumn_Side
            // 
            this.olvColumn_Side.Text = "|";
            this.olvColumn_Side.Width = 21;
            // 
            // olvColumn_Supplier
            // 
            this.olvColumn_Supplier.Text = "Владелец";
            this.olvColumn_Supplier.Width = 115;
            // 
            // olvColumn_Street
            // 
            this.olvColumn_Street.Text = "Улица";
            this.olvColumn_Street.Width = 207;
            // 
            // olvColumn_StreetNumber
            // 
            this.olvColumn_StreetNumber.Text = "Дом";
            this.olvColumn_StreetNumber.Width = 46;
            // 
            // olvColumn_OTS
            // 
            this.olvColumn_OTS.Text = "OTS";
            this.olvColumn_OTS.Width = 49;
            // 
            // olvColumn_GRP
            // 
            this.olvColumn_GRP.Text = "GRP";
            this.olvColumn_GRP.Width = 45;
            // 
            // olvColumn_Type
            // 
            this.olvColumn_Type.Text = "Тип";
            this.olvColumn_Type.Width = 74;
            // 
            // olvColumn_Size
            // 
            this.olvColumn_Size.Text = "Разм.";
            // 
            // olvColumn_ID
            // 
            this.olvColumn_ID.Text = "ID";
            // 
            // olvColumn_Light
            // 
            this.olvColumn_Light.Text = "Св.";
            // 
            // toolStripBoards
            // 
            this.toolStripBoards.AutoSize = false;
            this.toolStripBoards.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBoards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStripBoards.Location = new System.Drawing.Point(0, 0);
            this.toolStripBoards.Name = "toolStripBoards";
            this.toolStripBoards.Size = new System.Drawing.Size(604, 32);
            this.toolStripBoards.TabIndex = 2;
            this.toolStripBoards.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadDoors});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(140, 29);
            this.toolStripDropDownButton1.Text = "Загрузка плоскостей";
            // 
            // btnLoadDoors
            // 
            this.btnLoadDoors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadDoors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadDoors.Image = global::BoardsMapper.Properties.Resources.INFOPANEL_24;
            this.btnLoadDoors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadDoors.Name = "btnLoadDoors";
            this.btnLoadDoors.Size = new System.Drawing.Size(220, 30);
            this.btnLoadDoors.Text = "Импорт номеров DOORS";
            this.btnLoadDoors.Click += new System.EventHandler(this.btnLoadDoors_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveKml,
            this.btnSaveHtml});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(139, 29);
            this.toolStripSplitButton1.Text = "Экспорт плоскостей";
            // 
            // btnSaveKml
            // 
            this.btnSaveKml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveKml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveKml.Image = global::BoardsMapper.Properties.Resources.Kmz_24;
            this.btnSaveKml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveKml.Name = "btnSaveKml";
            this.btnSaveKml.Size = new System.Drawing.Size(188, 30);
            this.btnSaveKml.Text = "Kmz (Google Earth)";
            this.btnSaveKml.Click += new System.EventHandler(this.btnSaveKml_Click);
            // 
            // btnSaveHtml
            // 
            this.btnSaveHtml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveHtml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveHtml.Image = global::BoardsMapper.Properties.Resources.Html_24;
            this.btnSaveHtml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveHtml.Name = "btnSaveHtml";
            this.btnSaveHtml.Size = new System.Drawing.Size(188, 30);
            this.btnSaveHtml.Text = "Html";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGeocoderSettings,
            this.btnBoardsReadSettings});
            this.toolStripSplitButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripSplitButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(86, 29);
            this.toolStripSplitButton2.Text = "Настройки";
            // 
            // btnGeocoderSettings
            // 
            this.btnGeocoderSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeocoderSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeocoderSettings.Name = "btnGeocoderSettings";
            this.btnGeocoderSettings.Size = new System.Drawing.Size(253, 22);
            this.btnGeocoderSettings.Text = "Google Api Key";
            this.btnGeocoderSettings.Click += new System.EventHandler(this.btnGeocoderSettings_Click);
            // 
            // btnBoardsReadSettings
            // 
            this.btnBoardsReadSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBoardsReadSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBoardsReadSettings.Name = "btnBoardsReadSettings";
            this.btnBoardsReadSettings.Size = new System.Drawing.Size(253, 22);
            this.btnBoardsReadSettings.Text = "Источники импорта плоскостей";
            this.btnBoardsReadSettings.Click += new System.EventHandler(this.btnBoardsReadSettings_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripSplitButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(70, 29);
            this.toolStripSplitButton3.Text = "Справка";
            // 
            // panelBoardsInfo
            // 
            this.panelBoardsInfo.Controls.Add(this.panelMap);
            this.panelBoardsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoardsInfo.Location = new System.Drawing.Point(0, 0);
            this.panelBoardsInfo.Name = "panelBoardsInfo";
            this.panelBoardsInfo.Size = new System.Drawing.Size(579, 665);
            this.panelBoardsInfo.TabIndex = 2;
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Moccasin;
            this.panelMap.Controls.Add(this.webBrowser1);
            this.panelMap.Controls.Add(this.toolStripMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(579, 665);
            this.panelMap.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(579, 633);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStripMap
            // 
            this.toolStripMap.AutoSize = false;
            this.toolStripMap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDrawMap,
            this.btnSaveMapScreen,
            this.btnSaveMapClipboard,
            this.toolStripSeparator2,
            this.btnColorProviderDialog});
            this.toolStripMap.Location = new System.Drawing.Point(0, 0);
            this.toolStripMap.Name = "toolStripMap";
            this.toolStripMap.Size = new System.Drawing.Size(579, 32);
            this.toolStripMap.TabIndex = 3;
            this.toolStripMap.Text = "toolStrip1";
            // 
            // btnDrawMap
            // 
            this.btnDrawMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDrawMap.Image = global::BoardsMapper.Properties.Resources.Map_24;
            this.btnDrawMap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDrawMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDrawMap.Name = "btnDrawMap";
            this.btnDrawMap.Size = new System.Drawing.Size(28, 29);
            this.btnDrawMap.Text = "Рисовать карту";
            this.btnDrawMap.Click += new System.EventHandler(this.btnDrawMap_Click);
            // 
            // btnSaveMapScreen
            // 
            this.btnSaveMapScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveMapScreen.Image = global::BoardsMapper.Properties.Resources.Save_24;
            this.btnSaveMapScreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveMapScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveMapScreen.Name = "btnSaveMapScreen";
            this.btnSaveMapScreen.Size = new System.Drawing.Size(28, 29);
            this.btnSaveMapScreen.Text = "Сохранить скриншот карты";
            this.btnSaveMapScreen.Click += new System.EventHandler(this.btnSaveMapScreen_Click);
            // 
            // btnSaveMapClipboard
            // 
            this.btnSaveMapClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveMapClipboard.Image = global::BoardsMapper.Properties.Resources.Clipboard_24;
            this.btnSaveMapClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveMapClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveMapClipboard.Name = "btnSaveMapClipboard";
            this.btnSaveMapClipboard.Size = new System.Drawing.Size(28, 29);
            this.btnSaveMapClipboard.Text = "Скриншот карты в буфер";
            this.btnSaveMapClipboard.Click += new System.EventHandler(this.btnSaveMapClipboard_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btnColorProviderDialog
            // 
            this.btnColorProviderDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColorProviderDialog.Image = global::BoardsMapper.Properties.Resources.Color_24;
            this.btnColorProviderDialog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnColorProviderDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColorProviderDialog.Name = "btnColorProviderDialog";
            this.btnColorProviderDialog.Size = new System.Drawing.Size(28, 29);
            this.btnColorProviderDialog.Text = "Цветовая схема";
            this.btnColorProviderDialog.Click += new System.EventHandler(this.btnColorProviderDialog_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelBoards);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelBoardsInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 665);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.TabIndex = 3;
            // 
            // WindowBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 665);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WindowBoards";
            this.Text = "BoardsMapper";
            this.panelBoards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvBoards)).EndInit();
            this.toolStripBoards.ResumeLayout(false);
            this.toolStripBoards.PerformLayout();
            this.panelBoardsInfo.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.toolStripMap.ResumeLayout(false);
            this.toolStripMap.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoards;
        private System.Windows.Forms.Panel panelBoardsInfo;
        private BrightIdeasSoftware.FastObjectListView olvBoards;
        private BrightIdeasSoftware.OLVColumn olvColumn_Code;
        private BrightIdeasSoftware.OLVColumn olvColumn_Side;
        private BrightIdeasSoftware.OLVColumn olvColumn_Supplier;
        private BrightIdeasSoftware.OLVColumn olvColumn_Street;
        private BrightIdeasSoftware.OLVColumn olvColumn_StreetNumber;
        private BrightIdeasSoftware.OLVColumn olvColumn_OTS;
        private BrightIdeasSoftware.OLVColumn olvColumn_GRP;
        private BrightIdeasSoftware.OLVColumn olvColumn_Type;
        private BrightIdeasSoftware.OLVColumn olvColumn_Size;
        private BrightIdeasSoftware.OLVColumn olvColumn_ID;
        private BrightIdeasSoftware.OLVColumn olvColumn_Light;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BrightIdeasSoftware.OLVColumn olvColumn_Town;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStripBoards;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnLoadDoors;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem btnSaveKml;
        private System.Windows.Forms.ToolStripMenuItem btnSaveHtml;
        private System.Windows.Forms.ToolStripMenuItem btnGeocoderSettings;
        private System.Windows.Forms.ToolStripMenuItem btnBoardsReadSettings;
        private System.Windows.Forms.ToolStrip toolStripMap;
        private System.Windows.Forms.ToolStripButton btnDrawMap;
        private System.Windows.Forms.ToolStripButton btnSaveMapScreen;
        private System.Windows.Forms.ToolStripButton btnSaveMapClipboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnColorProviderDialog;
    }
}

