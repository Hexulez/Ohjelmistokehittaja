using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_testing
{
    internal class ComicProsessor
    {
        public async Task LoadComic(int comicNumber = 0)
        {
            string url = "";

            if (comicNumber > 0)
            {
                url = $"https://xkcd.com/{comicNumber}info.0.json";
            }
            else
            {
                url = https://xkcd.com/info.0.json
            }

            using (System.Net.Http.HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url)) ;
            {
                if (response.isSuccessStatusCode)
                {

                }
            }
        }
    }
}
