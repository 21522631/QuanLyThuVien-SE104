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
        public DataTable GetAllTenLoaiDocGia()
        {
            return LoaiDocGiaDAL.Instance.GetAllTenLoaiDocGia();
        }
        public string GetIDLoaiDocGiaByTenLoaiDocGia(string TenLoaiDocGia)
        {
            return LoaiDocGiaDAL.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(TenLoaiDocGia);
        }
        public DataTable GetLoaiDocGiaByTenLoaiDocGia(string TenLoaiDocGia)
        {
            return LoaiDocGiaDAL.Instance.GetLoaiDocGiaByTenLoaiDocGia(TenLoaiDocGia);
        }
        public DataTable GetLoaiDocGiaByID(string ID)
        {
            return LoaiDocGiaDAL.Instance.GetLoaiDocGiaByID(ID);
        }
        public DataTable SearchLoaiDocGia(string ThongTinTraCuu)
        {
            return LoaiDocGiaDAL.Instance.SearchLoaiDocGia(ThongTinTraCuu);
        }
        public int InsertLoaiDocGia(string TenLoaiDocGia)
        {
            return LoaiDocGiaDAL.Instance.InsertLoaiDocGia(TenLoaiDocGia);
        }
        public int UpdateLoaiDocGia(string MaLoaiDocGia, string TenLoaiDocGia)
        {
            return LoaiDocGiaDAL.Instance.UpdateLoaiDocGia(MaLoaiDocGia, TenLoaiDocGia);
        }
        public int DeleteLoaiDocGia(string MaLoaiDocGia)
        {
            return LoaiDocGiaDAL.Instance.DeleteLoaiDocGia(MaLoaiDocGia);
        }
    }
}
