using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12_10Kysymystä
{

    
    // kysymyksille tehty luokka josta on helppo löytää ja vaihtaa eri kysymykset
    
    internal class Kysymykset
    {
        string[] kysy = 
        { 
            "mikä 1", 
            "mikä 2",
            "mikä 3",
            "mikä 4", 
            "mikä 5",
            "mikä 6",
            "mikä 7",
            "mikä 8", 
            "mikä 9", 
            "mikä 10",
            "Ding ding ding" //täyterivi
        };
        
        string[] oikeatVastaukset = 
        {
            "oikea1",
            "oikea2", 
            "oikea3", 
            "oikea4", 
            "oikea5", 
            "oikea6", 
            "oikea7", 
            "oikea8", 
            "oikea9", 
            "oikea10",
            "ding" //täyterivi
        };
        
        //väärät vaihtoehdot 
        string[,] vaihtoehdot = 
        {
            { "väärä1/1", "väärä2/1", "väärä3/1" },
            { "väärä1/2", "väärä2/2", "väärä3/2" },
            { "väärä1/3", "väärä2/3", "väärä3/3" },
            { "väärä1/4", "väärä2/4", "väärä3/4" },
            { "väärä1/5", "väärä2/5", "väärä3/5" },
            { "väärä1/6", "väärä2/6", "väärä3/6" },
            { "väärä1/7", "väärä2/7", "väärä3/7" },
            { "väärä1/8", "väärä2/8", "väärä3/8" },
            { "väärä1/9", "väärä2/9", "väärä3/9" },
            { "väärä1/10", "väärä2/10", "väärä3/10" },
            { "ding", "ding", "ding" } // täyterivi
            
        };
            
        
        
        
        



        public string OVastaus(int x)
        {
            return oikeatVastaukset[x];
        }

        public string Vaihtoehdot(int y, int x) 
        { 
            return vaihtoehdot[y, x]; 
        }

        
        public string Kysy(int x)
        {
            return kysy[x];
        }
    }
}
