namespace Play_Game
{
    partial class displayScreen
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
            this.countdownDisplay = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Button();
            this.catImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catImage)).BeginInit();
            this.SuspendLayout();
            // 
            // countdownDisplay
            // 
            this.countdownDisplay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.countdownDisplay.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownDisplay.Location = new System.Drawing.Point(259, 244);
            this.countdownDisplay.Name = "countdownDisplay";
            this.countdownDisplay.Size = new System.Drawing.Size(43, 60);
            this.countdownDisplay.TabIndex = 1;
            this.countdownDisplay.Text = "3";
            this.countdownDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownDisplay.Visible = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(208, 87);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(150, 58);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Start";
            this.startLabel.UseVisualStyleBackColor = true;
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // catImage
            // 
            this.catImage.Image = global::Play_Game.Properties.Resources.Cat;
            this.catImage.Location = new System.Drawing.Point(25, 23);
            this.catImage.Name = "catImage";
            this.catImage.Size = new System.Drawing.Size(520, 401);
            this.catImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catImage.TabIndex = 4;
            this.catImage.TabStop = false;
            this.catImage.Visible = false;
            // 
            // displayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.catImage);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.countdownDisplay);
            this.Name = "displayScreen";
            this.RightToLeftLayout = true;
            this.Text = "Play Game";
            ((System.ComponentModel.ISupportInitialize)(this.catImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countdownDisplay;
        private System.Windows.Forms.Button startLabel;
        private System.Windows.Forms.PictureBox catImage;
    }
}

