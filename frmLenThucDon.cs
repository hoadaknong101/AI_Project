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
    public partial class frmLenThucDon : Form
    {
        private AIDB db = new AIDB();
        private int soNgay = 0;
        private int soBua = 0;
        private double? soCalo = 0;
        private double tongsoluong = 0;
        private List<NGUYENLIEU> nguyenlieu ;
        private List<MON> lsMon = new List<MON>();
        private List<CONGTHUCMON> lsCTM = new List<CONGTHUCMON>();
        private List<CONGTHUCMON> lsCanTim = new List<CONGTHUCMON>();


        //private AIDB db = new AIDB();
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

        DataGridView dgv;

        //-----------------------------------------------------//
        List<ThucDon> QTcu = new List<ThucDon>();

        List<ThucDon> QTmoi = new List<ThucDon>();

        List<ThucDon> QTbandau = new List<ThucDon>();
        private Random ran = new Random();

        private int soLuongCaThe = 40;

        private int soCap = 40;
        private int soLanLap = 100;

        private int tyLeLaiTao = 55;

        private int tyLeDotBien = 5;

        private int tyLeSongSot1 = 45;

        private int tyLeSongSot2 = 90;

        private ThucDon thucDonTotNhat = new ThucDon();




        //----------------------------------------------------//
        public frmLenThucDon()
        {
            InitializeComponent();
            tabControl.Visible = false;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            soNgay = int.Parse(txtSoNgay.Text.Trim());
            soBua = int.Parse(txtSoBua.Text.Trim());
            soCalo = Double.Parse(txtCalo.Text.Trim());
            //KhoiTaoQuanThe();
            ThuatToan();
            PrepareUI();
            MessageBox.Show("Đừng bỏ bữa nhé !\nMãi iu <3","Thông báo iu thưng");
            QTcu.Clear();
            QTmoi.Clear();
            QTbandau.Clear();
        }

        private void frmLenThucDon_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void PrepareUI()
        {
            tabControl.Visible = true;
            List<Ngay> lsNgay = new List<Ngay>();
            List<Bua> lsBua = new List<Bua>();
            for(int i =0;i< soNgay; i++)
            {
                lsNgay.Add(thucDonTotNhat.Ngay[i]);
            }
            
            for (int i = 0;i< soNgay; i++)
            {
                TabPage tabNgay = new TabPage();
                TabControl tmp = new TabControl();
                tabNgay.Controls.Add(tmp);
                tmp.Dock = DockStyle.Fill;
                tabNgay.Text = "Ngày " + (i + 1);
                for (int j = 0; j < soBua; j++)
                {
                    TabPage tabBua = new TabPage();
                    tabBua.Text = "Bữa " + (j + 1);
                    dgv = new DataGridView();
                    dgv.DataSource = thucDonTotNhat.Ngay[i].Bua[j].Mon;
                    dgv.Dock = DockStyle.Fill;
                    tabBua.Controls.Add(dgv);
                    tmp.Controls.Add(tabBua);
                }
                tabControl.Controls.Add(tabNgay);
            }
        }
        private void GetData()
        {
            nguyenlieu = db.NGUYENLIEUx.ToList();
            for(int i =0;i< nguyenlieu.Count();i++)
            {
                if (nguyenlieu[i].SoLuong == 0)
                {
                    nguyenlieu.Remove(nguyenlieu[i]);
                }
            }
            lsMon = db.MONs.ToList();
            lsCTM = db.CONGTHUCMONs.ToList();
        }
        private void KhoiTaoQuanThe()
        {
            for(int i = 0;i< soLuongCaThe; i++)
            {
                QTbandau.Add(TaoThucDon());
            }
        }
        private ThucDon TaoThucDon()
        {
            ThucDon td = new ThucDon();
            for(int i=0;i< soNgay; i++)
            {
                td.Ngay.Add(TaoNgay());
            }
            return td;
        }
        private Ngay TaoNgay()
        {
            Ngay day = new Ngay();
            for(int i =0;i < soBua; i++)
            {
                day.Bua.Add(TaoBua());
            }
            return day;
        }
        private Bua TaoBua()
        {
            Bua b = new Bua();
            for (int i = 0; i < 3; i++)
            {
                MON tmp = TaoMon();
                while(b.Mon.IndexOf(tmp) != -1)
                {
                    tmp = TaoMon();
                }
                b.Mon.Add(tmp);
            }
            return b;
        }
        private MON TaoMon()
        {
            int r = ran.Next(0,lsMon.Count());
            while (KiemTraMon(lsMon[r]) == false)
            {
                r = ran.Next(0, lsMon.Count());
            }
            return lsMon[r];
        }
        private bool KiemTraMon(MON x)
        {
            List<CONGTHUCMON> tmp = db.CONGTHUCMONs.Where(a => a.IDMon == x.ID).ToList();
            for(int i =0;i < tmp.Count(); i++)
            {
                foreach(var t in nguyenlieu)
                {
                    if(tmp[i].IDNL == t.ID && tmp[i].IDNL != 70)
                    {
                        if(tmp[i].LieuLuong <= t.SoLuong)
                        {
                            t.SoLuong -= tmp[i].LieuLuong;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private int Fitness(ThucDon x)
        {
            int dem = 0;
            for(int i =0;i< soNgay; i++)
            {
                for(int j = 0;j < soBua; j++)
                {
                    double? tongCalo = 0;
                    foreach(var t in x.Ngay[i].Bua[j].Mon)
                    {
                        tongCalo += t.Calo;
                    }
                    if (tongCalo - soCalo > -50 && tongCalo - soCalo < 50)
                    {
                        dem += 3;
                    }
                    else if (tongCalo - soCalo > -100 && tongCalo - soCalo < 100)
                    {
                        dem += 2;
                    }
                    else
                    {
                        if (tongCalo - soCalo > -200 && tongCalo - soCalo < 200)
                        {
                            dem++;
                        }
                    }
                        
                }
            }
            return dem;
        }
        private void TimThucDonTotNhat()
        {
            int max = 0;
            for (int i = 0; i < QTbandau.Count(); i++)
            {
                if (Fitness(QTbandau[i]) > max)
                {
                    max = Fitness(QTbandau[i]);
                    thucDonTotNhat = QTbandau[i];
                }
            }
        }
        private void ThuatToan()
        {
            KhoiTaoQuanThe();
            int t ;
            int k ;
            for(int i =0;i < soLanLap; i++)
            {
                TimThucDonTotNhat();
                for (int j = 0; j < QTbandau.Count(); j++)
                {
                    QTcu.Add(QTbandau[j]);
                }
                QTbandau.Clear();
                for(int h = 0;h < soCap; h++)
                {
                    t = ran.Next(0, QTcu.Count());
                    k = ran.Next(0, QTcu.Count());
                    if (Fitness(QTcu[t]) > Fitness(QTcu[k]))
                        QTbandau.Add(QTcu[t]);
                    else
                        QTbandau.Add(QTcu[k]);
                }
                QTcu.Clear();
                QTmoi.Clear();
                LaiTao();
                QTbandau.Clear();
                for (int j = 0; j < QTmoi.Count(); j++)
                {
                    QTbandau.Add(QTmoi[j]);
                }
            }
        }
        private void LaiTao()
        {
            int t;
            int k;
            for(int i = 0;i< QTbandau.Count() / 2; i++)
            {
                t = ran.Next(0, QTbandau.Count());
                k = ran.Next(0, QTbandau.Count());
                while (t == k && QTbandau.Count() > 1)
                {
                    t = ran.Next(0, QTbandau.Count());
                    k = ran.Next(0, QTbandau.Count());
                }
                ThucDon ct1 = QTbandau[t];
                ThucDon ct2 = QTbandau[k];
                ThucDon ctc1 = new ThucDon();
                ThucDon ctc2 = new ThucDon();
                for(int j = 0;j < soNgay; j++)
                {
                    Ngay ngay1 = new Ngay();
                    Ngay ngay2 = new Ngay();
                    for(int a = 0; a <soBua; a++)
                    {
                        Bua bua1 = ct1.Ngay[j].Bua[a];
                        Bua bua2 = ct2.Ngay[j].Bua[a];
                        for(int b = 0; b < 3; b++)
                        {
                            MON mon1 = bua1.Mon[b];
                            MON mon2 = bua2.Mon[b];
                            int tyLe = ran.Next(0, 100);
                            if(tyLe < tyLeLaiTao)
                            {
                                bua1.Mon[b] = mon2;
                                bua2.Mon[b] = mon1;
                            }
                        }
                        ngay1.Bua.Add(bua1);
                        ngay2.Bua.Add(bua2);                        
                    }
                    ctc1.Ngay.Add(ngay1);
                    ctc2.Ngay.Add(ngay2);
                }
                ctc1 = DotBien(ctc1);
                ctc2 = DotBien(ctc2);
                int tyLeSongSot = ran.Next(0, 100);
                if (tyLeSongSot < tyLeSongSot1)
                {
                    QTmoi.Add(ctc1);
                }
                else
                {
                    if (tyLeSongSot < tyLeSongSot2)
                    {
                        QTmoi.Add(ctc2);
                    }
                    else
                    {
                        int o = ran.Next(0, 2);
                        if (o == 0)
                        {
                            QTmoi.Add(ctc1);
                        }
                        else
                        {
                            QTmoi.Add(ctc2);
                        }
                    }
                }
                if (k > t)
                {
                    QTbandau.Remove(QTbandau[k]);
                    QTbandau.Remove(QTbandau[t]);
                }
                else
                {
                    QTbandau.Remove(QTbandau[t]);
                    QTbandau.Remove(QTbandau[k]);
                }
            }
        }
        private ThucDon DotBien(ThucDon x)
        {
            for (int i = 0; i < soNgay;i++)
            {
                for(int j = 0;j< soBua; j++)
                {
                    for(int k = 0;k < 3; k++)
                    {
                        int tyLe = ran.Next(0, 100);
                        if(tyLe < tyLeDotBien)
                        {
                            TraNguyenLieu(x.Ngay[i].Bua[j].Mon[k]);
                            MON ano = TaoMon();
                            x.Ngay[i].Bua[j].Mon[k] = ano;
                        }
                    }
                }
            }
            return x;
        }
        private void TraNguyenLieu(MON x)
        {
            List<CONGTHUCMON> tmp = db.CONGTHUCMONs.Where(a => a.IDMon == x.ID).ToList();
            for (int i = 0; i < tmp.Count(); i++)
            {
                foreach (var t in nguyenlieu)
                {
                    if (tmp[i].IDNL == t.ID && tmp[i].IDNL != 70)
                    {
                        if (tmp[i].LieuLuong <= t.SoLuong)
                        {
                            t.SoLuong += tmp[i].LieuLuong;
                        }
                    }
                }
            }
        }
    }
}
