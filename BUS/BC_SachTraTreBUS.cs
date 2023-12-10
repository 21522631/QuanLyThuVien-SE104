using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BC_SachTraTreBUS
    {
        private static BC_SachTraTreBUS instance;
        private BC_SachTraTreBUS() { }

        public static BC_SachTraTreBUS Instance 
        {
            get
            {
                if (instance == null) instance = new BC_SachTraTreBUS();
                return instance;
            }
            private set => instance = value;
        }
    }
}
