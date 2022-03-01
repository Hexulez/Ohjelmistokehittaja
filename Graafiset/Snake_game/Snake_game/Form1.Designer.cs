namespace Snake_game
{
    partial class Form1
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
            this.startBT = new System.Windows.Forms.Button();
            this.snapBT = new System.Windows.Forms.Button();
            this.gameboard = new System.Windows.Forms.PictureBox();
            this.ScoreLB = new System.Windows.Forms.Label();
            this.HiScoreLB = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.debugLB = new System.Windows.Forms.Label();
            this.debugLB2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameboard)).BeginInit();
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBT.Location = new System.Drawing.Point(591, 28);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(83, 45);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.StartGame);
            // 
            // snapBT
            // 
            this.snapBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapBT.Location = new System.Drawing.Point(591, 98);
            this.snapBT.Name = "snapBT";
            this.snapBT.Size = new System.Drawing.Size(83, 45);
            this.snapBT.TabIndex = 0;
            this.snapBT.Text = "snap";
            this.snapBT.UseVisualStyleBackColor = true;
            this.snapBT.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // gameboard
            // 
            this.gameboard.BackColor = System.Drawing.Color.HotPink;
            this.gameboard.Location = new System.Drawing.Point(30, 28);
            this.gameboard.Name = "gameboard";
            this.gameboard.Size = new System.Drawing.Size(521, 557);
            this.gameboard.TabIndex = 1;
            this.gameboard.TabStop = false;
            this.gameboard.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGameBoard);
            // 
            // ScoreLB
            // 
            this.ScoreLB.AutoSize = true;
            this.ScoreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLB.Location = new System.Drawing.Point(588, 186);
            this.ScoreLB.Name = "ScoreLB";
            this.ScoreLB.Size = new System.Drawing.Size(80, 24);
            this.ScoreLB.TabIndex = 2;
            this.ScoreLB.Text = "Score: 0";
            // 
            // HiScoreLB
            // 
            this.HiScoreLB.AutoSize = true;
            this.HiScoreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiScoreLB.Location = new System.Drawing.Point(588, 224);
            this.HiScoreLB.Name = "HiScoreLB";
            this.HiScoreLB.Size = new System.Drawing.Size(110, 24);
            this.HiScoreLB.TabIndex = 2;
            this.HiScoreLB.Text = "High Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // debugLB
            // 
            this.debugLB.AutoSize = true;
            this.debugLB.Location = new System.Drawing.Point(567, 324);
            this.debugLB.Name = "debugLB";
            this.debugLB.Size = new System.Drawing.Size(35, 13);
            this.debugLB.TabIndex = 3;
            this.debugLB.Text = "label1";
            this.debugLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // debugLB2
            // 
            this.debugLB2.AutoSize = true;
            this.debugLB2.Location = new System.Drawing.Point(567, 351);
            this.debugLB2.Name = "debugLB2";
            this.debugLB2.Size = new System.Drawing.Size(35, 13);
            this.debugLB2.TabIndex = 3;
            this.debugLB2.Text = "label1";
            this.debugLB2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 632);
            this.Controls.Add(this.debugLB2);
            this.Controls.Add(this.debugLB);
            this.Controls.Add(this.HiScoreLB);
            this.Controls.Add(this.ScoreLB);
            this.Controls.Add(this.gameboard);
            this.Controls.Add(this.snapBT);
            this.Controls.Add(this.startBT);
            this.Name = "Form1";
            this.Text = "Snake game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Button snapBT;
        private System.Windows.Forms.PictureBox gameboard;
        private System.Windows.Forms.Label ScoreLB;
        private System.Windows.Forms.Label HiScoreLB;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label debugLB;
        private System.Windows.Forms.Label debugLB2;
    }
}

