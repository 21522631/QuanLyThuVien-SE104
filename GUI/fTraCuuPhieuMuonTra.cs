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
    public partial class fTraCuuPhieuMuonTra : Form
    {
        public fTraCuuPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void fTraCuuPhieuMuonTra_Load(object sender, EventArgs e)
        {
            dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
        }
    }
}
