namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.conditionImage = new System.Windows.Forms.PictureBox();
            this.maxOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft MHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forecastLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forecastLabel.Location = new System.Drawing.Point(143, 375);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(76, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "       7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Max";
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cityOutput.Location = new System.Drawing.Point(3, 3);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(162, 32);
            this.cityOutput.TabIndex = 50;
            this.cityOutput.Text = "Stratford";
            // 
            // currentTemp
            // 
            this.currentTemp.BackColor = System.Drawing.Color.Transparent;
            this.currentTemp.Font = new System.Drawing.Font("Microsoft MHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentTemp.Location = new System.Drawing.Point(85, 175);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(85, 66);
            this.currentTemp.TabIndex = 51;
            this.currentTemp.Text = "30C";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft MHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minOutput.Location = new System.Drawing.Point(140, 254);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(83, 38);
            this.minOutput.TabIndex = 53;
            this.minOutput.Text = "10C";
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.Silver;
            this.dateOutput.Location = new System.Drawing.Point(6, 32);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(177, 32);
            this.dateOutput.TabIndex = 54;
            this.dateOutput.Text = "Wednesday, April 19";
            // 
            // conditionImage
            // 
            this.conditionImage.BackColor = System.Drawing.Color.Transparent;
            this.conditionImage.BackgroundImage = global::XMLWeather.Properties.Resources.Sunny;
            this.conditionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionImage.Location = new System.Drawing.Point(54, 51);
            this.conditionImage.Name = "conditionImage";
            this.conditionImage.Size = new System.Drawing.Size(117, 130);
            this.conditionImage.TabIndex = 44;
            this.conditionImage.TabStop = false;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft MHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.maxOutput.Location = new System.Drawing.Point(49, 254);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(88, 48);
            this.maxOutput.TabIndex = 52;
            this.maxOutput.Text = "30C";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.currentTemp);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.conditionImage);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(228, 410);
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.PictureBox conditionImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label maxOutput;
    }
}
