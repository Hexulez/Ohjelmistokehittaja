namespace Harjoitus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            
            string virhe = "Luku virheellinen";
            string lukuJono1 = LukuYksiTB.Text, lukuJono2 = LukuKaksiTB.Text;
            float luku1, luku2;
            try
            {
                luku1 = float.Parse(lukuJono1);
                luku2 = float.Parse(lukuJono2);
            }
            catch
            {
                VastausLB.Text = virhe;
                goto loppu;
            }
            float vastaus;
            string merkki = LaskutoimitusCB.Text;
            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break ;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    virhe = "merkki virheellinen"
                    VastausLB.Text = virhe;
                    goto loppu;
                    
            }
            VastausLB.Text = Convert.ToString(vastaus);
            loppu:
            VastausLB.Visible = true;
        }
    }
}