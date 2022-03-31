namespace Harjoituksia_dia68
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teht1BT = new System.Windows.Forms.Button();
            this.teht1LB = new System.Windows.Forms.Label();
            this.label3BT = new System.Windows.Forms.Label();
            this.teht3BT = new System.Windows.Forms.Button();
            this.teht2BT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.jakojaannosBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Laskin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lämpötilan muunnin";
            // 
            // teht1BT
            // 
            this.teht1BT.Location = new System.Drawing.Point(170, 19);
            this.teht1BT.Name = "teht1BT";
            this.teht1BT.Size = new System.Drawing.Size(75, 23);
            this.teht1BT.TabIndex = 1;
            this.teht1BT.Text = "Tehtävä 1";
            this.teht1BT.UseVisualStyleBackColor = true;
            this.teht1BT.Click += new System.EventHandler(this.teht1BT_Click);
            // 
            // teht1LB
            // 
            this.teht1LB.AutoSize = true;
            this.teht1LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teht1LB.Location = new System.Drawing.Point(12, 22);
            this.teht1LB.Name = "teht1LB";
            this.teht1LB.Size = new System.Drawing.Size(96, 20);
            this.teht1LB.TabIndex = 0;
            this.teht1LB.Text = "plussa lasku";
            // 
            // label3BT
            // 
            this.label3BT.AutoSize = true;
            this.label3BT.Location = new System.Drawing.Point(315, 197);
            this.label3BT.Name = "label3BT";
            this.label3BT.Size = new System.Drawing.Size(35, 13);
            this.label3BT.TabIndex = 2;
            this.label3BT.Text = "label3";
            // 
            // teht3BT
            // 
            this.teht3BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teht3BT.Location = new System.Drawing.Point(170, 74);
            this.teht3BT.Name = "teht3BT";
            this.teht3BT.Size = new System.Drawing.Size(75, 23);
            this.teht3BT.TabIndex = 3;
            this.teht3BT.Text = "Tehtävä 3";
            this.teht3BT.UseVisualStyleBackColor = true;
            this.teht3BT.Click += new System.EventHandler(this.teht3BT_Click);
            // 
            // teht2BT
            // 
            this.teht2BT.Location = new System.Drawing.Point(170, 45);
            this.teht2BT.Name = "teht2BT";
            this.teht2BT.Size = new System.Drawing.Size(75, 23);
            this.teht2BT.TabIndex = 3;
            this.teht2BT.Text = "Tehtävä 2";
            this.teht2BT.UseVisualStyleBackColor = true;
            this.teht2BT.Click += new System.EventHandler(this.teht2BT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jakojäännös";
            // 
            // jakojaannosBT
            // 
            this.jakojaannosBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jakojaannosBT.Location = new System.Drawing.Point(170, 103);
            this.jakojaannosBT.Name = "jakojaannosBT";
            this.jakojaannosBT.Size = new System.Drawing.Size(75, 23);
            this.jakojaannosBT.TabIndex = 3;
            this.jakojaannosBT.Text = "Tehtävä 4";
            this.jakojaannosBT.UseVisualStyleBackColor = true;
            this.jakojaannosBT.Click += new System.EventHandler(this.teht4BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teht2BT);
            this.Controls.Add(this.jakojaannosBT);
            this.Controls.Add(this.teht3BT);
            this.Controls.Add(this.label3BT);
            this.Controls.Add(this.teht1BT);
            this.Controls.Add(this.teht1LB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Valikko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teht1BT;
        private System.Windows.Forms.Label teht1LB;
        private System.Windows.Forms.Label label3BT;
        private System.Windows.Forms.Button teht3BT;
        private System.Windows.Forms.Button teht2BT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button jakojaannosBT;
    }
}

