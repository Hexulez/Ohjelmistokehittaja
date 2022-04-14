using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public class MINIMAX
    {
        bool end = false;
        int deep = 0, minScore, score;
        public Button MiniMaxInput(Button[] buttonArr, string[] buttonText, int counter)
        {
            int deep = 0;
            int movesleft = 0;
            int player = 1, moves = -999999,  maxScore = -999999999;
            for (int i = 0; i < buttonText.Length; i++)
            {
                if (buttonText[i] == "")
                {
                    Console.WriteLine("testi");
                    movesleft++;
                    score = testMiniMax(buttonText, counter, player,deep);
                    Console.WriteLine("palautuu");
                    Console.WriteLine(testMiniMax(buttonText, counter, player,deep));
                    Console.WriteLine(i);
                    Console.WriteLine("nämä");
                    if (score > maxScore) 
                    {
                        maxScore = score;
                        moves = i;
                        Console.WriteLine(maxScore + " movesleft" + movesleft);
                    }
                        
                }
                
            }
            Console.WriteLine("nyt");
            Console.WriteLine(moves);
            return buttonArr[moves];
        }

        public int testMiniMax(string[] buttonText, int counter, int player, int deep)
        {
            counter++;
            deep++;
            
            List<int> siirrot = new List<int>();
            string voitto;
            if (player == 2)
            {
                player = 1;
            }
            else if (player == 1)
            {
                player = 2;
            }


            for (int i = 0; i < buttonText.Length; i++)
            {
                if (buttonText[i] == "")
                {
                    string[] state = (string[])buttonText.Clone();
                    if (player == 2)
                    {
                        state[i] = "O";
                    }
                    else if (player == 1)
                    {
                        state[i] = "X";
                    }
                    
                    //tarkistaa päättyikö peli
                    voitto = LOGIC.Row(buttonText);
                    if (voitto == "X")
                    {
                        siirrot.Add(-100 + counter);
                        end = true;
                    }
                    else if (voitto == "O")
                    {
                        siirrot.Add(100 - counter);
                        end = true;
                    }
                    else if (voitto == "" && counter == 9)
                    {
                        siirrot.Add(0 + counter);
                        end = true;
                    }
                    else if(voitto == "" && counter < 9)
                    {
                        siirrot.Add(testMiniMax(state, counter,player, deep));
                        end = true;
                    }
                    

                    
                       

                            
                    
                    
                    

                }
            }
            int max = -99999;

            //Console.WriteLine("lista" + siirrot.Count);
            if (player == 2 )
            {
                
                foreach (int i in siirrot)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                    //Console.WriteLine("max " + siirrot.Max());
                    //Console.WriteLine(i.ToString());
                }
                
                return max;
            }
            else if (player == 1)
            {
                int min = 99999;

                foreach (int i in siirrot)
                {
                    if (i < min) { min = i; }
                    
                }
                //Console.WriteLine("Min " + siirrot.Min());
                return min;
            }
            Console.WriteLine(siirrot.ToArray());
            return max;
            
        }
    }
}
