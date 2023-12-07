using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiDAL
    {
        private static TheLoaiDAL instance;
        private TheLoaiDAL() { }
        public static TheLoaiDAL Instance
        {
            get
            {
                if (instance == null) instance = new TheLoaiDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
