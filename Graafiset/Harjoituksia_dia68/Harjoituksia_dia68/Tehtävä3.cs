using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoituksia_dia68
{
    public partial class teht3 : Form
    {
        public teht3()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            laskin();

        }

        private void laskin()
        {
            double luku1, luku2, plus, miinus, kerto, jaettu;
            try
            {

                luku1 = Double.Parse(numero1.Text);
                luku2 = Double.Parse(numero2.Text);

                plus = luku1 + luku2;
                miinus = luku1 - luku2;
                kerto = luku1 * luku2;
                jaettu = luku1 / luku2;

                summa.Text = "lukujen summa " + plus.ToString();
                erotus.Text = "lukujen erotus " + miinus.ToString();
                tulo.Text = "lukujen tulo " + kerto.ToString();
                jako.Text =  "lukujen jako " + jaettu.ToString();

            }
            catch
            {
                summa.Text = "Anna vain numeroita";
                tulo = erotus = jako = summa;
            }
            

        }
    }
}
