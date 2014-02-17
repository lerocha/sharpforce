using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Sharpforce.Responses;

namespace Sharpforce
{
    public class SalesforceClient : ISalesforceClient
    {
        protected const string DefaultBaseUrl = "https://login.salesforce.com";
        protected const string DefaultVersion = "v29.0";

        public string AccessToken { get; private set; }
        public string InstanceUrl { get; private set; }
        public string Version { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceClient" /> class using OAuth Refresh Token.
        /// </summary>
        /// <param name="consumerKey">The consumer key.</param>
        /// <param name="consumerSecret">The consumer secret.</param>
        /// <param name="refreshToken">The OAuth refresh token.</param>
        /// <param name="version">API version to be used.</param>
        /// <param name="baseUrl">The Salesforce base URL.</param>
        public SalesforceClient(string consumerKey, string consumerSecret, string refreshToken,
            string version = DefaultVersion, string baseUrl = DefaultBaseUrl)
        {
            Version = version;

            var httpClient = new HttpClient(new HttpClientHandler());

            // This is the request content
            HttpContent content = new FormUrlEncodedContent(new[]
                                                            {
                                                                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                                                                new KeyValuePair<string, string>("client_id", consumerKey),
                                                                new KeyValuePair<string, string>("client_secret", consumerSecret),
                                                                new KeyValuePair<string, string>("refresh_token", refreshToken),
                                                            });

            // Send request to Salesforce.
            HttpResponseMessage httpResponseMessage = httpClient.PostAsync(baseUrl + "/services/oauth2/token", content).Result;

            // Read response as RefreshTokenResponse.
            var responseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;

            var response = JsonConvert.DeserializeObject(responseContent, typeof (RefreshTokenResponse)) as RefreshTokenResponse;
            if (response != null)
            {
                AccessToken = response.AccessToken;
                InstanceUrl = response.InstanceUrl;
            }

            Debug.WriteLine("AccessToken={0}; StatusCode={1}; Reason={2}; ResponseContent={3}", 
                AccessToken, httpResponseMessage.StatusCode, httpResponseMessage.ReasonPhrase, responseContent);
        }

        /// <summary>
        /// Creates an object in Salesforce.
        /// http://www.salesforce.com/us/developer/docs/api_rest/Content/dome_sobject_create.htm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be created.</param>
        /// <returns></returns>
        public string Add<T>(object obj) where T : new()
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var request = new SalesforceRequest
                                    {
                                        AccessToken = AccessToken,
                                        BaseUrl = InstanceUrl,
                                        Resource = string.Format("/services/data/{0}/sobjects/{1}", Version, typeof(T).Name),
                                        Method = HttpMethod.Post,
                                        Body = obj,
                                    };

            var response = ExecuteRequest<AddResponse>(request);

            // Set Id property with the Id returned in the response.
            if (!obj.GetType().IsAnonymous())
            {
                var property = obj.GetType().GetProperty("Id");
                if (property != null)
                {
                    property.SetValue(obj,response.Data.Id, null);
                }
            }

            return response.Data.Id;
        }

        /// <summary>
        /// Get an Salesforce object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The id of the Salesforce object to be retrieved.</param>
        /// <returns></returns>
        public T Get<T>(string id) where T : new()
        {
            if (id == null) throw new ArgumentNullException("id");

            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = HttpMethod.Get,
            };
            var response = ExecuteRequest<T>(request);
            return response.Data;
        }

