using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucNangDAL
    {
        private static ChucNangDAL instance;
        ChucNangDAL() { }

        public static ChucNangDAL Instance
        {
            get
            {
                if (instance == null) instance = new ChucNangDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllChucNang()
        {
            string query = "SELECT ID, MACHUCNANG, TENCHUCNANG, TENMANHINHDUOCLOAD FROM CHUCNANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertChucNang(ChucNang chucnang)
        {
            string query = "INSERT INTO CHUCNANG VALUES(N'" + chucnang.TenChucNang + "', N'" + chucnang.TenManHinhDuocLoad + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteChucNang(int MaChucNang)
        {
            string query = "DELETE FROM CHUCNANG WHERE MACHUCNANG = '" + MaChucNang + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
