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
    public partial class fQuyDinh : Form
    {
        public fQuyDinh()
        {
            InitializeComponent();
        }

        private void fQuyDinh_Load(object sender, EventArgs e)
        {
            ThamSo thamso = new ThamSo();
            thamso = ThamSoBUS.Instance.GetThamSo();
            domThoiHanTheDocGia.Text = thamso.ThoiHanThe.ToString();
            domTuoiToiThieu.Text = thamso.TuoiToiThieu.ToString();
            domTuoiToiDa.Text = thamso.TuoiToiDa.ToString();
            domSoNgayMuonToiDa.Text = thamso.SoNgayMuonToiDa.ToString();
            domSoSachMuonToiDa.Text = thamso.SoSachMuonToiDa.ToString();
            domSoTienPhatTraTre.Text = thamso.DonGiaPhat.ToString();
            domKhoangCachNamXuatBan.Text = thamso.KhoangCachNamXB.ToString();
            if (thamso.ApDungQDTienThu == 1)
            {
                chkApDungQDTienThu.Checked = true;
            }
            else 
                chkApDungQDTienThu.Checked = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThamSo thamso = new ThamSo();
            if(domThoiHanTheDocGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời hạn thẻ độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domThoiHanTheDocGia.Focus();
            }
            else if (domTuoiToiDa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi đa của độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domTuoiToiDa.Focus();
            }
            else if (domTuoiToiThieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi tối thiểu của độc giả!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domTuoiToiThieu.Focus();
            }
          
            else if (domSoNgayMuonToiDa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số ngày mượn sách tối đa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domSoNgayMuonToiDa.Focus();
            }
            else if (domSoSachMuonToiDa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số sách mượn tối đa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domSoSachMuonToiDa.Focus();
            }
            else if (domSoTienPhatTraTre.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền phạt trả trễ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domSoTienPhatTraTre.Focus();
            }
            else if (domKhoangCachNamXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khoảng cách năm xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                domKhoangCachNamXuatBan.Focus();
            }
            else if (MessageBox.Show("Bạn thực sự có muốn thay đổi thông tin!", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                thamso.ThoiHanThe = Convert.ToInt32(domThoiHanTheDocGia.Text.ToString());
                thamso.TuoiToiThieu = Convert.ToInt32(domTuoiToiThieu.Text.ToString());
                thamso.TuoiToiDa = Convert.ToInt32(domTuoiToiDa.Text.ToString());
                thamso.SoNgayMuonToiDa = Convert.ToInt32(domSoNgayMuonToiDa.Text.ToString());
                thamso.SoSachMuonToiDa = Convert.ToInt32(domSoSachMuonToiDa.Text.ToString());
                thamso.DonGiaPhat = Convert.ToInt32(domSoTienPhatTraTre.Text.ToString());
                thamso.KhoangCachNamXB = Convert.ToInt32(domKhoangCachNamXuatBan.Text.ToString());
                if (chkApDungQDTienThu.Checked)
                {
                    thamso.ApDungQDTienThu = 1;
                }
                else
                {
                    thamso.ApDungQDTienThu = 0;
                }
                ThamSoBUS.Instance.UpdateThamSo(thamso);
                MessageBox.Show("Sửa thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
