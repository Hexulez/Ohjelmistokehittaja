using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä6_SalasananTarkistus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void checkBT_Click(object sender, EventArgs e)
        {
            if (UserTB.Text == "Hexulez" && PasswordTB.Text == "1234567")
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                VirheLB.Text = "Virheellinen käyttäjätunnus tai salasana";
                VirheLB.Visible = true;

            }
        }
    }
}
