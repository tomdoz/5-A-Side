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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();

        public HomePage()
        {
            InitializeComponent();
            UserHasTeam();
            GetNextGameweek();
        }

        public void UserHasTeam()
        {
            if (LoginMenu.TeamID == 0) //Checking if user account hasn't got a team associated with it
            {
                displayTopScorersButton.Visible = false;
                playNextMatchButton.Visible = false;
                teamDisplayButton.Visible = false;
                teamInputButton.Visible = true;
                displayTopScorersButton.Enabled = false;
                playNextMatchButton.Enabled = false;
                teamDisplayButton.Enabled = false;
                teamInputButton.Enabled = true;
                nextGameweek.Visible = false;
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
                nextGameweek.Visible = true;
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

        public void GetNextGameweek()
        {
            Con.Open();
            Com.CommandText = "Select currFixtureID from UserTable where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            int nextGameweekVal = Convert.ToInt32(reader["currFixtureID"]);
            int nextGameweekDenominator = nextGameweekVal / 3;
            nextGameweekVal = nextGameweekVal - (2 * nextGameweekDenominator);
            nextGameweek.Text = "Next gameweek: " + Convert.ToInt32(nextGameweekVal);
            Con.Close();
        }

        private void resetIconButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            Com.CommandText = "Update Teams SET Wins = " + 0 + ", Draws = " + 0 + ", Losses = " + 0 + ", GF = " + 0 + ", GA = " + 0 + ", Points = " + 0 + ", NumMatches = " + 0;
            Com.Connection = Con;
            Com.ExecuteNonQuery();
            Com.CommandText = "Update UserTable SET CurrFixtureID = " + 1;
            Com.Connection = Con;
            Com.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("All league table data is cleared, and the current matchweek has been reset to the first round of fixtures!", "Success!");
            GetNextGameweek();
        }
    }
}
