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
        public fQuanLySach(int Index)
        {
            InitializeComponent();
            this.tabQuanLySach.SelectedIndex = Index;
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
            if (txtMaTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTacGia.Focus();
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TacGia tacgia = new TacGia();
                tacgia.MaTacGia = txtMaTacGia.Text;
                tacgia.TenTacGia = txtTenTacGia.Text;
                tacgia.NgaySinh = dtmNgaySinh.Text;
                TacGiaBUS.Instance.UpdateTacGia(tacgia);
                dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            fThemTacGia f = new fThemTacGia();
            f.ShowDialog();
            dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TacGiaBUS.Instance.DeleteTacGia(txtMaTacGia.Text);
                txtMaTacGia.Text = "";
                txtTenTacGia.Text = "";
                dgvTacGia.DataSource = TacGiaBUS.Instance.GetAllTacGia();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            fThemTheLoai f = new fThemTheLoai();
            f.ShowDialog();
            dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (txtMaTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TheLoaiBUS.Instance.GetTheLoaiByTenTheLoai(txtTenTheLoai.Text).Rows.Count > 0)
            {
                MessageBox.Show("Đã tồn tại thể loại này. Vui lòng nhập tên thể loại khác!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TheLoai theloai = new TheLoai();
                theloai.MaTheLoai = txtMaTheLoai.Text;
                theloai.TenTheLoai = txtTenTheLoai.Text;
                TheLoaiBUS.Instance.UpdateTheLoai(theloai);
                dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }
        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTheLoai.CurrentRow.Index;
            txtMaTheLoai.Text = dgvTheLoai.Rows[index].Cells[0].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.Rows[index].Cells[1].Value.ToString();
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTheLoai.Focus();
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TheLoaiBUS.Instance.DeleteTheLoai(txtMaTheLoai.Text);
                txtMaTheLoai.Text = "";
                txtTenTheLoai.Text = "";
                dgvTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            dgvCT_TacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
            dgvCT_TacGia.Columns[0].HeaderCell.Value = "Mã tác giả";
            dgvCT_TacGia.Columns[1].HeaderCell.Value = "Tên tác giả";
            cboMaTacGia.SelectedIndex = -1;
        }

        private void dgvCT_TacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCT_TacGia.CurrentRow.Index;
            cboMaTacGia.Text = dgvCT_TacGia.Rows[index].Cells[0].Value.ToString();
        }

        private void btnThemDSTG_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(cboMaTacGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lại mã tác giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaTacGia.Focus();
            }
            else
            {
                CT_TacGia ct_tacgia = new CT_TacGia();
                ct_tacgia.IDSach = Convert.ToInt32(txtMaSach.Text.Replace("SA", "00"));
                ct_tacgia.IDTacGia = Convert.ToInt32(cboMaTacGia.Text.Replace("TG", "00"));
                if (CT_TacGiaBUS.Instance.GetCT_TacGiaByCT_TacGia(ct_tacgia).Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại tác giả. Vui lòng chọn lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMaTacGia.Focus();
                }
                else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    CT_TacGiaBUS.Instance.InsertCT_TacGia(ct_tacgia);
                    dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
                    MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaTacGia.SelectedIndex = -1;
                }
            }    
        }

        private void XoaDSTG_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboMaTacGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lại mã tác giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaTacGia.Focus();
            }
            else
            {
                CT_TacGia ct_tacgia = new CT_TacGia();
                ct_tacgia.IDSach = Convert.ToInt32(txtMaSach.Text.Replace("SA", "00"));
                ct_tacgia.IDTacGia = Convert.ToInt32(cboMaTacGia.Text.Replace("TG", "00"));
                if (CT_TacGiaBUS.Instance.GetCT_TacGiaByCT_TacGia(ct_tacgia).Rows.Count > 0)
                {
                    if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        CT_TacGiaBUS.Instance.DeleteCT_TacGia(ct_tacgia);
                        dgvCT_TacGia.DataSource = CT_TacGiaBUS.Instance.GetCT_TacGiaByIDSach(txtMaSach.Text.Replace("SA", "00"));
                        MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboMaTacGia.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tác giả trong danh sách. Vui lòng chọn lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMaTacGia.Focus();
                }    
            }    
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboTheLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTheLoai.Focus();
            }
            else if (txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSach.Focus();
            }
            else if (txtNhaXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhaXuatBan.Focus();
            }
            else if (txtNamXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamXuatBan.Focus();
            }
            else
            {
                Sach sach = new Sach();
                sach.MaSach = txtMaSach.Text;
                sach.TenSach = txtTenSach.Text;
                sach.IDTheLoai = cboTheLoai.SelectedValue.ToString().Replace("TL", "00");
                sach.NhaXuatBan = txtNhaXuatBan.Text;
                sach.NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
                int NamXuatBan;
                if (Int32.TryParse(txtNamXuatBan.Text, out NamXuatBan))
                {
                    if (DateTime.Now.Year - NamXuatBan > ThamSoBUS.Instance.GetThamSo().KhoangCachNamXB)
                    {
                        MessageBox.Show("Khoảng cách năm xuất bản phải nhỏ hơn " + ThamSoBUS.Instance.GetThamSo().KhoangCachNamXB + "!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNamXuatBan.Focus();
                    }
                    else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        SachBUS.Instance.UpdateSach(sach);
                        dgvSach.DataSource = SachBUS.Instance.GetAllSach();
                        MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng năm xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNamXuatBan.Focus();
                }
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
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
                dgvCT_TacGia.DataSource = null;
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            fThemSach f = new fThemSach();
            f.ShowDialog();
            dgvSach.DataSource = SachBUS.Instance.GetAllSach();
        }
    }
}
