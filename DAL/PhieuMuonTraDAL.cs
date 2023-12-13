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
        public DataTable GetAllPhieuMuonTra()
        {
            string query = "SELECT SOPMT, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, " +
                           "CAST('CS' + RIGHT('0000' + CAST(IDCUONSACH AS VARCHAR(4)), 4) AS CHAR(6)) AS MACUONSACH, " +
                           "NGAYMUON, NGAYPHAITRA, NGAYTRA, TIENPHAT FROM PHIEUMUONTRA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetSoLuongSachDangMuon(string IDdocGia)
        {
            string query = "SELECT IDDOCGIA, COUNT(IDCUONSACH) AS SOLUONGSACHMUON " +
                           "FROM CUONSACH JOIN PHIEUMUONTRA ON CUONSACH.ID = PHIEUMUONTRA.IDCUONSACH " +
                           "WHERE TINHTRANG = 0 AND IDDOCGIA = '" + IDdocGia + "' " +
                           "GROUP BY IDDOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetCuonSachTraTre(string Ngay)
        {
            string query = "SELECT IDCUONSACH, NGAYMUON, NGAYPHAITRA FROM PHIEUMUONTRA " +
                           "WHERE NGAYTRA IS NULL AND NGAYPHAITRA < '" + Ngay + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuMuonTra(string ThongTinTraCuu)
        {
            string query = "SELECT SOPMT, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, " +
                           "CAST('CS' + RIGHT('0000' + CAST(IDCUONSACH AS VARCHAR(4)), 4) AS CHAR(6)) AS MACUONSACH, " +
                           "NGAYMUON, NGAYPHAITRA, NGAYTRA, TIENPHAT FROM PHIEUMUONTRA " +
                           "WHERE SOPMT LIKE '%" + ThongTinTraCuu + "%' OR NGAYMUON LIKE '%" + ThongTinTraCuu + "%' OR NGAYPHAITRA LIKE '%" + ThongTinTraCuu + "%' OR NGAYTRA LIKE '%" + ThongTinTraCuu +
                           "%' OR IDDOCGIA LIKE '%" + ThongTinTraCuu + "%' OR IDCUONSACH LIKE '%" + ThongTinTraCuu + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhieuMuonTra(PhieuMuonTra PMT)
        {
            string query = "INSERT INTO PHIEUMUONTRA VALUES('" + PMT.IDDocGia + "', '" + PMT.IDCuonSach + "', '" + PMT.NgayMuon + "', '" + PMT.NgayPhaiTra + "', NULL, '0')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhieuMuonTra(PhieuMuonTra PMT)
        {
            string query = "UPDATE PHIEUMUONTRA SET NGAYMUON = '" + PMT.NgayMuon + "', NGAYPHAITRA = '" + PMT.NgayPhaiTra +
                           "', NGAYTRA = '" + PMT.NgayTra + "', TIENPHAT = '" + PMT.TienPhat +
                           "' WHERE SOPMT = '" + PMT.SoPMT + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhieuMuonTraVoiNull(PhieuMuonTra PMT)
        {
            string query = "UPDATE PHIEUMUONTRA SET NGAYMUON = '" + PMT.NgayMuon + "', NGAYPHAITRA = '" + PMT.NgayPhaiTra +
                           "' WHERE SOPMT = '" + PMT.SoPMT + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhieuMuonTra(string SoPMT)
        {
            string query = "DELETE FROM PHIEUMUONTRA WHERE SOPMT = '" + SoPMT + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
