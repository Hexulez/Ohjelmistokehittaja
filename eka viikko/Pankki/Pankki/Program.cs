using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pankki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pankkitili pt = new Pankkitili("hexulez", 1000);
            pt.Pano(500);
            pt.Otto(50);
            Console.WriteLine("nykyinen saldo on: " + pt.Saldo + "Euroa");
            Console.ReadLine();

        }
    }
}
