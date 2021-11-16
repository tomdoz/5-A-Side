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
            fixture.UpdateCurrFixture();
            Debug.WriteLine(fixture.fixtureID);
            homeTeam.Text = fixture.userName;
            awayTeam.Text = fixture.cpuName;
            Debug.WriteLine("home score chance = " + fixture.userScoreChance);
            Debug.WriteLine("away score chance = " + fixture.cpuScoreChance);
            homeScoreRecord = fixture.SimulateMatch(fixture.userScoreChance);
            awayScoreRecord = fixture.SimulateMatch(fixture.cpuScoreChance);
            DecodeRecords(homeScoreRecord, awayScoreRecord);
            homeScoreLab.Text = homeScore.ToString();
            awayScoreLab.Text = awayScore.ToString();
        }

        public void DecodeRecords(int[] home, int[] away)
        {
            for (int i = 0; i < 19; i++)
            {
                if (home[i] == 1)
                {
                    home1Score++;
                }
                if (away[i] == 1)
                {
                    away1Score++;
                }
            }
        }

        private void advanceButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }



    }
}
