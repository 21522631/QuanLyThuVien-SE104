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
    public partial class fDocGiaPhieuThuTienPhat : Form
    {
        private string MaDocGia;
        public fDocGiaPhieuThuTienPhat(string MaDocGia)
        {
            InitializeComponent();
            this.MaDocGia = MaDocGia;
        }

        private void fDocGiaPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            txtSoPhieuThu.Enabled = false;
            txtConLai.Enabled = false;
            txtSoTienThu.Enabled = false;
            txtTongNo.Enabled = false;
            dtmNgayThu.Enabled = false;
            dgvPTTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPTTP.DataSource = PhieuThuTienPhatBUS.Instance.GetPhieuThuTienPhatByIDDocGia(MaDocGia.Replace("DG","00"));
            dgvPTTP.Columns[0].HeaderCell.Value = "Số phiếu thu";
            dgvPTTP.Columns[1].HeaderCell.Value = "Mã độc giả";
            dgvPTTP.Columns[2].HeaderCell.Value = "Ngày thu";
            dgvPTTP.Columns[3].HeaderCell.Value = "Tổng nợ";
            dgvPTTP.Columns[4].HeaderCell.Value = "Số tiền thu";
            dgvPTTP.Columns[5].HeaderCell.Value = "Còn lại";
            dgvPTTP.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgvPTTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPTTP.CurrentRow.Index;
            txtSoPhieuThu.Text = dgvPTTP.Rows[index].Cells[0].Value.ToString();
            dtmNgayThu.Text = dgvPTTP.Rows[index].Cells[2].Value.ToString();
            txtTongNo.Text = dgvPTTP.Rows[index].Cells[3].Value.ToString();
            txtSoTienThu.Text = dgvPTTP.Rows[index].Cells[4].Value.ToString();
            txtConLai.Text = dgvPTTP.Rows[index].Cells[5].Value.ToString();
        }
    }
}
