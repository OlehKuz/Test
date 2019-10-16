namespace TradingApiLogin.Models.WebSocket
{
    public class GetMarketByPriceModel : SocketMessage//p246
    {
        public string OpenMarketByPrice => "OPENMBP";
        public long LoginId { get; set; }= 97;
        public string SessionKey { get; set; } = "1314690646-01151208206";
        public string KeyIdentifier { get; set; }= "13^1^1";//1,3
    }
}
