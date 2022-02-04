//The first UI seen by the user when the program opens, allowing the user to choose whether they would like to login or sign up depending on whether they already have an account or not
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm(); //Open a new instance of the sign up form
            signUp.Show();
            this.Hide(); //Close this form
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginMenu login = new LoginMenu(); //Open new instance of the login form
            login.Show();
            this.Hide(); //Close this form
        }
    }
}
