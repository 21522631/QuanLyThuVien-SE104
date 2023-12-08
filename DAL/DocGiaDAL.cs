using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        private static DocGiaDAL instance;
        private DocGiaDAL() { }
        public static DocGiaDAL Instance 
        {
            get
            {
                if (instance == null) instance = new DocGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllDocGia()
        {
            string query = "SELECT MADOCGIA, TENDOCGIA, NGAYSINH, DIACHI, EMAIL, TENLOAIDOCGIA, NGAYLAPTHE, NGAYHETHAN, TONGNO, MANGUOIDUNG " +
                "FROM DOCGIA JOIN LOAIDOCGIA ON DOCGIA.IDLOAIDOCGIA = LOAIDOCGIA.ID " +
                "JOIN NGUOIDUNG ON DOCGIA.IDNGUOIDUNG = NGUOIDUNG.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchDocGia(string ThongTinTraCuu)
        {
            string query = "SELECT MADOCGIA, TENDOCGIA, NGAYSINH, DIACHI, EMAIL, MALOAIDOCGIA, TENLOAIDOCGIA, NGAYLAPTHE, NGAYHETHAN, TONGNO, MANGUOIDUNG " +
                "FROM DOCGIA JOIN LOAIDOCGIA ON DOCGIA.IDLOAIDOCGIA = LOAIDOCGIA.ID " +
                "JOIN NGUOIDUNG ON DOCGIA.IDNGUOIDUNG = NGUOIDUNG.ID " +
                "WHERE MADOCGIA LIKE '%" + ThongTinTraCuu + "%' OR TENDOCGIA LIKE N'%" + ThongTinTraCuu + "%' OR MALOAIDOCGIA LIKE '%" + ThongTinTraCuu + "%' OR TENLOAIDOCGIA LIKE '%" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertDocGia(string TenDocGia, string NgaySinh, string DiaChi, string Email, string IDLoaiDocGia, string NgayLapThe, string NgayHetHan, string IDNguoiDung)
        {
            string query = "INSERT INTO DOCGIA VALUES('" + IDLoaiDocGia + "', N'" + TenDocGia + "', '" + NgaySinh + "', N'" + DiaChi + "', '" +
                           Email + "', '" + NgayLapThe + "', '" + NgayHetHan + "', 0" + ", '" + IDNguoiDung + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateDocGia(string MaDocGia, string TenDocGia, string NgaySinh, string DiaChi, string Email, string IDLoaiDocGia, string NgayLapThe)
        {
            string query = "UPDATE DOCGIA SET TENDOCGIA = N'" + TenDocGia + "', NGAYSINH = '" + NgaySinh +
                           "', DIACHI = N'" + DiaChi + "', EMAIL = '" + Email + "', IDLoaiDocGia = '" + IDLoaiDocGia + "', NGAYLAPTHE = '" + NgayLapThe +
                           "' WHERE MADOCGIA = '" + MaDocGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteDocGia(string MaDocGia)
        {
            string query = "DELETE FROM DOCGIA WHERE MADOCGIA = '" + MaDocGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
