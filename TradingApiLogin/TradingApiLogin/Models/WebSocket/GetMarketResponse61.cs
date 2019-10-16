using System;
namespace TradingApiLogin.Models.WebSocket
{
    public class GetMarketResponse
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
        public long QuantityBuy { get; set; }
        public double PriceBuy { get; set; }
        public long NumberOFOrdersBuy { get; set; }
        public long QuantitySell { get; set; }
        public double PriceSell { get; set; }
        public long NumberOFOrdersSell { get; set; }
        public double ClosePrice { get; set; }
        public double OpenPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double YearlyLow { get; set; }
        public double YearlyHigh { get; set; }
        public double ValueTradedToday { get; set; }
        public long NumberOFTradesToday { get; set; }
        public double UpperCircuit { get; set; }
        public double LowerCircuit { get; set; }
        public double BuyExchange { get; set; }
        public double SellExchange { get; set; }
        public double ABSOLUTEDIFF { get; set; }
        public double PERCENTAGEDIFF { get; set; }
        public double UNDERLYINGLTP { get; set; }
        public string LastUpdateTime { get; set; }
        public string Symbol { get; set; } //= "ATUL";//?       //"COPPER";//bcccontractcode
        public string Series { get; set; }// = "EQ";
        public string InstrumentType { get; set; }
        public long ExpiryDate { get; set; } //= 1580860800; //= 1569801600;
        public long StrikePrice { get; set; } //= -1;
        public string OptionType { get; set; }//char
        public string ISINNumber { get; set; }
        public string BSEGroup { get; set; }
        public string BSESymbol { get; set; }
        public long BoardLot { get; set; }
        public long DaysToExpiry { get; set; }
        public string Source1 { get; set; }
        public string Market1 { get; set; }
        public long Multiplier { get; set; }
        public long PQFactor { get; set; }
        public long TradingUnit { get; set; }
        public string Expirydate { get; set; }
        public long OpenInterest { get; set; }
        public long OpenInterestHigh { get; set; }
        public long OpenInterestLow { get; set; }
        public string SecurityKey { get; set; }
        public string Filler1 { get; set; }
        public string Filler2 { get; set; }
        public string Filler3 { get; set; }
        public string Filler4 { get; set; }
        public string Filler5 { get; set; }
        public string Filler6 { get; set; }
        public string Filler7 { get; set; }
        public string UnderlyingAsset { get; set; }
        public string SettlementType { get; set; }
        public long RepoTenure { get; set; }
        public string SecurityType { get; set; }
        public string Transferable { get; set; }
        public string FutureLTP { get; set; }
        public long BorrowAMT { get; set; }
        public long BorrowRate { get; set; }
        public long LendAMT { get; set; }
        public long LendRATE { get; set; }
        public long LastTradeRate { get; set; }
        public long LastTradeAMT { get; set; }
    }
}

/*
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
public string IndicativeQTYPrice { get; set; }*/