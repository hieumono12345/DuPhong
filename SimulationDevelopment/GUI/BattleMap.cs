using DevExpress.XtraEditors;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using SimulationDevelopment.DAO;
using SimulationDevelopment.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FluentDesignForm.Properties;

namespace SimulationDevelopment.GUI
{
    public partial class BattleMap : DevExpress.XtraEditors.XtraForm
    {
        private GMapOverlay markersOverlay;
        private List<History> listAlllHistory;
        string thoiGianMax;
        public BattleMap()
        {
            InitializeComponent();
            setMaxTaskbar();
            initMap();
            lbTime.Text = "00:00:00/" + thoiGianMax;
        }

        // Khởi tạo map
        private void initMap()
        {
            map.DragButton = MouseButtons.Left;
            map.Position = new PointLatLng(21.0285, 105.8342);
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 10;
            map.MaxZoom = 25;
            map.Zoom = 19;
            map.ShowCenter = false;
            markersOverlay = new GMapOverlay("markers");
            map.Overlays.Add(markersOverlay);
        }

        //set độ dài cho trackBarCombatMap
        private void setMaxTaskbar()
        {
            trackBarCombatMap.Maximum = HistoryDAO.Instance.getDoChia() +1;
            //trackBarCombatMap.Maximum = 6000;
            thoiGianMax = ConvertMillisecondsToTimeString(trackBarCombatMap.Maximum -1);
        }

