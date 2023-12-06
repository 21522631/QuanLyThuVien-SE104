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
            if(LoaiDocGiaBUS.Instance.InsertLoaiDocGia(txtTenLoaiDocGia.Text) > 0)
            {
                MessageBox.Show("Thông tin đã được lưu!", "Thành công!", MessageBoxButtons.OK);
                txtTenLoaiDocGia.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại!", "Thất bại!", MessageBoxButtons.OK);
            } 
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
