using DTO;
using BUS;
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
    public partial class fDocGia : Form
    {
        private NguoiDung nguoidung;
        public fDocGia(NguoiDung nguoidung)
        {
            InitializeComponent();
            this.nguoidung = nguoidung;
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(0);
            f.ShowDialog();
        }

        private void fDocGia_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinDocGia f = new fThongTinDocGia(ref nguoidung);
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinDocGia f = new fThongTinDocGia(ref nguoidung);
            f.ShowDialog();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(ref nguoidung);
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự có muốn đăng xuất?", "Thông tin!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void quảnLýNgườiDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThongTinDocGia f = new fThongTinDocGia(ref nguoidung);
            f.ShowDialog();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MaDocGia = DocGiaBUS.Instance.GetDocGiaByIDNguoiDung(nguoidung.ID.ToString()).Rows[0][0].ToString();
            fDocGiaSachDaMuon f = new fDocGiaSachDaMuon(MaDocGia);
            f.ShowDialog();
        }

        private void phiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MaDocGia = DocGiaBUS.Instance.GetDocGiaByIDNguoiDung(nguoidung.ID.ToString()).Rows[0][0].ToString();
            fDocGiaPhieuMuonTra f = new fDocGiaPhieuMuonTra(MaDocGia);
            f.ShowDialog();
        }
    }
}
