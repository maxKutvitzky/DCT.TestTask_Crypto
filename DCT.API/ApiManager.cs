using DCT.API.Models;
using System.Net.Http.Json;

namespace DCT.API
{
    /// <summary>
    /// Class for getting data from crypto API using HTTP requests
    /// </summary>
    public class ApiManager
    {
        private readonly Client _client = Client.Instance();


        /// <summary>
        /// Get list of currencies from crypto API 
        /// </summary>
        /// <param name="limit"> Number of currencies to return beginning from top </param>
        /// <returns></returns>
        public async Task<List<CoinDto>> GetCurrencies(int limit = 10)
        {
            string url = $@"https://api.coincap.io/v2/assets?limit={limit}";

            var responce = await _client.GetAsync(url).ConfigureAwait(false);

            var result = await responce.Content.ReadFromJsonAsync<CoinsResult>().ConfigureAwait(false);

            return result.data;
        }

        /// <summary>
        /// Get list of markets for specific currency
        /// </summary>
        /// <param name="id"> Currency id (returned by GetCurrencies method) </param>
        public async Task<List<Market>> GetCurrencyMarkets(string id)
        {
            string url = @$"https://api.coincap.io/v2/assets/{id}/markets";

            var responce = await _client.GetAsync(url).ConfigureAwait(false);

            var result = await responce.Content.ReadFromJsonAsync<MarketsResult>().ConfigureAwait(false);

            return result.data;
        }
        /// <summary>
        /// Get a currency by its id
        /// </summary>
        /// <param name="id"> Currency id (returned by GetCurrencies method) </param>
        /// <returns></returns>
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
