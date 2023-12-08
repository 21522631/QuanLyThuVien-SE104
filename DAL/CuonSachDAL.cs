using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class CuonSachDAL
    {
        private static CuonSachDAL instance;
        private CuonSachDAL() { }

        public static CuonSachDAL Instance
        {
            get
            {
                if (instance == null) instance = new CuonSachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllCuonSach()
        {
            string query = "SELECT MACUONSACH, MASACH, TENSACH, TINHTRANG " + 
                           "FROM CUONSACH JOIN SACH ON CUONSACH.IDSACH = SACH.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchCuonSach(string ThongTinTraCuu)
        {
            string query = "SELECT MACUONSACH, MASACH, TENSACH, TINHTRANG " +
                           "FROM CUONSACH JOIN SACH ON CUONSACH.IDSACH = SACH.ID " +
                           "WHERE MACUONSACH LIKE '" + ThongTinTraCuu + "%' OR MASACH LIKE '" + ThongTinTraCuu + "%' OR TENSACH LIKE N'%" + ThongTinTraCuu + "%' OR TINHTRANG = '" + ThongTinTraCuu + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertCuonSach(string IDSach)
        {
            string query = "INSERT INTO CUONSACH VALUES('" + IDSach + "', 1)";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
