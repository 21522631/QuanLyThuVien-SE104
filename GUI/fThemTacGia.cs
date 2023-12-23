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
using BUS;

namespace GUI
{
    public partial class fThemTacGia : Form
    {
        public fThemTacGia()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTacGia.Focus();
            }
            else
            {
                TacGia tacgia = new TacGia();
                tacgia.TenTacGia = txtTenTacGia.Text;
                tacgia.NgaySinh = dtmNgaySinh.Text;
                TacGiaBUS.Instance.InsertTacGia(tacgia);
                MessageBox.Show("Thêm mới tác giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTacGia.Text = "";
            }    
        }
    }
}
