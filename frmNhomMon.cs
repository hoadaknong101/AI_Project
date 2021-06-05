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
    public partial class frmNhomMon : Form
    {
        private AIDB db = new AIDB();
        public frmNhomMon()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            //

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
        }

        private void dgvNhomMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhomMon.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống", "Cảnh báo");
                return;
            }
            txtMaNhom.Text = dgvNhomMon.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = dgvNhomMon.CurrentRow.Cells[1].Value.ToString();
            btnLuu.Enabled = true;
        }

        private void frmNhomMon_Load(object sender, EventArgs e)
        {
            LoadData();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void LoadData()
        {
            dgvNhomMon.DataSource = db.NHOMMONs.ToList();
            Setup();
        }
        private void Setup()
        {
            dgvNhomMon.Columns[2].Visible = false;
            dgvNhomMon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhomMon.Columns[0].HeaderText = "Mã nhóm";
            dgvNhomMon.Columns[1].HeaderText = "Tên nhóm";
        }
    }
}
