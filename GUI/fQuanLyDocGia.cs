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
        public fQuanLyDocGia(int Index)
        {
            InitializeComponent();
            this.tabQuanLyDocGia.SelectedIndex = Index;
        }
        private void fQuanLyDocGia_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = false;
            txtMaLoaiDocGia.Enabled = false;
            dtmNgayLapThe.Enabled = false;
            dtmNgayHetHan.Enabled = false;
            cboLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllTenLoaiDocGia();
            cboLoaiDocGia.ValueMember = "TENLOAIDOCGIA";
            cboLoaiDocGia.SelectedIndex = -1;
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
            if (txtMaLoaiDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLoaiDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiDocGia.Focus();
            }
            else if (LoaiDocGiaBUS.Instance.GetLoaiDocGiaByTenLoaiDocGia(txtTenLoaiDocGia.Text).Rows.Count > 0)
            {
                MessageBox.Show("Loại độc giả này đã tồn tại. Vui lòng nhập lại tên loại độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiDocGia.Focus();
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                LoaiDocGiaBUS.Instance.UpdateLoaiDocGia(txtMaLoaiDocGia.Text, txtTenLoaiDocGia.Text);
                dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnXoaLoaiDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                LoaiDocGiaBUS.Instance.DeleteLoaiDocGia(txtMaLoaiDocGia.Text);
                txtMaLoaiDocGia.Text = "";
                txtTenLoaiDocGia.Text = "";
                dgvLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllLoaiDocGia();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }     
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
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
            }
            else if (cboLoaiDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lại loại độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLoaiDocGia.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else
            {
                ThamSo thamso = ThamSoBUS.Instance.GetThamSo();
                int Tuoi = DateTime.Now.Year - dtmNgaySinh.Value.Year;

                if (Tuoi < thamso.TuoiToiThieu)
                {
                    MessageBox.Show("Tuổi phải lớn hơn " + thamso.TuoiToiThieu, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtmNgaySinh.Focus();
                }
                else if (Tuoi > thamso.TuoiToiDa)
                {
                    MessageBox.Show("Tuổi phải nhỏ hơn " + thamso.TuoiToiDa, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtmNgaySinh.Focus();
                }
                else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    string IDLoaiDocGia = LoaiDocGiaBUS.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(cboLoaiDocGia.Text);
                    DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, txtHoVaTen.Text, dtmNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, IDLoaiDocGia, dtmNgayLapThe.Text);
                    dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
            }      
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong datagridview để thực hiện!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Bạn thực sự có muốn xoá thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                DocGiaBUS.Instance.DeleteDocGia(txtMaDocGia.Text);
                txtMaDocGia.Text = "";
                txtHoVaTen.Text = "";
                cboLoaiDocGia.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                dtmNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtmNgayLapThe.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtmNgayHetHan.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
                MessageBox.Show("Xoá thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabpgDocGia_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            fThemDocGia f = new fThemDocGia();
            f.ShowDialog();
            dgvDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
        }
    }
}
