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
            if (Utilities.InputChecking(PWTxt.Text, 8, 1, 50) == false || Utilities.InputChecking(userNameTxt.Text, 8, 0, 50) == false || Utilities.InputChecking(nameTxt.Text, 8, 0, 50) == false)
            {
                string message = "Name, Username or Password do not meet requirements. 8 characters are needed for all three, and the password needs a number in it";
                string title = "Error!";
                MessageBox.Show(message, title);
            }
            else
            {   if (Utilities.Duplicate(userNameTxt.Text, "UserTable", "Username") == true)
                {
                    string message = "The username you have requested is already taken, please use a different one";
                    string title = "Error: Username taken!";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string query = "insert into UserTable (Username, Password, Name, TeamID, currFixtureID, UserPoints , UserGF , UserGA , UserMatches , MUPoints , MUGF , MUGA , MUMatches , CHEPoints , CHEGF , CHEGA , CHEMatches , WOLPoints , WOLGF , WOLGA , WOLMatches , SOUPoints , SOUGF , SOUGA , SOUMatches , NORPoints , NORGF , NORGA , NORMatches) values('" + userNameTxt.Text + "', '" + Utilities.hashPassword(PWTxt.Text) + "', '" + nameTxt.Text + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "')";
                    Sql.Insert(query);
                    LoginMenu login = new LoginMenu();
                    login.Show();
                    this.Close();
                }
            }
        }


    }
}
