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
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
            dgvSach.Columns[0].HeaderCell.Value = "Mã sách";
            dgvSach.Columns[1].HeaderCell.Value = "Tên sách";
            dgvSach.Columns[2].HeaderCell.Value = "Mã thể loại";
            dgvSach.Columns[3].HeaderCell.Value = "Tên thể loại";
            dgvSach.Columns[4].HeaderCell.Value = "Nhà xuất bản";
            dgvSach.Columns[5].HeaderCell.Value = "Năm xuất bản";
            dgvSach.Columns[6].HeaderCell.Value = "Số lượng";
            dgvSach.Columns[7].HeaderCell.Value = "Giá tiền";
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            dgvTheLoai.Columns[0].HeaderCell.Value = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderCell.Value = "Tên thể loại";
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
            dgvTacGia.Columns[0].HeaderCell.Value = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderCell.Value = "Tên tác giả";
            dgvTacGia.Columns[2].HeaderCell.Value = "Ngày sinh";
            dgvTacGia.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuonSach.DataSource = CuonSachBUS.Instance.GetAllCuonSach();
            dgvCuonSach.Columns[0].HeaderCell.Value = "Mã cuốn sách";
            dgvCuonSach.Columns[1].HeaderCell.Value = "Mã sách";
            dgvCuonSach.Columns[2].HeaderCell.Value = "Tên sách";
            dgvCuonSach.Columns[3].HeaderCell.Value = "Tình trạng";
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
