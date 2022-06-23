namespace CarGame
{
    partial class CarGame
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
            this.components = new System.ComponentModel.Container();
            this.carTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.myCar = new System.Windows.Forms.PictureBox();
            this.PointsLB = new System.Windows.Forms.Label();
            this.playAgainBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            this.SuspendLayout();
            // 
            // carTimer
            // 
            this.carTimer.Enabled = true;
            this.carTimer.Interval = 50;
            this.carTimer.Tick += new System.EventHandler(this.carTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // myCar
            // 
            this.myCar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.myCar.Image = global::CarGame.Properties.Resources.Anonymous_car_side_view;
            this.myCar.Location = new System.Drawing.Point(22, 161);
            this.myCar.Margin = new System.Windows.Forms.Padding(2);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(75, 41);
            this.myCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCar.TabIndex = 0;
            this.myCar.TabStop = false;
            // 
            // PointsLB
            // 
            this.PointsLB.AutoSize = true;
            this.PointsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLB.Location = new System.Drawing.Point(480, 9);
            this.PointsLB.Name = "PointsLB";
            this.PointsLB.Size = new System.Drawing.Size(57, 20);
            this.PointsLB.TabIndex = 1;
            this.PointsLB.Text = "Points:";
            // 
            // playAgainBT
            // 
            this.playAgainBT.BackColor = System.Drawing.Color.Transparent;
            this.playAgainBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playAgainBT.FlatAppearance.BorderSize = 0;
            this.playAgainBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playAgainBT.Location = new System.Drawing.Point(390, 6);
            this.playAgainBT.Name = "playAgainBT";
            this.playAgainBT.Size = new System.Drawing.Size(75, 23);
            this.playAgainBT.TabIndex = 2;
            this.playAgainBT.Text = "Restart";
            this.playAgainBT.UseVisualStyleBackColor = false;
            this.playAgainBT.Visible = false;
            this.playAgainBT.Click += new System.EventHandler(this.PlayAgain);
            // 
            // CarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.playAgainBT);
            this.Controls.Add(this.PointsLB);
            this.Controls.Add(this.myCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarGame";
            this.Text = "CarGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer carTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.PictureBox myCar;
        private System.Windows.Forms.Label PointsLB;
        private System.Windows.Forms.Button playAgainBT;
    }
}

