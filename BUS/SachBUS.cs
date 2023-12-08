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
    public class SachBUS
    {
        private static SachBUS instance;
        private SachBUS() { }
        public static SachBUS Instance
        {
            get
            {
                if (instance == null) instance = new SachBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllSach()
        {
            return SachDAL.Instance.GetAllSach();
        }
        public DataTable SearchSach(string ThongTinTraCuu)
        {
            return SachDAL.Instance.SearchSach(ThongTinTraCuu);
        }
        public int UpdateSach(int SoLuong, string GiaTien, string MaSach)
        {
            return SachDAL.Instance.UpdateSach(SoLuong, GiaTien, MaSach);
        }
        public int InsertSach(Sach sach)
        {
            return SachDAL.Instance.InsertSach(sach);
        }
        public int UpdateSach(Sach sach)
        {
            return SachDAL.Instance.UpdateSach(sach);
        }
        public int DeleteSach(string MaSach) 
        {
            return SachDAL.Instance.DeleteSach(MaSach);
        }
    }
}
