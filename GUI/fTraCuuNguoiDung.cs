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
    public partial class fTraCuuNguoiDung : Form
    {
        public fTraCuuNguoiDung()
        {
            InitializeComponent();
        }

        private void fTraCuuNguoiDung_Load(object sender, EventArgs e)
        {
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
            dgvNguoiDung.Columns[0].HeaderCell.Value = "Mã người dùng";
            dgvNguoiDung.Columns[1].HeaderCell.Value = "Tên người dùng";
            dgvNguoiDung.Columns[2].HeaderCell.Value = "Tên đăng nhập";
            dgvNguoiDung.Columns[3].HeaderCell.Value = "Tên nhóm người dùng";
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.SearchNguoiDung(txtTraCuu.Text);
        }
    }
}
