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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();


        //variables for individual player attributes (user team);

        //captain attribute variables
        public int p1ShootingVal;
        public int p1DribblingVal;
        public int p1PaceVal;
        public int p1PhysicalVal;
        public int p1ReliableVal;
        public int p1TackleVal;
        public int p1AggroVal;
        //player 2 attribute variables
        public int p2ShootingVal;
        public int p2DribblingVal;
        public int p2PaceVal;
        public int p2PhysicalVal;
        public int p2ReliableVal;
        public int p2TackleVal;
        public int p2AggroVal;
        //player 3 attribute variables;
        public int p3ShootingVal;
        public int p3DribblingVal;
        public int p3PaceVal;
        public int p3PhysicalVal;
        public int p3ReliableVal;
        public int p3TackleVal;
        public int p3AggroVal;
        //player 4 attribute variables;
        public int p4ShootingVal;
        public int p4DribblingVal;
        public int p4PaceVal;
        public int p4PhysicalVal;
        public int p4ReliableVal;
        public int p4TackleVal;
        public int p4AggroVal;
        //player 5 attribute variables;
        public int p5ShootingVal;
        public int p5DribblingVal;
        public int p5PaceVal;
        public int p5PhysicalVal;
        public int p5ReliableVal;
        public int p5TackleVal;
        public int p5AggroVal;
        //substitute attribute variables
        public int subShootingVal;
        public int subDribblingVal;
        public int subPaceVal;
        public int subPhysicalVal;
        public int subReliableVal;
        public int subTackleVal;
        public int subAggroVal;

        //variables for individual player attributes (cpu team);

        //captain attribute variables
        public int cpuP1ShootingVal;
        public int cpuP1DribblingVal;
        public int cpuP1PaceVal;
        public int cpuP1PhysicalVal;
        public int cpuP1ReliableVal;
        public int cpuP1TackleVal;
        public int cpuP1AggroVal;
        //player 2 attribute variables
        public int cpuP2ShootingVal;
        public int cpuP2DribblingVal;
        public int cpuP2PaceVal;
        public int cpuP2PhysicalVal;
        public int cpuP2ReliableVal;
        public int cpuP2TackleVal;
        public int cpuP2AggroVal;
        //player 3 attribute variables;
        public int cpuP3ShootingVal;
        public int cpuP3DribblingVal;
        public int cpuP3PaceVal;
        public int cpuP3PhysicalVal;
        public int cpuP3ReliableVal;
        public int cpuP3TackleVal;
        public int cpuP3AggroVal;
        //player 4 attribute variables;
        public int cpuP4ShootingVal;
        public int cpuP4DribblingVal;
        public int cpuP4PaceVal;
        public int cpuP4PhysicalVal;
        public int cpuP4ReliableVal;
        public int cpuP4TackleVal;
        public int cpuP4AggroVal;
        //player 5 attRibute variables;
        public int cpuP5ShootingVal;
        public int cpuP5DribblingVal;
        public int cpuP5PaceVal;
        public int cpuP5PhysicalVal;
        public int cpuP5ReliableVal;
        public int cpuP5TackleVal;
        public int cpuP5AggroVal;
        //substitute attribute variables
        public int cpuSubShootingVal;
        public int cpuSubDribblingVal;
        public int cpuSubPaceVal;
        public int cpuSubPhysicalVal;
        public int cpuSubReliableVal;
        public int cpuSubTackleVal;
        public int cpuSubAggroVal;

        //variables for averages of each attribute for each stat for user and cpu teams
        public int userSHO;
        public int userDRI;
        public int userPAC;
        public int userPHY;
        public int userREL;
        public int userTAC;
        public int userAGG;
        public int cpuSHO;
        public int cpuDRI;
        public int cpuPAC;
        public int cpuPHY;
        public int cpuREL;
        public int cpuTAC;
        public int cpuAGG;

        //variables for game running
        public int fixtureID;
        public int cpuTeamID;
        public int userScoreChance;
        public int cpuScoreChance;
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        public bool userAtHome;

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams();
            matchTimer.Enabled = true;
        }

        public void GetCurrentFixture()
        {
            Con.Open();
            Com.CommandText = "Select CurrFixtureID from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            fixtureID = Convert.ToInt32(reader["CurrFixtureID"]);
            reader.Close();
            Con.Close();
        }

        public void AssignTeams()
        {
            Con.Open();
            //selecting Fixture from Fixtures table
            Com.CommandText = "Select * from Fixtures where Id = " + fixtureID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            if (Convert.ToInt32(reader["HomeTeamID"]) == 1)
            {
                userAtHome = true;
                cpuTeamID = Convert.ToInt32(reader["AwayTeamID"]);
            }
            else
            {
                userAtHome = false;
                cpuTeamID = Convert.ToInt32(reader["HomeTeamID"]);
            }
            reader.Close();
            //selecting and assigning the user team's player attributes
            Com.CommandText = "Select * from Players Where TeamId = " + LoginMenu.TeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    p1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    p1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    p1PaceVal = Convert.ToInt32(reader["Pace"]);
                    p1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    p1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    p1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    p1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    p2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    p2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    p2PaceVal = Convert.ToInt32(reader["Pace"]);
                    p2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    p2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    p2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    p2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    p3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    p3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    p3PaceVal = Convert.ToInt32(reader["Pace"]);
                    p3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    p3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    p3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    p3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    p4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    p4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    p4PaceVal = Convert.ToInt32(reader["Pace"]);
                    p4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    p4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    p4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    p4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    p5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    p5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    p5PaceVal = Convert.ToInt32(reader["Pace"]);
                    p5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    p5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    p5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    p5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    subShootingVal = Convert.ToInt32(reader["Shooting"]);
                    subDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    subPaceVal = Convert.ToInt32(reader["Pace"]);
                    subPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    subReliableVal = Convert.ToInt32(reader["Reliability"]);
                    subTackleVal = Convert.ToInt32(reader["Tackling"]);
                    subAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting user team's name
            Com.CommandText = "Select TeamName from Teams where Id = " + LoginMenu.TeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            userName.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            //selecting and assinging the cpu team's player attributes
            Com.CommandText = "Select * from Players Where TeamID = " + cpuTeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    cpuP1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuP1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuP1PaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuP1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuP1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuP1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuP1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    cpuP2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuP2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuP2PaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuP2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuP2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuP2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuP2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    cpuP3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuP3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuP3PaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuP3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuP3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuP3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuP3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    cpuP4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuP4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuP4PaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuP4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuP4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuP4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuP4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    cpuP5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuP5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuP5PaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuP5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuP5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuP5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuP5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    cpuSubShootingVal = Convert.ToInt32(reader["Shooting"]);
                    cpuSubDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    cpuSubPaceVal = Convert.ToInt32(reader["Pace"]);
                    cpuSubPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    cpuSubReliableVal = Convert.ToInt32(reader["Reliability"]);
                    cpuSubTackleVal = Convert.ToInt32(reader["Tackling"]);
                    cpuSubAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting cpu team's name
            Com.CommandText = "select TeamName from Teams where Id = " + cpuTeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            cpuTeamLabel.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            Con.Close();
        }

        public void LoadTeams()
        {
            GetCurrentFixture();
            AssignTeams();
            //need to add the proper iteration through the teams from CPU
            if(userAtHome == false)
            {
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
            TeamAvgStats();
            userScoreChance = UserChanceGenerator();
            cpuScoreChance = CPUChanceGenerator();
        }

        public void TeamAvgStats()
        {
            userSHO = (p1ShootingVal + p2ShootingVal + p3ShootingVal + p4ShootingVal + p5ShootingVal) / 5;
            userDRI = (p1DribblingVal + p2DribblingVal + p3DribblingVal + p4DribblingVal + p5DribblingVal) / 5;
            userPAC = (p1PaceVal + p2PaceVal + p3PaceVal + p4PaceVal + p5PaceVal) / 5;
            userPHY = (p1PhysicalVal + p2PhysicalVal + p3PhysicalVal + p4PhysicalVal + p5PhysicalVal) / 5;
            userREL = (p1ReliableVal + p2ReliableVal + p3ReliableVal + p4ReliableVal + p5ReliableVal) / 5;
            userTAC = (p1TackleVal + p2TackleVal + p3TackleVal + p4TackleVal + p5TackleVal) / 5;
            userAGG = (p1AggroVal + p2AggroVal + p3AggroVal + p4AggroVal + p5AggroVal) / 5;
            cpuSHO = (cpuP1ShootingVal + cpuP2ShootingVal + cpuP3ShootingVal + cpuP4ShootingVal + cpuP5ShootingVal) / 5;
            cpuDRI = (cpuP1DribblingVal + cpuP2DribblingVal + cpuP3DribblingVal + cpuP4DribblingVal + cpuP5DribblingVal) / 5;
            cpuPAC = (cpuP1PaceVal + cpuP2PaceVal + cpuP3PaceVal + cpuP4PaceVal + cpuP5PaceVal) / 5;
            cpuPHY = (cpuP1PhysicalVal + cpuP2PhysicalVal + cpuP3PhysicalVal + cpuP4PhysicalVal + cpuP5PhysicalVal) / 5;
            cpuREL = (cpuP1ReliableVal + cpuP2ReliableVal + cpuP3ReliableVal + cpuP4ReliableVal + cpuP5ReliableVal) / 5;
            cpuTAC = (cpuP1TackleVal + cpuP2TackleVal + cpuP3TackleVal + cpuP4TackleVal + cpuP5TackleVal) / 5;
            cpuAGG = (cpuP1AggroVal + cpuP2AggroVal + cpuP3AggroVal + cpuP4AggroVal + cpuP5AggroVal) / 5;
        }

        public int UserChanceGenerator()
        {
            userScoreChance = Convert.ToInt32(((0.6 * userSHO) + (0.5 * userPAC) + (0.3 * userDRI) + (0.1 * userPHY)) / 4); //loading the user attacking attribute stats into weighted average equation
            userScoreChance = userScoreChance - Convert.ToInt32(((0.5 * cpuTAC) + (0.4 * cpuPHY) + (0.2 * cpuAGG) + (0.2 * cpuREL)) / 4); //weighted average then found using CPU defensive attribute stats
            if (userAtHome == true)
            {
                userScoreChance = Convert.ToInt32(Convert.ToDouble(userScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            }
            
            else
            {
                userScoreChance = Convert.ToInt32(Convert.ToDouble(userScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            }
            if (userScoreChance < 1)
            {
                userScoreChance = 1;
            }
            return userScoreChance;
        }

        public int CPUChanceGenerator()
        {
            cpuScoreChance = Convert.ToInt32(((0.6 * cpuSHO) + (0.5 * cpuPAC) + (0.3 * cpuDRI) + (0.1 * cpuPHY)) / 4); //loading the CPU attacking attribute stats into weighted average equation
            cpuScoreChance = cpuScoreChance - Convert.ToInt32(((0.5 * userTAC) + (0.4 * userPHY) + (0.2 * userAGG) + (0.2 * userREL)) / 4); //weighted average then found using user defensive attribute stats
            if (userAtHome == false)
            {
                cpuScoreChance = Convert.ToInt32(Convert.ToDouble(cpuScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            }
            else
            {
                cpuScoreChance = Convert.ToInt32(Convert.ToDouble(cpuScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            }
            if (cpuScoreChance < 1)
            {
                cpuScoreChance = 1;
            }
            return cpuScoreChance;
        }

        public void ScoreGoalCheck()
        {
            Random random = new Random();
            int rollUserProbabilities = random.Next(0, 100);
            int rollCPUProbabilities = random.Next(0, 100);
            if (rollUserProbabilities <= userScoreChance)
            {
                UserScoreGoal();   
            }
            if (rollCPUProbabilities <= cpuScoreChance)
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

        public void UpdateCurrFixture()
        {
            Con.Open();
            Com.CommandText = "Update UserTable Set CurrFixtureID = " + (fixtureID + 1) + " Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            Com.ExecuteNonQuery();
            Con.Close();
        }

        public void LeagueTableUpdater()
        {
            //selecting leagueTableData for user so it can be updated
            Con.Open();
            Com.CommandText = "Select * from Teams Where Id = " + LoginMenu.TeamID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int userPoints = Convert.ToInt32(reader["Points"]);
            int userWins = Convert.ToInt32(reader["Wins"]);
            int userLosses = Convert.ToInt32(reader["Losses"]);
            int userDraws = Convert.ToInt32(reader["Draws"]);
            int userGF = Convert.ToInt32(reader["GF"]);
            int userGA = Convert.ToInt32(reader["GA"]);
            int userNumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            //selecting leagueTableData for cpu so it can be updated
            Com.CommandText = "Select * from Teams Where Id = " + cpuTeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            int cpuPoints = Convert.ToInt32(reader["Points"]);
            int cpuWins = Convert.ToInt32(reader["Wins"]);
            int cpuLosses = Convert.ToInt32(reader["Losses"]);
            int cpuDraws = Convert.ToInt32(reader["Draws"]);
            int cpuGF = Convert.ToInt32(reader["GF"]);
            int cpuGA = Convert.ToInt32(reader["GA"]);
            int cpuNumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            Con.Close();

            if (Convert.ToInt32(userScoreLabel.Text) > Convert.ToInt32(cpuScoreLabel.Text))
            {
                //user win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (userWins + 1) + ", Draws = " + userDraws + ", Losses = " + userLosses + ", GF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", GA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", Points = " + (userPoints + 3) + ", NumMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.TeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //cpu loss
                Com.CommandText = "Update Teams SET Wins = " + cpuWins + ", Draws = " + cpuDraws + ", Losses = " + (cpuLosses + 1) + ", GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", GA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", Points = " + cpuPoints + ", NumMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + cpuTeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
            else if (Convert.ToInt32(userScoreLabel.Text) < Convert.ToInt32(cpuScoreLabel.Text))
            {
                //cpu win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (cpuWins + 1) + ", Draws = " + cpuDraws + ", Losses = " + cpuLosses + ", GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", GA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", Points = " + (cpuPoints + 3) + ", NumMatches = " + (cpuNumMatches + 1) + " WHERE Id = " + cpuTeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //user loss
                Com.CommandText = "Update Teams SET Wins = " + userWins + ", Draws = " + userDraws + ", Losses = " + (userLosses + 1) + ", GF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", GA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", Points = " + userPoints + ", NumMatches = " + (userNumMatches + 1) + " WHERE Id = " + LoginMenu.TeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();

            }
            else
            {
                //user draw
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + userWins + ", Draws = " + (userDraws + 1) + ", Losses = " + userLosses + ", GF = " + (userGF + Convert.ToInt32(userScoreLabel.Text)) + ", GA = " + (userGA + Convert.ToInt32(cpuScoreLabel.Text)) + ", Points = " + (userPoints + 1) + ", NumMatches = " + (userNumMatches + 1) + "  WHERE Id = " + LoginMenu.TeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //cpu loss
                Com.CommandText = "Update Teams SET Wins = " + cpuWins + ", Draws = " + (cpuDraws + 1) + ", Losses = " + cpuLosses + ", GF = " + (cpuGF + Convert.ToInt32(cpuScoreLabel.Text)) + ", GA = " + (cpuGA + Convert.ToInt32(userScoreLabel.Text)) + ", Points = " + (cpuPoints + 1) + ", NumMatches = " + (cpuNumMatches + 1) + "  WHERE Id = " + cpuTeamID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
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
                    string matchEndMsg = "The Match has ended, the game finished " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                    LeagueTableUpdater();
                    UpdateCurrFixture();
                    RestOfLeagueResults rest = new RestOfLeagueResults();
                    rest.Show();
                    this.Close();
                }
            }
        }
    }
}
