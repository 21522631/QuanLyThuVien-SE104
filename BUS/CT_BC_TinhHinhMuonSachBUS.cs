using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_BC_TinhHinhMuonSachBUS
    {
        private static CT_BC_TinhHinhMuonSachBUS instance;
        private CT_BC_TinhHinhMuonSachBUS() { }

        public static CT_BC_TinhHinhMuonSachBUS Instance
        {
            get
            {
                if (instance == null) instance = new CT_BC_TinhHinhMuonSachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllCT_BCTinhHinhMuonSachByIDBC(int ID)
        {
            return CT_BC_TinhHinhMuonSachDAL.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(ID);
        }
        public int InsertCT_BCTinhHinhMuonSach(CT_BC_TinhHinhMuonSach CTBC)
        {
            return CT_BC_TinhHinhMuonSachDAL.Instance.InsertCT_BCTinhHinhMuonSach(CTBC);
        }
    }
}
