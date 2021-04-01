using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1180505018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Drawing.Graphics Cizgi;


        //kordinat sisteminde çizim yapmak için tanımlı bir kütüphane kullanıyoruz
        Pen Klm = new Pen(Color.Red, 2);

        //işlem yappılırken kolaylık olması için global bir dizi tanımlıyoruz
        Double[,] XYeni = new Double[3, 3];

        //üçgenin noktalarını veritoruz
        Double[,] XCisimNokta = new Double[3, 3]{ {2,3,1},
                                                  {7,3,1},
                                                  {2,6,1} };

        //burda döndürme işlemi için döndürme dizisini tanımlıyor fonksiyon üzerinde açıları veriyoruz
        Double[,] Tdondur = new Double[3, 3]{ {1, 0, 0},
                                              {0, 1, 0},
                                              {0, 0, 1} };

        // x eksenin de yansıtma yapmak için y eksenine (-) değer veriyoruz 
        Double[,] Tyansit = new double[3, 3]{ { 1,  0, 0 },
                                              { 0, -1, 0 },
                                              { 0,  0, 1 } };

        //üçgeni kordinat sistemine sığdırmak için ölçülendiriyoruz
        static double sıgdır(double x)
        {
            return x * (0.1);
        }
        int i, j, k;


        //ekranda kordinat sisteminin çizileceği konumu belirliyoruz
        private int KoordinatHesaplaX(Double geciciX)
        {
            return Convert.ToInt32(300 + 250 + (200 * geciciX));
        }

        private int KoordinatHesaplaY(Double geciciY)
        {
            return Convert.ToInt32(250 + (-200 * geciciY));
        }

        //Çizilecek üögenin temel noktalarını tanımlıyoruz
        private void Ciz()
        {
            Cizgi = this.CreateGraphics();

            Klm.Color = Color.Yellow;
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])), KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])), KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])), KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])));
            Cizgi.Dispose();
        }


        //kordinat sisteminin çizimini butona aktardım kordinat sistemini çiziyor
        private void btnEksen_Click(object sender, EventArgs e)
        {
            Cizgi = this.CreateGraphics();
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(-1), KoordinatHesaplaY(0), KoordinatHesaplaX(1), KoordinatHesaplaY(0));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(0), KoordinatHesaplaY(-1), KoordinatHesaplaX(0), KoordinatHesaplaY(1));
            Cizgi.Dispose();
        }

        //çiz butonunu tanımlıyoruz üçgenin değerlerini xyeni dizisine aktarıp çizim işlemini gerçekleştiriyoruz
        private void btnCiz_Click(object sender, EventArgs e)
        {

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    XYeni[i, j] = 0;

                    XYeni[i, j] = XCisimNokta[i, j];
                }
            }

            Ciz();
        }

        //temizleme işlemi
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //döndürme işlemini gerçekleştiriyor
        private void button1_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[3, 3];
            Double teta = 30;

            //alınan derece randyana çevrilip döndürme matrisinde yerlerine yerleştiriliyor
            teta = Convert.ToDouble(txtDondur.Text);
            Tdondur[0, 0] = Math.Cos(Math.PI * teta / 180.0);
            Tdondur[1, 1] = Tdondur[0, 0];

            Tdondur[1, 0] = Math.Sin(Math.PI * teta / 180.0);
            Tdondur[0, 1] = (-1) * Tdondur[1, 0];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 3; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Tdondur[k, j];
                    }
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    XYeni[i, j] = 0;

                    XYeni[i, j] = Gecici[i, j];
                }
            }

            Klm.Color = Color.Purple;
            Ciz();
            Cizgi = this.CreateGraphics();
            Klm.Color = Color.Purple;
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])), KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])), KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])), KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])));
            Cizgi.Dispose();
        }


        //x eksenine göre yansıtma işlemi gerçekleştiriyoruz
        private void btnYansıt_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 3; k++)
                    {
                        Gecici[i, j] += XCisimNokta[i, k] * Tyansit[k, j];
                    }
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    XYeni[i, j] = 0;

                    XYeni[i, j] = Gecici[i, j];
                }
            }

            Klm.Color = Color.Blue;
            Ciz();
            
            Cizgi = this.CreateGraphics();
            Klm.Color = Color.Blue;
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])), KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[1, 0])), KoordinatHesaplaY(sıgdır(XYeni[1, 1])), KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])));
            Cizgi.DrawLine(Klm, KoordinatHesaplaX(sıgdır(XYeni[2, 0])), KoordinatHesaplaY(sıgdır(XYeni[2, 1])), KoordinatHesaplaX(sıgdır(XYeni[0, 0])), KoordinatHesaplaY(sıgdır(XYeni[0, 1])));
            Cizgi.Dispose();

        }

    }
}
