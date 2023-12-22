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
    public partial class fDoiMatKhau : Form
    {
        private NguoiDung nguoidung;
        public fDoiMatKhau(ref NguoiDung nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nguoidung.MatKhau == txtMatKhauHienTai.Text)
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                {
                    nguoidung.MatKhau = txtMatKhauMoi.Text;
                    NguoiDungBUS.Instance.UpdateMatKhauNguoiDung(nguoidung.MaNguoiDung, nguoidung.MatKhau);
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauHienTai.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLaiMatKhau.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu thay đổi không khớp vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauMoi.Focus();
                }    
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng! Vui lòng nhập lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauHienTai.Focus();
            }    

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkHienThiMatKhau.Checked) 
            {
                txtMatKhauHienTai.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
            else 
            {
                txtMatKhauHienTai.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            } 
            
        }
    }
}
