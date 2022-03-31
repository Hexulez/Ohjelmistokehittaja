namespace API_testing
{
    partial class Main
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
            this.PreviousBT = new System.Windows.Forms.Button();
            this.SunInfoBT = new System.Windows.Forms.Button();
            this.NextBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousBT
            // 
            this.PreviousBT.Location = new System.Drawing.Point(143, 15);
            this.PreviousBT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PreviousBT.Name = "PreviousBT";
            this.PreviousBT.Size = new System.Drawing.Size(117, 41);
            this.PreviousBT.TabIndex = 0;
            this.PreviousBT.Text = "Previous";
            this.PreviousBT.UseVisualStyleBackColor = true;
            // 
            // SunInfoBT
            // 
            this.SunInfoBT.Location = new System.Drawing.Point(290, 15);
            this.SunInfoBT.Margin = new System.Windows.Forms.Padding(6);
            this.SunInfoBT.Name = "SunInfoBT";
            this.SunInfoBT.Size = new System.Drawing.Size(117, 41);
            this.SunInfoBT.TabIndex = 0;
            this.SunInfoBT.Text = "Sun information";
            this.SunInfoBT.UseVisualStyleBackColor = true;
            // 
            // NextBT
            // 
            this.NextBT.Location = new System.Drawing.Point(434, 15);
            this.NextBT.Margin = new System.Windows.Forms.Padding(6);
            this.NextBT.Name = "NextBT";
            this.NextBT.Size = new System.Drawing.Size(117, 41);
            this.NextBT.TabIndex = 0;
            this.NextBT.Text = "Next";
            this.NextBT.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 524);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextBT);
            this.Controls.Add(this.SunInfoBT);
            this.Controls.Add(this.PreviousBT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PreviousBT;
        private System.Windows.Forms.Button SunInfoBT;
        private System.Windows.Forms.Button NextBT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

