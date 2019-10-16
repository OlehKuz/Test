using System;
namespace TradingApiLogin.Models.WebSocket
{
    public class GetMarketResponse60
    {
        public long MESSAGETYPE { get; set; }
        public string LOGTIME { get; set; }//5:30:00
        public long Source { get; set; }
        public long Market { get; set; }
        public long OEToken { get; set; }  //BCCID
        public long OENSEToken { get; set; }
        public long OEBSEToken { get; set; }//BCCToken == BCCInstrumentId
        public long VolumeTradedToday { get; set; }
        public double LastTradedPrice { get; set; }
        public string NetChangeIndicator { get; set; }
        public double NetChange { get; set; }
        public double NetChangePercentage { get; set; }
        public long LastTradeQuantity { get; set; }
        public string LastTradeTime { get; set; } //5:30:00
        public double AverageTradePrice { get; set; }
        public long Quantity1 { get; set; }
        public double Price1 { get; set; }
        public long NumberOFOrders1 { get; set; }
        public long Quantity2 { get; set; }
        public double Price2 { get; set; }
        public long NumberOFOrders2 { get; set; }
        public double Quantity3 { get; set; }
        public double Price3 { get; set; }
        public double NumberOFOrders3 { get; set; }
        public double Quantity4 { get; set; }
        public double Price4 { get; set; }
        public double NumberOFOrders4 { get; set; }
        public double Quantity5 { get; set; }
        public double Price5 { get; set; } //long
        public double NumberOFOrders5 { get; set; }
        public double SellQuantity6 { get; set; }
        public double Price6 { get; set; }
        public long NumberOFOrders6 { get; set; }
        public long SellQuantity7 { get; set; }
        public double Price7 { get; set; }
        public long NumberOFOrders7 { get; set; }
        public long SellQuantity8 { get; set; }
        public double Price8 { get; set; }
        public long NumberOFOrders8 { get; set; }
        public long SellQuantity9 { get; set; }
        public double Price9 { get; set; }
        public long NumberOFOrders9 { get; set; }
        public long SellQuantity10 { get; set; }
        public double Price10 { get; set; }
        public long NumberOFOrders10 { get; set; }
        public long TotalBuyQuantity { get; set; }
        public long TotalSellQuantity { get; set; }
        public double ClosePrice { get; set; }
        public double OpenPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double YearlyLow { get; set; }
        public double YearlyHigh { get; set; }
        public long ValueTradedToday { get; set; }
        public long NumberOFTradesToday { get; set; }
        public double UpperCircuit { get; set; }
        public double LowerCircuit { get; set; }
        public double BuyAvgPrice { get; set; }
        public double SellAvgPrice { get; set; }
        public string LastUpdateTime { get; set; } //5:30:00 AM
        public double TotalTradedValue { get; set; }
        public string DailyPriceRange { get; set; }
        public long OpenIntrest { get; set; }
        public long CALevel { get; set; }
        public double BoardLot { get; set; }
        public double NUMERATOR { get; set; }
        public double DENOMENATOR { get; set; }
        public string IndicativeQTYPrice { get; set; }
    }
}
