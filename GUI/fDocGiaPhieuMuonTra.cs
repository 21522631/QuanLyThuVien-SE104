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
    public partial class fDocGiaPhieuMuonTra : Form
    {
        private string MaDocGia; 
        public fDocGiaPhieuMuonTra(string MaDocGia)
        {
            InitializeComponent();
            this.MaDocGia = MaDocGia;
        }
        private void fDocGiaPhieuMuonTra_Load(object sender, EventArgs e)
        {
            txtMaCuonSach.Enabled = false;
            txtSoPhieuMuonTra.Enabled = false;
            txtMaCuonSach.Enabled = false;
            txtTienPhat.Enabled = false;
            dtmNgayMuon.Enabled = false;
            dtmNgayTra.Enabled = false;
            chkTinhTrang.Checked = false;
            dtmNgayPhaiTra.Enabled = false;
            chkTinhTrang.Enabled = false;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.DataSource = PhieuMuonTraBUS.Instance.GetPhieuMuonTraByIDDocGia(MaDocGia.Replace("DG", "00"));
            dgvPhieuMuon.Columns[0].HeaderCell.Value = "Số phiếu mượn";
            dgvPhieuMuon.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPhieuMuon.Columns[2].HeaderCell.Value = "Mã cuốn sách";
            dgvPhieuMuon.Columns[3].HeaderCell.Value = "Ngày mượn";
            dgvPhieuMuon.Columns[4].HeaderCell.Value = "Ngày phải trả";
            dgvPhieuMuon.Columns[5].HeaderCell.Value = "Ngày trả";
            dgvPhieuMuon.Columns[6].HeaderCell.Value = "Tiền phạt";
            dgvPhieuMuon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuon.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieuMuon.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPhieuMuon.CurrentRow.Index;
            dtmNgayMuon.Format = DateTimePickerFormat.Custom;
            txtSoPhieuMuonTra.Text = dgvPhieuMuon.Rows[index].Cells[0].Value.ToString();
            txtMaCuonSach.Text = dgvPhieuMuon.Rows[index].Cells[2].Value.ToString();
            dtmNgayMuon.Text = dgvPhieuMuon.Rows[index].Cells[3].Value.ToString();
            dtmNgayPhaiTra.Text = dgvPhieuMuon.Rows[index].Cells[4].Value.ToString();
            dtmNgayTra.Text = dgvPhieuMuon.Rows[index].Cells[5].Value.ToString();
            txtTienPhat.Text = dgvPhieuMuon.Rows[index].Cells[6].Value.ToString();
            string DaTra = CuonSachBUS.Instance.GetAllCuonSachByMaCuonSach(txtMaCuonSach.Text).Rows[0][0].ToString();
            if (DaTra == "0")
            {
                chkTinhTrang.Checked = false;
            }
            else
            {
                chkTinhTrang.Checked = true;
            }
        }
    }
}
