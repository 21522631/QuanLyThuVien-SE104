using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;
        private NguoiDungBUS() { }
        public static NguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllNguoiDung()
        {
            return NguoiDungDAL.Instance.GetAllNguoiDung();
        }
        public DataTable GetNguoiDungByTaiKhoanMatKhau(string TenDangNhap, string MatKhau)
        {
            return NguoiDungDAL.Instance.GetNguoiDungByTaiKhoanMatKhau(TenDangNhap, MatKhau);
        }
        public string GetIDNguoiDungByTenDangNhap(string TenDangNhap)
        {
            return NguoiDungDAL.Instance.GetIDNguoiDungByTenDangNhap(TenDangNhap);
        }
        public DataTable SearchNguoiDung(string ThongTinTraCuu)
        {
            return NguoiDungDAL.Instance.SearchNguoiDung(ThongTinTraCuu);
        }
        public int InsertNguoiDungDocGia(string TenNguoiDung, string TenDangNhap, string MatKhau)
        {
            return NguoiDungDAL.Instance.InsertNguoiDungDocGia(TenNguoiDung, TenDangNhap, MatKhau);
        }
        public int InsertNguoiDung(NguoiDung nguoidung)
        {
            return NguoiDungDAL.Instance.InsertNguoiDung(nguoidung);
        }
        public int UpdateNguoiDung(NguoiDung nguoidung)
        {
            return NguoiDungDAL.Instance.UpdateNguoiDung(nguoidung);
        }
        public int UpdateTenNguoiDung(string MaNguoiDung, string TenNguoiDung)
        {
            return NguoiDungDAL.Instance.UpdateTenNguoiDung(MaNguoiDung, TenNguoiDung);
        }
        public int UpdateMatKhauNguoiDung(string MaNguoiDung, string MatKhau)
        {
            return NguoiDungDAL.Instance.UpdateMatKhauNguoiDung(MaNguoiDung, MatKhau);
        }
        public int DeleteNguoiDung(string MaNguoiDung)
        {
            return NguoiDungDAL.Instance.DeleteNguoiDung(MaNguoiDung);
        }
    }
}
