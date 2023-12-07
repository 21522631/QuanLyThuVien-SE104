using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_TacGiaDAL
    {
        private static CT_TacGiaDAL instance;
        private CT_TacGiaDAL() { }
        public static CT_TacGiaDAL Instance 
        {
            get
            {
                if (instance == null) instance = new CT_TacGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
