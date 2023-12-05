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
        public bool CheckDangNhap(string TenDangNhap, string MatKhau)
        {
            DataTable data = NguoiDungDAL.Instance.GetNguoiDungByTaiKhoanMatKhau(TenDangNhap, MatKhau);

            if (data.Rows.Count > 0)
                return true;
            else
            {
                return false;
            }
        }
    }
}
