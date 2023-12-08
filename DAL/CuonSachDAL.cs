using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CuonSachDAL
    {
        private static CuonSachDAL instance;
        private CuonSachDAL() { }

        public static CuonSachDAL Instance
        {
            get
            {
                if (instance == null) instance = new CuonSachDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
