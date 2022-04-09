namespace testeri
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
            this.previousImageButton = new System.Windows.Forms.Button();
            this.comicImage = new System.Windows.Forms.PictureBox();
            this.nextImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // previousImageButton
            // 
            this.previousImageButton.Location = new System.Drawing.Point(114, 34);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(75, 23);
            this.previousImageButton.TabIndex = 0;
            this.previousImageButton.Text = "button1";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.previousImageButton_Click);
            // 
            // comicImage
            // 
            this.comicImage.Location = new System.Drawing.Point(72, 92);
            this.comicImage.Name = "comicImage";
            this.comicImage.Size = new System.Drawing.Size(659, 302);
            this.comicImage.TabIndex = 1;
            this.comicImage.TabStop = false;
            // 
            // nextImageButton
            // 
            this.nextImageButton.Location = new System.Drawing.Point(253, 34);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(75, 23);
            this.nextImageButton.TabIndex = 0;
            this.nextImageButton.Text = "button1";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comicImage);
            this.Controls.Add(this.nextImageButton);
            this.Controls.Add(this.previousImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousImageButton;
        private System.Windows.Forms.PictureBox comicImage;
        private System.Windows.Forms.Button nextImageButton;
    }
}

