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
    public partial class fQuanLyNguoiDung : Form
    {
        public fQuanLyNguoiDung(int Index)
        {
            InitializeComponent();
            this.tabQuanNguoiDung.SelectedIndex = Index;

        }

        private void fQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            txtMaNguoiDung.Enabled = false;
            txtTenDangNhap.Enabled = false; 
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
            cboNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            cboNhomNguoiDung.DisplayMember = "TENNHOM";
            cboNhomNguoiDung.ValueMember = "ID";
            txtMaNhomNguoiDung.Enabled = false;
            dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            dgvNhomNguoiDung.Columns["ID"].Visible = false;
            txtMaChucNang.Enabled = false;
            dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
            dgvChucNang.Columns["ID"].Visible = false;
            cboMaNhomNguoiDungPQ.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            cboMaNhomNguoiDungPQ.DisplayMember = "MANHOM";
            cboMaNhomNguoiDungPQ.ValueMember = "ID";
            cboMaNhomNguoiDungPQ.SelectedItem = null;
            cboChucNangPQ.DataSource = ChucNangBUS.Instance.GetAllChucNang();
            cboChucNangPQ.DisplayMember = "MACHUCNANG";
            cboChucNangPQ.ValueMember = "ID";
            cboChucNangPQ.SelectedItem = null;

        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNguoiDung.CurrentRow.Index;
            txtMaNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[0].Value.ToString();
            txtTenNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[1].Value.ToString();
            txtTenDangNhap.Text = dgvNguoiDung.Rows[index].Cells[2].Value.ToString();
            cboNhomNguoiDung.Text = dgvNguoiDung.Rows[index].Cells[3].Value.ToString();
        }
        private void btnSuaNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDung nguoidung = new NguoiDung();
            nguoidung.MaNguoiDung = txtMaNguoiDung.Text;
            nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
            nguoidung.IDNhomNguoiDung = Convert.ToInt32(cboNhomNguoiDung.SelectedValue.ToString());
            NguoiDungBUS.Instance.UpdateNguoiDung(nguoidung);
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }
        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDungBUS.Instance.DeleteNguoiDung(txtMaNguoiDung.Text);
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            fThemNguoiDung f = new fThemNguoiDung();
            f.ShowDialog();
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
        }

        private void dgvNhomNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhomNguoiDung.CurrentRow.Index;
            txtMaNhomNguoiDung.Text = dgvNhomNguoiDung.Rows[index].Cells[1].Value.ToString();
            txtTenNhomNguoiDung.Text = dgvNhomNguoiDung.Rows[index].Cells[2].Value.ToString();
        }

        private void btnSuaNhomNguoiDung_Click(object sender, EventArgs e)
        {
            NhomNguoiDung NND = new NhomNguoiDung();
            NND.MaNhom = txtMaNhomNguoiDung.Text;
            NND.TenNhom = txtTenNhomNguoiDung.Text;
            NhomNguoiDungBUS.Instance.UpdateNhomNguoiDung(NND);
            dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
        }

        private void btnXoaNhomNguoiDung_Click(object sender, EventArgs e)
        {
            NhomNguoiDungBUS.Instance.DeleteNhomNguoiDung(txtMaNhomNguoiDung.Text);
            dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
        }

        private void btnThemNhomNguoiDung_Click(object sender, EventArgs e)
        {
            fThemNhomNguoiDung f = new fThemNhomNguoiDung();
            f.ShowDialog();
            dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
        }

        private void dgvChucNang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvChucNang.CurrentRow.Index;
            txtMaChucNang.Text = dgvChucNang.Rows[index].Cells[1].Value.ToString();
            txtTenChucNang.Text = dgvChucNang.Rows[index].Cells[2].Value.ToString();
            txtTenManHinhDuocLoad.Text = dgvChucNang.Rows[index].Cells[3].Value.ToString();
        }

        private void btnSuaChucNang_Click(object sender, EventArgs e)
        {
            ChucNang chucnang = new ChucNang();
            chucnang.MaChucNang = txtMaChucNang.Text;
            chucnang.TenChucNang = txtTenChucNang.Text;
            chucnang.TenManHinhDuocLoad = txtTenManHinhDuocLoad.Text;
            ChucNangBUS.Instance.UpdateChucNang(chucnang);
            dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
        }

        private void btnXoaChucNang_Click(object sender, EventArgs e)
        {
            ChucNangBUS.Instance.DeleteChucNang(txtMaChucNang.Text);
            dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
        }

        private void btnThemChucNang_Click(object sender, EventArgs e)
        {
            fThemChucNang f = new fThemChucNang();
            f.ShowDialog();
            dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
        }

        private void cboMaNhomNguoiDungPQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNhomNguoiDungPQ.SelectedItem != null)
            {
                try
                { 
                    int ID = Convert.ToInt32(cboMaNhomNguoiDungPQ.SelectedValue.ToString());
                    txtTenNhomNguoiDungPQ.Text = NhomNguoiDungBUS.Instance.GetNhomNguoiDungByID(ID).Rows[0][2].ToString();
                    dgvPhanQuyen.DataSource = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(ID);
                }
                catch { }
            }
            else
            {
                txtTenNhomNguoiDungPQ.Text = "";
            }    
        }

        private void dgvPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhanQuyen.CurrentRow.Index;
            cboChucNangPQ.Text = dgvPhanQuyen.Rows[index].Cells[0].Value.ToString();
            txtTenChucNangPQ.Text = dgvPhanQuyen.Rows[index].Cells[1].Value.ToString();
            txtTenManHinhDuocLoad.Text = dgvPhanQuyen.Rows[index].Cells[2].Value.ToString();
        }

        private void btnXoaPhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.IDNhomNguoiDung = Convert.ToInt32(cboMaNhomNguoiDungPQ.SelectedValue.ToString());
            phanquyen.IDChucNang = Convert.ToInt32(cboChucNangPQ.SelectedValue.ToString());
            PhanQuyenBUS.Instance.DeletePhanQuyen(phanquyen);
            dgvPhanQuyen.DataSource = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(phanquyen.IDNhomNguoiDung);
            cboChucNangPQ.Text = "";
            txtTenChucNangPQ.Text = "";
            txtTenManHinhDuocLoadPQ.Text = "";
        }

        private void btnThemPhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.IDNhomNguoiDung = Convert.ToInt32(cboMaNhomNguoiDungPQ.SelectedValue.ToString());
            phanquyen.IDChucNang = Convert.ToInt32(cboChucNangPQ.SelectedValue.ToString());
            PhanQuyenBUS.Instance.InsertPhanQuyen(phanquyen);
            dgvPhanQuyen.DataSource = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(phanquyen.IDNhomNguoiDung);
            cboChucNangPQ.Text = "";
            txtTenChucNangPQ.Text = "";
            txtTenManHinhDuocLoadPQ.Text = "";
        }

        private void cboChucNangPQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChucNangPQ.SelectedItem != null)
            {
                try
                {
                    int ID = Convert.ToInt32(cboChucNangPQ.SelectedValue.ToString());
                    txtTenChucNangPQ.Text = ChucNangBUS.Instance.GetChucNangByID(ID).Rows[0][2].ToString();
                    txtTenManHinhDuocLoadPQ.Text = ChucNangBUS.Instance.GetChucNangByID(ID).Rows[0][3].ToString();
                }
                catch { }
            }
            else
            {
                txtTenChucNangPQ.Text = "";
                txtTenManHinhDuocLoadPQ.Text = "";
            }
        }
    }
}
