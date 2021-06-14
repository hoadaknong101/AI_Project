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
        private AIDB db = new AIDB();
        public static int tongNguyenLieu;
        public static double calo;
        public static int ManhomMon;
        public static string nhomMon;
        public static int maMon;
        public static string tenMon;
        public static List<int> lsMaNguyenLieu;
        public static int lieuLuong;
        private int IDMON;
        public static List<int> lsLieuLuong;
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

        private void frmDanhSachMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void LoadData()
        {
            dgvMon.DataSource = db.MONs.ToList();
            Setting();
        }
        private void Setting()
        {
            dgvMon.Columns[5].Visible = false;
            dgvMon.Columns[6].Visible = false;
            dgvMon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMon.Columns[0].HeaderText = "Mã món";
            dgvMon.Columns[1].HeaderText = "Tên món";
            dgvMon.Columns[2].HeaderText = "Số NL cần dùng";
            dgvMon.Columns[3].HeaderText = "Số Calo";
            dgvMon.Columns[4].HeaderText = "Nhóm món";
            dgvMon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvMon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dgvMon.RowCount.ToString() == "0")
            //{
            //    MessageBox.Show("Dữ liệu trống", "Cảnh báo");
            //    return;
            //}
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //tenMon = dgvMon.CurrentRow.Cells[1].Value.ToString().Trim();
            ////tongNguyenLieu = int.Parse(dgvMon.CurrentRow.Cells[2].Value.ToString().Trim());
            //calo = double.Parse(dgvMon.CurrentRow.Cells[3].Value.ToString().Trim());
            //ManhomMon = int.Parse(dgvMon.CurrentRow.Cells[4].Value.ToString());
            //nhomMon = db.NHOMMONs.Find(ManhomMon).TenNhom.ToString().ToLower();
            //frmChiTietMonAn monAn = new frmChiTietMonAn();
            //monAn.ShowDialog();
            maMon = int.Parse(dgvMon.CurrentRow.Cells[0].Value.ToString().Trim());
            tenMon = dgvMon.CurrentRow.Cells[1].Value.ToString().Trim();
            IDMON = maMon;
            var x = db.CONGTHUCMONs.Where(s => s.IDMon == IDMON)
                .Select(s => s.IDNL);
            var y = db.CONGTHUCMONs.Where(s => s.IDMon == IDMON)
                .Select(s => s.LieuLuong);
            lsLieuLuong = y.ToList();
            lsMaNguyenLieu = x.ToList();
            frmChiTietCongThuc frm = new frmChiTietCongThuc();
            frm.ShowDialog();
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
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtSLNL.Text = dgvMon.CurrentRow.Cells[2].Value.ToString();
            txtTenMon.Text = dgvMon.CurrentRow.Cells[1].Value.ToString();
            txtCalo.Text = dgvMon.CurrentRow.Cells[3].Value.ToString();
            cbbNhomMon.Text = dgvMon.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
