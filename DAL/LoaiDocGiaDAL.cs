using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiDocGiaDAL
    {
        private static LoaiDocGiaDAL instance;
        private LoaiDocGiaDAL() { }
        public static LoaiDocGiaDAL Instance
        {
            get
            {
                if (instance == null) instance = new LoaiDocGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllLoaiDocGia()
        {
            string query = "SELECT MALOAIDOCGIA, TENLOAIDOCGIA FROM LOAIDOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllTenLoaiDocGia()
        {
            string query = "SELECT TENLOAIDOCGIA FROM LOAIDOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertLoaiDocGia(string TenLoaiDocGia)
        {
            string query = "INSERT INTO LOAIDOCGIA VALUES(N'" + TenLoaiDocGia + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateLoaiDocGia(string MaLoaiDocGia, string TenLoaiDocGia)
        {
            string query = "UPDATE LOAIDOCGIA SET TENLOAIDOCGIA = '" + TenLoaiDocGia +
                           "' WHERE MALOAIDOCGIA = '" + MaLoaiDocGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteLoaiDocGia(string MaLoaiDocGia)
        {
            string query = "DELETE FROM LOAIDOCGIA WHERE MALOAIDOCGIA = '" + MaLoaiDocGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
