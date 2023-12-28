using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fQuanLyPhieuMuonTra : Form
    {
        public fQuanLyPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void fPhieuMuonTra_Load(object sender, EventArgs e)
        {
            txtMaCuonSach.Enabled = false;
            txtSoPhieuMuonTra.Enabled = false;
            txtMaCuonSach.Enabled = false;
            txtMaDocGia.Enabled = false;
            txtNoCu.Enabled = false;
            txtTienPhat.Enabled = false;
            txtNoCu.Text = "0";
            txtTongNo.Enabled = false;
            dtmNgayMuon.Enabled = false;
            chkTinhTrang.Checked = false;
            dtmNgayPhaiTra.Enabled = false;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
            dgvPhieuMuon.Columns[0].HeaderCell.Value = "Số phiếu mượn";
            dgvPhieuMuon.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPhieuMuon.Columns[2].HeaderCell.Value = "Mã cuốn sách";
            dgvPhieuMuon.Columns[3].HeaderCell.Value = "Ngày mượn";
            dgvPhieuMuon.Columns[4].HeaderCell.Value = "Ngày phải trả";
            dgvPhieuMuon.Columns[5].HeaderCell.Value = "Ngày trả";
            dgvPhieuMuon.Columns[6].HeaderCell.Value = "Tiền phạt";
            dgvPhieuMuon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuon.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuon.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            fThemPhieuMuonTra f = new fThemPhieuMuonTra();
            f.ShowDialog();
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhieuMuon.CurrentRow.Index;
            dtmNgayMuon.Format = DateTimePickerFormat.Custom;
            txtSoPhieuMuonTra.Text = dgvPhieuMuon.Rows[index].Cells[0].Value.ToString();
            txtMaDocGia.Text = dgvPhieuMuon.Rows[index].Cells[1].Value.ToString();
            txtMaCuonSach.Text = dgvPhieuMuon.Rows[index].Cells[2].Value.ToString();
            dtmNgayMuon.Text = dgvPhieuMuon.Rows[index].Cells[3].Value.ToString();
            dtmNgayPhaiTra.Text = dgvPhieuMuon.Rows[index].Cells[4].Value.ToString();
            dtmNgayTra.Text = dgvPhieuMuon.Rows[index].Cells[5].Value.ToString();
            if (index != 0)
            {
                txtNoCu.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text).Rows[0]["TONGNO"].ToString();
            }
            if (dgvPhieuMuon.Rows[index].Cells[5].Value.ToString() == "")
            {
                chkTinhTrang.Checked = false;
                txtTienPhat.Text = "0";
                txtTongNo.Text = txtNoCu.Text;
            }
            else
            {
                chkTinhTrang.Checked = true;
            }
        }

        private void dtmNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayPhaiTra.Text = Convert.ToString(dtmNgayMuon.Value.AddDays(ThamSoBUS.Instance.GetThamSo().SoNgayMuonToiDa));
        }

        private void chkTinhTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTinhTrang.Checked)
            {
                int SoNgayMuon = dtmNgayTra.Value.Subtract(dtmNgayPhaiTra.Value).Days;
                if (SoNgayMuon < 0)
                {
                    txtTienPhat.Text = "0";
                    txtTongNo.Text = txtNoCu.Text;
                }
                else
                {
                    int NoCu;
                    int TienPhat = SoNgayMuon * ThamSoBUS.Instance.GetThamSo().DonGiaPhat;
                    txtTienPhat.Text = TienPhat.ToString();
                    if (Int32.TryParse(txtNoCu.Text.ToString(), out NoCu))
                    {
                        txtTongNo.Text = (NoCu + TienPhat).ToString();
                    }
                }
            }
            else
            {
                txtTienPhat.Text = "0";
                txtTongNo.Text = txtNoCu.Text;
            }    
        }

        private void btnSuaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuMuonTra.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                PhieuMuonTra PMT = new PhieuMuonTra();
                PMT.SoPMT = txtSoPhieuMuonTra.Text;
                PMT.NgayMuon = dtmNgayMuon.Text;
                PMT.NgayPhaiTra = dtmNgayPhaiTra.Text;
                if (chkTinhTrang.Checked == false)
                {
                    int TienPhat = Convert.ToInt32(dgvPhieuMuon.Rows[dgvPhieuMuon.CurrentRow.Index].Cells[6].Value.ToString());
                    if (TienPhat > 0) 
                    {
                        txtTongNo.Text = (Convert.ToInt32(txtTongNo.Text) - TienPhat).ToString();
                        DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, txtTongNo.Text);
                    }
                    PMT.TienPhat = "0";
                    PhieuMuonTraBUS.Instance.UpdatePhieuMuonTraVoiNull(PMT);
                    CuonSachBUS.Instance.UpdateCuonSach(txtMaCuonSach.Text, "0");

                }
                else
                {
                    PMT.TienPhat = txtTienPhat.Text;
                    PMT.NgayTra = dtmNgayTra.Text;
                    PhieuMuonTraBUS.Instance.UpdatePhieuMuonTra(PMT);
                    CuonSachBUS.Instance.UpdateCuonSach(txtMaCuonSach.Text, "1");
                    DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, txtTongNo.Text);
                }
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
                txtNoCu.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text).Rows[0]["TONGNO"].ToString();
            }
        }

        private void dtmNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (chkTinhTrang.Checked == true)
            {
                int SoNgayMuon = dtmNgayTra.Value.Subtract(dtmNgayPhaiTra.Value).Days;
                if (SoNgayMuon < 0)
                {
                    txtTienPhat.Text = "0";
                    txtTongNo.Text = txtNoCu.Text;
                }
                else
                {
                    int TienPhat = SoNgayMuon * ThamSoBUS.Instance.GetThamSo().DonGiaPhat;
                    txtTienPhat.Text = TienPhat.ToString();
                    txtTongNo.Text = (Convert.ToInt32(txtNoCu.Text.ToString()) + TienPhat).ToString();
                }
            }
            else 
            {

            } 
                
        }

        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (txtSoPhieuMuonTra.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {

                CuonSachBUS.Instance.UpdateCuonSach(txtMaCuonSach.Text, "1");
                int TienPhat = Convert.ToInt32(dgvPhieuMuon.Rows[dgvPhieuMuon.CurrentRow.Index].Cells[6].Value.ToString());
                int TongNo = Convert.ToInt32(DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text).Rows[0]["TONGNO"].ToString());
                if (TienPhat > 0)
                {
                    DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, (TongNo - TienPhat).ToString());
                }
                PhieuMuonTraBUS.Instance.DeletePhieuMuonTra(txtSoPhieuMuonTra.Text);
                dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
                txtMaCuonSach.Text = "";
                txtSoPhieuMuonTra.Text = "";
                txtMaDocGia.Text = "";
                txtNoCu.Text = "0";
                dtmNgayMuon.Text = "";
                dtmNgayPhaiTra.Text = "";
                dtmNgayTra.Text = "";
                txtTienPhat.Text = "0";
                txtTongNo.Text = "0";
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
