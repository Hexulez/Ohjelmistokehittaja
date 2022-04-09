using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        string turn;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            counter++;
            ((Button)sender).Text = turn;
            if (turn == "X")
            {
                turn = "O";
            }
            else
            {
                turn = "X";
            }
        }

         private void Restart()
         {
            but1.

         }
        

        
    }
}
