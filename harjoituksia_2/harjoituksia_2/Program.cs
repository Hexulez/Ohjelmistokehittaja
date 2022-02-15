using System;

namespace harjoituksia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
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
            switch( x)
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
    }
}
