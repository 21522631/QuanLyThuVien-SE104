using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
            dgvNguoiDung.Columns[0].HeaderCell.Value = "Mã người dùng";
            dgvNguoiDung.Columns[1].HeaderCell.Value = "Tên người dùng";
            dgvNguoiDung.Columns[2].HeaderCell.Value = "Tên đăng nhập";
            dgvNguoiDung.Columns[3].HeaderCell.Value = "Tên nhóm người dùng";
            cboNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            cboNhomNguoiDung.DisplayMember = "TENNHOM";
            cboNhomNguoiDung.ValueMember = "ID";
            cboNhomNguoiDung.Text = "";
            txtMaNhomNguoiDung.Enabled = false;
            dgvNhomNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
            dgvNhomNguoiDung.Columns[0].HeaderCell.Value = "Mã nhóm người dùng";
            dgvNhomNguoiDung.Columns[1].HeaderCell.Value = "Tên nhóm người dùng";
            dgvNhomNguoiDung.Columns["ID"].Visible = false;
            txtMaChucNang.Enabled = false;
            dgvChucNang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
            dgvChucNang.Columns[1].HeaderCell.Value = "Mã chức năng";
            dgvChucNang.Columns[2].HeaderCell.Value = "Tên chức năng";
            dgvChucNang.Columns[3].HeaderCell.Value = "Tên màn hình được load";
            dgvChucNang.Columns["ID"].Visible = false;
            dgvPhanQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            if(txtMaNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(txtTenNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNguoiDung.Focus();
            }
            else if (cboNhomNguoiDung.SelectedValue != null)
            {
                if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    NguoiDung nguoidung = new NguoiDung();
                    nguoidung.MaNguoiDung = txtMaNguoiDung.Text;
                    nguoidung.TenNguoiDung = txtTenNguoiDung.Text;
                    nguoidung.IDNhomNguoiDung = Convert.ToInt32(cboNhomNguoiDung.SelectedValue.ToString());
                    NguoiDungBUS.Instance.UpdateNguoiDung(nguoidung);
                    dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại nhóm người dùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNhomNguoiDung.Focus();
            }    
        }
        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtMaNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                NguoiDungBUS.Instance.DeleteNguoiDung(txtMaNguoiDung.Text);
                dgvNguoiDung.DataSource = NguoiDungBUS.Instance.GetAllNguoiDung();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNguoiDung.Text = "";
                txtTenNguoiDung.Text = "";
                txtTenDangNhap.Text = "";
                cboNhomNguoiDung.Text = "";
            }
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
            if (txtMaNhomNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenNhomNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhóm người dùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhomNguoiDung.Focus();
            }
            else if (NhomNguoiDungBUS.Instance.GetNhomNguoiDungByTenNhom(txtTenNhomNguoiDung.Text).Rows.Count > 0 )
            {
                MessageBox.Show("Nhóm đã tồn tại. Vui lòng nhập lại tên nhóm!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhomNguoiDung.Focus();
            }    
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                NhomNguoiDung NND = new NhomNguoiDung();
                NND.MaNhom = txtMaNhomNguoiDung.Text;
                NND.TenNhom = txtTenNhomNguoiDung.Text;
                NhomNguoiDungBUS.Instance.UpdateNhomNguoiDung(NND);
                dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnXoaNhomNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtMaNhomNguoiDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                NhomNguoiDungBUS.Instance.DeleteNhomNguoiDung(txtMaNhomNguoiDung.Text);
                dgvNhomNguoiDung.DataSource = NhomNguoiDungBUS.Instance.GetAllNhomNguoiDung();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhomNguoiDung.Text = "";
                txtTenNhomNguoiDung.Text = "";
            }
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
            if (txtMaChucNang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenChucNang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chức năng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenChucNang.Focus();
            }
            else if (txtTenManHinhDuocLoad.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên màn hình được load!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenManHinhDuocLoad.Focus();
            }
            else
            {
                ChucNang chucnang = new ChucNang();
                chucnang.MaChucNang = txtMaChucNang.Text;
                chucnang.TenChucNang = txtTenChucNang.Text;
                chucnang.TenManHinhDuocLoad = txtTenManHinhDuocLoad.Text;
                if (ChucNangBUS.Instance.GetChucNangByTenChucNang(chucnang).Rows.Count > 0)
                {
                    MessageBox.Show("Chức năng đã tồn tại. Vui lòng nhập chức năng khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenChucNang.Focus();
                }
                else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    ChucNangBUS.Instance.UpdateChucNang(chucnang);
                    dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoaChucNang_Click(object sender, EventArgs e)
        {
            if (txtMaChucNang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                ChucNangBUS.Instance.DeleteChucNang(txtMaChucNang.Text);
                dgvChucNang.DataSource = ChucNangBUS.Instance.GetAllChucNang();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChucNang.Text = "";
                txtTenChucNang.Text = "";
                txtTenManHinhDuocLoad.Text = "";
            }    
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
                    dgvPhanQuyen.Columns[0].HeaderCell.Value = "Mã chức năng";
                    dgvPhanQuyen.Columns[1].HeaderCell.Value = "Tên chức năng";
                    dgvPhanQuyen.Columns[2].HeaderCell.Value = "Tên màn hình được load";
                    cboChucNangPQ.Text = "";
                    txtTenChucNangPQ.Text = "";
                    txtTenManHinhDuocLoadPQ.Text = "";
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
            if (cboMaNhomNguoiDungPQ.SelectedValue == null)
            {
                MessageBox.Show("Mã nhóm không hợp lệ. Vui lòng chọn mã nhóm để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaNhomNguoiDungPQ.Focus();
            }
            else if (cboChucNangPQ.SelectedValue == null)
            {
                MessageBox.Show("Mã chức năng không hợp lệ. Vui lòng chọn mã chức năng để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChucNangPQ.Focus();
            }
            else
            {
                PhanQuyen phanquyen = new PhanQuyen();
                phanquyen.IDNhomNguoiDung = Convert.ToInt32(cboMaNhomNguoiDungPQ.SelectedValue.ToString());
                phanquyen.IDChucNang = Convert.ToInt32(cboChucNangPQ.SelectedValue.ToString());
                if (PhanQuyenBUS.Instance.GetAllPhanQuyenByPhanQuyen(phanquyen).Rows.Count > 0)
                {
                    if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        PhanQuyenBUS.Instance.DeletePhanQuyen(phanquyen);
                        dgvPhanQuyen.DataSource = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(phanquyen.IDNhomNguoiDung);
                        MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboChucNangPQ.Text = "";
                        txtTenChucNangPQ.Text = "";
                        txtTenManHinhDuocLoadPQ.Text = "";
                    }
                }
                else 
                {
                    MessageBox.Show("Chức năng không tồn tại. Vui lòng chọn lại mã chức năng để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboChucNangPQ.Focus();
                }
            }      
        }

        private void btnThemPhanQuyen_Click(object sender, EventArgs e)
        {
            if (cboMaNhomNguoiDungPQ.SelectedValue == null)
            {
                MessageBox.Show("Mã nhóm không hợp lệ. Vui lòng chọn mã nhóm để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaNhomNguoiDungPQ.Focus();
            }
            else if (cboChucNangPQ.SelectedValue == null)
            {
                MessageBox.Show("Mã nhóm không hợp lệ. Vui lòng chọn mã chức năng để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChucNangPQ.Focus();
            }
            else
            {
                PhanQuyen phanquyen = new PhanQuyen();
                phanquyen.IDNhomNguoiDung = Convert.ToInt32(cboMaNhomNguoiDungPQ.SelectedValue.ToString());
                phanquyen.IDChucNang = Convert.ToInt32(cboChucNangPQ.SelectedValue.ToString());
                if (PhanQuyenBUS.Instance.GetAllPhanQuyenByPhanQuyen(phanquyen).Rows.Count > 0)
                {
                    MessageBox.Show("Chức năng đã tồn tại. Vui lòng nhập chức năng khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboChucNangPQ.Focus();
                }
                else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    PhanQuyenBUS.Instance.InsertPhanQuyen(phanquyen);
                    dgvPhanQuyen.DataSource = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(phanquyen.IDNhomNguoiDung);
                    MessageBox.Show("Thêm thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }    
            
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
                cboChucNangPQ.Text = "";
                txtTenChucNangPQ.Text = "";
                txtTenManHinhDuocLoadPQ.Text = "";
            }
        }
    }
}
