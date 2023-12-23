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
    public partial class fThemChucNang : Form
    {
        public fThemChucNang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenChucNang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chức năng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenChucNang.Focus();
            }
            else if (txtTenManHinhDuocLoad.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên màn hình được load!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenManHinhDuocLoad.Focus();
            }
            else
            {
               
                ChucNang chucnang = new ChucNang();
                chucnang.TenChucNang = txtTenChucNang.Text;
                chucnang.TenManHinhDuocLoad = txtTenManHinhDuocLoad.Text;
                if (ChucNangBUS.Instance.GetChucNangByTenChucNang(chucnang).Rows.Count > 0 )
                {
                    MessageBox.Show("Chức năng đã tồn tại. Vui lòng nhập chức năng khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenChucNang.Focus();
                }
                else
                {
                    ChucNangBUS.Instance.InsertChucNang(chucnang);
                    MessageBox.Show("Thêm mới chức năng thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chucnang.TenChucNang = "";
                    chucnang.TenManHinhDuocLoad = "";
                }                  
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
