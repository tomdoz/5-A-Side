using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace _5_A_Side
{
    public partial class LeagueTable : Form
    {
        int[] PointTotals = new int[6];
        int UserRank;
        int MURank;
        int CHERank;
        int SOURank;
        int WOLRank;
        int NORRank;
        int UserPoints;
        int MUPoints;
        int CHEPoints;
        int SOUPoints;
        int WOLPoints;
        int NORPoints;

        public LeagueTable()
        {
            InitializeComponent();
            OrderTeams();
            int[] Ranks = new int[6] { UserRank, MURank, CHERank, SOURank, WOLRank, NORRank };
            string[] Codes = new string[6] { "User", "MU", "CHE", "SOU", "WOL", "NOR" };
            Ranks = PointsDrawCheck(Ranks, Codes);
            UserRank = Ranks[0];
            MURank = Ranks[1];
            CHERank = Ranks[2];
            SOURank = Ranks[3];
            WOLRank = Ranks[4];
            NORRank = Ranks[5];
            FillRow(UserRank, "User", LoginMenu.TeamID ,UserPoints);
            FillRow(MURank, "MU", 1002, MUPoints);
            FillRow(CHERank, "CHE", 1003 ,CHEPoints);
            FillRow(SOURank, "SOU", 1004, SOUPoints);
            FillRow(WOLRank, "WOL", 1005, WOLPoints);
            FillRow(NORRank, "NOR", 1006, NORPoints);
        }

        public int[] PointsDrawCheck(int[] ranks, string[] codes)
        {
            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = i+1; j < ranks.Length; j++)
                {
                    if (ranks[i] == ranks[j])
                    {
                        int iGD = Convert.ToInt32((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, codes[i] + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, codes[i] + "GA"))));
                        int jGD = Convert.ToInt32((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, codes[j] + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, codes[j] + "GA"))));
                        if (iGD > jGD)
                        {
                            ranks[j] = ranks[j] - 1;
                        }
                        else if (jGD > iGD)
                        {
                            ranks[i] = ranks[i] - 1;
                        }
                    }
                    
                }
            }
            return ranks;
        }

        public void OrderTeams()
        {
            int[] PointsToSort = new int[6];
            string[] teamCodes = new string[6] { "User", "MU", "CHE", "SOU", "WOL", "NOR" };
            UserPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "UserPoints"));
            MUPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "MUPoints"));
            CHEPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "CHEPoints"));
            SOUPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "SOUPoints"));
            WOLPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "WOLPoints"));
            NORPoints = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "NORPoints"));


            for (int i = 0; i < PointsToSort.Length; i++)
            {
                PointsToSort[i] = Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, teamCodes[i] + "Points"));
            }
            PointTotals = Utilities.mergeSort(PointsToSort);
            for (int i = 0; i < PointTotals.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 1;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 1;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 1;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 1;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 1;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 1;
                        }
                        break;

                    case 1:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 2;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 2;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 2;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 2;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 2;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 2;
                        }
                        break;

                    case 2:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 3;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 3;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 3;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 3;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 3;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 3;
                        }
                        break;

                    case 3:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 4;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 4;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 4;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 4;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 4;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 4;
                        }
                        break;

                    case 4:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 5;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 5;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 5;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 5;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 5;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 5;
                        }
                        break;

                    case 5:
                        if (UserPoints == PointTotals[i])
                        {
                            UserRank = 6;
                        }
                        if (MUPoints == PointTotals[i])
                        {
                            MURank = 6;
                        }
                        if (CHEPoints == PointTotals[i])
                        {
                            CHERank = 6;
                        }
                        if (SOUPoints == PointTotals[i])
                        {
                            SOURank = 6;
                        }
                        if (WOLPoints == PointTotals[i])
                        {
                            WOLRank = 6;
                        }
                        if (NORPoints == PointTotals[i])
                        {
                            NORRank = 6;
                        }
                        break;
                }
            }
        }

        public void FillRow(int Rank, string Team, int teamID, int points)
        {
            switch (Rank)
            {
                case 1:
                    GD6.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches6.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches"));
                    points6.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team6.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;

                case 2:
                    GD5.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches5.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches"));
                    points5.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team5.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;

                case 3:
                    GD4.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches4.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches"));
                    points4.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team4.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;

                case 4:
                    GD3.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches3.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches"));
                    points3.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team3.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;

                case 5:
                    GD2.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches2.Text = Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches");
                    points2.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team2.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;

                case 6:
                    GD1.Text = Convert.ToString((Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GF")) - Convert.ToInt32(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "GA"))));
                    matches1.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Matches"));
                    points1.Text = Convert.ToString(Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, Team + "Points"));
                    team1.Text = Sql.Select("Select TeamName From Teams Where Id = " + teamID, 0, "TeamName");
                    break;
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
