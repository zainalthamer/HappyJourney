namespace HappyJourney
{
    partial class FlightDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightDetail));
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.seatCategoryGridView = new System.Windows.Forms.DataGridView();
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.mnuFlightDetail = new System.Windows.Forms.MenuStrip();
            this.imgBackArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seatCategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookFlight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookFlight.Location = new System.Drawing.Point(633, 736);
            this.btnBookFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(186, 59);
            this.btnBookFlight.TabIndex = 29;
            this.btnBookFlight.Text = "Book Flight";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click_1);
            // 
            // seatCategoryGridView
            // 
            this.seatCategoryGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seatCategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatCategoryGridView.Location = new System.Drawing.Point(410, 371);
            this.seatCategoryGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seatCategoryGridView.Name = "seatCategoryGridView";
            this.seatCategoryGridView.RowHeadersWidth = 51;
            this.seatCategoryGridView.RowTemplate.Height = 24;
            this.seatCategoryGridView.Size = new System.Drawing.Size(644, 333);
            this.seatCategoryGridView.TabIndex = 28;
            // 
            // flightsGridView
            // 
            this.flightsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Location = new System.Drawing.Point(61, 124);
            this.flightsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowHeadersWidth = 51;
            this.flightsGridView.RowTemplate.Height = 24;
            this.flightsGridView.Size = new System.Drawing.Size(1335, 191);
            this.flightsGridView.TabIndex = 27;
            // 
            // mnuFlightDetail
            // 
            this.mnuFlightDetail.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuFlightDetail.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuFlightDetail.Location = new System.Drawing.Point(0, 0);
            this.mnuFlightDetail.Name = "mnuFlightDetail";
            this.mnuFlightDetail.Size = new System.Drawing.Size(1462, 24);
            this.mnuFlightDetail.TabIndex = 31;
            this.mnuFlightDetail.Text = "menuStrip1";
            // 
            // imgBackArrow
            // 
            this.imgBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("imgBackArrow.Image")));
            this.imgBackArrow.Location = new System.Drawing.Point(61, 59);
            this.imgBackArrow.Name = "imgBackArrow";
            this.imgBackArrow.Size = new System.Drawing.Size(44, 42);
            this.imgBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBackArrow.TabIndex = 30;
            this.imgBackArrow.TabStop = false;
            // 
            // FlightDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 811);
            this.Controls.Add(this.imgBackArrow);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.seatCategoryGridView);
            this.Controls.Add(this.flightsGridView);
            this.Controls.Add(this.mnuFlightDetail);
            this.Name = "FlightDetail";
            this.Text = "Flight Details";
            this.Load += new System.EventHandler(this.FlightDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seatCategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBackArrow;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.DataGridView seatCategoryGridView;
        private System.Windows.Forms.DataGridView flightsGridView;
        private System.Windows.Forms.MenuStrip mnuFlightDetail;
    }
}