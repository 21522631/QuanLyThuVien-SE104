using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BC_TinhHinhMuonSachBUS
    {
        private static BC_TinhHinhMuonSachBUS instance;
        private BC_TinhHinhMuonSachBUS() { }

        public static BC_TinhHinhMuonSachBUS Instance 
        {
            get
            {
                if (instance == null) instance = new BC_TinhHinhMuonSachBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
