using DCT.API;
using DCT.API.Models;
using DCT.UI.Extensions;
using DCT.UI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DCT.UI.Models
{
    /// <summary>
    /// Class that represents model for main window
    /// </summary>
    public class MainWindowModel
    {
        private ApiManager _apiManager = new ApiManager();
        /// <summary>
        /// Get top 10 currencies
        /// </summary>
        public async Task<List<CoinViewModel>> GetTopCoins()
        {
            List<CoinDto> coins = await _apiManager.GetCurrencies(10);
            List<CoinViewModel> coinModels = new List<CoinViewModel>();

            for(int idx = 0; idx < coins.Count; ++idx)
            {
                coinModels.Add(coins[idx].ToViewModel((uint)idx + 1));
            }

            return coinModels;
        }
        /// <summary>
        /// Get currency by its id
        /// </summary>
        public async Task<CoinViewModel> SearchCoin(string id)
        {
            CoinDto coin = await _apiManager.GetCurrency(id);

            if(coin == null)
            {
                return null;
            }

            return coin.ToViewModel(1);
        }
    }
}
