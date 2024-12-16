namespace HappyJourney
{
    partial class ListOfCities
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.City_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.composeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // composeToolStripMenuItem
            // 
            this.composeToolStripMenuItem.Name = "composeToolStripMenuItem";
            this.composeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.composeToolStripMenuItem.Text = "Compose";
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCity.Location = new System.Drawing.Point(27, 53);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(90, 30);
            this.btnAddCity.TabIndex = 1;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = false;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(27, 109);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(564, 27);
            this.txtCityName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(636, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City_Id,
            this.Country_Id,
            this.City_name,
            this.delete_city});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(50, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(663, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // City_Id
            // 
            this.City_Id.HeaderText = "City ID";
            this.City_Id.MinimumWidth = 8;
            this.City_Id.Name = "City_Id";
            this.City_Id.Width = 150;
            // 
            // Country_Id
            // 
            this.Country_Id.HeaderText = "Country ID ";
            this.Country_Id.MinimumWidth = 8;
            this.Country_Id.Name = "Country_Id";
            this.Country_Id.Width = 150;
            // 
            // City_name
            // 
            this.City_name.HeaderText = "City Name";
            this.City_name.MinimumWidth = 8;
            this.City_name.Name = "City_name";
            this.City_name.Width = 150;
            // 
            // delete_city
            // 
            this.delete_city.HeaderText = "Delete City";
            this.delete_city.MinimumWidth = 8;
            this.delete_city.Name = "delete_city";
            this.delete_city.Width = 150;
            // 
            // ListOfCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListOfCities";
            this.Text = "ListOfCities";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composeToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete_city;
    }
}