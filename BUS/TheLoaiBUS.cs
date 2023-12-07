using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        private static TheLoaiBUS instance;
        private TheLoaiBUS() { }

        public static TheLoaiBUS Instance 
        {
            get
            {
                if (instance == null) instance = new TheLoaiBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
