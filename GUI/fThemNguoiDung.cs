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
            cboNhomNguoiDung.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNguoiDung.Focus();
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else if (txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
            }
            if (txtMatKhau.Text == txtNhapLaiMatKhau.Text) 
            {
                NguoiDung nguoidung = new NguoiDung();
                nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
                nguoidung.TenDangNhap = txtTenDangNhap.Text;
                nguoidung.MatKhau = txtMatKhau.Text;
                if (NguoiDungBUS.Instance.GetIDNguoiDungByTenDangNhap(nguoidung.TenDangNhap) != null) 
                {
                    MessageBox.Show("Tài khoản đã tồn tại vui lòng nhập tài khoản khác !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                }
                else if (cboNhomNguoiDung.SelectedValue != null)
                {
                    nguoidung.IDNhomNguoiDung = Convert.ToInt32(cboNhomNguoiDung.SelectedValue.ToString());
                    NguoiDungBUS.Instance.InsertNguoiDung(nguoidung);
                    txtTenNguoiDung.Text = "";
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtNhapLaiMatKhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng tên nhóm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboNhomNguoiDung.Focus();
                }     
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp! Vui lòng nhập lại!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
            }   
            
        }
    }
}
