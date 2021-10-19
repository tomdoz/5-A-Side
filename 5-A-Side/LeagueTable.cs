using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _5_A_Side
{
    public partial class LeagueTable : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30"); 
        SqlCommand Com = new SqlCommand();
        int[] PointTotals = new int[6];

        public LeagueTable()
        {
            InitializeComponent();
            OrderTeams();
            FillRow(1);
            FillRow(2);
            FillRow(3);
            FillRow(4);
            FillRow(5);
            FillRow(6);
        }

        public void OrderTeams()
        {
            int[] PointsToSort = new int[6];
            Con.Open();
            Com.CommandText = "Select * From UserTable Where Id = " + LoginMenu.UserID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            reader.Read();
            for (int i = 0; i < PointsToSort.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        PointsToSort[i] = Convert.ToInt32(reader["UserPoints"]);
                        break;

                    case 1:
                        PointsToSort[i] = Convert.ToInt32(reader["MUPoints"]);
                        break;

                    case 2:
                        PointsToSort[i] = Convert.ToInt32(reader["CHEPoints"]);
                        break;

                    case 3:
                        PointsToSort[i] = Convert.ToInt32(reader["SOUPoints"]);
                        break;

                    case 4:
                        PointsToSort[i] = Convert.ToInt32(reader["WOLPoints"]);
                        break;

                    case 5:
                        PointsToSort[i] = Convert.ToInt32(reader["NORPoints"]);
                        break;
                }
                PointTotals = Utilities.mergeSort(PointsToSort);
            }
        }

        public void FillRow(int Rank)
        {
            switch (Rank)
            {
                case 1:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    SqlDataReader reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team1.Text = Convert.ToString(reader["TeamName"]);
                    wins1.Text = Convert.ToString(reader["Wins"]);
                    draws1.Text = Convert.ToString(reader["Losses"]);
                    losses1.Text = Convert.ToString(reader["Draws"]);
                    points1.Text = Convert.ToString(reader["Points"]);
                    GD1.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches1.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;

                case 2:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team2.Text = Convert.ToString(reader["TeamName"]);
                    wins2.Text = Convert.ToString(reader["Wins"]);
                    draws2.Text = Convert.ToString(reader["Losses"]);
                    losses2.Text = Convert.ToString(reader["Draws"]);
                    points2.Text = Convert.ToString(reader["Points"]);
                    GD2.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches2.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;

                case 3:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team3.Text = Convert.ToString(reader["TeamName"]);
                    wins3.Text = Convert.ToString(reader["Wins"]);
                    draws3.Text = Convert.ToString(reader["Losses"]);
                    losses3.Text = Convert.ToString(reader["Draws"]);
                    points3.Text = Convert.ToString(reader["Points"]);
                    GD3.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches3.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;

                case 4:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team4.Text = Convert.ToString(reader["TeamName"]);
                    wins4.Text = Convert.ToString(reader["Wins"]);
                    draws4.Text = Convert.ToString(reader["Losses"]);
                    losses4.Text = Convert.ToString(reader["Draws"]);
                    points4.Text = Convert.ToString(reader["Points"]);
                    GD4.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches4.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;

                case 5:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team5.Text = Convert.ToString(reader["TeamName"]);
                    wins5.Text = Convert.ToString(reader["Wins"]);
                    draws5.Text = Convert.ToString(reader["Losses"]);
                    losses5.Text = Convert.ToString(reader["Draws"]);
                    points5.Text = Convert.ToString(reader["Points"]);
                    GD5.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches5.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;

                case 6:
                    Con.Open();
                    Com.CommandText = "SELECT * FROM TEAMS ORDER BY Points Desc";
                    Com.Connection = Con;
                    reader = Com.ExecuteReader();
                    for (int i = 0; i < Rank; i++)
                    {
                        reader.Read();
                    }
                    team6.Text = Convert.ToString(reader["TeamName"]);
                    wins6.Text = Convert.ToString(reader["Wins"]);
                    draws6.Text = Convert.ToString(reader["Losses"]);
                    losses6.Text = Convert.ToString(reader["Draws"]);
                    points6.Text = Convert.ToString(reader["Points"]);
                    GD6.Text = Convert.ToString((Convert.ToInt32(reader["GF"]) - Convert.ToInt32(reader["GA"])));
                    matches6.Text = Convert.ToString(reader["NumMatches"]);
                    reader.Close();
                    Con.Close();
                    break;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
