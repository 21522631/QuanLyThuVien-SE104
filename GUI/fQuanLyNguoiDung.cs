using BUS;
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
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNguoiDung.CurrentRow.Index;
            txtMaNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[0].Value.ToString();
            txtTenNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[1].Value.ToString();
            txtTenDangNhap.Text = dgvNguoiDung.Rows[index].Cells[2].Value.ToString();
            cboNhomNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[3].Value.ToString();
        }
    }
}
