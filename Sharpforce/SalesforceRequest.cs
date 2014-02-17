using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Sharpforce
{
    public class SalesforceRequest
    {
        public HttpMethod Method { get; set; }
        public string BaseUrl { get; set; }
        public string Resource { get; set; }
        public object Body { get; set; }
        public string AccessToken { get; set; }

        /// <summary>
        /// Converts this object into a HttpRequestMessage.
        /// </summary>
        /// <returns></returns>
        public HttpRequestMessage ToHttpRequestMessage()
        {
            var request = new HttpRequestMessage
                          {
                              Method = Method,
                              RequestUri = new Uri(BaseUrl + Resource)
                          };

            if (Body != null)
            {
                var json = JsonConvert.SerializeObject(Body, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            request.Headers.Add("Authorization", "Bearer " + AccessToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return request;
        }
    }
}
