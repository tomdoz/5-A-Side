using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_A_Side
{
    public class Match : Sql
    {
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
        public int[] userAverages = new int[7];
        public int[] cpuAverages = new int[7];

        //variables for game running
        public int fixtureID;
        public int cpuTeamID;
        public int homeTeamID;
        public bool userAtHome = false;
        public bool cpuAtHome = false;
        public int gameClockIncrementer = 0;
        public int userScoreChance;
        public int cpuScoreChance;

        public void GetCurrentFixture()
        {
            fixtureID = Convert.ToInt32(Sql.Select("Select CurrFixtureID from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "CurrFixtureID"));
        }

        public void AssignTeams()
        {
            if (Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID")) == 1) //if the ID for the home team is 1 (which is the ID used in the fixture table for the user's team), user is at home
            {
                userAtHome = true; //user team is at home
                cpuAtHome = false;
                cpuTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "AwayTeamID")); //if user is at home, the cpuTeam must be away, so we can assing that teams ID
            }
            else
            {
                userAtHome = false; //we know the user team is away
                cpuAtHome = true;
                cpuTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID")); //therefore home team is cpu team
            }
            //selecting and assigning the user team's player attributes
            int[] capStats = Player.CollectStats(LoginMenu.TeamID, 1);
            p1ShootingVal = capStats[0];
            p1DribblingVal = capStats[1];
            p1PaceVal = capStats[2];
            p1PhysicalVal = capStats[3];
            p1ReliableVal = capStats[4];
            p1TackleVal = capStats[5];
            p1AggroVal = capStats[6];
            int[] p2Stats = Player.CollectStats(LoginMenu.TeamID, 2);
            p2ShootingVal = p2Stats[0];
            p2DribblingVal = p2Stats[1];
            p2PaceVal = p2Stats[2];
            p2PhysicalVal = p2Stats[3];
            p2ReliableVal = p2Stats[4];
            p2TackleVal = p2Stats[5];
            p2AggroVal = p2Stats[6];
            int[] p3Stats = Player.CollectStats(LoginMenu.TeamID, 3);
            p3ShootingVal = p3Stats[0];
            p3DribblingVal = p3Stats[1];
            p3PaceVal = p3Stats[2];
            p3PhysicalVal = p3Stats[3];
            p3ReliableVal = p3Stats[4];
            p3TackleVal = p3Stats[5];
            p3AggroVal = p3Stats[6];
            int[] p4Stats = Player.CollectStats(LoginMenu.TeamID, 4);
            p4ShootingVal = p4Stats[0];
            p4DribblingVal = p4Stats[1];
            p4PaceVal = p4Stats[2];
            p4PhysicalVal = p4Stats[3];
            p4ReliableVal = p4Stats[4];
            p4TackleVal = p4Stats[5];
            p4AggroVal = p4Stats[6];
            int[] p5Stats = Player.CollectStats(LoginMenu.TeamID, 5);
            p5ShootingVal = p5Stats[0];
            p5DribblingVal = p5Stats[1];
            p5PaceVal = p5Stats[2];
            p5PhysicalVal = p5Stats[3];
            p5ReliableVal = p5Stats[4];
            p5TackleVal = p5Stats[5];
            p5AggroVal = p5Stats[6];
            int[] p6Stats = Player.CollectStats(LoginMenu.TeamID, 6);
            subShootingVal = p6Stats[0];
            subDribblingVal = p6Stats[1];
            subPaceVal = p6Stats[2];
            subPhysicalVal = p6Stats[3];
            subReliableVal = p6Stats[4];
            subTackleVal = p6Stats[5];
            subAggroVal = p6Stats[6];
            //selecting user team's name
            string userName = Sql.Select("Select TeamName from Teams where Id = " + LoginMenu.TeamID.ToString(), 0, "TeamName");
            //selecting and assinging the cpu team's player attributes
            int[] cpuCapStats = Player.CollectStats(LoginMenu.TeamID, 1);
            cpuP1ShootingVal = cpuCapStats[0];
            cpuP1DribblingVal = cpuCapStats[1];
            cpuP1PaceVal = cpuCapStats[2];
            cpuP1PhysicalVal = cpuCapStats[3];
            cpuP1ReliableVal = cpuCapStats[4];
            cpuP1TackleVal = cpuCapStats[5];
            cpuP1AggroVal = cpuCapStats[6];
            int[] cpuP2Stats = Player.CollectStats(LoginMenu.TeamID, 2);
            cpuP2ShootingVal = cpuP2Stats[0];
            cpuP2DribblingVal = cpuP2Stats[1];
            cpuP2PaceVal = cpuP2Stats[2];
            cpuP2PhysicalVal = cpuP2Stats[3];
            cpuP2ReliableVal = cpuP2Stats[4];
            cpuP2TackleVal = cpuP2Stats[5];
            cpuP2AggroVal = cpuP2Stats[6];
            int[] cpuP3Stats = Player.CollectStats(LoginMenu.TeamID, 3);
            cpuP3ShootingVal = cpuP3Stats[0];
            cpuP3DribblingVal = cpuP3Stats[1];
            cpuP3PaceVal = cpuP3Stats[2];
            cpuP3PhysicalVal = cpuP3Stats[3];
            cpuP3ReliableVal = cpuP3Stats[4];
            cpuP3TackleVal = cpuP3Stats[5];
            cpuP3AggroVal = cpuP3Stats[6];
            int[] cpuP4Stats = Player.CollectStats(LoginMenu.TeamID, 4);
            cpuP4ShootingVal = cpuP4Stats[0];
            cpuP4DribblingVal = cpuP4Stats[1];
            cpuP4PaceVal = cpuP4Stats[2];
            cpuP4PhysicalVal = cpuP4Stats[3];
            cpuP4ReliableVal = cpuP4Stats[4];
            cpuP4TackleVal = cpuP4Stats[5];
            cpuP4AggroVal = cpuP4Stats[6];
            int[] cpuP5Stats = Player.CollectStats(LoginMenu.TeamID, 5);
            cpuP5ShootingVal = cpuP5Stats[0];
            cpuP5DribblingVal = cpuP5Stats[1];
            cpuP5PaceVal = cpuP5Stats[2];
            cpuP5PhysicalVal = cpuP5Stats[3];
            cpuP5ReliableVal = cpuP5Stats[4];
            cpuP5TackleVal = cpuP5Stats[5];
            cpuP5AggroVal = cpuP5Stats[6];
            int[] cpuP6Stats = Player.CollectStats(LoginMenu.TeamID, 6);
            cpuSubShootingVal = cpuP6Stats[0];
            cpuSubDribblingVal = cpuP6Stats[1];
            cpuSubPaceVal = cpuP6Stats[2];
            cpuSubPhysicalVal = cpuP6Stats[3];
            cpuSubReliableVal = cpuP6Stats[4];
            cpuSubTackleVal = cpuP6Stats[5];
            cpuSubAggroVal = cpuP6Stats[6];
            //selecting cpu team's name
            string cpuTeamLabel = Sql.Select("Select TeamName from Teams where Id = " + cpuTeamID.ToString(), 0, "TeamName");
        }

        public void TeamAvgStats()
        {
            //using a simple mean calculation
            int userSHO = (p1ShootingVal + p2ShootingVal + p3ShootingVal + p4ShootingVal + p5ShootingVal) / 5;
            int userDRI = (p1DribblingVal + p2DribblingVal + p3DribblingVal + p4DribblingVal + p5DribblingVal) / 5;
            int userPAC = (p1PaceVal + p2PaceVal + p3PaceVal + p4PaceVal + p5PaceVal) / 5;
            int userPHY = (p1PhysicalVal + p2PhysicalVal + p3PhysicalVal + p4PhysicalVal + p5PhysicalVal) / 5;
            int userREL = (p1ReliableVal + p2ReliableVal + p3ReliableVal + p4ReliableVal + p5ReliableVal) / 5;
            int userTAC = (p1TackleVal + p2TackleVal + p3TackleVal + p4TackleVal + p5TackleVal) / 5;
            int userAGG = (p1AggroVal + p2AggroVal + p3AggroVal + p4AggroVal + p5AggroVal) / 5;
            int [] userAveragesTemp = { userSHO, userDRI, userPAC, userPHY, userREL, userTAC, userAGG };
            userAverages = userAveragesTemp;
            int cpuSHO = (cpuP1ShootingVal + cpuP2ShootingVal + cpuP3ShootingVal + cpuP4ShootingVal + cpuP5ShootingVal) / 5;
            int cpuDRI = (cpuP1DribblingVal + cpuP2DribblingVal + cpuP3DribblingVal + cpuP4DribblingVal + cpuP5DribblingVal) / 5;
            int cpuPAC = (cpuP1PaceVal + cpuP2PaceVal + cpuP3PaceVal + cpuP4PaceVal + cpuP5PaceVal) / 5;
            int cpuPHY = (cpuP1PhysicalVal + cpuP2PhysicalVal + cpuP3PhysicalVal + cpuP4PhysicalVal + cpuP5PhysicalVal) / 5;
            int cpuREL = (cpuP1ReliableVal + cpuP2ReliableVal + cpuP3ReliableVal + cpuP4ReliableVal + cpuP5ReliableVal) / 5;
            int cpuTAC = (cpuP1TackleVal + cpuP2TackleVal + cpuP3TackleVal + cpuP4TackleVal + cpuP5TackleVal) / 5;
            int cpuAGG = (cpuP1AggroVal + cpuP2AggroVal + cpuP3AggroVal + cpuP4AggroVal + cpuP5AggroVal) / 5;
            int[] cpuAveragesTemp = new int[7]{ cpuSHO, cpuDRI, cpuPAC, cpuPHY, cpuREL, cpuTAC, cpuAGG };
            cpuAverages = cpuAveragesTemp;
        }

        public int ChanceGenerator(bool AtHome, int[] teamAverages, int[] opposingAverages)
        {
            int scoreChance = Convert.ToInt32(((0.6 * teamAverages[0]) + (0.5 * teamAverages[2]) + (0.3 * teamAverages[1]) + (0.1 * teamAverages[3])) / 4); //loading the attacking attribute stats into weighted average equation
            scoreChance = scoreChance - Convert.ToInt32(((0.5 * opposingAverages[5]) + (0.4 * opposingAverages[3]) + (0.2 * opposingAverages[6]) + (0.2 * opposingAverages[4])) / 4); //weighted average then found using opposition defensive attribute stats
            if (AtHome == true)
            {
                scoreChance = Convert.ToInt32(Convert.ToDouble(scoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            }

            else
            {
                scoreChance = Convert.ToInt32(Convert.ToDouble(scoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            }
            if (scoreChance < 1)
            {
                scoreChance = 1; //condition so we don't allow a chance of scoring to be lower than 1, as this would interfere with calcs
            }
            return scoreChance;
        }

        public void UpdateCurrFixture()
        {
            Sql.Update("Update UserTable Set CurrFixtureID = " + (fixtureID + 1) + " Where Id = " + LoginMenu.UserID.ToString());
        }

        public int MatchResult(int GoalsFor, int GoalsAgainst)
        {
            int Result;
            if (GoalsFor > GoalsAgainst)
            {
                Result = 3;
            }
            else if (GoalsAgainst > GoalsFor)
            {
                Result = 0;
            }
            else
            {
                Result = 1;
            }
            return Result;
        }
        public void LeagueTableUpdate(int GoalsFor,int GoalsAgainst, int Result, int TeamID)
        {
            //getting current values for 
            if (TeamID == LoginMenu.TeamID)
            {
                int Points = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserPoints"));
                int Wins = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserWins"));
                int Losses = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserLosses"));
                int Draws = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserDraws"));
                int GF = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserGF"));
                int GA = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserGA"));
                int NumMatches = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "UserMatches"));
                Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                Update("Update UserTable SET UserWins = " + (Wins + 1).ToString() + ", UserDraws = " + Draws.ToString() + ", UserLosses = " + Losses.ToString() + ", UserGF = " + (GF + GoalsFor).ToString() + ", UserGA = " + (GA + GoalsAgainst).ToString() + ", UserPoints = " + (Points + Result).ToString() + ", UserMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
            }
            else
            {
                switch (TeamID)
                {
                    case 1002: //MU
                        int Points = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUPoints"));
                        int Wins = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUWins"));
                        int Losses = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MULosses"));
                        int Draws = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUDraws"));
                        int GF = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUGF"));
                        int GA = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUGA"));
                        int NumMatches = Convert.ToInt32(Sql.Select("Select * from MUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "MUMatches"));
                        Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                        Update("Update MUTable SET MUWins = " + (Wins + 1).ToString() + ", MUDraws = " + Draws.ToString() + ", MULosses = " + Losses.ToString() + ", MUGF = " + (GF + GoalsFor).ToString() + ", MUGA = " + (GA + GoalsAgainst).ToString() + ", MUPoints = " + (Points + Result).ToString() + ", MUMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
                        break;

                    case 1003: //CHE
                        Points = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEPoints"));
                        Wins = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEWins"));
                        Losses = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHELosses"));
                        Draws = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEDraws"));
                        GF = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEGF"));
                        GA = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEGA"));
                        NumMatches = Convert.ToInt32(Sql.Select("Select * from CHETable Where Id = " + LoginMenu.UserID.ToString(), 0, "CHEMatches"));
                        Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                        Update("Update CHETable SET CHEWins = " + (Wins + 1).ToString() + ", CHEDraws = " + Draws.ToString() + ", CHELosses = " + Losses.ToString() + ", CHEGF = " + (GF + GoalsFor).ToString() + ", CHEGA = " + (GA + GoalsAgainst).ToString() + ", CHEPoints = " + (Points + Result).ToString() + ", CHEMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
                        break;

                    case 1004: //SOU
                        Points = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUPoints"));
                        Wins = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUWins"));
                        Losses = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOULosses"));
                        Draws = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUDraws"));
                        GF = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUGF"));
                        GA = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUGA"));
                        NumMatches = Convert.ToInt32(Sql.Select("Select * from SOUTable Where Id = " + LoginMenu.UserID.ToString(), 0, "SOUMatches"));
                        Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                        Update("Update SOUTable SET SOUWins = " + (Wins + 1).ToString() + ", SOUDraws = " + Draws.ToString() + ", SOULosses = " + Losses.ToString() + ", SOUGF = " + (GF + GoalsFor).ToString() + ", SOUGA = " + (GA + GoalsAgainst).ToString() + ", SOUPoints = " + (Points + Result).ToString() + ", SOUMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
                        break;

                    case 1005: //WOL
                        Points = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLPoints"));
                        Wins = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLWins"));
                        Losses = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLLosses"));
                        Draws = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLDraws"));
                        GF = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLGF"));
                        GA = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLGA"));
                        NumMatches = Convert.ToInt32(Sql.Select("Select * from WOLTable Where Id = " + LoginMenu.UserID.ToString(), 0, "WOLMatches"));
                        Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                        Update("Update WOLTable SET WOLWins = " + (Wins + 1).ToString() + ", WOLDraws = " + Draws.ToString() + ", WOLLosses = " + Losses.ToString() + ", WOLGF = " + (GF + GoalsFor).ToString() + ", WOLGA = " + (GA + GoalsAgainst).ToString() + ", WOLPoints = " + (Points + Result).ToString() + ", WOLMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
                        break;

                    case 1006: //NOR
                        Points = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORPoints"));
                        Wins = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORWins"));
                        Losses = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORLosses"));
                        Draws = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORDraws"));
                        GF = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORGF"));
                        GA = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORGA"));
                        NumMatches = Convert.ToInt32(Sql.Select("Select * from NORTable Where Id = " + LoginMenu.UserID.ToString(), 0, "NORMatches"));
                        Update("Update Teams SET GF = " + (GF + GoalsFor).ToString() + "Where Id = " + LoginMenu.TeamID.ToString());
                        Update("Update NORTable SET NORWins = " + (Wins + 1).ToString() + ", NORDraws = " + Draws.ToString() + ", NORLosses = " + Losses.ToString() + ", NORGF = " + (GF + GoalsFor).ToString() + ", NORGA = " + (GA + GoalsAgainst).ToString() + ", NORPoints = " + (Points + Result).ToString() + ", NORMatches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
                        break;
                }
            }
        }
    }

}
