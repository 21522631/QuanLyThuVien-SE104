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

        private void dgvPhieuNhapSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhieuNhapSach.CurrentRow.Index;
            txtSoPNS.Text = dgvPhieuNhapSach.Rows[index].Cells[0].Value.ToString();
            dtmNgayLap.Text = dgvPhieuNhapSach.Rows[index].Cells[1].Value.ToString();
            txtTongTien.Text = dgvPhieuNhapSach.Rows[index].Cells[2].Value.ToString();
            dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPNS.Text.Replace("PNS", "000"));
        }

        private void fQuanLyPhieuNhapSach_Load(object sender, EventArgs e)
        {
            txtSoPNS.Enabled = false;
            txtTongTien.Enabled = false;
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            fThemPhieuNhapSach f = new fThemPhieuNhapSach();
            f.ShowDialog();
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }

        private void btnThemCT_PhieuNhapSach_Click(object sender, EventArgs e)
        {
            fThemChiTietPhieuNhapSach f = new fThemChiTietPhieuNhapSach();
            f.ShowDialog();
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }

        private void dgvDSSachNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSSachNhap.CurrentRow.Index;
            txtMaSach.Text = dgvDSSachNhap.Rows[index].Cells[0].Value.ToString();
            txtTenSach.Text = dgvDSSachNhap.Rows[index].Cells[1].Value.ToString();
            domSoLuongNhap.Text = dgvDSSachNhap.Rows[index].Cells[2].Value.ToString();
            txtDonGia.Text = dgvDSSachNhap.Rows[index].Cells[3].Value.ToString();
            txtThanhTien.Text = dgvDSSachNhap.Rows[index].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuNhapSachBUS.Instance.DeletePhieuNhapSach(txtSoPNS.Text);
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuNhapSachBUS.Instance.UpdatePhieuNhapSach(txtSoPNS.Text, dtmNgayLap.Text);
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
        }
    }
}
