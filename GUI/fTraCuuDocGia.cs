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
    public partial class fTraCuuDocGia : Form
    {
        public fTraCuuDocGia(int Index)
        {
            InitializeComponent();
            this.tabTraCuuDocGia.SelectedIndex = Index;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTraCuuDocGia_TextChanged(object sender, EventArgs e)
        {
            if(txtTraCuuDocGia.Text == "")
            {
                dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            }
            else
            {
                dgvDocGia.DataSource = DocGiaBUS.Instance.SearchDocGia(txtTraCuuDocGia.Text);
            }    
        }

        private void fTraCuuDocGia_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
        }

        private void txtTraCuuLoaiDocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuLoaiDocGia.Text == "")
            {
                dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
            }
            else
            {
               // dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.SearchLoaiDocGia(txtTraCuuDocGia.Text);
            }
        }
    }
}
