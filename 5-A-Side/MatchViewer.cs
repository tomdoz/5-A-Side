using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;

namespace _5_A_Side
{
    public partial class MatchViewer : Form
    {
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        public Match match = new Match();
        public int userScore = 0;
        public int cpuScore = 0;
        public int[] userScoreRecord = new int[19];
        public int[] cpuScoreRecord = new int[19];

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams(); //when new MatchViewer form is opened, load the correct teams
            matchTimer.Enabled = true;
        }

        public void DisplayTeams()
        {
            userName.Text = match.userName;
            cpuTeamLabel.Text = match.cpuName;
        }
        public void LoadTeams()
        {
            match.MatchSetup();
            DisplayTeams();
            if (match.userAtHome == false)
            {
                //user team is always on the left side of the form, so we swap the away and home labels to reflect who is home and who is away
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
            userScoreRecord = match.SimulateMatch(match.userScoreChance);
            cpuScoreRecord = match.SimulateMatch(match.cpuScoreChance);
            Debug.WriteLine("MatchViewer userScoreChance = " + match.userScoreChance);
            Debug.WriteLine("MatchViewer cpuScoreChance = " + match.cpuScoreChance);
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

        public void DecodeScoreRecords()
        {
            int i = gameClockIncrementer / 5;
            if (userScoreRecord[i] == 1)
            {
                UserScoreGoal();
            }
            if(cpuScoreRecord[i] == 1)
            {
                CPUScoreGoal();
            }
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
            if (matchEnded == false)
            {
                DecodeScoreRecords();
                TimerLabel.Text = Convert.ToString(gameClockIncrementer + 5) + "'";
                gameClockIncrementer += 5;

                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    userScore = Convert.ToInt32(userScoreLabel.Text);
                    cpuScore = Convert.ToInt32(cpuScoreLabel.Text);
                    int userResult = match.MatchResult(userScore, cpuScore);
                    int CPUResult = match.MatchResult(cpuScore, userScore);
                    string matchEndMsg = "The Match has ended, the game finished " + userScore + " - " + cpuScore;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                    match.LeagueTableUpdate(userScore, cpuScore, userResult,LoginMenu.TeamID);
                    match.LeagueTableUpdate(cpuScore, userScore, CPUResult, match.cpuTeamID);
                    match.UpdateCurrFixture();
                    RestOfLeagueResults rest = new RestOfLeagueResults();
                    rest.Show();
                    this.Close();
                }
            }
        }
    }
}
