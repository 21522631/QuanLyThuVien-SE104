using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BC_TinhHinhMuonSachDAL
    {
        private static BC_TinhHinhMuonSachDAL instance;
        private BC_TinhHinhMuonSachDAL() { }
        public static BC_TinhHinhMuonSachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new BC_TinhHinhMuonSachDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllBC_TinhHinhMuonSach()
        {
            string query = "SELECT ID, MABCTHMS, THANG, NAM, TONGSOLUOTMUON FROM BC_TINHHINHMUONSACH ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetBC_TinhHinhMuonSachByNgay(int Thang, int Nam)
        {
            string query = "SELECT ID, MABCTHMS, THANG, NAM, TONGSOLUOTMUON FROM BC_TINHHINHMUONSACH " +
                           "WHERE THANG = '" + Thang + "' AND NAM = '" + Nam + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            string query = "INSERT INTO BC_TINHHINHMUONSACH VALUES('" + BC.Thang + "', '" + BC.Nam + "', '" + BC.TongSoLuotMuon + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int UpdateBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            string query = "UPDATE BC_TINHHINHMUONSACH SET TONGSOLUOTMUON = N'" + BC.TongSoLuotMuon +
                           "' WHERE THANG = '" + BC.Thang + "' AND NAM = '" + BC.Nam + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteBC_TinhHinhMuonSach(BC_TinhHinhMuonSach BC)
        {
            string query = "DELETE BC_TINHHINHMUONSACH WHERE THANG = '" + BC.Thang + "' AND NAM = '" + BC.Nam + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
