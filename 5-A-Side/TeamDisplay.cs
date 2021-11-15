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

    public partial class TeamDisplay : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tomra\OneDrive\Documents\FootballGame.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();

        public TeamDisplay()
        {
            InitializeComponent();
            LoadTeam();
        }

        public void LoadTeam()
        {
            Con.Open();
            Com.CommandText = "Select * from Players where TeamID = " + LoginMenu.TeamID;
            Com.Connection = Con;
            SqlDataReader reader = Com.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(reader["PlayerType"]) == 1)
                {
                    //captain loading
                    captainName.Text = Convert.ToString(reader["Name"]);
                    captainShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    captainSHO.Text = Convert.ToString(reader["Shooting"]);
                    captainDRI.Text = Convert.ToString(reader["Dribbling"]);
                    captainPAC.Text = Convert.ToString(reader["Pace"]);
                    captainPHY.Text = Convert.ToString(reader["Physicality"]);
                    captainREL.Text = Convert.ToString(reader["Reliability"]);
                    captainTAC.Text = Convert.ToString(reader["Tackling"]);
                    captainAGG.Text = Convert.ToString(reader["Aggression"]);
                }

                else if(Convert.ToInt32(reader["PlayerType"]) == 2)
                {
                    p2Name.Text = Convert.ToString(reader["Name"]);
                    p2ShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    p2SHO.Text = Convert.ToString(reader["Shooting"]);
                    p2DRI.Text = Convert.ToString(reader["Dribbling"]);
                    p2PAC.Text = Convert.ToString(reader["Pace"]);
                    p2PHY.Text = Convert.ToString(reader["Physicality"]);
                    p2REL.Text = Convert.ToString(reader["Reliability"]);
                    p2TAC.Text = Convert.ToString(reader["Tackling"]);
                    p2AGG.Text = Convert.ToString(reader["Aggression"]);
                }

                else if (Convert.ToInt32(reader["PlayerType"]) == 3)
                {
                    p3Name.Text = Convert.ToString(reader["Name"]);
                    p3ShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    p3SHO.Text = Convert.ToString(reader["Shooting"]);
                    p3DRI.Text = Convert.ToString(reader["Dribbling"]);
                    p3PAC.Text = Convert.ToString(reader["Pace"]);
                    p3PHY.Text = Convert.ToString(reader["Physicality"]);
                    p3REL.Text = Convert.ToString(reader["Reliability"]);
                    p3TAC.Text = Convert.ToString(reader["Tackling"]);
                    p3AGG.Text = Convert.ToString(reader["Aggression"]);
                }

                else if (Convert.ToInt32(reader["PlayerType"]) == 4)
                {
                    p4Name.Text = Convert.ToString(reader["Name"]);
                    p4ShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    p4SHO.Text = Convert.ToString(reader["Shooting"]);
                    p4DRI.Text = Convert.ToString(reader["Dribbling"]);
                    p4PAC.Text = Convert.ToString(reader["Pace"]);
                    p4PHY.Text = Convert.ToString(reader["Physicality"]);
                    p4REL.Text = Convert.ToString(reader["Reliability"]);
                    p4TAC.Text = Convert.ToString(reader["Tackling"]);
                    p4AGG.Text = Convert.ToString(reader["Aggression"]);
                }

                else if (Convert.ToInt32(reader["PlayerType"]) == 5)
                {
                    p5Name.Text = Convert.ToString(reader["Name"]);
                    p5ShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    p5SHO.Text = Convert.ToString(reader["Shooting"]);
                    p5DRI.Text = Convert.ToString(reader["Dribbling"]);
                    p5PAC.Text = Convert.ToString(reader["Pace"]);
                    p5PHY.Text = Convert.ToString(reader["Physicality"]);
                    p5REL.Text = Convert.ToString(reader["Reliability"]);
                    p5TAC.Text = Convert.ToString(reader["Tackling"]);
                    p5AGG.Text = Convert.ToString(reader["Aggression"]);
                }

                else if(Convert.ToInt32(reader["PlayerType"]) == 6)
                {
                    //substitute loading
                    subName.Text = Convert.ToString(reader["Name"]);
                    subShirtNum.Text = Convert.ToString(reader["ShirtNum"]);
                    subSHO.Text = Convert.ToString(reader["Shooting"]);
                    subDRI.Text = Convert.ToString(reader["Dribbling"]);
                    subPAC.Text = Convert.ToString(reader["Pace"]);
                    subPHY.Text = Convert.ToString(reader["Physicality"]);
                    subREL.Text = Convert.ToString(reader["Reliability"]);
                    subTAC.Text = Convert.ToString(reader["Tackling"]);
                    subAGG.Text = Convert.ToString(reader["Aggression"]);
                }  
            }
            reader.Close();
            //loading teamname and manager
            Com.CommandText = "Select * from Teams Where Id = " + LoginMenu.TeamID;
            Com.Connection = Con;
            reader = Com.ExecuteReader();
            reader.Read();
            teamNameLabel.Text = Sql.Select("Select * from Teams Where Id = ", 0, "TeamName", true, LoginMenu.TeamID);
            managerNameLabel.Text = Sql.Select("Select * from Teams Where Id = ", 0, "Manager", true, LoginMenu.TeamID);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
