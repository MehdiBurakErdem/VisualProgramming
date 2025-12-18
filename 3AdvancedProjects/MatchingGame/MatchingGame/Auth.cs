using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MatchingGame
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
                   string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            using (var con = Database.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT id, level FROM users WHERE username = @u AND password = @p";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", UsernameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", PasswordTextBox.Text.Trim());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            int level = reader.GetInt32(1);

                            // MainForm'a geç
                            MainPage main = new MainPage(userId, UsernameTextBox.Text, level);
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password");
                        }
                    }
                }
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '●';
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Username and password cannot be empty");
                return;
            }

            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO users (username, password) VALUES (@u, @p)";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", UsernameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", PasswordTextBox.Text.Trim());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful! you can log in.");

                        UsernameTextBox.Clear();
                        PasswordTextBox.Clear();
                    }
                    catch (SQLiteException)
                    {
                        MessageBox.Show("This username is already registered.");
                    }
                }
            }
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignButton_Click_1(object sender, EventArgs e)
        {

        }

        private void PasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            int cursorPosition = PasswordTextBox.SelectionStart;

            if (PasswordShow.Checked)
            {
                PasswordTextBox.PasswordChar = '\0'; 
            }
            else
            {
                PasswordTextBox.PasswordChar = '●';
            }
            PasswordTextBox.Focus();
            PasswordTextBox.SelectionStart = cursorPosition;
        }

        private void ShuttOffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
