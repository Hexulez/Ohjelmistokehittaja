using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituksia_dia68_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Menu();
            goto start;
        }

        static public double GetNumbers()
        {
        ERROR1:
            Console.WriteLine("Anna numero");
            try
            {
                double luku = double.Parse(Console.ReadLine());
                return luku;
            }
            catch
            {
                Console.WriteLine("Anna kelvollinen numero");
                goto ERROR1;

            }

        }

        static public int GetNumbersInt()
        {
        ERROR1:
            Console.WriteLine("Anna kokonaisluku");
            try
            {
                int luku = int.Parse(Console.ReadLine());
                return luku;
            }
            catch
            {
                Console.WriteLine("Anna kelvollinen kokonaisluku");
                goto ERROR1;

            }

        }


        static public void Menu()
        {
            double luku1, luku2;
            int nmb1, nmb2;
            double vastaus = 0;
            Console.WriteLine("Paina enter aloittaaksesi");
            Console.ReadLine();
            Console.WriteLine("anna numero minkä ohjelman tahdot käynnistää");
            Console.WriteLine("1. lukujen summa");
            Console.WriteLine("2. celcius faarenhaiteiksi");
            Console.WriteLine("3. Laskutoimitukset");
            Console.WriteLine("4. Jakojäännös");
            Console.WriteLine("5. tervehdys");
            Console.WriteLine("6. kertotaulu");
            Console.WriteLine("7. ikä");
            Console.WriteLine("8. numerot");
            Console.WriteLine("9. positiivinen vai negatiivinen");
            Console.WriteLine("10. Pisin sana");
            string ohjNmb = Console.ReadLine();

            switch (ohjNmb)
            {
                case "1":
                    luku1 = GetNumbers();
                    luku2 = GetNumbers();
                    Console.WriteLine("lukujen summa: " + Summa(luku1, luku2));
                    break;
                case "2":
                    luku1 = GetNumbers();
                    Console.WriteLine(LampoF(luku1));
                    break;
                case "3":
                    luku1 = GetNumbers();
                    luku2 = GetNumbers();
                    Console.WriteLine("lukujen summa: " + Summa(luku1, luku2));
                    Console.WriteLine("Lukujen erotus: " + erotus(luku1, luku2));
                    Console.WriteLine("Lukujen tulo: " + tulo(luku1, luku2));
                    Console.WriteLine("Lukujen Jako: " + jako(luku1, luku2));
                    break;
                case "4":
                    nmb1 = GetNumbersInt();
                    nmb2 = GetNumbersInt();
                    Console.WriteLine("Lukujen jakojäännös: " + jakoJaannos(nmb1, nmb2));
                    break;

                case "5":
                    tervehdys();
                    break;
                case "6":
                    kertotaulu();
                    break;
                case "7":
                    ika();
                    break;
                case "8":
                    numerot();
                    break;
                case "9":
                    PosNeg();
                    break;
                case "10":
                    PisinSana();
                    break;
                default: Console.WriteLine("Anna kelvollinen luku");
                    break;
            }

            
        }


        static public double Summa(double luku1, double luku2)
        {
            return luku1 + luku2;
        }

        static public double LampoF(double luku1)
        {
            return luku1 * 1.8 + 32;
        }

        static public double erotus(double luku1, double luku2)
        {
            return luku1 - luku2;
        }

        static public double tulo(double luku1, double luku2)
        {
            return luku1 * luku2;
        }

        static public double jako(double luku1, double luku2)
        {
            return luku1 / luku2;
        }

        static public int jakoJaannos(int luku1, int luku2)
        {
            return luku1 % luku2;
        }

        static public void tervehdys()
        {
            Console.WriteLine("Kerro nimesi");
            string name = Console.ReadLine();
            Console.WriteLine("Hei " + name + "!");
        }

        static public void kertotaulu()
        {
            int luku1;
            ERROR2:
            luku1 = GetNumbersInt();
            if (luku1 < 1 || luku1 > 10)
            {
                goto ERROR2;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(luku1*i);
            }
        }

        static public void ika()
        {
            int ika = GetNumbersInt();
            if (ika> 25)
            {
                Console.WriteLine(ika + " Näytät ikäistäsi nuoremmalta");
            }
            else
            {
                Console.WriteLine(ika + " Se on hyvä ikä =)");
            }
        }

        static public void numerot()
        {
            int luku1 = GetNumbersInt();
            for (int i = 0; i < luku1; i++)
            {
                Console.Write(luku1 + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(luku1);
            }
        }

        

        static public void PosNeg()
        {
            double luku1 = GetNumbers();
            double luku2 = GetNumbers();
            
            if (luku1 < 0 && luku2 < 0) 
            {
                Console.WriteLine("Molemmat luvut ovat negatiivisiä");
            }
            else if (luku1 > 0 && luku2 > 0)
            {
                Console.WriteLine("Molemmat luvut ovat positiivisiä");
            }
            else if (luku1 == 0 && luku2 == 0)
            {
                Console.WriteLine("Molemmat luvut ovat nolla");
            }
            else if (luku1 > 0 && luku2 == 0 || luku1 == 0 && luku2 > 0)
            {
                Console.WriteLine("Toinen luku on nolla ja toinen positiivinen");
            }
            else if (luku1 < 0 && luku2 == 0 || luku1 == 0 && luku2 < 0)
            {
                Console.WriteLine("Toinen luku on nolla ja toinen negatiivinen");
            }
            else
            {
                Console.WriteLine("Ohjelmassa tapahtui virhe");
            }
        }

        static public void PisinSana()
        {
            Console.WriteLine("Anna lause niin näytän pisimmän sanan siitä");
            string lause = Console.ReadLine();
            string[] sanat = lause.Split(' ');
            string longest ="";
            foreach (string s in sanat)
            {
                if (s.Length > longest.Length)
                {
                    longest = s;
                }
            }
            Console.WriteLine("pisin sana on " + longest);
        }
        
            
    }
}
