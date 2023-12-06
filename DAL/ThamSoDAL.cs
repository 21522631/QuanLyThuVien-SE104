using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThamSoDAL
    {
        private static ThamSoDAL instance;
        private ThamSoDAL() { }
        public static ThamSoDAL Instance 
        {
            get
            {
                if (instance == null) instance = new ThamSoDAL();
                return instance;
            }
            private set => instance = value;
        }
        public ThamSo GetThamSo()
        {
            ThamSo thamso = new ThamSo();
            DataTable data = new DataTable();
            string query = "SELECT * FROM THAMSO";
            data = DataProvider.Instance.ExecuteQuery(query);
            thamso.ID = Convert.ToInt32(data.Rows[0]["ID"].ToString());
            thamso.TuoiToiThieu = Convert.ToInt32(data.Rows[0]["TUOITOITHIEU"].ToString());
            thamso.TuoiToiDa = Convert.ToInt32(data.Rows[0]["TUOITOIDA"].ToString());
            thamso.ThoiHanThe = Convert.ToInt32(data.Rows[0]["THOIHANTHE"].ToString());
            thamso.KhoangCachNamXB = Convert.ToInt32(data.Rows[0]["KHOANGCACHNAMXB"].ToString());
            thamso.SoNgayMuonToiDa = Convert.ToInt32(data.Rows[0]["SONGAYMUONTOIDA"].ToString());
            thamso.SoSachMuonToiDa = Convert.ToInt32(data.Rows[0]["SOSACHMUONTOIDA"].ToString());
            thamso.DonGiaPhat = Convert.ToInt32(data.Rows[0]["DONGIAPHAT"].ToString());
            thamso.ApDungQDTienThu = Convert.ToInt32(data.Rows[0]["APDUNGQDTIENTHU"].ToString());
            return thamso;
        }
    }
}
