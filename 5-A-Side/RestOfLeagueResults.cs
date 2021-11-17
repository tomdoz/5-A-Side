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
        public Match fixture1 = new Match();
        public Match fixture2 = new Match();
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
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
            fixture.MatchSetup();
            Debug.WriteLine(fixture.fixtureID);
            fixture.UpdateCurrFixture();
            awayScoreRecord = fixture.SimulateMatch(fixture.cpuScoreChance);
            homeTeam.Text = fixture.userName;
            awayTeam.Text = fixture.cpuName;
            Debug.WriteLine("home score chance = " + fixture.userScoreChance);
            Debug.WriteLine("away score chance = " + fixture.cpuScoreChance);
            homeScoreRecord = fixture.SimulateMatch(fixture.userScoreChance);
            homeScore = DecodeRecord(homeScoreRecord);
            awayScore = DecodeRecord(awayScoreRecord);
            Debug.WriteLine("homeScore = " + homeScore);
            homeScoreLab.Text = homeScore.ToString();
            awayScoreLab.Text = awayScore.ToString();
            int homeResult = fixture1.MatchResult(homeScore, awayScore);
            int awayResult = fixture.MatchResult(awayScore, homeScore);
            fixture.LeagueTableUpdate(homeScore, awayScore, homeResult, fixture.userTeamID);
            fixture.LeagueTableUpdate(awayScore, homeScore, awayResult, fixture.cpuTeamID);
        }

        public int DecodeRecord(int[] array)
        {
            int Score = 0;
            for (int i = 0; i < 19; i++)
            {
                Debug.WriteLine("array" + i + " = " + array[i]);
                if (array[i] == 1)
                {
                    Score++;
                }
            }
            return Score;
        }

        private void advanceButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }



    }
}
