using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cocktail.Models;

namespace Cocktail.Service
{
    public class ApiManager
    {
        public static int api_key = 1; // CocktailDb developper test API key
        public async Task<CocktailList> SearchCocktail(string searchQuery)
        {
            string requestUrl = "www.thecocktaildb.com/api/json/v1/1/search.php?";
            string parameter = $"s={searchQuery}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(requestUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(parameter).ConfigureAwait(false);
            
            // SUITE VOIR PAGE MEDIUM
        }

        public void SearchIngredient(string searchQuery)
        {
            string requestUrl = $"www.thecocktaildb.com/api/json/v1/1/search.php?i={searchQuery}";
        }
    }
}
