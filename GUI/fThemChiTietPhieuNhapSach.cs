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
        private int DaLuu; 
        public fThemChiTietPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void fThemChiTietPhieuNhapSach_Load(object sender, EventArgs e)
        {
            DaLuu = 0;
            cboMaSach.DataSource = SachBUS.Instance.GetAllSach();
            cboMaSach.DisplayMember = "MASACH";
            cboMaSach.ValueMember = "MASACH";
            cboMaSach.SelectedIndex = -1;
            txtTenSach.Enabled = false;
            txtTenSach.Text = "";
            txtThanhTien.Text = "0";
            txtSoPhieuNhap.Enabled = false;
            txtTongTien.Enabled = false;
            txtThanhTien.Enabled = false;
            txtDonGia.Enabled = false;
            dtmNgayLap.Enabled = false;
            txtSoPhieuNhap.Text = PhieuNhapSachBUS.Instance.GetLatestPhieuNhapSach().Rows[0][1].ToString();
            txtTongTien.Text = "0";
            dgvDSSachNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPhieuNhap.Text.Replace("PNS", "000"));
            dgvDSSachNhap.Columns[0].HeaderCell.Value = "Mã sách";
            dgvDSSachNhap.Columns[1].HeaderCell.Value = "Tên sách";
            dgvDSSachNhap.Columns[2].HeaderCell.Value = "Số lượng";
            dgvDSSachNhap.Columns[3].HeaderCell.Value = "Đơn giá";
            dgvDSSachNhap.Columns[4].HeaderCell.Value = "Thành tiền";

        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue != null)
            {
                DataTable data =SachBUS.Instance.GetAllSachByMaSach(cboMaSach.SelectedValue.ToString());
                if( data.Rows.Count > 0)
                {
                    txtTenSach.Text = data.Rows[0][1].ToString();
                    txtDonGia.Text = data.Rows[0][6].ToString();
                    txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text.ToString()) * Convert.ToInt32(domSoLuong.Text.ToString()));
                    domSoLuong.Text = "1";
                }      
            }
            else
            {
                txtTenSach.Text = "";
                txtDonGia.Text = "0";
            }    
        }

        private void btnThemSachNhap_Click(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lại mã sách!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaSach.Focus();
            }
            else if (CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNSAndIDSach(txtSoPhieuNhap.Text.Replace("PNS", "000"), cboMaSach.Text.Replace("SA", "00")).Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại chi tiết phiếu nhập. Vui lòng kiếm tra lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaSach.Focus();
            }
            else
            {
                CT_PhieuNhapSach ct_PNS = new CT_PhieuNhapSach();
                ct_PNS.IDPNS = Convert.ToInt32(txtSoPhieuNhap.Text.Replace("PNS", "000"));
                ct_PNS.IDSach = Convert.ToInt32(cboMaSach.Text.Replace("SA", "00"));
                ct_PNS.DonGia = Convert.ToInt32(txtDonGia.Text);
                ct_PNS.SoLuongNhap = Convert.ToInt32(domSoLuong.Text);
                ct_PNS.ThanhTien = (Convert.ToInt32(txtThanhTien.Text.ToString()));
                CT_PhieuNhapSachBUS.Instance.InsertCT_PhieuNhapSach(ct_PNS);
                dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(ct_PNS.IDPNS.ToString());
                txtTongTien.Text = ((Convert.ToInt32(txtTongTien.Text.ToString())) + ct_PNS.ThanhTien).ToString();
            }    
            
        }

        private void cboSoPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPhieuNhap.Text.Replace("PNS", "000"));
                int TongTien = 0;
                for (int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++)
                {
                    TongTien = TongTien + Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[4].Value);
                }
                txtTongTien.Text = TongTien.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dgvDSSachNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSSachNhap.Rows.Count > 1)
            {
                int index = dgvDSSachNhap.CurrentRow.Index;
                cboMaSach.Text = dgvDSSachNhap.Rows[index].Cells[0].Value.ToString();
                domSoLuong.Text = dgvDSSachNhap.Rows[index].Cells[2].Value.ToString();
                txtDonGia.Text = dgvDSSachNhap.Rows[index].Cells[3].Value.ToString();
                txtDonGia.Text = dgvDSSachNhap.Rows[index].Cells[4].Value.ToString();
            }    
        }

        private void btnXoaSachNhap_Click(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lại mã sách!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaSach.Focus();
            }
            else if (CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNSAndIDSach(txtSoPhieuNhap.Text.Replace("PNS", "000"), cboMaSach.Text.Replace("SA", "00")).Rows.Count > 0)
            {
                CT_PhieuNhapSachBUS.Instance.DeleteCT_PhieuNhapSach(txtSoPhieuNhap.Text.Replace("PNS", "000"), cboMaSach.Text.Replace("SA", "00"));
                dgvDSSachNhap.DataSource = CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPhieuNhap.Text.Replace("PNS", "000"));
                txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text) - Convert.ToInt32(txtThanhTien.Text)).ToString();
                cboMaSach.Text = "";
                txtTenSach.Text = "";
                txtDonGia.Text = "0";
                txtThanhTien.Text = "0";
                domSoLuong.Text = "1";    
            }
            else
            {
                MessageBox.Show("Không tồn tại chi tiết phiếu nhập. Vui lòng kiếm tra lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaSach.Focus();
            }    
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (CT_PhieuNhapSachBUS.Instance.GetCT_PhieuNhapSachByIDPNS(txtSoPhieuNhap.Text.Replace("PNS", "000")).Rows.Count > 0)
            {
                DaLuu = 1;
                PhieuNhapSach PNS = new PhieuNhapSach();
                PNS.SoPNS = txtSoPhieuNhap.Text;
                PNS.TongTien = Convert.ToInt32(txtTongTien.Text.ToString());
                PhieuNhapSachBUS.Instance.UpdatePhieuNhapSach(PNS);
                CuonSach cuonsach = new CuonSach();
                for (int i = 0; i < dgvDSSachNhap.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[2].Value.ToString()); j++)
                        CuonSachBUS.Instance.InsertCuonSach(dgvDSSachNhap.Rows[i].Cells[0].Value.ToString().Replace("SA", "00"));
                    SachBUS.Instance.UpdateSach(Convert.ToInt32(dgvDSSachNhap.Rows[i].Cells[2].Value.ToString()), dgvDSSachNhap.Rows[i].Cells[3].Value.ToString(), dgvDSSachNhap.Rows[i].Cells[0].Value.ToString());
                }
                MessageBox.Show("Thêm phiếu nhập sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Không tồn tại sách nhập. Vui lòng kiếm tra lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaSach.Focus();
                DaLuu = 0;
            } 
                
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (DaLuu != 0)
            {
                this.Close();
            }
            else
            {
                PhieuNhapSachBUS.Instance.DeletePhieuNhapSach(txtSoPhieuNhap.Text);
                this.Close();
            }
        }

        private void domSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text.ToString()) * Convert.ToInt32(domSoLuong.Text.ToString()));
        }
    }
}
