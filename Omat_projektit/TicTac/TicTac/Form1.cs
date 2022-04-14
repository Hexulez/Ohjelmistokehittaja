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
        string turn = "X" , aloittava = "X";
        int counter = 2, p1Win, p2Win;
        
        
        
        public Form1()
        {
            InitializeComponent();
            selectCB.Items.Add("1 Player");
            selectCB.Items.Add("2 Player");
            selectCB.SelectedIndex = 0;
        }
        
        
        //Pelilaudan nappien tapahtuma
        private void button_Click(object sender, EventArgs e)
        {
            
            
            ((Button)sender).Text = turn;
            soloLoop:   //tarkistus loop 
            if (turn == "X")
            {
                turn = "O";
            }
            else if (turn == "O")
            {
                turn = "X";
            }
            ((Button)sender).Enabled = false;
            Win(); //kutsuu voitton tarkastuksen
            end();
            statusLB.Text = "Pelaajan "+ turn + " vuoro";
            if (selectCB.SelectedIndex == 0) // jos tietokone pelaaja on kytketty päälle niin ehto täyttyy
            {
                if (turn == "O")    //antaa tietokoneen tehdä siirron silloin kun on sen vuoro.
                {
                    
                    TestiLB.Text = counter.ToString();
                    MiniMax();
                    //ComputerMove();
                    counter++;
                    goto soloLoop; // hyppää takaisin jotta voi tehdä saman tarkistuksen kun pelaajallekin.

                }
                else
                {
                    counter++;
                }
            }
            
        }

        //tarkistaa jos maksimi määrä siirtoja on tehty
        private void end()
        {

            if (counter == 9)
            {
                Restart();
            }
        }

        //valitsee onko 1 vai 2 pelaajan peli ja nollaa pisteet
        
        private void selectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCB.SelectedIndex == 0)
            {
                
                p1Win = 0;
                p2Win = 0;
                Restart();
            }
            else if (selectCB.SelectedIndex == 1)
            {
                
                p1Win = 0;
                p2Win = 0;
                Restart();

            }
        }
        

        //restart nappi tekee sen mitä luvataankin
        private void restartBT_Click(object sender, EventArgs e)
        {
            Restart();
        }


        //käynnistää uudelleen sekä asettaa arvot oikein.
        private void Restart()
        {
            Button[] buttons = { but1, but2, but3, but4, but5, but6, but7, but8, but9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
            }
            counter = 1;
            if (aloittava == "X")
            {
                turn = "O";
                aloittava = "O";
            }
            else 
            {
                turn = "X";
                aloittava = "X";
            }
            statusLB.Text = "Pelaajan "+ turn + " vuoro";
            winP1.Text = "Pelaaja 1 (X)" + p1Win;
            winP2.Text = "Pelaaja 2 (O)" + p2Win;
            //lisäys??
            if (selectCB.SelectedIndex == 0) // jos tietokone pelaaja on kytketty päälle niin ehto täyttyy
            {
                if (turn == "O")    //antaa tietokoneen tehdä siirron silloin kun on sen vuoro.
                {
                    counter = 1;
                    TestiLB.Text = counter.ToString();
                    MiniMax();
                    //ComputerMove();
                    counter = 2;
                    turn = "X";
                }
            }

        }


        //tarkistaa voittaako jompikumpi
        private void Win()
        {
            string[] buttons = { but1.Text, but2.Text, but3.Text, but4.Text, but5.Text, but6.Text, but7.Text, but8.Text, but9.Text };
            string win = LOGIC.Row(buttons);
            if (win == "X") 
            {
                statusLB.Text = "woitto X";
                p1Win++;
                
                Restart();
            }
            else if (win == "O")
            {
                statusLB.Text = "Woitto O";
                p2Win++;
                
                Restart();
            }

            
        }

        // tietokoneen siirrot tulee täältä
        private void ComputerMove()
        {
            string[] buttonsText = { but1.Text, but2.Text, but3.Text, but4.Text, but5.Text, but6.Text, but7.Text, but8.Text, but9.Text };
            Button[] buttons = { but1, but2, but3, but4, but5, but6, but7, but8, but9 };
            Button move = AI_PLAYER.AiCore(buttons, buttonsText, counter);
            move.Text = "O";
            move.Enabled = false;

            if (counter == 1)
            {
                turn = "X";
            }
            else
            {
                turn = "O";
            }
            
            
        }
        
        private void MiniMax()
        {
            MINIMAX minimax = new MINIMAX();
            string[] buttonsText = { but1.Text, but2.Text, but3.Text, but4.Text, but5.Text, but6.Text, but7.Text, but8.Text, but9.Text };
            Button[] buttons = { but1, but2, but3, but4, but5, but6, but7, but8, but9 };
            Button move = minimax.MiniMaxInput(buttons, buttonsText, counter);
            move.Text = "O";
            move.Enabled = false;

            if (counter == 1)
            {
                turn = "X";
            }
            else
            {
                turn = "O";
            }
        }

    }
}
