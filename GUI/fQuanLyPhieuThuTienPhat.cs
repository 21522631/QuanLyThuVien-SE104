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
    public partial class fQuanLyPhieuThuTienPhat : Form
    {
        public fQuanLyPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void fQuanLyPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            txtSoPhieuThu.Enabled = false;
            txtConLai.Enabled = false;
            txtTongNo.Enabled = false;
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
        }

        private void btnThemPhieuThu_Click(object sender, EventArgs e)
        {
            fThemPhieuThuTienPhat f = new fThemPhieuThuTienPhat();
            f.ShowDialog();
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
        }

        private void dgvPTTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPTTP.CurrentRow.Index;
            txtSoPhieuThu.Text = dgvPTTP.Rows[index].Cells[0].Value.ToString();
            txtMaDocGia.Text = dgvPTTP.Rows[index].Cells[1].Value.ToString();
            dtmNgayThu.Text = dgvPTTP.Rows[index].Cells[2].Value.ToString();
            txtTongNo.Text = dgvPTTP.Rows[index].Cells[3].Value.ToString();
        }
    }
}
