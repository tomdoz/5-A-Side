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
            string query = "insert into UserTable (Username, Password, Name, TeamID, currFixtureID, UserPoints , UserWins , UserDraws , UserLosses , UserGF , UserGA , UserMatches , MUPoints , MUWins , MUDraws , MULosses , MUGF , MUGA , MUMatches , CHEPoints , CHEWins , CHEDraws , CHELosses , CHEGF , CHEGA , CHEMatches , WOLPoints , WOLWins , WOLDraws , WOLLosses , WOLGF , WOLGA , WOLMatches , SOUPoints , SOUWins , SOUDraws , SOULosses , SOUGF , SOUGA , SOUMatches , NORPoints , NORWins , NORDraws , NORLosses , NORGF , NORGA , NORMatches) values('" + userNameTxt.Text + "', '" + Utilities.hashPassword(PWTxt.Text) + "', '" + nameTxt.Text + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "')";
            Sql.Insert(query);
            LoginMenu login = new LoginMenu();
            login.Show();
            this.Close();
        }
    }
}
