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
    public class PhieuNhapSachBUS
    {
        private static PhieuNhapSachBUS instance;
        private PhieuNhapSachBUS () { }
        public static PhieuNhapSachBUS Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuNhapSachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuNhapSach()
        {
            return PhieuNhapSachDAL.Instance.GetAllPhieuNhapSach();
        }
        public DataTable SearchPhieuNhapSach(string ThongTinTraCuu)
        {
            return PhieuNhapSachDAL.Instance.SearchPhieuNhapSach (ThongTinTraCuu);
        }
        public int InsertPhieuNhapSach(string NgayLap)
        {
            return PhieuNhapSachDAL.Instance.InsertPhieuNhapSach(NgayLap);
        }
        public int UpdatePhieuNhapSach(string SoPNS, string NgayLap)
        {
            return PhieuNhapSachDAL.Instance.UpdatePhieuNhapSach(SoPNS, NgayLap);
        }
        public int UpdatePhieuNhapSach(PhieuNhapSach PNS)
        {
            return PhieuNhapSachDAL.Instance.UpdatePhieuNhapSach(PNS);
        }
        public int DeletePhieuNhapSach(string SoPNS)
        {
            return PhieuNhapSachDAL.Instance.DeletePhieuNhapSach(SoPNS);
        }
    }
}
