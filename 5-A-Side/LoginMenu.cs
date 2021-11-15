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

    public partial class LoginMenu : Form
    {
        public bool loginDetailsCorrect = false;
        public static int UserID;
        public static int TeamID;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();

        public LoginMenu()
        {
            InitializeComponent();
            Con.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int UsersCount = Sql.CountRows("UserTable");
            for (int i = 0; i < UsersCount; i++)
            {
                string readerUsernameVal = Sql.Select("Select * from UserTable", i, "Username", false, 0);
                string readerPasswordVal = Sql.Select("Select * from UserTable", i, "Password", false, 0);
                if (userTxt.Text == readerUsernameVal && Utilities.hashPassword(passwordTxt.Text) == readerPasswordVal)
                {
                    loginDetailsCorrect = true;
                    UserID = Convert.ToInt32(Sql.Select("Select * from UserTable", i, "Id", false, 0));
                    TeamID = Convert.ToInt32(Sql.Select("Select * from UserTable", i, "TeamID", false, 0));
                }
            }

            if (loginDetailsCorrect == true)
            {
                MessageBox.Show("Enjoy the time playing!", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePage home = new HomePage();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong/missing credentials. Try again.", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
