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
            List<int> list = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;
            map[1] = 2;
            map[5] = 3;
            map[4] = 6;
            
            Console.WriteLine(map.Values.Max(x => x.Key);

            Console.WriteLine("");
            
            list = map.Values.ToList();
            Console.WriteLine(map. ) ;

            //Console.WriteLine(map[list.IndexOf(list.Max())].);

            Console.WriteLine(map.Keys);
            Console.WriteLine(map.Values);
            //Console.WriteLine(map.Values.Max());
            Console.ReadLine();


            /*
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
            */
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
