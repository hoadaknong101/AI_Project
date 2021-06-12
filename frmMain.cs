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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLenThucDon_Click(object sender, EventArgs e)
        {
            frmLenThucDon thucDon = new frmLenThucDon();
            thucDon.ShowDialog();
        }

        private void btnDSMonAn_Click(object sender, EventArgs e)
        {
            frmDanhSachMonAn monAn = new frmDanhSachMonAn();
            monAn.ShowDialog();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            frmNguyenLieu nguyenLieu = new frmNguyenLieu();
            nguyenLieu.ShowDialog();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu gioiThieu = new frmGioiThieu();
            gioiThieu.ShowDialog();
        }

        private void btnCongThucMon_Click(object sender, EventArgs e)
        {
            frmCongThucMon frm = new frmCongThucMon();
            frm.ShowDialog();
        }
    }
}
