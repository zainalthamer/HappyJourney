namespace HappyJourney
{
    partial class Compose
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
            this.lblNewMessage = new System.Windows.Forms.Label();
            this.txtRecepient = new System.Windows.Forms.TextBox();
            this.txtMessageContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMessage.Location = new System.Drawing.Point(647, 142);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(229, 37);
            this.lblNewMessage.TabIndex = 2;
            this.lblNewMessage.Text = "New Message";
            // 
            // txtRecepient
            // 
            this.txtRecepient.Location = new System.Drawing.Point(558, 218);
            this.txtRecepient.Name = "txtRecepient";
            this.txtRecepient.Size = new System.Drawing.Size(397, 31);
            this.txtRecepient.TabIndex = 3;
            // 
            // txtMessageContent
            // 
            this.txtMessageContent.Location = new System.Drawing.Point(558, 275);
            this.txtMessageContent.Multiline = true;
            this.txtMessageContent.Name = "txtMessageContent";
            this.txtMessageContent.Size = new System.Drawing.Size(397, 263);
            this.txtMessageContent.TabIndex = 4;
            this.txtMessageContent.Text = "\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(670, 565);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(181, 43);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 719);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageContent);
            this.Controls.Add(this.txtRecepient);
            this.Controls.Add(this.lblNewMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Compose";
            this.Text = "Compose";
            this.Load += new System.EventHandler(this.Compose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.TextBox txtRecepient;
        private System.Windows.Forms.TextBox txtMessageContent;
        private System.Windows.Forms.Button btnSend;
    }
}