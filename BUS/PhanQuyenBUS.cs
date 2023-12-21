using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyenBUS
    {
        private static PhanQuyenBUS instance;
        private PhanQuyenBUS() { }

        public static PhanQuyenBUS Instance 
        {
            get
            {
                if (instance == null) instance = new PhanQuyenBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
