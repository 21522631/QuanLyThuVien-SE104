using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        private static DocGiaDAL instance;
        private DocGiaDAL() { }
        public static DocGiaDAL Instance 
        {
            get
            {
                if (instance == null) instance = new DocGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllDocGia()
        {
            string query = "SELECT MADOCGIA, TENDOCGIA, NGAYSINH, DIACHI, EMAIL, TENLOAIDOCGIA, NGAYLAPTHE, NGAYHETHAN, MANGUOIDUNG " +
                "FROM DOCGIA JOIN LOAIDOCGIA ON DOCGIA.IDLOAIDOCGIA = LOAIDOCGIA.ID " +
                "JOIN NGUOIDUNG ON DOCGIA.IDNGUOIDUNG = NGUOIDUNG.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
