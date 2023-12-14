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
                BC.Ngay = DateTime.Now.ToString("dd/MM/YYYY");
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
        }

        private void btnTKTinhHinhMuon_Click(object sender, EventArgs e)
        {
            int Nam = dtmTGBCTinhHinhMuon.Value.Year;
            int Thang = dtmTGBCTinhHinhMuon.Value.Month;
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
    }
}
