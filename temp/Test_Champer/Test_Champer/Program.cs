using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Champer
{
    internal class Program
    {
        static int calculateGrundy(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            if (n == 3)
                return 3;
            else
                return (5%(3+1));

        }

        // Driver code 
        public static void Main(String[] args)
        {
            int n = 5;
            Console.WriteLine(calculateGrundy(n));

            Console.WriteLine(5%(3+1));
            Console.Read();
        }
    }
}

