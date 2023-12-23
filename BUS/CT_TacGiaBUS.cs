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
    public class CT_TacGiaBUS
    {
        private static CT_TacGiaBUS instance;
        private CT_TacGiaBUS() { }
        public static CT_TacGiaBUS Instance 
        {
            get
            {
                if (instance == null) instance = new CT_TacGiaBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetCT_TacGiaByIDSach(string IDSach)
        {
            return CT_TacGiaDAL.Instance.GetCT_TacGiaByIDSach(IDSach);
        }
        public DataTable GetCT_TacGiaByCT_TacGia(CT_TacGia CTTG)
        {
            return CT_TacGiaDAL.Instance.GetCT_TacGiaByCT_TacGia(CTTG);
        }
        public int InsertCT_TacGia(CT_TacGia ct_tacgia) 
        {
            return CT_TacGiaDAL.Instance.InsertCT_TacGia(ct_tacgia);
        }
        public int DeleteCT_TacGia(CT_TacGia ct_tacgia)
        {
            return CT_TacGiaDAL.Instance.DeleteCT_TacGia(ct_tacgia);
        }
    }
}
