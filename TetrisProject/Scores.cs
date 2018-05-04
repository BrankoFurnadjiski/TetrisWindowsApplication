using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TetrisProject
{
    public static class Scores
    {
        public static List<int> top10 = new List<int>();
        public static int HighScore
        {
            get
            {
                if (File.ReadAllText("scores.txt").Length != 0)
                {
                    return top10[0];
                }
                return 0;
            }
        }

        public static void startScores()
        {
            if (File.Exists("scores.txt"))
            {
                loadScores();
            }
            else
            {
                File.WriteAllText("scores.txt", "");
            }
        }

        public static void Add(int score)
        {
            top10.Add(score);
            top10.Sort();
            top10.Reverse();
            if (top10.Count > 10) top10.RemoveAt(10);
        }

        public static void loadScores()
        {
            if (File.ReadAllText("scores.txt").Length != 0)
            {
                string[] parts = File.ReadAllText("scores.txt").Split(',');
                foreach (string part in parts)
                {
                    Add(int.Parse(part));
                }
            }
        }

        public static void saveScores()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int score in top10)
                sb.Append(score.ToString() + ",");
            sb.Remove(sb.Length - 1, 1);
            File.WriteAllText("scores.txt", sb.ToString());
        }
    }
}
