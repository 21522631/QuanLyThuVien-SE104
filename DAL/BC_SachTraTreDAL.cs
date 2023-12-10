using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BC_SachTraTreDAL
    {
        private static BC_SachTraTreDAL instance;
        private BC_SachTraTreDAL() { }

        public static BC_SachTraTreDAL Instance
        {
            get
            {
                if (instance == null) instance = new BC_SachTraTreDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetBC_SachTraTre(string Ngay)
        {
            string query = "SELECT * FROM BC_SACHTRATRE WHERE NGAY = '" + Ngay + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertBC_SachTraTre(BC_SachTraTre BC)
        {
            string query = "INSERT BC_SACHTRATRE VALUES('" + BC.Ngay + "', '" + BC.IDCuonSach + "', '" + BC.NgayMuon + "', '" + BC.SoNgayTraTre + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
