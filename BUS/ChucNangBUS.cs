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
    public class ChucNangBUS
    {
        private static ChucNangBUS instance;
        ChucNangBUS() { }

        public static ChucNangBUS Instance
        {
            get
            {
                if (instance == null) instance = new ChucNangBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetAllChucNang()
        {
            return ChucNangDAL.Instance.GetAllChucNang();
        }
        public DataTable GetChucNangByID(int ID)
        {
            return ChucNangDAL.Instance.GetChucNangByID(ID);
        }
        public DataTable GetChucNangByTenChucNang(ChucNang chucnang)
        {
            return ChucNangDAL.Instance.GetChucNangByTenChucNang(chucnang);
        }
        public int InsertChucNang(ChucNang chucnang)
        {
            return ChucNangDAL.Instance.InsertChucNang(chucnang);
        }
        public int UpdateChucNang(ChucNang chucnang)
        {
            return ChucNangDAL.Instance.UpdateChucNang(chucnang);
        }
        public int DeleteChucNang(string MaChucNang)
        {
            return ChucNangDAL.Instance.DeleteChucNang(MaChucNang);
        }
    }
}
