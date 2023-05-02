using DCT.UI.Models;
using DCT.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCT.UI.ViewModels;

namespace DCT.UI.Extensions
{
    public static class CoinExtension
    {
        public static CoinViewModel ToViewModel(this CoinDto coinDto, uint index)
        {
            return new CoinViewModel()
            {
                Index = index,
                Id = coinDto.id,
                Name = coinDto.name,
                PriceUsd = String.Format("{0:0.00}$", coinDto.priceUsd)
            };
        }
    }
}
