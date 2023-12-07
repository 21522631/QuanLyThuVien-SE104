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
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSach.Text = cboMaSach.SelectedValue.ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text =Convert.ToString(Convert.ToInt32(txtDonGia.Text.ToString()) * Convert.ToInt32(domSoLuong.Text.ToString()));
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
            ct_PNS.ThanhTien = Convert.ToInt32(txtDonGia.Text);
            CT_PhieuNhapSachBUS.Instance.InsertCT_PhieuNhapSach(ct_PNS);
            dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(ct_PNS.IDPNS.ToString());
            txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text) + ct_PNS.ThanhTien).ToString();
        }

        private void cboSoPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(cboSoPhieuNhap.Text.Replace("PNS", "000"));
                int TongTien = 0;
                for(int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++) 
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
    }
}
