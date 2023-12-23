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
    public partial class fThemTheLoai : Form
    {
        public fThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else if (TheLoaiBUS.Instance.GetTheLoaiByTenTheLoai(txtTenTheLoai.Text).Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại thể loại này. Vui lòng nhập tên thể loại khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else
            {
                TheLoaiBUS.Instance.InsertTheLoai(txtTenTheLoai.Text);
                MessageBox.Show("Thêm mới thể loại sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTheLoai.Text = "";
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
