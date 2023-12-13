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
    public class PhieuMuonTraBUS
    {
        private static PhieuMuonTraBUS instance;
        private PhieuMuonTraBUS() { }
        public static PhieuMuonTraBUS Instance
        {
            get
            {
                if (instance == null) instance = new PhieuMuonTraBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuMuonTra()
        {
            return PhieuMuonTraDAL.Instance.GetAllPhieuMuonTra();
        }
        public DataTable GetSoLuongSachDangMuon(string IDdocGia)
        {
            return PhieuMuonTraDAL.Instance.GetSoLuongSachDangMuon(IDdocGia);
        }
        public DataTable GetCuonSachTraTre(string Ngay)
        {
            return PhieuMuonTraDAL.Instance.GetCuonSachTraTre(Ngay);
        }
        public DataTable SearchPhieuMuonTra(string ThongTinTraCuu)
        {
            return PhieuMuonTraDAL.Instance.SearchPhieuMuonTra(ThongTinTraCuu);
        }
        public int InsertPhieuMuonTraBUS(PhieuMuonTra PMT)
        {
            return PhieuMuonTraDAL.Instance.InsertPhieuMuonTra(PMT);
        }
        public int UpdatePhieuMuonTra(PhieuMuonTra PMT)
        {
            return PhieuMuonTraDAL.Instance.UpdatePhieuMuonTra(PMT);
        }
        public int UpdatePhieuMuonTraVoiNull(PhieuMuonTra PMT)
        {
            return PhieuMuonTraDAL.Instance.UpdatePhieuMuonTraVoiNull(PMT);
        }
        public int DeletePhieuMuonTra(string SoPMT)
        {
            return PhieuMuonTraDAL.Instance.DeletePhieuMuonTra(SoPMT);
        }
    }
}
