using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BC_SachTraTreDAL
    {
        private static BC_SachTraTreDAL instance;
        private BC_SachTraTreDAL() { }

        public static BC_SachTraTreDAL Instance
        {
            get
            {
                if (instance == null) instance = new BC_SachTraTreDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
