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
            string query = "SELECT MACHUCNANG, TENCHUCNANG, TENMANHINHDUOCLOAD FROM PHANQUYEN JOIN CHUCNANG ON PHANQUYEN.IDCHUCNANG = CHUCNANG.ID " +
                           "WHERE IDNHOMNGUOIDUNG = '" + IDNND + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertPhanQuyen(PhanQuyen phanquyen)
        {
            string query = "INSERT INTO PHANQUYEN VALUES('" + phanquyen.IDNhomNguoiDung + "', '" + phanquyen.IDChucNang + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeletePhanQuyen(PhanQuyen phanquyen) 
        {
            string query = "DELETE FROM PHANQUYEN WHERE IDNHOMNGUOIDUNG = '" + phanquyen.IDNhomNguoiDung + "' AND IDCHUCNANG = '" + phanquyen.IDChucNang + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
