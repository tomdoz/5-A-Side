//Class used to allow the user to create a new account the first time they open the program.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _5_A_Side
{
    public partial class SignUpForm : Form
    {
        SqlCommand Com = new SqlCommand();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void signUpButton_Click(object sender, EventArgs e)
        {
            //If the Password, Username or Name input don't meet the requirements for length or numbers, don't create the account
            if (Utilities.InputChecking(PWTxt.Text, 8, 50, 1) == false || Utilities.InputChecking(userNameTxt.Text, 8, 50, 0) == false || Utilities.InputChecking(nameTxt.Text, 8, 50, 0) == false)
            {
                //Displays suitable messagebox to inform user of this
                string message = "Name, Username or Password do not meet requirements. 8 characters are needed for all three, and the password needs a number in it";
                string title = "Error!";
                MessageBox.Show(message, title);
            }
            //if the inputs do meet the requirements, check if the username has already been used in a different user account
            else
            {   if (Utilities.Duplicate(userNameTxt.Text, "UserTable", "Username") == true) //if it is a duplicate, don't create the account
                {
                    //Displays a suitable messagebox to inform user of this
                    string message = "The username you have requested is already taken, please use a different one";
                    string title = "Error: Username taken!";
                    MessageBox.Show(message, title);
                }
                else
                {
                    //if all conditions are met, insert the relevant inputs into the UserTable, creating a new record
                    Con.Open();
                    Com.Connection = Con;
                    Com.CommandText = "insert into UserTable (Username, Password, Name, TeamID, currFixtureID, UserPoints , UserGF , UserGA , UserMatches , MUPoints , MUGF , MUGA , MUMatches , CHEPoints , CHEGF , CHEGA , CHEMatches , WOLPoints , WOLGF , WOLGA , WOLMatches , SOUPoints , SOUGF , SOUGA , SOUMatches , NORPoints , NORGF , NORGA , NORMatches) values(@Username, @Password, @Name, '" + 0 + "', '" + 1 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "')";
                    Com.Parameters.AddWithValue("@Username", userNameTxt.Text);
                    Com.Parameters.AddWithValue("@Password", Utilities.hashPassword(PWTxt.Text));
                    Com.Parameters.AddWithValue("@Name", nameTxt.Text);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    LoginMenu login = new LoginMenu(); //open a new loginMenu form
                    login.Show();
                    this.Close(); //close signUpForm
                }
            }
        }


    }
}
