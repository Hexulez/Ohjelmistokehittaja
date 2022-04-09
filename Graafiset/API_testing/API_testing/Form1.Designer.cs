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
            this.comicImage = new System.Windows.Forms.PictureBox();
            this.testi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousBT
            // 
            this.PreviousBT.Location = new System.Drawing.Point(143, 15);
            this.PreviousBT.Margin = new System.Windows.Forms.Padding(6);
            this.PreviousBT.Name = "PreviousBT";
            this.PreviousBT.Size = new System.Drawing.Size(117, 41);
            this.PreviousBT.TabIndex = 0;
            this.PreviousBT.Text = "Previous";
            this.PreviousBT.UseVisualStyleBackColor = true;
            this.PreviousBT.Click += new System.EventHandler(this.PreviousBT_Click);
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
            this.NextBT.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // comicImage
            // 
            this.comicImage.Location = new System.Drawing.Point(12, 83);
            this.comicImage.Name = "comicImage";
            this.comicImage.Size = new System.Drawing.Size(825, 700);
            this.comicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.comicImage.TabIndex = 1;
            this.comicImage.TabStop = false;
            // 
            // testi
            // 
            this.testi.AutoSize = true;
            this.testi.Location = new System.Drawing.Point(139, 56);
            this.testi.Name = "testi";
            this.testi.Size = new System.Drawing.Size(60, 24);
            this.testi.TabIndex = 2;
            this.testi.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 806);
            this.Controls.Add(this.testi);
            this.Controls.Add(this.comicImage);
            this.Controls.Add(this.NextBT);
            this.Controls.Add(this.SunInfoBT);
            this.Controls.Add(this.PreviousBT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousBT;
        private System.Windows.Forms.Button SunInfoBT;
        private System.Windows.Forms.Button NextBT;
        private System.Windows.Forms.PictureBox comicImage;
        private System.Windows.Forms.Label testi;
    }
}

