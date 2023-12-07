using DTO;
using BUS;
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
    public partial class fThemPhieuNhapSach : Form
    {
        public fThemPhieuNhapSach()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuNhapSachBUS.Instance.InsertPhieuNhapSach(dtmNgayLap.Text);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
