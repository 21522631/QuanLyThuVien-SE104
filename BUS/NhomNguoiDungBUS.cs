using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhomNguoiDungBUS
    {
        private static NhomNguoiDungBUS instance;
        private NhomNguoiDungBUS() { }

        public static NhomNguoiDungBUS Instance 
        {
            get
            {
                if (instance == null) instance = new NhomNguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllNhomNguoiDung()
        {
            return NhomNguoiDungDAL.Instance.GetAllNhomNguoiDung();
        }
    }
}
