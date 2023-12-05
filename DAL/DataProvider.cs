using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private string strconn = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyThuVien;Integrated Security=True;Trust Server Certificate=True";
        
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;
        }
    }
}
