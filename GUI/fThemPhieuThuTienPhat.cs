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
using static System.Net.WebRequestMethods;

namespace GUI
{
    public partial class fThemPhieuThuTienPhat : Form
    {
        public fThemPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void fThemPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            txtTongNo.Enabled = false;
            txtTienConLai.Enabled = false;
            cboDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            cboDocGia.DisplayMember = "MADOCGIA";
            cboDocGia.ValueMember = "TENDOCGIA";
            cboDocGia.SelectedIndex = -1;
            txtTenDocGia.Text = "";
            txtTongNo.Text = "0";
        }

        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue != null)
            {
                txtTenDocGia.Text = cboDocGia.SelectedValue.ToString();
                if (DocGiaBUS.Instance.GetDocGiaByMaDocGia(cboDocGia.Text.ToString()).Rows.Count > 0)
                {

                    txtTongNo.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(cboDocGia.Text.ToString()).Rows[0]["TONGNO"].ToString();
                    txtSoTienThu.Text = "0";
                }
            }
                
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            int SoTienThu;
            if (Int32.TryParse(txtSoTienThu.Text, out SoTienThu))
            {
                txtTienConLai.Text = (Convert.ToInt32(txtTongNo.Text.ToString()) - SoTienThu).ToString();
            }
            else 
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienThu.Focus();
            }       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cboDocGia.SelectedValue == null) 
            {
                MessageBox.Show("Vui lòng chọn mã độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDocGia.Focus();
            }
            else if (txtSoTienThu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền thu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTienThu.Focus();
            }    
            else 
            {
                if (ThamSoBUS.Instance.GetThamSo().ApDungQDTienThu == 1)
                {
                    if (Convert.ToInt32(txtTienConLai.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Số tiền thu không được vượt quá tiền nợ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoTienThu.Focus();
                    }
                    else
                    {
                        PhieuThuTienPhat PTTP = new PhieuThuTienPhat();
                        PTTP.IDDocGia = Convert.ToInt32(cboDocGia.Text.ToString().Replace("DG", "00"));
                        PTTP.NgayThu = dtmNgayThu.Text.ToString();
                        PTTP.TongNo = Convert.ToInt32(txtTongNo.Text.ToString());
                        PTTP.SoTienThu = Convert.ToInt32(txtSoTienThu.Text.ToString());
                        if (PTTP.SoTienThu <= 0)
                        {
                            MessageBox.Show("Số tiền thu phải là số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoTienThu.Focus();
                        }
                        else
                        {
                            PTTP.ConLai = Convert.ToInt32(txtTienConLai.Text.ToString());
                            PhieuThuTienPhatBUS.Instance.InsertPhieuThuTienPhat(PTTP);
                            DocGiaBUS.Instance.UpdateDocGia(cboDocGia.Text.ToString(), txtTienConLai.Text.ToString());
                            MessageBox.Show("Thêm mới độc giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }               
                    }
                }
                else
                {
                    PhieuThuTienPhat PTTP = new PhieuThuTienPhat();
                    PTTP.IDDocGia = Convert.ToInt32(cboDocGia.Text.ToString().Replace("DG", "00"));
                    PTTP.NgayThu = dtmNgayThu.Text.ToString();
                    PTTP.TongNo = Convert.ToInt32(txtTongNo.Text.ToString());
                    PTTP.SoTienThu = Convert.ToInt32(txtSoTienThu.Text.ToString());
                    PTTP.ConLai = Convert.ToInt32(txtTienConLai.Text.ToString());
                    PhieuThuTienPhatBUS.Instance.InsertPhieuThuTienPhat(PTTP);
                    DocGiaBUS.Instance.UpdateDocGia(cboDocGia.Text.ToString(), txtTienConLai.Text.ToString());
                }
            }    
        }
    }
}
