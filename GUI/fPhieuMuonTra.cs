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
    public partial class fPhieuMuonTra : Form
    {
        public fPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void fPhieuMuonTra_Load(object sender, EventArgs e)
        {
            txtMaCuonSach.Enabled = false;
            txtSoPhieuMuonTra.Enabled = false;
            txtMaCuonSach.Enabled = false;
            txtNoCu.Text = "";
            chkTinhTrang.Checked = false;
        }

       

        private void cboMaCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboMaCuonSach.SelectedValue.ToString() == "0")
            //{
            //    chkTinhTrang.Checked = false;//chua tra
            //}
            //else
            //{
            //    chkTinhTrang.Checked = true;
            //} 
                
        }

        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            fThemPhieuMuonTra f = new fThemPhieuMuonTra();
            f.ShowDialog();
        }
    }
}
