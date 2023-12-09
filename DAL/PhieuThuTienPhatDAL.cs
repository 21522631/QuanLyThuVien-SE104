using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuTienPhatDAL
    {
        private static PhieuThuTienPhatDAL instance;
        private PhieuThuTienPhatDAL() { }
        public static PhieuThuTienPhatDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienPhatDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuThuTienPhat()
        {
            string query = "SELECT SOPTTP, CAST('DG' + RIGHT('0000' + CAST(IDDOCGIA AS VARCHAR(4)), 4) AS CHAR(6)) AS MADOCGIA, NGAYTHU, TONGNO, SOTIENTHU, CONLAI " +
                           "FROM PHIEUTHUTIENPHAT";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
