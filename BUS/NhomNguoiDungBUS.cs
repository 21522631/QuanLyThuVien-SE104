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
        public DataTable GetNhomNguoiDungByID(int ID)
        {
            return NhomNguoiDungDAL.Instance.GetNhomNguoiDungByID(ID);
        }
        public int InsertNhomNguoiDung(string TenNhom)
        {
            return NhomNguoiDungDAL.Instance.InsertNhomNguoiDung(TenNhom);
        }
        public int UpdateNhomNguoiDung(NhomNguoiDung NND)
        {
            return NhomNguoiDungDAL.Instance.UpdateNhomNguoiDung(NND);
        }
        public int DeleteNhomNguoiDung(string MaNhom)
        {
            return NhomNguoiDungDAL.Instance.DeleteNhomNguoiDung(MaNhom);
        }
    }
}
