using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fThemChiTietPhieuNhapSach : Form
    {
        int Count = 0;
        public fThemChiTietPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void fThemChiTietPhieuNhapSach_Load(object sender, EventArgs e)
        {
            cboSoPhieuNhap.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
            cboSoPhieuNhap.Text = "";
            cboSoPhieuNhap.DisplayMember = "SOPNS";
            cboSoPhieuNhap.ValueMember = "SOPNS";
            cboSoPhieuNhap.Text = "";
            cboMaSach.DataSource = SachBUS.Instance.GetAllSach();
            cboMaSach.DisplayMember = "MASACH";
            cboMaSach.ValueMember = "TENSACH";
            cboMaSach.Text = "";
            txtTenSach.Enabled = false;
            txtTenSach.Text = "";
            txtDonGia.Text = "0";
            Count = 1;
            txtTongTien.Enabled = false;
            txtThanhTien.Enabled = false;
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSach.Text = cboMaSach.SelectedValue.ToString();

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text.ToString()) * Convert.ToInt32(domSoLuong.Text.ToString()));
        }

        private void domSoLuong_SelectedItemChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text.ToString()) * Convert.ToInt32(domSoLuong.Text.ToString()));
        }

        private void btnThemSachNhap_Click(object sender, EventArgs e)
        {
            CT_PhieuNhapSach ct_PNS = new CT_PhieuNhapSach();
            ct_PNS.IDPNS = Convert.ToInt32(cboSoPhieuNhap.Text.Replace("PNS", "000"));
            ct_PNS.IDSach = Convert.ToInt32(cboMaSach.Text.Replace("SA", "00"));
            ct_PNS.DonGia = Convert.ToInt32(txtDonGia.Text);
            ct_PNS.SoLuongNhap = Convert.ToInt32(domSoLuong.Text);
            ct_PNS.ThanhTien = (Convert.ToInt32(txtThanhTien.Text.ToString()));
            CT_PhieuNhapSachBUS.Instance.InsertCT_PhieuNhapSach(ct_PNS);
            dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(ct_PNS.IDPNS.ToString());
            txtTongTien.Text = ((Convert.ToInt32(txtTongTien.Text.ToString())) + ct_PNS.ThanhTien).ToString();
        }

        private void cboSoPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(cboSoPhieuNhap.Text.Replace("PNS", "000"));
                int TongTien = 0;
                for (int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++)
                {
                    TongTien = TongTien + Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[4].Value);
                }
                txtTongTien.Text = TongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuốn sách sẽ được thêm tự động khi lưu!");
            }
        }

        private void dgvDSSachNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSSachNhap.CurrentRow.Index;
            cboMaSach.Text = dgvDSSachNhap.Rows[index].Cells[0].Value.ToString();
            domSoLuong.Text = dgvDSSachNhap.Rows[index].Cells[2].Value.ToString();
            txtDonGia.Text = dgvDSSachNhap.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dgvDSSachNhap.Rows[index].Cells[4].Value.ToString();
        }

        private void btnXoaSachNhap_Click(object sender, EventArgs e)
        {
            CT_PhieuNhapSachBUS.Instance.DeleteCT_PhieuNhapSach(cboSoPhieuNhap.Text.Replace("PNS", "000"), cboMaSach.Text.Replace("SA", "00"));
            dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(cboSoPhieuNhap.Text.Replace("PNS", "000"));
            cboMaSach.Text = "";
            txtTenSach.Text = "";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            domSoLuong.Text = "00";
            int TongTien = 0;
            for (int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++)
            {
                TongTien = TongTien + Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[4].Value);
            }
            txtTongTien.Text = TongTien.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuNhapSach PNS = new PhieuNhapSach();
            PNS.SoPNS = cboSoPhieuNhap.Text;
            PNS.TongTien = Convert.ToInt32(txtTongTien.Text.ToString());
            PhieuNhapSachBUS.Instance.UpdatePhieuNhapSach(PNS);
            CuonSach cuonsach = new CuonSach();
            for (int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++)
            {
                for(int j = 0; j < Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[2].Value.ToString()); j++)
                    CuonSachBUS.Instance.InsertCuonSach(dgvDSSachNhap.Rows[i].Cells[0].Value.ToString().Replace("SA", "00"));//0 ma sah//2 la so luong
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
