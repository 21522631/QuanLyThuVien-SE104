using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTienPhat
    {
        public int ID { get; set; }
        public string SoPTTP { get; set; }
        public int IDDocGia { get; set; }
        public string NgayThu { get; set; }
        public int TongNo { get; set; }
        public int SoTienThu { get; set; }
        public int ConLai { get; set; }
    }
}