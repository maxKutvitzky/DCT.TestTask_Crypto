using DCT.API.Models;
using DCT.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API
{
    public class ApiManager
    {
        private readonly Client _client = Client.Instance();
        
        public async Task<List<CoinDto>> GetCurrencies(int limit = 100)
        {
            string url = $@"https://api.coincap.io/v2/assets?limit={limit}";

            var result = await _client.GetAsync(url).Result.Content.ReadFromJsonAsync<CoinsResult>();

            return result.data;
        }

        public async Task<List<Market>> GetCurrencyMarkets(string id)
        {
            string url = @$"https://api.coincap.io/v2/assets/{id}/markets";

            var result = await _client.GetAsync(url).Result.Content.ReadFromJsonAsync<MarketsResult>();

            return result.data;
        }

        public async Task<CoinDto> GetCurrency(string id)
        {
            string url = @$"https://api.coincap.io/v2/assets/{id}";

            var result = await _client.GetAsync(url).Result.Content.ReadFromJsonAsync<CoinResult>();

            return result.data;
        }


    }
}
