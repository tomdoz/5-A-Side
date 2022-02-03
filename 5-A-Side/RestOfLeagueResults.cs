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
using System.Diagnostics;

namespace _5_A_Side
{
    public partial class RestOfLeagueResults : Form
    {

        //essential variables
        public Match fixture1 = new Match(); //Creating the new match instances for the two matches to be simulated 
        public Match fixture2 = new Match();
        public bool matchEnded = false; 
        public int gameClockIncrementer = 0; //Keeps track of the value how many 5 minute periods have elapsed
        //Keeps track of number of goal scored by each of the 4 teams playing the match
        public int home1Score = 0;
        public int away1Score = 0;
        public int home2Score = 0;
        public int away2Score = 0;
        public int[] home1ScoreRecord = new int[19];
        public int[] away1ScoreRecord = new int[19];
        public int[] home2ScoreRecord = new int[19];
        public int[] away2ScoreRecord = new int[19];


        public RestOfLeagueResults()
        {
            InitializeComponent();
            LoadTeams(fixture1, homeTeam1, awayTeam1, home1ScoreRecord, away1ScoreRecord, home1Score, away1Score, homeTeam1Score, awayTeam1Score);
            LoadTeams(fixture2, homeTeam2, awayTeam2, home2ScoreRecord, away2ScoreRecord, home2Score, away2Score, homeTeam2Score, awayTeam2Score);
        }

        public void LoadTeams(Match fixture, Label homeTeam, Label awayTeam, int[] homeScoreRecord, int[] awayScoreRecord, int homeScore, int awayScore, Label homeScoreLab, Label awayScoreLab)
        {
            fixture.MatchSetup(); //Runs methods essential for fixture to assign data to variables to the point where match can be simulated
            fixture.UpdateCurrFixture(); //Updates Current Fixture so second match isn't just a repeat of the first
            awayScoreRecord = fixture.SimulateMatch(fixture.cpuScoreChance); //Simulates the match, returning an array of 1s and 0s for when this team scored
            homeTeam.Text = fixture.userName; //Displays the Team's names on the correct labels
            awayTeam.Text = fixture.cpuName;
            homeScoreRecord = fixture.SimulateMatch(fixture.userScoreChance); //Simulates the match, returning an array of 1s and 0s for when this team scored
            homeScore = DecodeRecord(homeScoreRecord); //Return an integer corresponding to how many goals a team scored in the match
            awayScore = DecodeRecord(awayScoreRecord);
            homeScoreLab.Text = homeScore.ToString(); //Display number of goals scored in match by each team to user
            awayScoreLab.Text = awayScore.ToString();
            int homeResult = fixture1.MatchResult(homeScore, awayScore);
            int awayResult = fixture.MatchResult(awayScore, homeScore);
            //Update league table to reflect result of match
            fixture.LeagueTableUpdate(homeScore, awayScore, homeResult, fixture.userTeamID, fixture.GetTeamCode(fixture.userTeamID));
            fixture.LeagueTableUpdate(awayScore, homeScore, awayResult, fixture.cpuTeamID, fixture.GetTeamCode(fixture.cpuTeamID));
        }

        public int DecodeRecord(int[] array) //For each 1 in the array, increment the value returned, as this is how many goals that team scored
        {
            int Score = 0;
            for (int i = 0; i < 19; i++)
            {
                if (array[i] == 1)
                {
                    Score++;
                }
            }
            return Score;
        }

        private void advanceButton_Click(object sender, EventArgs e) //Open new homepage form and close current form
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }



    }
}
