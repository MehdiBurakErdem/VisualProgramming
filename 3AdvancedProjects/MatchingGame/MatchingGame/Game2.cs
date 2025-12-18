using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Game2 : Form
    {
        private int _level;
        private int _userId;
        private string _username;

        private List<int> numbers = new List<int>();
        private int showIndex = 0;
        private int inputIndex = 0;

        public Game2(int userId, string username, int level)
        {
            InitializeComponent();

            _userId = userId;
            _username = username;
            _level = level;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Game2_Load(object sender, EventArgs e)
        {

            FailPanel.Visible = false;

            showIndex = 0;
            inputIndex = 0;

            // LEVEL LABEL
            LevelLabel.Text = $"Level: {_level}";

            // PROGRESS LABEL (MatchesLabel)
            MatchesLabel.Text = $"0/{_level - 8}";

            InputBox.Clear();
            InputBox.Visible = false;
            InputBox.ReadOnly = true;

            NumberLabel.Text = "";
            NumberLabel.Visible = true;

            GenerateNumbers();

            ShowTimer.Stop();
            ShowTimer.Start();
        }

        private void GenerateNumbers()
        {
            numbers.Clear();
            Random rnd = new Random();

            int count = _level - 8;

            for (int i = 0; i < count; i++)
                numbers.Add(rnd.Next(10, 99));
        }

        private void ShowFailPanel()
        {
            InputBox.ReadOnly = true;
            FailPanel.Visible = true;
            FailPanel.BringToFront();
        }

        private void ShowTimer_Tick_1(object sender, EventArgs e)
        {
            if (showIndex < numbers.Count)
            {
                NumberLabel.Text = numbers[showIndex].ToString();
                showIndex++;
            }
            else
            {
                ShowTimer.Stop();

                NumberLabel.Text = "";
                NumberLabel.Visible = false;

                inputIndex = 0;
                MatchesLabel.Text = $"0/{numbers.Count}";

                InputBox.Clear();
                InputBox.Visible = true;
                InputBox.ReadOnly = false;
                InputBox.Focus();
            }
        }

        // EXIT → MainPage (Game1 ile aynı)
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage(_userId, _username, _level);
            main.Show();
            this.Hide();
        }

        private void RetryButton_Click_1(object sender, EventArgs e)
        {
            FailPanel.Visible = false;

            showIndex = 0;
            inputIndex = 0;

            MatchesLabel.Text = $"0/{numbers.Count}";

            InputBox.Clear();
            InputBox.Visible = false;
            InputBox.ReadOnly = true;

            NumberLabel.Text = "";
            NumberLabel.Visible = true;

            GenerateNumbers();

            ShowTimer.Stop();
            ShowTimer.Start();
        }

        private void FailMainPageButton_Click_1(object sender, EventArgs e)
        {
            MainPage main = new MainPage(_userId, _username, _level);
            main.Show();
            this.Hide();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (InputBox.ReadOnly) return;
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;

            if (!int.TryParse(InputBox.Text, out int value))
                return;

            if (value == numbers[inputIndex])
            {
                inputIndex++;
                InputBox.Clear();

                // 🔹 PROGRESS UPDATE
                MatchesLabel.Text = $"{inputIndex}/{numbers.Count}";

                if (inputIndex == numbers.Count)
                {
                    _level++;
                    Database.UpdateUserLevel(_userId, _level);

                    MessageBox.Show($"Level completed! Next Level: {_level}");

                    Game2 next = new Game2(_userId, _username, _level);
                    next.Show();
                    this.Hide();
                }
            }
            else
            {
                ShowFailPanel();
            }
        }
    }
}
