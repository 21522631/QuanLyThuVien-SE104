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
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            dgvDocGia.Columns[0].HeaderCell.Value = "Mã độc giả";
            dgvDocGia.Columns[1].HeaderCell.Value = "Tên dộc giả";
            dgvDocGia.Columns[2].HeaderCell.Value = "Ngày sinh";
            dgvDocGia.Columns[3].HeaderCell.Value = "Địa chỉ";
            dgvDocGia.Columns[4].HeaderCell.Value = "Email";
            dgvDocGia.Columns[5].HeaderCell.Value = "Loại độc giả";
            dgvDocGia.Columns[6].HeaderCell.Value = "Ngày lập thẻ";
            dgvDocGia.Columns[7].HeaderCell.Value = "Ngày hết hạn";
            dgvDocGia.Columns[8].HeaderCell.Value = "Tổng nợ";
            dgvDocGia.Columns[9].HeaderCell.Value = "Mã người dùng";
            dgvDocGia.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDocGia.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDocGia.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvLoaiDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
            dgvLoaiDocGia.Columns[0].HeaderCell.Value = "Mã loại độc giả";
            dgvLoaiDocGia.Columns[1].HeaderCell.Value = "Tên loại dộc giả";
        }

        private void txtTraCuuLoaiDocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuLoaiDocGia.Text == "")
            {
                dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
            }
            else
            {
                dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.SearchLoaiDocGia(txtTraCuuLoaiDocGia.Text);
            }
        }
    }
}
