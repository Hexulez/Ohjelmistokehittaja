namespace Harjoituksia_dia68
{
    partial class teht3
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
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Label();
            this.erotus = new System.Windows.Forms.Label();
            this.tulo = new System.Windows.Forms.Label();
            this.jako = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna 2 lukua niin annan lukujen summan, erotuksen tulon ja jaon";
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(50, 76);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 1;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(207, 76);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ja";
            // 
            // summa
            // 
            this.summa.AutoSize = true;
            this.summa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summa.Location = new System.Drawing.Point(46, 127);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(16, 20);
            this.summa.TabIndex = 3;
            this.summa.Text = "x";
            // 
            // erotus
            // 
            this.erotus.AutoSize = true;
            this.erotus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erotus.Location = new System.Drawing.Point(46, 147);
            this.erotus.Name = "erotus";
            this.erotus.Size = new System.Drawing.Size(16, 20);
            this.erotus.TabIndex = 3;
            this.erotus.Text = "x";
            // 
            // tulo
            // 
            this.tulo.AutoSize = true;
            this.tulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulo.Location = new System.Drawing.Point(46, 167);
            this.tulo.Name = "tulo";
            this.tulo.Size = new System.Drawing.Size(16, 20);
            this.tulo.TabIndex = 3;
            this.tulo.Text = "x";
            // 
            // jako
            // 
            this.jako.AutoSize = true;
            this.jako.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jako.Location = new System.Drawing.Point(46, 187);
            this.jako.Name = "jako";
            this.jako.Size = new System.Drawing.Size(16, 20);
            this.jako.TabIndex = 3;
            this.jako.Text = "x";
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskeBT.Location = new System.Drawing.Point(345, 67);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(100, 34);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Tehtävä3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.jako);
            this.Controls.Add(this.tulo);
            this.Controls.Add(this.erotus);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label1);
            this.Name = "Tehtävä3";
            this.Text = "Tehtävä3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label summa;
        private System.Windows.Forms.Label erotus;
        private System.Windows.Forms.Label tulo;
        private System.Windows.Forms.Label jako;
        private System.Windows.Forms.Button laskeBT;
    }
}