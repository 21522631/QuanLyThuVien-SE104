using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        public int ID {  get; set; }
        public string MaDocGia {  get; set; }
        public int IDLoaiDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi {  get; set; }
        public string Email { get; set; }
        public DateTime NgayLapThe {  get; set; }
        public DateTime NgayHetHan {  get; set; }
        public int TongNo { get; set; }
        public int IDNguoiDung { get; set; }

    }
}
