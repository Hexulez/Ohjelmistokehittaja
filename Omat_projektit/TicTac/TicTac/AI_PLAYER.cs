using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public static class AI_PLAYER
    {
        
        public static Button AiCore(Button[] buttonArr, string[] buttonText , int counter)
        {
            Random random = new Random();
            switch (counter)
            {
                case 1:
                    return First(buttonArr);
                    break;
                case 2:
                    return Rand(buttonArr, buttonText, random);
                    break ;
                case 3:
                    return Third(buttonArr, buttonText);
                    break ;
                case 4:
                    return Rand(buttonArr, buttonText ,random);
                    break;
                case 5:
                    return Fifth(buttonArr, buttonText);
                    break;
                case 6:
                    return Rand(buttonArr, buttonText, random);
                    break;
                case 7:
                    return Seventh(buttonArr, buttonText);
                    break;
                case 8:
                    return Rand(buttonArr, buttonText, random);
                default:
                    return buttonArr[0];
            }
            
        }


        //Tietokone aloittaa vuorot
        private static Button First(Button[] buttonArr)
        {

            return buttonArr[0];
        }

        private static Button Third(Button[] buttonArr, string[] buttonText)
        {
            if (buttonText[1] == "X")
            {
                return buttonArr[4];
            }
            else if (buttonText[3] == "X")
            {
                return buttonArr[4];
            }
            else if (buttonText[8] == "")
            {
                return buttonArr[8];
            }
            else 
            {
                return buttonArr[2];
            }

        }

        private static Button Fifth(Button[] buttonArr, string[] buttonText)
        {
            if (buttonText[4] == "O" && buttonText[8] == "")
            {
                return buttonArr[8];
            }
            else if (buttonText[4] == "O" && buttonText[1] == "X")
            {
                return buttonArr[6];
            }
            else if (buttonText[4] == "O" && buttonText[3] == "X")
            {
                return buttonArr[2];
            }
            else if (buttonText[8] == "O" && buttonText[4] == "")
            {
                return buttonArr[4];
            }
            else if (buttonText[2] == "O" && buttonText[1] == "")
            {
                return buttonArr[1];
            }
            else if (buttonText[8] == "O" && buttonText[4] == "X" && buttonText[2] == "")
            {
                return buttonArr[2];
            }
            else
            {
                return buttonArr[6];
            }

        }

        private static Button Seventh(Button[] buttonArr, string[] buttonText)
        {
            if (buttonText[4] == "O" && buttonText[1] == "X" && buttonText[2] == "")
            {
                return buttonArr[2];
            }
            else if (buttonText[4] == "O" && buttonText[1] == "X" && buttonText[3] == "")
            {
                return buttonArr[3];
            }
            else if (buttonText[4] == "O" && buttonText[3] == "X" && buttonText[1] == "")
            {
                return buttonArr[1];
            }
            else if (buttonText[4] == "O" && buttonText[3] == "X" && buttonText[6] == "")
            {
                return buttonArr[6];
            }
            else if (buttonText[8] == "O" && buttonText[2] == "O" && buttonText[1] == "")
            {
                return buttonArr[1];
            }
            else if (buttonText[8] == "O" && buttonText[2] == "O" && buttonText[5] == "")
            {
                return buttonArr[5];
            }
            else if (buttonText[8] == "O" && buttonText[6] == "0" && buttonText[7] == "")
            {
                return buttonArr[7];
            }
            else if (buttonText[8] == "O" && buttonText[6] == "O" && buttonText[3] == "")
            {
                return buttonArr[3];
            }
            else if (buttonText[0] == "O" && buttonText[2] == "O" && buttonText[6] == "O" && buttonText[3] == "")
            {
                return buttonArr[3];
            }
            else if (buttonText[0] == "O" && buttonText[2] == "O" && buttonText[6] == "O" && buttonText[4] == "")
            {
                return buttonArr[4];
            }
            else
            {
                return buttonArr[3];
            }

        }



        //
        //Pelaaja Aloittaa
        //
        private static Button Rand(Button[] buttonArr, string[] buttonText, Random random)
        {
        findEmpty:
            int rnd = random.Next(0, 9);
            if (buttonText[rnd] == "")
            {
                return buttonArr[rnd];
            }
            goto findEmpty;
            
        }

        private static Button Second(Button[] buttonArr, string[] buttonText, Random random)
        {
        findEmpty:
            int rnd = random.Next(0, 9);
            if (buttonText[rnd] == "")
            {
                return buttonArr[rnd];
            }
            goto findEmpty;

        }
        private static Button Fourth(Button[] buttonArr, string[] buttonText)
        {
            if (buttonText[8] == "")
            {
                return buttonArr[8];
            }
            else
            {
                return buttonArr[2];
            }

        }

        private static Button Sixth(Button[] buttonArr, string[] buttonText)
        {
            return buttonArr[1];
        }
    }
}
