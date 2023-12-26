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
        public DataTable GetPhieuMuonTraByIDDocGia(string IDDocGia)
        {
            string query = "SELECT SOPMT, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, " +
                           "CAST('CS' + RIGHT('0000' + CAST(IDCUONSACH AS VARCHAR(4)), 4) AS CHAR(6)) AS MACUONSACH, " +
                           "NGAYMUON, NGAYPHAITRA, NGAYTRA, TIENPHAT FROM PHIEUMUONTRA " +
                           "WHERE IDDOCGIA = '" + IDDocGia + "'";
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
        public DataTable GetTongSoLuotMuonTheoTheLoaiByNgay(int Thang, int Nam)
        {
            string query = "SELECT THELOAI.ID, THELOAI.TENTHELOAI, COUNT(SOPMT) AS SOLUOTMUON " +
                           "FROM PHIEUMUONTRA JOIN CUONSACH ON PHIEUMUONTRA.IDCUONSACH = CUONSACH.ID " +
                           "JOIN SACH ON SACH.ID = CUONSACH.IDSACH " +
                           "JOIN THELOAI ON SACH.IDTHELOAI = THELOAI.ID " +
                           "WHERE NGAYMUON LIKE '" + Nam + "-" + Thang + "%'" +
                           "GROUP BY THELOAI.ID, THELOAI.TENTHELOAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuMuonTra(string ThongTinTraCuu)
        {
            string query = "SELECT SOPMT, MADOCGIA, MACUONSACH, NGAYMUON, NGAYPHAITRA, NGAYTRA, TIENPHAT " +
                           "FROM PHIEUMUONTRA JOIN DOCGIA ON PHIEUMUONTRA.IDDOCGIA = DOCGIA.ID " +
                           "JOIN CUONSACH ON PHIEUMUONTRA.IDCUONSACH = CUONSACH.ID " +
                           "WHERE SOPMT LIKE '" + ThongTinTraCuu + "%' OR MADOCGIA LIKE '" + ThongTinTraCuu + "%' OR MACUONSACH LIKE '" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuMuonTra(string ThongTinTraCuu, string NgayMuon, string NgayTra)
        {
            string query = "SELECT * " +
                         " FROM(SELECT SOPMT, MADOCGIA, MACUONSACH, NGAYMUON, NGAYPHAITRA, NGAYTRA, TIENPHAT FROM PHIEUMUONTRA JOIN DOCGIA ON PHIEUMUONTRA.IDDOCGIA = DOCGIA.ID JOIN CUONSACH ON PHIEUMUONTRA.IDCUONSACH = CUONSACH.ID WHERE SOPMT LIKE '" + ThongTinTraCuu + "%' OR MADOCGIA LIKE '" + ThongTinTraCuu + "%' OR MACUONSACH LIKE '" + ThongTinTraCuu + "%') AS TEMP " +
                         " WHERE " + NgayMuon + NgayTra;
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
            string query = "UPDATE PHIEUMUONTRA SET NGAYMUON = '" + PMT.NgayMuon + "', NGAYPHAITRA = '" + PMT.NgayPhaiTra + "', NGAYTRA = NULL, TIENPHAT = 0" + 
                           " WHERE SOPMT = '" + PMT.SoPMT + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhieuMuonTra(string SoPMT)
        {
            string query = "DELETE FROM PHIEUMUONTRA WHERE SOPMT = '" + SoPMT + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
