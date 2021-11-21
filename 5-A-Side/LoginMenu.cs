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

        public LoginMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int UsersCount = Sql.CountRows("UserTable");
            for (int i = 0; i < UsersCount; i++)
            {
                string readerUsernameVal = Sql.Select("Select * from UserTable", i, "Username");
                string readerPasswordVal = Sql.Select("Select * from UserTable", i, "Password");
                if (userTxt.Text == readerUsernameVal && Utilities.hashPassword(passwordTxt.Text) == readerPasswordVal)
                {
                    loginDetailsCorrect = true;
                    UserID = Convert.ToInt32(Sql.Select("Select * from UserTable", i, "Id"));
                    TeamID = Convert.ToInt32(Sql.Select("Select * from UserTable", i, "TeamID"));
                }
            }

            if (loginDetailsCorrect == true)
            {
                if (Sql.Select("Select * From Teams Where Id = " + TeamID, 0, "GF") == "0")
                {
                    Sql.Update("Update Teams Set GF = 0");
                }
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
