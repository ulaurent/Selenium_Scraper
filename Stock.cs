using System;
namespace Yahoo_Scrape
{
    public class Stock
    {
        public string StockSymbol { get; set; }
        public string LastPrice { get; set; }
        public string PriceChange { get; set; }
        public string PercentChange { get; set; }
        public string MarketTime { get; set; }
        public Stock()
        {
        }
    }
}
