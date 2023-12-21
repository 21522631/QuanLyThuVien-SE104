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
            ChucNang chucnang = new ChucNang();
            chucnang.TenChucNang = txtTenChucNang.Text;
            chucnang.TenManHinhDuocLoad = txtTenManHinhDuocLoad.Text;
            ChucNangBUS.Instance.InsertChucNang(chucnang);
            chucnang.TenChucNang = "";
            chucnang.TenManHinhDuocLoad = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
