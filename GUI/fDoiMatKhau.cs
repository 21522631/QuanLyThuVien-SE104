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
            if (txtMatKhauHienTai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauHienTai.Focus();
            }
            else if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Focus();
            }
            else if (txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu lại mật khẩu mới!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau .Focus();
            }    
            else if (nguoidung.MatKhau == txtMatKhauHienTai.Text)
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
                {
                    if(txtMatKhauMoi.Text == txtMatKhauHienTai.Text)
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauMoi.Focus();
                    }    
                    else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        nguoidung.MatKhau = txtMatKhauMoi.Text;
                        NguoiDungBUS.Instance.UpdateMatKhauNguoiDung(nguoidung.MaNguoiDung, nguoidung.MatKhau);
                        MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatKhauHienTai.Text = "";
                        txtMatKhauMoi.Text = "";
                        txtNhapLaiMatKhau.Text = "";
                    }
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
