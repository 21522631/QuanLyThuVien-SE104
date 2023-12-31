﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapSachDAL
    {
        private static PhieuNhapSachDAL instance;
        private PhieuNhapSachDAL() { }

        public static PhieuNhapSachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuNhapSachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuNhapSach()
        {
            string query = "SELECT SOPNS, NGAYLAP, TONGTIEN FROM PHIEUNHAPSACH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetLatestPhieuNhapSach()
        {
            string query = "SELECT * FROM PHIEUNHAPSACH WHERE ID = (SELECT MAX(ID) FROM PHIEUNHAPSACH) ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuNhapSach(string ThongTinTraCuu)
        {
            string query = "SELECT SOPNS, NGAYLAP, TONGTIEN FROM PHIEUNHAPSACH " + 
                           "WHERE SOPNS LIKE '" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchPhieuNhapSach(string ThongTinTraCuu, string NgayLap)
        {
            string query = "SELECT SOPNS, NGAYLAP, TONGTIEN FROM PHIEUNHAPSACH " +
                           "WHERE SOPNS LIKE '%" + ThongTinTraCuu + "%' AND NGAYLAP = '" + NgayLap + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhieuNhapSach(string NgayLap)
        {
            string query = "INSERT INTO PHIEUNHAPSACH VALUES('" + NgayLap + "', 0)";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhieuNhapSach(string SoPNS, string NgayLap)
        {
            string query = "UPDATE PHIEUNHAPSACH SET NGAYLAP = '" + NgayLap +
                           "' WHERE SOPNS = '" + SoPNS + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdatePhieuNhapSach(PhieuNhapSach PNS)
        {
            string query = "UPDATE PHIEUNHAPSACH SET TONGTIEN = '" + PNS.TongTien +
                           "' WHERE SOPNS = '" + PNS.SoPNS + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhieuNhapSach(string SoPNS)
        {
            string query = "DELETE FROM PHIEUNHAPSACH WHERE SOPNS = '" + SoPNS + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
