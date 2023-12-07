using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_TacGiaBUS
    {
        private static CT_TacGiaBUS instance;
        private CT_TacGiaBUS() { }
        public static CT_TacGiaBUS Instance 
        {
            get
            {
                if (instance == null) instance = new CT_TacGiaBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
