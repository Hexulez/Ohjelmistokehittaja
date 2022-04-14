namespace Tehtava20_oppilasHallinta
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
            this.idTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.opiskelijaNroTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tietoTauluDG = new System.Windows.Forms.DataGridView();
            this.eraseBT = new System.Windows.Forms.Button();
            this.tallenneBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tietoTauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Location = new System.Drawing.Point(177, 35);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(221, 29);
            this.idTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(615, 35);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(221, 29);
            this.phoneTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puhelin";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(177, 70);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(221, 29);
            this.firstNameTB.TabIndex = 0;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(615, 70);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(221, 29);
            this.emailTB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Etunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sähköposti";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(177, 105);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(221, 29);
            this.lastNameTB.TabIndex = 0;
            // 
            // opiskelijaNroTB
            // 
            this.opiskelijaNroTB.Location = new System.Drawing.Point(615, 105);
            this.opiskelijaNroTB.Name = "opiskelijaNroTB";
            this.opiskelijaNroTB.Size = new System.Drawing.Size(221, 29);
            this.opiskelijaNroTB.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sukunimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Opiskelija numero";
            // 
            // tietoTauluDG
            // 
            this.tietoTauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietoTauluDG.Location = new System.Drawing.Point(56, 197);
            this.tietoTauluDG.Name = "tietoTauluDG";
            this.tietoTauluDG.Size = new System.Drawing.Size(780, 235);
            this.tietoTauluDG.TabIndex = 2;
            this.tietoTauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietoTauluDG_CellContentClick);
            // 
            // eraseBT
            // 
            this.eraseBT.Location = new System.Drawing.Point(74, 149);
            this.eraseBT.Name = "eraseBT";
            this.eraseBT.Size = new System.Drawing.Size(112, 31);
            this.eraseBT.TabIndex = 3;
            this.eraseBT.Text = "Tyhjennä";
            this.eraseBT.UseVisualStyleBackColor = true;
            this.eraseBT.Click += new System.EventHandler(this.eraseBT_Click);
            // 
            // tallenneBT
            // 
            this.tallenneBT.Location = new System.Drawing.Point(228, 149);
            this.tallenneBT.Name = "tallenneBT";
            this.tallenneBT.Size = new System.Drawing.Size(112, 31);
            this.tallenneBT.TabIndex = 3;
            this.tallenneBT.Text = "Tallenna";
            this.tallenneBT.UseVisualStyleBackColor = true;
            this.tallenneBT.Click += new System.EventHandler(this.tallenneBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(380, 149);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(112, 31);
            this.paivitaBT.TabIndex = 3;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(533, 149);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(112, 31);
            this.poistaBT.TabIndex = 3;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 457);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallenneBT);
            this.Controls.Add(this.eraseBT);
            this.Controls.Add(this.tietoTauluDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opiskelijaNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.idTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietoTauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox opiskelijaNroTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tietoTauluDG;
        private System.Windows.Forms.Button eraseBT;
        private System.Windows.Forms.Button tallenneBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

