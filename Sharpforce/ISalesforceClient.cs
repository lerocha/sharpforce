using System.Collections.Generic;
using Sharpforce.Responses;

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
}