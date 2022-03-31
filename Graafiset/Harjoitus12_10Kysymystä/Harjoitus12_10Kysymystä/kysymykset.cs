using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12_10Kysymystä
{
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
            "Ding ding ding" 
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
            "ding" 
        };
        
        string[,] vaihtoehdot = 
        {
            { "väärä1/1", "väärä2/1", "väärä3/1" },
            { "väärä1/2", "väärä2/2", "väärä3/2" },
            { "väärä1/3", "väärä2/3", "väärä3/3" },
            { "väärä1/1", "väärä2/1", "väärä3/1" },
            { "väärä1/2", "väärä2/2", "väärä3/2" },
            { "väärä1/3", "väärä2/3", "väärä3/3" },
            { "väärä1/1", "väärä2/1", "väärä3/1" },
            { "väärä1/2", "väärä2/2", "väärä3/2" },
            { "väärä1/3", "väärä2/3", "väärä3/3" },
            { "väärä1/1", "väärä2/1", "väärä3/1" },
            { "ding", "ding", "ding" }
            
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
