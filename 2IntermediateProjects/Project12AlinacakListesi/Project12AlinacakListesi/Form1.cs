using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12AlinacakListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Elma");
            comboBox1.Items.Add("Armut");
            comboBox1.Items.Add("Ekmek");
        }


        private void WritetoListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void DeletetoListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }


        private void WritetoComboBox_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(textBox1.Text))
                comboBox1.Items.Add(textBox1.Text);
            else
                MessageBox.Show("Bu öğe zaten mevcut.");
        }

        private void DeletetoComboBox_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
        }

        private void ComboBoxToListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
