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
        private int songay = 0;
        private int sobua = 0;
        private double socalo = 0;
        private int tongsoluong = 0;
        private List<NGUYENLIEU> nguyenlieu = new List<NGUYENLIEU>();

        //-----------------------------------------------------//
        List<ThucDon> QTcu = new List<ThucDon>();

        List<ThucDon> QTmoi = new List<ThucDon>();

        List<ThucDon> QTbandau = new List<ThucDon>();
        private Random ran = new Random();

        private int soluongcathe = 100;

        private int socap = 100;
        private int solanlap = 400;

        private int tylelaitao = 55;

        private int tyledotbiet = 5;

        private int tylesongsot1 = 45;

        private int tylesongsot2 = 90;

        private ThucDon besttd = new ThucDon();

        private int fnbest = 0;



        //----------------------------------------------------//
        public frmLenThucDon()
        {
            InitializeComponent();

        }

        private void getdata()
        {
            nguyenlieu = db.NGUYENLIEUx.ToList();

            foreach (var x in nguyenlieu)
            {
                if (x.SoLuong == 0)
                    nguyenlieu.Remove(x);
            }

        }


        private void Data()
        {
            songay = Convert.ToInt32(tbsongay.Text);
            sobua = Convert.ToInt32(tbsobua.Text);
            socalo = Convert.ToDouble(tbcalo.Text);
            getdata();

            for (int i = 0; i < nguyenlieu.Count() - 1; i++)
            {
                tongsoluong += Convert.ToInt32(nguyenlieu[0].SoLuong.Value.ToString());
            }

        }

        private int fitness(ThucDon td)
        {
            int fn = 0;

            for (int i = 0; i < songay; i++)
            {
                for (int j = 0; j < sobua; j++)
                {
                    Bua bua = td.Ngay[i].Bua[j];

                    double calo = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        calo += Convert.ToDouble(bua.Mon[k].Calo.Value.ToString());
                    }

                    if (calo >= socalo)
                        fn++;

                }
            }

            return fn;
        }

        private void SinhQT()
        {
            for (int temp = 0; temp < soluongcathe; temp++)
            {
                QTbandau.Add(taothucdon());
            }
            nguyenlieu.Clear();


        }

        private ThucDon taothucdon()
        {
            ThucDon td = new ThucDon();
            for (int j = 0; j < songay; j++)
            {
                td.Ngay.Add(taongay());
            }

            return td;

        }

        private Ngay taongay()
        {
            List<MON> cacmon = db.MONs.ToList();
            Ngay ngay = new Ngay();

            for (int i = 0; i < sobua; i++)
            {

                ngay.Bua.Add(taobua());
            }

            return ngay;

        }

        private Bua taobua()
        {

            Bua bua = new Bua();
            for (int k = 0; k < 3; k++)
            {
                bua.Mon.Add(createmon());
            }

            return bua;

        }


        private Boolean checksoluong(NGUYENLIEU nl, int lieuluong)
        {
            if (nl.NHOMNGUYENLIEU.TenNhom.Trim().ToUpper().CompareTo("GIA VI") != 0)
            {
                int temp3 = nguyenlieu.IndexOf(nl);
                int soluongnl = Convert.ToInt32(nguyenlieu[temp3].SoLuong.Value.ToString());

                if (soluongnl >= lieuluong)
                {
                    soluongnl -= lieuluong;

                    nguyenlieu[temp3].SoLuong = soluongnl;

                    return true;
                }
                else
                    return false;

            }

            return true;
        }

        private Boolean checkmon(MON temp)
        {
            List<CONGTHUCMON> congthuc = db.CONGTHUCMONs.ToList();

            int m = Convert.ToInt32(temp.TongNguyenLieu.Value.ToString());

            CONGTHUCMON[] ct = new CONGTHUCMON[m];
            int nct = 0;

            for (int h = 0; h < congthuc.Count() - 1; h++)
            {
                MON mon1 = congthuc[0].MON;

                if (mon1 == temp)
                    ct[nct++] = congthuc[0];
            }

            for (int i = 0; i < m; i++)
            {
                if (checksoluong(ct[i].NGUYENLIEU, Convert.ToInt32(ct[i].LieuLuong)) == false)
                    return false;
            }

            return true;

        }

        private MON createmon()
        {
            List<MON> cacmon = db.MONs.ToList();

            int t = ran.Next(0, cacmon.Count());

            MON temp = cacmon[t];

            while (checkmon(temp) == false)
            {
                t = ran.Next(0, cacmon.Count());
                temp = cacmon[t];
            }

            return temp;
        }

        private void Findbest(List<ThucDon> Quanthe)
        {
            int max = 0;
            for (int i = 0; i < Quanthe.Count(); i++)
            {

                if (fitness(Quanthe[i]) > max)
                {
                    max = fitness(Quanthe[i]);
                    besttd = Quanthe[i];

                }

            }
        }
        private void FindThucDon()
        {
            Data();
            SinhQT();
            int t;
            int k;

            for (int i = 0; i < solanlap; i++)
            {
                Findbest(QTbandau);

                for (int j = 0; j < QTbandau.Count(); j++)
                {
                    QTcu.Add(QTbandau[j]);
                }

                QTbandau.Clear();

                for (int j = 0; j < socap; j++)
                {
                    t = ran.Next(0, QTcu.Count());
                    k = ran.Next(0, QTcu.Count());

                    if (fitness(QTcu[t]) > fitness(QTcu[k]))
                        QTbandau.Add(QTcu[t]);
                    else
                        QTbandau.Add(QTcu[k]);
                }

                QTcu.Clear();
                QTmoi.Clear();

                Laitao();
                QTbandau.Clear();
                for (int j = 0; j < QTmoi.Count(); j++)
                {
                    QTbandau.Add(QTmoi[j]);
                }

            }

        }
        private void Laitao()
        {
            int t = 0;
            int k = 0;
            int n = QTbandau.Count();
            for (int j = 0; j < n / 2; j++)
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

                for (int i = 0; i < songay; i++)
                {
                    Ngay ngay1 = new Ngay();
                    Ngay ngay2 = new Ngay();
                    for (int a = 0; a < sobua; a++)
                    {
                        Bua bua1 = ct1.Ngay[i].Bua[a];
                        Bua bua2 = ct2.Ngay[i].Bua[a];

                        for (int b = 0; b < 3; b++)
                        {
                            MON mon1 = bua1.Mon[b];
                            MON mon2 = bua2.Mon[b];

                            int tile = ran.Next(0, 101);

                            if (tile < tylelaitao)
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

                    ctc1 = dotbien(ctc1);
                    ctc2 = dotbien(ctc2);

                    int tilesongsot = ran.Next(0, 100);

                    if (tilesongsot < tylesongsot1)
                        QTmoi.Add(ctc1);
                    else
                    if (tilesongsot < tylesongsot2)
                        QTmoi.Add(ctc2);
                    else
                    {
                        int h = ran.Next(0, 2);
                        if (h == 0)
                            QTmoi.Add(ctc1);
                        else
                            QTmoi.Add(ctc2);
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
        }
        private ThucDon dotbien(ThucDon td)
        {
            ThucDon temp = new ThucDon();
            for (int i = 0; i < songay; i++)
            {
                Ngay ngay1 = new Ngay();

                for (int a = 0; a < sobua; a++)
                {
                    Bua bua1 = td.Ngay[i].Bua[a];

                    for (int b = 0; b < 3; b++)
                    {
                        MON mon1 = bua1.Mon[b];

                        int tile = ran.Next(0, 101);

                        if (tile < tyledotbiet)
                        {
                            List<CONGTHUCMON> congthuc = db.CONGTHUCMONs.ToList();

                            int m = Convert.ToInt32(mon1.TongNguyenLieu.Value.ToString());

                            CONGTHUCMON[] ct = new CONGTHUCMON[m];

                            for (int j = 0; j < m; j++)
                            {
                                NGUYENLIEU nl = ct[j].NGUYENLIEU;
                                int lieuluong = Convert.ToInt32(ct[j].LieuLuong);
                                if (nl.NHOMNGUYENLIEU.TenNhom.Trim().ToUpper().CompareTo("GIA VI") != 0)
                                {
                                    int temp3 = nguyenlieu.IndexOf(nl);
                                    int soluongnl = Convert.ToInt32(nguyenlieu[temp3].SoLuong.Value.ToString());

                                    soluongnl += lieuluong;

                                    nguyenlieu[temp3].SoLuong = soluongnl;
                                }
                            }

                            mon1 = createmon();
                            bua1.Mon[b] = mon1;
                        }

                    }

                    ngay1.Bua.Add(bua1);

                }
                temp.Ngay.Add(ngay1);

            }
            return temp;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FindThucDon();

            MessageBox.Show(besttd.Ngay[0].Bua[0].Mon[0].TenMon);
        }
    }
}
