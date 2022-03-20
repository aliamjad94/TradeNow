using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeNowLibrary
{
    public class TraderClass
    {
        public int OrderID { get; set; }
        public string Order { get; set; }
        public string Symbol { get; set; }
        public uint Quantity { get; set; }
        public double Price { get; set; }
        public string Route { get; set; }
        public string OrderType { get; set; }
        public string Tif { get; set; }

    }
}
