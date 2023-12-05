using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public int ID { get; set; }
        public string MaNguoiDung {  get; set; }
        public string TenNguoiDung { get; set; }
        public string TenDangNhap {  get; set; }  
        public string MatKhau { get; set; }
        public int IDNhomNguoiDung { get; set; }
    } 
}
