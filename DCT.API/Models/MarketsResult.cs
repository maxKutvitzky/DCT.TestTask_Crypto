using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT.API.Models
{
    public class MarketsResult
    {
        public List<Market> data {  get; set; }
        public long timestamp { get; set; }
    }
}
