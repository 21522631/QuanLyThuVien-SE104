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
    public partial class fTraCuuPhieuThuTienPhat : Form
    {
        public fTraCuuPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void fTraCuuPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text);
        }
    }
}
