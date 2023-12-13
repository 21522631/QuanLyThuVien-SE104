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
    public partial class fTraCuuPhieuNhapSach : Form
    {
        public fTraCuuPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void fTraCuuPhieuNhapSach_Load(object sender, EventArgs e)
        {
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text);
        }
    }
}
