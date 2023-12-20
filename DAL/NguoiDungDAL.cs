using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NguoiDungDAL
    {
        private static NguoiDungDAL instance;
        private NguoiDungDAL() { }
        public static NguoiDungDAL Instance 
        {
            get
            {
                if (instance == null) instance = new NguoiDungDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllNguoiDung()
        {
            string query = "SELECT MANGUOIDUNG, TENNGUOIDUNG, TENDANGNHAP, TENNHOM " +
                "FROM NGUOIDUNG JOIN NHOMNGUOIDUNG ON NGUOIDUNG.IDNHOMNGUOIDUNG = NHOMNGUOIDUNG.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetNguoiDungByTaiKhoanMatKhau(string TenDangNhap, string MatKhau)
        {
            string query = "SELECT * FROM NGUOIDUNG " +
                "WHERE TENDANGNHAP = '" + TenDangNhap + "' AND MATKHAU = '" + MatKhau + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public string GetIDNguoiDungByTenDangNhap(string TenDangNhap)
        {
            string query = "SELECT ID FROM NGUOIDUNG " +
                "WHERE TENDANGNHAP = '" + TenDangNhap + "'";
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }
        public int InsertNguoiDungDocGia(string TenNguoiDung, string TenDangNhap, string MatKhau)
        {
            string query = "INSERT INTO NGUOIDUNG VALUES(N'" + TenNguoiDung + "', '" + TenDangNhap + "', '" + MatKhau + "', 3)";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }

}
