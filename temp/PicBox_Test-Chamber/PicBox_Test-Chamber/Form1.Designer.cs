namespace PicBox_Test_Chamber
{
    partial class carGame
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
            this.myCar = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.TicTocTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // myCar
            // 
            this.myCar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myCar.Location = new System.Drawing.Point(12, 197);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(76, 47);
            this.myCar.TabIndex = 0;
            this.myCar.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enemy.Location = new System.Drawing.Point(712, 197);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(76, 47);
            this.Enemy.TabIndex = 0;
            this.Enemy.TabStop = false;
            // 
            // TicTocTimer
            // 
            this.TicTocTimer.Enabled = true;
            this.TicTocTimer.Tick += new System.EventHandler(this.TicTocTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // carGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.myCar);
            this.Name = "carGame";
            this.Text = "carGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.carGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myCar;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TicTocTimer;
        private System.Windows.Forms.Timer enemyTimer;
    }
}

