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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String username = "1234";
        String password = "Mehdi123.";
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (username == UsernameBox.Text && password == PasswordBox.Text)
            {
                MessageBox.Show("Giriş Başarılı!");
                Form1 form1 = new Form1();
                this.Hide();

                HesapMakinesi hesapMakinesi = new HesapMakinesi();
                hesapMakinesi.Show();

            }
            else
            {
                UsernameBox.Clear();
                PasswordBox.Clear();
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }
        }
        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KapatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
