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
    public partial class RestOfLeagueResults : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();

        //captain attribute variables
        public int home1P1ShootingVal;
        public int home1P1DribblingVal;
        public int home1P1PaceVal;
        public int home1P1PhysicalVal;
        public int home1P1ReliableVal;
        public int home1P1TackleVal;
        public int home1P1AggroVal;
        //player 2 attribute variables
        public int home1P2ShootingVal;
        public int home1P2DribblingVal;
        public int home1P2PaceVal;
        public int home1P2PhysicalVal;
        public int home1P2ReliableVal;
        public int home1P2TackleVal;
        public int home1P2AggroVal;
        //player 3 attribute variables;
        public int home1P3ShootingVal;
        public int home1P3DribblingVal;
        public int home1P3PaceVal;
        public int home1P3PhysicalVal;
        public int home1P3ReliableVal;
        public int home1P3TackleVal;
        public int home1P3AggroVal;
        //player 4 attribute variables;
        public int home1P4ShootingVal;
        public int home1P4DribblingVal;
        public int home1P4PaceVal;
        public int home1P4PhysicalVal;
        public int home1P4ReliableVal;
        public int home1P4TackleVal;
        public int home1P4AggroVal;
        //player 5 attRibute variables;
        public int home1P5ShootingVal;
        public int home1P5DribblingVal;
        public int home1P5PaceVal;
        public int home1P5PhysicalVal;
        public int home1P5ReliableVal;
        public int home1P5TackleVal;
        public int home1P5AggroVal;
        //substitute attribute variables
        public int home1SubShootingVal;
        public int home1SubDribblingVal;
        public int home1SubPaceVal;
        public int home1SubPhysicalVal;
        public int home1SubReliableVal;
        public int home1SubTackleVal;
        public int home1SubAggroVal;

        //captain attribute variables
        public int away1P1ShootingVal;
        public int away1P1DribblingVal;
        public int away1P1PaceVal;
        public int away1P1PhysicalVal;
        public int away1P1ReliableVal;
        public int away1P1TackleVal;
        public int away1P1AggroVal;
        //player 2 attribute variables
        public int away1P2ShootingVal;
        public int away1P2DribblingVal;
        public int away1P2PaceVal;
        public int away1P2PhysicalVal;
        public int away1P2ReliableVal;
        public int away1P2TackleVal;
        public int away1P2AggroVal;
        //player 3 attribute variables;
        public int away1P3ShootingVal;
        public int away1P3DribblingVal;
        public int away1P3PaceVal;
        public int away1P3PhysicalVal;
        public int away1P3ReliableVal;
        public int away1P3TackleVal;
        public int away1P3AggroVal;
        //player 4 attribute variables;
        public int away1P4ShootingVal;
        public int away1P4DribblingVal;
        public int away1P4PaceVal;
        public int away1P4PhysicalVal;
        public int away1P4ReliableVal;
        public int away1P4TackleVal;
        public int away1P4AggroVal;
        //player 5 attRibute variables;
        public int away1P5ShootingVal;
        public int away1P5DribblingVal;
        public int away1P5PaceVal;
        public int away1P5PhysicalVal;
        public int away1P5ReliableVal;
        public int away1P5TackleVal;
        public int away1P5AggroVal;
        //substitute attribute variables
        public int away1SubShootingVal;
        public int away1SubDribblingVal;
        public int away1SubPaceVal;
        public int away1SubPhysicalVal;
        public int away1SubReliableVal;
        public int away1SubTackleVal;
        public int away1SubAggroVal;

        //captain attribute variables
        public int home2P1ShootingVal;
        public int home2P1DribblingVal;
        public int home2P1PaceVal;
        public int home2P1PhysicalVal;
        public int home2P1ReliableVal;
        public int home2P1TackleVal;
        public int home2P1AggroVal;
        //player 2 attribute variables
        public int home2P2ShootingVal;
        public int home2P2DribblingVal;
        public int home2P2PaceVal;
        public int home2P2PhysicalVal;
        public int home2P2ReliableVal;
        public int home2P2TackleVal;
        public int home2P2AggroVal;
        //player 3 attribute variables;
        public int home2P3ShootingVal;
        public int home2P3DribblingVal;
        public int home2P3PaceVal;
        public int home2P3PhysicalVal;
        public int home2P3ReliableVal;
        public int home2P3TackleVal;
        public int home2P3AggroVal;
        //player 4 attribute variables;
        public int home2P4ShootingVal;
        public int home2P4DribblingVal;
        public int home2P4PaceVal;
        public int home2P4PhysicalVal;
        public int home2P4ReliableVal;
        public int home2P4TackleVal;
        public int home2P4AggroVal;
        //player 5 attRibute variables;
        public int home2P5ShootingVal;
        public int home2P5DribblingVal;
        public int home2P5PaceVal;
        public int home2P5PhysicalVal;
        public int home2P5ReliableVal;
        public int home2P5TackleVal;
        public int home2P5AggroVal;
        //substitute attribute variables
        public int home2SubShootingVal;
        public int home2SubDribblingVal;
        public int home2SubPaceVal;
        public int home2SubPhysicalVal;
        public int home2SubReliableVal;
        public int home2SubTackleVal;
        public int home2SubAggroVal;

        //captain attribute variables
        public int away2P1ShootingVal;
        public int away2P1DribblingVal;
        public int away2P1PaceVal;
        public int away2P1PhysicalVal;
        public int away2P1ReliableVal;
        public int away2P1TackleVal;
        public int away2P1AggroVal;
        //player 2 attribute variables
        public int away2P2ShootingVal;
        public int away2P2DribblingVal;
        public int away2P2PaceVal;
        public int away2P2PhysicalVal;
        public int away2P2ReliableVal;
        public int away2P2TackleVal;
        public int away2P2AggroVal;
        //player 3 attribute variables;
        public int away2P3ShootingVal;
        public int away2P3DribblingVal;
        public int away2P3PaceVal;
        public int away2P3PhysicalVal;
        public int away2P3ReliableVal;
        public int away2P3TackleVal;
        public int away2P3AggroVal;
        //player 4 attribute variables;
        public int away2P4ShootingVal;
        public int away2P4DribblingVal;
        public int away2P4PaceVal;
        public int away2P4PhysicalVal;
        public int away2P4ReliableVal;
        public int away2P4TackleVal;
        public int away2P4AggroVal;
        //player 5 attRibute variables;
        public int away2P5ShootingVal;
        public int away2P5DribblingVal;
        public int away2P5PaceVal;
        public int away2P5PhysicalVal;
        public int away2P5ReliableVal;
        public int away2P5TackleVal;
        public int away2P5AggroVal;
        //substitute attribute variables
        public int away2SubShootingVal;
        public int away2SubDribblingVal;
        public int away2SubPaceVal;
        public int away2SubPhysicalVal;
        public int away2SubReliableVal;
        public int away2SubTackleVal;
        public int away2SubAggroVal;

        //variables for averages of each attribute for each stat for teams
        public int home1SHO;
        public int home1DRI;
        public int home1PAC;
        public int home1PHY;
        public int home1REL;
        public int home1TAC;
        public int home1AGG;
        public int away1SHO;
        public int away1DRI;
        public int away1PAC;
        public int away1PHY;
        public int away1REL;
        public int away1TAC;
        public int away1AGG;
        public int home2SHO;
        public int home2DRI;
        public int home2PAC;
        public int home2PHY;
        public int home2REL;
        public int home2TAC;
        public int home2AGG;
        public int away2SHO;
        public int away2DRI;
        public int away2PAC;
        public int away2PHY;
        public int away2REL;
        public int away2TAC;
        public int away2AGG;

        //essential variables
        public int home1ID;
        public int away1ID;
        public int home2ID;
        public int away2ID;
        public int fixtureID;
        public int home1ScoreChance;
        public int away1ScoreChance;
        public int home2ScoreChance;
        public int away2ScoreChance;
        public int rollHome1Probabilities;
        public int rollAway1Probabilities;
        public int rollHome2Probabilities;
        public int rollAway2Probabilities;
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        Random rand = new Random();

        public RestOfLeagueResults()
        {
            InitializeComponent();
            LoadTeams();
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

        public void LoadTeams()
        {
            GetCurrentFixture();
            AssignTeams();
            TeamAvgStats();
            home1ScoreChance = home1ChanceGenerator();
            away1ScoreChance = away1ChanceGenerator();
            home2ScoreChance = home2ChanceGenerator();
            away2ScoreChance = away2ChanceGenerator();
        }

        static int GenerateRandom(Random rand)
        {
            int randomProb = rand.Next(0,100);
            return randomProb;
        }

        public void ScoreGoalCheck()
        {
            rollHome1Probabilities = GenerateRandom(rand);
            rollAway1Probabilities = GenerateRandom(rand);
            rollHome2Probabilities = GenerateRandom(rand);
            rollAway2Probabilities = GenerateRandom(rand);
            Home1ScoreGoal();
            Away1ScoreGoal();
            Home2ScoreGoal();
            Away2ScoreGoal();
            UpdateCurrFixture();
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
            //create this 
            //selecting leagueTableData for user so it can be updated
            Con.Open();
            Com.CommandText = "Select * from Teams Where Id = " + home1ID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int home1Points = Convert.ToInt32(reader["Points"]);
            int home1Wins = Convert.ToInt32(reader["Wins"]);
            int home1Losses = Convert.ToInt32(reader["Losses"]);
            int home1Draws = Convert.ToInt32(reader["Draws"]);
            int home1GF = Convert.ToInt32(reader["GF"]);
            int home1GA = Convert.ToInt32(reader["GA"]);
            int home1NumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            //selecting leagueTableData for cpu so it can be updated
            Com.CommandText = "Select * from Teams Where Id = " + away1ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            int away1Points = Convert.ToInt32(reader["Points"]);
            int away1Wins = Convert.ToInt32(reader["Wins"]);
            int away1Losses = Convert.ToInt32(reader["Losses"]);
            int away1Draws = Convert.ToInt32(reader["Draws"]);
            int away1GF = Convert.ToInt32(reader["GF"]);
            int away1GA = Convert.ToInt32(reader["GA"]);
            int away1NumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            Con.Close();

            if (Convert.ToInt32(homeTeam1Score.Text) > Convert.ToInt32(awayTeam1Score.Text))
            {
                //home1 win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (home1Wins + 1) + ", Draws = " + home1Draws + ", Losses = " + home1Losses + ", GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", GA = " + (home1GA + Convert.ToInt32(awayTeam1Score.Text)) + ", Points = " + (home1Points + 3) + ", NumMatches = " + (home1NumMatches + 1) + " WHERE Id = " + home1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //away1 loss
                Com.CommandText = "Update Teams SET Wins = " + away1Wins + ", Draws = " + away1Draws + ", Losses = " + (away1Losses + 1) + ", GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + ", GA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", Points = " + away1Points + ", NumMatches = " + (away1NumMatches + 1) + " WHERE Id = " + away1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
            else if (Convert.ToInt32(homeTeam1Score.Text) < Convert.ToInt32(awayTeam1Score.Text))
            {
                //away1 win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (away1Wins + 1) + ", Draws = " + away1Draws + ", Losses = " + away1Losses + ", GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + ", GA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", Points = " + (away1Points + 3) + ", NumMatches = " + (away1NumMatches + 1) + " WHERE Id = " + away1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //home1 loss
                Com.CommandText = "Update Teams SET Wins = " + home1Wins + ", Draws = " + home1Draws + ", Losses = " + (home1Losses + 1) + ", GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", GA = " + (home1GA + Convert.ToInt32(awayTeam1Score.Text)) + ", Points = " + home1Points + ", NumMatches = " + (home1NumMatches + 1) + " WHERE Id = " + home1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
            else
            {
                //home1 draw
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + home1Wins + ", Draws = " + (home1Draws + 1) + ", Losses = " + home1Losses + ", GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", GA = " + (home1GA + Convert.ToInt32(awayTeam1Score.Text)) + ", Points = " + (home1Points + 1) + ", NumMatches = " + (home1NumMatches + 1) + " WHERE Id = " + home1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //away1 draw
                Com.CommandText = "Update Teams SET Wins = " + away1Wins + ", Draws = " + (away1Draws + 1) + ", Losses = " + away1Losses + ", GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + ", GA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", Points = " + (away1Points + 1) + ", NumMatches = " + (away1NumMatches + 1) + " WHERE Id = " + away1ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }

            //selecting leagueTableData for home2 so it can be updated
            Con.Open();
            Com.CommandText = "Select * from Teams Where Id = " + home2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            int home2Points = Convert.ToInt32(reader["Points"]);
            int home2Wins = Convert.ToInt32(reader["Wins"]);
            int home2Losses = Convert.ToInt32(reader["Losses"]);
            int home2Draws = Convert.ToInt32(reader["Draws"]);
            int home2GF = Convert.ToInt32(reader["GF"]);
            int home2GA = Convert.ToInt32(reader["GA"]);
            int home2NumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            //selecting leagueTableData for away2 so it can be updated
            Com.CommandText = "Select * from Teams Where Id = " + away2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            int away2Points = Convert.ToInt32(reader["Points"]);
            int away2Wins = Convert.ToInt32(reader["Wins"]);
            int away2Losses = Convert.ToInt32(reader["Losses"]);
            int away2Draws = Convert.ToInt32(reader["Draws"]);
            int away2GF = Convert.ToInt32(reader["GF"]);
            int away2GA = Convert.ToInt32(reader["GA"]);
            int away2NumMatches = Convert.ToInt32(reader["NumMatches"]);
            reader.Close();
            Con.Close();

            if (Convert.ToInt32(homeTeam2Score.Text) > Convert.ToInt32(awayTeam2Score.Text))
            {
                //home2 win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (home2Wins + 1) + ", Draws = " + home2Draws + ", Losses = " + home2Losses + ", GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", GA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", Points = " + (home2Points + 3) + ", NumMatches = " + (home2NumMatches + 1) + " WHERE Id = " + home2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //away2 loss
                Com.CommandText = "Update Teams SET Wins = " + away2Wins + ", Draws = " + away2Draws + ", Losses = " + (away2Losses + 1) + ", GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", GA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", Points = " + away2Points +", NumMatches = " + (away2NumMatches + 1) + " WHERE Id = " + away2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
            else if (Convert.ToInt32(homeTeam2Score.Text) < Convert.ToInt32(awayTeam2Score.Text))
            {
                //away2 win
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + (away2Wins + 1) + ", Draws = " + away2Draws + ", Losses = " + away2Losses + ", GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", GA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", Points = " + (away2Points + 3) + ", NumMatches = " + (away1NumMatches + 1) + " WHERE Id = " + away2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //home2 loss
                Com.CommandText = "Update Teams SET Wins = " + home2Wins + ", Draws = " + home2Draws + ", Losses = " + (home2Losses + 1) + ", GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", GA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", Points = " + home2Points + ", NumMatches = " + (home2NumMatches + 1) + " WHERE Id = " + home2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
            else if (Convert.ToInt32(homeTeam2Score.Text) == Convert.ToInt32(awayTeam2Score.Text))
            {
                //home2 draw
                Con.Open();
                Com.CommandText = "Update Teams SET Wins = " + home2Wins + ", Draws = " + (home2Draws + 1) + ", Losses = " + home2Losses + ", GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", GA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", Points = " + (home2Points + 1) + ", NumMatches = " + (home2NumMatches + 1) + " WHERE Id = " + home2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                //away2 draw
                Com.CommandText = "Update Teams SET Wins = " + away2Wins + ", Draws = " + (away2Draws + 1) + ", Losses = " + away2Losses + ", GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", GA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", Points = " + (away2Points + 1) + ", NumMatches = " + (away2NumMatches + 1) + " WHERE Id = " + away2ID;
                Com.Connection = Con;
                Com.ExecuteNonQuery();
                Con.Close();
            }
        }

        public void Home1ScoreGoal()
        {
            if (rollHome1Probabilities <= home1ScoreChance)
            {
                homeTeam1Score.Text = Convert.ToString(Convert.ToInt32(homeTeam1Score.Text) + 1);
            }
        }

        public void Away1ScoreGoal()
        {
            if (rollAway1Probabilities <= away1ScoreChance)
            {
                awayTeam1Score.Text = Convert.ToString(Convert.ToInt32(awayTeam1Score.Text) + 1);
            }
        }

        public void Home2ScoreGoal() 
        {
            if (rollHome2Probabilities <= home2ScoreChance)
            {
                homeTeam2Score.Text = Convert.ToString(Convert.ToInt32(homeTeam2Score.Text) + 1);
            }
        }

        public void Away2ScoreGoal()
        {
            if (rollAway2Probabilities <= away2ScoreChance)
            {
                awayTeam2Score.Text = Convert.ToString(Convert.ToInt32(awayTeam2Score.Text) + 1);
            }
        }

        public int home1ChanceGenerator()
        {
            home1ScoreChance = Convert.ToInt32(((0.6 * home1SHO) + (0.5 * home1PAC) + (0.3 * home1DRI) + (0.1 * home1PHY)) / 4); //loading the home1 attacking attribute stats into weighted average equation
            home1ScoreChance = home1ScoreChance - Convert.ToInt32(((0.5 * away1TAC) + (0.4 * away1PHY) + (0.2 * away1AGG) + (0.2 * away1REL)) / 4); //weighted average then found using CPU defensive attribute stats
            //home1ScoreChance = Convert.ToInt32(Convert.ToDouble(home1ScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            if (home1ScoreChance < 1)
            {
                home1ScoreChance = 1;
            }
            return home1ScoreChance;
        }

        public int away1ChanceGenerator()
        {
            away1ScoreChance = Convert.ToInt32(((0.6 * away1SHO) + (0.5 * away1PAC) + (0.3 * away1DRI) + (0.1 * away1PHY)) / 4); //loading the away1 attacking attribute stats into weighted average equation
            away1ScoreChance = away1ScoreChance - Convert.ToInt32(((0.5 * home1TAC) + (0.4 * home1PHY) + (0.2 * home1AGG) + (0.2 * home1REL)) / 4); //weighted average then found using CPU defensive attribute stats                                                                                                                                        // away1ScoreChance = Convert.ToInt32(Convert.ToDouble(away1ScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            if (away1ScoreChance < 1)
            {
                away1ScoreChance = 1;
            }
            return away1ScoreChance;
        }

        public int home2ChanceGenerator()
        {
            home2ScoreChance = Convert.ToInt32(((0.6 * home2SHO) + (0.5 * home2PAC) + (0.3 * home2DRI) + (0.1 * home2PHY)) / 4); //loading the home2 attacking attribute stats into weighted average equation
            home2ScoreChance = home2ScoreChance - Convert.ToInt32(((0.5 * away2TAC) + (0.4 * away2PHY) + (0.2 * away2AGG) + (0.2 * away2REL)) / 4); //weighted average then found using CPU defensive attribute stats                                                                                                                                          // home2ScoreChance = Convert.ToInt32(Convert.ToDouble(home2ScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            if (home2ScoreChance < 1)
            {
                home2ScoreChance = 1;
            }
            return home2ScoreChance;
        }

        public int away2ChanceGenerator()
        {
            away2ScoreChance = Convert.ToInt32(((0.6 * away2SHO) + (0.5 * away2PAC) + (0.3 * away2DRI) + (0.1 * away2PHY)) / 4); //loading the away2 attacking attribute stats into weighted average equation
            away2ScoreChance = away2ScoreChance - Convert.ToInt32(((0.5 * home2TAC) + (0.4 * home2PHY) + (0.2 * home2AGG) + (0.2 * home2REL)) / 4); //weighted average then found using CPU defensive attribute stats
                                                                                                                                                    // away2ScoreChance = Convert.ToInt32(Convert.ToDouble(away2ScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            if (away2ScoreChance < 1)
            {
                away2ScoreChance = 1;
            }
            return away2ScoreChance;
        }

        public void TeamAvgStats()
        {
            home1SHO = (home1P1ShootingVal + home1P2ShootingVal + home1P3ShootingVal + home1P4ShootingVal + home1P5ShootingVal) / 5;
            home1DRI = (home1P1DribblingVal + home1P2DribblingVal + home1P3DribblingVal + home1P4DribblingVal + home1P5DribblingVal) / 5;
            home1PAC = (home1P1PaceVal + home1P2PaceVal + home1P3PaceVal + home1P4PaceVal + home1P5PaceVal) / 5;
            home1PHY = (home1P1PhysicalVal + home1P2PhysicalVal + home1P3PhysicalVal + home1P4PhysicalVal + home1P5PhysicalVal) / 5;
            home1REL = (home1P1ReliableVal + home1P2ReliableVal + home1P3ReliableVal + home1P4ReliableVal + home1P5ReliableVal) / 5;
            home1TAC = (home1P1TackleVal + home1P2TackleVal + home1P3TackleVal + home1P4TackleVal + home1P5TackleVal) / 5;
            home1AGG = (home1P1AggroVal + home1P2AggroVal + home1P3AggroVal + home1P4AggroVal + home1P5AggroVal) / 5;
            away1SHO = (away1P1ShootingVal + away1P2ShootingVal + away1P3ShootingVal + away1P4ShootingVal + away1P5ShootingVal) / 5;
            away1DRI = (away1P1DribblingVal + away1P2DribblingVal + away1P3DribblingVal + away1P4DribblingVal + away1P5DribblingVal) / 5;
            away1PAC = (away1P1PaceVal + away1P2PaceVal + away1P3PaceVal + away1P4PaceVal + away1P5PaceVal) / 5;
            away1PHY = (away1P1PhysicalVal + away1P2PhysicalVal + away1P3PhysicalVal + away1P4PhysicalVal + away1P5PhysicalVal) / 5;
            away1REL = (away1P1ReliableVal + away1P2ReliableVal + away1P3ReliableVal + away1P4ReliableVal + away1P5ReliableVal) / 5;
            away1TAC = (away1P1TackleVal + away1P2TackleVal + away1P3TackleVal + away1P4TackleVal + away1P5TackleVal) / 5;
            away1AGG = (away1P1AggroVal + away1P2AggroVal + away1P3AggroVal + away1P4AggroVal + away1P5AggroVal) / 5;
            home2SHO = (home2P1ShootingVal + home2P2ShootingVal + home2P3ShootingVal + home2P4ShootingVal + home2P5ShootingVal) / 5;
            home2DRI = (home2P1DribblingVal + home2P2DribblingVal + home2P3DribblingVal + home2P4DribblingVal + home2P5DribblingVal) / 5;
            home2PAC = (home2P1PaceVal + home2P2PaceVal + home2P3PaceVal + home2P4PaceVal + home2P5PaceVal) / 5;
            home2PHY = (home2P1PhysicalVal + home2P2PhysicalVal + home2P3PhysicalVal + home2P4PhysicalVal + home2P5PhysicalVal) / 5;
            home2REL = (home2P1ReliableVal + home2P2ReliableVal + home2P3ReliableVal + home2P4ReliableVal + home2P5ReliableVal) / 5;
            home2TAC = (home2P1TackleVal + home2P2TackleVal + home2P3TackleVal + home2P4TackleVal + home2P5TackleVal) / 5;
            home2AGG = (home2P1AggroVal + home2P2AggroVal + home2P3AggroVal + home2P4AggroVal + home2P5AggroVal) / 5;
            away2SHO = (away2P1ShootingVal + away2P2ShootingVal + away2P3ShootingVal + away2P4ShootingVal + away2P5ShootingVal) / 5;
            away2DRI = (away2P1DribblingVal + away2P2DribblingVal + away2P3DribblingVal + away2P4DribblingVal + away2P5DribblingVal) / 5;
            away2PAC = (away2P1PaceVal + away2P2PaceVal + away2P3PaceVal + away2P4PaceVal + away2P5PaceVal) / 5;
            away2PHY = (away2P1PhysicalVal + away2P2PhysicalVal + away2P3PhysicalVal + away2P4PhysicalVal + away2P5PhysicalVal) / 5;
            away2REL = (away2P1ReliableVal + away2P2ReliableVal + away2P3ReliableVal + away2P4ReliableVal + away2P5ReliableVal) / 5;
            away2TAC = (away2P1TackleVal + away2P2TackleVal + away2P3TackleVal + away2P4TackleVal + away2P5TackleVal) / 5;
            away2AGG = (away2P1AggroVal + away2P2AggroVal + away2P3AggroVal + away2P4AggroVal + away2P5AggroVal) / 5;
        }

        public void AssignTeams()
        {
            Con.Open();
            //selecting Fixture from Fixtures table
            Com.CommandText = "Select * from Fixtures where Id = " + fixtureID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            away1ID = Convert.ToInt32(reader["AwayTeamID"]);
            home1ID = Convert.ToInt32(reader["HomeTeamID"]);
            reader.Close();
            //selecting and assigning the home team from first fixture's player attributes
            Com.CommandText = "Select * from Players Where TeamId = " + home1ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    home1P1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1P1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1P1PaceVal = Convert.ToInt32(reader["Pace"]);
                    home1P1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1P1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1P1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1P1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    home1P2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1P2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1P2PaceVal = Convert.ToInt32(reader["Pace"]);
                    home1P2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1P2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1P2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1P2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    home1P3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1P3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1P3PaceVal = Convert.ToInt32(reader["Pace"]);
                    home1P3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1P3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1P3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1P3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    home1P4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1P4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1P4PaceVal = Convert.ToInt32(reader["Pace"]);
                    home1P4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1P4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1P4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1P4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    home1P5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1P5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1P5PaceVal = Convert.ToInt32(reader["Pace"]);
                    home1P5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1P5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1P5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1P5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    home1SubShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home1SubDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home1SubPaceVal = Convert.ToInt32(reader["Pace"]);
                    home1SubPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home1SubReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home1SubTackleVal = Convert.ToInt32(reader["Tackling"]);
                    home1SubAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting home 1 team's name
            Com.CommandText = "Select TeamName from Teams where Id = " + home1ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            homeTeam1.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            //selecting and assigning the away team from first fixture's player attributes
            Com.CommandText = "Select * from Players Where TeamId = " + away1ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    away1P1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1P1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1P1PaceVal = Convert.ToInt32(reader["Pace"]);
                    away1P1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1P1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1P1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1P1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    away1P2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1P2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1P2PaceVal = Convert.ToInt32(reader["Pace"]);
                    away1P2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1P2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1P2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1P2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    away1P3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1P3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1P3PaceVal = Convert.ToInt32(reader["Pace"]);
                    away1P3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1P3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1P3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1P3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    away1P4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1P4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1P4PaceVal = Convert.ToInt32(reader["Pace"]);
                    away1P4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1P4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1P4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1P4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    away1P5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1P5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1P5PaceVal = Convert.ToInt32(reader["Pace"]);
                    away1P5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1P5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1P5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1P5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    away1SubShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away1SubDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away1SubPaceVal = Convert.ToInt32(reader["Pace"]);
                    away1SubPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away1SubReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away1SubTackleVal = Convert.ToInt32(reader["Tackling"]);
                    away1SubAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting away 1 team's name
            Com.CommandText = "Select TeamName from Teams where Id = " + away1ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            awayTeam1.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            fixtureID++;
            //selecting 2nd Fixture from Fixtures table
            Com.CommandText = "Select * from Fixtures where Id = " + fixtureID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            away2ID = Convert.ToInt32(reader["AwayTeamID"]);
            home2ID = Convert.ToInt32(reader["HomeTeamID"]);
            reader.Close();
            //selecting and assigning the home team from first fixture's player attributes
            Com.CommandText = "Select * from Players Where TeamId = " + home2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    home2P1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2P1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2P1PaceVal = Convert.ToInt32(reader["Pace"]);
                    home2P1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2P1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2P1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2P1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    home2P2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2P2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2P2PaceVal = Convert.ToInt32(reader["Pace"]);
                    home2P2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2P2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2P2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2P2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    home2P3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2P3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2P3PaceVal = Convert.ToInt32(reader["Pace"]);
                    home2P3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2P3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2P3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2P3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    home2P4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2P4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2P4PaceVal = Convert.ToInt32(reader["Pace"]);
                    home2P4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2P4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2P4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2P4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    home2P5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2P5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2P5PaceVal = Convert.ToInt32(reader["Pace"]);
                    home2P5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2P5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2P5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2P5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    home2SubShootingVal = Convert.ToInt32(reader["Shooting"]);
                    home2SubDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    home2SubPaceVal = Convert.ToInt32(reader["Pace"]);
                    home2SubPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    home2SubReliableVal = Convert.ToInt32(reader["Reliability"]);
                    home2SubTackleVal = Convert.ToInt32(reader["Tackling"]);
                    home2SubAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting home 1 team's name
            Com.CommandText = "Select TeamName from Teams where Id = " + home2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            homeTeam2.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            //selecting and assigning the away team from first fixture's player attributes
            Com.CommandText = "Select * from Players Where TeamId = " + away2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    away2P1ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2P1DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2P1PaceVal = Convert.ToInt32(reader["Pace"]);
                    away2P1PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2P1ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2P1TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2P1AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    away2P2ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2P2DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2P2PaceVal = Convert.ToInt32(reader["Pace"]);
                    away2P2PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2P2ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2P2TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2P2AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    away2P3ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2P3DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2P3PaceVal = Convert.ToInt32(reader["Pace"]);
                    away2P3PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2P3ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2P3TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2P3AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    away2P4ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2P4DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2P4PaceVal = Convert.ToInt32(reader["Pace"]);
                    away2P4PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2P4ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2P4TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2P4AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    away2P5ShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2P5DribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2P5PaceVal = Convert.ToInt32(reader["Pace"]);
                    away2P5PhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2P5ReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2P5TackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2P5AggroVal = Convert.ToInt32(reader["Aggression"]);
                }

                if (Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    away2SubShootingVal = Convert.ToInt32(reader["Shooting"]);
                    away2SubDribblingVal = Convert.ToInt32(reader["Dribbling"]);
                    away2SubPaceVal = Convert.ToInt32(reader["Pace"]);
                    away2SubPhysicalVal = Convert.ToInt32(reader["Physicality"]);
                    away2SubReliableVal = Convert.ToInt32(reader["Reliability"]);
                    away2SubTackleVal = Convert.ToInt32(reader["Tackling"]);
                    away2SubAggroVal = Convert.ToInt32(reader["Aggression"]);
                }
            }
            reader.Close();
            //selecting away 1 team's name
            Com.CommandText = "Select TeamName from Teams where Id = " + away2ID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            awayTeam2.Text = Convert.ToString(reader["TeamName"]);
            reader.Close();
            Con.Close();
        }


        private void advanceButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
            if (matchEnded == false)
            {
                gameClockIncrementer += 5;
                ScoreGoalCheck();
                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    LeagueTableUpdater();
                    UpdateCurrFixture();
                }
            }
        }
    }
}
