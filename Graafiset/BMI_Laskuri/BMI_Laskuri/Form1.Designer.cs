namespace BMI_Laskuri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.Vastaus1 = new System.Windows.Forms.Label();
            this.Vastaus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pituus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paino:";
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(161, 43);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(100, 29);
            this.PituusTB.TabIndex = 1;
            this.PituusTB.TextChanged += new System.EventHandler(this.PituusTB_TextChanged);
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(161, 84);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(100, 29);
            this.PainoTB.TabIndex = 1;
            this.PainoTB.TextChanged += new System.EventHandler(this.PainoTB_TextChanged);
            // 
            // Vastaus1
            // 
            this.Vastaus1.AutoSize = true;
            this.Vastaus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Vastaus1.Location = new System.Drawing.Point(56, 140);
            this.Vastaus1.Name = "Vastaus1";
            this.Vastaus1.Size = new System.Drawing.Size(60, 24);
            this.Vastaus1.TabIndex = 2;
            this.Vastaus1.Text = "label3";
            this.Vastaus1.Visible = false;
            // 
            // Vastaus2
            // 
            this.Vastaus2.AutoSize = true;
            this.Vastaus2.Location = new System.Drawing.Point(56, 204);
            this.Vastaus2.Name = "Vastaus2";
            this.Vastaus2.Size = new System.Drawing.Size(60, 24);
            this.Vastaus2.TabIndex = 3;
            this.Vastaus2.Text = "label4";
            this.Vastaus2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 314);
            this.Controls.Add(this.Vastaus2);
            this.Controls.Add(this.Vastaus1);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.Label Vastaus1;
        private System.Windows.Forms.Label Vastaus2;
    }
}

