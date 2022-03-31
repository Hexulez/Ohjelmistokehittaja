namespace Lämpötilan_muunnin
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
            this.lampoTB = new System.Windows.Forms.TextBox();
            this.FahRD = new System.Windows.Forms.RadioButton();
            this.CelsiusRD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lampoTB
            // 
            this.lampoTB.Location = new System.Drawing.Point(92, 59);
            this.lampoTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lampoTB.Name = "lampoTB";
            this.lampoTB.Size = new System.Drawing.Size(180, 29);
            this.lampoTB.TabIndex = 0;
            this.lampoTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FahRD
            // 
            this.FahRD.AutoSize = true;
            this.FahRD.Checked = true;
            this.FahRD.Location = new System.Drawing.Point(53, 43);
            this.FahRD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FahRD.Name = "FahRD";
            this.FahRD.Size = new System.Drawing.Size(119, 28);
            this.FahRD.TabIndex = 1;
            this.FahRD.TabStop = true;
            this.FahRD.Text = "Fahrenheit";
            this.FahRD.UseVisualStyleBackColor = true;
            // 
            // CelsiusRD
            // 
            this.CelsiusRD.AutoSize = true;
            this.CelsiusRD.Location = new System.Drawing.Point(53, 83);
            this.CelsiusRD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CelsiusRD.Name = "CelsiusRD";
            this.CelsiusRD.Size = new System.Drawing.Size(89, 28);
            this.CelsiusRD.TabIndex = 1;
            this.CelsiusRD.Text = "Celsius";
            this.CelsiusRD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CelsiusRD);
            this.groupBox1.Controls.Add(this.FahRD);
            this.groupBox1.Location = new System.Drawing.Point(338, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(229, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kummaksi muutat";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(79, 184);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(60, 24);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "label1";
            this.VastausLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anna lämpötila";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lampoTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lampoTB;
        private System.Windows.Forms.RadioButton FahRD;
        private System.Windows.Forms.RadioButton CelsiusRD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label label1;
    }
}

