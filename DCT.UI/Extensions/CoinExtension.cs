using DCT.UI.Models;
using DCT.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.UI.Extensions
{
    public static class CoinExtension
    {
        public static CoinModel ToModel(this CoinDto coinDto)
        {
            return new CoinModel()
            {
                Id = coinDto.id,
                ChangePercent24Hr = coinDto.changePercent24Hr,
                Name = coinDto.name,
                PriceUsd = coinDto.priceUsd,
                Symbol = coinDto.symbol,
                VolumeUsd24Hr = coinDto.volumeUsd24Hr
            };
        }
    }
}
