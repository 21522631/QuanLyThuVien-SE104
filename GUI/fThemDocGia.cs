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
    public partial class fThemDocGia : Form
    {
        public fThemDocGia()
        {
            InitializeComponent();
        }
        private void fThemDocGia_Load(object sender, EventArgs e)
        {
            cboLoaiDocGia.DataSource = LoaiDocGiaBUS.Instance.GetAllTenLoaiDocGia();
            cboLoaiDocGia.ValueMember = "TENLOAIDOCGIA";
            cboLoaiDocGia.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string IDLoaiDocGia = LoaiDocGiaBUS.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(cboLoaiDocGia.Text);
            NguoiDungBUS.Instance.InsertNguoiDungDocGia(txtHoVaTen.Text, txtTenDangNhap.Text, txtMatKhau.Text);
            string IDNguoiDung = NguoiDungBUS.Instance.GetIDNguoiDungByTenDangNhap(txtTenDangNhap.Text);
            //Thêm nguoi dung//check thamso
            DocGiaBUS.Instance.InsertDocGia(txtHoVaTen.Text, dtmNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, IDLoaiDocGia, dtmNgayLapThe.Text, dtmNgayHetHan.Text, IDNguoiDung);
        }
    }
}
