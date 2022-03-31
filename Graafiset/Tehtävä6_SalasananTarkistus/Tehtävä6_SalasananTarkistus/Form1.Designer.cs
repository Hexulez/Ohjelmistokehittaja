namespace Tehtävä6_SalasananTarkistus
{
    partial class SalasanaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBT = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.NimiLB = new System.Windows.Forms.Label();
            this.VirheLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.VirheLB);
            this.panel1.Controls.Add(this.checkBT);
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.UserTB);
            this.panel1.Controls.Add(this.SalasanaLB);
            this.panel1.Controls.Add(this.NimiLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 465);
            this.panel1.TabIndex = 0;
            // 
            // checkBT
            // 
            this.checkBT.ForeColor = System.Drawing.Color.Black;
            this.checkBT.Location = new System.Drawing.Point(121, 311);
            this.checkBT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBT.Name = "checkBT";
            this.checkBT.Size = new System.Drawing.Size(119, 45);
            this.checkBT.TabIndex = 2;
            this.checkBT.Text = "Tarkista";
            this.checkBT.UseVisualStyleBackColor = true;
            this.checkBT.Click += new System.EventHandler(this.checkBT_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(330, 206);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(234, 35);
            this.PasswordTB.TabIndex = 1;
            // 
            // UserTB
            // 
            this.UserTB.Location = new System.Drawing.Point(330, 124);
            this.UserTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(234, 35);
            this.UserTB.TabIndex = 1;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(116, 210);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(112, 29);
            this.SalasanaLB.TabIndex = 0;
            this.SalasanaLB.Text = "Salasana";
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Location = new System.Drawing.Point(116, 128);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(167, 29);
            this.NimiLB.TabIndex = 0;
            this.NimiLB.Text = "Käyttäjätunnus";
            // 
            // VirheLB
            // 
            this.VirheLB.AutoSize = true;
            this.VirheLB.Location = new System.Drawing.Point(325, 260);
            this.VirheLB.Name = "VirheLB";
            this.VirheLB.Size = new System.Drawing.Size(79, 29);
            this.VirheLB.TabIndex = 1;
            this.VirheLB.Text = "label1";
            this.VirheLB.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 465);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "kyllä se toimi... ";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkistus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button checkBT;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label NimiLB;
        private System.Windows.Forms.Label VirheLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

