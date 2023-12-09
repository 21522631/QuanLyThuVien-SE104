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
            txtSoTienThu.Text = dgvPTTP.Rows[index].Cells[4].Value.ToString();
            txtConLai.Text = dgvPTTP.Rows[index].Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuThuTienPhatBUS.Instance.UpdatePhieuThuTienPhat(txtSoPhieuThu.Text.ToString(), dtmNgayThu.Text.ToString());
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuThuTienPhatBUS.Instance.DeletePhieuThuTienPhat(txtSoPhieuThu.Text.ToString());
            int TongNo = Convert.ToInt32(txtSoTienThu.Text.ToString()) + Convert.ToInt32(DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text.ToString()).Rows[0]["TONGNO"].ToString());
            DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text.ToString(), TongNo.ToString());
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();

        }
    }
}
