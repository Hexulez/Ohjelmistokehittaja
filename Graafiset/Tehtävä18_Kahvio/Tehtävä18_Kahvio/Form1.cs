using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä18_Kahvio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            Tietoa();
        }

        public void Tietoa()
        {
            hideAll();
            MeistaPL.Visible = true;
            //meistaLB.Visible = true;
            meistaLB.Text = MEISTA.Teksti;
        }
        
        private void ruuatBT_Click(object sender, EventArgs e)
        {
            hideAll();
            ruuatPL.Visible = true;
            ruuatLB.Text = RUUAT.ruuatTeksti;
            ruuatHintaLB.Text = RUUAT.ruuatHinta;
            ruuat2LB.Text = RUUAT.ruuat2Teksti;
            ruuatHinta2LB.Text = RUUAT.ruuanHinta2;
        }

        private void hideAll()
        {
            MeistaPL.Visible=false;
            ruuatPL.Visible=false;
            juomatPL.Visible=false;
            herkutPL.Visible=false;
            KoriPL.Visible=false;
            
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            hideAll();
            juomatPL.Visible=true;
            kuumaLB.Text = JUOMAT.juomatHot;
            kuumaHintaLB.Text = JUOMAT.hinnatHot;
            kylmaLB.Text = JUOMAT.juomatCold;
            kylmaHintaLB.Text = JUOMAT.hinnatCold;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            hideAll();
            herkutPL.Visible=true;
            makeisetLB.Text = HERKUT.makeiset;
            makeisetHinta.Text = HERKUT.makeisetHinta;
            muutLB.Text = HERKUT.muut;
            muutHinta.Text = HERKUT.muutHinta;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tietoa();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideAll();
            KoriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
