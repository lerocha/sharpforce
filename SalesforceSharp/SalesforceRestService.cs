﻿using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Gets available API the versions.
        /// </summary>
        /// <returns></returns>
        List<VersionResponse> GetVersions();

        /// <summary>
        /// Completely describes the individual metadata at all levels for the specified object. 
        /// For example, this can be used to retrieve the fields, URLs, and child relationships for the Account object.
        /// </summary>
        /// <param name="name">The Salesforce object name.</param>
        /// <returns></returns>
        string DescribeJson(string name);

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

            return ExecuteRequest(request);
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

            return ExecuteRequest<QueryResponse<T>>(request);
        }

        /// <summary>
        /// Gets available API the versions.
        /// </summary>
        /// <returns></returns>
        public List<VersionResponse> GetVersions()
        {
            IRestRequest request = new RestRequest
            {
                Resource = "/services/data/",
                Method = Method.GET
            };
            return ExecuteRequest<List<VersionResponse>>(request);
        }

        /// <summary>
        /// Completely describes the individual metadata at all levels for the specified object.
        /// For example, this can be used to retrieve the fields, URLs, and child relationships for the Account object.
        /// </summary>
        /// <param name="name">The Salesforce object name.</param>
        /// <returns></returns>
        public string DescribeJson(string name)
        {
            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/v20.0/sobjects/{0}/describe/", name),
                Method = Method.GET
            };

            return ExecuteRequest(request);
        }

        /// <summary>
        /// Completely describes the individual metadata at all levels for the specified object.
        /// For example, this can be used to retrieve the fields, URLs, and child relationships for the Account object.
        /// </summary>
        /// <param name="name">The Salesforce object name.</param>
        /// <returns></returns>
        public DescribeResponse Describe(string name)
        {
            IRestRequest request = new RestRequest
            {
                Resource = string.Format("/services/data/v20.0/sobjects/{0}/describe/", name),
                Method = Method.GET
            };

            return ExecuteRequest<DescribeResponse>(request);
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
                Resource = "/services/data/v20.0/sobjects/",
                Method = Method.GET
            };

            return ExecuteRequest<DescribeGlobalResponse>(request);
        }

        private string ExecuteRequest(IRestRequest request)
        {
            if (request == null) throw new ArgumentException("request");

            request.AddHeader("Authorization", "Bearer " + AccessToken);

            IRestClient client = new RestClient();
            client.BaseUrl = InstanceUrl;
            var response = client.Execute(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorMessage);
                throw response.ErrorException;
            }

            return response.Content;
        }

        private T ExecuteRequest<T>(IRestRequest request) where T : new()
        {
            request.AddHeader("Authorization", "Bearer " + AccessToken);

            IRestClient client = new RestClient();
            client.BaseUrl = InstanceUrl;
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine(response.ErrorMessage);
                throw response.ErrorException;
            }

            return response.Data;
        }
    }
}
