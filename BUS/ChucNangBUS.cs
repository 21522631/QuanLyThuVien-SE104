using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucNangBUS
    {
        private static ChucNangBUS instance;
        ChucNangBUS() { }

        public static ChucNangBUS Instance 
        {
            get
            {
                if (instance == null) instance = new ChucNangBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
