using System;
using System.Diagnostics;
using Newtonsoft.Json;
using RestSharp.Serializers;

namespace Sharpforce
{
    internal class SalesforceSerializer : ISerializer
    {
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }

        public SalesforceSerializer()
        {
            ContentType = "application/json";
        }

        public string Serialize(object obj)
        {
            if (obj==null) throw new ArgumentNullException();

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings{NullValueHandling = NullValueHandling.Ignore});
            Debug.WriteLine("Serialization; type={0}; json={1}", obj.GetType(), json);
            return json;
        }
    }
}