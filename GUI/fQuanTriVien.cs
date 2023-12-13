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
    public partial class fQuanTriVien : Form
    {
        public fQuanTriVien()
        {
            InitializeComponent();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {

        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {

        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {

        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {

        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuThu_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTenNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDocGia f = new fQuanLyDocGia(0);
            f.ShowDialog();
        }

        private void sửaĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDocGia f = new fQuanLyDocGia(0);
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sửaThôngTinTácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thêmPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemPhieuNhapSach f = new fThemPhieuNhapSach();
            f.ShowDialog();
        }

        private void tìmKiếmPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemLoaiDocGia f = new fThemLoaiDocGia(); 
            f.ShowDialog();
        }

        private void độcGiảToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fQuanLyDocGia f= new fQuanLyDocGia(0);
            f.ShowDialog();
        }

        private void loạiĐộcGiảToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fQuanLyDocGia f = new fQuanLyDocGia(1);
            f.ShowDialog();
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemDocGia f = new fThemDocGia();
            f.ShowDialog();
        }

        private void fQuanTriVien_Load(object sender, EventArgs e)
        {

        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuDocGia f = new fTraCuuDocGia(0);
            f.ShowDialog();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuDocGia f = new fTraCuuDocGia(0);
            f.ShowDialog();
        }

        private void loạiĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuDocGia f = new fTraCuuDocGia(1);
            f.ShowDialog();
        }

        private void sáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fQuanLySach f = new fQuanLySach(0);
            f.ShowDialog();
        }

        private void thêmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLySach f = new fQuanLySach(0);
            f.ShowDialog();
        }

        private void tácGiảToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fQuanLySach f = new fQuanLySach(1);
            f.ShowDialog();
        }

        private void thểLoạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQuanLySach f = new fQuanLySach(2);
            f.ShowDialog();
        }

        private void thẻLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(2);
            f.ShowDialog();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemSach f = new fThemSach();
            f.ShowDialog();
        }

        private void tácGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemTheLoai f = new fThemTheLoai();
            f.ShowDialog();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTacGia f = new fThemTacGia();
            f.ShowDialog();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLySach f = new fQuanLySach(0);
            f.ShowDialog();
        }

        private void quảnLýPhiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuNhapSach f = new fQuanLyPhieuNhapSach();
            f.ShowDialog();
        }

        private void cậpNhậpThôngTinPhiếuNhâpkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuNhapSach f = new fQuanLyPhieuNhapSach();
            f.ShowDialog();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(0);
            f.ShowDialog();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(0);
            f.ShowDialog();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(1);
            f.ShowDialog();
        }

        private void cuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuSach f = new fTraCuuSach(3);
            f.ShowDialog();
        }

        private void thêmPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemPhieuMuonTra f = new fThemPhieuMuonTra();
            f.ShowDialog();
        }

        private void sửaPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuMuonTra f = new fQuanLyPhieuMuonTra();
            f.ShowDialog();
        }

        private void thêmPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemPhieuThuTienPhat f = new fThemPhieuThuTienPhat();
            f.ShowDialog();
        }

        private void xoáPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuThuTienPhat f = new fQuanLyPhieuThuTienPhat();
            f.ShowDialog();
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuyDinh f = new fQuyDinh();
            f.ShowDialog();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoThongKe f = new fBaoCaoThongKe(0);
            f.ShowDialog();
        }

        private void báoCáoMượnTheoThểLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoThongKe f = new fBaoCaoThongKe(0);
            f.ShowDialog();
        }

        private void báoCáoSáchTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoThongKe f = new fBaoCaoThongKe(1);
            f.ShowDialog();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuMuonTra f = new fQuanLyPhieuMuonTra();
            f.ShowDialog();
        }

        private void quảnLýPhiếuThuTiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyPhieuThuTienPhat f = new fQuanLyPhieuThuTienPhat();
            f.ShowDialog();
        }

        private void tìmKiếmPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuPhieuMuonTra f = new fTraCuuPhieuMuonTra();
            f.ShowDialog();
        }
    }
}
