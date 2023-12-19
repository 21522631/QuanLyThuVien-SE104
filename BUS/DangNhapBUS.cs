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
        public NguoiDung CheckDangNhap(string TenDangNhap, string MatKhau)
        {
            DataTable data = NguoiDungDAL.Instance.GetNguoiDungByTaiKhoanMatKhau(TenDangNhap, MatKhau);

            if (data.Rows.Count > 0)
            {
                NguoiDung nguoidung = new NguoiDung();
                nguoidung.ID = Convert.ToInt32(data.Rows[0][0].ToString());
                nguoidung.MaNguoiDung = data.Rows[0][1].ToString();
                nguoidung.TenNguoiDung = data.Rows[0][2].ToString();
                nguoidung.TenDangNhap = TenDangNhap;
                nguoidung.MatKhau = MatKhau;
                nguoidung.IDNhomNguoiDung = Convert.ToInt32(data.Rows[0][5].ToString());
                return nguoidung;
            }
            else
            {
                return null;
            }
        }
    }
}
