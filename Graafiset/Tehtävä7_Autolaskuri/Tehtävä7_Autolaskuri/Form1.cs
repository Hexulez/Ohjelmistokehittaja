using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tehtävä7_Autolaskuri
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vastaus();
            tarkista();
            
        }

        private void tarkista()
        {
            int errornmb = 0;
            try
            {
                double.Parse(LainaTB.Text);
                double.Parse(NesteetTB.Text);
                double.Parse(VakuutusTB.Text);
                double.Parse(PolttoaineTB.Text);
                double.Parse(muutTB.Text);
                double.Parse(PesuTB.Text);
                double.Parse(HuollotTB.Text);
                double.Parse(RenkaatTB.Text);
                double.Parse(KMTB.Text);
                
            }
            catch
            {
                errornmb += 1;
                ErrorLB.Visible = true;
            }
            if (errornmb == 0 )
            {
                ErrorLB.Visible = false;
            }
            
        }

        private void vastaus()
        {
            double laina, nesteet, vakuutus, polttoaine, muut, pesut, huollot, renkaat, kilometrit, hintaPerKM;
            laina = Desimaaliksi(LainaTB.Text);
            nesteet = Desimaaliksi(NesteetTB.Text);
            vakuutus = KuukausiHinta(VakuutusTB.Text);
            polttoaine = Desimaaliksi(PolttoaineTB.Text);
            muut = Desimaaliksi(muutTB.Text);
            pesut = Desimaaliksi(PesuTB.Text);
            huollot = KuukausiHinta(HuollotTB.Text);
            renkaat = KuukausiHinta(RenkaatTB.Text);
            try
            {
                kilometrit = double.Parse(KMTB.Text);
            }
            catch
            {
                kilometrit = 0;
            }
            hintaPerKM = (laina+ muut + nesteet + vakuutus + polttoaine + pesut + huollot + renkaat) / kilometrit;
            
            PerKM.Text = hintaPerKM.ToString();
            PerKM.Visible = true;

        }

        private double Desimaaliksi(string jono)
        {
            double luku;
            try
            {
                luku = double.Parse(jono);
            }
            catch
            {
                ErrorLB.Text = "Virheellinen syöte";
                ErrorLB.Visible = true;
                return 0;

            }
            return luku;
        }


        private double KuukausiHinta(string arvo)
        {
            double luku;
            try
            {
                luku = double.Parse(arvo);
            }
            catch
            {
                ErrorLB.Text = "Virheellinen syöte";
                ErrorLB.Visible = true;
                return 0;
            }
            return luku/12;
        }
    }
}
