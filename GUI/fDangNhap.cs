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
            NguoiDung nguoidung = new NguoiDung();
            nguoidung = DangNhapBUS.Instance.CheckDangNhap(TenDangNhap, MatKhau);
            if (nguoidung == null)
            {
                txtTenDangNhap.Focus();
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi!", MessageBoxButtons.OK);
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
                        fDocGia fDG = new fDocGia();
                        this.Hide();
                        fDG.ShowDialog();
                        this.Show();
                        break;
                }
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
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

        }
    }
}
