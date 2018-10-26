namespace ProjectMarse
{
    partial class EV3Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EV3Connect));
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(77, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP address of EV3";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(64, 118);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(114, 20);
            this.ipAddressBox.TabIndex = 11;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(345, 102);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(145, 47);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(220, 132);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(220, 97);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // pictureBack
            // 
            this.pictureBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBack.BackgroundImage")));
            this.pictureBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBack.Location = new System.Drawing.Point(394, 350);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(156, 51);
            this.pictureBack.TabIndex = 15;
            this.pictureBack.TabStop = false;
            this.pictureBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBack_MouseClick);
            this.pictureBack.MouseEnter += new System.EventHandler(this.pictureBack_MouseEnter);
            this.pictureBack.MouseLeave += new System.EventHandler(this.pictureBack_MouseLeave);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(83)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(562, 413);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipAddressBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectedDeviceLabel);
            this.Controls.Add(this.disconnectButton);
            this.Name = "Form5";
            this.Text = "Connection EV3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox pictureBack;
    }
}