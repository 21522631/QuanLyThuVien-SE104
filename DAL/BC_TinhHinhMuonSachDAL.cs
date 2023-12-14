using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BC_TinhHinhMuonSachDAL
    {
        private static BC_TinhHinhMuonSachDAL instance;
        private BC_TinhHinhMuonSachDAL() { }
        public static BC_TinhHinhMuonSachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new BC_TinhHinhMuonSachDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
