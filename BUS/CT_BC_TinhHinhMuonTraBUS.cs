using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_BC_TinhHinhMuonTraBUS
    {
        private static CT_BC_TinhHinhMuonTraBUS instance;
        private CT_BC_TinhHinhMuonTraBUS() { }

        public static CT_BC_TinhHinhMuonTraBUS Instance
        {
            get
            {
                if (instance == null) instance = new CT_BC_TinhHinhMuonTraBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
