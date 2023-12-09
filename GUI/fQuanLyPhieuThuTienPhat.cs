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
    public partial class fQuanLyPhieuThuTienPhat : Form
    {
        public fQuanLyPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void fQuanLyPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            cboDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            cboDocGia.DisplayMember = "MADOCGIA";
            cboDocGia.ValueMember = "MADOCGIA";
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
        }
    }
}
