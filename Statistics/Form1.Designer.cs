namespace Statistics
{
    partial class Statistics
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
            this.buttonSettings2 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMoving = new System.Windows.Forms.Button();
            this.buttonBattery = new System.Windows.Forms.Button();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.textBoxMeters = new System.Windows.Forms.TextBox();
            this.labelMeters = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSettings2
            // 
            this.buttonSettings2.Location = new System.Drawing.Point(12, 172);
            this.buttonSettings2.Name = "buttonSettings2";
            this.buttonSettings2.Size = new System.Drawing.Size(131, 23);
            this.buttonSettings2.TabIndex = 0;
            this.buttonSettings2.Text = "Instellingen";
            this.buttonSettings2.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(320, 253);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonMoving
            // 
            this.buttonMoving.BackColor = System.Drawing.Color.Lime;
            this.buttonMoving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoving.Location = new System.Drawing.Point(12, 253);
            this.buttonMoving.Name = "buttonMoving";
            this.buttonMoving.Size = new System.Drawing.Size(131, 23);
            this.buttonMoving.TabIndex = 23;
            this.buttonMoving.Text = "In beweging";
            this.buttonMoving.UseVisualStyleBackColor = false;
            // 
            // buttonBattery
            // 
            this.buttonBattery.Location = new System.Drawing.Point(12, 212);
            this.buttonBattery.Name = "buttonBattery";
            this.buttonBattery.Size = new System.Drawing.Size(131, 23);
            this.buttonBattery.TabIndex = 24;
            this.buttonBattery.Text = "Batterij";
            this.buttonBattery.UseVisualStyleBackColor = true;
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(218, 199);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(18, 13);
            this.labelCelsius.TabIndex = 25;
            this.labelCelsius.Text = "°C";
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(203, 215);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(44, 20);
            this.textBoxCelsius.TabIndex = 26;
            // 
            // textBoxMeters
            // 
            this.textBoxMeters.Location = new System.Drawing.Point(253, 215);
            this.textBoxMeters.Name = "textBoxMeters";
            this.textBoxMeters.Size = new System.Drawing.Size(44, 20);
            this.textBoxMeters.TabIndex = 27;
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(270, 199);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(16, 13);
            this.labelMeters.TabIndex = 28;
            this.labelMeters.Text = "M";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(303, 215);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(44, 20);
            this.textBoxSpeed.TabIndex = 29;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(314, 199);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(33, 13);
            this.labelSpeed.TabIndex = 30;
            this.labelSpeed.Text = "Km/u";
            // 
            // labelAir
            // 
            this.labelAir.AutoSize = true;
            this.labelAir.Location = new System.Drawing.Point(231, 172);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(91, 13);
            this.labelAir.TabIndex = 31;
            this.labelAir.Text = "Lucht verzadiging";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 300);
            this.Controls.Add(this.labelAir);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelMeters);
            this.Controls.Add(this.textBoxMeters);
            this.Controls.Add(this.textBoxCelsius);
            this.Controls.Add(this.labelCelsius);
            this.Controls.Add(this.buttonBattery);
            this.Controls.Add(this.buttonMoving);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSettings2);
            this.Name = "Statistics";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMoving;
        private System.Windows.Forms.Button buttonBattery;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.TextBox textBoxMeters;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelAir;
    }
}

