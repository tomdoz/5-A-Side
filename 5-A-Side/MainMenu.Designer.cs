
namespace _5_A_Side
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(109, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIVE-A-SIDE FANTASY \r\n    DREAM LEAGUE";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.signUpButton.Location = new System.Drawing.Point(50, 194);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(294, 141);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(413, 194);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(294, 141);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Black", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button loginButton;
    }
}