        /// <summary>
        /// Updates an object in Salesforce.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be updated.</param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Update<T>(object obj, string id) where T : new()
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (id == null) throw new ArgumentNullException("id");

            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = new HttpMethod("PATCH"),
                Body = obj,
            };
            ExecuteRequest<SalesforceResponse>(request);
        }

        /// <summary>
        /// Updates an object in Salesforce.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be updated.</param>
        /// <exception cref="System.ArgumentNullException">obj</exception>
        /// <exception cref="System.ArgumentException">Object to update is missing Id property;obj</exception>
        public void Update<T>(T obj) where T : new()
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var property = obj.GetType().GetProperty("Id");
            if (property==null) throw new ArgumentException("Id property is missing", "obj");

            var id = property.GetValue(obj, null) as string;
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("Id property cannot be null or empty", "obj");

            Update<T>(obj, id);
        }

        /// <summary>
        /// Deletes an Salesforce object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The id of the Salesforce object to be deleted.</param>
        /// <returns></returns>
        public void Delete<T>(string id) where T : new()
        {
            if (id == null) throw new ArgumentNullException("id");

            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = HttpMethod.Delete
            };
            ExecuteRequest<SalesforceResponse>(request);
        }

        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        public IList<T> Query<T>(string query) where T : new()
        {
            if (query == null) throw new ArgumentNullException("query");

            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/query/?q={1}", Version, query),
                Method = HttpMethod.Get
            };

            var response = ExecuteRequest<QueryResponse<T>>(request);
            return response.Data.Records;
        }

        /// <summary>
        /// Gets available API the versions.
        /// </summary>
        /// <returns></returns>
        public IList<ApiVersion> GetVersions()
        {
            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = "/services/data/",
                Method = HttpMethod.Get
            };
            var response = ExecuteRequest<List<ApiVersion>>(request);
            return response.Data;
        }

        /// <summary>
        /// Completely describes the individual metadata at all levels for the specified object.
        /// For example, this can be used to retrieve the fields, URLs, and child relationships for the Account object.
        /// </summary>
        /// <param name="name">The Salesforce object name.</param>
        /// <returns></returns>
        public DescribeResponse Describe(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/{1}/describe/", Version, name),
                Method = HttpMethod.Get
            };

            var response = ExecuteRequest<DescribeResponse>(request);
            return response.Data;
        }

        /// <summary>
        /// Lists the available objects and their metadata for your organization's data.
        /// In addition, it provides the organization encoding, as well as maximum batch size permitted in queries
        /// </summary>
        /// <returns></returns>
        public DescribeGlobalResponse DescribeGlobal()
        {
            var request = new SalesforceRequest
            {
                AccessToken = AccessToken,
                BaseUrl = InstanceUrl,
                Resource = string.Format("/services/data/{0}/sobjects/", Version),
                Method = HttpMethod.Get
            };

            var response = ExecuteRequest<DescribeGlobalResponse>(request);
            return response.Data;
        }

        private SalesforceResponse<T> ExecuteRequest<T>(SalesforceRequest request) where T : new()
        {
            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {
                var httpResponseMessage = httpClient.SendAsync(request.ToHttpRequestMessage()).Result;

                // Read response as RefreshTokenResponse.
                var responseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
                Debug.WriteLine("StatusCode={0}; ErrorCode={1}; Message={2}; Data={3}", httpResponseMessage.StatusCode, string.Empty, httpResponseMessage.ReasonPhrase, responseContent);

                // Check for errors
                if (!httpResponseMessage.IsSuccessStatusCode)
                {
                    // Sets the error information
                    string message = httpResponseMessage.ReasonPhrase;
                    var errors = responseContent.ToObject<List<SalesforceResponse>>();

                    string errorCode = null;
                    if (errors.Count > 0)
                    {
                        errorCode = errors[0].ErrorCode;
                        message = errors[0].Message;
                    }

                    Debug.WriteLine("StatusCode={0}; ErrorCode={1}; Message={2}", httpResponseMessage.StatusCode, errorCode, message);
                    throw new SalesforceException(message, httpResponseMessage.StatusCode, errorCode, null);
                }

                // Parse the response.
                var data = responseContent.ToObject<T>();

                var salesforceResponse = new SalesforceResponse<T>
                {
                    Data = data,
                    StatusCode = httpResponseMessage.StatusCode, 
                    Message = httpResponseMessage.ReasonPhrase
                };

                Debug.WriteLine("StatusCode={0}; ErrorCode={1}; Message={2}; Data={3}", salesforceResponse.StatusCode, string.Empty, salesforceResponse.Message, responseContent);
                return salesforceResponse;
            }
        }
    }
}
