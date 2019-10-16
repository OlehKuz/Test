using System;
using System.Collections.Generic;
using System.Diagnostics;
using TradingApiLogin.Models.WebSocket;

namespace TradingApiLogin.Managers
{
    
    public class MessageManager
    {
        public List<GetMarketResponse> marketUpdates = new List<GetMarketResponse>();
        private JsonResponseConvert converter = new JsonResponseConvert();
        public void HandleMessage(object obj, string message)
        {
            //Debug.WriteLine(message);
            GetMarketResponse marketResponse = (GetMarketResponse)converter.Deserialize(typeof(GetMarketResponse), message, '|');
            marketUpdates.Add(marketResponse);
        }
    }
}
