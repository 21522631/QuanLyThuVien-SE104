using BUS;
using DTO;
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
            dgvDSSachNhap.Columns[0].HeaderCell.Value = "Mã sách";
            dgvDSSachNhap.Columns[1].HeaderCell.Value = "Tên sách";
            dgvDSSachNhap.Columns[2].HeaderCell.Value = "Số lượng";
            dgvDSSachNhap.Columns[3].HeaderCell.Value = "Đơn giá";
            dgvDSSachNhap.Columns[4].HeaderCell.Value = "Thành tiền";
        }

        private void fQuanLyPhieuNhapSach_Load(object sender, EventArgs e)
        {
            txtSoPNS.Enabled = false;
            txtTongTien.Enabled = false;
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtDonGia.Enabled = false;
            domSoLuongNhap.Enabled = false;
            txtThanhTien.Enabled = false;
            dgvDSSachNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhapSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
            dgvPhieuNhapSach.Columns[0].HeaderCell.Value = "Số phiếu nhập sách";
            dgvPhieuNhapSach.Columns[1].HeaderCell.Value = "Ngày lập phiếu";
            dgvPhieuNhapSach.Columns[2].HeaderCell.Value = "Tổng tiền";
            dgvPhieuNhapSach.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

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
            if (txtSoPNS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {         
                DataTable data = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPNS.Text.Replace("PNS", "000"));
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    SachBUS.Instance.UpdateSach(-Convert.ToInt32(data.Rows[i][2].ToString()), data.Rows[i][3].ToString(), data.Rows[i][0].ToString());
                    CuonSachBUS.Instance.DeleteCuonSach(data.Rows[i][0].ToString().Replace("SA","00"), data.Rows[i][2].ToString());
                }
                PhieuNhapSachBUS.Instance.DeletePhieuNhapSach(txtSoPNS.Text);
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoPNS.Text = "";
                txtTongTien.Text = "";
                dgvDSSachNhap.DataSource = null;
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoPNS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PhieuNhapSachBUS.Instance.UpdatePhieuNhapSach(txtSoPNS.Text, dtmNgayLap.Text);
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
