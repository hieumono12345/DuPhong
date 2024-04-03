namespace SimulationDevelopment.GUI
{
    partial class ucDigitalMapManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDigitalMapManagement));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDigitalMap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBanDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToaDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhichThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.FilePathImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtFilePath = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilePath = new DevExpress.XtraEditors.SimpleButton();
            this.txtKichThuoc = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToaDo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBanDo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcDigitalMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKichThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToaDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBanDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bản đồ số";
            // 
            // gcDigitalMap
            // 
            this.gcDigitalMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcDigitalMap.Location = new System.Drawing.Point(51, 109);
            this.gcDigitalMap.MainView = this.gridView1;
            this.gcDigitalMap.Name = "gcDigitalMap";
            this.gcDigitalMap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.gcDigitalMap.Size = new System.Drawing.Size(1388, 866);
            this.gcDigitalMap.TabIndex = 1;
            this.gcDigitalMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenBanDo,
            this.MoTa,
            this.FilePath,
            this.ToaDo,
            this.KhichThuoc,
            this.chiTiet,
            this.FilePathImg});
            this.gridView1.GridControl = this.gcDigitalMap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 50;
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 50;
            // 
            // TenBanDo
            // 
            this.TenBanDo.Caption = "Tên bản đồ";
            this.TenBanDo.FieldName = "TenBanDo";
            this.TenBanDo.MaxWidth = 250;
            this.TenBanDo.MinWidth = 25;
            this.TenBanDo.Name = "TenBanDo";
            this.TenBanDo.Visible = true;
            this.TenBanDo.VisibleIndex = 1;
            this.TenBanDo.Width = 250;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Mô tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.MaxWidth = 250;
            this.MoTa.MinWidth = 25;
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 2;
            this.MoTa.Width = 250;
            // 
            // FilePath
            // 
            this.FilePath.Caption = "Đường dẫn file bản đồ";
            this.FilePath.FieldName = "FilePath";
            this.FilePath.MaxWidth = 250;
            this.FilePath.MinWidth = 25;
            this.FilePath.Name = "FilePath";
            this.FilePath.Visible = true;
            this.FilePath.VisibleIndex = 3;
            this.FilePath.Width = 94;
            // 
            // ToaDo
            // 
            this.ToaDo.Caption = "Tọa độ";
            this.ToaDo.FieldName = "ToaDo";
            this.ToaDo.MaxWidth = 250;
            this.ToaDo.MinWidth = 25;
            this.ToaDo.Name = "ToaDo";
            this.ToaDo.Visible = true;
            this.ToaDo.VisibleIndex = 4;
            this.ToaDo.Width = 224;
            // 
            // KhichThuoc
            // 
            this.KhichThuoc.Caption = "Kích thước (m)";
            this.KhichThuoc.FieldName = "KichThuoc";
            this.KhichThuoc.MaxWidth = 250;
            this.KhichThuoc.MinWidth = 25;
            this.KhichThuoc.Name = "KhichThuoc";
            this.KhichThuoc.Visible = true;
            this.KhichThuoc.VisibleIndex = 5;
            this.KhichThuoc.Width = 250;
            // 
            // chiTiet
            // 
            this.chiTiet.Caption = "Chi tiết";
            this.chiTiet.ColumnEdit = this.btnDetail;
            this.chiTiet.FieldName = "chiTiet";
            this.chiTiet.MaxWidth = 75;
            this.chiTiet.MinWidth = 25;
            this.chiTiet.Name = "chiTiet";
            this.chiTiet.Visible = true;
            this.chiTiet.VisibleIndex = 6;
            // 
            // btnDetail
            // 
            this.btnDetail.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FilePathImg
            // 
            this.FilePathImg.Caption = "File Path Img";
            this.FilePathImg.FieldName = "FilePathImg";
            this.FilePathImg.MinWidth = 25;
            this.FilePathImg.Name = "FilePathImg";
            this.FilePathImg.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtFilePath);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.btnFilePath);
            this.panelControl1.Controls.Add(this.txtKichThuoc);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txtToaDo);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtMoTa);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtTenBanDo);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Location = new System.Drawing.Point(1445, 663);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(538, 312);
            this.panelControl1.TabIndex = 2;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(162, 261);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFilePath.Properties.Appearance.Options.UseFont = true;
            this.txtFilePath.Size = new System.Drawing.Size(314, 26);
            this.txtFilePath.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đường dẫn:";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePath.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFilePath.Appearance.Options.UseFont = true;
            this.btnFilePath.Location = new System.Drawing.Point(482, 260);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(39, 27);
            this.btnFilePath.TabIndex = 8;
            this.btnFilePath.Text = " ... ";
            this.btnFilePath.ToolTip = "Chọn thay đường dẫn khác";
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKichThuoc.Location = new System.Drawing.Point(162, 209);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtKichThuoc.Properties.Appearance.Options.UseFont = true;
            this.txtKichThuoc.Size = new System.Drawing.Size(359, 26);
            this.txtKichThuoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kích thước:";
            // 
            // txtToaDo
            // 
            this.txtToaDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToaDo.Location = new System.Drawing.Point(162, 159);
            this.txtToaDo.Name = "txtToaDo";
            this.txtToaDo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtToaDo.Properties.Appearance.Options.UseFont = true;
            this.txtToaDo.Size = new System.Drawing.Size(359, 26);
            this.txtToaDo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tọa độ:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoTa.Location = new System.Drawing.Point(162, 108);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Size = new System.Drawing.Size(359, 26);
            this.txtMoTa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // txtTenBanDo
            // 
            this.txtTenBanDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBanDo.Location = new System.Drawing.Point(162, 53);
            this.txtTenBanDo.Name = "txtTenBanDo";
            this.txtTenBanDo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTenBanDo.Properties.Appearance.Options.UseFont = true;
            this.txtTenBanDo.Size = new System.Drawing.Size(359, 26);
            this.txtTenBanDo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bản đồ:";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.pictureBoxMap);
            this.panelControl2.Location = new System.Drawing.Point(1445, 109);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(538, 548);
            this.panelControl2.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(482, 521);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 27);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "...";
            this.simpleButton1.ToolTip = "Thay đổi ảnh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMap.Location = new System.Drawing.Point(18, 14);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(503, 506);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1588, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thông tin bản đồ";
            // 
            // ucDigitalMapManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDigitalMap);
            this.Controls.Add(this.label1);
            this.Name = "ucDigitalMapManagement";
            this.Size = new System.Drawing.Size(1986, 989);
            ((System.ComponentModel.ISupportInitialize)(this.gcDigitalMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKichThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToaDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBanDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDigitalMap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenBanDo;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn ToaDo;
        private DevExpress.XtraGrid.Columns.GridColumn KhichThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn chiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenBanDo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKichThuoc;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtToaDo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnFilePath;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn FilePath;
        private DevExpress.XtraEditors.TextEdit txtFilePath;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private DevExpress.XtraGrid.Columns.GridColumn FilePathImg;
        private System.Windows.Forms.Label label7;
    }
}
