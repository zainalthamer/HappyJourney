namespace HappyJourney
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignupLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(462, 162);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(380, 215);
            this.txtBoxEmail.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(234, 26);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(380, 261);
            this.txtBoxPassword.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(234, 26);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(438, 306);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 36);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Don\'t have an account?";
            // 
            // lblSignupLink
            // 
            this.lblSignupLink.AutoSize = true;
            this.lblSignupLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lblSignupLink.Location = new System.Drawing.Point(536, 360);
            this.lblSignupLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignupLink.Name = "lblSignupLink";
            this.lblSignupLink.Size = new System.Drawing.Size(49, 16);
            this.lblSignupLink.TabIndex = 13;
            this.lblSignupLink.TabStop = true;
            this.lblSignupLink.Text = "Signup";
            this.lblSignupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignupLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.lblSignupLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblSignupLink;
    }
}