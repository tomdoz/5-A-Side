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
    public partial class playerInputForm : Form
    {

        //captain attribute variables
        public int p1ShootingVal = 0;
        public int p1DribblingVal = 0;
        public int p1PaceVal = 0;
        public int p1PhysicalVal = 0;
        public int p1ReliableVal = 0;
        public int p1TackleVal = 0;
        public int p1AggroVal = 0;
        //player 2 attribute variables
        public int p2ShootingVal = 0;
        public int p2DribblingVal = 0;
        public int p2PaceVal = 0;
        public int p2PhysicalVal = 0;
        public int p2ReliableVal = 0;
        public int p2TackleVal = 0;
        public int p2AggroVal = 0;
        //player 3 attribute variables;
        public int p3ShootingVal = 0;
        public int p3DribblingVal = 0;
        public int p3PaceVal = 0;
        public int p3PhysicalVal = 0;
        public int p3ReliableVal = 0;
        public int p3TackleVal = 0;
        public int p3AggroVal = 0;
        //player 4 attribute variables;
        public int p4ShootingVal = 0;
        public int p4DribblingVal = 0;
        public int p4PaceVal = 0;
        public int p4PhysicalVal = 0;
        public int p4ReliableVal = 0;
        public int p4TackleVal = 0;
        public int p4AggroVal = 0;
        //player 5 attribute variables;
        public int p5ShootingVal = 0;
        public int p5DribblingVal = 0;
        public int p5PaceVal = 0;
        public int p5PhysicalVal = 0;
        public int p5ReliableVal = 0;
        public int p5TackleVal = 0;
        public int p5AggroVal = 0;
        //substitute attribute variables
        public int subShootingVal = 0;
        public int subDribblingVal = 0;
        public int subPaceVal = 0;
        public int subPhysicalVal = 0;
        public int subReliableVal = 0;
        public int subTackleVal = 0;
        public int subAggroVal = 0;
        public playerInputForm()
        {
            InitializeComponent();
        }

        private void sliderValueUpdater_Tick(object sender, EventArgs e)
        {
            //Updating captain current labels and remaining points
            currentShooting.Text = Convert.ToString(p1ShootingVal);
            currentDribbling.Text = Convert.ToString(p1DribblingVal);
            currentPhysical.Text = Convert.ToString(p1PhysicalVal);
            currentReliability.Text = Convert.ToString(p1ReliableVal);
            label1.Text = Convert.ToString(p1TackleVal);
            currentAgrression.Text = Convert.ToString(p1AggroVal);
            currentPace.Text = Convert.ToString(p1PaceVal);
            pointsRemainingNum.Text = Convert.ToString(500 - ShootingSlider.Value - dribblingSlider.Value - passingSlider.Value - physicalitySlider.Value - ReliableSlider.Value - aggressionSlider.Value - tackleSlider.Value);
            //CAPTAIN: if no skill points are remaining reset the sliders to 0
            if (Convert.ToInt32(pointsRemainingNum.Text) < 0)
            {
                ShootingSlider.Value = 0;
                dribblingSlider.Value = 0;
                passingSlider.Value = 0;
                physicalitySlider.Value = 0;
                ReliableSlider.Value = 0;
                tackleSlider.Value = 0;
                aggressionSlider.Value = 0;
                currentShooting.Text = "0";
                currentDribbling.Text = "0";
                currentPhysical.Text = "0";
                currentReliability.Text = "0";
                label1.Text = "0";
                currentAgrression.Text = "0";
                currentPace.Text = "0";
            }

            //PLAYER 2 SLIDER UPDATES
            p2CurrShooting.Text = Convert.ToString(p2ShootingVal);
            p2CurrDribbling.Text = Convert.ToString(p2DribblingVal);
            p2CurrPace.Text = Convert.ToString(p2PaceVal);
            p2CurrPhysical.Text = Convert.ToString(p2PhysicalVal);
            p2CurrAgression.Text = Convert.ToString(p2AggroVal);
            p2CurrReliable.Text = Convert.ToString(p2ReliableVal);
            p2CurrTackle.Text = Convert.ToString(p2TackleVal);
            p2PointsLeftLabel.Text = Convert.ToString(450 - p2ShootingSlider.Value - p2DribblingSlider.Value - p2PaceSlider.Value - p2PhysicalitySlider.Value - p2ReliableSlider.Value - p2TackleSlider.Value - p2AggressionSlider.Value);

            //player 2 skill point limit enforcement
            if (Convert.ToInt32(p2PointsLeftLabel.Text) < 0)
            {
                p2ShootingSlider.Value = 0;
                p2DribblingSlider.Value = 0;
                p2PaceSlider.Value = 0;
                p2PhysicalitySlider.Value = 0;
                p2ReliableSlider.Value = 0;
                p2TackleSlider.Value = 0;
                p2AggressionSlider.Value = 0;
                p2CurrShooting.Text = "0";
                p2CurrDribbling.Text = "0";
                p2CurrPace.Text = "0";
                p2CurrPhysical.Text = "0";
                p2CurrAgression.Text = "0";
                p2CurrReliable.Text = "0";
                p2CurrTackle.Text = "0";
            }

            //PLAYER 3 SLIDER UPDATES
            p3CurrShooting.Text = Convert.ToString(p3ShootingVal);
            p3CurrDribbling.Text = Convert.ToString(p3DribblingVal);
            p3CurrPace.Text = Convert.ToString(p3PaceVal);
            p3CurrPhysical.Text = Convert.ToString(p3PhysicalVal);
            p3CurrAggro.Text = Convert.ToString(p3AggroVal);
            p3CurrReliable.Text = Convert.ToString(p3ReliableVal);
            p3CurrTackle.Text = Convert.ToString(p3TackleVal);
            p3PointsRemaining.Text = Convert.ToString(450 - p3ShootingSlider.Value - p3DribblingSlider.Value - p3PaceSlider.Value - p3PhysicalSlider.Value - p3ReliableSlider.Value - p3TackleSlider.Value - p3AggroSlider.Value);

            //P3 no skill points remaining
            if (Convert.ToInt32(p3PointsRemaining.Text) < 0)
            {
                p3ShootingSlider.Value = 0;
                p3DribblingSlider.Value = 0;
                p3PaceSlider.Value = 0;
                p3PhysicalSlider.Value = 0;
                p3ReliableSlider.Value = 0;
                p3TackleSlider.Value = 0;
                p3AggroSlider.Value = 0;
                p3CurrShooting.Text = "0";
                p3CurrDribbling.Text = "0";
                p3CurrPace.Text = "0";
                p3CurrPhysical.Text = "0";
                p3CurrAggro.Text = "0";
                p3CurrReliable.Text = "0";
                p3CurrTackle.Text = "0";
            }

            //PLAYER 4 SLIDER UPDATES
            p4CurrShooting.Text = Convert.ToString(p4ShootingVal);
            p4CurrDribbling.Text = Convert.ToString(p4DribblingVal);
            p4CurrPace.Text = Convert.ToString(p4PaceVal);
            p4CurrPhysical.Text = Convert.ToString(p4PhysicalVal);
            p4CurrAggro.Text = Convert.ToString(p4AggroVal);
            p4CurrReliable.Text = Convert.ToString(p4ReliableVal);
            p4CurrTackle.Text = Convert.ToString(p4TackleVal);
            p4PointsRemaining.Text = Convert.ToString(450 - p4ShootingSlider.Value - p4DribblingSlider.Value - p4PaceSlider.Value - p4PhysicalSlider.Value - p4ReliableSlider.Value - p4TackleSlider.Value - p4AgrroSlider.Value);

            //P4 no skill points remaining
            if (Convert.ToInt32(p4PointsRemaining.Text) < 0)
            {
                p4ShootingSlider.Value = 0;
                p4DribblingSlider.Value = 0;
                p4PaceSlider.Value = 0;
                p4PhysicalSlider.Value = 0;
                p4ReliableSlider.Value = 0;
                p4TackleSlider.Value = 0;
                p4AgrroSlider.Value = 0;
                p4CurrShooting.Text = "0";
                p4CurrDribbling.Text = "0";
                p4CurrPace.Text = "0";
                p4CurrPhysical.Text = "0";
                p4CurrAggro.Text = "0";
                p4CurrReliable.Text = "0";
                p4CurrTackle.Text = "0";
            }

            //PLAYER 5 SLIDER UPDATES
            p5CurrShooting.Text = Convert.ToString(p5ShootingVal);
            p5CurrDribbling.Text = Convert.ToString(p5DribblingVal);
            p5CurrPace.Text = Convert.ToString(p5PaceVal);
            p5CurrPhysical.Text = Convert.ToString(p5PhysicalVal);
            p5CurrAggro.Text = Convert.ToString(p5AggroVal);
            p5CurrReliability.Text = Convert.ToString(p5ReliableVal);
            p5CurrTackle.Text = Convert.ToString(p5TackleVal);
            p5PointsRemaining.Text = Convert.ToString(450 - p5ShootingSlider.Value - p5DribblingSlider.Value - p5PaceSlider.Value - p5PhysicalitySlider.Value - p5ReliableSlider.Value - p5TackleSlider.Value - p5AggroSlider.Value);

            //P5 no skill points remaining
            if (Convert.ToInt32(p5PointsRemaining.Text) < 0)
            {
                p5ShootingSlider.Value = 0;
                p5DribblingSlider.Value = 0;
                p5PaceSlider.Value = 0;
                p5PhysicalitySlider.Value = 0; 
                p5ReliableSlider.Value = 0;
                p5TackleSlider.Value = 0;
                p5AggroSlider.Value = 0;
                p5CurrShooting.Text = "0";
                p5CurrDribbling.Text = "0";
                p5CurrPace.Text = "0";
                p5CurrPhysical.Text = "0";
                p5CurrAggro.Text = "0";
                p5CurrReliability.Text = "0";
                p5CurrTackle.Text = "0";
            }

            //SUB SLIDER UPDATES
            subCurrShooting.Text = Convert.ToString(subShootingVal);
            subCurrDribbling.Text = Convert.ToString(subDribblingVal);
            subCurrPace.Text = Convert.ToString(subPaceVal);
            subCurrPhysical.Text = Convert.ToString(subPhysicalVal);
            subCurrAggro.Text = Convert.ToString(subAggroVal);
            subCurrReliable.Text = Convert.ToString(subReliableVal);
            subCurrTackle.Text = Convert.ToString(subTackleVal);
            subPointsRemaining.Text = Convert.ToString(400 - subShootingSlider.Value - subDribblingSlider.Value - subPaceSlider.Value - subPhysicalSlider.Value - subReliableSlider.Value - subTackleSlider.Value - subAggroSlider.Value);

            //sub no skill points remaining
            if (Convert.ToInt32(subPointsRemaining.Text) < 0)
            {
                subShootingSlider.Value = 0;
                subDribblingSlider.Value = 0;
                subPaceSlider.Value = 0;
                subPhysicalSlider.Value = 0;
                subReliableSlider.Value = 0;
                subTackleSlider.Value = 0;
                subAggroSlider.Value = 0;
                subCurrShooting.Text = "0";
                subCurrDribbling.Text = "0";
                subCurrPace.Text = "0";
                subCurrPhysical.Text = "0";
                subCurrAggro.Text = "0";
                subCurrReliable.Text = "0";
                subCurrTackle.Text = "0";
            }
        }

        //for team captain
        private void ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p1ShootingVal = ShootingSlider.Value;
        }

        private void dribblingSlider_Scroll(object sender, EventArgs e)
        {
            p1DribblingVal = dribblingSlider.Value;
        }

        private void physicalitySlider_Scroll(object sender, EventArgs e)
        {
            p1PhysicalVal = physicalitySlider.Value;
        }

        private void ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p1ReliableVal = ReliableSlider.Value;
        }

        private void tackleSlider_Scroll(object sender, EventArgs e)
        {
            p1TackleVal = tackleSlider.Value;
        }

        private void aggressionSlider_Scroll(object sender, EventArgs e)
        {
            p1AggroVal = aggressionSlider.Value;
        }

        private void paceSlider_Scroll(object sender, EventArgs e)
        {
            p1PaceVal = passingSlider.Value;
        }

        //Player 2 Slider events
        private void p2ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p2ShootingVal = p2ShootingSlider.Value;
        }

        private void p2DribblingSlider_Scroll(object sender, EventArgs e)
        {
            p2DribblingVal = p2DribblingSlider.Value;
        }

        private void p2PaceSlider_Scroll(object sender, EventArgs e)
        {
            p2PaceVal = p2PaceSlider.Value;
        }

        private void p2PhysicalitySlider_Scroll(object sender, EventArgs e)
        {
            p2PhysicalVal = p2PhysicalitySlider.Value;
        }

        private void p2ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p2ReliableVal = p2ReliableSlider.Value;
        }

        private void p2TackleSlider_Scroll(object sender, EventArgs e)
        {
            p2TackleVal = p2TackleSlider.Value;
        }

        private void p2AggressionSlider_Scroll(object sender, EventArgs e)
        {
            p2AggroVal = p2AggressionSlider.Value;
        }

        //P3 Slider Events
        private void p3ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p3ShootingVal = p3ShootingSlider.Value;
        }

        private void p3DribblingSlider_Scroll(object sender, EventArgs e)
        {
            p3DribblingVal = p3DribblingSlider.Value;
        }

        private void p3PaceSlider_Scroll(object sender, EventArgs e)
        {
            p3PaceVal = p3PaceSlider.Value;
        }

        private void p3PhysicalSlider_Scroll(object sender, EventArgs e)
        {
            p3PhysicalVal = p3PhysicalSlider.Value;
        }

        private void p3ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p3ReliableVal = p3ReliableSlider.Value;
        }

        private void p3TackleSlider_Scroll(object sender, EventArgs e)
        {
            p3TackleVal = p3TackleSlider.Value;
        }

        private void p3AggroSlider_Scroll(object sender, EventArgs e)
        {
            p3AggroVal = p3AggroSlider.Value;
        }

        //PLAYER 4 SLIDER EVENTS
        private void p4ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p4ShootingVal = p4ShootingSlider.Value;
        }

        private void p4DribblingSlider_Scroll(object sender, EventArgs e)
        {
            p4DribblingVal = p4DribblingSlider.Value;
        }

        private void p4PaceSlider_Scroll(object sender, EventArgs e)
        {
            p4PaceVal = p4PaceSlider.Value;
        }

        private void p4PhysicalSlider_Scroll(object sender, EventArgs e)
        {
            p4PhysicalVal = p4PhysicalSlider.Value;
        }

        private void p4ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p4ReliableVal = p4ReliableSlider.Value;
        }

        private void p4TackleSlider_Scroll(object sender, EventArgs e)
        {
            p4TackleVal = p4TackleSlider.Value;
        }

        private void p4AgrroSlider_Scroll(object sender, EventArgs e)
        {
            p4AggroVal = p4AgrroSlider.Value;
        }

        //PLAYER 5 SLIDER EVENTS
        private void p5ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p5ShootingVal = p5ShootingSlider.Value;
        }

        private void p5DribblingSlider_Scroll(object sender, EventArgs e)
        {
            p5DribblingVal = p5DribblingSlider.Value;
        }

        private void p5PaceSlider_Scroll(object sender, EventArgs e)
        {
            p5PaceVal = p5PaceSlider.Value;
        }

        private void p5PhysicalitySlider_Scroll(object sender, EventArgs e)
        {
            p5PhysicalVal = p5PhysicalitySlider.Value;
        }

        private void p5ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p5ReliableVal = p5ReliableSlider.Value;
        }

        private void p5TackleSlider_Scroll(object sender, EventArgs e)
        {
            p5TackleVal = p5TackleSlider.Value;
        }

        private void p5AggroSlider_Scroll(object sender, EventArgs e)
        {
            p5AggroVal = p5AggroSlider.Value;
        }

        //SUB SLIDER EVENTS
        private void subShootingSlider_Scroll(object sender, EventArgs e)
        {
            subShootingVal = subShootingSlider.Value;
        }

        private void subDribblingSlider_Scroll(object sender, EventArgs e)
        {
            subDribblingVal = subDribblingSlider.Value;
        }

        private void subPaceSlider_Scroll(object sender, EventArgs e)
        {
            subPaceVal = subPaceSlider.Value;
        }

        private void subPhysicalSlider_Scroll(object sender, EventArgs e)
        {
            subPhysicalVal = subPhysicalSlider.Value;
        }

        private void subReliableSlider_Scroll(object sender, EventArgs e)
        {
            subReliableVal = subReliableSlider.Value;
        }

        private void subTackleSlider_Scroll(object sender, EventArgs e)
        {
            subTackleVal = subTackleSlider.Value;
        }

        private void subAggroSlider_Scroll(object sender, EventArgs e)
        {
            subAggroVal = subAggroSlider.Value;
        }

        private void submitTeamButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pointsRemainingNum.Text) == 0 && Convert.ToInt32(p2PointsLeftLabel.Text) == 0 && Convert.ToInt32(p3PointsRemaining.Text) == 0 && Convert.ToInt32(p4PointsRemaining.Text) == 0 && Convert.ToInt32(p5PointsRemaining.Text) == 0 && Convert.ToInt32(subPointsRemaining.Text) == 0)
            {
               CreateTeam();
               InsertToDB(p1ShootingVal, p1DribblingVal, p1PaceVal, p1PhysicalVal, p1ReliableVal, p1TackleVal, p1AggroVal, textBox1.Text, lastNameTXT.Text, Convert.ToInt32(shirtTxt.Text), LoginMenu.TeamID, 1);
               InsertToDB(p2ShootingVal, p2DribblingVal, p2PaceVal, p2PhysicalVal, p2ReliableVal, p2TackleVal, p2AggroVal, p2firstNameTxt.Text, p2lastNameTxt.Text, Convert.ToInt32(p2ShirtTxt.Text), LoginMenu.TeamID, 2);
               InsertToDB(p3ShootingVal, p3DribblingVal, p3PaceVal, p3PhysicalVal, p3ReliableVal, p3TackleVal, p3AggroVal, p3FirstNameTxt.Text, p3LastNameTxt.Text, Convert.ToInt32(p3ShirtTxt.Text), LoginMenu.TeamID, 3);
               InsertToDB(p4ShootingVal, p4DribblingVal, p4PaceVal, p4PhysicalVal, p4ReliableVal, p4TackleVal, p4AggroVal, p4FirstNameTxt.Text, p4LastNameTxt.Text, Convert.ToInt32(p4ShirtTxt.Text), LoginMenu.TeamID, 4);
               InsertToDB(p5ShootingVal, p5DribblingVal, p5PaceVal, p5PhysicalVal, p5ReliableVal, p5TackleVal, p5AggroVal, p5firstNameTxt.Text, p5LastNameTxt.Text, Convert.ToInt32(p5ShirtTxt.Text), LoginMenu.TeamID, 5);
               InsertToDB(subShootingVal, subDribblingVal, subPaceVal, subPhysicalVal, subReliableVal, subTackleVal, subAggroVal, subFirstNameTxt.Text, subLastNameTxt.Text, Convert.ToInt32(subShirtTxt.Text), LoginMenu.TeamID, 6);
               MessageBox.Show("Your team was inputted to the database, and your account is now ready to stsrt simulating games", "Team Creation Successful!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               HomePage home = new HomePage();
               home.Show();
               this.Close();
            }
            else
            {
                string message = "You need to use all the available skill points for each player!";
                string title = "Couldn't submit team";
                MessageBox.Show(message, title);
            }
        }

        private void InsertToDB(int Shooting, int Dribbling, int Pace, int Physicality, int Reliability, int Tackling, int Aggression, string FirstName, string LastName, int ShirtNum, int TeamID, int PlayerType)
        {
            Sql.Insert("insert into Players (Shooting, Dribbling, Pace, Physicality, Reliability, Tackling, Aggression, Name, ShirtNum, TeamID, PlayerType) values('" + Shooting + "', '" + Dribbling + "', '" + Pace + "', '" + Physicality + "', '" + Reliability + "', '" + Tackling + "', '" + Aggression + "', '" + (FirstName + " " + LastName) + "', '" + ShirtNum + "', '" + TeamID + "', '" + PlayerType + "')");
        }

        private void CreateTeam()
        {
            string NameVal = Sql.Select("Select Name from UserTable Where Id = " + LoginMenu.UserID, 0, "Name");
            Sql.Update("insert into Teams (TeamName, Manager, GF) values('" + teamNameTxt.Text + "', '" + NameVal + "', '" + 0 + "')");
            string TeamName;
            string Manager;
            for (int i = 0; i < Sql.Count("Teams"); i++)
            {
                TeamName = Sql.Select("Select * From Teams", i, "TeamName");
                Manager = Sql.Select("Select * From Teams", i, "Manager");
                if (TeamName == teamNameTxt.Text && Manager == NameVal)
                {
                    LoginMenu.TeamID = Convert.ToInt32(Sql.Select("Select * From Teams", i, "Id"));
                    break;
                }
            }
            Sql.Update("UPDATE UserTable SET TeamID = " + LoginMenu.TeamID + " WHERE Id = " + LoginMenu.UserID);
        }

    }
}
