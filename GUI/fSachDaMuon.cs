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
    public partial class fSachDaMuon : Form
    {
        private string MaDocGia;
        public fSachDaMuon(string MaDocGia)
        {
            InitializeComponent();
            this.MaDocGia = MaDocGia;
        }

        private void fSachDaMuon_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            txtTheLoai.Enabled = false;
            txtTenSach.Enabled = false;
            txtNhaXuatBan.Enabled = false;
            txtNamXuatBan.Enabled=false;
            txtGiaTien.Enabled = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.DataSource = SachBUS.Instance.GetAllSachDaMuonByIDDocGia(MaDocGia.Replace("DG", "00"));
            dgvSach.Columns[0].HeaderCell.Value = "Mã sách";
            dgvSach.Columns[1].HeaderCell.Value = "Tên sách";
            dgvSach.Columns[2].HeaderCell.Value = "Mã thể loại";
            dgvSach.Columns[3].HeaderCell.Value = "Tên thể loại";
            dgvSach.Columns[4].HeaderCell.Value = "Nhà xuất bản";
            dgvSach.Columns[5].HeaderCell.Value = "Năm xuất bản";
            dgvSach.Columns[6].HeaderCell.Value = "Giá tiền";
            dgvCT_TacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[index].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[index].Cells[1].Value.ToString();
            txtTheLoai.Text = dgvSach.Rows[index].Cells[3].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[index].Cells[4].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[index].Cells[5].Value.ToString();
            txtGiaTien.Text = dgvSach.Rows[index].Cells[6].Value.ToString();
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
            dgvCT_TacGia.Columns[0].HeaderCell.Value = "Mã tác giả";
            dgvCT_TacGia.Columns[1].HeaderCell.Value = "Tên tác giả";
        }
    }
}
