﻿using System;
using System.Collections.Generic;
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
        public string GetIDNguoiDungByTenDangNhap(string TenDangNhap)
        {
            return NguoiDungDAL.Instance.GetIDNguoiDungByTenDangNhap(TenDangNhap);
        }
        public int InsertNguoiDungDocGia(string TenNguoiDung, string TenDangNhap, string MatKhau) 
        {
            return NguoiDungDAL.Instance.InsertNguoiDungDocGia(TenNguoiDung, TenDangNhap, MatKhau);
        }
    }
}
