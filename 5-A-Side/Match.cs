using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _5_A_Side
{
    public class Match : Sql
    {
        //arrays for individual player attributes (user team);
        public int[] capStats = new int[7];
        public int[] p2Stats = new int[7];
        public int[] p3Stats = new int[7];
        public int[] p4Stats = new int[7];
        public int[] p5Stats = new int[7];
        public int[] p6Stats = new int[7];

        //arrays for individual player attributes (cpu team)
        public int[] cpuCapStats = new int[7];
        public int[] cpuP2Stats = new int[7];
        public int[] cpuP3Stats = new int[7];
        public int[] cpuP4Stats = new int[7];
        public int[] cpuP5Stats = new int[7];
        public int[] cpuP6Stats = new int[7];

        //variables for averages of each attribute for each stat for user and cpu teams
        public int[] userAverages = new int[7];
        public int[] cpuAverages = new int[7];

        //variables for game running
        public Random random = new Random();
        public int fixtureID;
        public string userName;
        public string cpuName;
        public int cpuTeamID;
        public int userTeamID;
        public bool userAtHome = false;
        public bool cpuAtHome = false;
        public int gameClockIncrementer = 0;
        public int userScoreChance;
        public int cpuScoreChance;

        public void MatchSetup() //Runs the methods to set up an Instance of the match class with the approriate data to the point where the match can be simulated
        {
            GetCurrentFixture();
            AssignTeams();
            TeamAvgStats();
            userScoreChance = ChanceGenerator(userAtHome, userAverages, cpuAverages);
            cpuScoreChance = ChanceGenerator(userAtHome, cpuAverages, userAverages);
        }

        public void GetCurrentFixture() //Selects the current fixture which is the fixture that will be played out in this match instance
        {
            fixtureID = Convert.ToInt32(Sql.Select("Select CurrFixtureID from UserTable Where Id = " + LoginMenu.UserID.ToString(), 0, "CurrFixtureID"));
        }

        public void AssignTeams() //assigns the correct teams to the appropriate variables using the fixture ID
        {
            if (Convert.ToInt32(Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID")) == 1 || (Convert.ToInt32(Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "AwayTeamID")) == 1))
            {
                if (Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID")) == 1) //if the ID for the home team is 1 (which is the ID used in the fixture table for the user's team), user is at home
                {
                    userAtHome = true; //user team is at home
                    cpuAtHome = false;
                    userTeamID = LoginMenu.TeamID;
                    cpuTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "AwayTeamID")); //if user is at home, the cpuTeam must be away, so we can assing that teams ID
                }
                else
                {
                    userAtHome = false; //we know the user team is away
                    cpuAtHome = true;
                    userTeamID = LoginMenu.TeamID;
                    cpuTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID")); //therefore home team is cpu team
                }
            }
            else
            {
                userAtHome = true;
                cpuAtHome = false;
                userTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "HomeTeamID"));
                cpuTeamID = Convert.ToInt32(Sql.Select("Select * from Fixtures where Id = " + fixtureID.ToString(), 0, "AwayTeamID"));
            }

            //selecting and assigning the user team's player attributes
            capStats = Player.CollectStats(userTeamID, 1);
            p2Stats = Player.CollectStats(userTeamID, 2);
            p3Stats = Player.CollectStats(userTeamID, 3);
            p4Stats = Player.CollectStats(userTeamID, 4);
            p5Stats = Player.CollectStats(userTeamID, 5);
            p6Stats = Player.CollectStats(userTeamID, 6);
            //selecting user team's name
            userName = Sql.Select("Select TeamName from Teams where Id = " + userTeamID.ToString(), 0, "TeamName");
            //selecting and assinging the cpu team's player attributes
            cpuCapStats = Player.CollectStats(cpuTeamID, 1);
            cpuP2Stats = Player.CollectStats(cpuTeamID, 2);
            cpuP3Stats = Player.CollectStats(cpuTeamID, 3);
            cpuP4Stats = Player.CollectStats(cpuTeamID, 4);
            cpuP5Stats = Player.CollectStats(cpuTeamID, 5);
            cpuP6Stats = Player.CollectStats(cpuTeamID, 6);
            //selecting cpu team's name
            cpuName = Sql.Select("Select TeamName from Teams where Id = " + cpuTeamID.ToString(), 0, "TeamName");
        }

        public void TeamAvgStats()
        {
            //using a simple mean calculation
            int userSHO = (capStats[0] + p2Stats[0] + p3Stats[0] + p4Stats[0] + p5Stats[0] + p6Stats[0]) / 5;
            int userDRI = (capStats[1] + p2Stats[1] + p3Stats[1] + p4Stats[1] + p5Stats[1] + p6Stats[1]) / 5;
            int userPAC = (capStats[2] + p2Stats[2] + p3Stats[2] + p4Stats[2] + p5Stats[2] + p6Stats[2]) / 5;
            int userPHY = (capStats[3] + p2Stats[3] + p3Stats[3] + p4Stats[3] + p5Stats[3] + p6Stats[3]) / 5;
            int userREL = (capStats[4] + p2Stats[4] + p3Stats[4] + p4Stats[4] + p5Stats[4] + p6Stats[4]) / 5;
            int userTAC = (capStats[5] + p2Stats[5] + p3Stats[5] + p4Stats[5] + p5Stats[5] + p6Stats[5]) / 5;
            int userAGG = (capStats[6] + p2Stats[6] + p3Stats[6] + p4Stats[6] + p5Stats[6] + p6Stats[6]) / 5;
            int[] userAveragesTemp = { userSHO, userDRI, userPAC, userPHY, userREL, userTAC, userAGG };
            userAverages = userAveragesTemp;
            int cpuSHO = (cpuCapStats[0] + cpuP2Stats[0] + cpuP3Stats[0] + cpuP4Stats[0] + cpuP5Stats[0] + cpuP6Stats[0]) / 5;
            int cpuDRI = (cpuCapStats[1] + cpuP2Stats[1] + cpuP3Stats[1] + cpuP4Stats[1] + cpuP5Stats[1] + cpuP6Stats[1]) / 5;
            int cpuPAC = (cpuCapStats[2] + cpuP2Stats[2] + cpuP3Stats[2] + cpuP4Stats[2] + cpuP5Stats[2] + cpuP6Stats[2]) / 5;
            int cpuPHY = (cpuCapStats[3] + cpuP2Stats[3] + cpuP3Stats[3] + cpuP4Stats[3] + cpuP5Stats[3] + cpuP6Stats[3]) / 5;
            int cpuREL = (cpuCapStats[4] + cpuP2Stats[4] + cpuP3Stats[4] + cpuP4Stats[4] + cpuP5Stats[4] + cpuP6Stats[4]) / 5;
            int cpuTAC = (cpuCapStats[5] + cpuP2Stats[5] + cpuP3Stats[5] + cpuP4Stats[5] + cpuP5Stats[5] + cpuP6Stats[5]) / 5;
            int cpuAGG = (cpuCapStats[6] + cpuP2Stats[6] + cpuP3Stats[6] + cpuP4Stats[6] + cpuP5Stats[6] + cpuP6Stats[6]) / 5;
            int[] cpuAveragesTemp = new int[7] { cpuSHO, cpuDRI, cpuPAC, cpuPHY, cpuREL, cpuTAC, cpuAGG };
            cpuAverages = cpuAveragesTemp;
        }
        //Algorithm to find the % chance (0-100) of a team scoring every 5 in-game minutes
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

        public void UpdateCurrFixture() //Updates the Current Fixture for this UserAccount so the next time a match instance is created the fixture used isn't repeated
        {
            Sql.Update("Update UserTable Set CurrFixtureID = " + (fixtureID + 1) + " Where Id = " + LoginMenu.UserID.ToString());
        }

        public int[] SimulateMatch(int ScoreChance) //Checks whether each team would score every 5 minutes and saves this data in an array
        {
            int[] Score = new int[19]; //Length of 19 because that is how many 5 minute intervals there are in a match (0, 5, 10 ... 90)
            for (int i = 0; i < 19; i++)
            {
                if (ScoreGoalCheck(ScoreChance) == true)
                {
                    Score[i] = 1; //1 assigned if goal scored
                }
                else
                {
                    Score[i] = 0; //0 assigned if no goal scored
                }
            }
            return Score;
        }

        public bool ScoreGoalCheck(int ScoreChance)
        {
            //generates a random number between one and a hundred, if this number less than equal to the corresponding teams chance of scoring then they score
            int rollProbabilities = random.Next(0, 100);
            if (rollProbabilities <= ScoreChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int MatchResult(int GoalsFor, int GoalsAgainst)
        {
            int Result;
            if (GoalsFor > GoalsAgainst) //If team A scored more goals than team B,
            {
                Result = 3; //they get 3 points (Win)
            }
            else if (GoalsAgainst > GoalsFor) //If team A scored less goals than team B
            {
                Result = 0; //they get 0 points (Loss)
            }
            else //Team A and B scored equal goals
            {
                Result = 1; //Team A gets 1 points (Draw)
            }
            return Result;
        }

        public string GetTeamCode(int TeamID) //Returns the teamCode that prefaces the league table data in UserTable attributes for each team
        {
            string output = "User";
            switch (TeamID)
            {
                case 1002:
                    output = "MU";
                    break;

                case 1003:
                    output = "CHE";
                    break;

                case 1004:
                    output = "SOU";
                    break;

                case 1005:
                    output = "WOL";
                    break;

                case 1006:
                    output = "NOR";
                    break;
            }
            return output;
        }

        public void LeagueTableUpdate(int GoalsFor, int GoalsAgainst, int Result, int TeamID, string Code)
        {
            //Selects the current values for points, and appends the correct values to reflect how the match went. 
            int Points = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID, 0, Code + "Points"));
            int GF = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID, 0, Code + "GF"));
            int GA = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID, 0, "UserGA"));
            int NumMatches = Convert.ToInt32(Sql.Select("Select * from UserTable Where Id = " + LoginMenu.UserID, 0, Code + "Matches"));
            //Appended values then used to Update the correct records in UserTable and Teams
            Update("Update UserTable SET " + Code + "GF = " + (GF + GoalsFor) + ", " + Code + "GA = " + (GA + GoalsAgainst) + ", " + Code + "Points = " + (Points + Result).ToString() + ", " + Code + "Matches = " + (NumMatches + 1).ToString() + " WHERE Id = " + LoginMenu.UserID.ToString());
            Update("Update Teams SET GF = " + (Select("Select * from UserTable Where Id = " + LoginMenu.UserID, 0, Code + "GF")) + "Where Id = " + TeamID);
        }
    }

}
