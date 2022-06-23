using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Button> buttonList = MakeList();
        }
        string turn = "X";
        
        
        
        
        private List<Button> MakeList()
        {
            List<Button> list = new List<Button>();
            list.Add(GameBoard1);
            list.Add(GameBoard2);
            list.Add(GameBoard3);
            list.Add(GameBoard4);
            list.Add(GameBoard5);
            list.Add(GameBoard6);
            list.Add(GameBoard7);
            list.Add(GameBoard8);
            list.Add(GameBoard9);
            return list;
        }
        


        private string changeTurn(string turn)
        {
            if ( turn == "X")
            {
                return "Y";
            }
            else
            {
                return "X";
            }
        }

            


        
        private void Game_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            
        }
    }
}
