using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtävä14_Diary
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tiedosto= File.ReadAllText("C:/Users/Hexulez/source/repos/Ohjelmistokehittaja/Graafiset/Tehtävä14_Diary/kirja.txt");
            string teksti = DateTime.Now + ":\n" + TekstiRB.Text + "\n";
            tiedosto += teksti;
            TextWriter text = new StreamWriter("C:/Users/Hexulez/source/repos/Ohjelmistokehittaja/Graafiset/Tehtävä14_Diary/kirja.txt");
            text.Write(tiedosto);
            text.Close();
            Application.Exit();
        }
    }
}
