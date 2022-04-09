namespace Tehtävä18_HarjoitusOppilaitostenTiedoilla
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
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuHenkCB = new System.Windows.Forms.ComboBox();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(165, 140);
            this.oppilaitosCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(218, 32);
            this.oppilaitosCB.TabIndex = 0;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuHenkCB
            // 
            this.vastuuHenkCB.FormattingEnabled = true;
            this.vastuuHenkCB.Location = new System.Drawing.Point(689, 140);
            this.vastuuHenkCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.vastuuHenkCB.Name = "vastuuHenkCB";
            this.vastuuHenkCB.Size = new System.Drawing.Size(218, 32);
            this.vastuuHenkCB.TabIndex = 0;
            this.vastuuHenkCB.TextChanged += new System.EventHandler(this.vastuuHenkCB_TextChanged);
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Location = new System.Drawing.Point(160, 249);
            this.katuosoiteLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(60, 24);
            this.katuosoiteLB.TabIndex = 1;
            this.katuosoiteLB.Text = "label1";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Location = new System.Drawing.Point(160, 301);
            this.postinumeroLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(60, 24);
            this.postinumeroLB.TabIndex = 1;
            this.postinumeroLB.Text = "label1";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(161, 341);
            this.postitoimipaikkaLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(60, 24);
            this.postitoimipaikkaLB.TabIndex = 1;
            this.postitoimipaikkaLB.Text = "label1";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(161, 387);
            this.puhelinLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(60, 24);
            this.puhelinLB.TabIndex = 1;
            this.puhelinLB.Text = "label1";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(685, 236);
            this.titteliLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(60, 24);
            this.titteliLB.TabIndex = 1;
            this.titteliLB.Text = "label1";
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Location = new System.Drawing.Point(685, 288);
            this.sijaintiLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(60, 24);
            this.sijaintiLB.TabIndex = 1;
            this.sijaintiLB.Text = "label1";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Location = new System.Drawing.Point(686, 328);
            this.phoneLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(60, 24);
            this.phoneLB.TabIndex = 1;
            this.phoneLB.Text = "label1";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(686, 374);
            this.emailLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(60, 24);
            this.emailLB.TabIndex = 1;
            this.emailLB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 489);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.vastuuHenkCB);
            this.Controls.Add(this.oppilaitosCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.ComboBox vastuuHenkCB;
        private System.Windows.Forms.Label katuosoiteLB;
        private System.Windows.Forms.Label postinumeroLB;
        private System.Windows.Forms.Label postitoimipaikkaLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label titteliLB;
        private System.Windows.Forms.Label sijaintiLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label emailLB;
    }
}

