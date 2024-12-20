namespace HappyJourney
{
    partial class Home
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
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.departDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.dstLabel = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightsGridView
            // 
            this.flightsGridView.AllowUserToAddRows = false;
            this.flightsGridView.AllowUserToDeleteRows = false;
            this.flightsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Location = new System.Drawing.Point(0, 218);
            this.flightsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowHeadersWidth = 51;
            this.flightsGridView.RowTemplate.Height = 24;
            this.flightsGridView.ShowEditingIcon = false;
            this.flightsGridView.Size = new System.Drawing.Size(1472, 502);
            this.flightsGridView.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1271, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 45);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(882, 127);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(367, 31);
            this.arrivalDateTimePicker.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(877, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Arrival Time";
            // 
            // departDateTimePicker
            // 
            this.departDateTimePicker.Location = new System.Drawing.Point(498, 129);
            this.departDateTimePicker.Name = "departDateTimePicker";
            this.departDateTimePicker.Size = new System.Drawing.Size(367, 31);
            this.departDateTimePicker.TabIndex = 29;
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.Location = new System.Drawing.Point(493, 89);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(174, 25);
            this.departureLabel.TabIndex = 28;
            this.departureLabel.Text = "Departure Time";
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(267, 129);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(213, 31);
            this.destTextBox.TabIndex = 27;
            // 
            // dstLabel
            // 
            this.dstLabel.AutoSize = true;
            this.dstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstLabel.Location = new System.Drawing.Point(262, 89);
            this.dstLabel.Name = "dstLabel";
            this.dstLabel.Size = new System.Drawing.Size(131, 25);
            this.dstLabel.TabIndex = 26;
            this.dstLabel.Text = "Destination";
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(37, 129);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(213, 31);
            this.originTextBox.TabIndex = 25;
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginLabel.Location = new System.Drawing.Point(32, 89);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(75, 25);
            this.OriginLabel.TabIndex = 24;
            this.OriginLabel.Text = "Origin";
            // 
            // mnuHome
            // 
            this.mnuHome.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuHome.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuHome.Location = new System.Drawing.Point(0, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(1472, 24);
            this.mnuHome.TabIndex = 23;
            this.mnuHome.Text = "menuStrip1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 719);
            this.Controls.Add(this.flightsGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departDateTimePicker);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.dstLabel);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.OriginLabel);
            this.Controls.Add(this.mnuHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flightsGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker departDateTimePicker;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.Label dstLabel;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.MenuStrip mnuHome;
    }
}