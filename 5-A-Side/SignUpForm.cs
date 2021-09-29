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
        SqlDataAdapter dataAdapt;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.FiveAsideDBConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[User] (Username) VALUES (@Username)", connection);
                cmd.Connection = connection;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar);
                cmd.Parameters["@Username"].Value = userNameTxt.Text;
                MessageBox.Show(Convert.ToString(cmd.ExecuteNonQuery()), "Siuuu");
            }
            //this.Close();
        }
    }
}
