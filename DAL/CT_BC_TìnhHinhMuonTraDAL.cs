using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_BC_TìnhHinhMuonTraDAL
    {
        private static CT_BC_TìnhHinhMuonTraDAL instance;
        private CT_BC_TìnhHinhMuonTraDAL() { }
        public static CT_BC_TìnhHinhMuonTraDAL Instance 
        {
            get
            {
                if (instance == null) instance = new CT_BC_TìnhHinhMuonTraDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
