using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNguoiDungDAL
    {
        private static NhomNguoiDungDAL instance;
        private NhomNguoiDungDAL() { }
        public static NhomNguoiDungDAL Instance 
        {
            get
            {
                if (instance == null) instance = new NhomNguoiDungDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllNhomNguoiDung()
        {
            string query = "SELECT ID, MANHOM, TENNHOM FROM NHOMNGUOIDUNG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
