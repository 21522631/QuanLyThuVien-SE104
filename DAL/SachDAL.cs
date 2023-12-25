using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private static SachDAL instance;
        private SachDAL() { }

        public static SachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new SachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllSach()
        {
            string query = "SELECT MASACH, TENSACH, MATHELOAI, TENTHELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, GIATIEN " +
                           "FROM SACH JOIN THELOAI ON SACH.IDTHELOAI = THELOAI.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllSachByMaSach(string MaSach)
        {
            string query = "SELECT MASACH, TENSACH, IDTHELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, GIATIEN " +
                           "FROM SACH WHERE MASACH = '" + MaSach + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchSach(string ThongTinTraCuu)
        {
            string query = "SELECT MASACH, TENSACH, MATHELOAI, TENTHELOAI, NHAXUATBAN, NAMXUATBAN, SOLUONG, GIATIEN " +
                           "FROM SACH JOIN THELOAI ON SACH.IDTHELOAI = THELOAI.ID " +
                           "WHERE MASACH LIKE '%" + ThongTinTraCuu + "%' OR TENSACH LIKE N'%" + ThongTinTraCuu + "%' OR MATHELOAI LIKE '%" + ThongTinTraCuu + "%' OR TENTHELOAI LIKE N'%" + ThongTinTraCuu +
                           "%' OR NHAXUATBAN LIKE '%" + ThongTinTraCuu + "%' OR NAMXUATBAN LIKE '%" + ThongTinTraCuu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertSach(Sach sach)
        {
            string query = "INSERT INTO SACH VALUES(N'" + sach.TenSach + "', '" + sach.IDTheLoai + "', '" + sach.NhaXuatBan + "', '" + sach.NamXuatBan + "', '0', '" + sach.GiaTien + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateSach(int SoLuong, string GiaTien, string MaSach)
        {
            string query = "UPDATE SACH SET SOLUONG = (SELECT SOLUONG FROM SACH WHERE MASACH = '" + MaSach + "')  + " + SoLuong + ", GIATIEN = '" + GiaTien +
                           "' WHERE MASACH = '" + MaSach + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateSach(Sach sach)
        {
            string query = "UPDATE SACH SET TENSACH = N'" + sach.TenSach + "', IDTHELOAI = '" + sach.IDTheLoai +
                           "', NHAXUATBAN = N'" + sach.NhaXuatBan + "', NAMXUATBAN = '" + sach.NamXuatBan + 
                           "' WHERE MASACH = '" + sach.MaSach + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteSach(string MaSach) 
        {
            string query = "DELETE FROM SACH WHERE MASACH = '" + MaSach + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
