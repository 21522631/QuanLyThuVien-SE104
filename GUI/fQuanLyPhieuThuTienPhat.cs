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
            txtMaDocGia.Enabled = false;
            txtSoPhieuThu.Enabled = false;
            txtConLai.Enabled = false;
            txtSoTienThu.Enabled=false;
            txtTongNo.Enabled = false;
            dgvPTTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
            dgvPTTP.Columns[0].HeaderCell.Value = "Số phiếu thu";
            dgvPTTP.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPTTP.Columns[2].HeaderCell.Value = "Ngày thu";
            dgvPTTP.Columns[3].HeaderCell.Value = "Tổng nợ";
            dgvPTTP.Columns[4].HeaderCell.Value = "Số tiền thu";
            dgvPTTP.Columns[5].HeaderCell.Value = "Còn lại";
            dgvPTTP.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            if (txtSoPhieuThu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PhieuThuTienPhatBUS.Instance.UpdatePhieuThuTienPhat(txtSoPhieuThu.Text.ToString(), dtmNgayThu.Text.ToString());
                dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuThu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PhieuThuTienPhatBUS.Instance.DeletePhieuThuTienPhat(txtSoPhieuThu.Text.ToString());
                int TongNo = Convert.ToInt32(txtSoTienThu.Text.ToString()) + Convert.ToInt32(DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text.ToString()).Rows[0]["TONGNO"].ToString());
                DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text.ToString(), TongNo.ToString());
                dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoPhieuThu.Text = "";
                txtSoTienThu.Text = "";
                txtMaDocGia.Text = "";
                txtTongNo.Text = "";
                txtSoTienThu.Text = "";
                txtConLai.Text = "";
            }

        }
    }
}
