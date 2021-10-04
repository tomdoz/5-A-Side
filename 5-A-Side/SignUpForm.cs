﻿using System;
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

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.SimulationFootballDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTable (Username, Password, Name) VALUES (@Username, @Password, @Name)", connection);
                cmd.Connection = connection;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50);
                cmd.Parameters["@Username"].Value = userNameTxt.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                cmd.Parameters["@Password"].Value = PWTxt.Text;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                cmd.Parameters["@Name"].Value = textBox1.Text;
                connection.Open();
                MessageBox.Show(Convert.ToString(cmd.ExecuteNonQuery()), "Siuuu");
                connection.Close();
            }

            //this.Close();
        }

        private void testReadButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.SimulationFootballDBConnectionString))
            {
                SqlDataReader dataReader;
                String Output = "";
                SqlCommand cmd = new SqlCommand("Select Id, Username from UserTable", connection);
                cmd.Connection = connection;
                connection.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
                }
                connection.Close();
                MessageBox.Show(Output);
            }
        }
    }
}