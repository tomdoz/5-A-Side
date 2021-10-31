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
            Con.Open();
            Com.Connection = Con;
            Com.CommandText = "select * from UserTable";
            SqlDataReader reader = Com.ExecuteReader();
            while(reader.Read())
            {
                string readerUsernameVal = (reader["Username"].ToString());
                string readerPasswordVal = (reader["Password"].ToString());
                if (userTxt.Text == readerUsernameVal && Utilities.hashPassword(passwordTxt.Text) == readerPasswordVal)
                {
                    loginDetailsCorrect = true;
                    UserID = Convert.ToInt32(reader["Id"]);
                    TeamID = Convert.ToInt32(reader["TeamID"]);
                }
            }

            if (loginDetailsCorrect == true)
            {
                MessageBox.Show("Enjoy the time playing!", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePage home = new HomePage();
                Con.Close();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong/missing credentials. Try again.", "Login unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
        }
    }
}
