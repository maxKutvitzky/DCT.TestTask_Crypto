using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API.Models
{
    public class Market
    {
        public string exchangeId { get; set; }
        public string baseId { get; set; }
        public string quoteId { get; set; }
        public string baseSymbol { get; set; }
        public string quoteSymbol { get; set; }
        public double volumeUsd24Hr { get; set; }
        public double priceUsd { get; set; }
        public double volumePercent { get; set; }

    }
}
