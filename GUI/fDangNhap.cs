using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
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
            else
            {
                string TenDangNhap = txtTenDangNhap.Text;
                string MatKhau = txtMatKhau.Text;
                NguoiDung nguoidung = new NguoiDung();
                nguoidung = DangNhapBUS.Instance.CheckDangNhap(TenDangNhap, MatKhau);
                if (nguoidung == null)
                {
                    txtTenDangNhap.Focus();
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    switch (nguoidung.IDNhomNguoiDung)
                    {
                        case 1:
                            fQuanTriVien fQTV = new fQuanTriVien(nguoidung);
                            this.Hide();
                            fQTV.ShowDialog();
                            this.Show();
                            break;
                        case 2:
                            fThuThu fTT = new fThuThu(nguoidung);
                            this.Hide();
                            fTT.ShowDialog();
                            this.Show();
                            break;
                        case 3:
                            fDocGia fDG = new fDocGia(nguoidung);
                            this.Hide();
                            fDG.ShowDialog();
                            this.Show();
                            break;
                    }
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                }
            }
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTenDangNhap;
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự có muốn thoát chương trình!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
