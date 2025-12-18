using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MatchingGame
{
    public partial class MainPage : Form
    {
        private string _username;
        private int _level;
        private int _userId;

        public MainPage(int userId, string username, int level)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            _level = level;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            InformationText.Text = $"Welcome {_username}\nLevel: {_level}";
            LoadChart();
        }

        private void LoadChart()
        {
            var dt = Database.GetLevelStats();

            UsersChart.Series.Clear();
            UsersChart.ChartAreas[0].AxisY.Interval = 1;
            UsersChart.ChartAreas[0].AxisY.Minimum = 0;

            Series series = new Series("Number of gamers");
            series.ChartType = SeriesChartType.Column;

            int maxLevel = dt.AsEnumerable()
                .Select(r => Convert.ToInt32(r["level"]))
                .DefaultIfEmpty(1)
                .Max();

            for (int i = 1; i <= maxLevel; i++)
            {
                var row = dt.Select("level=" + i);
                int count = row.Length > 0 ? Convert.ToInt32(row[0]["count"]) : 0;
                series.Points.AddXY("Lvl " + i, count);
            }

            UsersChart.Series.Add(series);
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            if (_level >= 10)
            {
                Game2 game2 = new Game2(_userId, _username, _level);
                game2.Show();
            }
            else
            {
                Game1 game1 = new Game1(_userId, _username, _level);
                game1.Show();
            }

            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
