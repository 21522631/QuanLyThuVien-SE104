using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDocGiaDAL
    {
        private static LoaiDocGiaDAL instance;
        private LoaiDocGiaDAL() { }
        public static LoaiDocGiaDAL Instance
        {
            get
            {
                if (instance == null) instance = new LoaiDocGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllLoaiDocGia()
        {
            string query = "SELECT * FROM LOAIDOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
