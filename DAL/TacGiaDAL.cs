﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TacGiaDAL
    {
        private static TacGiaDAL instance;
        private TacGiaDAL() { }
        public static TacGiaDAL Instance 
        {
            get
            {
                if (instance == null) instance = new TacGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllTacGia()
        {
            string query = "SELECT MATACGIA, TENTACGIA, NGAYSINH FROM TACGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchTacGia(string ThongTinTraCuu)
        {
            string query = "SELECT MATACGIA, TENTACGIA, NGAYSINH FROM TACGIA " +
                           "WHERE MATACGIA LIKE '" + ThongTinTraCuu + "%' OR TENTACGIA LIKE N'%" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertTacGia(TacGia tacgia)
        {
            string query = "INSERT INTO TACGIA VALUES(N'" + tacgia.TenTacGia + "', '" + tacgia.NgaySinh + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateTacGia(TacGia tacgia)
        {
            string query = "UPDATE TACGIA SET TENTACGIA = N'" + tacgia.TenTacGia + "', NGAYSINH = '" + tacgia.NgaySinh +
                           "' WHERE MATACGIA = '" + tacgia.MaTacGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteTacGia(string MaTacGia)
        {
            string query = "DELETE FROM TACGIA WHERE MATACGIA = '" + MaTacGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
