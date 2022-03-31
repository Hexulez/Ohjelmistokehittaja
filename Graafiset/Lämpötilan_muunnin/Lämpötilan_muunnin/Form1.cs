using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lämpötilan_muunnin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VastausLB.Text = Muunnin(lampoTB.Text);
        }

        private string Muunnin(string lampo)
        {
            double nmb;
            VastausLB.Visible = true;
            try
            {
                nmb = double.Parse(lampo);
            }
            catch { return "Virheellinen lämpötila"; }
            

            if (FahRD.Checked)
            {
                nmb = nmb * 1.8 + 32;
                return nmb.ToString();
            }

            if (CelsiusRD.Checked)
            {
                nmb = (nmb - 32) / 1.8;
                return nmb.ToString();
            }
            
            else 
            {
                return "error!?";
            }
        }
        
        

    }
}
