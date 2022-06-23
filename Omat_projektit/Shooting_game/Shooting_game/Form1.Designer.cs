namespace Shooting_game
{
    partial class shootingGameFM
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
            this.PlayerPB = new System.Windows.Forms.PictureBox();
            this.AimingPB = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimingPB)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPB
            // 
            this.PlayerPB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayerPB.Location = new System.Drawing.Point(519, 358);
            this.PlayerPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerPB.Name = "PlayerPB";
            this.PlayerPB.Size = new System.Drawing.Size(44, 37);
            this.PlayerPB.TabIndex = 0;
            this.PlayerPB.TabStop = false;
            // 
            // AimingPB
            // 
            this.AimingPB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AimingPB.Location = new System.Drawing.Point(183, 194);
            this.AimingPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AimingPB.Name = "AimingPB";
            this.AimingPB.Size = new System.Drawing.Size(36, 33);
            this.AimingPB.TabIndex = 1;
            this.AimingPB.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // shootingGameFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 811);
            this.Controls.Add(this.AimingPB);
            this.Controls.Add(this.PlayerPB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "shootingGameFM";
            this.Text = "Shooting_game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shootingGameFM_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.shootingGameFM_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shootingGameFM_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shootingGameFM_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimingPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerPB;
        private System.Windows.Forms.PictureBox AimingPB;
        private System.Windows.Forms.Timer gameTimer;
    }
}

