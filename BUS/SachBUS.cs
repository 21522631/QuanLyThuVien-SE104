using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        private static SachBUS instance;
        private SachBUS() { }
        public static SachBUS Instance
        {
            get
            {
                if (instance == null) instance = new SachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllSach()
        {
            return SachDAL.Instance.GetAllSach();
        }    
    }
}
