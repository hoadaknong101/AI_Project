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
        private AIDB db = new AIDB();
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnNhomNL_Click(object sender, EventArgs e)
        {
            frmNhomNguyenLieu frm = new frmNhomNguyenLieu();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvNL.DataSource = db.NGUYENLIEUx.ToList();
            Setup();
        }
        private void Setup()
        {
            dgvNL.Columns[4].Visible = false;
            dgvNL.Columns[5].Visible = false;
            dgvNL.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNL.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void dgvNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNL.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống", "Cảnh báo");
                return;
            }
            txtIDNL.Text = dgvNL.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dgvNL.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dgvNL.CurrentRow.Cells[2].Value.ToString();
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtIDNL.Text = "";
            txtTenNL.Text = "";
            txtSL.Text = "";
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
    }
}
