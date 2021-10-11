
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.emailAddTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.PWTxt = new System.Windows.Forms.TextBox();
            this.enterPWLabel = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.enterUserLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(178, 17);
            this.topTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1083, 106);
            this.topTitleLabel.TabIndex = 1;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.enterDOB);
            this.groupBox1.Controls.Add(this.dobPicker);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.emailAddTxt);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.PWTxt);
            this.groupBox1.Controls.Add(this.enterPWLabel);
            this.groupBox1.Controls.Add(this.userNameTxt);
            this.groupBox1.Controls.Add(this.enterUserLabel);
            this.groupBox1.Location = new System.Drawing.Point(54, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(636, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create your account here!";
            // 
            // enterDOB
            // 
            this.enterDOB.AutoSize = true;
            this.enterDOB.BackColor = System.Drawing.SystemColors.Window;
            this.enterDOB.Location = new System.Drawing.Point(66, 288);
            this.enterDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterDOB.Name = "enterDOB";
            this.enterDOB.Size = new System.Drawing.Size(135, 25);
            this.enterDOB.TabIndex = 9;
            this.enterDOB.Text = "Date of birth:";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(216, 288);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(370, 31);
            this.dobPicker.TabIndex = 8;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(216, 215);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(332, 31);
            this.nameTxt.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.SystemColors.Window;
            this.firstName.Location = new System.Drawing.Point(28, 217);
            this.firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(176, 25);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "Enter your name:";
            // 
            // emailAddTxt
            // 
            this.emailAddTxt.Location = new System.Drawing.Point(216, 162);
            this.emailAddTxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailAddTxt.Name = "emailAddTxt";
            this.emailAddTxt.Size = new System.Drawing.Size(332, 31);
            this.emailAddTxt.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Location = new System.Drawing.Point(0, 165);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(209, 25);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Enter email address:";
            // 
            // PWTxt
            // 
            this.PWTxt.Location = new System.Drawing.Point(216, 115);
            this.PWTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PWTxt.Name = "PWTxt";
            this.PWTxt.PasswordChar = '*';
            this.PWTxt.Size = new System.Drawing.Size(332, 31);
            this.PWTxt.TabIndex = 3;
            // 
            // enterPWLabel
            // 
            this.enterPWLabel.AutoSize = true;
            this.enterPWLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enterPWLabel.Location = new System.Drawing.Point(30, 115);
            this.enterPWLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterPWLabel.Name = "enterPWLabel";
            this.enterPWLabel.Size = new System.Drawing.Size(180, 25);
            this.enterPWLabel.TabIndex = 2;
            this.enterPWLabel.Text = "Create password:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(216, 71);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(332, 31);
            this.userNameTxt.TabIndex = 1;
            // 
            // enterUserLabel
            // 
            this.enterUserLabel.AutoSize = true;
            this.enterUserLabel.BackColor = System.Drawing.SystemColors.Window;
            this.enterUserLabel.Location = new System.Drawing.Point(20, 73);
            this.enterUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterUserLabel.Name = "enterUserLabel";
            this.enterUserLabel.Size = new System.Drawing.Size(188, 25);
            this.enterUserLabel.TabIndex = 0;
            this.enterUserLabel.Text = "Enter a username:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.signUpButton.Location = new System.Drawing.Point(827, 253);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(320, 165);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Create Account";
            this.signUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 662);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.topTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox emailAddTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox PWTxt;
        private System.Windows.Forms.Button signUpButton;
    }
}