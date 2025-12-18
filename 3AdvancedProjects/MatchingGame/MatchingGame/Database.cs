using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingGame
{
    public static class Database
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(@"Data Source=|DataDirectory|\Auth.db;Version=3;");
        }

        // Kullanıcı sayısını ve her levelin yüzdesini döndüren method
        public static DataTable GetLevelStats()
        {
            using (var con = GetConnection())
            {
                con.Open();
                var cmd = new SQLiteCommand(@"
                SELECT level, COUNT(*) as count 
                FROM users 
                GROUP BY level
            ", con);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int GetTotalUsers()
        {
            using (var con = GetConnection())
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM users", con);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void UpdateUserLevel(int userId, int newLevel)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SQLiteCommand("UPDATE users SET level=@level WHERE id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@level", newLevel);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}
