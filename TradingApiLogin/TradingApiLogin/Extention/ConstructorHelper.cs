using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TradingApiLogin.Extention
{
    //dont put jsonproperty on response
    public class ConstructorHelper
    {
        public static string GetConstructorData(object data)
        {
            var obj = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data));
            int i = 0;
            return string.Join(';', obj.Children()
                       .Cast<JProperty>()

                       .Select(j => j.Name + '=' + "data[" + i++ + "]"));

        }
    }
}
