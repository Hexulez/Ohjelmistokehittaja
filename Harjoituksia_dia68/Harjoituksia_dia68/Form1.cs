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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void teht1BT_Click(object sender, EventArgs e)
        {
            teht1 f2 = new teht1();
            f2.ShowDialog(); // Shows Form2
        }


    }
}
