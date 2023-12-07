using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_TacGiaDAL
    {
        private static CT_TacGiaDAL instance;
        private CT_TacGiaDAL() { }
        public static CT_TacGiaDAL Instance 
        {
            get
            {
                if (instance == null) instance = new CT_TacGiaDAL();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetCT_TacGiaByIDSach(string IDSach)
        {
            string query = "SELECT MATACGIA, TENTACGIA FROM CT_TACGIA JOIN TACGIA ON CT_TACGIA.IDTACGIA = TACGIA.ID " +
                           "WHERE IDSACH = '" + IDSach + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int InsertCT_TacGia(CT_TacGia ct_tacgia)
        {
            string query = "INSERT INTO CT_TACGIA VALUES('" + ct_tacgia.IDSach + "', '" + ct_tacgia.IDTacGia + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int DeleteCT_TacGia(CT_TacGia ct_tacgia)
        {
            string query = "DELETE FROM CT_TACGIA WHERE IDSACH = '" + ct_tacgia.IDSach + "' AND IDTACGIA = '" +ct_tacgia.IDTacGia + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
