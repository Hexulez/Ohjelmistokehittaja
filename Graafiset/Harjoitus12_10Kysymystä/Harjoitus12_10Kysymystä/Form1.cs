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

        //logic
        public void Logic()
        {
            if (kysymysNmr == 11 ) //katkaisee kyselyn kun viimeinen kymmenes vastaus on annettu
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

        
        //tarkistaa mikä vastaus on valittu
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


        //kasaa kysymykset satunnaiseen järjestykseen
        private void builder(int oikeanVastauksenNumero)
        {
            int counter = 0;        //laskuri joka laskee että vääriä vastauksia tulee oikeam määrä + auttaa ne paikalleen
            string[] wrong = satunnaiset(); //luodaan taulukko missä väärät vastaukset on satunnaisessa järjestyksessä
            Random rand = new Random();
            oikeaVastausNmr = rand.Next(4); //määritellään oikean vastauksen paikka
            Kysymykset kysymykset = new Kysymykset();
            kysymysGB.Text = kysymykset.Kysy(kysymysNmr); //otetaan oikea kysymys laatikkoon
            List<string> list = new List<string>(); //luodaan uusi lista minkä avulla laitetaan myöhemmin vastaukset satunnaiseen järjestykseen
            for (int i = 0; i < 4; i++)         //loop jolla luodaan lista josta lopulta vastaukset menevät satunnaisille paikoilleen
            if (oikeaVastausNmr == list.Count)
            {
                list.Add(kysymykset.OVastaus(kysymysNmr));

            }
            else
            {
                    list.Add(wrong[counter]);
                    counter++;
            }
            
            //object taulukko on tehty jotta ei tarvi tehdä niin pitkää if else listausta
            object[] radiot = { radio1.Text = list[0],radio2.Text = list[1],radio3.Text = list[2],radio4.Text = list[3]}; 

            counter = 0;
        }

        //laittaa väärät vastaukset satunnaiseen järjestykseen.
        private string[] satunnaiset()
        {
            int del=0;
            Kysymykset kysymykset = new Kysymykset();
            Random rdm = new Random();
            List<string> vastaukset = new List<string>();
            List<string> satunnaiset = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                vastaukset.Add(kysymykset.Vaihtoehdot(kysymysNmr, i));
            }
            for (int u = 0; u < 3; u++)
            {

                del = rdm.Next(vastaukset.Count);
                satunnaiset.Add(vastaukset[del]);
                vastaukset.RemoveAt(del);
            }

            return satunnaiset.ToArray();


        }
            
        
    }
}
