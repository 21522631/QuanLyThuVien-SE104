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
            thamso.ID = Convert.ToInt32(data.Rows[0][0].ToString());
            thamso.TuoiToiThieu = Convert.ToInt32(data.Rows[0][1].ToString());
            thamso.TuoiToiDa = Convert.ToInt32(data.Rows[0][2].ToString());
            thamso.ThoiHanThe = Convert.ToInt32(data.Rows[0][3].ToString());
            thamso.KhoangCachNamXB = Convert.ToInt32(data.Rows[0][4].ToString());
            thamso.SoNgayMuonToiDa = Convert.ToInt32(data.Rows[0][5].ToString());
            thamso.SoSachMuonToiDa = Convert.ToInt32(data.Rows[0][6].ToString());
            thamso.DonGiaPhat = Convert.ToInt32(data.Rows[0][7].ToString());
            thamso.ApDungQDTienThu = Convert.ToInt32(data.Rows[0][8].ToString());
            return thamso;
        }
        public int UpdateThamSo(ThamSo thamso)
        {
            string query = "UPDATE THAMSO SET TUOITOITHIEU = '" + thamso.TuoiToiThieu + "', TUOITOIDA = '" + thamso.TuoiToiDa + "', DONGIAPHAT = '" + thamso.DonGiaPhat + "', APDUNGQDTIENTHU = '" + thamso.ApDungQDTienThu +
                           "', THOIHANTHE = '" + thamso.ThoiHanThe + "', KHOANGCACHNAMXB = '" + thamso.KhoangCachNamXB + "', SONGAYMUONTOIDA = '" + thamso.SoNgayMuonToiDa + "', SOSACHMUONTOIDA = '" + thamso.SoSachMuonToiDa +
                           "' WHERE ID = 1";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
