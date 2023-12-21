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
    public class PhanQuyenBUS
    {
        private static PhanQuyenBUS instance;
        private PhanQuyenBUS() { }

        public static PhanQuyenBUS Instance 
        {
            get
            {
                if (instance == null) instance = new PhanQuyenBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhanQuyenByIDNhomNguoiDung(int IDNND)
        {
            return PhanQuyenDAL.Instance.GetAllPhanQuyenByIDNhomNguoiDung(IDNND);
        }
        public int InsertPhanQuyen(PhanQuyen phanquyen)
        {
            return PhanQuyenDAL.Instance.InsertPhanQuyen(phanquyen);
        }
        public int DeletePhanQuyen(int IDNND) 
        {
            return PhanQuyenDAL.Instance.DeletePhanQuyen(IDNND);
        }
    }
}
