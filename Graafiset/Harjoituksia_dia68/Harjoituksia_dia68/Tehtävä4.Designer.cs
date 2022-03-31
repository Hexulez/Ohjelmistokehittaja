namespace Harjoituksia_dia68
{
    partial class teht4
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
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.TulosLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(67, 54);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 0;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(211, 54);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 0;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(69, 20);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(389, 20);
            this.a.TabIndex = 1;
            this.a.Text = "Anna 2  koko lukua niin näytän niiden jako jäännöksen";
            // 
            // TulosLB
            // 
            this.TulosLB.AutoSize = true;
            this.TulosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TulosLB.Location = new System.Drawing.Point(64, 91);
            this.TulosLB.Name = "TulosLB";
            this.TulosLB.Size = new System.Drawing.Size(180, 20);
            this.TulosLB.TabIndex = 2;
            this.TulosLB.Text = "Lukujen jakojäännös on ";
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(362, 51);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 3;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Tehtävä4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 124);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.TulosLB);
            this.Controls.Add(this.a);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Name = "Tehtävä4";
            this.Text = "Tehtävä4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label TulosLB;
        private System.Windows.Forms.Button laskeBT;
    }
}