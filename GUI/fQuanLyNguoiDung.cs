﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fQuanLyNguoiDung : Form
    {
        public fQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void fQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }
    }
}