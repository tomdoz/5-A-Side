using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;


namespace _5_A_Side
{
    public partial class TopScorers : Form
    {
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
            DisplayScorerTable(1, player1, team1, goals1, lastMatch1);
            DisplayScorerTable(2, player2, team2, goals2, lastMatch2);
            DisplayScorerTable(3, player3, team3, goals3, lastMatch3);
            DisplayScorerTable(4, player4, team4, goals4, lastMatch4);
            DisplayScorerTable(5, player5, team5, goals5, lastMatch5);

        }

        public void DisplayScorerTable(int Rank, Label player, Label team, Label goals, Label lastMatch)
        {
            RankingTeams(Rank);
            RankingPlayersByShooting();
            getLastMatch();
            FillRow(player, team, goals, lastMatch);

        }

        public void RankingTeams(int Rank) //Ranking teams by who scores the most goals
        {
            TeamID = Convert.ToInt32(Sql.Select("Select * From Teams Order By GF Desc", (Rank - 1), "Id"));
            TeamIDForFixtures = TeamID;
            if (TeamID == LoginMenu.TeamID)
            {
                TeamIDForFixtures = 1;
            }
            string code = GetTeamCode(TeamIDForFixtures);
            GF = Convert.ToInt32(Sql.Select("SELECT * FROM UserTable Where Id = " + LoginMenu.UserID, 0, code + "GF"));
            teamName = Sql.Select("SELECT * FROM Teams WHERE Id = " + TeamID, 0, "TeamName");
        }

        public string GetTeamCode(int TeamIDForFixtures)
        {
            string code = "";
            switch (TeamIDForFixtures)
            {
                case 1:
                    code = "User";
                    break;

                case 1002:
                    code = "MU";
                    break;

                case 1003:
                    code = "CHE";
                    break;

                case 1004:
                    code = "SOU";
                    break;

                case 1005:
                    code = "WOL";
                    break;

                case 1006:
                    code = "NOR";
                    break;
            }
            return code;
        }

        public void RankingPlayersByShooting()
        {
            playerName = Sql.Select("SELECT * FROM Players WHERE TeamID = " + TeamID.ToString() + " ORDER BY Shooting Desc", 0, "Name");
        }

        public void getLastMatch()
        {
            int CurrFixtureID = Convert.ToInt32(Sql.Select("SELECT CurrFixtureID FROM UserTable WHERE Id = " + LoginMenu.UserID, 0, "CurrFixtureID"));
            for (int i = 0; i < CurrFixtureID; i++)
            {
                CurrFixtureID--;
                if (Convert.ToInt32(Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "HomeTeamID")) == TeamIDForFixtures)
                {
                    if (Convert.ToInt32(Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "AwayTeamID")) == 1)
                    {
                        string awayTeam = Sql.Select("SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID, 0, "TeamName");
                        LastMatch = teamName + " v " + awayTeam;
                        break;
                    }
                    else
                    {
                        int AwayID = Convert.ToInt32(Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "AwayTeamID"));
                        string awayTeam = Sql.Select("SELECT TeamName FROM Teams WHERE Id = " + AwayID, 0, "TeamName");
                        LastMatch = teamName + " v " + awayTeam;
                        break;
                    }
                }

                if (Convert.ToInt32(Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "AwayTeamID")) == TeamIDForFixtures)
                {
                    if (Convert.ToInt32((Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "HomeTeamID"))) == 1)
                    {
                        string homeTeam = Sql.Select("SELECT TeamName FROM Teams WHERE Id = " + LoginMenu.TeamID, 0, "TeamName");
                        LastMatch = homeTeam + " v " + teamName;
                        break;
                    }
                    else
                    {
                        int HomeID = Convert.ToInt32(Sql.Select("SELECT * FROM Fixtures WHERE Id = " + CurrFixtureID, 0, "HomeTeamID"));
                        string homeTeam = Sql.Select("SELECT TeamName FROM Teams WHERE Id = " + HomeID, 0, "TeamName");
                        LastMatch = homeTeam + " v " + teamName;
                        break;
                    }
                }
            }
        }

        public void FillRow(Label player, Label team, Label goals, Label lastMatch)
        {
            player.Text = playerName;
            team.Text = teamName;
            goals.Text = Convert.ToString(GF);
            lastMatch.Text = LastMatch;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    } 
}
