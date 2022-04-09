using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;


namespace Tehtävä16_ajastin
{
    public partial class Form1 : Form
    {
        int minuutit, sekuntit, kokonaisAika;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            for ( int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i);
                SekuntitCB.Items.Add(i);
            }
            minuutitCB.SelectedIndex = 30;
            SekuntitCB.SelectedIndex = 0;
            StopBT.Enabled = false;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( kokonaisAika > 0)
            {
                
                kokonaisAika--;
                minuutit = kokonaisAika/60;
                sekuntit = kokonaisAika- minuutit * 60;
                AikaLB.Text = "Aikaa jäljellä: " + minuutit + " min " + sekuntit + " sek";
            }
            else
            {
                AikaLB.Text = "aika loppui";
                SystemSounds.Beep.Play();
                StartBT.Enabled = true;
                
                //StopBT.Enabled= false;
            }
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled= true;
            minuutit = Muunna(minuutitCB.Text);
            sekuntit = Muunna(SekuntitCB.Text);
            kokonaisAika = minuutit * 60 + sekuntit;
            timer1.Enabled = true;
            
            
        }

        private int Muunna(string luku)
        {
            try
            {
                return Int32.Parse(luku);
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
