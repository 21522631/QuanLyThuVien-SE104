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
    public partial class fThemSach : Form
    {
        public fThemSach()
        {
            InitializeComponent();
        }
        private void fThemSach_Load(object sender, EventArgs e)
        {
            cboTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            cboTheLoai.DisplayMember = "TENTHELOAI";
            cboTheLoai.ValueMember = "MATHELOAI";
            cboTheLoai.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.TenSach = txtTenSach.Text;
            sach.NhaXuatBan = txtNhaXuatBan.Text;
            sach.NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
            sach.IDTheLoai = cboTheLoai.SelectedValue.ToString().Replace("TL", "00");
            SachBUS.Instance.InsertSach(sach);
        }
    }
}
