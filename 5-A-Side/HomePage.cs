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

namespace _5_A_Side
{
    public partial class HomePage : Form
    {
        //declaring connection string
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();

        public HomePage()
        {
            InitializeComponent();
            UserHasTeam(); //checking if the user has a team
            GetNextGameweek(); //setting the next the next gameweek (next match to be played) e.g. if teams have played 2 matches next gameweek is 3
            
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
            Con.Open(); //open the connection to the database
            Com.CommandText = "Select UserMatches from UserTable where Id = " + LoginMenu.UserID; //select the number of matches the user has played
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read(); //read the selected data
            int nextGameweekVal = Convert.ToInt32(reader["UserMatches"]); //assign the value stored in the selected record in the NumMatches column
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
            reader.Close(); //close the reader
            Con.Close(); //close the connection
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
            Con.Open(); //open connection to the DB
            Com.CommandText = "Update UserTable SET UserGF = " + 0 + ", UserGA = " + 0 + ", UserPoints = " + 0 + ", UserMatches = " + 0 + ",  MUGF = " + 0 + ", MUGA = " + 0 + ", MUPoints = " + 0 + ", MUMatches = " + 0 + ", CHEGF = " + 0 + ", CHEGA = " + 0 + ", CHEPoints = " + 0 + ", CHEMatches = " + 0 + ", WOLGF = " + 0 + ", WOLGA = " + 0 + ", WOLPoints = " + 0 + ", WOLMatches = " + 0 + ", SOUGF = " + 0 + ", SOUGA = " + 0 + ", SOUPoints = " + 0 + ", SOUMatches = " + 0 + ", NORGF = " + 0 + ", NORGA = " + 0 + ", NORPoints = " + 0 + ", NORMatches = " + 0; //update all records in the Teams table, to have 0 in all the columns that allow progress
            Com.Connection = Con;
            Com.ExecuteNonQuery(); //executes this command
            Com.CommandText = "Update UserTable SET CurrFixtureID = " + 1 + " WHERE Id = " + LoginMenu.UserID; //updates the current fixture ID in the current user's account record to be 0, so when a match is next played the season is started again
            Com.Connection = Con;
            Com.ExecuteNonQuery(); //executes the command
            Com.CommandText = "Update Teams SET GF = " + 0;
            Com.Connection = Con;
            Com.ExecuteNonQuery();
            Con.Close(); //closes the connection
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
    }
}
