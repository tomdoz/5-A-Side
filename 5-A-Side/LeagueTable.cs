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
using System.Data.Sql;

namespace _5_A_Side
{
    public partial class LeagueTable : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30"); 
        SqlCommand Com = new SqlCommand();
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
            Debug.WriteLine(Convert.ToString(UserRank));
            FillRow(UserRank, "User");
            FillRow(MURank, "MU");
            FillRow(CHERank, "CHE");
            FillRow(SOURank, "SOU");
            FillRow(WOLRank, "WOL");
            FillRow(NORRank, "NOR");
        }

        public void OrderTeams()
        {
            int[] PointsToSort = new int[6];
            Con.Open();
            Com.CommandText = "Select * From UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            UserPoints = Convert.ToInt32(reader["UserPoints"]);
            MUPoints = Convert.ToInt32(reader["MUPoints"]);
            CHEPoints = Convert.ToInt32(reader["CHEPoints"]);
            SOUPoints = Convert.ToInt32(reader["SOUPoints"]);
            WOLPoints = Convert.ToInt32(reader["WOLPoints"]);
            NORPoints = Convert.ToInt32(reader["NORPoints"]);
            for (int i = 0; i < PointsToSort.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        PointsToSort[i] = Convert.ToInt32(reader["UserPoints"]);
                        break;

                    case 1:
                        PointsToSort[i] = Convert.ToInt32(reader["MUPoints"]);
                        break;

                    case 2:
                        PointsToSort[i] = Convert.ToInt32(reader["CHEPoints"]);
                        break;

                    case 3:
                        PointsToSort[i] = Convert.ToInt32(reader["SOUPoints"]);
                        break;

                    case 4:
                        PointsToSort[i] = Convert.ToInt32(reader["WOLPoints"]);
                        break;

                    case 5:
                        PointsToSort[i] = Convert.ToInt32(reader["NORPoints"]);
                        break;
                }
            }
            Con.Close();
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

        public void FillRow(int Rank, string Team)
        {
            switch (Rank)
            {
                case 1: //team is in last place 
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    SqlDataReader reader = Com.ExecuteReader();
                    reader.Read();
                    wins6.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws6.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses6.Text = Convert.ToString(reader[Team + "Draws"]);
                    points6.Text = Convert.ToString(reader[Team + "Points"]);
                    GD6.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches6.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select TeamName From Teams Where Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team6.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team6.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team6.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team6.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team6.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team6.Text = "Norwich";
                    }
                    Con.Close();
                    break;

                case 2:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    wins5.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws5.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses5.Text = Convert.ToString(reader[Team + "Draws"]);
                    points5.Text = Convert.ToString(reader[Team + "Points"]);
                    GD5.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches5.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select TeamName From Teams Where Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team5.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team5.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team5.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team5.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team5.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team5.Text = "Norwich";
                    }
                    Con.Close();
                    break;

                case 3:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    wins4.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws4.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses4.Text = Convert.ToString(reader[Team + "Draws"]);
                    points4.Text = Convert.ToString(reader[Team + "Points"]);
                    GD4.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches4.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select TeamName From Teams Where Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team4.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team4.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team4.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team4.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team4.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team4.Text = "Norwich";
                    }
                    Con.Close();
                    break;

                case 4:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    wins3.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws3.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses3.Text = Convert.ToString(reader[Team + "Draws"]);
                    points3.Text = Convert.ToString(reader[Team + "Points"]);
                    GD3.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches3.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select TeamName From Teams Where Id= " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team3.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team3.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team3.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team3.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team3.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team3.Text = "Norwich";
                    }
                    Con.Close();
                    break;

                case 5:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    wins2.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws2.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses2.Text = Convert.ToString(reader[Team + "Draws"]);
                    points2.Text = Convert.ToString(reader[Team + "Points"]);
                    GD2.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches2.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select TeamName From Teams Where Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team2.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team2.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team2.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team2.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team2.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team2.Text = "Norwich";
                    }
                    Con.Close();
                    break;

                case 6:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM UserTable WHERE Id = " + LoginMenu.UserID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    wins1.Text = Convert.ToString(reader[Team + "Wins"]);
                    draws1.Text = Convert.ToString(reader[Team + "Losses"]);
                    losses1.Text = Convert.ToString(reader[Team + "Draws"]);
                    points1.Text = Convert.ToString(reader[Team + "Points"]);
                    GD1.Text = Convert.ToString((Convert.ToInt32(reader[Team + "GF"]) - Convert.ToInt32(reader[Team + "GA"])));
                    matches1.Text = Convert.ToString(reader[Team + "Matches"]);
                    reader.Close();
                    if (Team == "User")
                    {
                        Com.CommandText = "Select * From Teams Where Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        team1.Text = Convert.ToString(reader["TeamName"]);
                    }
                    if (Team == "MU")
                    {
                        team1.Text = "Manchester United";
                    }
                    if (Team == "CHE")
                    {
                        team1.Text = "Chelsea";
                    }
                    if (Team == "SOU")
                    {
                        team1.Text = "Southampton";
                    }
                    if (Team == "WOL")
                    {
                        team1.Text = "Wolves";
                    }
                    if (Team == "NOR")
                    {
                        team1.Text = "Norwich";
                    }
                    Con.Close();
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
