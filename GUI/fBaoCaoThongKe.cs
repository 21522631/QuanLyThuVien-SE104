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

namespace GUI
{
    public partial class fBaoCaoThongKe : Form
    {
        public fBaoCaoThongKe(int Index)
        {
            InitializeComponent();
            this.tabBaoCaoThongKe.SelectedIndex = Index;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fBaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
