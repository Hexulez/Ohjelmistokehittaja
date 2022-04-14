using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(3);
            vs.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadLine();

            int luku = 1;
            int numero = Plus(luku);
            Console.WriteLine(numero);
            Console.WriteLine(luku);
            Console.ReadLine();

        }

        private static int Plus(int luku)
        {
            luku++;

            if (luku <9)
            {
                Plus(luku);
            }
            return luku;
        }
    }
}
