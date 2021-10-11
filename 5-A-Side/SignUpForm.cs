using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _5_A_Side
{
    public partial class SignUpForm : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UserTable (Username, Password, Name, TeamID) values('" + userNameTxt.Text + "', '" + PWTxt.Text + "', '" + nameTxt.Text + "', '" + 0 + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            LoginMenu login = new LoginMenu();
            login.Show();
            this.Close();
        }
    }
}
