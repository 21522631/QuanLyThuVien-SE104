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
    public class TheLoaiBUS
    {
        private static TheLoaiBUS instance;
        private TheLoaiBUS() { }

        public static TheLoaiBUS Instance 
        {
            get
            {
                if (instance == null) instance = new TheLoaiBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllTheLoai()
        {
            return TheLoaiDAL.Instance.GetAllTheLoai();
        }
        public DataTable GetTheLoaiByTenTheLoai(string TenTheLoai)
        {
            return TheLoaiDAL.Instance.GetTheLoaiByTenTheLoai(TenTheLoai);
        }
        public DataTable SearchTheLoai(string ThongTinTraCuu)
        {
            return TheLoaiDAL.Instance.SearchTheLoai(ThongTinTraCuu);
        }
        public int InsertTheLoai(string TenTheLoai)
        {
            return TheLoaiDAL.Instance.InsertTheLoai(TenTheLoai);
        }
        public int UpdateTheLoai(TheLoai theloai)
        {
            return TheLoaiDAL.Instance.UpdateTheLoai(theloai);
        }
        public int DeleteTheLoai(string MaTheLoai)
        {
            return TheLoaiDAL.Instance.DeleteTheLoai(MaTheLoai);
        }
    }
}
