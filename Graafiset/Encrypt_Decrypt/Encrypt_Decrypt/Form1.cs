using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        CRYPTING crypting = new CRYPTING();
        PASSWORD password = new PASSWORD();
        ERAMAKE eramake = new ERAMAKE();
        public Form1()
        {
            InitializeComponent();
        }

        private void cryptBT_Click(object sender, EventArgs e)
        {
            string teksti = encryptTB.Text;
            password.Encrypt(teksti, 1);
            encryptTB.Text = "";
            DataDG.DataSource = password.HaeSalasanat();
        }

        private void decryptBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = crypting.Decrypt(decryptTB.Text);
            vastausLB.Visible = true;
            
        }

        private void DataDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decryptTB.Text = DataDG.CurrentRow.Cells[0].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataDG.DataSource = password.HaeSalasanat();
        }

        private void EracryptBT_Click(object sender, EventArgs e)
        {
            string teksti = encryptTB.Text;
            password.Encrypt(teksti, 2);
            encryptTB.Text = "";
            DataDG.DataSource = password.HaeSalasanat();
        }

        private void eraDecryptBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = eramake.EraDecrypt(decryptTB.Text);
            vastausLB.Visible = true;
        }
    }
}
