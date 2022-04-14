namespace Encrypt_Decrypt
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
            this.encryptTB = new System.Windows.Forms.TextBox();
            this.decryptTB = new System.Windows.Forms.TextBox();
            this.cryptBT = new System.Windows.Forms.Button();
            this.decryptBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.DataDG = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EracryptBT = new System.Windows.Forms.Button();
            this.eraDecryptBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptTB
            // 
            this.encryptTB.Location = new System.Drawing.Point(80, 59);
            this.encryptTB.Margin = new System.Windows.Forms.Padding(6);
            this.encryptTB.Name = "encryptTB";
            this.encryptTB.Size = new System.Drawing.Size(227, 29);
            this.encryptTB.TabIndex = 0;
            // 
            // decryptTB
            // 
            this.decryptTB.Location = new System.Drawing.Point(80, 100);
            this.decryptTB.Margin = new System.Windows.Forms.Padding(6);
            this.decryptTB.Name = "decryptTB";
            this.decryptTB.Size = new System.Drawing.Size(227, 29);
            this.decryptTB.TabIndex = 0;
            // 
            // cryptBT
            // 
            this.cryptBT.Location = new System.Drawing.Point(35, 24);
            this.cryptBT.Name = "cryptBT";
            this.cryptBT.Size = new System.Drawing.Size(89, 35);
            this.cryptBT.TabIndex = 1;
            this.cryptBT.Text = "Crypt";
            this.cryptBT.UseVisualStyleBackColor = true;
            this.cryptBT.Click += new System.EventHandler(this.cryptBT_Click);
            // 
            // decryptBT
            // 
            this.decryptBT.Location = new System.Drawing.Point(35, 65);
            this.decryptBT.Name = "decryptBT";
            this.decryptBT.Size = new System.Drawing.Size(89, 37);
            this.decryptBT.TabIndex = 1;
            this.decryptBT.Text = "Decrypt";
            this.decryptBT.UseVisualStyleBackColor = true;
            this.decryptBT.Click += new System.EventHandler(this.decryptBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(76, 135);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(60, 24);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // DataDG
            // 
            this.DataDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDG.Location = new System.Drawing.Point(41, 184);
            this.DataDG.Name = "DataDG";
            this.DataDG.Size = new System.Drawing.Size(614, 257);
            this.DataDG.TabIndex = 3;
            this.DataDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDG_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cryptBT);
            this.groupBox1.Controls.Add(this.decryptBT);
            this.groupBox1.Location = new System.Drawing.Point(316, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "complex crypting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EracryptBT);
            this.groupBox2.Controls.Add(this.eraDecryptBT);
            this.groupBox2.Location = new System.Drawing.Point(491, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eramake crypting";
            // 
            // EracryptBT
            // 
            this.EracryptBT.Location = new System.Drawing.Point(0, 28);
            this.EracryptBT.Name = "EracryptBT";
            this.EracryptBT.Size = new System.Drawing.Size(163, 35);
            this.EracryptBT.TabIndex = 1;
            this.EracryptBT.Text = "Eramake Crypt";
            this.EracryptBT.UseVisualStyleBackColor = true;
            this.EracryptBT.Click += new System.EventHandler(this.EracryptBT_Click);
            // 
            // eraDecryptBT
            // 
            this.eraDecryptBT.Location = new System.Drawing.Point(0, 63);
            this.eraDecryptBT.Name = "eraDecryptBT";
            this.eraDecryptBT.Size = new System.Drawing.Size(168, 37);
            this.eraDecryptBT.TabIndex = 1;
            this.eraDecryptBT.Text = " Eramake Decrypt";
            this.eraDecryptBT.UseVisualStyleBackColor = true;
            this.eraDecryptBT.Click += new System.EventHandler(this.eraDecryptBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataDG);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.decryptTB);
            this.Controls.Add(this.encryptTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Crypt And decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encryptTB;
        private System.Windows.Forms.TextBox decryptTB;
        private System.Windows.Forms.Button cryptBT;
        private System.Windows.Forms.Button decryptBT;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.DataGridView DataDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EracryptBT;
        private System.Windows.Forms.Button eraDecryptBT;
    }
}

