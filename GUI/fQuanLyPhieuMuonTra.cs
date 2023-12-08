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
            txtNoCu.Enabled = false;
            txtTienPhat.Enabled = false;
            txtNoCu.Text = "";
            chkTinhTrang.Checked = false;
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
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
            txtNoCu.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text).Rows[0]["TONGNO"].ToString();
            if (chkTinhTrang.Checked == false) 
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
            string DaTra = CuonSachBUS.Instance.GetAllCuonSachByMaCuonSach(txtMaCuonSach.Text).Rows[0][0].ToString();
            if (DaTra == "0")
            {
                chkTinhTrang.Checked = false;
            } 
            else 
                chkTinhTrang.Checked = true;
        }

        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {
            PhieuMuonTra PMT = new PhieuMuonTra();
            PMT.SoPMT = txtSoPhieuMuonTra.Text;
            PMT.NgayMuon = dtmNgayMuon.Text;
            PMT.NgayPhaiTra = dtmNgayPhaiTra.Text;
            if (chkTinhTrang.Checked == false)
            {
               PMT.TienPhat = "0";
               PhieuMuonTraBUS.Instance.UpdatePhieuMuonTraVoiNull(PMT);
            }
            else
            {
                PMT.TienPhat = txtTienPhat.Text;
                PMT.NgayTra = dtmNgayTra.Text;
                PhieuMuonTraBUS.Instance.UpdatePhieuMuonTra(PMT);
                CuonSachBUS.Instance.UpdateCuonSach(txtMaCuonSach.Text, "1"); 
                DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, txtTongNo.Text);
            }
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
            txtNoCu.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(txtMaDocGia.Text).Rows[0]["TONGNO"].ToString();

        }

        private void dtmNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayPhaiTra.Text = Convert.ToString(dtmNgayMuon.Value.AddDays(ThamSoBUS.Instance.GetThamSo().SoNgayMuonToiDa));
        }

        private void btnXoaLoaiDocGia_Click(object sender, EventArgs e)
        {
            PhieuMuonTraBUS.Instance.DeletePhieuMuonTra(txtSoPhieuMuonTra.Text);
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
            CuonSachBUS.Instance.UpdateCuonSach(txtMaCuonSach.Text, "1");
            txtMaCuonSach.Text = "";
            txtSoPhieuMuonTra.Text = "";
            txtTienPhat.Text = "";
            txtMaDocGia.Text = "";
            dtmNgayMuon.Text = "";
            dtmNgayPhaiTra.Text = "";
            dtmNgayTra.Text = "";
            txtTienPhat.Text = "";
            txtTongNo.Text = "";
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
                    int TienPhat = SoNgayMuon * ThamSoBUS.Instance.GetThamSo().DonGiaPhat;
                    txtTienPhat.Text = TienPhat.ToString();
                    txtTongNo.Text = (Convert.ToInt32(txtNoCu.Text.ToString()) + TienPhat).ToString();
                }
            }
            else
            {
                txtTienPhat.Text = "0";
                txtTongNo.Text = txtNoCu.Text;
            }    
        }
    }
}
