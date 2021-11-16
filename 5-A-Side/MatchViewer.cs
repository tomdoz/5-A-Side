using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _5_A_Side
{
    public partial class MatchViewer : Form
    {
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        public Match userMatch = new Match();
        public int userScore = 0;
        public int cpuScore = 0;

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams(); //when new MatchViewer form is opened, load the correct teams
            matchTimer.Enabled = true;
        }

        public void LoadTeams()
        {
            userMatch.GetCurrentFixture();
            userMatch.AssignTeams();
            userMatch.TeamAvgStats();
            userMatch.userScoreChance = userMatch.ChanceGenerator(userMatch.userAtHome, userMatch.userAverages, userMatch.cpuAverages);
            userMatch.cpuScoreChance = userMatch.ChanceGenerator(userMatch.userAtHome, userMatch.userAverages, userMatch.cpuAverages);
            if (userMatch.userAtHome == false)
            {
                //user team is always on the left side of the form, so we swap the away and home labels to reflect who is home and who is away
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
        }

        public void ScoreGoalCheck()
        {
            //generates a random number between one and a hundred, if this number less than equal to the corresponding teams chance of scoring then they score
            Random random = new Random();
            int rollUserProbabilities = random.Next(0, 100);
            int rollCPUProbabilities = random.Next(0, 100);
            if (rollUserProbabilities <= userMatch.userScoreChance)
            {
                UserScoreGoal();
            }
            if (rollCPUProbabilities <= userMatch.cpuScoreChance)
            {
                CPUScoreGoal();
            }
        }

        public void UserScoreGoal()
        {
            userScoreLabel.Text = Convert.ToString(Convert.ToInt32(userScoreLabel.Text) + 1);
            string userScoreMsg = "Your team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string userScoreMsgTitle = TimerLabel.Text + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(userScoreMsg, userScoreMsgTitle);
            matchTimer.Start();
        }

        public void CPUScoreGoal()
        {
            cpuScoreLabel.Text = Convert.ToString(Convert.ToInt32(cpuScoreLabel.Text) + 1);
            string cpuScoreMsg = "The opposition team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string cpuScoreMsgTitle = TimerLabel.Text + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(cpuScoreMsg, cpuScoreMsgTitle);
            matchTimer.Start();
        }

        public void LeagueTableUpdater()
        {
            //selecting leagueTableData for user so it can be updated
            int userPoints = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserPoints"));
            int userWins = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserWins"));
            int userLosses = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserLosses"));
            int userDraws = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserDraws"));
            int userGF = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserGF"));
            int userGA = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserGA"));
            int userNumMatches = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserMatches"));
            int cpuPoints, cpuWins, cpuLosses, cpuDraws, cpuGF, cpuGA, cpuNumMatches;
            Com.CommandText = "Update Teams SET GF = " + (userGF + userScore)) + "Where Id = " + LoginMenu.TeamID;
            Com.Connection = Con;
            Com.ExecuteNonQuery();
            //selecting leagueTableData for cpu so it can be updated
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            switch (cpuTeamID)
            {
                case 1002:  //if cpuTeam is Man United 
                    cpuPoints = Convert.ToInt32(reader["MUPoints"]);
                    cpuWins = Convert.ToInt32(reader["MUWins"]);
                    cpuLosses = Convert.ToInt32(reader["MULosses"]);
                    cpuDraws = Convert.ToInt32(reader["MUDraws"]);
                    cpuGF = Convert.ToInt32(reader["MUGF"]);
                    cpuGA = Convert.ToInt32(reader["MUGA"]);
                    cpuNumMatches = Convert.ToInt32(reader["MUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + "Where Id = " + 1002;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //user win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + (userWins + 1) + ", UserDraws = " + userDraws + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 3) + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET MUWins = " + cpuWins + ", MUDraws = " + cpuDraws + ", MULosses = " + (cpuLosses + 1) + ", MUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", MUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", MUPoints = " + cpuPoints + ", MUMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //cpu win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + (cpuWins + 1) + ", MUDraws = " + cpuDraws + ", MULosses = " + cpuLosses + ", MUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", MUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", MUPoints = " + (cpuPoints + 3) + ", MUMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //user loss
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + userDraws + ", UserLosses = " + (userLosses + 1) + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + userPoints + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();

                    }
                    else
                    {
                        //user draw
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + (userDraws + 1) + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 1) + ", UserMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu draw
                        Com.CommandText = "Update UserTable SET MUWins = " + cpuWins + ", MUDraws = " + (cpuDraws + 1) + ", MULosses = " + cpuLosses + ", MUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", MUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", MUPoints = " + (cpuPoints + 1) + ", MUMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1003:  //if cpuTeam is Chelsea
                    cpuPoints = Convert.ToInt32(reader["CHEPoints"]);
                    cpuWins = Convert.ToInt32(reader["CHEWins"]);
                    cpuLosses = Convert.ToInt32(reader["CHELosses"]);
                    cpuDraws = Convert.ToInt32(reader["CHEDraws"]);
                    cpuGF = Convert.ToInt32(reader["CHEGF"]);
                    cpuGA = Convert.ToInt32(reader["CHEGA"]);
                    cpuNumMatches = Convert.ToInt32(reader["CHEMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + "Where Id = " + 1003;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //user win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + (userWins + 1) + ", UserDraws = " + userDraws + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 3) + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET CHEWins = " + cpuWins + ", CHEDraws = " + cpuDraws + ", CHELosses = " + (cpuLosses + 1) + ", CHEGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", CHEGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", CHEPoints = " + cpuPoints + ", CHEMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //cpu win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + (cpuWins + 1) + ", CHEDraws = " + cpuDraws + ", CHELosses = " + cpuLosses + ", CHEGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", CHEGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", CHEPoints = " + (cpuPoints + 3) + ", CHEMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //user loss
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + userDraws + ", UserLosses = " + (userLosses + 1) + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + userPoints + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();

                    }
                    else
                    {
                        //user draw
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + (userDraws + 1) + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 1) + ", UserMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET CHEWins = " + cpuWins + ", CHEDraws = " + (cpuDraws + 1) + ", CHELosses = " + cpuLosses + ", CHEGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", CHEGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", CHEPoints = " + (cpuPoints + 1) + ", CHEMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1004:  //if cpuTeam is Southampton
                    cpuPoints = Convert.ToInt32(reader["SOUPoints"]);
                    cpuWins = Convert.ToInt32(reader["SOUwins"]);
                    cpuLosses = Convert.ToInt32(reader["SOULosses"]);
                    cpuDraws = Convert.ToInt32(reader["SOUDraws"]);
                    cpuGF = Convert.ToInt32(reader["SOUGF"]);
                    cpuGA = Convert.ToInt32(reader["SOUGA"]);
                    cpuNumMatches = Convert.ToInt32(reader["SOUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + "Where Id = " + 1004;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //user win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + (userWins + 1) + ", UserDraws = " + userDraws + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 3) + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET SOUWins = " + cpuWins + ", SOUDraws = " + cpuDraws + ", SOULosses = " + (cpuLosses + 1) + ", SOUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", SOUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", SOUPoints = " + cpuPoints + ", SOUMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //cpu win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + (cpuWins + 1) + ", SOUDraws = " + cpuDraws + ", SOULosses = " + cpuLosses + ", SOUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", SOUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", SOUPoints = " + (cpuPoints + 3) + ", SOUMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //user loss
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + userDraws + ", UserLosses = " + (userLosses + 1) + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + userPoints + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();

                    }
                    else
                    {
                        //user draw
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + (userDraws + 1) + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 1) + ", UserMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET SOUWins = " + cpuWins + ", SOUDraws = " + (cpuDraws + 1) + ", SOULosses = " + cpuLosses + ", SOUGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", SOUGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", SOUPoints = " + (cpuPoints + 1) + ", SOUMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1005:  //if cpuTeam is Wolves
                    cpuPoints = Convert.ToInt32(reader["WOLPoints"]);
                    cpuWins = Convert.ToInt32(reader["WOLwins"]);
                    cpuLosses = Convert.ToInt32(reader["WOLLosses"]);
                    cpuDraws = Convert.ToInt32(reader["WOLDraws"]);
                    cpuGF = Convert.ToInt32(reader["WOLGF"]);
                    cpuGA = Convert.ToInt32(reader["WOLGA"]);
                    cpuNumMatches = Convert.ToInt32(reader["WOLMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + "Where Id = " + 1005;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //user win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + (userWins + 1) + ", UserDraws = " + userDraws + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 3) + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET WOLWins = " + cpuWins + ", WOLDraws = " + cpuDraws + ", WOLLosses = " + (cpuLosses + 1) + ", WOLGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", WOLGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", WOLPoints = " + cpuPoints + ", WOLMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //cpu win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + (cpuWins + 1) + ", WOLDraws = " + cpuDraws + ", WOLLosses = " + cpuLosses + ", WOLGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", WOLGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", WOLPoints = " + (cpuPoints + 3) + ", WOLMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //user loss
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + userDraws + ", UserLosses = " + (userLosses + 1) + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + userPoints + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();

                    }
                    else
                    {
                        //user draw
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + (userDraws + 1) + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 1) + ", UserMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET WOLWins = " + cpuWins + ", WOLDraws = " + (cpuDraws + 1) + ", WOLLosses = " + cpuLosses + ", WOLGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", WOLGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", WOLPoints = " + (cpuPoints + 1) + ", WOLMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1006:  //if cpuTeam is Norwich
                    cpuPoints = Convert.ToInt32(reader["NORPoints"]);
                    cpuWins = Convert.ToInt32(reader["NORwins"]);
                    cpuLosses = Convert.ToInt32(reader["NORLosses"]);
                    cpuDraws = Convert.ToInt32(reader["NORDraws"]);
                    cpuGF = Convert.ToInt32(reader["NORGF"]);
                    cpuGA = Convert.ToInt32(reader["NORGA"]);
                    cpuNumMatches = Convert.ToInt32(reader["NORMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + "Where Id = " + 1006;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //user win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + (userWins + 1) + ", UserDraws = " + userDraws + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 3) + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET NORWins = " + cpuWins + ", NORDraws = " + cpuDraws + ", NORLosses = " + (cpuLosses + 1) + ", NORGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", NORGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", NORPoints = " + cpuPoints + ", NORMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
                    {
                        //cpu win
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + (cpuWins + 1) + ", NORDraws = " + cpuDraws + ", NORLosses = " + cpuLosses + ", NORGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", NORGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", NORPoints = " + (cpuPoints + 3) + ", NORMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //user loss
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + userDraws + ", UserLosses = " + (userLosses + 1) + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + userPoints + ", UserMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();

                    }
                    else
                    {
                        //user draw
                        Con.Open();
                        Com.CommandText = "Update UserTable SET UserWins = " + userWins + ", UserDraws = " + (userDraws + 1) + ", UserLosses = " + userLosses + ", UserGF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", UserGA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", UserPoints = " + (userPoints + 1) + ", UserMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        //cpu loss
                        Com.CommandText = "Update UserTable SET NORWins = " + cpuWins + ", NORDraws = " + (cpuDraws + 1) + ", NORLosses = " + cpuLosses + ", NORGF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", NORGA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", NORPoints = " + (cpuPoints + 1) + ", NORMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;
            }
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
            if (matchEnded == false)
            {
                TimerLabel.Text = Convert.ToString(gameClockIncrementer + 5) + "'";
                gameClockIncrementer += 5;
                ScoreGoalCheck();
                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    userScore = Convert.ToInt32(userScoreLabel.Text);
                    cpuScore = Convert.ToInt32(cpuScoreLabel.Text);
                    string matchEndMsg = "The Match has ended, the game finished " + userScore + " - " + cpuScore;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                    LeagueTableUpdater();
                    userMatch.UpdateCurrFixture();
                    RestOfLeagueResults rest = new RestOfLeagueResults();
                    rest.Show();
                    this.Close();
                }
            }
        }
    }
}
