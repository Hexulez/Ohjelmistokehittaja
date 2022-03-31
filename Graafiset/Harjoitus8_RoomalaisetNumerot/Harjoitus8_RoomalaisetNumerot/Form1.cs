using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus8_RoomalaisetNumerot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RomansLB.Text = Romans(textBox1.Text);
        }

        private string Romans(string luku) 
        {
            try
            {
                Int32.Parse(luku);
            }
            catch 
            {
                return "luku ei kelpaa";
            }
            string romans = "";
            switch (luku.Length)
            {
                case 1:
                    romans = (ykkoset(luku.Substring(0, 1)));
                    break;
                case 2:
                    romans = (kymmenet(luku.Substring(0, 1)));
                    romans += (ykkoset(luku.Substring(1, 1)));
                    break;
                case 3:
                    romans = sadat(luku.Substring(0, 1));
                    romans += (kymmenet(luku.Substring(1, 1)));
                    romans += ykkoset(luku.Substring(2, 1));
                    break;
                case 4:
                    romans = tuhannet(luku.Substring(0, 1));
                    romans += sadat(luku.Substring(1, 1));
                    romans += kymmenet(luku.Substring(2, 1));
                    romans += ykkoset(luku.Substring (3, 1));
                    break;
                default:
                    return "luku ei kelpaa";
            }
            return romans;

        }

        private int StringToNumb(String jono)
        {
                return Convert.ToInt32(jono);
        }

        private string tuhannet(string jono)
        {
            int x = StringToNumb(jono);
            switch (x)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                default:
                    return "";
            }
        }

        private string sadat(string jono)
        {
            int x = StringToNumb(jono);
            switch (x)
            {
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return "CD";
                case 5:
                    return "D";
                case 6:
                    return "DC";
                case 7:
                    return "DCC";
                case 8:
                    return "DCCC";
                case 9:
                    return "CM";
                default: return "";

            }
        }

        private string kymmenet(string jono)
        {
            int x = StringToNumb(jono);
            switch (x)
            {
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return "XL";
                case 5:
                    return "L";
                case 6:
                    return "LX";
                case 7:
                    return "LXX";
                case 8:
                    return "LXXX";
                case 9:
                    return "XC";
                default:
                    return "";

            }
        }

        private string ykkoset(string jono)
        {
            int x = StringToNumb(jono);
            switch (x)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
