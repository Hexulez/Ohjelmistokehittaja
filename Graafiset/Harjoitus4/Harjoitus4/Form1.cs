namespace Harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = SyntymaAikaDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            VuosissaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukausissaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PaivissaLB.Text = erotus + " p‰iv‰‰";
            TunneissaLB.Text = (erotus * 24) + " tuntia";
            MinuuteissaLB.Text = (erotus * 24 * 60) + " minuuttia";
            SekunteissaLB.Text = (erotus * 24 * 60 * 60) + " sekuntia";
            VuosissaLB.Visible = true;
            KuukausissaLB.Visible = true;
            PaivissaLB.Visible = true;
            TunneissaLB.Visible = true;
            MinuuteissaLB.Visible=true;
            SekunteissaLB.Visible=true; 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VuosissaLB_Click(object sender, EventArgs e)
        {

        }
    }
}