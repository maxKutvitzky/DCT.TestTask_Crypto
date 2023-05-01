﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.UI.Models
{
    public class CoinModel
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double PriceUsd { get; set; }
        public double VolumeUsd24Hr { get; set; }
        public double ChangePercent24Hr { get; set; }
    }
}
