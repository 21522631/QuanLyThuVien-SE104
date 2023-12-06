using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ThamSoBUS
    {
        private static ThamSoBUS instance;
        private ThamSoBUS() { }
        public static ThamSoBUS Instance 
        {
            get
            {
                if (instance == null) instance = new ThamSoBUS();
                return instance;
            }
            private set => instance = value;
        }
        public ThamSo GetThamSo()
        {
            return ThamSoDAL.Instance.GetThamSo();
        }
    }
}
