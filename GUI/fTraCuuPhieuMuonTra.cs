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
    public partial class fTraCuuPhieuMuonTra : Form
    {
        public fTraCuuPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void fTraCuuPhieuMuonTra_Load(object sender, EventArgs e)
        {
            dgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.GetAllPhieuMuonTra();
            dgvPhieuMuonTra.Columns[0].HeaderCell.Value = "Số phiếu mượn";
            dgvPhieuMuonTra.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPhieuMuonTra.Columns[2].HeaderCell.Value = "Mã cuốn sách";
            dgvPhieuMuonTra.Columns[3].HeaderCell.Value = "Ngày mượn";
            dgvPhieuMuonTra.Columns[4].HeaderCell.Value = "Ngày phải trả";
            dgvPhieuMuonTra.Columns[5].HeaderCell.Value = "Ngày trả";
            dgvPhieuMuonTra.Columns[6].HeaderCell.Value = "Tiền phạt";
            dgvPhieuMuonTra.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuonTra.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuonTra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked)
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }
            else 
            {
                dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
            }
        }

        private void dtmNgayMuon_ValueChanged(object sender, EventArgs e)
        {
        }
        private void chkDaTra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDaTra.Checked) 
            {
                chkChuaTra.Checked = false;
                chkNgayTra.Checked = false;
            }
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked)
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }
        }

        private void chkChuaTra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChuaTra.Checked)
            {
                chkDaTra.Checked = false;
                chkNgayTra.Checked = false;
            }
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked)
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }
        }

        private void chkNgayTra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgayTra.Checked)
            {
                chkChuaTra.Checked = false;
                chkDaTra.Checked = false;
            }
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked)
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }

        }

        private void chkNgayMuon_CheckedChanged(object sender, EventArgs e)
        {
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked)
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }
        }

        private void chkApDungLoc_CheckedChanged(object sender, EventArgs e)
        {
            string NgayMuon = "";
            string NgayTra = "";
            if (chkApDungLoc.Checked) 
            {
                if (!chkDaTra.Checked && !chkChuaTra.Checked && !chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text);
                }
                else if (chkDaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkDaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NOT NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && !chkNgayMuon.Checked)
                {
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkChuaTra.Checked && chkNgayMuon.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' AND ";
                    NgayTra = "NGAYTRA IS NULL";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && !chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else if (chkNgayMuon.Checked && chkNgayTra.Checked)
                {
                    NgayMuon = "NGAYMUON = '" + dtmNgay.Value + "' OR ";
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'" ;
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
                else
                {
                    NgayTra = "NGAYTRA = '" + dtmNgay.Value + "'";
                    dgvPhieuMuonTra.DataSource = PhieuMuonTraBUS.Instance.SearchPhieuMuonTra(txtTraCuu.Text, NgayMuon, NgayTra);
                }
            }
        }
    }
}
