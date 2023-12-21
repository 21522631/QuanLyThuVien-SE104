using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        private static PhanQuyenDAL instance;
        PhanQuyenDAL() { }

        public static PhanQuyenDAL Instance 
        {
            get
            {
                if (instance == null) instance = new PhanQuyenDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
