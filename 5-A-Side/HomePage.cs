using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_A_Side
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            UserHasTeam();
        }

        public void UserHasTeam()
        {
            if (LoginMenu.TeamID == 0) //Checking if user account has a team associated with it
            {
                displayTopScorersButton.Visible = false;
                playNextMatchButton.Visible = false;
                teamDisplayButton.Visible = false;
                teamInputButton.Visible = true;
                displayTopScorersButton.Enabled = false;
                playNextMatchButton.Enabled = false;
                teamDisplayButton.Enabled = false;
                teamInputButton.Enabled = true;
            }
            else //if user account does have a team associated
            {
                displayTopScorersButton.Visible = true;
                playNextMatchButton.Visible = true;
                teamDisplayButton.Visible = true;
                teamInputButton.Visible = false;
                displayTopScorersButton.Enabled = true;
                playNextMatchButton.Enabled = true;
                teamDisplayButton.Enabled = true;
                teamInputButton.Enabled = false;
            }
        }

        private void displayTopScorersButton_Click(object sender, EventArgs e)
        {

        }

        private void playNextMatchButton_Click(object sender, EventArgs e)
        {
            MatchViewer nextMatch = new MatchViewer();
            nextMatch.Show();
            this.Close();
        }

        private void teamDisplayButton_Click(object sender, EventArgs e)
        {
            TeamDisplay teamDisplay = new TeamDisplay();
            teamDisplay.Show();
            this.Close();
        }

        private void teamInputButton_Click(object sender, EventArgs e)
        {
            playerInputForm teamInput = new playerInputForm();
            teamInput.Show();
        }
    }
}
