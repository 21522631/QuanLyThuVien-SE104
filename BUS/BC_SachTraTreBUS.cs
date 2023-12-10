using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BC_SachTraTreBUS
    {
        private static BC_SachTraTreBUS instance;
        private BC_SachTraTreBUS() { }

        public static BC_SachTraTreBUS Instance 
        {
            get
            {
                if (instance == null) instance = new BC_SachTraTreBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetBC_SachTraTre(string Ngay)
        {
            return BC_SachTraTreDAL.Instance.GetBC_SachTraTre(Ngay);
        }
        public int InsertBC_SachTraTre(BC_SachTraTre BC)
        {
            return BC_SachTraTreDAL.Instance.InsertBC_SachTraTre(BC);
        }
    }
}
