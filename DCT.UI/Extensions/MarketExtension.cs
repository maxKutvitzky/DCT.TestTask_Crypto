using DCT.API.Models;
using DCT.UI.ViewModels;
using System;

namespace DCT.UI.Extensions
{
    /// <summary>
    /// Class that contains extension methods for market classes
    /// </summary>
    public static class MarketExtension
    {
        /// <summary>
        /// Convert market DTO to MarketViewModel
        /// </summary>
        /// <param name="market"></param>
        /// <returns></returns>
        public static MarketViewModel ToViewModel(this Market market)
        {
            return new MarketViewModel()
            {
                Name = market.exchangeId,
                FromSymbol = market.baseSymbol,
                ToSymbol = market.quoteSymbol,
                PriceUsd = String.Format(CoinExtension.DEFAULT_NUMBER_FORMAT, market.priceUsd),
                VolumeUsd24Hr = String.Format(CoinExtension.DEFAULT_NUMBER_FORMAT, market.volumeUsd24Hr)
            };
        }
    }
}
