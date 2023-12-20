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
    public partial class fQuanLyNguoiDung : Form
    {
        public fQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void fQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            txtMaNguoiDung.Enabled = false;
            txtTenDangNhap.Enabled = false; 
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
            cboNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            cboNhomNguoiDung.DisplayMember = "TENNHOM";
            cboNhomNguoiDung.ValueMember = "ID";
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNguoiDung.CurrentRow.Index;
            txtMaNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[0].Value.ToString();
            txtTenNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[1].Value.ToString();
            txtTenDangNhap.Text = dgvNguoiDung.Rows[index].Cells[2].Value.ToString();
            cboNhomNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[3].Value.ToString();
        }
        private void btnSuaNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDung nguoidung = new NguoiDung();
            nguoidung.MaNguoiDung = txtMaNguoiDung.Text;
            nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
            nguoidung.IDNhomNguoiDung = Convert.ToInt32(cboNhomNguoiDung.SelectedValue.ToString());
            NguoiDungBUS.Instance.UpdateNguoiDung(nguoidung);
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }
        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.Instance.DeleteNguoiDung(txtMaNguoiDung.Text);
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            fThemNguoiDung f = new fThemNguoiDung();
            f.ShowDialog();
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }
    }
}
