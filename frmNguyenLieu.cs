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
        private List<NGUYENLIEU> lsCanTim = new List<NGUYENLIEU>();
        private List<NHOMNGUYENLIEU> lsNhomNL = new List<NHOMNGUYENLIEU>();
        private List<string> lsLoc = new List<string>();
        private List<NGUYENLIEU> lsDongVat = new List<NGUYENLIEU>(); 
        private List<NGUYENLIEU> lsThucVat = new List<NGUYENLIEU>(); 
        private List<NGUYENLIEU> lsGiaVi = new List<NGUYENLIEU>(); 
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
            lsNhomNL = db.NHOMNGUYENLIEUx.ToList();
            cbbNhomMon.DataSource = lsNhomNL;
            cbbNhomMon.DisplayMember = "TenNhom";
            cbbNhomMon.ValueMember = "ID";
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            dgvNL.EditMode = DataGridViewEditMode.EditProgrammatically;
            lsLoc.Add("Tất cả");
            lsLoc.Add("Động vật");
            lsLoc.Add("Thực vật");
            lsLoc.Add("Gia vị");
            cbbLoc.DataSource = lsLoc;
        }
        private void LoadData()
        {
            dgvNL.DataSource = db.NGUYENLIEUx.ToList();
            Setup();
            var dv = from d in db.NGUYENLIEUx
                     where d.NhomNL == 50
                     select d;
            var tv = from t in db.NGUYENLIEUx
                     where t.NhomNL == 60
                     select t;
            var gv = from g in db.NGUYENLIEUx
                     where g.NhomNL == 70
                     select g;
            lsDongVat = dv.ToList();
            lsThucVat = tv.ToList();
            lsGiaVi = gv.ToList();
               
        }
        private void Setup()
        {
            dgvNL.Columns[4].Visible = false;
            dgvNL.Columns[5].Visible = false;
            dgvNL.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNL.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNL.Columns[0].HeaderText = "Mã NL";
            dgvNL.Columns[1].HeaderText = "Tên NL";
            dgvNL.Columns[2].HeaderText = "Mã nhóm";
            dgvNL.Columns[3].HeaderText = "Số lượng";
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
            btnHuy.Enabled = true;
            txtIDNL.Text = dgvNL.CurrentRow.Cells[0].Value.ToString();
            txtTenNL.Text = dgvNL.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dgvNL.CurrentRow.Cells[3].Value.ToString();
            var x = db.NHOMNGUYENLIEUx.Find(int.Parse(dgvNL.CurrentRow.Cells[2].Value.ToString()));
            cbbNhomMon.Text = x.TenNhom;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtIDNL.Text = "";
            txtTenNL.Text = "";
            txtSL.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            var add = new NGUYENLIEU()
            {
                ID = int.Parse(txtIDNL.Text.Trim()),
                TenNL = txtTenNL.Text.Trim(),
                NhomNL = int.Parse(cbbNhomMon.Text.Trim()),
                SoLuong = Double.Parse(txtSL.Text.Trim()),
            };
            db.NGUYENLIEUx.Add(add);
            db.SaveChanges();
            //
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //
            var mod = db.NGUYENLIEUx.Find(int.Parse(txtIDNL.Text.Trim()));
            mod.SoLuong = Double.Parse(txtSL.Text.Trim());
            db.SaveChanges();
            //
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var find = from f in db.NGUYENLIEUx
                       where f.TenNL.StartsWith(txtNhapTen.Text)
                       select f;
            lsCanTim = find.ToList();
            dgvNL.DataSource = lsCanTim;
            Setup();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvNL.DataSource = db.NGUYENLIEUx.ToList();
            Setup();
            txtNhapTen.Clear();
            dgvNL.ClearSelection();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void cbbLoc_TextChanged(object sender, EventArgs e)
        {
            if(cbbLoc.SelectedIndex == 0)
            {
                dgvNL.DataSource = db.NGUYENLIEUx.ToList();
                Setup();
            }
            if(cbbLoc.SelectedIndex == 1)
            {
                dgvNL.DataSource = lsDongVat;
                Setup();
            }
            if(cbbLoc.SelectedIndex == 2)
            {
                dgvNL.DataSource = lsThucVat;
                Setup();
            }
            if(cbbLoc.SelectedIndex == 3)
            {
                dgvNL.DataSource = lsGiaVi;
                Setup();
            }
        }
    }
}
