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
    public partial class frmChiTietCongThuc : Form
    {
        private AIDB db = new AIDB();
        public frmChiTietCongThuc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietCongThuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            lblMon.Text = db.MONs.Find(frmCongThucMon.maMon).TenMon.ToLower().ToString().Trim();
            lblNhomMon.Text = "Đây là loại " + db.NHOMMONs.Find(db.MONs.Find(frmCongThucMon.maMon).NhomMon).TenNhom.ToString().ToLower().Trim();
            lblTongSoCalo.Text = "Tổng số calo " + db.MONs.Find(frmCongThucMon.maMon).Calo + " kCal";
            lbNguyenLieu.Items.Clear();
            lbNguyenLieu.DataSource = frmCongThucMon.lsMaNguyenLieu;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
