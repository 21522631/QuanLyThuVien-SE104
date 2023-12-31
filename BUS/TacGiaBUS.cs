﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TacGiaBUS
    {
        private static TacGiaBUS instance;
        private TacGiaBUS() { }
        public static TacGiaBUS Instance
        {
            get
            {
                if (instance == null) instance = new TacGiaBUS();
                return instance;
            }
            private set => instance = value;
        }
        public DataTable SearchTacGia(string ThongTinTraCuu)
        {
            return TacGiaDAL.Instance.SearchTacGia(ThongTinTraCuu);
        }
        public DataTable GetAllTacGia()
        {
            return TacGiaDAL.Instance.GetAllTacGia();
        }
        public int InsertTacGia(TacGia tacgia)
        {
            return TacGiaDAL.Instance.InsertTacGia(tacgia);
        }
        public int UpdateTacGia(TacGia tacgia)
        {
            return TacGiaDAL.Instance.UpdateTacGia(tacgia);
        }
        public int DeleteTacGia(string MaTacGia)
        {
            return TacGiaDAL.Instance.DeleteTacGia(MaTacGia);
        }
    }
}
