using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project13Deneme
{
    public partial class Form1 : Form
    {
        ColorDialog color = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            color.Color = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            SendingSituation.Text = "";

            listBox1.Items.Clear();
            listBox1.Items.Add("Name: " + NameTextBox.Text);
            listBox1.Items.Add("Surname: " + SurnameTextBox.Text);
            listBox1.Items.Add("Age: " + (DateTime.Now.Year - dateTimePicker1.Value.Year));

            listBox1.Items.Add("Your country is: " + cmbCountry.Text);
            if (rbMale.Checked) { listBox1.Items.Add("Person is Okay"); } else {listBox1.Items.Add("Person is not Okay"); }
            
            if(cbSituationOK.Checked && !(cbSituationNo.Checked)) { listBox1.Items.Add("Statuation is OK"); } 
            else if (!(cbSituationOK.Checked) && cbSituationNo.Checked) { listBox1.Items.Add("Statuation is not OK"); }
            else { listBox1.Items.Add("Statuation is not defined"); }

            for (int i = 10; i <= 100; i++)
                progressBar1.Value = i;

            if (progressBar1.Value == 100)
                SendingSituation.Text = "Information Sent... You can check information page";

            if (color != null)
            {
                listBox1.BackColor = color.Color;
                color.Reset();
            }

            tabPage1.Refresh();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnColorDialog_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
        }
    }
}
