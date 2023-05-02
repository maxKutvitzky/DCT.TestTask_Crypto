using DCT.API;
using DCT.API.Models;
using DCT.UI.Extensions;
using DCT.UI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DCT.UI.Models
{
    public class MainWindowModel
    {
        private ApiManager _apiManager = new ApiManager();
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

        public async Task<CoinViewModel> SearchCoin(string name)
        {
            CoinDto coin = await _apiManager.GetCurrency(name);

            if(coin == null)
            {
                return null;
            }

            return coin.ToViewModel(1);
        }
    }
}
