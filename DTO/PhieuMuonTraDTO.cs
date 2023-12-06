using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonTra
    {
        public int ID { get; set; }
        public string SoPMT { get; set; }
        public int IDDocGia { get; set; }
        public int IDCuonSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayPhaiTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int TienPhat { get; set; }
    }
}