        // Xử lý sự kiện khi giá trị của trackBarCombatMap thay đổi
        private string ConvertMillisecondsToTimeString(int milliseconds)
        {
            // Chuyển đổi milliseconds thành TimeSpan
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(milliseconds * 1000);

            // Format chuỗi theo dạng "hh:mm:ss"
            string timeString = $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";

            return timeString;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            // nếu đang dừng lại thì chạy
            if (timer.Enabled == false)
            {
                timer.Start();
                btnStartStop.Text = "Tạm dừng";
            }
            else
            {
                timer.Stop();
                btnStartStop.Text = "Bắt đầu";
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            // nếu giá trị của trackBarCombatMap đạt giá trị lớn nhất thì dừng lại
            if (trackBarCombatMap.Value == trackBarCombatMap.Maximum )//
            {
                timer.Stop();
                btnStartStop.Text = "Bắt đầu";
                trackBarCombatMap.Value = 1;
            }
            // tăng giá trị của trackBarCombatMap lên 1
            else
            {
                DrawNguoiLinhTaiThoiDiem(trackBarCombatMap.Value);
                if (trackBarCombatMap.Value %1 == 0)
                {                    
                    lbTime.Text = ConvertMillisecondsToTimeString(trackBarCombatMap.Value) + "/" + thoiGianMax;
                }
                
                trackBarCombatMap.Value++;
            }
        }

        private void DrawNguoiLinhTaiThoiDiem(int ThoiDiem)
        {
            List<History> list = HistoryDAO.Instance.GetHistoriesByThoiDiem(ThoiDiem);

            // Xóa tất cả các marker cũ từ markersOverlay
            markersOverlay.Markers.Clear();

            // Tạo list chứa các điểm và kiểu màu tương ứng
            var points = new List<(PointLatLng, GMarkerGoogleType)>();
            foreach (History item in list)
            {
                if (item.IDTeam == 1)
                {
                    switch (item.IDTrangThai)
                    {
                        case 1://nếu hiện tại sống
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.green));
                            break;
                        case 2:// nếu hiện tại bị thương
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.red));
                            break;
                        case 3:// nếu hi sinh
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.black_small));
                            break;
                    }
                }
                else
                {
                    switch (item.IDTrangThai)
                    {
                        case 1://nếu hiện tại sống
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.blue));
                            break;
                        case 2:// nếu hiện tại bị thương
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.orange));
                            break;
                        case 3:// nếu hi sinh
                            points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.brown_small));
                            break;
                    }
                }
            }

            // Với mỗi điểm, tạo marker và thêm vào markersOverlay
            foreach (var point in points)
            {
                var marker = new GMarkerGoogle(point.Item1, point.Item2);
                markersOverlay.Markers.Add(marker);
            }

            // Gọi Refresh để hiển thị thay đổi
            map.Refresh();
        }

        private void btnReLocation_Click(object sender, EventArgs e)
        {
            map.Position = new PointLatLng(21.0285, 105.8342);
            map.Zoom = 19;
        }

        //Test --------------------------------------------------------------

        public const double k = Math.PI / 180d; // degrees to radians
        public PointLatLng MidPoint(PointLatLng point1, PointLatLng point2)
        {
            // Returns the half-way point along a great circle path between the two points.
            // https://www.movable-type.co.uk/scripts/latlong.html

            // Bx = cos φ2 ⋅ cos Δλ
            // By = cos φ2 ⋅ sin Δλ
            // φm = atan2(sin φ1 + sin φ2, √(cos φ1 + Bx)² +By² )
            // λm = λ1 + atan2(By, cos(φ1) + Bx)

            double φ1 = point1.Lat * k;
            double λ1 = point1.Lng * k;
            double φ2 = point2.Lat * k;
            double λ2 = point2.Lng * k;

            double Bx = Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            double By = Math.Cos(φ2) * Math.Sin(λ2 - λ1);
            double φm = Math.Atan2(Math.Sin(φ1) + Math.Sin(φ2),
                Math.Sqrt(Math.Pow((Math.Cos(φ1) + Bx), 2d) + By * By));
            double λm = λ1 + Math.Atan2(By, Math.Cos(φ1) + Bx);
            return new PointLatLng(φm / k, λm / k);
        }

        //Calculate Bearing:

        public double Bearing(PointLatLng point1, PointLatLng point2)
        {
            // returns bearing between to points in radians
            // https://www.movable-type.co.uk/scripts/latlong.html

            // θ = atan2(sin Δλ ⋅ cos φ2, cos φ1 ⋅ sin φ2 − sin φ1 ⋅ cos φ2 ⋅ cos Δλ)

            double φ1 = point1.Lat * k;
            double λ1 = point1.Lng * k;
            double φ2 = point2.Lat * k;
            double λ2 = point2.Lng * k;
            double y = Math.Sin(λ2 - λ1) * Math.Cos(φ2);
            double x = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            return Math.Atan2(y, x);
        }
        //Rotating Shape:

        public Bitmap RotateShape(Bitmap shape, double angle) // angle in radians
        {
            Bitmap bmp = new Bitmap(shape.Width, shape.Height);
            bmp.SetResolution(shape.HorizontalResolution, shape.VerticalResolution);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.TranslateTransform(shape.Width / 2, shape.Height / 2);
                g.RotateTransform((float)(angle / k));
                g.TranslateTransform(-shape.Width / 2, -shape.Height / 2);
                g.DrawImage(shape, new Point(0, 0));
            }
            return bmp;
        }

        //Sample Data:

        PointLatLng[] coords = new PointLatLng[]
        {
            new PointLatLng(22.314829392513598, 114.05459908390375),
            new PointLatLng(22.314861593596778, 114.05412482777214),
            new PointLatLng(22.314644236141167, 114.05375064403528),
            new PointLatLng(22.314535557286437, 114.05350263853526),
            new PointLatLng(22.313847255908490, 114.05338951321947),
            new PointLatLng(22.313706375091120, 114.05441199203533),
            new PointLatLng(22.313223354066515, 114.05435978035109),
            new PointLatLng(22.313162976320920, 114.05468610337743),
            new PointLatLng(22.313122724476038, 114.05478182479850),
            new PointLatLng(22.312893288738540, 114.05462083877217),
            new PointLatLng(22.312720205388830, 114.05442504495637),
            new PointLatLng(22.312893288738540, 114.05322852719314),
            new PointLatLng(22.313142850399935, 114.05328073887735)
        };

        //Drawing the route with a direction inserted at mid-points of each segment and alignd to segment angle:

        private void draw_path()
        {
            map.MapProvider = GMapProviders.GoogleMap; ;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            GMapOverlay routeLayer = new GMapOverlay("routes");
            GMapRoute route = new GMapRoute(coords, string.Empty);
            routeLayer.Routes.Add(route);
            map.Overlays.Add(routeLayer);

            GMapOverlay markersLayer = new GMapOverlay("markers");
            markersLayer.Id = "markers";

            GMarkerGoogle gm_start = new GMarkerGoogle(coords[0], GMarkerGoogleType.red);
            gm_start.ToolTipText = "Start";
            gm_start.ToolTipMode = MarkerTooltipMode.Always;
            markersLayer.Markers.Add(gm_start);

            GMarkerGoogle gm_end = new GMarkerGoogle(coords[coords.Length - 1], GMarkerGoogleType.red);
            gm_end.ToolTipText = "End";
            gm_end.ToolTipMode = MarkerTooltipMode.Always;
            markersLayer.Markers.Add(gm_end);

            for (int i = 1; i < coords.Length; i++)
            {
                /*using (Bitmap arrow = Resources.a1)
                {
                    GMarkerGoogle gm = new GMarkerGoogle(
                        p: MidPoint(coords[i - 1], coords[i]),
                        RotateShape(arrow, (float)(Bearing(coords[i - 1], coords[i])))
                        ) ;
                    gm.Offset = new Point(-arrow.Width / 2, -arrow.Height / 2);
                    markersLayer.Markers.Add(gm);
                }*/
            }

            map.Overlays.Add(markersLayer);
            map.ZoomAndCenterRoute(route);
        }


    }
}