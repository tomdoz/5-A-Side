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
        //setting the connection string for connecting to the database
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

        //variables for league table data;
        public int cpuPoints;
        public int cpuWins;
        public int cpuLosses;
        public int cpuDraws;
        public int cpuGF;
        public int cpuGA;
        public int cpuNumMatches;

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
            LoadTeams(); //when new MatchViewer form is opened, load the correct teams
            matchTimer.Enabled = true;
        }

        public void GetCurrentFixture()
        {
            Con.Open(); //open connection to DB
            Com.CommandText = "Select CurrFixtureID from UserTable Where Id = " + LoginMenu.UserID; //selects the which fixture is next to be played for this user's account
            Com.Connection = Con; 
            SqlDataReader reader = Com.ExecuteReader(); //execute command
            reader.Read(); //read the next record that meets the conditions of the select statement
            fixtureID = Convert.ToInt32(reader["CurrFixtureID"]); 
            reader.Close();
            Con.Close(); //closing connection
        }

        public void AssignTeams()
        {
            Con.Open();
            //selecting Fixture from Fixtures table
            Com.CommandText = "Select * from Fixtures where Id = " + fixtureID; //using fixtureID pulled from userTable to find out which teams are playing
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            if (Convert.ToInt32(reader["HomeTeamID"]) == 1) //if the ID for the home team is 1 (which is the ID used in the fixture table for the user's team), user is at home
            {
                userAtHome = true; //user team is at home
                cpuTeamID = Convert.ToInt32(reader["AwayTeamID"]); //if user is at home, the cpuTeam must be away, so we can assing that teams ID
            }
            else
            {
                userAtHome = false; //we know the user team is awat
                cpuTeamID = Convert.ToInt32(reader["HomeTeamID"]); //therefore home team is cpu team
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
            if(userAtHome == false)
            {
                //user team is always on the left side of the form, so we swap the away and home labels to reflect who is home and who is away
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
            TeamAvgStats(); //averaging the the stats of both teams so we have one value for each team for each of the 7 attributes
            //setting the chances of each team scoring
            userScoreChance = UserChanceGenerator(); 
            cpuScoreChance = CPUChanceGenerator();
        }

        public void TeamAvgStats()
        {
            //using a simple mean calculation
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
                userScoreChance = 1; //condition so we don't allow a chance of scoring to be lower than 1, as this would interfere with calcs
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
                cpuScoreChance = 1; //condition so we don't allow a chance of scoring to be lower than 1, as this would interfere with calcs
            }
            return cpuScoreChance;
        }

        public void ScoreGoalCheck()
        {
            //generates a random number between one and a hundred, if this number less than equal to the corresponding teams chance of scoring then they score
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
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int userPoints = Convert.ToInt32(reader["UserPoints"]);
            int userWins = Convert.ToInt32(reader["UserWins"]);
            int userLosses = Convert.ToInt32(reader["UserLosses"]);
            int userDraws = Convert.ToInt32(reader["UserDraws"]);
            int userGF = Convert.ToInt32(reader["UserGF"]);
            int userGA = Convert.ToInt32(reader["UserGA"]);
            int userNumMatches = Convert.ToInt32(reader["UserMatches"]);
            reader.Close();
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
                        //cpu loss
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
