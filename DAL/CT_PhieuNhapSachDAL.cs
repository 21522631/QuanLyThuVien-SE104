using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
        public int InsertCT_PhieuNhapSach(CT_PhieuNhapSach ct_PNS)
        {
            string query = "INSERT INTO CT_PHIEUNHAPSACH VALUES('" + ct_PNS.IDPNS + "', '" + ct_PNS.IDSach + "', '" + ct_PNS.SoLuongNhap + "', '" + ct_PNS.DonGia + "', '"  + ct_PNS.ThanhTien + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteCT_PhieuNhapSach(string IDPNS, string IDSach)
        {
            string query = "DELETE FROM CT_PHIEUNHAPSACH WHERE IDPNS = '" + IDPNS + "' AND IDSACH = '" + IDSach + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
