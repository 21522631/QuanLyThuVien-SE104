using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_BC_TinhHinhMuonSachDAL
    {
        private static CT_BC_TinhHinhMuonSachDAL instance;
        private CT_BC_TinhHinhMuonSachDAL() { }
        public static CT_BC_TinhHinhMuonSachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new CT_BC_TinhHinhMuonSachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllCT_BCTinhHinhMuonSachByIDBC(int ID)
        {
            string query = "SELECT TENTHELOAI, SOLUOTMUON, TILE " +
                           "FROM BC_TINHHINHMUONSACH JOIN CT_BC_TINHHINHMUONSACH ON BC_TINHHINHMUONSACH.ID = CT_BC_TINHHINHMUONSACH.IDBCTHMS " +
                           "JOIN THELOAI ON THELOAI.ID = CT_BC_TINHHINHMUONSACH.IDTHELOAI " +
                           "WHERE BC_TINHHINHMUONSACH.ID = '" + ID + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertCT_BCTinhHinhMuonSach(CT_BC_TinhHinhMuonSach CTBC)
        {
            string query = "INSERT INTO CT_BC_TINHHINHMUONSACH VALUES('" + CTBC.IDBCTHMS + "', '" + CTBC.IDTheLoai + "', '" + CTBC.SoLuotMuon + "', '" + CTBC.TiLe + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateCT_BCTinhHinhMuonSach(CT_BC_TinhHinhMuonSach CTBC)
        {
            string query = "UPDATE CT_BC_TINHHINHMUONSACH SET SOLUOTMUON = '" + CTBC.SoLuotMuon + "', TILE = '" + CTBC.TiLe + "' " +
                           "'WHERE IDBCTHMS = '" + CTBC.IDBCTHMS + "' AND IDTHELOAI = '" + CTBC.IDTheLoai + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
