using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_PhieuNhapSachBUS
    {
        private static CT_PhieuNhapSachBUS instance;
        private CT_PhieuNhapSachBUS() { }

        public static CT_PhieuNhapSachBUS Instance
        {
            get
            {
                if (instance == null) instance = new CT_PhieuNhapSachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetCT_PhieuNhapSachByIDPNS(string IDPNS)
        {
            return CT_PhieuNhapSachDAL.Instance.GetCT_PhieuNhapSachByIDPNS(IDPNS);
        }
        public DataTable GetCT_PhieuNhapSachByIDPNSAndIDSach(string IDPNS, string IDSach)
        {
            return CT_PhieuNhapSachDAL.Instance.GetCT_PhieuNhapSachByIDPNSAndIDSach(IDPNS, IDSach);
        }
        public int InsertCT_PhieuNhapSach(CT_PhieuNhapSach ct_PNS)
        {
            return CT_PhieuNhapSachDAL.Instance.InsertCT_PhieuNhapSach(ct_PNS);
        }
        public int DeleteCT_PhieuNhapSach(string IDPNS, string IDSach) 
        {
            return CT_PhieuNhapSachDAL.Instance.DeleteCT_PhieuNhapSach(IDPNS, IDSach);
        }
    }
}
