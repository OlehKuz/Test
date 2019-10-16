using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TradingApiLogin.Extention
{
    public class QueryStringHelper
    {
        //"&OEMarket=" + newOrder.OEMarket + "&OESymbol=" + newOrder.OESymbol
        //public string Message => GetQueryString(this);
        public static string GetQueryStringConstructor(object data)
        {
            var obj = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data));
            int i = 0;
            return string.Join("",obj.Children()
                       .Cast<JProperty>()
                       
                       .Select(j => "+\"&" + j.Name +'='+ "\"+data[" + i++ +"]"));
           
        }

        public static string GetQueryString(object data)
        {
            var obj = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data));
            int i = 0;
            return string.Join("", obj.Children()
                       .Cast<JProperty>()

                       .Select(j => "+\"&" + j.Name + "=\"+" + j.Name));

        }
    }
}
