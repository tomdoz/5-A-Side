//This class acts as the backbone of the program, with most of the functionality of the prorgram being launched from it. The user, navigates through this form to open the playerInputForm, TeamDisplay, MatchViewer, TopScorers and LeagueTable. The user can also logout of their account.
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
            UserHasTeam(); //checking if the user has a team
            GetNextGameweek(); //setting the next the next gameweek (next match to be played) e.g. if teams have played 2 matches next gameweek is 3
            DisplayUserName();
        }

        public void DisplayUserName()
        {
            usernameLabel.Text = Sql.Select("Select * From UserTable Where Id = " + LoginMenu.UserID, 0, "Username");
        }


        public void UserHasTeam()
        {
            if (LoginMenu.TeamID == 0) //Checking if user account hasn't got a team associated with it
            {
                //hide and disable the buttons that should not be accessible if the user has no team
                displayTopScorersButton.Visible = false;
                playNextMatchButton.Visible = false;
                teamDisplayButton.Visible = false;
                displayTopScorersButton.Enabled = false;
                playNextMatchButton.Enabled = false;
                teamDisplayButton.Enabled = false;
                nextGameweek.Visible = false;
                resetButton.Visible = false;
                resetButton.Enabled = false;
                //show and enable button needed to create team
                teamInputButton.Visible = true;
                teamInputButton.Enabled = true;
                //hide and disable button to view league table at end of season
                showLeagueTable.Visible = false;
                showLeagueTable.Enabled = false;
            }
            else //if user account does have a team associated
            {
                //show and enable buttons accessible when user has a team
                displayTopScorersButton.Visible = true;
                playNextMatchButton.Visible = true;
                teamDisplayButton.Visible = true;
                displayTopScorersButton.Enabled = true;
                nextGameweek.Visible = true;
                playNextMatchButton.Enabled = true;
                teamDisplayButton.Enabled = true;
                resetButton.Visible = true;
                resetButton.Enabled = true;
                //hide disable button to create team as user already has one
                teamInputButton.Visible = false;
                teamInputButton.Enabled = false;
                //hide and disable button to view league table at end of season
                showLeagueTable.Visible = false;
                showLeagueTable.Enabled = false;
            }
        }

        private void displayTopScorersButton_Click(object sender, EventArgs e)
        {
            //when this button clicked, open topScorers form, and close current form
            TopScorers top = new TopScorers();
            top.Show();
            this.Close();
        }

        private void playNextMatchButton_Click(object sender, EventArgs e)
        {
            //when this button clicked, open matchviewer form, and close current form
            MatchViewer nextMatch = new MatchViewer();
            nextMatch.Show();
            this.Close();
        }

        private void teamDisplayButton_Click(object sender, EventArgs e)
        {
            //when this button clicked, open teamDisplay form, and close current form
            TeamDisplay teamDisplay = new TeamDisplay();
            teamDisplay.Show();
            this.Close();
        }

        private void teamInputButton_Click(object sender, EventArgs e)
        {
            //when this button clicked, open playerInput form, and close current form
            playerInputForm teamInput = new playerInputForm();
            teamInput.Show();
        }

        public void GetNextGameweek()
        {
            int nextGameweekVal = Convert.ToInt32(Sql.Select("Select UserMatches from UserTable where Id = " + LoginMenu.UserID.ToString(), 0, "UserMatches")); //assign the value stored in the selected record in the NumMatches column
            nextGameweekVal++; //increment this value, so it is the NEXT gameweek
            if (nextGameweekVal == 11) //if this value is 11, then the season has ended, so change the label to display that
            {
                nextGameweek.Text = "Season has ended!";
                SeasonEnded(); 
            }
            else
            {
                nextGameweek.Text = "Next gameweek: " + Convert.ToInt32(nextGameweekVal); //if the season hasn't ended, change the label to show the next gameweek
            }
        }

        public void SeasonEnded()
        {
            //if season has ended user is now able to view the final league table
            showLeagueTable.Visible = true;
            showLeagueTable.Enabled = true;
            //user is no longer able to play the next match as all the matches have finished
            playNextMatchButton.Visible = false;
            playNextMatchButton.Enabled = false;


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //user can choose to reset their progress in a season and start again
            Sql.Update("Update UserTable SET UserGF = " + 0.ToString() + ", CurrFixtureID = " + 1 + ", UserGA = " + 0.ToString() + ", UserPoints = " + 0.ToString() + ", UserMatches = " + 0.ToString() + ",  MUGF = " + 0.ToString() + ", MUGA = " + 0.ToString() + ", MUPoints = " + 0.ToString() + ", MUMatches = " + 0.ToString() + ", CHEGF = " + 0.ToString() + ", CHEGA = " + 0.ToString() + ", CHEPoints = " + 0.ToString() + ", CHEMatches = " + 0.ToString() + ", WOLGF = " + 0.ToString() + ", WOLGA = " + 0.ToString() + ", WOLPoints = " + 0.ToString() + ", WOLMatches = " + 0.ToString() + ", SOUGF = " + 0.ToString() + ", SOUGA = " + 0.ToString() + ", SOUPoints = " + 0.ToString() + ", SOUMatches = " + 0.ToString() + ", NORGF = " + 0.ToString() + ", NORGA = " + 0.ToString().ToString() + ", NORPoints = " + 0.ToString().ToString() + ", NORMatches = " + 0.ToString().ToString());
            Sql.Update("Update Teams SET GF = " + 0.ToString());
            //notifying the user that this was successful
            MessageBox.Show("All league table data is cleared, and the current matchweek has been reset to the first round of fixtures!", "Success!");
            GetNextGameweek(); //updating the current gameweek so it reflects that the season has been reset
            UserHasTeam(); 
        }

        private void showLeagueTable_Click(object sender, EventArgs e)
        {
            //when button clicked, open LeagueTable form, close current form
            LeagueTable league = new LeagueTable();
            league.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginMenu login = new LoginMenu();
            login.Show();
            this.Close();
        }
    }
}
