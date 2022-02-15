using System;

namespace Laskut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y,z;
            Console.WriteLine("Anna numero x");
            string inputX = Console.ReadLine();
            Console.WriteLine("Anna numero y");
            string inputY = Console.ReadLine();
            Int32.TryParse(inputX, out x);
            Int32.TryParse(inputY, out y);
            
            x = 3 + y;
            Console.WriteLine("3 + {1} = {0}",x,y);
            x = 2 - y;
            Console.WriteLine("2 - {1} = {0}", x, y);
            x = 5 * y;
            Console.WriteLine("5 * {1} = {0}", x, y );
            z = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, z);
            z = x % y;
            Console.WriteLine("{0} % {1} = {2}", x, y, z);
            z = x +y;
            Console.WriteLine("{0} + {1} = {2}", x, y,z);
            z = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, z);
            z = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, z);
            z = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, z);
            Console.ReadLine();
        }
    }
}
