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
    public partial class fQuanLyPhieuNhapSach : Form
    {
        public fQuanLyPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThemPhieuNhapSach f = new fThemPhieuNhapSach();
            f.ShowDialog();
        }

        private void dgvPhieuNhapSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fQuanLyPhieuNhapSach_Load(object sender, EventArgs e)
        {
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }
    }
}
