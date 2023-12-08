using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTraCuuSach : Form
    {
        public fTraCuuSach(int Index)
        {
            InitializeComponent();
            this.tabTraCuuSach.SelectedIndex = Index;
        }

        private void fTraCuuSach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
            dgvCuonSach.DataSource = CuonSachBUS.Instance.GetAllCuonSach();
        }

        private void txtTraCuuSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuSach.Text == "")
            {
                dgvSach.DataSource = SachBUS.Instance.GetAllSach();
            }
            else
            {
                dgvSach.DataSource = SachBUS.Instance.SearchSach(txtTraCuuSach.Text);
            }
        }

        private void txtTraCuuTheLoai_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuTheLoai.Text == "")
            {
                dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            }
            else
            {
                dgvTheLoai.DataSource = TheLoaiBUS.Instance.SearchTheLoai(txtTraCuuTheLoai.Text);
            }
        }

        private void txtTraCuuTacGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuTacGia.Text == "")
            {
                dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
            }
            else
            {
                dgvTacGia.DataSource = TacGiaBUS.Instance.SearchTacGia(txtTraCuuTacGia.Text);
            }
        }

        private void txtTraCuuCuonSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuCuonSach.Text == "")
            {
                dgvCuonSach.DataSource = CuonSachBUS.Instance.GetAllCuonSach();
            }
            else
            {
                dgvCuonSach.DataSource = CuonSachBUS.Instance.SearchCuonSach(txtTraCuuCuonSach.Text);
            }
        }
    }
}
