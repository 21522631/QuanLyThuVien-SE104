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
        private string strconn = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyThuVien;Integrated Security=True;TrustServerCertificate=True";
        
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteNonQuery();
            }
            return data;
        }
        public object ExecuteScalar(string query)
        {
            object data;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteScalar();       
            }
            return data;
        }
    }
}
