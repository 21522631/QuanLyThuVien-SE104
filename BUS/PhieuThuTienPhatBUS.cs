using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuThuTienPhatBUS
    {
        private static PhieuThuTienPhatBUS instance;
        private PhieuThuTienPhatBUS() { }
        public static PhieuThuTienPhatBUS Instance 
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienPhatBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllPhieuThuTienPhat()
        {
            return PhieuThuTienPhatDAL.Instance.GetAllPhieuThuTienPhat();
        }
    }
}
