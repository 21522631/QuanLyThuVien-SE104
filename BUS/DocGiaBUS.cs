using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class DocGiaBUS
    {
        private static DocGiaBUS instance;
        private DocGiaBUS() { }
        public static DocGiaBUS Instance 
        {
            get
            {
                if (instance == null) instance = new DocGiaBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllDocGia()
        {
            return DocGiaDAL.Instance.GetAllDocGia();
        }
        public int UpdateDocGia(string MaDocGia, string TenDocGia, string NgaySinh, string DiaChi, string Email, string IDLoaiDocGia, string NgayLapThe)
        {
            return DocGiaDAL.Instance.UpdateDocGia(MaDocGia, TenDocGia, NgaySinh, DiaChi, Email, IDLoaiDocGia, NgayLapThe);
        }
        public int DeleteDocGia(string MaDocGia)
        {
            return DocGiaDAL.Instance.DeleteDocGia(MaDocGia);
        }
    }
}
