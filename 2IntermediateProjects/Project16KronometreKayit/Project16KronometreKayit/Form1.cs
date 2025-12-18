using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16KronometreKayit
{
    
    public partial class Form1 : Form
    {
        int TurS = 1;
        public Form1()
        {
          
            InitializeComponent();
            SystemTimer.Start();
            SystemTimer.Interval = 1000;
        }

        private void KronometreTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TimerKronometre.Interval = 1;
            TimerKronometre.Start();
        }

        private void CloseTheAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            TimerKronometre.Stop();
        }

        private void SaliseLabelText_Click(object sender, EventArgs e)
        {
           
        }

        private void TimerKronometre_Tick(object sender, EventArgs e)
        {


            SaliseLabelText.Text = (Convert.ToInt32(SaliseLabelText.Text) + 1).ToString();
            if (Convert.ToInt32(SaliseLabelText.Text) == 60)
            {
                SaliseLabelText.Text = "00";
                SaniyeLabelText.Text = (Convert.ToInt32(SaniyeLabelText.Text) + 1).ToString();
                if (Convert.ToInt32(SaniyeLabelText.Text) == 60)
                {
                    SaniyeLabelText.Text = "00";
                    DakikaLabelText.Text = (Convert.ToInt32(DakikaLabelText.Text) + 1).ToString();
                    if (Convert.ToInt32(DakikaLabelText.Text) == 60)
                    {
                        DakikaLabelText.Text = "00";
                        SaatLabelText.Text = (Convert.ToInt32(SaatLabelText.Text) + 1).ToString();
                        if (Convert.ToInt32(SaatLabelText.Text) == 24)
                        {
                            SaatLabelText.Text = "00";
                        }
                    }
                }
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void SaveToListButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tour" + TurS  + " = " +SaatLabelText.Text + " : " + DakikaLabelText.Text + " : " + SaniyeLabelText.Text + " : " + SaliseLabelText.Text);
            TurS++;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TurS = 1;
            SaatLabelText.Text = "00";
            DakikaLabelText.Text = "00";
            SaniyeLabelText.Text = "00";
            SaliseLabelText.Text = "00";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "KronometreKayit";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                sw.WriteLine("Tour\tSaat\tDakika\tSaniye\tSalise");
                sw.WriteLine("--------------------------------------");

                foreach (var item in listBox1.Items)
                {
                    // Tour1 = 00 : 01 : 23 : 45
                    string[] parca = item.ToString().Split('=');
                    string tur = parca[0].Trim();
                    string[] zaman = parca[1].Split(':');

                    sw.WriteLine(tur + "\t" +
                                 zaman[0].Trim() + "\t" +
                                 zaman[1].Trim() + "\t" +
                                 zaman[2].Trim() + "\t" +
                                 zaman[3].Trim());
                }

                sw.Close();
            }
        }

        private void SystemTarihLabel_Click(object sender, EventArgs e)
        {

        }

        private void SystemSaatLabel_Click(object sender, EventArgs e)
        {

        }

        private void SystemTimer_Tick(object sender, EventArgs e)
        {
            SystemTarihLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
            SystemSaatLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}