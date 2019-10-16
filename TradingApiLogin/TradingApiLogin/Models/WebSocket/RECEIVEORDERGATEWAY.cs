

namespace TradingApiLogin.Models.WebSocket
{
    public class RECEIVEORDERGATEWAY : SocketMessage
    {
        public string RECEIVeORDERGATEWAY => "RECEIVEORDERGATEWAY";
        public long LoginId { get; set; } = 97;
        public string SessionKey { get; set; } = "1314690646-01151208206";

        public char ConnectionType { get; set; } = 'N';
    }
}
