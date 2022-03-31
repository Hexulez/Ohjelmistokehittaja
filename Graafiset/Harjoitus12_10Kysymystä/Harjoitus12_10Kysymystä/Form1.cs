using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus12_10Kysymystä
{
    public partial class Form1 : Form
    {
        int kysymysNmr = 0;
        int oikeaVastausNmr, annettu, oikein;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            Logic();
        }
        public void Logic()
        {
            if (kysymysNmr == 11 )
            {
                vastausLB.Text = "oikeita vastastauksia oli " + oikein + ".";
                resetBT.Visible = true;
                kysymysGB.Enabled = false;
                vastausLB.Visible = true;
                kysymysNmr =0;
                Clean();
                

                return;
            }
            else if (radio1.Checked == true || radio2.Checked == true || radio3.Checked == true || radio4.Checked == true )
            {
                Tarkista();
                builder(oikeaVastausNmr);
                kysymysNmr++;
            }
            Clean();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {

            resetBT.Visible = false;
            kysymysGB.Enabled=true;
            vastausLB.Visible=false;
            kysymysNmr = 0;
            oikeaVastausNmr = 0;
            annettu = 0;
            oikein = 0;
            builder(oikeaVastausNmr);
            kysymysNmr++;

            
        }

        

        public void Tarkista()
        {
            if (radio1.Checked == true)
            {
                annettu = 0;
            }
            else if (radio2.Checked == true)
            {
                annettu = 1;
            }
            else if (radio3.Checked == true)
            {
                annettu = 2;
            }
            else if (radio4.Checked == true)
            {
                annettu=3;
            }
            else { annettu = 5; }

            if (oikeaVastausNmr == annettu)
            {
                oikein += 1;
            }
            

        }

        private void Clean()
        {
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            radio4.Checked = false;
        }

        private void builder(int x)
        {
            
            Random rand = new Random();
            oikeaVastausNmr = rand.Next(4);
            int counter = 0;
            Kysymykset kysymykset = new Kysymykset();
            kysymysGB.Text = kysymykset.Kysy(kysymysNmr);
            List<string> list = new List<string>();
            for (int i = 0; i < 4; i++)
            if (oikeaVastausNmr == list.Count)
            {
                list.Add(kysymykset.OVastaus(kysymysNmr));

            }
            else
            {
                list.Add(kysymykset.Vaihtoehdot(kysymysNmr, counter));
                    counter++;
            }
            
            
            object[] radiot = { radio1.Text = list[0],radio2.Text = list[1],radio3.Text = list[2],radio4.Text = list[3]};

            counter = 0;
        }

    }
}
