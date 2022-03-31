using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus5_LukujenJärjestys
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "-999")
                {
                    TekstiLB.Text = "";
                    int [] taulukko = list.ToArray();
                    Array.Sort(taulukko);
                    foreach ( var element in taulukko)
                    {
                        TekstiLB.Text += element + " ";
                    }
                    TekstiLB.Visible = true;

                }

                else
                {
                    try
                    {
                        TekstiLB.Visible=false;
                        list.Add(Int32.Parse(textBox1.Text));
                        textBox1.Text = "";
                    }
                    catch 
                    {
                        TekstiLB.Text = "virheellinen luku";
                        textBox1.Text = "";
                        TekstiLB.Visible = true;
                    }
                    
                }
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                EraseText();
            }
        }

        private void EraseText()
        {
            TekstiLB.Text = "";
            list.Clear();
        }

    }
}
