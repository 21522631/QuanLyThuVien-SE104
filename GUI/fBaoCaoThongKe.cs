using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class fBaoCaoThongKe : Form
    {
        public fBaoCaoThongKe(int Index)
        {
            InitializeComponent();
            this.tabBaoCaoThongKe.SelectedIndex = Index;
        }
        private void fBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            int Thang = dtmTGBCTinhHinhMuon.Value.Month;
            int Nam = dtmTGBCTinhHinhMuon.Value.Year;
            dgvBCSachTraTre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBCTinhHinhMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable data1 = BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam);
            if(data1.Rows.Count > 0)
            {
                int IDBC = Convert.ToInt32(data1.Rows[0][0].ToString());
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(IDBC);
            }
            else
            {
                //Check trh chưa có phiếu mượn nào
                DataTable dt = PhieuMuonTraBUS.Instance.GetTongSoLuotMuonTheoTheLoaiByNgay(Thang, Nam);
                BC_TinhHinhMuonSach BC = new BC_TinhHinhMuonSach();
                BC.Thang = Thang;
                BC.Nam = Nam;
                if (dt.Rows.Count > 0)
                {
                    BC.TongSoLuotMuon = Convert.ToInt32(dt.Compute("SUM(SOLUOTMUON)", string.Empty));
                }
                else
                {
                    BC.TongSoLuotMuon = 0;
                }    
                BC_TinhHinhMuonSachBUS.Instance.InsertBC_TinhHinhMuonSach(BC);
                CT_BC_TinhHinhMuonSach CTBC = new CT_BC_TinhHinhMuonSach();
                CTBC.IDBCTHMS = Convert.ToInt32(BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam).Rows[0][0].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTBC.IDTheLoai = Convert.ToInt32(dt.Rows[i][0].ToString());
                    CTBC.SoLuotMuon = Convert.ToInt32(dt.Rows[i][2].ToString());
                    CTBC.TiLe = float.Parse(CTBC.SoLuotMuon.ToString()) / BC.TongSoLuotMuon;
                    CT_BC_TinhHinhMuonSachBUS.Instance.InsertCT_BCTinhHinhMuonSach(CTBC);
                }
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(CTBC.IDBCTHMS);
            }    
            string Ngay = DateTime.Now.ToString("MM/dd/yyyy");
            DataTable data = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            int SoLuongSachTraTre = data.Rows.Count;
            if(SoLuongSachTraTre > 0) 
            {
                dgvBCSachTraTre.DataSource = data;
            }
            else
            {
                BC_SachTraTre BC = new BC_SachTraTre();
                BC.Ngay = DateTime.Now.ToString("dd/MM/yyyy");
                DataTable SachTraTre = PhieuMuonTraBUS.Instance.GetCuonSachTraTre(Ngay);
                if (SachTraTre.Rows.Count > 0)
                    for (int i  = 0; i < SachTraTre.Rows.Count; i++) 
                    {
                        BC.IDCuonSach = Convert.ToInt32(SachTraTre.Rows[i][0].ToString());
                        BC.NgayMuon = Convert.ToDateTime(SachTraTre.Rows[i][1]).ToString("dd/MM/yyyy");
                        string NgayTra = SachTraTre.Rows[i][2].ToString();
                        BC.SoNgayTraTre = Convert.ToDateTime(Ngay).Subtract(Convert.ToDateTime(NgayTra)).Days;
                        BC_SachTraTreBUS.Instance.InsertBC_SachTraTre(BC);
                    }
                dgvBCSachTraTre.DataSource = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            }
            dgvBCTinhHinhMuon.Columns[0].HeaderCell.Value = "Tên thể loại";
            dgvBCTinhHinhMuon.Columns[1].HeaderCell.Value = "Số lượt mượn";
            dgvBCTinhHinhMuon.Columns[2].HeaderCell.Value = "Tỉ lệ";
            dgvBCSachTraTre.Columns[0].HeaderCell.Value = "Ngày";
            dgvBCSachTraTre.Columns[1].HeaderCell.Value = "ID Cuốn Sách";
            dgvBCSachTraTre.Columns[2].HeaderCell.Value = "Ngày mượn";
            dgvBCSachTraTre.Columns[3].HeaderCell.Value = "Số ngày trả trễ";
            dgvBCSachTraTre.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvBCSachTraTre.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnTKTinhHinhMuon_Click(object sender, EventArgs e)
        {
            int Nam = dtmTGBCTinhHinhMuon.Value.Year;
            int Thang = dtmTGBCTinhHinhMuon.Value.Month;
            DataTable data1 = BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam);
            if (data1.Rows.Count > 0)
            {
                int IDBC = Convert.ToInt32(data1.Rows[0][0].ToString());
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(IDBC);
            }
            else
            {
                DataTable dt = PhieuMuonTraBUS.Instance.GetTongSoLuotMuonTheoTheLoaiByNgay(Thang, Nam);
                BC_TinhHinhMuonSach BC = new BC_TinhHinhMuonSach();
                BC.Thang = Thang;
                BC.Nam = Nam;
                int TongSoLuotMuon;
                Int32.TryParse(dt.Compute("SUM(SOLUOTMUON)", string.Empty).ToString(),out TongSoLuotMuon);
                BC.TongSoLuotMuon = TongSoLuotMuon;
                BC_TinhHinhMuonSachBUS.Instance.InsertBC_TinhHinhMuonSach(BC);
                CT_BC_TinhHinhMuonSach CTBC = new CT_BC_TinhHinhMuonSach();
                CTBC.IDBCTHMS = Convert.ToInt32(BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam).Rows[0][0].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTBC.IDTheLoai = Convert.ToInt32(dt.Rows[i][0].ToString());
                    CTBC.SoLuotMuon = Convert.ToInt32(dt.Rows[i][2].ToString());
                    CTBC.TiLe = float.Parse(CTBC.SoLuotMuon.ToString()) / BC.TongSoLuotMuon;
                    CT_BC_TinhHinhMuonSachBUS.Instance.UpdateCT_BCTinhHinhMuonSach(CTBC);
                }
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(CTBC.IDBCTHMS);
            }
        }
        private void btnTKSachTraTre_Click(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy" };
            string Ngay = DateTime.ParseExact(dtmTGBCSachTraTre.Text.ToString(), formats, new CultureInfo("en-US"), DateTimeStyles.None).ToString();
            DataTable data = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            int SoLuongSachTraTre = data.Rows.Count;
            if (SoLuongSachTraTre > 0)
            {
                dgvBCSachTraTre.DataSource = data;
            }
            else
            {

                BC_SachTraTre BC = new BC_SachTraTre();
                BC.Ngay = dtmTGBCSachTraTre.Text.ToString();
                DataTable SachTraTre = PhieuMuonTraBUS.Instance.GetCuonSachTraTre(Ngay);
                if (SachTraTre.Rows.Count > 0)
                    for (int i = 0; i < SachTraTre.Rows.Count; i++)
                    {
                        BC.IDCuonSach = Convert.ToInt32(SachTraTre.Rows[i][0].ToString());
                        BC.NgayMuon = Convert.ToDateTime(SachTraTre.Rows[i][1]).ToString("dd/MM/yyyy");
                        string NgayTra = SachTraTre.Rows[i][2].ToString();
                        BC.SoNgayTraTre = Convert.ToDateTime(Ngay).Subtract(Convert.ToDateTime(NgayTra)).Days;
                        BC_SachTraTreBUS.Instance.InsertBC_SachTraTre(BC);
                    }
                dgvBCSachTraTre.DataSource = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            }
        }

        private void dtmTGBCTinhHinhMuon_ValueChanged(object sender, EventArgs e)
        {
            int Thang = dtmTGBCTinhHinhMuon.Value.Month;
            int Nam = dtmTGBCTinhHinhMuon.Value.Year;
            dgvBCSachTraTre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBCTinhHinhMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable data1 = BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam);
            if (data1.Rows.Count > 0)
            {
                int IDBC = Convert.ToInt32(data1.Rows[0][0].ToString());
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(IDBC);
            }
            else
            {
                DataTable dt = PhieuMuonTraBUS.Instance.GetTongSoLuotMuonTheoTheLoaiByNgay(Thang, Nam);
                BC_TinhHinhMuonSach BC = new BC_TinhHinhMuonSach();
                BC.Thang = Thang;
                BC.Nam = Nam;
                if (dt.Rows.Count > 0)
                {
                    BC.TongSoLuotMuon = Convert.ToInt32(dt.Compute("SUM(SOLUOTMUON)", string.Empty));
                }
                else
                {
                    BC.TongSoLuotMuon = 0;
                }
                BC_TinhHinhMuonSachBUS.Instance.InsertBC_TinhHinhMuonSach(BC);
                CT_BC_TinhHinhMuonSach CTBC = new CT_BC_TinhHinhMuonSach();
                CTBC.IDBCTHMS = Convert.ToInt32(BC_TinhHinhMuonSachBUS.Instance.GetBC_TinhHinhMuonSachByNgay(Thang, Nam).Rows[0][0].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CTBC.IDTheLoai = Convert.ToInt32(dt.Rows[i][0].ToString());
                    CTBC.SoLuotMuon = Convert.ToInt32(dt.Rows[i][2].ToString());
                    CTBC.TiLe = float.Parse(CTBC.SoLuotMuon.ToString()) / BC.TongSoLuotMuon;
                    CT_BC_TinhHinhMuonSachBUS.Instance.InsertCT_BCTinhHinhMuonSach(CTBC);
                }
                dgvBCTinhHinhMuon.DataSource = CT_BC_TinhHinhMuonSachBUS.Instance.GetAllCT_BCTinhHinhMuonSachByIDBC(CTBC.IDBCTHMS);
            }
        }

        private void dtmTGBCSachTraTre_ValueChanged(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy" };
            string Ngay = DateTime.ParseExact(dtmTGBCSachTraTre.Text.ToString(), formats, new CultureInfo("en-US"), DateTimeStyles.None).ToString();
            DataTable data = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            int SoLuongSachTraTre = data.Rows.Count;
            if (SoLuongSachTraTre > 0)
            {
                dgvBCSachTraTre.DataSource = data;
            }
            else
            {

                BC_SachTraTre BC = new BC_SachTraTre();
                BC.Ngay = dtmTGBCSachTraTre.Text.ToString();
                DataTable SachTraTre = PhieuMuonTraBUS.Instance.GetCuonSachTraTre(Ngay);
                if (SachTraTre.Rows.Count > 0)
                    for (int i = 0; i < SachTraTre.Rows.Count; i++)
                    {
                        BC.IDCuonSach = Convert.ToInt32(SachTraTre.Rows[i][0].ToString());
                        BC.NgayMuon = Convert.ToDateTime(SachTraTre.Rows[i][1]).ToString("dd/MM/yyyy");
                        string NgayTra = SachTraTre.Rows[i][2].ToString();
                        BC.SoNgayTraTre = Convert.ToDateTime(Ngay).Subtract(Convert.ToDateTime(NgayTra)).Days;
                        BC_SachTraTreBUS.Instance.InsertBC_SachTraTre(BC);
                    }
                dgvBCSachTraTre.DataSource = BC_SachTraTreBUS.Instance.GetBC_SachTraTre(Ngay);
            }
        }
        private void btnXuatExcelBCTraTre_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing); ;
            for (int i = 1; i < dgvBCSachTraTre.Columns.Count + 1; i++)
            {
                ExcelApp.Cells[1, i] = dgvBCSachTraTre.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvBCSachTraTre.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBCSachTraTre.Columns.Count; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dgvBCSachTraTre.Rows[i].Cells[j].Value?.ToString();
                }
            }
            ExcelApp.Columns.AutoFit();
            ExcelApp.Visible = true;
        }
    }
}
