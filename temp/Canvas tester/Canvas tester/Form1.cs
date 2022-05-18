using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Canvas_tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int paikka = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PressButton(object sender, KeyPressEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour; //luo muuttujan millä määritellään myöhemmin pallojen väri

            snakeColour = Brushes.Black;
            

            canvas.FillEllipse(snakeColour, new Rectangle
            (
            1 * Settings.Width,
            Snake[i].Y * Settings.Height,
            Settings.Width, Settings.Height
            ));


            
        }
    }
}
