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
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataAdapter dataAdapt;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=F:\a levels\PROJ\newTomdoz\5 - A - Side\5 - A - Side\FiveAsideDB.mdf;Integrated Security=True");
            cn.Open();
            cmd = new SqlCommand("INSERT INTO [User] (Username, Password, Name) " + "VALUES (@Username ,@Password ,@Name)", cn);
            cmd.Parameters.AddWithValue("@Username", userNameTxt.Text);
            cmd.Parameters.AddWithValue("@Password", PWTxt.Text);
            cmd.Parameters.AddWithValue("@Name", firstName.Text);
            cmd.ExecuteNonQuery();
            //playerInputForm inputTeam = new playerInputForm();
            //inputTeam.Show();
           this.Close();
        }
    }
}
