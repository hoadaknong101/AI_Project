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
    public partial class frmNhomNguyenLieu : Form
    {
        private AIDB db = new AIDB();
        public frmNhomNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhomNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadData();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void LoadData()
        {
            dgvNhomNL.DataSource = db.NHOMNGUYENLIEUx.ToList();
            Setup();
        }

        private void Setup()
        {
            dgvNhomNL.Columns[2].Visible = false;
            dgvNhomNL.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhomNL.Columns[0].HeaderText = "Mã nhóm";
            dgvNhomNL.Columns[1].HeaderText = "Tên nhóm";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //


            //
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //


            //
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadData();
        }

        private void dgvNhomNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhomNL.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống", "Cảnh báo");
                return;
            }
            txtMaNhom.Text = dgvNhomNL.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = dgvNhomNL.CurrentRow.Cells[1].Value.ToString();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }
    }
}
