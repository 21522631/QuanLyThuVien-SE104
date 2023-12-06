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
            cboLoaiDocGia.ValueMember = "TENLOAIDOCGIA";
            cboLoaiDocGia.Text = "";
            dtmNgayHetHan.Enabled = false;
            dtmNgayHetHan.Text = Convert.ToString(dtmNgayLapThe.Value.AddMonths(ThamSoBUS.Instance.GetThamSo().ThoiHanThe));
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThamSo thamso = ThamSoBUS.Instance.GetThamSo();
            int Tuoi = DateTime.Now.Year - dtmNgaySinh.Value.Year;
            
            if(Tuoi < thamso.TuoiToiThieu)
            {
                MessageBox.Show("Tuổi phải lớn hơn " + thamso.TuoiToiThieu, "Lỗi", MessageBoxButtons.OK);
            }
            else if (Tuoi > thamso.TuoiToiDa)
            {
                MessageBox.Show("Tuổi phải nhỏ hơn " + thamso.TuoiToiDa, "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string IDLoaiDocGia = LoaiDocGiaBUS.Instance.GetIDLoaiDocGiaByTenLoaiDocGia(cboLoaiDocGia.Text);
                NguoiDungBUS.Instance.InsertNguoiDungDocGia(txtHoVaTen.Text, txtTenDangNhap.Text, txtMatKhau.Text);
                string IDNguoiDung = NguoiDungBUS.Instance.GetIDNguoiDungByTenDangNhap(txtTenDangNhap.Text);
                DocGiaBUS.Instance.InsertDocGia(txtHoVaTen.Text, dtmNgaySinh.Text, txtDiaChi.Text, txtEmail.Text, IDLoaiDocGia, dtmNgayLapThe.Text, dtmNgayHetHan.Text, IDNguoiDung);
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
    }
}
