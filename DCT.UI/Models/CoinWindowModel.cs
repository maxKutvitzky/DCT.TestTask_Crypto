using DCT.API;
using DCT.UI.Extensions;
using DCT.UI.ViewModels;
using System.Threading.Tasks;

namespace DCT.UI.Models
{
    /// <summary>
    /// Class that represents model for coin info window
    /// </summary>
    class CoinWindowModel
    {
        private ApiManager _apiManager = new ApiManager();
        /// <summary>
        /// Get currency info from API
        /// </summary>
        /// <param name="id"> Currency id </param>
        public async Task<CoinWindowViewModel> GetCurrency(string id)
        {
            var coinDto = await _apiManager.GetCurrency(id);

            if(coinDto == null)
            {
                return null;
            }

            var coinWindowViewModel = coinDto.ToViewModel();

            var coinMarkets = await _apiManager.GetCurrencyMarkets(coinDto.id);

            foreach (var market in coinMarkets)
            {
                coinWindowViewModel.Markets.Add(market.ToViewModel());
            }

            return coinWindowViewModel;
        }
    }
}
