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
            /*
            for (int i = 0; i < buttonText.Length; i++)
            {

                if (buttonText[i] == "")
                {
                    Console.WriteLine("testi");
                    movesleft++;
                    score = testMiniMax(buttonText, counter, player,deep);
                    Console.WriteLine("palautuu");
                    //Console.WriteLine(testMiniMax(buttonText, counter, player,deep));
                    //Console.WriteLine(i);
                    Console.WriteLine("nämä");
                    if (score > maxScore) 
                    {
                        maxScore = score;
                        moves = i;
                        Console.WriteLine(maxScore + " movesleft" + movesleft);
                    }
                        
                }
                
            }

            */

            moves = testMiniMax(buttonText, counter, player, deep);
            Console.WriteLine("nyt");
            Console.WriteLine(moves);
            return buttonArr[moves];
        }

        public int testMiniMax(string[] buttonText, int counter, int player, int deep)
        {
            counter++;
            deep++;
            Dictionary<int, int> map = new Dictionary<int, int>();
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
                        map.Add(i, -100 + counter);
                        //siirrot.Add(-100 + counter);
                        end = true;
                    }
                    else if (voitto == "O")
                    {
                        map.Add(i, 100 - counter);
                        //siirrot.Add(100 - counter);
                        end = true;
                    }
                    else if (voitto == "" && counter == 9)
                    {
                        map.Add(i, 0 + counter);
                        //siirrot.Add(0 + counter);
                        end = true;
                    }
                    else if(voitto == "" && counter < 9)
                    {
                        map.Add(i,testMiniMax(state, counter, player, deep));
                        //siirrot.Add(testMiniMax(state, counter,player, deep));
                        end = true;
                    }
                    

                    
                       

                            
                    
                    
                    

                }
            }
            
            if (deep == 1)
            {
                List<int> list = new List<int>();
                list = map.Values.ToList();
                int mones = -1, suurin = -9999999;                
                foreach (int i in list)
                {
                    mones++;
                    if (i > suurin)
                    {
                        suurin = mones;
                    }
                }
                Console.WriteLine(map.Keys.ToString());
                return suurin;
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
