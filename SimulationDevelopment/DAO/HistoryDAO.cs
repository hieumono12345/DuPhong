using DevExpress.ClipboardSource.SpreadsheetML;
using SimulationDevelopment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SimulationDevelopment.DAO
{
    public class HistoryDAO
    {
        private static HistoryDAO instance;

        public static HistoryDAO Instance
        {
            get { if (instance == null) instance = new HistoryDAO(); return instance; }
            private set { instance = value; }
        }

        private HistoryDAO() { }

        public List<History> GetHistoriesByThoiDiem(int thoiDiem)
        {
            List<History> list = new List<History>();

            string query = "Select * from History where ThoiDiem = " + thoiDiem;

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (System.Data.DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }

            return list;
        }

        //phải sửa lại thêm paramater là IDtranChien
        public int getDoChia()
        {
            string query = "select count(*) AS DoChia from (select ThoiDiem from History where IDTranChien=1 Group by ThoiDiem) as a";
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);
            //return data.Rows[0].Field<int>(0);this.TenBanDo = row["TenBanDo"].ToString();
            int DoChia=0;
            foreach(System.Data.DataRow item in data.Rows)
            {
                int DoChiaParse;
                if (!int.TryParse(item["DoChia"].ToString(), out DoChiaParse))
                {
                    DoChia = 0;
                }
                else
                {
                    DoChia = DoChiaParse;
                }
                /*History history = new History(item);
                list.Add(history);*/
            }
            return DoChia;
        }

        // Lấy danh sách ng lính tại thời điểm đầu tiên
        public List<History> GetHistoriesByThoiDiemDauTien()
        {
            List<History> list = new List<History>();

            string query = "Select * from History where ThoiDiem = 1";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (System.Data.DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }

            return list;
        }

        // lấy toàn bộ danh sách
        public List<History> GetAllHistories()
        {
            List<History> list = new List<History>();

            string query = "Select * from History";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (System.Data.DataRow item in data.Rows)
            {
                History history = new History(item);
                list.Add(history);
            }

            return list;
        }

        // lấy toàn bộ danh sách người lính của trận chiến
        public List<int> GetListNguoiLinhWithTranChien(int IDTranChiem)
        {
            List<int> list = new List<int>();

            string query = "select IDNguoiLinh from History Where IDTranChien="+IDTranChiem+" group by IDNguoiLinh";
            int IDNguoiLinh = 1;
            list.Add(-1);
            list.Add(0);
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (System.Data.DataRow item in data.Rows)
            {
                int DoChiaParse;
                if (!int.TryParse(item["IDNguoiLinh"].ToString(), out DoChiaParse))
                {
                    IDNguoiLinh = 1;
                }
                else
                {
                    IDNguoiLinh = DoChiaParse;
                }
                list.Add(IDNguoiLinh);
            }

            return list;
        }       
    }
}
