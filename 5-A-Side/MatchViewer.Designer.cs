
namespace _5_A_Side
{
    partial class MatchViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.team1Name = new System.Windows.Forms.Label();
            this.leftHome = new System.Windows.Forms.Label();
            this.leftAway = new System.Windows.Forms.Label();
            this.cpuTeamLabel = new System.Windows.Forms.Label();
            this.rightHome = new System.Windows.Forms.Label();
            this.rightAway = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.matchTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match Viewer";
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.BackColor = System.Drawing.Color.Transparent;
            this.team1Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team1Name.ForeColor = System.Drawing.Color.White;
            this.team1Name.Location = new System.Drawing.Point(550, 151);
            this.team1Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(186, 45);
            this.team1Name.TabIndex = 1;
            this.team1Name.Text = "User Team";
            // 
            // leftHome
            // 
            this.leftHome.AutoSize = true;
            this.leftHome.BackColor = System.Drawing.Color.Transparent;
            this.leftHome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftHome.ForeColor = System.Drawing.Color.White;
            this.leftHome.Location = new System.Drawing.Point(496, 151);
            this.leftHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftHome.Name = "leftHome";
            this.leftHome.Size = new System.Drawing.Size(72, 45);
            this.leftHome.TabIndex = 2;
            this.leftHome.Text = "(H)";
            // 
            // leftAway
            // 
            this.leftAway.AutoSize = true;
            this.leftAway.BackColor = System.Drawing.Color.Transparent;
            this.leftAway.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftAway.ForeColor = System.Drawing.Color.White;
            this.leftAway.Location = new System.Drawing.Point(496, 151);
            this.leftAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftAway.Name = "leftAway";
            this.leftAway.Size = new System.Drawing.Size(70, 45);
            this.leftAway.TabIndex = 3;
            this.leftAway.Text = "(A)";
            this.leftAway.Visible = false;
            // 
            // cpuTeamLabel
            // 
            this.cpuTeamLabel.AutoSize = true;
            this.cpuTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuTeamLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuTeamLabel.ForeColor = System.Drawing.Color.White;
            this.cpuTeamLabel.Location = new System.Drawing.Point(730, 151);
            this.cpuTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuTeamLabel.Name = "cpuTeamLabel";
            this.cpuTeamLabel.Size = new System.Drawing.Size(180, 45);
            this.cpuTeamLabel.TabIndex = 4;
            this.cpuTeamLabel.Text = "CPU Team";
            // 
            // rightHome
            // 
            this.rightHome.AutoSize = true;
            this.rightHome.BackColor = System.Drawing.Color.Transparent;
            this.rightHome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightHome.ForeColor = System.Drawing.Color.White;
            this.rightHome.Location = new System.Drawing.Point(888, 151);
            this.rightHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightHome.Name = "rightHome";
            this.rightHome.Size = new System.Drawing.Size(72, 45);
            this.rightHome.TabIndex = 5;
            this.rightHome.Text = "(H)";
            this.rightHome.Visible = false;
            // 
            // rightAway
            // 
            this.rightAway.AutoSize = true;
            this.rightAway.BackColor = System.Drawing.Color.Transparent;
            this.rightAway.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightAway.ForeColor = System.Drawing.Color.White;
            this.rightAway.Location = new System.Drawing.Point(890, 151);
            this.rightAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightAway.Name = "rightAway";
            this.rightAway.Size = new System.Drawing.Size(70, 45);
            this.rightAway.TabIndex = 6;
            this.rightAway.Text = "(A)";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.userScoreLabel.Font = new System.Drawing.Font("Segoe UI Black", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userScoreLabel.ForeColor = System.Drawing.Color.White;
            this.userScoreLabel.Location = new System.Drawing.Point(-31, 305);
            this.userScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(370, 425);
            this.userScoreLabel.TabIndex = 7;
            this.userScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Segoe UI Black", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.White;
            this.cpuScoreLabel.Location = new System.Drawing.Point(301, 305);
            this.cpuScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(370, 425);
            this.cpuScoreLabel.TabIndex = 8;
            this.cpuScoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 212);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(635, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 318);
            this.label3.TabIndex = 10;
            this.label3.Text = "Match\r\nClock:";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI Black", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(988, 305);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(480, 425);
            this.TimerLabel.TabIndex = 11;
            this.TimerLabel.Text = "0\'";
            // 
            // matchTimer
            // 
            this.matchTimer.Interval = 7000;
            this.matchTimer.Tick += new System.EventHandler(this.matchTimer_Tick);
            // 
            // MatchViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 877);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.cpuTeamLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userScoreLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.leftHome);
            this.Controls.Add(this.rightAway);
            this.Controls.Add(this.rightHome);
            this.Controls.Add(this.leftAway);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MatchViewer";
            this.Text = "Match Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label team1Name;
        private System.Windows.Forms.Label leftHome;
        private System.Windows.Forms.Label leftAway;
        private System.Windows.Forms.Label cpuTeamLabel;
        private System.Windows.Forms.Label rightHome;
        private System.Windows.Forms.Label rightAway;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer matchTimer;
    }
}