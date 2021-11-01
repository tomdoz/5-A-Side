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
        public int fixture1Result; //for the result variables, a home win is 1, an away win is 2 and a draw is 3
        public int fixture2Result;
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
            int home1Points, home1Wins, home1Losses, home1Draws, home1GF, home1GA, home1NumMatches, away1Points, away1Wins, away1Losses, away1Draws, away1GF, away1GA, away1NumMatches, home2Points, home2Wins, home2Losses, home2Draws, home2GF, home2GA, home2NumMatches, away2Points, away2Wins, away2Losses, away2Draws, away2GF, away2GA, away2NumMatches;
            //selecting leagueTableData for home1 so it can be updated
            Con.Open();
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            switch (home1ID)
            {
                case 1002: //if homeTeam1 is MU
                    home1Points = Convert.ToInt32(reader["MUPoints"]);
                    home1Wins = Convert.ToInt32(reader["MUWins"]);
                    home1Losses = Convert.ToInt32(reader["MULosses"]);
                    home1Draws = Convert.ToInt32(reader["MUDraws"]);
                    home1GF = Convert.ToInt32(reader["MUGF"]);
                    home1GA = Convert.ToInt32(reader["MUGA"]);
                    home1NumMatches = Convert.ToInt32(reader["MUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + "Where Id = " + 1002;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + (home1Wins + 1) + ", MUDraws = " + home1Draws + ", MULosses = " + home1Losses + ", MUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", MUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + (home1Points + 3) + ", MUMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result ==2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + home1Wins + ", MUDraws = " + home1Draws + ", MULosses = " + (home1Losses + 1) + ", MUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", MUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + home1Points + ", MUMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + home1Wins + ", MUDraws = " + (home1Draws + 1) + ", MULosses = " + home1Losses + ", MUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", MUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + (home1Points + 1) + ", MUMatches = " + (home1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1003: //if homeTeam1 is CHE
                    home1Points = Convert.ToInt32(reader["CHEPoints"]);
                    home1Wins = Convert.ToInt32(reader["CHEWins"]);
                    home1Losses = Convert.ToInt32(reader["CHELosses"]);
                    home1Draws = Convert.ToInt32(reader["CHEDraws"]);
                    home1GF = Convert.ToInt32(reader["CHEGF"]);
                    home1GA = Convert.ToInt32(reader["CHEGA"]);
                    home1NumMatches = Convert.ToInt32(reader["CHEMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + "Where Id = " + 1003;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + (home1Wins + 1) + ", CHEDraws = " + home1Draws + ", CHELosses = " + home1Losses + ", CHEGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + (home1Points + 3) + ", CHEMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + home1Wins + ", CHEDraws = " + home1Draws + ", CHELosses = " + (home1Losses + 1) + ", CHEGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + home1Points + ", CHEMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + home1Wins + ", CHEDraws = " + (home1Draws + 1) + ", CHELosses = " + home1Losses + ", CHEGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + (home1Points + 1) + ", CHEMatches = " + (home1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1004: //if homeTeam1 is SOU
                    home1Points = Convert.ToInt32(reader["SOUPoints"]);
                    home1Wins = Convert.ToInt32(reader["SOUWins"]);
                    home1Losses = Convert.ToInt32(reader["SOULosses"]);
                    home1Draws = Convert.ToInt32(reader["SOUDraws"]);
                    home1GF = Convert.ToInt32(reader["SOUGF"]);
                    home1GA = Convert.ToInt32(reader["SOUGA"]);
                    home1NumMatches = Convert.ToInt32(reader["SOUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + "Where Id = " + 1004;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + (home1Wins + 1) + ", SOUDraws = " + home1Draws + ", SOULosses = " + home1Losses + ", SOUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + (home1Points + 3) + ", SOUMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + home1Wins + ", SOUDraws = " + home1Draws + ", SOULosses = " + (home1Losses + 1) + ", SOUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + home1Points + ", SOUMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + home1Wins + ", SOUDraws = " + (home1Draws + 1) + ", SOULosses = " + home1Losses + ", SOUGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + (home1Points + 1) + ", SOUMatches = " + (home1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1005: //homeTeam1 is WOL
                    home1Points = Convert.ToInt32(reader["WOLPoints"]);
                    home1Wins = Convert.ToInt32(reader["WOLWins"]);
                    home1Losses = Convert.ToInt32(reader["WOLLosses"]);
                    home1Draws = Convert.ToInt32(reader["WOLDraws"]);
                    home1GF = Convert.ToInt32(reader["WOLGF"]);
                    home1GA = Convert.ToInt32(reader["WOLGA"]);
                    home1NumMatches = Convert.ToInt32(reader["WOLMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + "Where Id = " + 1005;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + (home1Wins + 1) + ", WOLDraws = " + home1Draws + ", WOLLosses = " + home1Losses + ", WOLGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + (home1Points + 3) + ", WOLMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + home1Wins + ", WOLDraws = " + home1Draws + ", WOLLosses = " + (home1Losses + 1) + ", WOLGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + home1Points + ", WOLMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + home1Wins + ", WOLDraws = " + (home1Draws + 1) + ", WOLLosses = " + home1Losses + ", WOLGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + (home1Points + 1) + ", WOLMatches = " + (home1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1006:
                    home1Points = Convert.ToInt32(reader["NORPoints"]);
                    home1Wins = Convert.ToInt32(reader["NORWins"]);
                    home1Losses = Convert.ToInt32(reader["NORLosses"]);
                    home1Draws = Convert.ToInt32(reader["NORDraws"]);
                    home1GF = Convert.ToInt32(reader["NORGF"]);
                    home1GA = Convert.ToInt32(reader["NORGA"]);
                    home1NumMatches = Convert.ToInt32(reader["NORMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + "Where Id = " + 1006;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + (home1Wins + 1) + ", NORDraws = " + home1Draws + ", NORLosses = " + home1Losses + ", NORGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", NORGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + (home1Points + 3) + ", NORMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + home1Wins + ", NORDraws = " + home1Draws + ", NORLosses = " + (home1Losses + 1) + ", NORGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", NORGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + home1Points + ", NORMatches = " + (home1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + home1Wins + ", NORDraws = " + (home1Draws + 1) + ", NORLosses = " + home1Losses + ", NORGF = " + (home1GF + Convert.ToInt32(homeTeam1Score.Text)) + ", NORGA = " + (home1GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + (home1Points + 1) + ", NORMatches = " + (home1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;
            }

            //selecting leagueTableData for away1 so it can be updated
            Con.Open();
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            switch (away1ID)
            {
                case 1002: //if awayTeam1 is MU
                    away1Points = Convert.ToInt32(reader["MUPoints"]);
                    away1Wins = Convert.ToInt32(reader["MUWins"]);
                    away1Losses = Convert.ToInt32(reader["MULosses"]);
                    away1Draws = Convert.ToInt32(reader["MUDraws"]);
                    away1GF = Convert.ToInt32(reader["MUGF"]);
                    away1GA = Convert.ToInt32(reader["MUGA"]);
                    away1NumMatches = Convert.ToInt32(reader["MUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + "Where Id = " + 1002;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + (away1Wins + 1) + ", MUDraws = " + away1Draws + ", MULosses = " + away1Losses + ", MUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", MUPoints = " + (away1Points + 3) + ", MUMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + away1Wins + ", MUDraws = " + away1Draws + ", MULosses = " + (away1Losses + 1) + ", MUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", MUPoints = " + away1Points + ", MUMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + away1Wins + ", MUDraws = " + (away1Draws + 1) + ", MULosses = " + away1Losses + ", MUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", MUPoints = " + (away1Points + 1) + ", MUMatches = " + (away1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1003: //if awayTeam1 is CHE
                    away1Points = Convert.ToInt32(reader["CHEPoints"]);
                    away1Wins = Convert.ToInt32(reader["CHEWins"]);
                    away1Losses = Convert.ToInt32(reader["CHELosses"]);
                    away1Draws = Convert.ToInt32(reader["CHEDraws"]);
                    away1GF = Convert.ToInt32(reader["CHEGF"]);
                    away1GA = Convert.ToInt32(reader["CHEGA"]);
                    away1NumMatches = Convert.ToInt32(reader["CHEMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + "Where Id = " + 1003;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + (away1Wins + 1) + ", CHEDraws = " + away1Draws + ", CHELosses = " + away1Losses + ", CHEGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEPoints = " + (away1Points + 3) + ", CHEMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + away1Wins + ", CHEDraws = " + away1Draws + ", CHELosses = " + (away1Losses + 1) + ", CHEGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEPoints = " + away1Points + ", CHEMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + away1Wins + ", CHEDraws = " + (away1Draws + 1) + ", CHELosses = " + away1Losses + ", CHEGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", CHEPoints = " + (away1Points + 1) + ", CHEMatches = " + (away1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1004: //if awayTeam1 is SOU
                    away1Points = Convert.ToInt32(reader["SOUPoints"]);
                    away1Wins = Convert.ToInt32(reader["SOUWins"]);
                    away1Losses = Convert.ToInt32(reader["SOULosses"]);
                    away1Draws = Convert.ToInt32(reader["SOUDraws"]);
                    away1GF = Convert.ToInt32(reader["SOUGF"]);
                    away1GA = Convert.ToInt32(reader["SOUGA"]);
                    away1NumMatches = Convert.ToInt32(reader["SOUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + "Where Id = " + 1004;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + (away1Wins + 1) + ", SOUDraws = " + away1Draws + ", SOULosses = " + away1Losses + ", SOUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUPoints = " + (away1Points + 3) + ", SOUMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + away1Wins + ", SOUDraws = " + away1Draws + ", SOULosses = " + (away1Losses + 1) + ", SOUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUPoints = " + away1Points + ", SOUMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + away1Wins + ", SOUDraws = " + (away1Draws + 1) + ", SOULosses = " + away1Losses + ", SOUGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", SOUPoints = " + (away1Points + 1) + ", SOUMatches = " + (away1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1005: //away Team1 is WOL
                    away1Points = Convert.ToInt32(reader["WOLPoints"]);
                    away1Wins = Convert.ToInt32(reader["WOLWins"]);
                    away1Losses = Convert.ToInt32(reader["WOLLosses"]);
                    away1Draws = Convert.ToInt32(reader["WOLDraws"]);
                    away1GF = Convert.ToInt32(reader["WOLGF"]);
                    away1GA = Convert.ToInt32(reader["WOLGA"]);
                    away1NumMatches = Convert.ToInt32(reader["WOLMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + "Where Id = " + 1005;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + (away1Wins + 1) + ", WOLDraws = " + away1Draws + ", WOLLosses = " + away1Losses + ", WOLGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLPoints = " + (away1Points + 3) + ", WOLMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + away1Wins + ", WOLDraws = " + away1Draws + ", WOLLosses = " + (away1Losses + 1) + ", WOLGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLPoints = " + away1Points + ", WOLMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + away1Wins + ", WOLDraws = " + (away1Draws + 1) + ", WOLLosses = " + away1Losses + ", WOLGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", WOLPoints = " + (away1Points + 1) + ", WOLMatches = " + (away1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1006:
                    away1Points = Convert.ToInt32(reader["NORPoints"]);
                    away1Wins = Convert.ToInt32(reader["NORWins"]);
                    away1Losses = Convert.ToInt32(reader["NORLosses"]);
                    away1Draws = Convert.ToInt32(reader["NORDraws"]);
                    away1GF = Convert.ToInt32(reader["NORGF"]);
                    away1GA = Convert.ToInt32(reader["NORGA"]);
                    away1NumMatches = Convert.ToInt32(reader["NORMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away1GF + Convert.ToInt32(awayTeam1Score.Text)) + "Where Id = " + 1006;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture1Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + (away1Wins + 1) + ", NORDraws = " + away1Draws + ", NORLosses = " + away1Losses + ", NORGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", NORPoints = " + (away1Points + 3) + ", NORMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + away1Wins + ", NORDraws = " + away1Draws + ", NORLosses = " + (away1Losses + 1) + ", NORGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", NORPoints = " + away1Points + ", NORMatches = " + (away1NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture1Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + away1Wins + ", NORDraws = " + (away1Draws + 1) + ", NORLosses = " + away1Losses + ", NORGF = " + (away1GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away1GA + Convert.ToInt32(homeTeam1Score.Text)) + ", NORPoints = " + (away1Points + 1) + ", NORMatches = " + (away1NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;        
            }
            //FIXTURE 2 NOW
            //selecting leagueTableData for home2 so it can be updated
            Con.Open();
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            switch (home2ID)
            {
                case 1002: //if homeTeam1 is MU
                    home2Points = Convert.ToInt32(reader["MUPoints"]);
                    home2Wins = Convert.ToInt32(reader["MUWins"]);
                    home2Losses = Convert.ToInt32(reader["MULosses"]);
                    home2Draws = Convert.ToInt32(reader["MUDraws"]);
                    home2GF = Convert.ToInt32(reader["MUGF"]);
                    home2GA = Convert.ToInt32(reader["MUGA"]);
                    home2NumMatches = Convert.ToInt32(reader["MUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + "Where Id = " + 1002;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + (home2Wins + 1) + ", MUDraws = " + home2Draws + ", MULosses = " + home2Losses + ", MUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", MUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + (home2Points + 3) + ", MUMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + home2Wins + ", MUDraws = " + home2Draws + ", MULosses = " + (home2Losses + 1) + ", MUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", MUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + home2Points + ", MUMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + home2Wins + ", MUDraws = " + (home2Draws + 1) + ", MULosses = " + home2Losses + ", MUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", MUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", MUPoints = " + (home2Points + 1) + ", MUMatches = " + (home2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1003: //if homeTeam1 is CHE
                    home2Points = Convert.ToInt32(reader["CHEPoints"]);
                    home2Wins = Convert.ToInt32(reader["CHEWins"]);
                    home2Losses = Convert.ToInt32(reader["CHELosses"]);
                    home2Draws = Convert.ToInt32(reader["CHEDraws"]);
                    home2GF = Convert.ToInt32(reader["CHEGF"]);
                    home2GA = Convert.ToInt32(reader["CHEGA"]);
                    home2NumMatches = Convert.ToInt32(reader["CHEMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + "Where Id = " + 1003;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + (home2Wins + 1) + ", CHEDraws = " + home2Draws + ", CHELosses = " + home2Losses + ", CHEGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + (home2Points + 3) + ", CHEMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + home2Wins + ", CHEDraws = " + home2Draws + ", CHELosses = " + (home2Losses + 1) + ", CHEGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + home2Points + ", CHEMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + home2Wins + ", CHEDraws = " + (home2Draws + 1) + ", CHELosses = " + home2Losses + ", CHEGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEPoints = " + (home2Points + 1) + ", CHEMatches = " + (home2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1004: //if homeTeam1 is SOU
                    home2Points = Convert.ToInt32(reader["SOUPoints"]);
                    home2Wins = Convert.ToInt32(reader["SOUWins"]);
                    home2Losses = Convert.ToInt32(reader["SOULosses"]);
                    home2Draws = Convert.ToInt32(reader["SOUDraws"]);
                    home2GF = Convert.ToInt32(reader["SOUGF"]);
                    home2GA = Convert.ToInt32(reader["SOUGA"]);
                    home2NumMatches = Convert.ToInt32(reader["SOUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + "Where Id = " + 1004;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + (home2Wins + 1) + ", SOUDraws = " + home2Draws + ", SOULosses = " + home2Losses + ", SOUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + (home2Points + 3) + ", SOUMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    { 
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + home2Wins + ", SOUDraws = " + home2Draws + ", SOULosses = " + (home2Losses + 1) + ", SOUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + home2Points + ", SOUMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + home2Wins + ", SOUDraws = " + (home2Draws + 1) + ", SOULosses = " + home2Losses + ", SOUGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUPoints = " + (home2Points + 1) + ", SOUMatches = " + (home2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1005: //homeTeam1 is WOL
                    home2Points = Convert.ToInt32(reader["WOLPoints"]);
                    home2Wins = Convert.ToInt32(reader["WOLWins"]);
                    home2Losses = Convert.ToInt32(reader["WOLLosses"]);
                    home2Draws = Convert.ToInt32(reader["WOLDraws"]);
                    home2GF = Convert.ToInt32(reader["WOLGF"]);
                    home2GA = Convert.ToInt32(reader["WOLGA"]);
                    home2NumMatches = Convert.ToInt32(reader["WOLMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + "Where Id = " + 1005;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + (home2Wins + 1) + ", WOLDraws = " + home2Draws + ", WOLLosses = " + home2Losses + ", WOLGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + (home2Points + 3) + ", WOLMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + home2Wins + ", WOLDraws = " + home2Draws + ", WOLLosses = " + (home2Losses + 1) + ", WOLGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + home2Points + ", WOLMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + home2Wins + ", WOLDraws = " + (home2Draws + 1) + ", WOLLosses = " + home2Losses + ", WOLGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLPoints = " + (home2Points + 1) + ", WOLMatches = " + (home2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1006:
                    home2Points = Convert.ToInt32(reader["NORPoints"]);
                    home2Wins = Convert.ToInt32(reader["NORWins"]);
                    home2Losses = Convert.ToInt32(reader["NORLosses"]);
                    home2Draws = Convert.ToInt32(reader["NORDraws"]);
                    home2GF = Convert.ToInt32(reader["NORGF"]);
                    home2GA = Convert.ToInt32(reader["NORGA"]);
                    home2NumMatches = Convert.ToInt32(reader["NORMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + "Where Id = " + 1006;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + (home2Wins + 1) + ", NORDraws = " + home2Draws + ", NORLosses = " + home2Losses + ", NORGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", NORGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + (home2Points + 3) + ", NORMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + home2Wins + ", NORDraws = " + home2Draws + ", NORLosses = " + (home2Losses + 1) + ", NORGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", NORGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + home2Points + ", NORMatches = " + (home2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + home2Wins + ", NORDraws = " + (home2Draws + 1) + ", NORLosses = " + home2Losses + ", NORGF = " + (home2GF + Convert.ToInt32(homeTeam2Score.Text)) + ", NORGA = " + (home2GA + Convert.ToInt32(awayTeam2Score.Text)) + ", NORPoints = " + (home2Points + 1) + ", NORMatches = " + (home2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;
            }

            //selecting leagueTableData for away2 so it can be updated
            Con.Open();
            Com.CommandText = "Select * from UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            switch (away2ID)
            {
                case 1002: //if awayTeam1 is MU
                    away2Points = Convert.ToInt32(reader["MUPoints"]);
                    away2Wins = Convert.ToInt32(reader["MUWins"]);
                    away2Losses = Convert.ToInt32(reader["MULosses"]);
                    away2Draws = Convert.ToInt32(reader["MUDraws"]);
                    away2GF = Convert.ToInt32(reader["MUGF"]);
                    away2GA = Convert.ToInt32(reader["MUGA"]);
                    away2NumMatches = Convert.ToInt32(reader["MUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + "Where Id = " + 1002;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 1) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + (away2Wins + 1) + ", MUDraws = " + away2Draws + ", MULosses = " + away2Losses + ", MUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", MUPoints = " + (away2Points + 3) + ", MUMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 2) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + away2Wins + ", MUDraws = " + away2Draws + ", MULosses = " + (away2Losses + 1) + ", MUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", MUPoints = " + away2Points + ", MUMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET MUWins = " + away2Wins + ", MUDraws = " + (away2Draws + 1) + ", MULosses = " + away2Losses + ", MUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", MUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", MUPoints = " + (away2Points + 1) + ", MUMatches = " + (away2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1003: //if awayTeam1 is CHE
                    away2Points = Convert.ToInt32(reader["CHEPoints"]);
                    away2Wins = Convert.ToInt32(reader["CHEWins"]);
                    away2Losses = Convert.ToInt32(reader["CHELosses"]);
                    away2Draws = Convert.ToInt32(reader["CHEDraws"]);
                    away2GF = Convert.ToInt32(reader["CHEGF"]);
                    away2GA = Convert.ToInt32(reader["CHEGA"]);
                    away2NumMatches = Convert.ToInt32(reader["CHEMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + "Where Id = " + 1003;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + (away2Wins + 1) + ", CHEDraws = " + away2Draws + ", CHELosses = " + away2Losses + ", CHEGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEPoints = " + (away2Points + 3) + ", CHEMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + away2Wins + ", CHEDraws = " + away2Draws + ", CHELosses = " + (away2Losses + 1) + ", CHEGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEPoints = " + away2Points + ", CHEMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET CHEWins = " + away2Wins + ", CHEDraws = " + (away2Draws + 1) + ", CHELosses = " + away2Losses + ", CHEGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", CHEGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", CHEPoints = " + (away2Points + 1) + ", CHEMatches = " + (away2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1004: //if awayTeam1 is SOU
                    away2Points = Convert.ToInt32(reader["SOUPoints"]);
                    away2Wins = Convert.ToInt32(reader["SOUWins"]);
                    away2Losses = Convert.ToInt32(reader["SOULosses"]);
                    away2Draws = Convert.ToInt32(reader["SOUDraws"]);
                    away2GF = Convert.ToInt32(reader["SOUGF"]);
                    away2GA = Convert.ToInt32(reader["SOUGA"]);
                    away2NumMatches = Convert.ToInt32(reader["SOUMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + "Where Id = " + 1004;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + (away2Wins + 1) + ", SOUDraws = " + away2Draws + ", SOULosses = " + away2Losses + ", SOUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUPoints = " + (away2Points + 3) + ", SOUMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + away2Wins + ", SOUDraws = " + away2Draws + ", SOULosses = " + (away2Losses + 1) + ", SOUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUPoints = " + away2Points + ", SOUMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET SOUWins = " + away2Wins + ", SOUDraws = " + (away2Draws + 1) + ", SOULosses = " + away2Losses + ", SOUGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", SOUGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", SOUPoints = " + (away2Points + 1) + ", SOUMatches = " + (away2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1005: //awayTeam1 is WOL
                    away2Points = Convert.ToInt32(reader["WOLPoints"]);
                    away2Wins = Convert.ToInt32(reader["WOLWins"]);
                    away2Losses = Convert.ToInt32(reader["WOLLosses"]);
                    away2Draws = Convert.ToInt32(reader["WOLDraws"]);
                    away2GF = Convert.ToInt32(reader["WOLGF"]);
                    away2GA = Convert.ToInt32(reader["WOLGA"]);
                    away2NumMatches = Convert.ToInt32(reader["WOLMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + "Where Id = " + 1005;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + (away2Wins + 1) + ", WOLDraws = " + away2Draws + ", WOLLosses = " + away2Losses + ", WOLGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLPoints = " + (away2Points + 3) + ", WOLMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + away2Wins + ", WOLDraws = " + away2Draws + ", WOLLosses = " + (away2Losses + 1) + ", WOLGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLPoints = " + away2Points + ", WOLMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET WOLWins = " + away2Wins + ", WOLDraws = " + (away2Draws + 1) + ", WOLLosses = " + away2Losses + ", WOLGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", WOLGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", WOLPoints = " + (away2Points + 1) + ", WOLMatches = " + (away2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;

                case 1006:
                    away2Points = Convert.ToInt32(reader["NORPoints"]);
                    away2Wins = Convert.ToInt32(reader["NORWins"]);
                    away2Losses = Convert.ToInt32(reader["NORLosses"]);
                    away2Draws = Convert.ToInt32(reader["NORDraws"]);
                    away2GF = Convert.ToInt32(reader["NORGF"]);
                    away2GA = Convert.ToInt32(reader["NORGA"]);
                    away2NumMatches = Convert.ToInt32(reader["NORMatches"]);
                    reader.Close();
                    Com.CommandText = "Update Teams SET GF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + "Where Id = " + 1006;
                    Com.Connection = Con;
                    Com.ExecuteNonQuery();
                    Con.Close();
                    if (fixture2Result == 2) //win
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + (away2Wins + 1) + ", NORDraws = " + away2Draws + ", NORLosses = " + away2Losses + ", NORGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", NORPoints = " + (away2Points + 3) + ", NORMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 1) //loss
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + away2Wins + ", NORDraws = " + away2Draws + ", NORLosses = " + (away2Losses + 1) + ", NORGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", NORPoints = " + away2Points + ", NORMatches = " + (away2NumMatches + 1) + " WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    else if (fixture2Result == 3) //draw
                    {
                        Con.Open();
                        Com.CommandText = "Update UserTable SET NORWins = " + away2Wins + ", NORDraws = " + (away2Draws + 1) + ", NORLosses = " + away2Losses + ", NORGF = " + (away2GF + Convert.ToInt32(awayTeam2Score.Text)) + ", NORGA = " + (away2GA + Convert.ToInt32(homeTeam2Score.Text)) + ", NORPoints = " + (away2Points + 1) + ", NORMatches = " + (away2NumMatches + 1) + "  WHERE Id = " + LoginMenu.UserID;
                        Com.Connection = Con;
                        Com.ExecuteNonQuery();
                        Con.Close();
                    }
                    break;
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
                awayTeam2Score.Text = Convert.ToString(Convert.ToInt32(awayTeam2Score.Text) + 1);
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
            home1ScoreChance = Convert.ToInt32(Convert.ToDouble(home1ScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
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
            away1ScoreChance = Convert.ToInt32(Convert.ToDouble(away1ScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
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
            home2ScoreChance = Convert.ToInt32(Convert.ToDouble(home2ScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            away1ScoreChance = Convert.ToInt32(Convert.ToDouble(away1ScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
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
                    SetGameResult();
                    LeagueTableUpdater();
                    UpdateCurrFixture();
                }
            }
        }

        public void SetGameResult()
        {
            //fixture 1
            if (Convert.ToInt32(homeTeam1Score.Text) > Convert.ToInt32(awayTeam1Score.Text))
            {
                fixture1Result = 1; //home win
            }
            else if (Convert.ToInt32(homeTeam1Score.Text) < Convert.ToInt32(awayTeam1Score.Text))
            {
                fixture1Result = 2; //away win
            }
            else
            {
                fixture1Result = 3; //draw
            }

            //fixture 2
            if (Convert.ToInt32(homeTeam2Score.Text) > Convert.ToInt32(awayTeam2Score.Text))
            {
                fixture2Result = 1; //home win
            }
            else if (Convert.ToInt32(homeTeam2Score.Text) < Convert.ToInt32(awayTeam2Score.Text))
            {
                fixture2Result = 2; //away win
            }
            else
            {
                fixture2Result = 3; //draw
            }
        }
        
    }
}
