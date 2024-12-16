namespace HappyJourney
{
    partial class ListOfAirports
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAirportId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.City_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airport_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airport_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICAo_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IATA_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_airport = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.inboxToolStripMenuItem,
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
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAirport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAirport.Location = new System.Drawing.Point(55, 63);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(136, 36);
            this.btnAddAirport.TabIndex = 1;
            this.btnAddAirport.Text = "Add Airport";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(607, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtAirportId
            // 
            this.txtAirportId.Location = new System.Drawing.Point(55, 143);
            this.txtAirportId.Name = "txtAirportId";
            this.txtAirportId.Size = new System.Drawing.Size(513, 27);
            this.txtAirportId.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City_id,
            this.airport_id,
            this.Airport_name,
            this.ICAo_code,
            this.IATA_code,
            this.Delete_airport});
            this.dataGridView1.Location = new System.Drawing.Point(55, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(662, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // City_id
            // 
            this.City_id.HeaderText = "City ID";
            this.City_id.MinimumWidth = 8;
            this.City_id.Name = "City_id";
            // 
            // airport_id
            // 
            this.airport_id.HeaderText = "Airport ID";
            this.airport_id.MinimumWidth = 8;
            this.airport_id.Name = "airport_id";
            // 
            // Airport_name
            // 
            this.Airport_name.HeaderText = "Airport Name";
            this.Airport_name.MinimumWidth = 8;
            this.Airport_name.Name = "Airport_name";
            // 
            // ICAo_code
            // 
            this.ICAo_code.HeaderText = "ICAO Code";
            this.ICAo_code.MinimumWidth = 8;
            this.ICAo_code.Name = "ICAo_code";
            // 
            // IATA_code
            // 
            this.IATA_code.HeaderText = "IATA Code";
            this.IATA_code.MinimumWidth = 8;
            this.IATA_code.Name = "IATA_code";
            // 
            // Delete_airport
            // 
            this.Delete_airport.HeaderText = "Delete Airport";
            this.Delete_airport.MinimumWidth = 8;
            this.Delete_airport.Name = "Delete_airport";
            // 
            // ListOfAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAirportId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListOfAirports";
            this.Text = "ListOfAirports";
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
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composeToolStripMenuItem;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAirportId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn airport_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICAo_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn IATA_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete_airport;
    }
}