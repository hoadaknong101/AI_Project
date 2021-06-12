using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoad());
            //Application.Run(new frmChiTietMonAn());
            //Application.Run(new frmNguyenLieu());
            //Application.Run(new frmNhomNguyenLieu());
            //Application.Run(new frmDanhSachMonAn());
            //Application.Run(new frmNhomMon());
            //Application.Run(new frmLenThucDon());
        }
    }
}
