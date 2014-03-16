using System;
using System.Net.Http;

namespace Sharpforce
{
    public class SalesforceRequestFactory
    {
        public static SalesforceRequest CreateAddRequest<T>(string accessToken, string instanceUrl, string version, object obj) where T : new()
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}", version, typeof(T).Name),
                Method = HttpMethod.Post,
                Body = obj,
            };
        }

        public static SalesforceRequest CreateGetRequest<T>(string accessToken, string instanceUrl, string version, string id) where T : new()
        {
            return new SalesforceRequest
                   {
                       AccessToken = accessToken,
                       BaseUrl = instanceUrl,
                       Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", version, typeof(T).Name, id),
                       Method = HttpMethod.Get,
                   };
        }

        public static SalesforceRequest CreateUpdateRequest<T>(string accessToken, string instanceUrl, string version, object obj, string id) where T : new()
        {
            return new SalesforceRequest
                   {
                       AccessToken = accessToken,
                       BaseUrl = instanceUrl,
                       Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", version, typeof(T).Name, id),
                       Method = new HttpMethod("PATCH"),
                       Body = obj,
                   };
        }

        public static SalesforceRequest CreateDeleteRequest<T>(string accessToken, string instanceUrl, string version, string id) where T : new()
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", version, typeof(T).Name, id),
                Method = HttpMethod.Delete
            };
        }

        public static SalesforceRequest CreateQueryRequest<T>(string accessToken, string instanceUrl, string version, string query) where T : new()
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = string.Format("/services/data/{0}/query/?q={1}", version, query),
                Method = HttpMethod.Get,
            };
        }

        public static SalesforceRequest CreateVersionsRequest(string accessToken, string instanceUrl, string version)
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = "/services/data/",
                Method = HttpMethod.Get,
            };
        }

        public static SalesforceRequest CreateDescribeRequest(string accessToken, string instanceUrl, string version, string name)
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/describe/", version, name),
                Method = HttpMethod.Get,
            };
        }

        public static SalesforceRequest CreateDescribeGlobalRequest(string accessToken, string instanceUrl, string version)
        {
            return new SalesforceRequest
            {
                AccessToken = accessToken,
                BaseUrl = instanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/", version),
                Method = HttpMethod.Get,
            };
        }
    }
}