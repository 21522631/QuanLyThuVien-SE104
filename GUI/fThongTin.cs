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
    public partial class fThongTin : Form
    {
        private NguoiDung nguoidung;
        public fThongTin(ref NguoiDung nguoidung)
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
                txtChucNang.Text = txtChucNang.Text + Environment.NewLine + data.Rows[i][1].ToString() ;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.Instance.UpdateTenNguoiDung(txtMaNguoiDung.Text, txtTenNguoiDung.Text);
            nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(ref nguoidung);
            f.ShowDialog();
        }
    }
}
