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
        }

        public void LoadTeams(Match fixture, Label homeTeam, Label awayTeam, int[] homeScoreRecord, int[] awayScoreRecord, int homeScore, int awayScore, Label homeScoreLab, Label awayScoreLab)
        {
            fixture1.MatchSetup();
            fixture1.UpdateCurrFixture();
            Debug.WriteLine(fixture1.fixtureID);
            away1ScoreRecord = fixture1.SimulateMatch(fixture1.cpuScoreChance);
            homeTeam1.Text = fixture1.userName;
            awayTeam1.Text = fixture1.cpuName;
            Debug.WriteLine("home score chance = " + fixture1.userScoreChance);
            Debug.WriteLine("away score chance = " + fixture1.cpuScoreChance);
            home1ScoreRecord = fixture1.SimulateMatch(fixture1.userScoreChance);
            DecodeRecords(home1ScoreRecord, away1ScoreRecord);
            homeTeam1Score.Text = home1Score.ToString();
            awayTeam1Score.Text = away1Score.ToString();
            fixture2.MatchSetup();
            fixture2.UpdateCurrFixture();
            away2ScoreRecord = fixture2.SimulateMatch(fixture2.cpuScoreChance);
            Debug.WriteLine(fixture2.fixtureID);
            homeTeam2.Text = fixture2.userName;
            awayTeam2.Text = fixture2.cpuName;
            Debug.WriteLine("home score chance = " + fixture2.userScoreChance);
            Debug.WriteLine("away score chance = " + fixture2.cpuScoreChance);
            home2ScoreRecord = fixture2.SimulateMatch(fixture2.userScoreChance);
            DecodeRecords(home2ScoreRecord, away2ScoreRecord);
            homeTeam2Score.Text = home2Score.ToString();
            awayTeam2Score.Text = away2Score.ToString();
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
