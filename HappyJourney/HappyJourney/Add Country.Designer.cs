namespace HappyJourney
{
    partial class Add_Country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Country));
            this.mnuNavigation = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuNavigation
            // 
            this.mnuNavigation.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuNavigation.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.inboxToolStripMenuItem,
            this.composeToolStripMenuItem});
            this.mnuNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnuNavigation.Name = "mnuNavigation";
            this.mnuNavigation.Size = new System.Drawing.Size(800, 33);
            this.mnuNavigation.TabIndex = 0;
            this.mnuNavigation.Text = "mnuNavigation";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.inboxToolStripMenuItem.Text = "Inbox";
            // 
            // composeToolStripMenuItem
            // 
            this.composeToolStripMenuItem.Name = "composeToolStripMenuItem";
            this.composeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.composeToolStripMenuItem.Text = "Compose";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(26, 62);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.Location = new System.Drawing.Point(307, 159);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(161, 29);
            this.lblAddCountry.TabIndex = 2;
            this.lblAddCountry.Text = "Add Country";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(255, 220);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(273, 27);
            this.txtCountryName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(334, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // Add_Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblAddCountry);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mnuNavigation);
            this.MainMenuStrip = this.mnuNavigation;
            this.Name = "Add_Country";
            this.Text = "Add_Country";
            this.mnuNavigation.ResumeLayout(false);
            this.mnuNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavigation;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composeToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnAdd;
    }
}