using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationDevelopment.DTO
{
    public class History
    {
        public History(int ID, int IDMap, int IDTranChien, int ThoiDiem, int IDNguoiLinh, int IDTrangThai, float KinhDo, float ViDo, int IDTeam)
        {
            this.ID = ID;
            this.IDMap = IDMap;
            this.IDTranChien = IDTranChien;
            this.ThoiDiem = ThoiDiem;
            this.IDNguoiLinh = IDNguoiLinh;
            this.IDTrangThai = IDTrangThai;
            this.KinhDo = KinhDo;
            this.ViDo = ViDo;
            this.IDTeam = IDTeam;
        }

        public History(DataRow row)
        {
            int IdParse;
            if (!int.TryParse(row["ID"].ToString(), out IdParse))
            {
                this.ID = 0;
            }
            else
            {
                this.ID = IdParse;
            }
            int IDMapParse;
            if (!int.TryParse(row["IDMap"].ToString(), out IDMapParse))
            {
                this.IDMap = 0;
            }
            else
            {
                this.IDMap = IDMapParse;
            }
            int IDTranChienParse;
            if (!int.TryParse(row["IDTranChien"].ToString(), out IDTranChienParse))
            {
                this.IDTranChien = 0;
            }
            else
            {
                this.IDTranChien = IDTranChienParse;
            }
            int ThoiDiemParse;
            if (!int.TryParse(row["ThoiDiem"].ToString(), out ThoiDiemParse))
            {
                this.ThoiDiem = 0;
            }
            else
            {
                this.ThoiDiem = ThoiDiemParse;
            }
            int IDNguoiLinhParse;
            if (!int.TryParse(row["IDNguoiLinh"].ToString(), out IDNguoiLinhParse))
            {
                this.IDNguoiLinh = 0;
            }
            else
            {
                this.IDNguoiLinh = IDNguoiLinhParse;
            }
            int IDTrangThaiParse;
            if (!int.TryParse(row["IDTrangThai"].ToString(), out IDTrangThaiParse))
            {
                this.IDTrangThai = 0;
            }
            else
            {
                this.IDTrangThai = IDTrangThaiParse;
            }
            float KinhDoParse;
            if (!float.TryParse(row["KinhDo"].ToString(), out KinhDoParse))
            {
                this.KinhDo = 0;
            }
            else
            {
                this.KinhDo = KinhDoParse;
            }
            float ViDoParse;
            if (!float.TryParse(row["ViDo"].ToString(), out ViDoParse))
            {
                this.ViDo = 0;
            }
            else
            {
                this.ViDo = ViDoParse;
            }
            int IDTeamParse;
            if (!int.TryParse(row["IDTeam"].ToString(), out IDTeamParse))
            {
                this.IDTeam = 0;
            }
            else
            {
                this.IDTeam = IDTeamParse;
            }
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private int _IDMap;
        public int IDMap
        {
            get { return _IDMap; }
            set { _IDMap = value; }
        }
        private int _IDTranChien;
        public int IDTranChien
        {
            get { return _IDTranChien; }
            set { _IDTranChien = value; }
        }
        private int _ThoiDiem;
        public int ThoiDiem
        {
            get { return _ThoiDiem; }
            set { _ThoiDiem = value; }
        }
        private int _IDNguoiLinh;
        public int IDNguoiLinh
        {
            get { return _IDNguoiLinh; }
            set { _IDNguoiLinh = value; }
        }
        private int _IDTrangThai;
        public int IDTrangThai
        {
            get { return _IDTrangThai; }
            set { _IDTrangThai = value; }
        }
        private float _KinhDo;
        public float KinhDo
        {
            get { return _KinhDo; }
            set { _KinhDo = value; }
        }
        private float _ViDo;
        public float ViDo
        {
            get { return _ViDo; }
            set { _ViDo = value; }
        }
        private int _IDTeam;
        public int IDTeam
        {
            get { return _IDTeam; }
            set { _IDTeam = value; }
        }
    }
}
