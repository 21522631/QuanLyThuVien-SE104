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
            string query = "SELECT * FROM DOCGIA";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
