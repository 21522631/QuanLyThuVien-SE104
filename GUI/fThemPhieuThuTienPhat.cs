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
            cboDocGia.Text = "";
            txtTongNo.Text = "";
            txtTenDocGia.Text = "";
        }

        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenDocGia.Text = cboDocGia.SelectedValue.ToString();
                txtTongNo.Text = DocGiaBUS.Instance.GetDocGiaByMaDocGia(cboDocGia.Text.ToString()).Rows[0]["TONGNO"].ToString();
            }
            catch (Exception)
            {
            } 
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTienConLai.Text = (Convert.ToInt32(txtTongNo.Text.ToString()) - Convert.ToInt32(txtSoTienThu.Text.ToString())).ToString();
            }
            catch (Exception) 
            {
                txtTienConLai.Text = txtTongNo.Text.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThamSoBUS.Instance.GetThamSo().ApDungQDTienThu == 1)
            {
                if (Convert.ToInt32(txtTienConLai.Text.ToString()) < 0)
                {
                    MessageBox.Show("Số tiền thu không được vượt quá tiền nợ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
