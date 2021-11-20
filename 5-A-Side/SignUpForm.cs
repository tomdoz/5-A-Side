using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;

namespace _5_A_Side
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (Utilities.InputChecking(PWTxt.Text, 8, 1) || Utilities.InputChecking(userNameTxt.Text, 8, 0) == false)
            {
                string message = "Username or Password do not meet requirements. 8 characters are needed for both, and the password needs a number in it";
                string title = "Error!";
                MessageBox.Show(message, title);
            }
            else
            {
                string query = "insert into UserTable (Username, Password, Name, TeamID, currFixtureID, UserPoints , UserWins , UserDraws , UserLosses , UserGF , UserGA , UserMatches , MUPoints , MUWins , MUDraws , MULosses , MUGF , MUGA , MUMatches , CHEPoints , CHEWins , CHEDraws , CHELosses , CHEGF , CHEGA , CHEMatches , WOLPoints , WOLWins , WOLDraws , WOLLosses , WOLGF , WOLGA , WOLMatches , SOUPoints , SOUWins , SOUDraws , SOULosses , SOUGF , SOUGA , SOUMatches , NORPoints , NORWins , NORDraws , NORLosses , NORGF , NORGA , NORMatches) values('" + userNameTxt.Text + "', '" + Utilities.hashPassword(PWTxt.Text) + "', '" + nameTxt.Text + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "')";
                Sql.Insert(query);
                LoginMenu login = new LoginMenu();
                login.Show();
                this.Close();
            }
        }
    }
}
