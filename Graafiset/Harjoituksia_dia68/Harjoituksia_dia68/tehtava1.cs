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
    public partial class teht1 : Form
    {
        public teht1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Summa();
        }

        private void Summa()
        {
            SummaLB.Text = "x";
            SummaLB.Visible = false;
            
            string tulos = "";
            try
            {
                int luku1 = Int32.Parse(textBox1.Text);
                int luku2 = Int32.Parse(textBox2.Text);
                luku1 += luku2;
                tulos = luku1.ToString();
            }
            catch 
            {
                try
                {
                    float luku1 = float.Parse(textBox1.Text);
                    float luku2 = float.Parse(textBox2.Text);
                    luku1 += luku2;
                    tulos = luku1.ToString();
                }
                catch 
                {
                    SummaLB.Text = "virheellinen luku";
                    SummaLB.Visible = true;
                        
                }

                
            }
            finally
            {
                if (SummaLB.Text == "x")
                {
                    SummaLB.Text = tulos;
                    SummaLB.Visible = true;
                }
                
            }

            

        }
    }
}
