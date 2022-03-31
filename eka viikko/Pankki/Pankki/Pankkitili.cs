using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pankki
{
    internal class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;


        private Pankkitili() { }
        public Pankkitili(String asiakkaanNimi, double saldo)
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
}
