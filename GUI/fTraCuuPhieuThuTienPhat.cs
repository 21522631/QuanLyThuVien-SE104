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
    public partial class fTraCuuPhieuThuTienPhat : Form
    {
        public fTraCuuPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void fTraCuuPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            dgvPhieuThuTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.GetAllPhieuThuTienPhat();
            dgvPhieuThuTien.Columns[0].HeaderCell.Value = "Số phiếu thu";
            dgvPhieuThuTien.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPhieuThuTien.Columns[2].HeaderCell.Value = "Ngày thu";
            dgvPhieuThuTien.Columns[3].HeaderCell.Value = "Tổng nợ";
            dgvPhieuThuTien.Columns[4].HeaderCell.Value = "Số tiền thu";
            dgvPhieuThuTien.Columns[5].HeaderCell.Value = "Còn lại";
            dgvPhieuThuTien.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text, dtmNgayThu.Value.ToString());
            }
            else
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text);
            }    
        }

        private void chkApDungNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text, dtmNgayThu.Value.ToString());
            }
            else
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text);
            }
        }

        private void dtmNgayThu_ValueChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text, dtmNgayThu.Value.ToString());
            }
            else
            {
                dgvPhieuThuTien.DataSource = PhieuThuTienPhatBUS.Instance.SearchPhieuThuTienPhat(txtTraCuu.Text);
            }
        }
    }
}
