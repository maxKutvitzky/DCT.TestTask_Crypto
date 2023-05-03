using DCT.API.Models;
using System;
using DCT.UI.ViewModels;

namespace DCT.UI.Extensions
{
    /// <summary>
    /// Class that contains extension methods for currency classes
    /// </summary>
    public static class CoinExtension
    {
        public const string DEFAULT_NUMBER_FORMAT = @"{0:0.00}$";
        public const string DEFAULT_PERCENT_FORMAT = @"{0:0.00}%";

        /// <summary>
        /// Convert Coin DTO to CoinViewModel
        /// </summary>
        public static CoinViewModel ToViewModel(this CoinDto coinDto, uint index)
        {
            return new CoinViewModel()
            {
                Index = index,
                Id = coinDto.id,
                Name = coinDto.name,
                PriceUsd = String.Format(DEFAULT_NUMBER_FORMAT, coinDto.priceUsd)
            };
        }

        /// <summary>
        /// Convert Coin DTO to CoinWindowViewModel
        /// </summary>
        public static CoinWindowViewModel ToViewModel(this CoinDto coinDto)
        {
            return new CoinWindowViewModel()
            {
                Id = coinDto.id,
                Name = coinDto.name,
                Symbol = coinDto.symbol,
                VolumeUsd24Hr = String.Format(DEFAULT_NUMBER_FORMAT, coinDto.volumeUsd24Hr),
                ChangePercent24Hr = String.Format(DEFAULT_PERCENT_FORMAT, coinDto.changePercent24Hr),
                PriceUsd = String.Format(DEFAULT_NUMBER_FORMAT, coinDto.priceUsd)
            };
        }
    }
}
