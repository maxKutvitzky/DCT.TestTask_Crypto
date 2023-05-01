using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API.Models
{
    internal class CoinsResult
    {
        public List<CoinDto> data { get; set; }
        public long timestamp { get; set; }
    }
}
