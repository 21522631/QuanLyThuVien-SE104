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

        private void btnThemDocGia_Click(object sender, EventArgs e)
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
            txtMaTacGia.Enabled = false;
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void dgtTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvTacGia.CurrentRow.Index;
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
    }
}
