//Methods used to manipulate the data of indivdual virtual footballers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_A_Side
{
    public class Player : Sql
    {
        public static string GetAttribute(string stat, int TeamID, int PlayerType) //Queries the Players table to select the value of a specified stat of one player
        {
            string value = Select("Select * from Players Where TeamId = " + TeamID.ToString() + " And PlayerType = " + PlayerType.ToString(), 0, stat);
            return value;
        }

        public static int[] CollectStats(int TeamID, int PlayerType) //Returns an array of the stats of each of the 7 attributes of a specified player
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
