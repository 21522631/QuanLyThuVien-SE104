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
            TheLoaiBUS.Instance.InsertTheLoai(txtTenTacGia.Text);
            txtTenTacGia.Text = "";
        }
    }
}
