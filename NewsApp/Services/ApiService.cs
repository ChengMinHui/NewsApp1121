using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
   public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
        
            //var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=007f28685d479c87301b26c4e791264c&lang=en");
            var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category=general{categoryName.ToLower()}&apikey=007f28685d479c87301b26c4e791264c&lang=zh&country=TW");

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
