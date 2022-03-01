using System;
using System.Threading;


namespace Multithread_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();

            Thread.Sleep(2000);
            Console.WriteLine("Main Thread is complete");

        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("timer #1: "+ i+ " seconds");
                Thread.Sleep(1000);
            }
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
    }
}
