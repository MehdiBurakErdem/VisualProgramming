using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15MovingButton
{
    public partial class Form1 : Form
    {
        int counter;
        int checkstart = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer2.Interval = 500;

            if (checkstart == 1)
            {
                DirectionLabel.Visible = false;
                timer1.Start();
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
            {
                CounterLabel.Text = "Timer: " + (counter/2).ToString();
            }

            if (counter == 20)
            {
                checkstart = 0;
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Time's up, try again!!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            YakalamaButonu.Location = new Point(rand.Next(0,Size.Width - YakalamaButonu.Width), rand.Next(0, Size.Height - YakalamaButonu.Height));
        }

        private void YakalamaButonu_Click(object sender, EventArgs e)
        {
            if (checkstart == 0)
            {
                counter = 0;
                checkstart = 1;
                Form1_Load(sender, e);
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                checkstart = 0;
                MessageBox.Show(Convert.ToInt32(counter / 2) + " saniye de yakaladınız tebrikler..");
            }    
        }
    }
}
