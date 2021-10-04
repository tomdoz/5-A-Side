using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5_A_Side
{    
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           HomePage home = new HomePage();
           home.Show();
           this.Close();
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
