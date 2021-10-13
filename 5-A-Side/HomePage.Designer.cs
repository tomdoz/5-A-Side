
namespace _5_A_Side
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.displayTopScorersButton = new System.Windows.Forms.Button();
            this.playNextMatchButton = new System.Windows.Forms.Button();
            this.teamInputButton = new System.Windows.Forms.Button();
            this.teamDisplayButton = new System.Windows.Forms.Button();
            this.nextGameweek = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TitleLabel.Location = new System.Drawing.Point(43, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(699, 54);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Five-A-Side Fantasy Dream League";
            // 
            // displayTopScorersButton
            // 
            this.displayTopScorersButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTopScorersButton.Location = new System.Drawing.Point(622, 201);
            this.displayTopScorersButton.Name = "displayTopScorersButton";
            this.displayTopScorersButton.Size = new System.Drawing.Size(150, 86);
            this.displayTopScorersButton.TabIndex = 3;
            this.displayTopScorersButton.Text = "Display Top Scorers";
            this.displayTopScorersButton.UseVisualStyleBackColor = true;
            this.displayTopScorersButton.Click += new System.EventHandler(this.displayTopScorersButton_Click);
            // 
            // playNextMatchButton
            // 
            this.playNextMatchButton.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playNextMatchButton.Location = new System.Drawing.Point(280, 147);
            this.playNextMatchButton.Name = "playNextMatchButton";
            this.playNextMatchButton.Size = new System.Drawing.Size(238, 156);
            this.playNextMatchButton.TabIndex = 4;
            this.playNextMatchButton.Text = "Play Next Match!";
            this.playNextMatchButton.UseVisualStyleBackColor = true;
            this.playNextMatchButton.Click += new System.EventHandler(this.playNextMatchButton_Click);
            // 
            // teamInputButton
            // 
            this.teamInputButton.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamInputButton.Location = new System.Drawing.Point(280, 147);
            this.teamInputButton.Name = "teamInputButton";
            this.teamInputButton.Size = new System.Drawing.Size(238, 156);
            this.teamInputButton.TabIndex = 5;
            this.teamInputButton.Text = "You need to create your team!";
            this.teamInputButton.UseVisualStyleBackColor = true;
            this.teamInputButton.Visible = false;
            this.teamInputButton.Click += new System.EventHandler(this.teamInputButton_Click);
            // 
            // teamDisplayButton
            // 
            this.teamDisplayButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDisplayButton.Location = new System.Drawing.Point(12, 201);
            this.teamDisplayButton.Name = "teamDisplayButton";
            this.teamDisplayButton.Size = new System.Drawing.Size(150, 86);
            this.teamDisplayButton.TabIndex = 6;
            this.teamDisplayButton.Text = "View your Team\'s Attributes";
            this.teamDisplayButton.UseVisualStyleBackColor = true;
            this.teamDisplayButton.Click += new System.EventHandler(this.teamDisplayButton_Click);
            // 
            // nextGameweek
            // 
            this.nextGameweek.AutoSize = true;
            this.nextGameweek.BackColor = System.Drawing.Color.Transparent;
            this.nextGameweek.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.nextGameweek.ForeColor = System.Drawing.Color.Black;
            this.nextGameweek.Location = new System.Drawing.Point(200, 69);
            this.nextGameweek.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nextGameweek.Name = "nextGameweek";
            this.nextGameweek.Size = new System.Drawing.Size(383, 54);
            this.nextGameweek.TabIndex = 8;
            this.nextGameweek.Text = "Next gameweek: 1";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(315, 329);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 86);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Display Top Scorers";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 427);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.nextGameweek);
            this.Controls.Add(this.teamDisplayButton);
            this.Controls.Add(this.displayTopScorersButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.playNextMatchButton);
            this.Controls.Add(this.teamInputButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(805, 466);
            this.MinimumSize = new System.Drawing.Size(691, 466);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button displayTopScorersButton;
        private System.Windows.Forms.Button playNextMatchButton;
        private System.Windows.Forms.Button teamInputButton;
        private System.Windows.Forms.Button teamDisplayButton;
        private System.Windows.Forms.Label nextGameweek;
        private System.Windows.Forms.Button resetButton;
    }
}