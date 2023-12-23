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
    public partial class fThemNhomNguoiDung : Form
    {
        public fThemNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNhom.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại tên nhóm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhom.Focus();
            }
            else if (NhomNguoiDungBUS.Instance.GetNhomNguoiDungByTenNhom(txtTenNhom.Text).Rows.Count > 0)
            {
                MessageBox.Show("Nhóm đã tồn tại. Vui lòng nhập lại tên nhóm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhom.Focus();
            }    
            else
            {
                NhomNguoiDungBUS.Instance.InsertNhomNguoiDung(txtTenNhom.Text);
                MessageBox.Show("Thêm mới nhóm người dùng thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhom.Text = "";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
