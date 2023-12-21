using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucNangDAL
    {
        private static ChucNangDAL instance;
        ChucNangDAL() { }

        public static ChucNangDAL Instance
        {
            get
            {
                if (instance == null) instance = new ChucNangDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
