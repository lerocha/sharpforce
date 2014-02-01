using System;
using System.Collections.Generic;
using System.Diagnostics;
﻿using RestSharp;
﻿using RestSharp.Deserializers;
﻿using Sharpforce.Responses;

namespace Sharpforce
{
    public interface ISalesforceClient
    {
        /// <summary>
        /// Creates an object in Salesforce.
        /// http://www.salesforce.com/us/developer/docs/api_rest/Content/dome_sobject_create.htm
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be created.</param>
        /// <returns></returns>
        string Add<T>(object obj) where T : new();

        /// <summary>
        /// Get an Salesforce object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The id of the Salesforce object to be retrieved.</param>
        /// <returns></returns>
        T Get<T>(string id) where T : new();

        /// <summary>
        /// Updates an object in Salesforce.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be updated.</param>
        /// <param name="id"></param>
        /// <returns></returns>
        void Update<T>(object obj, string id) where T : new();

        /// <summary>
        /// Updates an object in Salesforce.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Salesforce object to be updated.</param>
        /// <returns></returns>
        void Update<T>(T obj) where T : new();

        /// <summary>
        /// Deletes an Salesforce object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The id of the Salesforce object to be deleted.</param>
        /// <returns></returns>
        void Delete<T>(string id) where T : new();

        /// <summary>
        /// Execute a SOQL Query
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <returns></returns>
        IList<T> Query<T>(string query) where T : new();

        /// <summary>
        /// Gets available API the versions.
        /// </summary>
        /// <returns></returns>
        IList<ApiVersion> GetVersions();

        /// <summary>
        /// Completely describes the individual metadata at all levels for the specified object. 
        /// For example, this can be used to retrieve the fields, URLs, and child relationships for the Account object.
        /// </summary>
        /// <param name="name">The Salesforce object name.</param>
        /// <returns></returns>
        DescribeResponse Describe(string name);

        /// <summary>
        /// Lists the available objects and their metadata for your organization's data. 
        /// In addition, it provides the organization encoding, as well as maximum batch size permitted in queries
        /// </summary>
        /// <returns></returns>
        DescribeGlobalResponse DescribeGlobal();
    }

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
        public SalesforceClient(string consumerKey, string consumerSecret, string refreshToken, string version = DefaultVersion, string baseUrl = DefaultBaseUrl)
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
                Debug.WriteLine("StatusCode={0}; Message={1}; AccessToken=null", response.StatusCode, response.ErrorMessage);
                return;
            }

            response.Data.StatusCode = response.StatusCode;
            Debug.WriteLine(response.Data.ToString());

            AccessToken = response.Data.AccessToken;
            InstanceUrl = response.Data.InstanceUrl;
            Version = version;
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/{1}", Version, typeof(T).Name),
                Method = Method.POST,
                RequestFormat = DataFormat.Json,
                JsonSerializer = new SalesforceSerializer()
            };
            request.AddBody(obj);
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = Method.GET
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = Method.PATCH,
                RequestFormat = DataFormat.Json,
                JsonSerializer = new SalesforceSerializer()
            };
            request.AddBody(obj);
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/{1}/{2}", Version, typeof(T).Name, id),
                Method = Method.DELETE
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/query/?q={1}", Version, query),
                Method = Method.GET
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
            IRestRequest request = new RestRequest
            {
                Resource = "/services/data/",
                Method = Method.GET
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

            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/{1}/describe/", Version, name),
                Method = Method.GET
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
            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/{0}/sobjects/", Version),
                Method = Method.GET
            };

            var response = ExecuteRequest<DescribeGlobalResponse>(request);
            return response.Data;
        }

        private SalesforceResponse<T> ExecuteRequest<T>(IRestRequest request) where T : new()
        {
            request.AddHeader("Authorization", "Bearer " + AccessToken);

            IRestClient client = new RestClient();
            client.BaseUrl = InstanceUrl;
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                // Sets the error information
                string message = response.ErrorMessage;
                var deserializer = new JsonDeserializer();
                var errors = deserializer.Deserialize<List<SalesforceResponse>>(response);
                string errorCode = null;

                if (errors.Count > 0)
                {
                    errorCode = errors[0].ErrorCode;
                    message = errors[0].Message;
                }

                Debug.WriteLine("StatusCode={0}; ErrorCode={1}; Message={2}", response.StatusCode, errorCode, message);
                throw new SalesforceException(message, response.StatusCode, errorCode, null);
            }

            var salesforceResponse = new SalesforceResponse<T>
            {
                Data = response.Data,
                StatusCode = response.StatusCode
            };

            Debug.WriteLine("StatusCode={0}; ErrorCode={1}; Message={2}; Data={3}", response.StatusCode, string.Empty, response.ErrorMessage, response.Data);
            return salesforceResponse;
        }
    }
}
