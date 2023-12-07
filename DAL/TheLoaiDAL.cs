using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiDAL
    {
        private static TheLoaiDAL instance;
        private TheLoaiDAL() { }
        public static TheLoaiDAL Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllTheLoai()
        {
            string query = "SELECT MATHELOAI, TENTHELOAI FROM THELOAI";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertTheLoai(string TenTheLoai)
        {
            string query = "INSERT INTO THELOAI VALUES(N'" + TenTheLoai + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateTheLoai(TheLoai theloai)
        {
            string query = "UPDATE THELOAI SET TENTHELOAI = N'" + theloai.TenTheLoai +
                           "' WHERE MATHELOAI = '" + theloai.MaTheLoai + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteTheLoai(string MaTheLoai)
        {
            string query = "DELETE FROM THELOAI WHERE MATHELOAI = '" + MaTheLoai + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
