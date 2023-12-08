using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CuonSachBUS
    {
        private static CuonSachBUS instance;
        private CuonSachBUS() { }
        public static CuonSachBUS Instance
        {
            get
            {
                if (instance == null) instance = new CuonSachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public int InsertCuonSach(string IDSach)
        {
            return CuonSachDAL.Instance.InsertCuonSach(IDSach);
        }
    }
}
