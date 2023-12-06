using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiDocGiaBUS
    {
        private static LoaiDocGiaBUS instance;
        private LoaiDocGiaBUS() { }
        public static LoaiDocGiaBUS Instance 
        {
            get
            {
                if (instance == null) instance = new LoaiDocGiaBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllLoaiDocGia()
        {
            return LoaiDocGiaDAL.Instance.GetAllLoaiDocGia();
        }
    }
}
