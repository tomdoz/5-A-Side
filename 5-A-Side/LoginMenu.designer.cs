
namespace _5_A_Side
{
    partial class LoginMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginTXT = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordPrompt = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TitleLabel.Location = new System.Drawing.Point(24, 13);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1406, 106);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Five-A-Side Fantasy Dream League";
            // 
            // LoginTXT
            // 
            this.LoginTXT.AutoSize = true;
            this.LoginTXT.BackColor = System.Drawing.Color.Transparent;
            this.LoginTXT.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.LoginTXT.ForeColor = System.Drawing.Color.Orange;
            this.LoginTXT.Location = new System.Drawing.Point(506, 121);
            this.LoginTXT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginTXT.Name = "LoginTXT";
            this.LoginTXT.Size = new System.Drawing.Size(328, 72);
            this.LoginTXT.TabIndex = 2;
            this.LoginTXT.Text = "Login now!";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(492, 231);
            this.userTxt.Margin = new System.Windows.Forms.Padding(2);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(530, 31);
            this.userTxt.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(20, 200);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(462, 72);
            this.Username.TabIndex = 4;
            this.Username.Text = "Enter username:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.Black;
            this.passwordTxt.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.Location = new System.Drawing.Point(492, 325);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(530, 31);
            this.passwordTxt.TabIndex = 5;
            // 
            // passwordPrompt
            // 
            this.passwordPrompt.AutoSize = true;
            this.passwordPrompt.BackColor = System.Drawing.Color.Transparent;
            this.passwordPrompt.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.passwordPrompt.ForeColor = System.Drawing.Color.Transparent;
            this.passwordPrompt.Location = new System.Drawing.Point(30, 294);
            this.passwordPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordPrompt.Name = "passwordPrompt";
            this.passwordPrompt.Size = new System.Drawing.Size(459, 72);
            this.passwordPrompt.TabIndex = 6;
            this.passwordPrompt.Text = "Enter password:";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(984, 402);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(434, 138);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "CLICK TO LOGIN TO YOUR ACCOUNT";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1524, 587);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordPrompt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.LoginTXT);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1550, 658);
            this.MinimumSize = new System.Drawing.Size(1550, 658);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LoginTXT;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordPrompt;
        private System.Windows.Forms.Button loginButton;
    }
}