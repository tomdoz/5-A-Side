using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _5_A_Side
{
    public partial class MatchViewer : Form
    {
        //variables for individual player attributes (user team);

        //captain attribute variables
        public int p1ShootingVal = 80;
        public int p1DribblingVal = 80;
        public int p1PaceVal = 80;
        public int p1PhysicalVal = 80;
        public int p1ReliableVal = 80;
        public int p1TackleVal = 80;
        public int p1AggroVal = 80;
        //player 2 attribute variables
        public int p2ShootingVal = 80;
        public int p2DribblingVal = 80;
        public int p2PaceVal = 80;
        public int p2PhysicalVal = 80;
        public int p2ReliableVal = 80;
        public int p2TackleVal = 80;
        public int p2AggroVal = 80;
        //player 3 attribute variables;
        public int p3ShootingVal = 80;
        public int p3DribblingVal = 80;
        public int p3PaceVal = 80;
        public int p3PhysicalVal = 80;
        public int p3ReliableVal = 80;
        public int p3TackleVal = 80;
        public int p3AggroVal = 80;
        //player 4 attribute variables;
        public int p4ShootingVal = 80;
        public int p4DribblingVal = 80;
        public int p4PaceVal = 80;
        public int p4PhysicalVal = 80;
        public int p4ReliableVal = 80;
        public int p4TackleVal = 80;
        public int p4AggroVal = 80;
        //player 5 attribute variables;
        public int p5ShootingVal = 80;
        public int p5DribblingVal = 80;
        public int p5PaceVal = 80;
        public int p5PhysicalVal = 80;
        public int p5ReliableVal = 80;
        public int p5TackleVal = 80;
        public int p5AggroVal = 80;
        //substitute attribute variables
        public int subShootingVal = 80;
        public int subDribblingVal = 80;
        public int subPaceVal = 80;
        public int subPhysicalVal = 80;
        public int subReliableVal = 80;
        public int subTackleVal = 80;
        public int subAggroVal = 80;

        //variables for individual player attributes (user team);

        //captain attribute variables
        public int cpuP1ShootingVal = 80;
        public int cpuP1DribblingVal = 80;
        public int cpuP1PaceVal = 80;
        public int cpuP1PhysicalVal = 80;
        public int cpuP1ReliableVal = 80;
        public int cpuP1TackleVal = 80;
        public int cpuP1AggroVal = 80;
        //player 2 attribute variables
        public int cpuP2ShootingVal = 80;
        public int cpuP2DribblingVal = 80;
        public int cpuP2PaceVal = 80;
        public int cpuP2PhysicalVal = 80;
        public int cpuP2ReliableVal = 80;
        public int cpuP2TackleVal = 80;
        public int cpuP2AggroVal = 80;
        //player 3 attribute variables;
        public int cpuP3ShootingVal = 80;
        public int cpuP3DribblingVal = 80;
        public int cpuP3PaceVal = 80;
        public int cpuP3PhysicalVal = 80;
        public int cpuP3ReliableVal = 80;
        public int cpuP3TackleVal = 80;
        public int cpuP3AggroVal = 80;
        //player 4 attribute variables;
        public int cpuP4ShootingVal = 80;
        public int cpuP4DribblingVal = 80;
        public int cpuP4PaceVal = 80;
        public int cpuP4PhysicalVal = 80;
        public int cpuP4ReliableVal = 80;
        public int cpuP4TackleVal = 80;
        public int cpuP4AggroVal = 80;
        //player 5 attRibute variables;
        public int cpuP5ShootingVal = 80;
        public int cpuP5DribblingVal = 80;
        public int cpuP5PaceVal = 80;
        public int cpuP5PhysicalVal = 80;
        public int cpuP5ReliableVal = 80;
        public int cpuP5TackleVal = 80;
        public int cpuP5AggroVal = 80;
        //substitute attribute variables
        public int cpuSubShootingVal = 80;
        public int cpuSubDribblingVal = 80;
        public int cpuSubPaceVal = 80;
        public int cpuSubPhysicalVal = 80;
        public int cpuSubReliableVal = 80;
        public int cpuSubTackleVal = 80;
        public int cpuSubAggroVal = 80;

        //variables for averages of each attribute for each stat for user and cpu teams
        public int userSHO;
        public int userDRI;
        public int userPAC;
        public int userPHY;
        public int userREL;
        public int userTAC;
        public int userAGG;
        public int cpuSHO;
        public int cpuDRI;
        public int cpuPAC;
        public int cpuPHY;
        public int cpuREL;
        public int cpuTAC;
        public int cpuAGG;
        public int userScoreChance;
        public int cpuScoreChance;
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        public bool userAtHome = true;

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams();
            matchTimer.Enabled = true;
        }

        public void LoadTeams()
        {
            //need to add the loading of team names to the labels and proper iteration through the teams from CPU
            //Still need to pull who is home and who is away from fixture table to then control this variable
            if(userAtHome == false)
            {
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
            TeamAvgStats();
            userScoreChance = UserChanceGenerator();
            cpuScoreChance = CPUChanceGenerator();
        }

        public void TeamAvgStats()
        {
            userSHO = (p1ShootingVal + p2ShootingVal + p3ShootingVal + p4ShootingVal + p5ShootingVal) / 5;
            userDRI = (p1DribblingVal + p2DribblingVal + p3DribblingVal + p4DribblingVal + p5DribblingVal) / 5;
            userPAC = (p1PaceVal + p2PaceVal + p3PaceVal + p4PaceVal + p5PaceVal) / 5;
            userPHY = (p1PhysicalVal + p2PhysicalVal + p3PhysicalVal + p4PhysicalVal + p5PhysicalVal) / 5;
            userREL = (p1ReliableVal + p2ReliableVal + p3ReliableVal + p4ReliableVal + p5ReliableVal) / 5;
            userTAC = (p1TackleVal + p2TackleVal + p3TackleVal + p4TackleVal + p5TackleVal) / 5;
            userAGG = (p1AggroVal + p2AggroVal + p3AggroVal + p4AggroVal + p5AggroVal) / 5;
            cpuSHO = (cpuP1ShootingVal + cpuP2ShootingVal + cpuP3ShootingVal + cpuP4ShootingVal + cpuP5ShootingVal) / 5;
            cpuDRI = (cpuP1DribblingVal + cpuP2DribblingVal + cpuP3DribblingVal + cpuP4DribblingVal + cpuP5DribblingVal) / 5;
            cpuPAC = (cpuP1PaceVal + cpuP2PaceVal + cpuP3PaceVal + cpuP4PaceVal + cpuP5PaceVal) / 5;
            cpuPHY = (cpuP1PhysicalVal + cpuP2PhysicalVal + cpuP3PhysicalVal + cpuP4PhysicalVal + cpuP5PhysicalVal) / 5;
            cpuREL = (cpuP1ReliableVal + cpuP2ReliableVal + cpuP3ReliableVal + cpuP4ReliableVal + cpuP5ReliableVal) / 5;
            cpuTAC = (cpuP1TackleVal + cpuP2TackleVal + cpuP3TackleVal + cpuP4TackleVal + cpuP5TackleVal) / 5;
            cpuAGG = (cpuP1AggroVal + cpuP2AggroVal + cpuP3AggroVal + cpuP4AggroVal + cpuP5AggroVal) / 5;
        }

        public int UserChanceGenerator()
        {
            userScoreChance = Convert.ToInt32(((0.6 * userSHO) + (0.5 * userPAC) + (0.3 * userDRI) + (0.1 * userPHY)) / 4); //loading the user attacking attribute stats into weighted average equation
            userScoreChance = userScoreChance - Convert.ToInt32(((0.5 * cpuTAC) + (0.4 * cpuPHY) + (0.2 * cpuAGG) + (0.2 * cpuREL)) / 4); //weighted average then found using CPU defensive attribute stats
            if (userAtHome == true)
            {
                userScoreChance = Convert.ToInt32(Convert.ToDouble(userScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            }
            
            else
            {
                userScoreChance = Convert.ToInt32(Convert.ToDouble(userScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            }
            return userScoreChance;
        }

        public int CPUChanceGenerator()
        {
            cpuScoreChance = Convert.ToInt32(((0.6 * cpuSHO) + (0.5 * cpuPAC) + (0.3 * cpuDRI) + (0.1 * cpuPHY)) / 4); //loading the CPU attacking attribute stats into weighted average equation
            cpuScoreChance = cpuScoreChance - Convert.ToInt32(((0.5 * userTAC) + (0.4 * userPHY) + (0.2 * userAGG) + (0.2 * userREL)) / 4); //weighted average then found using user defensive attribute stats
            if (userAtHome == false)
            {
                cpuScoreChance = Convert.ToInt32(Convert.ToDouble(cpuScoreChance) / 0.42857142857); //home adv. modifier = 3:7 ratio of A:H fans so we 3/7 as modifier
            }

            else
            {
                cpuScoreChance = Convert.ToInt32(Convert.ToDouble(cpuScoreChance) / 2.33333333333); //away disadv. modifier = 7:3 ratio of H:A fans so we use 7/3 as modifier
            }
            return cpuScoreChance;
        }

        public void ScoreGoalCheck()
        {
            Random random = new Random();
            int rollUserProbabilities = random.Next(0, 100);
            int rollCPUProbabilities = random.Next(0, 100);
            if (rollUserProbabilities <= userScoreChance)
            {
                UserScoreGoal();   
            }
            if (rollCPUProbabilities <= cpuScoreChance)
            {
                CPUScoreGoal();
            }
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

        private void matchTimer_Tick(object sender, EventArgs e)
        {
           if (matchEnded == false)
           {
                TimerLabel.Text = Convert.ToString(gameClockIncrementer + 5) + "'";
                gameClockIncrementer += 5;
                ScoreGoalCheck();
                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    string matchEndMsg = "The Match has ended, the game finished " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                }
            }
        }
    }
}
