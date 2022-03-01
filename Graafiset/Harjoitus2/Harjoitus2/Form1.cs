namespace Harjoitus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;
        }
    }
}