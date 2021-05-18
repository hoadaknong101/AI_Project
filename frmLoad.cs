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
    public partial class frmLoad : Form
    {
        Random r = new Random();
        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pnlLoad.Width += r.Next(0,10);
            if (pnlLoad.Width > 584)
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
                timer.Stop();
            }
        }
    }
}
