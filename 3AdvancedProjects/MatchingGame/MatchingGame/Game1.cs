using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Game1 : Form
    {
        private int _level;
        private int _userId;
        private string _username;

        private Button firstCard = null;
        private Button secondCard = null;
        private int matchesFound = 0;
        private List<Button> cards = new List<Button>();

        private int cardAreaWidth = 730;
        private int cardAreaHeight = 600;
        private int cardMaxWidth = 120;
        private int cardMaxHeight = 120;

        private int remainingSeconds;

        public Game1(int userId, string username, int level)
        {
            InitializeComponent();

            _userId = userId;
            _username = username;
            _level = level;

            this.ClientSize = new Size(730, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            MatchesLabel.Text = "Matches Found: 0";
            this.FormClosing += Game1_FormClosing;
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            LevelLabel.Text = $"Level: {_level}";
            matchesFound = 0;
            MatchesLabel.Text = "Matches Found: 0";

            FailPanel.Visible = false;

            StartGameTimer();
            InitializeCards();
        }

        private void StartGameTimer()
        {
            remainingSeconds = _level * 6;
            TimerLabel.Text = $"Time: {remainingSeconds:00}";

            GameTimer.Stop();
            GameTimer.Tick -= GameTimer_Tick;
            GameTimer.Tick += GameTimer_Tick;
            GameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            TimerLabel.Text = $"Time: {remainingSeconds:00}";

            if (remainingSeconds <= 0)
            {
                GameTimer.Stop();
                ShowFailPanel();
            }
        }

        private void ShowFailPanel()
        {
            foreach (var c in cards)
                c.Enabled = false;

            FailPanel.Visible = true;
            FailPanel.BringToFront();
        }

        private void RetryButton_Click_1(object sender, EventArgs e)
        {
            FailPanel.Visible = false;
            matchesFound = 0;
            MatchesLabel.Text = "Matches Found: 0";

            InitializeCards();
            StartGameTimer();
        }

        private void FailMainPageButton_Click_1(object sender, EventArgs e)
        {
            GameTimer.Stop();
            MainPage main = new MainPage(_userId, _username, _level);
            main.Show();
            this.Hide();
        }

        private void InitializeCards()
        {
            cards.Clear();

            foreach (var c in this.Controls.OfType<Button>().Where(b => b.Tag != null).ToList())
                this.Controls.Remove(c);

            firstCard = null;
            secondCard = null;

            int pairs = _level + 1;

            List<Color> colors = new List<Color>
            {
                Color.Black, Color.White, Color.Red, Color.Green,
                Color.Blue, Color.Yellow, Color.Purple, Color.Orange,
                Color.Brown, Color.Pink, Color.Cyan, Color.Magenta
            };

            List<Color> gameColors = colors.Concat(colors).Take(pairs).ToList();
            gameColors.AddRange(gameColors);

            Random rnd = new Random();
            gameColors = gameColors.OrderBy(x => rnd.Next()).ToList();

            int totalCards = gameColors.Count;

            int columns = (int)Math.Ceiling(Math.Sqrt(totalCards));
            int rows = (int)Math.Ceiling((double)totalCards / columns);

            int spacing = 8;

            int cardWidth = (cardAreaWidth - (columns + 1) * spacing) / columns;
            int cardHeight = (cardAreaHeight - (rows + 1) * spacing) / rows;

            cardWidth = Math.Min(cardWidth, cardMaxWidth);
            cardHeight = Math.Min(cardHeight, cardMaxHeight);

            cardWidth = Math.Max(cardWidth, 45);
            cardHeight = Math.Max(cardHeight, 45);

            int startX = (this.ClientSize.Width - (columns * cardWidth + (columns - 1) * spacing)) / 2;
            int startY = 90;

            for (int i = 0; i < gameColors.Count; i++)
            {
                Button card = new Button();
                card.Width = cardWidth;
                card.Height = cardHeight;
                card.BackColor = Color.Gray;
                card.Tag = gameColors[i];
                card.Click += Card_Click;

                int row = i / columns;
                int col = i % columns;

                card.Left = startX + col * (cardWidth + spacing);
                card.Top = startY + row * (cardHeight + spacing);

                this.Controls.Add(card);
                cards.Add(card);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null || clicked.BackColor != Color.Gray)
                return;

            clicked.BackColor = (Color)clicked.Tag;

            if (firstCard == null)
            {
                firstCard = clicked;
                return;
            }

            secondCard = clicked;
            this.Enabled = false;

            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += (s, ev) =>
            {
                t.Stop();
                this.Enabled = true;

                if (firstCard.Tag.Equals(secondCard.Tag))
                {
                    firstCard.Visible = false;
                    secondCard.Visible = false;

                    matchesFound++;
                    MatchesLabel.Text = $"Matches Found: {matchesFound}";

                    if (matchesFound == (_level + 1))
                    {
                        GameTimer.Stop();
                        _level++;
                        Database.UpdateUserLevel(_userId, _level);

                        if (_level >= 10)
                        {
                            Game2 game2 = new Game2(_userId, _username, _level);
                            game2.Show();
                            this.Hide();
                            return;
                        }

                        LevelLabel.Text = $"Level: {_level}";
                        matchesFound = 0;

                        InitializeCards();
                        StartGameTimer();
                    }
                }
                else
                {
                    firstCard.BackColor = Color.Gray;
                    secondCard.BackColor = Color.Gray;
                }

                firstCard = null;
                secondCard = null;
            };
            t.Start();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            GameTimer.Stop();
            MainPage main = new MainPage(_userId, _username, _level);
            main.Show();
            this.Hide();
        }

        private void Game1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTimer.Stop();
        }

        private void MatchesLabel_Click(object sender, EventArgs e) { }
    }
}
