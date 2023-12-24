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
    public partial class fTraCuuPhieuNhapSach : Form
    {
        public fTraCuuPhieuNhapSach()
        {
            InitializeComponent();
        }

        private void fTraCuuPhieuNhapSach_Load(object sender, EventArgs e)
        {
            dgvPhieuNhapSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.GetAllPhieuNhapSach();
            dgvPhieuNhapSach.Columns[0].HeaderCell.Value = "Số phiếu nhập sách";
            dgvPhieuNhapSach.Columns[1].HeaderCell.Value = "Ngày lập phiếu";
            dgvPhieuNhapSach.Columns[2].HeaderCell.Value = "Tổng tiền";
            dgvPhieuNhapSach.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text, dtmNgayLap.Value.ToString());
            }
            else
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text);
            }
        }

        private void chkApDungNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text, dtmNgayLap.Value.ToString());
            }
            else
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text);
            }
        }

        private void dtmNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text, dtmNgayLap.Value.ToString());
            }
            else
            {
                dgvPhieuNhapSach.DataSource = PhieuNhapSachBUS.Instance.SearchPhieuNhapSach(txtTraCuu.Text);
            }
        }
    }
}
