using System.Diagnostics;
using RestSharp;
using SalesforceSharp.Responses;

namespace SalesforceSharp
{
    public interface ISalesforceRestService
    {
        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        string Query(string query);

        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        QueryResponse<T> Query<T>(string query) where T : new();
    }

    public class SalesforceRestService : ISalesforceRestService
    {
        protected const string DefaultBaseUrl = "https://login.salesforce.com";

        public string AccessToken { get; private set; }
        public string InstanceUrl { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceRestService" /> class using OAuth Refresh Token.
        /// </summary>
        /// <param name="consumerKey">The consumer key.</param>
        /// <param name="consumerSecret">The consumer secret.</param>
        /// <param name="refreshToken">The OAuth refresh token.</param>
        /// <param name="baseUrl">The base URL.</param>
        public SalesforceRestService(string consumerKey, string consumerSecret, string refreshToken, string baseUrl = DefaultBaseUrl)
        {
            // Create the RefreshToken request.
            IRestRequest request = new RestRequest
                                   {
                                       Resource = "/services/oauth2/token",
                                       Method = Method.POST
                                   };

            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("client_id", consumerKey);
            request.AddParameter("client_secret", consumerSecret);
            request.AddParameter("refresh_token", refreshToken);

            IRestClient client = new RestClient();
            client.BaseUrl = baseUrl;
            var response = client.Execute<RefreshTokenResponse>(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorMessage);
                return;
            }

            AccessToken = response.Data.AccessToken;
            InstanceUrl = response.Data.InstanceUrl;
        }

        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        public string Query(string query)
        {
            IRestRequest request = new RestRequest
            {
                Resource = "/services/data/v20.0/query/?q=" + query,
                Method = Method.GET
            };
            request.AddHeader("Authorization", "Bearer " + AccessToken);

            IRestClient client = new RestClient();
            client.BaseUrl = InstanceUrl;
            var response = client.Execute(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorMessage);
                return null;
            }

            return response.Content;
        }

        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        public QueryResponse<T> Query<T>(string query) where T : new()
        {
            IRestRequest request = new RestRequest
            {
                Resource = "/services/data/v20.0/query/?q=" + query,
                Method = Method.GET
            };
            request.AddHeader("Authorization", "Bearer " + AccessToken);

            IRestClient client = new RestClient();
            client.BaseUrl = InstanceUrl;
            var response = client.Execute<QueryResponse<T>>(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorMessage);
            }

            return response.Data;
        }
    }
}
