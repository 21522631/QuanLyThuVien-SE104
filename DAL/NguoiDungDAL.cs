﻿using System;
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
            if (DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0)
                return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
            else 
                return null;
        }
        public DataTable SearchNguoiDung(string ThongTinTraCuu)
        {
            string query = "SELECT MANGUOIDUNG, TENNGUOIDUNG, TENDANGNHAP, TENNHOM " +
                "FROM NGUOIDUNG JOIN NHOMNGUOIDUNG ON NGUOIDUNG.IDNHOMNGUOIDUNG = NHOMNGUOIDUNG.ID " +
                "WHERE MANGUOIDUNG LIKE '" + ThongTinTraCuu + "%' OR TENNGUOIDUNG LIKE N'%" + ThongTinTraCuu + "%' OR MANHOM LIKE '" + ThongTinTraCuu + "%' OR TENNHOM LIKE N'%" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertNguoiDungDocGia(string TenNguoiDung, string TenDangNhap, string MatKhau)
        {
            string query = "INSERT INTO NGUOIDUNG VALUES(N'" + TenNguoiDung + "', '" + TenDangNhap + "', '" + MatKhau + "', 3)";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int InsertNguoiDung(NguoiDung nguoidung)
        {
            string query = "INSERT INTO NGUOIDUNG VALUES(N'" + nguoidung.TenNguoiDung + "', '" + nguoidung.TenDangNhap + "', '" + nguoidung.MatKhau + "', '" + nguoidung.IDNhomNguoiDung + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateNguoiDung(NguoiDung nguoidung)
        {
            string query = "UPDATE NGUOIDUNG SET TENNGUOIDUNG = N'" + nguoidung.TenNguoiDung + "', IDNHOMNGUOIDUNG = '" + nguoidung.IDNhomNguoiDung + "' " +
                           "WHERE MANGUOIDUNG = '" + nguoidung.MaNguoiDung + "' " ;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateTenNguoiDung(string MaNguoiDung, string TenNguoiDung)
        {
            string query = "UPDATE NGUOIDUNG SET TENNGUOIDUNG = N'" + TenNguoiDung + "' WHERE MANGUOIDUNG = '" + MaNguoiDung + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateMatKhauNguoiDung(string MaNguoiDung, string MatKhau)
        {
            string query = "UPDATE NGUOIDUNG SET MATKHAU = N'" + MatKhau + "' WHERE MANGUOIDUNG = '" + MaNguoiDung + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteNguoiDung(string MaNguoiDung)
        {
            string query = "DELETE FROM NGUOIDUNG WHERE MANGUOIDUNG = '" + MaNguoiDung + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }

}
