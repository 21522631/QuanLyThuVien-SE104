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
    public partial class fThemNguoiDung : Form
    {
        public fThemNguoiDung()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemNguoiDung_Load(object sender, EventArgs e)
        {
            cboNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            cboNhomNguoiDung.DisplayMember = "TENNHOM";
            cboNhomNguoiDung.ValueMember = "ID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == txtNhapLaiMatKhau.Text) 
            {
                NguoiDung nguoidung = new NguoiDung();
                nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
                nguoidung.TenDangNhap = txtTenDangNhap.Text;
                nguoidung.MatKhau = txtMatKhau.Text;
                nguoidung.IDNhomNguoiDung = Convert.ToInt32(cboNhomNguoiDung.SelectedValue.ToString());
                NguoiDungBUS.Instance.InsertNguoiDung(nguoidung);
                txtTenNguoiDung.Text = "";
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtNhapLaiMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp! Vui lòng nhập lại!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
            }   
            
        }
    }
}
