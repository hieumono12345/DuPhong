namespace SimulationDevelopment.GUI
{
    partial class BattleMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleMap));
            this.trackBarCombatMap = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnStartStop = new DevExpress.XtraEditors.SimpleButton();
            this.cbTocDoPhat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnReLocation = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCombatMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTocDoPhat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarCombatMap
            // 
            this.trackBarCombatMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCombatMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarCombatMap.Location = new System.Drawing.Point(133, 596);
            this.trackBarCombatMap.Maximum = 100;
            this.trackBarCombatMap.Minimum = 1;
            this.trackBarCombatMap.Name = "trackBarCombatMap";
            this.trackBarCombatMap.Size = new System.Drawing.Size(1021, 56);
            this.trackBarCombatMap.TabIndex = 14;
            this.trackBarCombatMap.Value = 1;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "BẢN ĐỒ";
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
            this.map.Location = new System.Drawing.Point(12, 68);
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
            this.map.TabIndex = 18;
            this.map.Zoom = 0D;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartStop.Location = new System.Drawing.Point(884, 671);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(94, 29);
            this.btnStartStop.TabIndex = 17;
            this.btnStartStop.Text = "Bắt đầu";
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // cbTocDoPhat
            // 
            this.cbTocDoPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTocDoPhat.EditValue = "X 1";
            this.cbTocDoPhat.Location = new System.Drawing.Point(1007, 677);
            this.cbTocDoPhat.Name = "cbTocDoPhat";
            this.cbTocDoPhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTocDoPhat.Properties.Items.AddRange(new object[] {
            " X 0.5",
            " X 0.75",
            " X 1",
            " X 1.25",
            " X 1.5",
            " X 2"});
            this.cbTocDoPhat.Size = new System.Drawing.Size(43, 22);
            this.cbTocDoPhat.TabIndex = 16;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1160, 596);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(14, 16);
            this.lbTime.TabIndex = 15;
            this.lbTime.Text = "1";
            // 
            // btnReLocation
            // 
            this.btnReLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReLocation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReLocation.ImageOptions.Image")));
            this.btnReLocation.Location = new System.Drawing.Point(1189, 520);
            this.btnReLocation.Name = "btnReLocation";
            this.btnReLocation.Size = new System.Drawing.Size(162, 39);
            this.btnReLocation.TabIndex = 20;
            this.btnReLocation.Text = "Trở lại vị trí ban đầu";
            this.btnReLocation.ToolTip = "Quay về vị trí ban đầu";
            this.btnReLocation.ToolTipTitle = "Trở lại vị trí ban đầu";
            this.btnReLocation.Click += new System.EventHandler(this.btnReLocation_Click);
            // 
            // BattleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 713);
            this.Controls.Add(this.btnReLocation);
            this.Controls.Add(this.trackBarCombatMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cbTocDoPhat);
            this.Controls.Add(this.lbTime);
            this.Name = "BattleMap";
            this.Text = "BattleMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCombatMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTocDoPhat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarCombatMap;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private GMap.NET.WindowsForms.GMapControl map;
        private DevExpress.XtraEditors.SimpleButton btnStartStop;
        private DevExpress.XtraEditors.ComboBoxEdit cbTocDoPhat;
        private System.Windows.Forms.Label lbTime;
        private DevExpress.XtraEditors.SimpleButton btnReLocation;
    }
}