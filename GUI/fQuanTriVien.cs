﻿using System;
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
    }
}
