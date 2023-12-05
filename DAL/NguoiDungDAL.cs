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
