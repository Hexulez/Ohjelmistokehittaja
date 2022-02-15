using System;
using System.Linq;

namespace harjoituksia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, o, p;
            Console.WriteLine("Anna luku x");
            x = GetNumb();
            Console.WriteLine("Anna luku y");
            y = GetNumb();

            if (x > y)
            {
                Console.WriteLine("{0},{1}", y, x);
            }
            else
            {
                Console.WriteLine("{0},{1}", x, y);
            }

            Console.WriteLine("Anna luku z");
            z = GetNumb();
            Biggest(x, y, z);
            NumbAsWord(x);
            NumbAsWord(y);
            NumbAsWord(z);

            Console.WriteLine("Anna luku o");
            o = GetNumb();
            Console.WriteLine("Anna luku p");
            p = GetNumb();
            BiggestFive(x, y, z, o, p);

            ChooseType();







        }
        
        static int GetNumb()
        {
            int x;
            string inputX = Console.ReadLine();
            Int32.TryParse(inputX, out x);
            return x;
        }

        static void Biggest(int x, int y, int z)
        {
            Console.WriteLine(Math.Max(Math.Max(x, y), z));
        }

        static void NumbAsWord(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viiisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default:
                    Console.WriteLine("numero {0} ei ole 0-9 väliltä", x);
                    break;
            }
        }
        static void BiggestFive(int x, int y, int z, int o, int p)
        {
            int[] numbers = { x, y, z, o, p };
            int biggestNumber = numbers.Max();
            Console.WriteLine("Suurin numero {0}", biggestNumber);
        } 
        
        static void ChooseType()
        {
            string valitse = "";
            while (valitse == "") ;
            Console.WriteLine("Haluatko antaa kokonaisluvun, douple-luvun vai merkkijonon?");
            Console.WriteLine("Kokonaisluku  = int ");
            Console.WriteLine("douple-luku = douple");
            Console.WriteLine("Merkkijono = String");
            valitse = Console.ReadLine();
            switch (valitse)
            {
                case "kokonaisluku":
                    case "int":
                        case "1":
                    Console.WriteLine("anna suuri luku");
                    int luku = Console.ReadLine();
                    Console.WriteLine("Kasvatin lukua yhdellä" + (luku +1));
                case "douple":
                case "douple-luku":
                case "2":

                    Console.WriteLine("Kasvatin douple- lukua yhdellä" + valitse + 1);
                case "merkkijono":
                case "string":
                case "3":
                    Console.WriteLine("Lisäsin * merkin loppuun", valitse)
            }
                
        }
    }
}
