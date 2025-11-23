using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project14ListQueue
{
    public partial class Form1 : Form
    {
        String id = "2";
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String name, surname, p_number, job;
            id = (Convert.ToInt32(id)+1).ToString();
            name = NameTextBox.Text;
            surname = SurnameTextBox.Text;
            p_number = PhoneNumbertextBox.Text;
            job = JobtextBox.Text;

            String[] colum = { id, name, surname, p_number, job };
            ListViewItem listItem = new ListViewItem(colum);
            listView1.Items.Add(listItem);
            ResultLabel.Text = ("Name: " + name + " Surname: " + surname + " kişisi id:" + id + " olarak eklendi.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Önce seçili satırı sil
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                // Sonra ID’leri baştan sıra sıra güncelle
                int newID = 1;
                foreach (ListViewItem item in listView1.Items)
                {
                    item.SubItems[0].Text = newID.ToString();
                    newID++;
                }

                // Son ID’yi id değişkenine ata
                id = (listView1.Items.Count).ToString();

                ResultLabel.Text = "Kişi silindi ve ID'ler güncellendi.";
            }
            else
            {
                ResultLabel.Text = "Lütfen silmek için bir satır seçin!";
            }
        }


    }
}
