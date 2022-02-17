using System;
using System.Linq;

namespace harjoituksia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int x, y, z, o, p;      //Määrittelee muuttujat mitä käytämme
            Console.WriteLine("Anna luku x");
            x = GetNumb();  // funktio joka muuttaa annetut merkit numeroiksi
            Console.WriteLine("Anna luku y");
            y = GetNumb();

            if (x > y)      //tulostaa ensin pienemmän numeron
            {
                Console.WriteLine("{0},{1}", y, x);
            }
            else
            {
                Console.WriteLine("{0},{1}", x, y);
            }

            Console.WriteLine("Anna luku z"); //ottaa kolmannen numeron
            z = GetNumb();  //muuttaa sen taas luvuksi
            Biggest(x, y, z);   //vertaa mikä on isoin luku kolmesta
            NumbAsWord(x);  //kirjoittaa luvut kirjaimina
            NumbAsWord(y);
            NumbAsWord(z);

            //ottaa pari numeroa lisää
            Console.WriteLine("Anna luku o");
            o = GetNumb();
            Console.WriteLine("Anna luku p");
            p = GetNumb();
            BiggestFive(x, y, z, o, p); //isoin viidestä

            ChooseType(); //valitse minkä tyyppisen syötteen haluaa antaa

            //bonus laskin
            BonusSystem();

            while (1 == 1)
            {
                KirjoitaNumerot();

                Console.ReadLine();
            }






        }
        
        static int GetNumb()
        {
            int x;
            string inputX = Console.ReadLine();
            try 
            {
                x = Convert.ToInt32(inputX); 
            } 
            catch 
            {
                Console.WriteLine("Sinun täytyy antaa kokonaisluku");
               return GetNumb();
            }
            return x;
        }

        static void Biggest(int x, int y, int z)
        {
            Console.WriteLine(Math.Max(Math.Max(x, y), z));
        }

        static void NumbAsWord(int x)
        {
            switch (x)
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
        static void BiggestFive(int x, int y, int z, int o, int p)
        {
            int[] numbers = { x, y, z, o, p };
            int biggestNumber = numbers.Max();
            Console.WriteLine("Suurin numero {0}", biggestNumber);
        } 
        
        static void ChooseType()
        {
            string valitse = "";
            while (valitse == "")
            {

                Console.WriteLine("Haluatko antaa kokonaisluvun, douple-luvun vai merkkijonon?");
                Console.WriteLine("Kokonaisluku  = int ");
                Console.WriteLine("douple-luku = douple");
                Console.WriteLine("Merkkijono = String");
                valitse = Console.ReadLine();
                switch (valitse)
                {
                    case "kokonaisluku":
                    case "int":
                    case "1":
                        Console.WriteLine("anna suuri luku");
                        string temp = Console.ReadLine();
                        try
                        {
                            int luku = Convert.ToInt32(temp);
                            
                            Console.WriteLine("Kasvatin lukua yhdellä: " + (luku + 1));
                        }
                        catch
                        {
                            Console.WriteLine("Sinun pitää antaa kokonaisluku");
                            valitse = "";
                        }
                                            
                        break;
                        
                    case "douple":
                    case "douple-luku":
                    case "2":
                        Console.WriteLine("anna Desimaali");
                        temp = Console.ReadLine();
                        try
                        {
                            double desi = Convert.ToDouble(temp);
                            Console.WriteLine("Kasvatin douple- lukua yhdellä: " + (desi + 1));
                        }
                        catch
                        {
                            Console.WriteLine("sinun pitää antaa desimaaliluku");
                            valitse = "";
                        }
                        break;
                    case "merkkijono":
                    case "string":
                    case "3":
                        Console.WriteLine("anna Merkkijono");
                        temp = Console.ReadLine();
                        Console.WriteLine("Lisäsin * merkin loppuun: " + temp + "*");
                        break;

                    default:
                        valitse = "";
                        break;
                }
            }   
        }

        static void BonusSystem()
        {
            Console.WriteLine("Anna bonus pisteiden määrä (1-9)");
            int bonus = GetNumb();
            switch (bonus)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Pisteiden määrä on {0}", (bonus * 10));
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("pisteiden määrä on {0}", bonus * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("pisteiden määrä on {0} ", (bonus * 1000));
                    break;
                default:
                    Console.WriteLine("pistemäärän pitää olla väliltä 1-9");
                    BonusSystem();
                    break;

            }
        }

        //kirjoittaa numerot sanoiksi
        static void KirjoitaNumerot()
        {
            Console.WriteLine("anna numero niin kirjoitan sen kirjaimilla");
            int numero = GetNumb();
            string numeroSanana = Convert.ToString(numero);
            string sana, testiSana;
            
            
            switch (numeroSanana.Length) //tarkistaa sanojen pituuden
            {
                case 1:
                    sana = ykkoset(numeroSanana[0]);  //kutsuu funktion joka hoitaa ykköset
                    break;
                case 2:
                    sana = Kymmenet(numeroSanana[0]); //kutsuu funktion joka hoitaa kymmenet
                    testiSana = ykkoset(numeroSanana[1]); // kutsuu funktion joka hoitaa ykköset
                    sana = checkTens(sana, testiSana);  //tarkistaa poikkeukset
                    
                    break;

                case 3:
                    sana = Kymmenet(numeroSanana[1]); //kutsuu kymmenet
                    testiSana = ykkoset(numeroSanana[2]);   //kutsuu ykköset
                    sana = checkTens(sana, testiSana);  //tarkistaa poikkeukset
                    sana = sana.Insert(0, sadat(numeroSanana[0]));  //laittaa sadat funktion tuloksen muuttujan alkuun.
                    break;
                default:
                    sana = "liian iso luku anna pienempi";
                    break;

                   
            }

            
          Console.WriteLine(sana);
            
        }

        //palauttaa ykköset sanoina
        static string ykkoset(char x)
        {
            switch (x)
            {
                case '1':
                    return "yksi";
                case '2':
                    return "kaksi";
                case '3':
                    return "kolme";
                case '4':
                    return "neljä";
                case '5':
                    return "viisi";
                case '6':
                    return "kuusi";
                case '7':
                    return "seitsemän";
                case '8':
                    return "kahdeksan";
                case '9':
                    return "yhdeksän";
                default:
                    return "Nolla";
            }
        }

        //palauttaa kymmenet sanoina
        static string Kymmenet(char x)
        {
            switch (x)
            {
                case '1':
                    return "toista";
                case '2':
                    return "kaksikymmentä";
                case '3':
                    return "kolmekymmentä";
                case '4':
                    return "neljäkymmentä";
                case '5':
                    return "viisikymmentä";
                case '6':
                    return "kuusikymmentä";
                case '7':
                    return "seitsemänkymmentä";
                case '8':
                    return "kahdeksankymmentä";
                case '9':
                    return "yhdeksänkymmentä";
                default:
                    return "";
            }
        }

        //tarkista ja kymmenet ja hoitaa poikkeukset
        static string checkTens(string sana, string testiSana)
        {   
            if (sana == "toista" && testiSana == "Nolla")
            {
                    return "kymmenen";
            }
            else if (sana == "toista")
            {
                    return testiSana + "toista";
            }
            else if (testiSana != "Nolla")
                {
                    return sana + testiSana;
                }
            else 
            {
                return sana;
            }
        }


        //palauttaa satojen arvon 
        static string sadat(char x)
        {
            switch (x)
                { 
                   case '1':
                        return "sata";
                    case '2':
                        return "kaksisataa";
                    case '3':
                        return "kolmesataa";
                    case '4':
                        return "neljäsataa";
                    case '5':
                        return "viisisataa";
                    case '6':
                        return "kuusisataa";
                    case '7':
                        return "seitsemänsataa";
                    case '8':
                        return "kahdeksansataa";
                    case '9':
                        return "yhdeksänsataa";
                    default:
                        return "";
                }
        }
    }
}
