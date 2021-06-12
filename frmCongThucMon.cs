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
    public partial class frmCongThucMon : Form
    {
        private AIDB db = new AIDB();
        public static int maMon;
        public static string tenMon;
        public static List<int> lsMaNguyenLieu;
        public static int lieuLuong;
        private int IDMON;
        public frmCongThucMon()
        {
            InitializeComponent();
        }

        private void frmCongThucMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvCongThucMon.DataSource = db.CONGTHUCMONs.ToList();
            dgvCongThucMon.Columns[0].HeaderText = "Mã món";
            dgvCongThucMon.Columns[1].HeaderText = "Tên món";
            dgvCongThucMon.Columns[2].HeaderText = "Mã nguyên liệu";
            dgvCongThucMon.Columns[3].HeaderText = "Liều lượng";
            dgvCongThucMon.Columns[4].Visible = false;
            dgvCongThucMon.Columns[5].Visible = false;
            dgvCongThucMon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCongThucMon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvCongThucMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maMon = int.Parse(dgvCongThucMon.CurrentRow.Cells[0].Value.ToString().Trim());
            tenMon = dgvCongThucMon.CurrentRow.Cells[1].Value.ToString().Trim();
            IDMON = int.Parse(dgvCongThucMon.CurrentRow.Cells[0].Value.ToString().Trim());
            lsMaNguyenLieu = (List<int>)(from s in db.CONGTHUCMONs
                         where s.IDNL == IDMON
                         select new { s.IDNL});
            frmChiTietCongThuc frm = new frmChiTietCongThuc();
            frm.ShowDialog();
        }
    }
}
