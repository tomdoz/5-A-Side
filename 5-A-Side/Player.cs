using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_A_Side
{
    public class Player : Sql
    {
        public static string GetAttribute(string stat, int TeamID, int PlayerType)
        {
            string value = Select("Select * from Players Where TeamId = " + TeamID.ToString() + " And PlayerType = " + PlayerType.ToString(), 0, stat);
            return value;
        }

        public static int[] CollectStats(int TeamID, int PlayerType)
        {
            int[] PlayerStats = new int[7];
            string[] AttributeNames = new string[7] { "Shooting", "Dribbling", "Pace" , "Physicality" , "Reliability" , "Tackling" , "Aggression" };
            for (int i = 0; i < 7; i++)
            {
                PlayerStats[i] = Convert.ToInt32(GetAttribute(AttributeNames[i], TeamID, PlayerType));
            }
            return PlayerStats;
        }
    } 

}
