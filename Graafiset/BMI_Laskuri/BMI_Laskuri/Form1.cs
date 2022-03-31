using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Laskuri
{
    public partial class Form1 : Form
    {
        String PainoIndex, painoLuokka;
        public  Form1()
        {
            InitializeComponent();
        }

        private void PituusTB_TextChanged(object sender, EventArgs e)
        {
            Kirjoita();
        }

        private void PainoTB_TextChanged(object sender, EventArgs e)
        {
            Kirjoita();
        }

        //Kirjoittaa vastauksen
        private void Kirjoita()
        {
            Vastaus1.Visible = true;
            Vastaus2.Visible = true;
            PainoIndex = BMI(PituusTB.Text, PainoTB.Text);
            if (PainoIndex == "Virheellinen syöte")
            {
                Vastaus1.Text = PainoIndex;
            }
            else
            {
            Vastaus1.Text = "Paino indeksi on " + PainoIndex;

            }
            painoLuokka = Toinen(PainoIndex);
            Vastaus2.Text = painoLuokka;
            if(painoLuokka == "Alipaino")
            {
                Vastaus1.ForeColor = Color.Blue;
                Vastaus2.ForeColor = Color.Blue;
            }
            else if (painoLuokka == "Normaalipaino")
            {
                Vastaus1.ForeColor = Color.Green;
                Vastaus2.ForeColor = Color.Green;
            }
            else if (painoLuokka == "Ylipaino")
            {
                Vastaus1.ForeColor = Color.DarkOrange;
                Vastaus2.ForeColor = Color.DarkOrange;
            }
            else if (painoLuokka == "Huomattava ylipaino")
            {
                Vastaus1.ForeColor = Color.Red;
                Vastaus2.ForeColor = Color.Red;

            }
            else
            {
                Vastaus1.ForeColor = Color.Black;
                Vastaus2.ForeColor = Color.Black;
            }

        }

        //tarkistaa minkälainen paino index on
        private string Toinen(string bmi)
        {
            double index;
            try
            {
                index = Convert.ToDouble(bmi);
            }
            catch
            {
                return "Error with numbers";
            }

            if (index < 18.5)
            {
                return "Alipaino";
            }
            else if (index > 18.5 && index < 24.9)
            {
                return "Normaalipaino";
            }
            else if (index > 25 && index < 39.9)
            {
                return "Ylipaino";
            }
            else if (index > 40)
            {
                return "Huomattava ylipaino";
            }
            else
            {
                return "Error";
            }


        }

        //laskee painoindeksin
        private string BMI(string pituusS, string painoS)
        {
            double pituus, paino; 
            try
            {
                pituus = Convert.ToDouble(pituusS);
                paino = Convert.ToDouble(painoS);
            }
            catch
            {
                return "Virheellinen syöte";
            }
            pituus /= 100;
            if (PainoTB.Text != "" && PituusTB.Text != "")
            {
                double vastaus = Math.Round( paino / (pituus * pituus), 2);
                return vastaus.ToString();
            }
            return "Error?!";
        }
    }
}
