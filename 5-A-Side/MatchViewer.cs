//Simulates a match between the user's team and a cpu team and displays the results in "real-time" by showing if a goal was scored every five minutes (from 0-90)
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
        public Match match = new Match(); //Inialises a new match object for the match to be played
        public int userScore = 0;
        public int cpuScore = 0;
        public int[] userScoreRecord = new int[19];
        public int[] cpuScoreRecord = new int[19];

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams(); //when new MatchViewer form is opened, load the correct teams
            matchTimer.Enabled = true; //start match timer
        }

        public void DisplayTeams() //Displays proper team names for teams playing in the match
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
            userScoreRecord = match.SimulateMatch(match.userScoreChance); //Stores the Score records of the user and cpu teams 
            cpuScoreRecord = match.SimulateMatch(match.cpuScoreChance);
        }

        public void UserScoreGoal()
        {  
            //Increments the User's score by one
            userScoreLabel.Text = Convert.ToString(Convert.ToInt32(userScoreLabel.Text) + 1);
            string userScoreMsg = "Your team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string userScoreMsgTitle = TimerLabel.Text + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(userScoreMsg, userScoreMsgTitle); //Display appropriate messagebox and pause the match timer until it is dismissed
            matchTimer.Start();
        }

        public void CPUScoreGoal()
        {
            //Increments the CPU's score by one
            cpuScoreLabel.Text = Convert.ToString(Convert.ToInt32(cpuScoreLabel.Text) + 1);
            string cpuScoreMsg = "The opposition team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string cpuScoreMsgTitle = TimerLabel.Text + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(cpuScoreMsg, cpuScoreMsgTitle); //Display appropriate messagebox and pause the match time until the messagebox is dismissed
            matchTimer.Start();
        }

        public void DecodeScoreRecords()
        {   //if index i in scoreRecord is 1, a goal is scored.
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
            //Method called everytime the matchTimer is enabled and the interval elapses
            if (matchEnded == false)
            {
                //if the match hasn't ended (e.g. clock isn't > 90 minutes)
                DecodeScoreRecords();
                TimerLabel.Text = Convert.ToString(gameClockIncrementer + 5) + "'"; //increment timer by 5 minutes
                gameClockIncrementer += 5;

                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    userScore = Convert.ToInt32(userScoreLabel.Text);
                    cpuScore = Convert.ToInt32(cpuScoreLabel.Text);
                    int userResult = match.MatchResult(userScore, cpuScore);
                    int CPUResult = match.MatchResult(cpuScore, userScore);
                    //Display approriate messagebox to inform user game has ended
                    string matchEndMsg = "The Match has ended, the game finished " + userScore + " - " + cpuScore;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                    //update the LeagueTable in user's record in UserTable to reflect results of this match
                    match.LeagueTableUpdate(userScore, cpuScore, userResult, LoginMenu.TeamID, match.GetTeamCode(LoginMenu.TeamID));
                    match.LeagueTableUpdate(cpuScore, userScore, CPUResult, match.cpuTeamID, match.GetTeamCode(match.cpuTeamID));
                    match.UpdateCurrFixture();
                    RestOfLeagueResults rest = new RestOfLeagueResults(); //open new RestOfLeagueResults form
                    rest.Show();
                    this.Close(); //Close this form
                }
            }
        }
    }
}
