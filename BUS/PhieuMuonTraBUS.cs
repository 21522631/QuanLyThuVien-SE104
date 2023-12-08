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
        public DataTable GetSoLuongSachDangMuon(string IDdocGia)
        {
            return PhieuMuonTraDAL.Instance.GetSoLuongSachDangMuon(IDdocGia);
        }
        public int InsertPhieuMuonTraBUS(PhieuMuonTra PMT)
        {
            return PhieuMuonTraDAL.Instance.InsertPhieuMuonTra(PMT);
        }
    }
}
