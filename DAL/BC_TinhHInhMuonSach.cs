using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BC_TinhHinhMuonSach
    {
        private static BC_TinhHinhMuonSach instance;
        private BC_TinhHinhMuonSach() { }
        public static BC_TinhHinhMuonSach Instance 
        {
            get
            {
                if (instance == null) instance = new BC_TinhHinhMuonSach();
                return instance;
            }
            private set => instance = value;
        }
    }
}
