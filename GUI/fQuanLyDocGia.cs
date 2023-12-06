using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Reflection;

namespace GUI
{
    public partial class fQuanLyDocGia : Form
    {
        public fQuanLyDocGia()
        {
            InitializeComponent();
        }
        private void fQuanLyDocGia_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = false;
            txtMaLoaiDocGia.Enabled = false;
            cboLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllTenLoaiDocGia();
            //cboLoaiDocGia.DisplayMember = "Name";
            cboLoaiDocGia.ValueMember = "TENLOAIDOCGIA";
            dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void dgvLoaiDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvLoaiDocGia.CurrentRow.Index;
            txtMaLoaiDocGia.Text = dgvLoaiDocGia.Rows[index].Cells[0].Value.ToString();
            txtTenLoaiDocGia.Text = dgvLoaiDocGia.Rows[index].Cells[1].Value.ToString();    
        }

        private void btnSuaLoaiDocGia_Click(object sender, EventArgs e)
        {
            LoaiDocGiaBUS.Instance.UpdateLoaiDocGia(txtMaLoaiDocGia.Text, txtTenLoaiDocGia.Text);
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
        }

        private void btnXoaLoaiDocGia_Click(object sender, EventArgs e)
        {
            LoaiDocGiaBUS.Instance.DeleteLoaiDocGia(txtMaLoaiDocGia.Text);
            txtMaLoaiDocGia.Text = "";
            txtTenLoaiDocGia.Text = "";
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
        }

        private void btnThemLoaiDocGia_Click(object sender, EventArgs e)
        {
            fThemLoaiDocGia f = new fThemLoaiDocGia();
            f.ShowDialog();
            dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
        }

        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvDocGia.CurrentRow.Index;
            txtMaDocGia.Text = dgvDocGia.Rows[index].Cells[0].Value.ToString();
            txtHoVaTen.Text = dgvDocGia.Rows[index].Cells[1].Value.ToString();
            dtmNgaySinh.Text = dgvDocGia.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDocGia.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvDocGia.Rows[index].Cells[4].Value.ToString();
            cboLoaiDocGia.Text = dgvDocGia.Rows[index].Cells[5].Value.ToString();
            dtmNgayLapThe.Text = dgvDocGia.Rows[index].Cells[6].Value.ToString();
            dtmNgayHetHan.Text = dgvDocGia.Rows[index].Cells[7].Value.ToString();
        }

        private void cboLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSuaDocGia_Click(object sender, EventArgs e)
        {

        }
    }
}
