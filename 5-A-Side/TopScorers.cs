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
using System.Data.Sql;


namespace _5_A_Side
{
    public partial class TopScorers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        public int TeamID;
        public int TeamIDForFixtures;
        public int GF;
        public string playerName;
        public string teamName;
        public string LastMatch;
        public string NextMatch;

        public TopScorers()
        {
            InitializeComponent();
            RankingTeams(1);
            RankingTeams(2);
            RankingTeams(3);
            RankingTeams(4);
            RankingTeams(5);
        }

        public void RankingTeams(int Rank) //Ranking teams by who scores the most goals
        {
            Con.Open();
            Com.CommandText = "SELECT * FROM Teams ORDER BY GF Desc";
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            for (int i = 1; i < (Rank + 1); i++)
            {
                reader.Read();
            }
            TeamID = Convert.ToInt32(reader["Id"]);
            TeamIDForFixtures = TeamID;
            if (TeamID == LoginMenu.TeamID)
            {
                TeamIDForFixtures = 1;
            }
            GF = Convert.ToInt32(reader["GF"]);
            teamName = Convert.ToString(reader["TeamName"]);
            reader.Close();
            Con.Close();
            RankingPlayersByShooting(Rank);
        }

        public void RankingPlayersByShooting(int Rank)
        {
            Con.Open();
            Com.CommandText = "SELECT * FROM Players WHERE TeamID = " + TeamID + " ORDER BY Shooting Desc";
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            playerName = Convert.ToString(reader["Name"]);
            reader.Close();
            Con.Close();
            getLastMatch(Rank);
        }

        public void getLastMatch(int Rank)
        {
            Con.Open();
            Com.CommandText = "SELECT CurrFixtureID FROM UserTable WHERE Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int CurrFixtureID = Convert.ToInt32(reader["CurrFixtureID"]);
            for (int i = 0; i < CurrFixtureID; i++)
            {
                reader.Close();
                CurrFixtureID--;
                Com.CommandText = "SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID;
                Com.Connection = Con;
                reader = Com.ExecuteReader();
                reader.Read();
                if (Convert.ToInt32(reader["HomeTeamID"]) == TeamIDForFixtures)
                {
                    if (Convert.ToInt32(reader["AwayTeamID"]) == 1)
                    {
                        reader.Close();
                        Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        string awayTeam = Convert.ToString(reader["TeamName"]);
                        LastMatch = teamName + " v " + awayTeam;
                        break;
                    }
                    else
                    {
                        int AwayID = Convert.ToInt32(reader["AwayTeamID"]);
                        reader.Close();
                        Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + AwayID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        string awayTeam = Convert.ToString(reader["TeamName"]);
                        LastMatch = teamName + " v " + awayTeam;
                        break;
                    }
                }

                if (Convert.ToInt32(reader["AwayTeamID"]) == TeamIDForFixtures)
                {
                    if (Convert.ToInt32(reader["HomeTeamID"]) == 1)
                    {
                        reader.Close();
                        Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        string homeTeam = Convert.ToString(reader["TeamName"]);
                        LastMatch = homeTeam + " v " + teamName;
                        break;
                    }
                    else
                    {
                        int HomeID = Convert.ToInt32(reader["HomeTeamID"]);
                        reader.Close();
                        Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + HomeID;
                        Com.Connection = Con;
                        reader = Com.ExecuteReader();
                        reader.Read();
                        string homeTeam = Convert.ToString(reader["TeamName"]);
                        LastMatch = homeTeam + " v " + teamName;
                        break;
                    }
                }
            }
            Con.Close();
            GetNextMatch(Rank);
        }

        public void GetNextMatch(int Rank)
        {
            Con.Open();
            Com.CommandText = "SELECT CurrFixtureID FROM UserTable WHERE Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int CurrFixtureID = Convert.ToInt32(reader["CurrFixtureID"]); 
            if (CurrFixtureID == 31)
            {
                reader.Close();
                Con.Close();
                NextMatch = "N/A";
                FillRow(Rank);
            }
            else
            {
                for (int i = 0; i < CurrFixtureID; i++)
                {
                    reader.Close();
                    Con.Close();
                    CurrFixtureID++;
                    Con.Open();
                    Com.CommandText = "SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID;
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    reader.Read();
                    if (Convert.ToInt32(reader["HomeTeamID"]) == TeamIDForFixtures)
                    {
                        if (Convert.ToInt32(reader["AwayTeamID"]) == 1)
                        {
                            reader.Close();
                            Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID;
                            Com.Connection = Con;
                            reader = Com.ExecuteReader();
                            reader.Read();
                            string awayTeam = Convert.ToString(reader["TeamName"]);
                            NextMatch = teamName + " v " + awayTeam;
                            break;
                        }
                        else
                        {
                            int AwayID = Convert.ToInt32(reader["AwayTeamID"]);
                            reader.Close();
                            Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + AwayID;
                            Com.Connection = Con;
                            reader = Com.ExecuteReader();
                            reader.Read();
                            string awayTeam = Convert.ToString(reader["TeamName"]);
                            NextMatch = teamName + " v " + awayTeam;
                            break;
                        }
                    }

                    if (Convert.ToInt32(reader["AwayTeamID"]) == TeamIDForFixtures)
                    {
                        if (Convert.ToInt32(reader["HomeTeamID"]) == 1)
                        {
                            reader.Close();
                            Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID;
                            Com.Connection = Con;
                            reader = Com.ExecuteReader();
                            reader.Read();
                            string homeTeam = Convert.ToString(reader["TeamName"]);
                            NextMatch = homeTeam + " v " + teamName;
                            break;
                        }
                        else
                        {
                            int HomeID = Convert.ToInt32(reader["HomeTeamID"]);
                            reader.Close();
                            Com.CommandText = "SELECT TeamName FROM Teams WHERE Id = " + HomeID;
                            Com.Connection = Con;
                            reader = Com.ExecuteReader();
                            reader.Read();
                            string homeTeam = Convert.ToString(reader["TeamName"]);
                            NextMatch = homeTeam + " v " + teamName;
                            break;
                        }
                    }
                }
                Con.Close();
                FillRow(Rank);
            }
        }

        public void FillRow(int Rank)
        {
            switch (Rank)
            {
                case 1:
                    player1.Text = playerName;
                    team1.Text = teamName;
                    goals1.Text = Convert.ToString(GF / 3);
                    lastMatch1.Text = LastMatch;
                    nextMatch1.Text = NextMatch;
                    break;

                case 2:
                    player2.Text = playerName;
                    team2.Text = teamName;
                    goals2.Text = Convert.ToString(GF / 3);
                    lastMatch2.Text = LastMatch;
                    nextMatch2.Text = NextMatch;
                    break;

                case 3:
                    player3.Text = playerName;
                    team3.Text = teamName;
                    goals3.Text = Convert.ToString(GF / 3);
                    lastMatch3.Text = LastMatch;
                    nextMatch3.Text = NextMatch;
                    break;

                case 4:
                    player4.Text = playerName;
                    team4.Text = teamName;
                    goals4.Text = Convert.ToString(GF / 3);
                    lastMatch4.Text = LastMatch;
                    nextMatch4.Text = NextMatch;
                    break;

                case 5:
                    player5.Text = playerName;
                    team5.Text = teamName;
                    goals5.Text = Convert.ToString(GF / 3);
                    lastMatch5.Text = LastMatch;
                    nextMatch5.Text = NextMatch;
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
