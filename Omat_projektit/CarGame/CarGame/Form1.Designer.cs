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
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            this.SuspendLayout();
            // 
            // carTimer
            // 
            this.carTimer.Enabled = true;
            this.carTimer.Tick += new System.EventHandler(this.carTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // myCar
            // 
            this.myCar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myCar.Location = new System.Drawing.Point(30, 198);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(100, 50);
            this.myCar.TabIndex = 0;
            this.myCar.TabStop = false;
            // 
            // CarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myCar);
            this.Name = "CarGame";
            this.Text = "CarGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer carTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.PictureBox myCar;
    }
}

