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
