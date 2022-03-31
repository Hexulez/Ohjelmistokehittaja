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
    public partial class teht4 : Form
    {
        public teht4()
        {
            InitializeComponent();
        }

        private void Jakojaannos()
        {
            int luku1, luku2, jaannos;
            string tulos ="";
            
            try
            {
                luku1 = int.Parse(numero1.Text);
                luku2 = int.Parse(numero2.Text);
                jaannos = luku1 % luku2;
                tulos = "Lukujen jakojäännös on: " + jaannos;
            }
            catch
            {
                tulos = "Anna kokonaisluvut";
                
            }
            finally
            {
                TulosLB.Text = tulos;
            }



        }
            


        

        private void laskeBT_Click(object sender, EventArgs e)
        {
            Jakojaannos();
        }
    }
}
