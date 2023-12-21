using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class PhanQuyenDAL
    {
        private static PhanQuyenDAL instance;
        PhanQuyenDAL() { }

        public static PhanQuyenDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhanQuyenDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhanQuyenByIDNhomNguoiDung(int IDNND)
        {
            string query = "SELECT IDCHUCNANG FROM PHANQUYEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhanQuyen(PhanQuyen phanquyen)
        {
            string query = "INSERT INTO PHANQUYEN VALUES('" + phanquyen.IDNhomNguoiDung + "', '" + phanquyen.IDChucNang + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhanQuyen(int IDNND) 
        {
            string query = "DELETE FROM PHANQUYEN WHERE IDNHOMNGUOIDUNG = '" + IDNND + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
