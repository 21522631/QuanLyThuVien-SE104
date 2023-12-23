using BUS;
using DTO;
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
    public partial class fThemSach : Form
    {
        public fThemSach()
        {
            InitializeComponent();
        }
        private void fThemSach_Load(object sender, EventArgs e)
        {
            cboTheLoai.DataSource = TheLoaiBUS.Instance.GetAllTheLoai();
            cboTheLoai.DisplayMember = "TENTHELOAI";
            cboTheLoai.ValueMember = "MATHELOAI";
            cboTheLoai.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedValue == null) 
            {
                MessageBox.Show("Vui lòng chọn thể loại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTheLoai.Focus();
            }
            else if (txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSach.Focus();
            }
            else if (txtNhaXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhaXuatBan.Focus();
            }
            else if (txtNamXuatBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamXuatBan.Focus();
            }
            else
            {
                Sach sach = new Sach();
                sach.TenSach = txtTenSach.Text;
                sach.NhaXuatBan = txtNhaXuatBan.Text;
                int NamXuatBan;
                if (Int32.TryParse(txtNamXuatBan.Text, out NamXuatBan))
                {
                    if (DateTime.Now.Year - NamXuatBan > ThamSoBUS.Instance.GetThamSo().KhoangCachNamXB)
                    {
                        MessageBox.Show("Khoảng cách năm xuất bản phải nhỏ hơn " + ThamSoBUS.Instance.GetThamSo().KhoangCachNamXB + "!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNamXuatBan.Focus();
                    }
                    else
                    {
                        sach.NamXuatBan = NamXuatBan;
                        sach.IDTheLoai = cboTheLoai.SelectedValue.ToString().Replace("TL", "00");
                        SachBUS.Instance.InsertSach(sach);
                        MessageBox.Show("Thêm mới sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboTheLoai.SelectedIndex = -1;
                        txtTenSach.Text = "";
                        txtNamXuatBan.Text = "";
                        txtNhaXuatBan.Text = "";
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng năm xuất bản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNamXuatBan.Focus();
                }    
            }    
            
        }
    }
}
