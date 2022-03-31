namespace Harjoitus12_10Kysymystä
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
            this.kysymysGB = new System.Windows.Forms.GroupBox();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.resetBT = new System.Windows.Forms.Button();
            this.kysymysGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysGB
            // 
            this.kysymysGB.Controls.Add(this.radio4);
            this.kysymysGB.Controls.Add(this.radio3);
            this.kysymysGB.Controls.Add(this.radio2);
            this.kysymysGB.Controls.Add(this.radio1);
            this.kysymysGB.Location = new System.Drawing.Point(114, 75);
            this.kysymysGB.Margin = new System.Windows.Forms.Padding(6);
            this.kysymysGB.Name = "kysymysGB";
            this.kysymysGB.Padding = new System.Windows.Forms.Padding(6);
            this.kysymysGB.Size = new System.Drawing.Size(525, 256);
            this.kysymysGB.TabIndex = 1;
            this.kysymysGB.TabStop = false;
            this.kysymysGB.Text = "groupBox1";
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(55, 199);
            this.radio4.Margin = new System.Windows.Forms.Padding(6);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(133, 28);
            this.radio4.TabIndex = 0;
            this.radio4.TabStop = true;
            this.radio4.Text = "radioButton1";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(55, 157);
            this.radio3.Margin = new System.Windows.Forms.Padding(6);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(133, 28);
            this.radio3.TabIndex = 0;
            this.radio3.TabStop = true;
            this.radio3.Text = "radioButton1";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(55, 114);
            this.radio2.Margin = new System.Windows.Forms.Padding(6);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(133, 28);
            this.radio2.TabIndex = 0;
            this.radio2.TabStop = true;
            this.radio2.Text = "radioButton1";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(55, 72);
            this.radio1.Margin = new System.Windows.Forms.Padding(6);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(133, 28);
            this.radio1.TabIndex = 0;
            this.radio1.Text = "radioButton1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(83, 398);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(60, 24);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // resetBT
            // 
            this.resetBT.Location = new System.Drawing.Point(114, 12);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(129, 54);
            this.resetBT.TabIndex = 1;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Visible = false;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 510);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kysymysGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Kysely";
            this.kysymysGB.ResumeLayout(false);
            this.kysymysGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox kysymysGB;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.Button resetBT;
    }
}

