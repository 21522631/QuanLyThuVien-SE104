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
    public partial class fThongTinDocGia : Form
    {
        private NguoiDung nguoidung;
        public fThongTinDocGia(ref NguoiDung nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
        }

        private void fThongTinDocGia_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtLoaiDocGia.Enabled = false;
            dtmNgayLapThe.Enabled = false;
            dtmNgayHetHan.Enabled = false;
            txtTongNo.Enabled = false;
            txtChucNang.Enabled = false;
            DataTable data = new DataTable();
            data = DocGiaBUS.Instance.GetDocGiaByIDNguoiDung(nguoidung.ID.ToString());
            txtMaDocGia.Text = data.Rows[0][0].ToString();
            txtTenDangNhap.Text = nguoidung.TenDangNhap;
            txtHoVaTen.Text = data.Rows[0][1].ToString();
            dtmNgaySinh.Text = data.Rows[0][2].ToString();
            txtDiaChi.Text = data.Rows[0][3].ToString();
            txtEmail.Text = data.Rows[0][4].ToString();
            txtLoaiDocGia.Text = LoaiDocGiaBUS.Instance.GetLoaiDocGiaByID(data.Rows[0][5].ToString()).Rows[0][0].ToString();
            dtmNgayLapThe.Text = data.Rows[0][6].ToString();
            dtmNgayHetHan.Text = data.Rows[0][7].ToString();
            txtTongNo.Text = data.Rows[0][8].ToString();
            DataTable datapq = new DataTable();
            datapq = PhanQuyenBUS.Instance.GetAllPhanQuyenByIDNhomNguoiDung(nguoidung.IDNhomNguoiDung);
            for (int i = 0; i < datapq.Rows.Count; i++)
            {
                txtChucNang.Text = txtChucNang.Text + Environment.NewLine + datapq.Rows[i][1].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
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
                    string IDLoaiDocGia = LoaiDocGiaBUS.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(txtLoaiDocGia.Text);
                    DocGiaBUS.Instance.UpdateDocGia(txtMaDocGia.Text, txtHoVaTen.Text, dtmNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, IDLoaiDocGia, dtmNgayLapThe.Text);
                    MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(ref nguoidung);
            f.ShowDialog();
        }
    }
}
