using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_v2
{
    internal class Winning
    {
        public static string Row(string[] buttonArr)
        {
            //tämä array korvaa pitkän if else lausekkeen
            int[,] place = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < 8; i++)
            {
                if (buttonArr[place[i, 0]] == buttonArr[place[i, 1]] && buttonArr[place[i, 2]] == buttonArr[place[i, 1]])
                {
                    if (buttonArr[place[i, 0]] == "X")
                    {
                        return "X";
                    }
                    else if (buttonArr[place[i, 0]] == "O")
                    {
                        return "O";
                    }
                }

            }



            return "";
        }
    }
}
