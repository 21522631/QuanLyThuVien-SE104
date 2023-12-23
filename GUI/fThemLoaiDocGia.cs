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
    public partial class fThemLoaiDocGia : Form
    {
        public fThemLoaiDocGia()
        {
            InitializeComponent();
        }
        private void fThemLoaiDocGia_Load(object sender, EventArgs e)
        {
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiDocGia.Focus();
            }
            else if (LoaiDocGiaBUS.Instance.GetLoaiDocGiaByTenLoaiDocGia(txtTenLoaiDocGia.Text).Rows.Count > 0)
            {
                MessageBox.Show("Loại độc giả này đã tồn tại. Vui lòng nhập lại tên loại độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiDocGia.Focus();
            }
            else
            {
                LoaiDocGiaBUS.Instance.InsertLoaiDocGia(txtTenLoaiDocGia.Text);
                MessageBox.Show("Thêm mới loại độc giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiDocGia.Text = "";
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
