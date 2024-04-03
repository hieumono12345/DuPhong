namespace SimulationDevelopment
{
    partial class TestBattleMap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestBattleMap));
            this.trackBarCombatMap = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.cbTocDoPhat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnStartStop = new DevExpress.XtraEditors.SimpleButton();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReLocation = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowRoutes = new System.Windows.Forms.ComboBox();
            this.cbShowRoutes2 = new DevExpress.XtraScheduler.UI.ResourcesComboBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCombatMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTocDoPhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowRoutes2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarCombatMap
            // 
            this.trackBarCombatMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCombatMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarCombatMap.Location = new System.Drawing.Point(109, 593);
            this.trackBarCombatMap.Maximum = 100;
            this.trackBarCombatMap.Minimum = 1;
            this.trackBarCombatMap.Name = "trackBarCombatMap";
            this.trackBarCombatMap.Size = new System.Drawing.Size(1072, 56);
            this.trackBarCombatMap.TabIndex = 4;
            this.trackBarCombatMap.Value = 1;
            this.trackBarCombatMap.Scroll += new System.EventHandler(this.trackBarCombatMap_Scroll);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1187, 593);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(116, 16);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00:00/00:00:00";
            // 
            // cbTocDoPhat
            // 
            this.cbTocDoPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTocDoPhat.EditValue = "X 1";
            this.cbTocDoPhat.Location = new System.Drawing.Point(1007, 674);
            this.cbTocDoPhat.Name = "cbTocDoPhat";
            this.cbTocDoPhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTocDoPhat.Properties.Items.AddRange(new object[] {
            " X 0.5",
            " X 1",
            " X 1.5",
            " X 2"});
            this.cbTocDoPhat.Size = new System.Drawing.Size(73, 22);
            this.cbTocDoPhat.TabIndex = 8;
            this.cbTocDoPhat.SelectedIndexChanged += new System.EventHandler(this.cbTocDoPhat_SelectedIndexChanged);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartStop.Location = new System.Drawing.Point(884, 668);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(94, 29);
            this.btnStartStop.TabIndex = 9;
            this.btnStartStop.Text = "Bắt đầu";
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click_1);
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 65);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1339, 491);
            this.map.TabIndex = 10;
            this.map.Zoom = 0D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "BẢN ĐỒ";
            // 
            // btnReLocation
            // 
            this.btnReLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReLocation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReLocation.ImageOptions.Image")));
            this.btnReLocation.Location = new System.Drawing.Point(1189, 517);
            this.btnReLocation.Name = "btnReLocation";
            this.btnReLocation.Size = new System.Drawing.Size(162, 39);
            this.btnReLocation.TabIndex = 21;
            this.btnReLocation.Text = "Trở lại vị trí ban đầu";
            this.btnReLocation.ToolTip = "Quay về vị trí ban đầu";
            this.btnReLocation.ToolTipTitle = "Trở lại vị trí ban đầu";
            this.btnReLocation.Click += new System.EventHandler(this.btnReLocation_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(529, 668);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hiện đường đi:";
            // 
            // cbShowRoutes
            // 
            this.cbShowRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowRoutes.FormattingEnabled = true;
            this.cbShowRoutes.Location = new System.Drawing.Point(759, 646);
            this.cbShowRoutes.Name = "cbShowRoutes";
            this.cbShowRoutes.Size = new System.Drawing.Size(87, 24);
            this.cbShowRoutes.TabIndex = 26;
            // 
            // cbShowRoutes2
            // 
            this.cbShowRoutes2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowRoutes2.Location = new System.Drawing.Point(759, 674);
            this.cbShowRoutes2.Name = "cbShowRoutes2";
            this.cbShowRoutes2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShowRoutes2.Size = new System.Drawing.Size(87, 22);
            this.cbShowRoutes2.TabIndex = 27;
            // 
            // TestBattleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 713);
            this.Controls.Add(this.cbShowRoutes2);
            this.Controls.Add(this.cbShowRoutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnReLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cbTocDoPhat);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.trackBarCombatMap);
            this.Name = "TestBattleMap";
            this.Text = "Xem lại trận chiến";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCombatMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTocDoPhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowRoutes2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarCombatMap;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTime;
        private DevExpress.XtraEditors.ComboBoxEdit cbTocDoPhat;
        private DevExpress.XtraEditors.SimpleButton btnStartStop;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnReLocation;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShowRoutes;
        private DevExpress.XtraScheduler.UI.ResourcesComboBoxControl cbShowRoutes2;
    }
}