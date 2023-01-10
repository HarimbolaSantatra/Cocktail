using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cocktail.Service
{
    public class ApiClient
    {
        private string BaseAddress;
        public ApiClient(string sourceBaseAdrs)
        {
            BaseAddress = sourceBaseAdrs;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);
        }
    }
}
