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
    public partial class fThemDocGia : Form
    {
        public fThemDocGia()
        {
            InitializeComponent();
        }
        private void fThemDocGia_Load(object sender, EventArgs e)
        {
            cboLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllTenLoaiDocGia();
            cboLoaiDocGia.DisplayMember = "TENLOAIDOCGIA";
            cboLoaiDocGia.ValueMember = "TENLOAIDOCGIA";
            cboLoaiDocGia.SelectedIndex = -1;
            dtmNgayHetHan.Enabled = false;
            dtmNgayHetHan.Text = Convert.ToString(dtmNgayLapThe.Value.AddMonths(ThamSoBUS.Instance.GetThamSo().ThoiHanThe));
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else if (txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
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
            else if (NguoiDungBUS.Instance.GetIDNguoiDungByTenDangNhap(txtTenDangNhap.Text) != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại vui lòng nhập tài khoản khác !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
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
                else
                {
                    string IDLoaiDocGia = LoaiDocGiaBUS.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(cboLoaiDocGia.Text);
                    NguoiDungBUS.Instance.InsertNguoiDungDocGia(txtHoVaTen.Text, txtTenDangNhap.Text, txtMatKhau.Text);
                    string IDNguoiDung = NguoiDungBUS.Instance.GetIDNguoiDungByTenDangNhap(txtTenDangNhap.Text);
                    DocGiaBUS.Instance.InsertDocGia(txtHoVaTen.Text, dtmNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, IDLoaiDocGia, dtmNgayLapThe.Text, dtmNgayHetHan.Text, IDNguoiDung);
                    MessageBox.Show("Thêm mới độc giả thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoVaTen.Text = "";
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    txtNhapLaiMatKhau.Text = "";
                    cboLoaiDocGia.Text = "";
                    txtDiaChi.Text = "";
                    txtEmail.Text = "";
                }

            }
        }

        private void dtmNgayLapThe_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayHetHan.Text = Convert.ToString(dtmNgayLapThe.Value.AddMonths(ThamSoBUS.Instance.GetThamSo().ThoiHanThe));
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }

            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
 }
