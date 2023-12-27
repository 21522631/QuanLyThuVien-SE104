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
    public class BC_TinhHinhMuonSachBUS
    {
        private static BC_TinhHinhMuonSachBUS instance;
        private BC_TinhHinhMuonSachBUS() { }

        public static BC_TinhHinhMuonSachBUS Instance
        {
            get
            {
                if (instance == null) instance = new BC_TinhHinhMuonSachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllBC_TinhHinhMuonSach()
        {
            return BC_TinhHinhMuonSachDAL.Instance.GetAllBC_TinhHinhMuonSach();
        }
        public DataTable GetBC_TinhHinhMuonSachByNgay(int Thang, int Nam)
        {
            return BC_TinhHinhMuonSachDAL.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam);
        }
        public int InsertBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            return BC_TinhHinhMuonSachDAL.Instance.InsertBC_TinhHinhMuonSach(BC);
        }
        public int UpdateBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            return BC_TinhHinhMuonSachDAL.Instance.UpdateBC_TinhHinhMuonSach(BC);
        }
        public int DeleteBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            return BC_TinhHinhMuonSachDAL.Instance.DeleteBC_TinhHinhMuonSach(BC);
        }
    }
}
