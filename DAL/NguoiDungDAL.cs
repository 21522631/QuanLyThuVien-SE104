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
        public DataTable GetAllNguoiDung()
        {
            string query = "SELECT * FROM NGUOIDUNG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetNguoiDungByTaiKhoanMatKhau(string TenDangNhap, string MatKhau)
        {
            string query = "SELECT * FROM NGUOIDUNG " +
                "WHERE TENDANGNHAP = '" + TenDangNhap + "' AND MATKHAU = '" + MatKhau + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }

}
