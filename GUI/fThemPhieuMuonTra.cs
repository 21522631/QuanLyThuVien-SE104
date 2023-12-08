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
    public partial class fThemPhieuMuonTra : Form
    {
        public fThemPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuMuonTra PMS = new PhieuMuonTra();
            PMS.IDDocGia = cboMaDocGia.Text.Replace("DG", "00");
            PMS.IDCuonSach = cboMaCuonSach.Text.Replace("CS", "00");
            PMS.NgayMuon = dtmNgayMuon.Text;
            PMS.NgayPhaiTra = dtmNgayPhaiTra.Text;
            DataTable dt = new DataTable();
            dt = PhieuMuonTraBUS.Instance.GetSoLuongSachDangMuon(cboMaDocGia.Text.Replace("DG", "00"));
            int SoLuongSachMuon = 0;
            if (dt.Rows.Count > 0 )
            {
                SoLuongSachMuon = Convert.ToInt32(dt.Rows[0][1].ToString());
            }
            if(SoLuongSachMuon < ThamSoBUS.Instance.GetThamSo().SoSachMuonToiDa)
            {
                PhieuMuonTraBUS.Instance.InsertPhieuMuonTraBUS(PMS);
                CuonSachBUS.Instance.UpdateCuonSach(cboMaCuonSach.Text, "0");
            }
            else
            {
                MessageBox.Show("Số lượng sách mượn đã vượt quy định", "Không hợp lệ!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboMaCuonSach.DataSource = CuonSachBUS.Instance.GetAllCuonSachConTrong();
            cboMaCuonSach.Text = "";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemPhieuMuonTra_Load(object sender, EventArgs e)
        {
            cboMaDocGia.DataSource = DocGiaBUS.Instance.GetAllDocGia();
            cboMaDocGia.DisplayMember = "MADOCGIA";
            cboMaDocGia.Text = "";
            cboMaCuonSach.DataSource = CuonSachBUS.Instance.GetAllCuonSachConTrong();
            cboMaCuonSach.DisplayMember = "MACUONSACH";
            cboMaCuonSach.Text = "";
            dtmNgayPhaiTra.Enabled = false;
            dtmNgayPhaiTra.Text = Convert.ToString(dtmNgayMuon.Value.AddDays(ThamSoBUS.Instance.GetThamSo().SoNgayMuonToiDa));
        }

        private void dtmNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtmNgayPhaiTra.Text = Convert.ToString(dtmNgayMuon.Value.AddDays(ThamSoBUS.Instance.GetThamSo().SoNgayMuonToiDa));
        }
    }
}
