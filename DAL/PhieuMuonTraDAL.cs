using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuMuonTraDAL
    {
        private static PhieuMuonTraDAL instance;
        private PhieuMuonTraDAL() { }
        public static PhieuMuonTraDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuMuonTraDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetSoLuongSachDangMuon(string IDdocGia)
        {
            string query = "SELECT IDDOCGIA, COUNT(IDCUONSACH) AS SOLUONGSACHMUON " +
                           "FROM CUONSACH JOIN PHIEUMUONTRA ON CUONSACH.ID = PHIEUMUONTRA.IDCUONSACH " +
                           "WHERE TINHTRANG = 0 AND IDDOCGIA = '" + IDdocGia + "' " +
                           "GROUP BY IDDOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhieuMuonTra(PhieuMuonTra PMT)
        {
            string query = "INSERT INTO PHIEUMUONTRA VALUES('" + PMT.IDDocGia + "', '" + PMT.IDCuonSach + "', '" + PMT.NgayMuon + "', '" + PMT.NgayPhaiTra + "', NULL, '0')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
