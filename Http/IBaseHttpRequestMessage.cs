using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Fintatech.TDS.Cm.BOW.Common.Messages.Requests.Http
{
    public interface IBaseHttpRequestMessage
    {
        string ToQueryString();
    }
}