using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_PhieuNhapSachDAL
    {
        private static CT_PhieuNhapSachDAL instance;
        private CT_PhieuNhapSachDAL() { }
        public static CT_PhieuNhapSachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new CT_PhieuNhapSachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetCT_PhieuNhapSachByIDPNS(string IDPNS)
        {
            string query = "SELECT MASACH, TENSACH, SOLUONGNHAP, DONGIA, THANHTIEN " +
                           "FROM CT_PHIEUNHAPSACH JOIN SACH ON CT_PHIEUNHAPSACH.IDSACH = SACH.ID " +
                           "WHERE IDPNS = " + IDPNS;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
