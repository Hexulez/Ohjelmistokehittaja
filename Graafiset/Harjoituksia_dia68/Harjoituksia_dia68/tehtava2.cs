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
    public partial class teht2 : Form
    {
        public teht2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lampo();
        }

        private void lampo()
        {
            try
            {
                double asteet = double.Parse(Cel.Text);
                asteet = asteet * 1.8 + 32;

                lampoLB.Text = "= " + asteet.ToString() + "F";
            }
            catch 
            {
                lampoLB.Text = "= Annna lämpötila kokonaislukuna"; 
            }

        }

    }
}
