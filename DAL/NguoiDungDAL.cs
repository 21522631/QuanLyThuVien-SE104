using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDung : DataProvider
    {
        DataProvider  data = new DataProvider();
        public DataTable GetAllNguoiDung()
        {
            string query = "SELECT * FROM NGUOIDUNG";
            return base.ExecuteQuery(query);
        }
    }
}
