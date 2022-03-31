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

            
            
            teht1 f1 = new teht1();
            f1.ShowDialog(); // Shows Form1
            
        }

        private void teht2BT_Click(object sender, EventArgs e)
        {

            teht2 f2 = new teht2();
            f2.ShowDialog(); // Shows Form2

        }

        private void teht3BT_Click(object sender, EventArgs e)
        {

            teht3 f3 = new teht3();
            f3.ShowDialog(); // Shows Form2

        }

        private void teht4BT_Click(object sender, EventArgs e)
        {
            teht4 f4 = new teht4();
            f4.ShowDialog(); // Shows Form4
        }
    }
}
