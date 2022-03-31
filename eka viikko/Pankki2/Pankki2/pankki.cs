using System;

namespace Pankki2 
{
    /*
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;


        private Pankkitil() { }
        public  Pankkitili(String asiakkaanNimi, double saldo)
        {
            m_asiakkaanNimi = asiakkaanNimi;
            m_saldo = saldo;
        }

        public string AsiakkaanNimi
        { get { return m_asiakkaanNimi; } }

        public double Saldo
        { get { return m_saldo; } }

        public void Otto(double summa)
        {
            if (summa > m_saldo)
            {
                throw new ArgumentException("summa");
            }
            if (summa < 0)
            {
                throw new IndexOutOfRangeException("summa");
            }
            m_saldo -= summa;

        }

        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }



    }
    */


    internal class pankkitili
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


    
