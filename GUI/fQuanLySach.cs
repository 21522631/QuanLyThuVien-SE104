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
    public partial class fQuanLySach : Form
    {
        public fQuanLySach()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void fQuanLySach_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            txtMaTacGia.Enabled = false;
            txtGiaTien.Enabled = false;
            domSoLuong.Enabled = false;
            cboTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            cboTheLoai.DisplayMember = "TENTHELOAI";
            cboTheLoai.ValueMember = "MATHELOAI";
            cboTheLoai.Text = "";
            cboMaTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
            cboMaTacGia.DisplayMember = "MATACGIA";
            cboMaTacGia.ValueMember = "MATACGIA";
            cboMaTacGia.Text = "";
            txtMaTheLoai.Enabled = false;
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void dgtTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTacGia.CurrentRow.Index;
            txtMaTacGia.Text = dgvTacGia.Rows[index].Cells[0].Value.ToString();
            txtTenTacGia.Text = dgvTacGia.Rows[index].Cells[1].Value.ToString();
            dtmNgaySinh.Text = dgvTacGia.Rows[index].Cells[2].Value.ToString();
        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            TacGia tacgia = new TacGia();
            tacgia.MaTacGia = txtMaTacGia.Text;
            tacgia.TenTacGia = txtTenTacGia.Text;
            tacgia.NgaySinh = dtmNgaySinh.Text;
            TacGiaBUS.Instance.UpdateTacGia(tacgia);
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            fThemTacGia f = new fThemTacGia();
            f.ShowDialog();
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            TacGiaBUS.Instance.DeleteTacGia(txtMaTacGia.Text);
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            dtmNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void txtMaTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            fThemTheLoai f = new fThemTheLoai();
            f.ShowDialog();
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            TheLoai theloai = new TheLoai();
            theloai.MaTheLoai = txtMaTheLoai.Text;
            theloai.TenTheLoai = txtTenTheLoai.Text;
            TheLoaiBUS.Instance.UpdateTheLoai(theloai);
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
        }

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTheLoai.CurrentRow.Index;
            txtMaTheLoai.Text = dgvTheLoai.Rows[index].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.Rows[index].Cells[1].Value.ToString();
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            TheLoaiBUS.Instance.DeleteTheLoai(txtMaTheLoai.Text);
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSach.CurrentRow.Index;
            txtMaSach.Text = dgvSach.Rows[index].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[index].Cells[1].Value.ToString();
            cboTheLoai.Text = dgvSach.Rows[index].Cells[3].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[index].Cells[4].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[index].Cells[5].Value.ToString();
            domSoLuong.Text = dgvSach.Rows[index].Cells[6].Value.ToString();
            txtGiaTien.Text = dgvSach.Rows[index].Cells[7].Value.ToString();
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
        }

        private void dgvCT_TacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCT_TacGia.CurrentRow.Index;
            cboMaTacGia.Text = dgvCT_TacGia.Rows[index].Cells[0].Value.ToString();
        }

        private void btnThemDSTG_Click(object sender, EventArgs e)
        {
            CT_TacGia ct_tacgia = new CT_TacGia();
            ct_tacgia.IDSach = Convert.ToInt32(txtMaSach.Text.Replace("SA", "00"));
            ct_tacgia.IDTacGia = Convert.ToInt32(cboMaTacGia.Text.Replace("TG", "00"));
            CT_TacGiaBUS.Instance.InsertCT_TacGia(ct_tacgia);
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
        }

        private void XoaDSTG_Click(object sender, EventArgs e)
        {
            CT_TacGia ct_tacgia = new CT_TacGia();
            ct_tacgia.IDSach = Convert.ToInt32(txtMaSach.Text.Replace("SA", "00"));
            ct_tacgia.IDTacGia = Convert.ToInt32(cboMaTacGia.Text.Replace("TG", "00"));
            CT_TacGiaBUS.Instance.DeleteCT_TacGia(ct_tacgia);
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.IDTheLoai = cboTheLoai.SelectedValue.ToString().Replace("TL", "00");
            sach.NhaXuatBan = txtNhaXuatBan.Text;
            sach.NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
            SachBUS.Instance.UpdateSach(sach);
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            SachBUS.Instance.DeleteSach(txtMaSach.Text);
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboTheLoai.Text = "";
            txtNhaXuatBan.Text = "";
            txtNamXuatBan.Text = "";
            domSoLuong.Text = "";
            txtGiaTien.Text = "";
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            fThemSach f = new fThemSach();
            f.ShowDialog();
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
