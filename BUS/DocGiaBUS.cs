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
        public DataTable GetDocGiaByMaDocGia(string MaDocGia)
        {
            return DocGiaDAL.Instance.GetDocGiaByMaDocGia(MaDocGia);
        }
        public DataTable SearchDocGia(string ThongTinTimKiem)
        {
            return DocGiaDAL.Instance.SearchDocGia(ThongTinTimKiem);
        }
        public int InsertDocGia(string TenDocGia, string NgaySinh, string DiaChi, string Email, string IDLoaiDocGia, string NgayLapThe, string NgayHetHan, string IDNguoiDung)
        {
            return DocGiaDAL.Instance.InsertDocGia(TenDocGia, NgaySinh, DiaChi, Email, IDLoaiDocGia, NgayLapThe, NgayHetHan, IDNguoiDung);
        }
        public int UpdateDocGia(string MaDocGia, string TenDocGia, string NgaySinh, string DiaChi, string Email, string IDLoaiDocGia, string NgayLapThe)
        {
            return DocGiaDAL.Instance.UpdateDocGia(MaDocGia, TenDocGia, NgaySinh, DiaChi, Email, IDLoaiDocGia, NgayLapThe);
        }
        public int UpdateDocGia(string MaDocGia, string TongNo)
        {
            return DocGiaDAL.Instance.UpdateDocGia(MaDocGia, TongNo);
        }
        public int DeleteDocGia(string MaDocGia)
        {
            return DocGiaDAL.Instance.DeleteDocGia(MaDocGia);
        }
    }
}
