using DCT.API.Models;
using System.Net.Http.Json;

namespace DCT.API
{
    public class ApiManager
    {
        private readonly Client _client = Client.Instance();
        
        public async Task<List<CoinDto>> GetCurrencies(int limit = 10)
        {
            string url = $@"https://api.coincap.io/v2/assets?limit={limit}";

            var responce = await _client.GetAsync(url).ConfigureAwait(false);

            var result = await responce.Content.ReadFromJsonAsync<CoinsResult>().ConfigureAwait(false);

            return result.data;
        }

        public async Task<List<Market>> GetCurrencyMarkets(string id)
        {
            string url = @$"https://api.coincap.io/v2/assets/{id}/markets";

            var responce = await _client.GetAsync(url).ConfigureAwait(false);

            var result = await responce.Content.ReadFromJsonAsync<MarketsResult>().ConfigureAwait(false);

            return result.data;
        }

        public async Task<CoinDto> GetCurrency(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return null;
            }

            string url = @$"https://api.coincap.io/v2/assets/{id}";

            var responce = await _client.GetAsync(url).ConfigureAwait(false);

            var result = await responce.Content.ReadFromJsonAsync<CoinResult>().ConfigureAwait(false);

            return result.data;
        }


    }
}
