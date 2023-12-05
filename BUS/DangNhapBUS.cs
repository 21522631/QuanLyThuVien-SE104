using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Net.Http.Headers;
using System.Data;

namespace BUS
{
    public class DangNhapBUS
    {
        private static DangNhapBUS instance;
        private DangNhapBUS() { }
        public static DangNhapBUS Instance 
        {
            get
            {
                if (instance == null) instance = new DangNhapBUS();
                return instance;
            }
            private set => instance = value;
        }
        public int CheckDangNhap(string TenDangNhap, string MatKhau)
        {
            DataTable data = NguoiDungDAL.Instance.GetNguoiDungByTaiKhoanMatKhau(TenDangNhap, MatKhau);

            if (data.Rows.Count > 0)
            {
                DataRow datarow = data.Rows[0];
                return (int)datarow["IDNhomNguoiDung"];  
            }
            else
            {
                return 0;
            }
        }
    }
}
