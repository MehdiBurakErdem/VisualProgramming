using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        int sayi = 0;
        String islem = "";
        Boolean ekran_S = false;

        private void Sonuc_Click(object sender, EventArgs e)
        {

        }
        private void Sayi1_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "1";
        }

        private void Sayi2_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "2";
        }

        private void Sayi3_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "3";
        }

        private void Sayi4_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "4";
        }

        private void Sayi5_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "5";
        }

        private void Sayi6_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "6";
        }

        private void Sayi7_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "7";
        }

        private void Sayi8_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "8";
        }

        private void Sayi9_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "9";
        }

        private void Sayi0_Click(object sender, EventArgs e)
        {
            if (ekran_S == false)
            {
                ekran_S = true;
                Sonuc.Text = "";
            }
            Sonuc.Text += "0";
        }

        private void Toplama_Click(object sender, EventArgs e)
        {
            if (ekran_S == true){
                ekran_S = false;
                sayi = Convert.ToInt32(Sonuc.Text);
                islem = "+";
                Sonuc.Text = "0";
            }
        }

        private void Cikartma_Click(object sender, EventArgs e)
        {
            if (ekran_S == true)
            {
                ekran_S = false;
                sayi = Convert.ToInt32(Sonuc.Text);
                islem = "-";
            }
        }

        private void Carpma_Click(object sender, EventArgs e)
        {
            if (ekran_S == true)
            {
                ekran_S = false;
                sayi = Convert.ToInt32(Sonuc.Text);
                islem = "*";
            }
        }

        private void Bolme_Click(object sender, EventArgs e)
        {
            if (ekran_S == true)
            {
                ekran_S = false;
                sayi = Convert.ToInt32(Sonuc.Text);
                islem = "/";
            }
        }

        private void Esittir_Click(object sender, EventArgs e)
        {
            switch(islem)
            {
                case "+":
                    Sonuc.Text = Convert.ToString(sayi + Convert.ToInt32(Sonuc.Text));
                    break;
                case "-":
                    Sonuc.Text = Convert.ToString(sayi - Convert.ToInt32(Sonuc.Text));
                    break;
                case "*":
                    Sonuc.Text = Convert.ToString(sayi * Convert.ToInt32(Sonuc.Text));
                    break;
                case "/":
                    Sonuc.Text = Convert.ToString(sayi / Convert.ToInt32(Sonuc.Text));
                    break;
            }
            ekran_S = false;
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            ekran_S = false;
            Sonuc.Text = "0";
            sayi = 0;
        }

        private void KapatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
