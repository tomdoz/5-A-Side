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
            int[] capStats = Player.CollectStats(LoginMenu.TeamID, 1);
            captainSHO.Text = Convert.ToString(capStats[0]);
            captainDRI.Text = Convert.ToString(capStats[1]);
            captainPAC.Text = Convert.ToString(capStats[2]);
            captainPHY.Text = Convert.ToString(capStats[3]);
            captainREL.Text = Convert.ToString(capStats[4]);
            captainTAC.Text = Convert.ToString(capStats[5]);
            captainAGG.Text = Convert.ToString(capStats[6]);
            captainName.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 1);
            captainShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 1);

            int[] p2Stats = Player.CollectStats(LoginMenu.TeamID, 2);
            p2SHO.Text = Convert.ToString(p2Stats[0]);
            p2DRI.Text = Convert.ToString(p2Stats[1]);
            p2PAC.Text = Convert.ToString(p2Stats[2]);
            p2PHY.Text = Convert.ToString(p2Stats[3]);
            p2REL.Text = Convert.ToString(p2Stats[4]);
            p2TAC.Text = Convert.ToString(p2Stats[5]);
            p2AGG.Text = Convert.ToString(p2Stats[6]);
            p2Name.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 2);
            p2ShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 2);

            int[] p3Stats = Player.CollectStats(LoginMenu.TeamID, 3);
            p3SHO.Text = Convert.ToString(p3Stats[0]);
            p3DRI.Text = Convert.ToString(p3Stats[1]);
            p3PAC.Text = Convert.ToString(p3Stats[2]);
            p3PHY.Text = Convert.ToString(p3Stats[3]);
            p3REL.Text = Convert.ToString(p3Stats[4]);
            p3TAC.Text = Convert.ToString(p3Stats[5]);
            p3AGG.Text = Convert.ToString(p3Stats[6]);
            p3Name.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 3);
            p3ShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 3);

            int[] p4Stats = Player.CollectStats(LoginMenu.TeamID, 4);
            p4SHO.Text = Convert.ToString(p4Stats[0]);
            p4DRI.Text = Convert.ToString(p4Stats[1]);
            p4PAC.Text = Convert.ToString(p4Stats[2]);
            p4PHY.Text = Convert.ToString(p4Stats[3]);
            p4REL.Text = Convert.ToString(p4Stats[4]);
            p4TAC.Text = Convert.ToString(p4Stats[5]);
            p4AGG.Text = Convert.ToString(p4Stats[6]);
            p4Name.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 4);
            p4ShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 4);

            int[] p5Stats = Player.CollectStats(LoginMenu.TeamID, 5);
            p5SHO.Text = Convert.ToString(p5Stats[0]);
            p5DRI.Text = Convert.ToString(p5Stats[1]);
            p5PAC.Text = Convert.ToString(p5Stats[2]);
            p5PHY.Text = Convert.ToString(p5Stats[3]);
            p5REL.Text = Convert.ToString(p5Stats[4]);
            p5TAC.Text = Convert.ToString(p5Stats[5]);
            p5AGG.Text = Convert.ToString(p5Stats[6]);
            p5Name.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 5);
            p5ShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 5);

            int[] p6Stats = Player.CollectStats(LoginMenu.TeamID, 6);
            subSHO.Text = Convert.ToString(p6Stats[0]);
            subDRI.Text = Convert.ToString(p6Stats[1]);
            subPAC.Text = Convert.ToString(p6Stats[2]);
            subPHY.Text = Convert.ToString(p6Stats[3]);
            subREL.Text = Convert.ToString(p6Stats[4]);
            subTAC.Text = Convert.ToString(p6Stats[5]);
            subAGG.Text = Convert.ToString(p6Stats[6]);
            subName.Text = Player.GetAttribute("Name", LoginMenu.TeamID, 6);
            subShirtNum.Text = Player.GetAttribute("ShirtNum", LoginMenu.TeamID, 6);

            teamNameLabel.Text = Sql.Select("Select * from Teams Where Id = " + LoginMenu.TeamID.ToString(), 0, "TeamName");
            managerNameLabel.Text = Sql.Select("Select * from Teams Where Id = " + LoginMenu.TeamID.ToString(), 0, "Manager");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
