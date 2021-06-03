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
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnNhomNL_Click(object sender, EventArgs e)
        {
            frmNguyenLieu frm = new frmNguyenLieu();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
