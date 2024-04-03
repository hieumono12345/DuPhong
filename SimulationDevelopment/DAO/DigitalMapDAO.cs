using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationDevelopment.DTO;

namespace SimulationDevelopment.DAO
{
    public class DigitalMapDAO
    {
        private static DigitalMapDAO instance;

        public static DigitalMapDAO Instance
        {
            get { if (instance == null) instance = new DigitalMapDAO(); return instance; }
            private set { instance = value; }
        }

        private DigitalMapDAO() { }

        public DataTable getAllDigitaMap()
        {
            string query = "Select * from DigitalMap";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public DigitalMap GetDigitalMapById(int id)
        {
            List<DigitalMap> list = new List<DigitalMap>();

            string query = "Select * from DigitalMap where ID =" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DigitalMap a = new DigitalMap(item);
                list.Add(a);
            }

            if (list.Count == 0)
                return null;
            return list[0];
        }

        /*public DataTable getDSDaPhanCongTrongThang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER (ORDER BY MaGac) AS 'STT',a.Dap,a.Hoi,a.MaGac,a.Ngay,a.NhacNho,b.TenDV from NoiDungGac a, DonVi b where a.MaDV=b.MaDV");
            return data;
        }
        public NoiDungGac getNoiDungGac(int id)
        {

            List<NoiDungGac> list = new List<NoiDungGac>();

            string query = "SELECT ROW_NUMBER() OVER (ORDER BY MaGac) AS 'STT',a.Dap,a.Hoi,a.MaGac,a.Ngay,a.NhacNho,b.TenDV from NoiDungGac a, DonVi b where a.MaDV=b.MaDV and a.MaGac=" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NoiDungGac a = new NoiDungGac(item);
                list.Add(a);
            }

            return list[0];
        }
        public soLuongConLai getSoLuong(int maDV, string Ngay, string TGBD)
        {

            List<soLuongConLai> list = new List<soLuongConLai>();


            string query = "usp_soluongconlai @madv=" + maDV + " , @ngay='" + Ngay + "' , @TGBD=  '" + TGBD + "'";


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                soLuongConLai a = new soLuongConLai(item);
                list.Add(a);
            }

            return list[0];
        }
        public bool themLichGac(string Ngay, string hoi, string dap, int maDV, string nhacNho)

        {

            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_ThemLichGac @ngay , @hoi , @dap , @MaDV , @NhacNho ", new object[] { Ngay, hoi, dap, maDV, nhacNho });
            //int result = DataProvider.Instance.ExecuteNonQuery("exec USP_ThemLichGac @ngay='" + Ngay + "', @hoi='" + hoi"', @dap='" + dap + "', @MaDV='" + maDV + "', @NhacNho='" + nhacNho + "'");

            return result > 0;
        }

        internal void themLichGac(DateTime dateTime, string text1, string text2, int selectedValue)
        {
            throw new NotImplementedException();
        }*/
    }
}
