using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API
{
    internal sealed class Client
    {
        private Client() 
        {
            _httpClient = new HttpClient();
        }

        private readonly HttpClient _httpClient;
        private static Client _instance;

        public static Client Instance()
        {
            if (_instance == null)
            {
                _instance = new Client();
            }
            return _instance;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }
    }
}
