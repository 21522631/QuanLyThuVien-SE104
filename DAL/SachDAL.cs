﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private static SachDAL instance;
        private SachDAL() { }

        public static SachDAL Instance 
        {
            get
            {
                if (instance == null) instance = new SachDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}