using DevExpress.XtraEditors;
using GMap.NET.MapProviders;
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
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace SimulationDevelopment
{
    public partial class TestBattleMap : DevExpress.XtraEditors.XtraForm
    {
        private GMapOverlay markersOverlay;
        private List<History> listAlllHistory;
        string thoiGianMax;
        int ShowRoute = 0;
        int ShowLast = -2;
        bool isShowRoute = false;
        List<int> listIDNguoiLinh = new List<int>();
        public TestBattleMap()
        {
            InitializeComponent();
            setMaxTaskbar();
            initMap();
            lbTime.Text = "00:00:00/" + thoiGianMax;
            listAlllHistory = HistoryDAO.Instance.GetAllHistories();
            LoadDataComboBox();
            listIDNguoiLinh = HistoryDAO.Instance.GetListNguoiLinhWithTranChien(1);

        }

        // Load dữ liệu commbo box
        private void LoadDataComboBox()
        {
            Dictionary<int, string> list = HistoryDAO.Instance.GetListNguoiLinhWithTranChien(1)
                                              .ToDictionary(k => k, v => v == -1 ? "Hiện tất cả" : v == 0 ? "Ẩn tất cả" : "Người lính " + v.ToString());

            cbShowRoutes.DataSource = new BindingSource(list, null);
            cbShowRoutes.DisplayMember = "Value";
            cbShowRoutes.ValueMember = "Key";

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
            initNguoiLinh();
        }

        //set độ dài cho trackBarCombatMap
        private void setMaxTaskbar()
        {
            trackBarCombatMap.Maximum = HistoryDAO.Instance.getDoChia() + 1;
            thoiGianMax = ConvertMillisecondsToTimeString(trackBarCombatMap.Maximum - 1);
            trackBarCombatMap.Minimum = 1;
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

        private void btnStartStop_Click_1(object sender, EventArgs e)
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
                if (trackBarCombatMap.Value == trackBarCombatMap.Maximum)
                {
                    btnStartStop.Text = "Bắt đầu";
                } else
                {
                    btnStartStop.Text = "Tiếp tục";
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // nếu giá trị của trackBarCombatMap đạt giá trị lớn nhất thì dừng lại
            if (trackBarCombatMap.Value == trackBarCombatMap.Maximum)//
            {
                timer.Stop();
                btnStartStop.Text = "Bắt đầu";
                trackBarCombatMap.Value = 1;
            }
            // tăng giá trị của trackBarCombatMap lên 1
            else
            {
                DrawNguoiLinhTaiThoiDiem(trackBarCombatMap.Value);
                if (trackBarCombatMap.Value % 1 == 0)
                {
                    lbTime.Text = ConvertMillisecondsToTimeString(trackBarCombatMap.Value) + "/" + thoiGianMax;
                }
                //handleShowRoute(-1);
                if (isShowRoute)
                {
                    DrawRouteOfNguoiLinh(2, trackBarCombatMap.Value);
                }
                trackBarCombatMap.Value++;
            }
        }

        private void handleShowRoute(int mode, int ThoiDiem)
        {
            if (mode == ShowLast)
            {
                return;
            }

            switch (mode)
            {
                case -1:
                    ShowLast = -1;
                    foreach (int IDNguoiLinh in listIDNguoiLinh)
                    {
                        DrawRouteOfNguoiLinh(IDNguoiLinh, ThoiDiem);
                    }
                    break;
                case 0:
                    ShowLast = 0;
                    foreach (int IDNguoiLinh in listIDNguoiLinh)
                    {
                        RemoveRoutesByID(IDNguoiLinh);
                    }
                    break;
                default:
                    if (mode == ShowLast)
                    {
                        break;
                    }
                    RemoveRoutesByID(ShowLast);
                    ShowLast = mode;
                    DrawRouteOfNguoiLinh(mode, ThoiDiem);
                    break;
            }

        }


        private void DrawNguoiLinhTaiThoiDiem(int ThoiDiem)
        {
            List<History> list = HistoryDAO.Instance.GetHistoriesByThoiDiem(ThoiDiem);

            List<History> filteredList = listAlllHistory.Where(obj => obj.ThoiDiem == ThoiDiem).ToList();
            //List<MyObject> filteredList = myList.FindAll(obj => obj.IDTrangThai == 1);

            foreach (History item in filteredList)
            {
                XoaVaTaoLaiMarker(item.IDNguoiLinh, item.KinhDo, item.ViDo, item.IDTeam, item.IDTrangThai);
            }

        }

        private void cbTocDoPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTocDoPhat.SelectedText)
            {
                case (" X 1"):
                    timer.Interval = 100;
                    break;
                case " X 0.5":
                    timer.Interval = 200;
                    break;
                case " X 1.5":
                    timer.Interval = 67;
                    break;
                case " X 2":
                    timer.Interval = 50;
                    break;
            }
        }

        private void btnReLocation_Click(object sender, EventArgs e)
        {
            map.Position = new PointLatLng(21.0285, 105.8342);
            map.Zoom = 19;
        }

        // Khởi tạo danh sách người lính
        private void initNguoiLinh()
        {
            // lấy danh sach người lính tại thời điểm đầu tiên
            List<History> list = HistoryDAO.Instance.GetHistoriesByThoiDiemDauTien();

            // Tạo list chứa các điểm, kiểu màu và Id tương ứng
            var points = new List<(PointLatLng, GMarkerGoogleType, int)>();
            foreach (History item in list)
            {
                int markerId = item.IDNguoiLinh;

                if (item.IDTeam == 1)
                {
                    points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.green, markerId));
                }
                else
                {
                    points.Add((new PointLatLng(item.KinhDo, item.ViDo), GMarkerGoogleType.blue, markerId));
                }
            }

            // Thêm các marker vào markersOverlay
            foreach (var point in points)
            {
                var marker = new GMarkerGoogle(point.Item1, point.Item2);
                marker.Tag = point.Item3; // Gán ID cho marker
                markersOverlay.Markers.Add(marker);
            }

            // Gọi Refresh để hiển thị thay đổi
            map.Refresh();
        }

        private GMapMarker GetMarkerById(int markerId)
        {
            return markersOverlay.Markers.FirstOrDefault(marker => (int)marker.Tag == markerId);
        }

        // xóa và tạo lại maker

        public void XoaVaTaoLaiMarker(int id, double kinhDo, double viDo, int IDTeam, int IDTrangThai)
        {
            // Tìm marker có ID tương ứng
            GMapMarker existingMarker = GetMarkerById(id);


            // Nếu không tìm thấy marker
            if (existingMarker == null)
            {
                return;
            }

            // Xóa marker hiện tại
            markersOverlay.Markers.Remove(existingMarker);
            GMarkerGoogleType newMarkerType = GMarkerGoogleType.green;
            // tạo màu cho marker
            if (IDTeam == 1)
            {
                switch (IDTrangThai)
                {
                    case 1:
                        newMarkerType = GMarkerGoogleType.green;
                        break;
                    case 2:
                        newMarkerType = GMarkerGoogleType.red;
                        break;
                    case 3:
                        newMarkerType = GMarkerGoogleType.black_small;
                        break;
                }
            }
            else
            {
                switch (IDTrangThai)
                {
                    case 1:
                        newMarkerType = GMarkerGoogleType.blue;
                        break;
                    case 2:
                        newMarkerType = GMarkerGoogleType.orange;
                        break;
                    case 3:
                        newMarkerType = GMarkerGoogleType.brown_small;
                        break;
                }
            }

            // Tạo mới marker với tọa độ và kiểu mới
            GMarkerGoogle newMarker = new GMarkerGoogle(new PointLatLng(kinhDo, viDo), newMarkerType);
            newMarker.Tag = id; // Gán lại ID mới cho Tag

            // Thêm marker mới vào overlay
            markersOverlay.Markers.Add(newMarker);

            // Gọi Refresh bằng cách sử dụng Invoke để đảm bảo thao tác trên UI diễn ra trên luồng chính
            map.Invoke(new Action(() => map.Refresh()));
        }

        private void trackBarCombatMap_Scroll(object sender, EventArgs e)
        {
            DrawNguoiLinhTaiThoiDiem(sbyte.Parse(trackBarCombatMap.Value.ToString()));
        }

        Dictionary<int, List<GMapRoute>> routeDictionary = new Dictionary<int, List<GMapRoute>>();

        // Tạo một đường thẳng mới và thêm vào overlay và dictionary
        private void AddRoute(int routeID, List<PointLatLng> points)
        {
            GMapRoute route = new GMapRoute(points, "Route");
            markersOverlay.Routes.Add(route);

            if (!routeDictionary.ContainsKey(routeID))
            {
                routeDictionary.Add(routeID, new List<GMapRoute>());
            }
            routeDictionary[routeID].Add(route);
        }

        // Xóa tất cả các đường thẳng có cùng ID
        private void RemoveRoutesByID(int routeID)
        {
            if (!routeDictionary.ContainsKey(routeID))
            {
                return;
            }

            foreach (var route in routeDictionary[routeID].ToList())
            {
                markersOverlay.Routes.Remove(route);
                routeDictionary[routeID].Remove(route);
            }

            //map.Refresh();
        }

        // Lấy danh sách tọa độ đã đi qua của một người lính tại một thời điểm
        private List<PointLatLng> GetListPointLatLng(int IDNguoiLinh, int ThoiDiem)
        {
            return listAlllHistory
                    .Where(obj => obj.ThoiDiem <= ThoiDiem && obj.IDNguoiLinh == IDNguoiLinh)
                    .Select(item => new PointLatLng(item.KinhDo, item.ViDo))
                    .ToList();
        }

        // Vẽ đường đi của người lính tại một thời điểm
        private void DrawRouteOfNguoiLinh(int IDNguoiLinh, int ThoiDiem)
        {
            List<PointLatLng> points = GetListPointLatLng(IDNguoiLinh, ThoiDiem);
            RemoveRoutesByID(IDNguoiLinh);
            AddRoute(IDNguoiLinh, points);
        }

        //===============================================================================================

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //c1
            //DrawLineWithID(new PointLatLng(21.0278, 105.8342), new PointLatLng(21.0279, 105.8343), "YourRouteID");

            //c2
            //DrawLineWithID(new PointLatLng(21.0278, 105.8342), new PointLatLng(21.0279, 105.8343), new PointLatLng(21.0281, 105.8341),1);
            //DrawLineWithID(new PointLatLng(21.028, 105.834), new PointLatLng(21.0281, 105.8341), "YourRouteID");

            if (isShowRoute)
            {
                isShowRoute = false;
                
                RemoveRoutesByID(2);
            }
            else
            {
                isShowRoute = true;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int routeIDToDelete = 1; // ID của đường thẳng cần xóa
            RemoveRoutesByID(routeIDToDelete);
        }
    
        
    }
}