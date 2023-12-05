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
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;

            switch (DangNhapBUS.Instance.CheckDangNhap(TenDangNhap, MatKhau))
            {
                case 0:
                    txtTenDangNhap.Focus();
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi!", MessageBoxButtons.OK);
                    break;
                case 1:
                    fQuanTriVien fQTV = new fQuanTriVien();
                    this.Hide();
                    fQTV.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    fThuThu fTT = new fThuThu();
                    this.Hide();
                    fTT.ShowDialog();
                    this.Show();
                    break;
                case 3:
                    fDocGia fDG = new fDocGia();
                    this.Hide();
                    fDG.ShowDialog();
                    this.Show();
                    break;
            }
                
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
