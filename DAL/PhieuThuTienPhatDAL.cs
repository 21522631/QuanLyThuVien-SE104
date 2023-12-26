using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuTienPhatDAL
    {
        private static PhieuThuTienPhatDAL instance;
        private PhieuThuTienPhatDAL() { }
        public static PhieuThuTienPhatDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienPhatDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuThuTienPhat()
        {
            string query = "SELECT SOPTTP, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, NGAYTHU, TONGNO, SOTIENTHU, CONLAI " +
                           "FROM PHIEUTHUTIENPHAT";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetPhieuThuTienPhatByIDDocGia(string IDDocGia)
        {
            string query = "SELECT SOPTTP, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, NGAYTHU, TONGNO, SOTIENTHU, CONLAI " +
                           "FROM PHIEUTHUTIENPHAT WHERE IDDOCGIA = '" + IDDocGia + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuThuTienPhat(string ThongTinTraCuu)
        {
            string query = "SELECT SOPTTP, MADOCGIA, NGAYTHU, PHIEUTHUTIENPHAT.TONGNO, SOTIENTHU, CONLAI " +
                           "FROM PHIEUTHUTIENPHAT JOIN DOCGIA ON PHIEUTHUTIENPHAT.IDDOCGIA = DOCGIA.ID " +
                           "WHERE SOPTTP LIKE '" + ThongTinTraCuu + "%' OR MADOCGIA LIKE '" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuThuTienPhat(string ThongTinTraCuu, string NgayThu)
        {
            string query = "SELECT SOPTTP, MADOCGIA, NGAYTHU, TONGNO, SOTIENTHU, CONLAI " +
                           "FROM (SELECT SOPTTP, MADOCGIA, NGAYTHU, PHIEUTHUTIENPHAT.TONGNO, SOTIENTHU, CONLAI " +
                           "FROM PHIEUTHUTIENPHAT JOIN DOCGIA ON PHIEUTHUTIENPHAT.IDDOCGIA = DOCGIA.ID " +
                           "WHERE SOPTTP LIKE '" + ThongTinTraCuu + "%' OR MADOCGIA LIKE '" + ThongTinTraCuu + "%') AS TEMP " +
                           "WHERE NGAYTHU = '" + NgayThu + "'";
                           
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhieuThuTienPhat(PhieuThuTienPhat PTTP)
        {
            string query = "INSERT INTO PHIEUTHUTIENPHAT VALUES('" + PTTP.IDDocGia + "', '" + PTTP.NgayThu + "', '" + PTTP.TongNo + "', '" +
                           PTTP.SoTienThu + "', '" + PTTP.ConLai +  "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhieuThuTienPhat(string SoPTTP, string NgayThu)
        {
            string query = "UPDATE PHIEUTHUTIENPHAT SET NGAYTHU = '" + NgayThu + "' WHERE SOPTTP = '" + SoPTTP + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhieuThuTienPhat(string SoPTTP)
        {
            string query = "DELETE FROM PHIEUTHUTIENPHAT WHERE SOPTTP = '" + SoPTTP + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
