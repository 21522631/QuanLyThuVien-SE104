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
            txtSoTienPhatTraTre.Text = thamso.DonGiaPhat.ToString();
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
            thamso.ThoiHanThe = Convert.ToInt32(domThoiHanTheDocGia.Text.ToString());
            thamso.TuoiToiThieu = Convert.ToInt32(domTuoiToiThieu.Text.ToString());
            thamso.TuoiToiDa = Convert.ToInt32(domTuoiToiDa.Text.ToString());
            thamso.SoNgayMuonToiDa = Convert.ToInt32(domSoNgayMuonToiDa.Text.ToString());
            thamso.SoSachMuonToiDa = Convert.ToInt32(domSoSachMuonToiDa.Text.ToString());
            thamso.DonGiaPhat = Convert.ToInt32(txtSoTienPhatTraTre.Text.ToString());
            thamso.KhoangCachNamXB = Convert.ToInt32(domKhoangCachNamXuatBan.Text.ToString());
            if(chkApDungQDTienThu.Checked)
            {
                thamso.ApDungQDTienThu = 1;
            }
            else
                thamso.ApDungQDTienThu = 0;
            ThamSoBUS.Instance.UpdateThamSo(thamso);
        }
    }
}
