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
    public partial class fThongTinNguoiDung : Form
    {
        private NguoiDung nguoidung;
        public fThongTinNguoiDung(ref NguoiDung nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
        }

        private void fThongTin_Load(object sender, EventArgs e)
        {
            txtMaNguoiDung.Enabled = false;
            txtNhomNguoiDung.Enabled = false;
            txtTenDangNhap.Enabled = false; 
            txtChucNang.Enabled = false;
            txtMaNguoiDung.Text = nguoidung.MaNguoiDung.ToString();
            txtTenNguoiDung.Text = nguoidung.TenNguoiDung.ToString();
            txtNhomNguoiDung.Text = NhomNguoiDungBUS.Instance.GetNhomNguoiDungByID(nguoidung.IDNhomNguoiDung).Rows[0][2].ToString();
            txtTenDangNhap.Text = nguoidung.TenDangNhap.ToString();
            DataTable data = new DataTable();
            data = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(nguoidung.IDNhomNguoiDung);
            for(int i = 0; i < data.Rows.Count; i++) 
            {
                string test = data.Rows[i][1].ToString();
                txtChucNang.Text = txtChucNang.Text + Environment.NewLine + data.Rows[i][1].ToString() ;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại tên người dùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    NguoiDungBUS.Instance.UpdateTenNguoiDung(txtMaNguoiDung.Text, txtTenNguoiDung.Text);
                    nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
                    MessageBox.Show("Thông tin đã được thay đổi!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(ref nguoidung);
            f.ShowDialog();
        }

    }
}
