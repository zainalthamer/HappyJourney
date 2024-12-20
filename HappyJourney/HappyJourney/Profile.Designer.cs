namespace HappyJourney
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(377, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(342, 207);
            this.labelName.MinimumSize = new System.Drawing.Size(300, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(300, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name Name Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDob
            // 
            this.txtDob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDob.Location = new System.Drawing.Point(317, 260);
            this.txtDob.Name = "txtDob";
            this.txtDob.ReadOnly = true;
            this.txtDob.Size = new System.Drawing.Size(161, 22);
            this.txtDob.TabIndex = 2;
            // 
            // txtNationality
            // 
            this.txtNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationality.Location = new System.Drawing.Point(498, 260);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.ReadOnly = true;
            this.txtNationality.Size = new System.Drawing.Size(156, 22);
            this.txtNationality.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(317, 307);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(161, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Location = new System.Drawing.Point(498, 307);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(156, 22);
            this.txtRole.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(317, 355);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(337, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(317, 399);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(337, 38);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(317, 443);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(337, 38);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 509);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSignOut;
    }
}