using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API.Models
{
    public class CoinDto
    {
        public string id {  get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public double priceUsd { get; set; }
        public double volumeUsd24Hr { get; set; }
        public double changePercent24Hr { get; set; }


    }
}
