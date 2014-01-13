using System.Diagnostics;
using RestSharp;
using SalesforceSharp.Responses;

namespace SalesforceSharp
{
    public class SalesforceRestService
    {
        protected const string DefaultBaseUrl = "https://login.salesforce.com";

        public string AccessToken { get; set; }

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

            if (response.ErrorException == null)
            {
                var content = response.Content;
                Debug.WriteLine(content);
                AccessToken = response.Data.AccessToken;
            }
        }
    }
}
