using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapaySinirAgı
{
    public partial class Form1 : Form
    {
        public double giris1;
        public double giris2;
        public double wa;
        public double BeklenenCikis;
        public double Hata;
        public double lr;
        public double wb;
        public double wc;
        public double wd;
        public double we;
        public double wf;
        public double Gwa;
        public double Gwb;
        public double Gwc;
        public double Gwd;
        public double Gwe;
        public double Gwf;
        public double Ywa;
        public double Ywb;
        public double Ywc;
        public double Ywd;
        public double Ywe;
        public double Ywf;
        public double Micinf;
        public double Nicinf;
        public double MicinToplam;
        public double NicinToplam;
        public double SonucToplam;
        public double Sonucf;

        public Form1()
        {
            InitializeComponent();
            
           
        }

        public double Fonksiyon(double x, double y)
        {
            double üssü;
            üssü = Math.Pow(2.7182, x);
            return 1 / (1 + üssü) * y;

        }
        public double Turev(double a)
        {
            return a * (1 - a);
        }
        public void No(double k,double m)
        {

            wa = Convert.ToDouble(textBox10.Text);
            wb = Convert.ToDouble(textBox11.Text);
            wc = Convert.ToDouble(textBox12.Text);
            wd = Convert.ToDouble(textBox13.Text);
            we = Convert.ToDouble(textBox14.Text);
            wf = Convert.ToDouble(textBox15.Text);
            lr = Convert.ToDouble(textBox16.Text);
            MicinToplam = (Fonksiyon(k, wa) + Fonksiyon(m, wb));
            Micinf = Fonksiyon(MicinToplam, 1);
            NicinToplam = (Fonksiyon(k, wc) + Fonksiyon(m, wd));
            Nicinf = Fonksiyon(MicinToplam, 1);
            SonucToplam = (Fonksiyon(Micinf, we) + Fonksiyon(Nicinf, wf));
            Sonucf = Fonksiyon(SonucToplam, 1);
            Hata = (BeklenenCikis - Sonucf) * Turev(Sonucf);

            Gwe = (Hata * we) * Turev(Micinf);
            Ywe = we + (lr * Gwe * MicinToplam);
            Gwf = (Hata * wf) * Turev(Nicinf);
            Ywf = wf + (lr * Gwf * NicinToplam);
            Gwd = (Hata * wd) * Turev(Fonksiyon(m, wd));
            Ywd = wd + (lr * Gwd * m);
            Gwc = (Hata * wc) * Turev(Fonksiyon(m, wc));
            Ywc = wc + (lr * Gwc * m);
            Gwb = (Hata * wb) * Turev(Fonksiyon(k, wb));
            Ywb = wb + (lr * Gwb * k);
            Gwa = (Hata * wa) * Turev(Fonksiyon(k, wa));
            Ywa = wa + (lr * Gwa * k);
            wa = Ywa;
            wb = Ywb;
            wc = Ywc;
            wd = Ywd;
            we = Ywe;
            wf = Ywf;
            textBox10.Text = Convert.ToString(wa);
            textBox11.Text = Convert.ToString(wb);
            textBox12.Text = Convert.ToString(wc);
            textBox13.Text = Convert.ToString(wd);
            textBox14.Text = Convert.ToString(we);
            textBox15.Text = Convert.ToString(wf);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                giris1 = Convert.ToDouble(textBox1.Text);
                giris2 = Convert.ToDouble(textBox2.Text);
                BeklenenCikis = Convert.ToDouble(textBox3.Text);

                No(giris1, giris2);
                giris1 = Convert.ToDouble(textBox6.Text);
                giris2 = Convert.ToDouble(textBox5.Text);
                BeklenenCikis = Convert.ToDouble(textBox4.Text);

                No(giris1, giris2);
                giris1 = Convert.ToDouble(textBox9.Text);
                giris2 = Convert.ToDouble(textBox8.Text);
                BeklenenCikis = Convert.ToDouble(textBox7.Text);

                No(giris1, giris2);

            }
            
            catch (Exception hata)
            {
                MessageBox.Show(""+hata,"Bütün Textboxları Doğru Doldur");
            }
         







        }
    }
}
