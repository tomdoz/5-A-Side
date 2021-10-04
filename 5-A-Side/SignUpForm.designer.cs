
namespace _5_A_Side
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enterDOB = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.emailAddTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.PWTxt = new System.Windows.Forms.TextBox();
            this.enterPWLabel = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.enterUserLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.testReadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(89, 9);
            this.topTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(538, 54);
            this.topTitleLabel.TabIndex = 1;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.enterDOB);
            this.groupBox1.Controls.Add(this.dobPicker);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.emailAddTxt);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.PWTxt);
            this.groupBox1.Controls.Add(this.enterPWLabel);
            this.groupBox1.Controls.Add(this.userNameTxt);
            this.groupBox1.Controls.Add(this.enterUserLabel);
            this.groupBox1.Location = new System.Drawing.Point(27, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(318, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create your account here!";
            // 
            // enterDOB
            // 
            this.enterDOB.AutoSize = true;
            this.enterDOB.BackColor = System.Drawing.SystemColors.Window;
            this.enterDOB.Location = new System.Drawing.Point(33, 150);
            this.enterDOB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.enterDOB.Name = "enterDOB";
            this.enterDOB.Size = new System.Drawing.Size(68, 13);
            this.enterDOB.TabIndex = 9;
            this.enterDOB.Text = "Date of birth:";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(108, 150);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(1);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(187, 20);
            this.dobPicker.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.SystemColors.Window;
            this.firstName.Location = new System.Drawing.Point(14, 113);
            this.firstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(87, 13);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "Enter your name:";
            // 
            // emailAddTxt
            // 
            this.emailAddTxt.Location = new System.Drawing.Point(108, 84);
            this.emailAddTxt.Margin = new System.Windows.Forms.Padding(1);
            this.emailAddTxt.Name = "emailAddTxt";
            this.emailAddTxt.Size = new System.Drawing.Size(168, 20);
            this.emailAddTxt.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Location = new System.Drawing.Point(0, 86);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(102, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Enter email address:";
            // 
            // PWTxt
            // 
            this.PWTxt.Location = new System.Drawing.Point(108, 60);
            this.PWTxt.Margin = new System.Windows.Forms.Padding(1);
            this.PWTxt.Name = "PWTxt";
            this.PWTxt.PasswordChar = '*';
            this.PWTxt.Size = new System.Drawing.Size(168, 20);
            this.PWTxt.TabIndex = 3;
            // 
            // enterPWLabel
            // 
            this.enterPWLabel.AutoSize = true;
            this.enterPWLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enterPWLabel.Location = new System.Drawing.Point(15, 60);
            this.enterPWLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.enterPWLabel.Name = "enterPWLabel";
            this.enterPWLabel.Size = new System.Drawing.Size(89, 13);
            this.enterPWLabel.TabIndex = 2;
            this.enterPWLabel.Text = "Create password:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(108, 37);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(1);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(168, 20);
            this.userNameTxt.TabIndex = 1;
            // 
            // enterUserLabel
            // 
            this.enterUserLabel.AutoSize = true;
            this.enterUserLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enterUserLabel.Location = new System.Drawing.Point(10, 38);
            this.enterUserLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.enterUserLabel.Name = "enterUserLabel";
            this.enterUserLabel.Size = new System.Drawing.Size(93, 13);
            this.enterUserLabel.TabIndex = 0;
            this.enterUserLabel.Text = "Enter a username:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.signUpButton.Location = new System.Drawing.Point(450, 77);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(1);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(160, 86);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Create Account";
            this.signUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // testReadButton
            // 
            this.testReadButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.testReadButton.Location = new System.Drawing.Point(450, 169);
            this.testReadButton.Margin = new System.Windows.Forms.Padding(1);
            this.testReadButton.Name = "testReadButton";
            this.testReadButton.Size = new System.Drawing.Size(160, 86);
            this.testReadButton.TabIndex = 4;
            this.testReadButton.Text = "Read usernames";
            this.testReadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.testReadButton.UseVisualStyleBackColor = true;
            this.testReadButton.Click += new System.EventHandler(this.testReadButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 344);
            this.Controls.Add(this.testReadButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.topTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label enterUserLabel;
        private System.Windows.Forms.Label enterPWLabel;
        private System.Windows.Forms.Label enterDOB;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox emailAddTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox PWTxt;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button testReadButton;
    }
}