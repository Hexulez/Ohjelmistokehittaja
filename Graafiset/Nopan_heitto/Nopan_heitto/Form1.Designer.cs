namespace Nopan_heitto
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
            this.Dice1PB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Dice2PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice1PB
            // 
            this.Dice1PB.Image = global::Nopan_heitto.Properties.Resources.dice06;
            this.Dice1PB.Location = new System.Drawing.Point(128, 79);
            this.Dice1PB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Dice1PB.Name = "Dice1PB";
            this.Dice1PB.Size = new System.Drawing.Size(241, 266);
            this.Dice1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice1PB.TabIndex = 0;
            this.Dice1PB.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll dice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dice2PB
            // 
            this.Dice2PB.Image = global::Nopan_heitto.Properties.Resources.dice06;
            this.Dice2PB.Location = new System.Drawing.Point(424, 79);
            this.Dice2PB.Margin = new System.Windows.Forms.Padding(6);
            this.Dice2PB.Name = "Dice2PB";
            this.Dice2PB.Size = new System.Drawing.Size(241, 266);
            this.Dice2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice2PB.TabIndex = 0;
            this.Dice2PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(726, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dice2PB);
            this.Controls.Add(this.Dice1PB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Nopat";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice1PB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Dice2PB;
    }
}

