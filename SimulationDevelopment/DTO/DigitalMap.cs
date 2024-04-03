using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationDevelopment.DTO
{
    public class DigitalMap
    {

        public DigitalMap(int Id, string TenBanDo, string MoTa, string FilePath, string ToaDo, string KichThuoc)
        {
            this.Id = Id;
            this.TenBanDo = TenBanDo;
            this.MoTa = MoTa;   
            this.FilePath = FilePath;
            this.ToaDo = ToaDo;
            this.KichThuoc = KichThuoc;
        }
        public DigitalMap(DataRow row)
        {
            int IdParse;
            if(!int.TryParse(row["ID"].ToString(), out IdParse))
            {
                this.Id = 0;
            }
            else
            {
                this.Id = IdParse;
            }
            this.TenBanDo = row["TenBanDo"].ToString();
            this.MoTa = row["MoTa"].ToString(); 
            this.FilePath = row["FilePath"].ToString();
            this.FilePath = row["ToaDo"].ToString();
            this.FilePath = row["KichThuoc"].ToString();
        }
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _TenBanDo;
        public string TenBanDo
        {
            get { return _TenBanDo; }
            set { _TenBanDo = value; }
        }

        private string _MoTa;
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        private string _FilePath;
        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }
        private string _ToaDo;
        public string ToaDo
        {
            get { return _ToaDo; }
            set { _ToaDo = value; }
        }
        private string _KichThuoc;
        public string KichThuoc
        {
            get { return _KichThuoc; }
            set { _KichThuoc = value; }
        }

    }
}
