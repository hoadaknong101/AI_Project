using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Project
{
    public partial class frmDanhSachMonAn : Form
    {
        public frmDanhSachMonAn()
        {
            InitializeComponent();
        }

        private void btnNhomNL_Click(object sender, EventArgs e)
        {
            frmNhomMon frmNhom = new frmNhomMon();
            frmNhom.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
