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
        public DataTable GetAllCuonSach()
        {
            return CuonSachDAL.Instance.GetAllCuonSach();
        }
        public DataTable GetAllCuonSachConTrong()
        {
            return CuonSachDAL.Instance.GetAllCuonSachConTrong();
        }
        public DataTable GetAllCuonSachByMaCuonSach(string MaCuonSach)
        {
            return CuonSachDAL.Instance.GetAllCuonSachByMaCuonSach(MaCuonSach);
        }
        public DataTable SearchCuonSach(string ThongTinTraCuu)
        {
            return CuonSachDAL.Instance.SearchCuonSach(ThongTinTraCuu);
        }
        public int InsertCuonSach(string IDSach)
        {
            return CuonSachDAL.Instance.InsertCuonSach(IDSach);
        }
        public int UpdateCuonSach(string MaCuonSach, string TinhTrang)
        {
            return CuonSachDAL.Instance.UpdateCuonSach(MaCuonSach, TinhTrang);
        }
        public int DeleteCuonSach(string IDSach, string SoLuong)
        {
            return CuonSachDAL.Instance.DeleteCuonSach(IDSach, SoLuong);
        }
    }
}
