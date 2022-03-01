namespace Harjoitus4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.VuosissaLB = new System.Windows.Forms.Label();
            this.KuukausissaLB = new System.Windows.Forms.Label();
            this.PaivissaLB = new System.Windows.Forms.Label();
            this.TunneissaLB = new System.Windows.Forms.Label();
            this.MinuuteissaLB = new System.Windows.Forms.Label();
            this.SekunteissaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyntymaAikaDT.Location = new System.Drawing.Point(20, 27);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(392, 35);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(458, 28);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(143, 34);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab1.Location = new System.Drawing.Point(101, 125);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(92, 30);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Vuosissa";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab2.Location = new System.Drawing.Point(101, 155);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(125, 30);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Kuukausissa";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab3.Location = new System.Drawing.Point(101, 185);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(84, 30);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "Päivissä";
            this.lab3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab4.Location = new System.Drawing.Point(101, 215);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(105, 30);
            this.lab4.TabIndex = 2;
            this.lab4.Text = "Tunneissa";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab5.Location = new System.Drawing.Point(101, 245);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(125, 30);
            this.lab5.TabIndex = 2;
            this.lab5.Text = "Minuuteissa";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab6.Location = new System.Drawing.Point(101, 275);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(121, 30);
            this.lab6.TabIndex = 2;
            this.lab6.Text = "Sekunteissa";
            this.lab6.Click += new System.EventHandler(this.label5_Click);
            // 
            // VuosissaLB
            // 
            this.VuosissaLB.AutoSize = true;
            this.VuosissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VuosissaLB.Location = new System.Drawing.Point(292, 125);
            this.VuosissaLB.Name = "VuosissaLB";
            this.VuosissaLB.Size = new System.Drawing.Size(23, 30);
            this.VuosissaLB.TabIndex = 2;
            this.VuosissaLB.Text = "x";
            this.VuosissaLB.Visible = false;
            this.VuosissaLB.Click += new System.EventHandler(this.VuosissaLB_Click);
            // 
            // KuukausissaLB
            // 
            this.KuukausissaLB.AutoSize = true;
            this.KuukausissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KuukausissaLB.Location = new System.Drawing.Point(292, 155);
            this.KuukausissaLB.Name = "KuukausissaLB";
            this.KuukausissaLB.Size = new System.Drawing.Size(23, 30);
            this.KuukausissaLB.TabIndex = 2;
            this.KuukausissaLB.Text = "x";
            this.KuukausissaLB.Visible = false;
            // 
            // PaivissaLB
            // 
            this.PaivissaLB.AutoSize = true;
            this.PaivissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaivissaLB.Location = new System.Drawing.Point(292, 185);
            this.PaivissaLB.Name = "PaivissaLB";
            this.PaivissaLB.Size = new System.Drawing.Size(23, 30);
            this.PaivissaLB.TabIndex = 2;
            this.PaivissaLB.Text = "x";
            this.PaivissaLB.Visible = false;
            // 
            // TunneissaLB
            // 
            this.TunneissaLB.AutoSize = true;
            this.TunneissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TunneissaLB.Location = new System.Drawing.Point(292, 215);
            this.TunneissaLB.Name = "TunneissaLB";
            this.TunneissaLB.Size = new System.Drawing.Size(23, 30);
            this.TunneissaLB.TabIndex = 2;
            this.TunneissaLB.Text = "x";
            this.TunneissaLB.Visible = false;
            // 
            // MinuuteissaLB
            // 
            this.MinuuteissaLB.AutoSize = true;
            this.MinuuteissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuuteissaLB.Location = new System.Drawing.Point(292, 245);
            this.MinuuteissaLB.Name = "MinuuteissaLB";
            this.MinuuteissaLB.Size = new System.Drawing.Size(23, 30);
            this.MinuuteissaLB.TabIndex = 2;
            this.MinuuteissaLB.Text = "x";
            this.MinuuteissaLB.Visible = false;
            // 
            // SekunteissaLB
            // 
            this.SekunteissaLB.AutoSize = true;
            this.SekunteissaLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunteissaLB.Location = new System.Drawing.Point(292, 275);
            this.SekunteissaLB.Name = "SekunteissaLB";
            this.SekunteissaLB.Size = new System.Drawing.Size(23, 30);
            this.SekunteissaLB.TabIndex = 2;
            this.SekunteissaLB.Text = "x";
            this.SekunteissaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.SekunteissaLB);
            this.Controls.Add(this.MinuuteissaLB);
            this.Controls.Add(this.TunneissaLB);
            this.Controls.Add(this.PaivissaLB);
            this.Controls.Add(this.KuukausissaLB);
            this.Controls.Add(this.VuosissaLB);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeBT;
        private Label lab1;
        private Label lab2;
        private Label lab3;
        private Label lab4;
        private Label lab5;
        private Label lab6;
        private Label VuosissaLB;
        private Label KuukausissaLB;
        private Label PaivissaLB;
        private Label TunneissaLB;
        private Label MinuuteissaLB;
        private Label SekunteissaLB;
    }
}