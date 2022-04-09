using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtävä13_SuosikkiNimet
{
    public partial class form1 : Form
    {
        string[] pojat = File.ReadAllLines("C:/Users/Hexulez/source/repos/Ohjelmistokehittaja/Graafiset/Tehtävä13_SuosikkiNimet/Pojat.txt");
        string[] tytot = File.ReadAllLines("C:/Users/Hexulez/source/repos/Ohjelmistokehittaja/Graafiset/Tehtävä13_SuosikkiNimet/Tytot.txt");
        public form1()
        {
            InitializeComponent();
            
            
        }

        public void TarkistaBT_Click(object sender, EventArgs e)
        {
            NimienTarkistus();
        }

        private void NimiTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NimienTarkistus();
            }
        }

        private void NimienTarkistus()
        {
            label2.Visible = false;
            int laskuri = 1;
            string nimi = IsoK(NimiTB.Text);
            foreach (string poika in pojat)
            {
                if (poika == nimi)
                {
                    label2.Text = "nimesi on listalla sijalla " + laskuri;
                    label2.Visible = true;
                }
                laskuri++;

            }
            laskuri = 1;
            foreach (string girl in tytot)
            {
                if (girl == nimi)
                {
                    label2.Text = "nimesi on listalla sijalla " + laskuri;
                    label2.Visible = true;
                }
                laskuri++;
            }
            if (label2.Visible == false)
            {
                label2.Text = "Nimesi ei ole listalla!";
                label2.Visible = true;
            }
        }

        private string IsoK(string nimi)
        {
            try
            {
                return char.ToUpper(nimi[0]) + nimi.Substring(1);
            }
            catch { return "Error"; }

        }
    }
}
