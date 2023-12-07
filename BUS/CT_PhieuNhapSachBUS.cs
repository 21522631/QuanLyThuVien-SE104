using DAL;
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
    }
}
