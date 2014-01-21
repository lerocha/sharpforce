using System;
using System.Configuration;
using NUnit.Framework;
using SalesforceSharp.Responses;

namespace SalesforceSharp.Test
{
	[TestFixture]
	public class SalesforceRestServiceTest
	{
        private string ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        private string ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        private string RefreshToken = ConfigurationManager.AppSettings["RefreshToken"];

		[Test]
        public void SalesforceRestServiceConstructor()
		{
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            Assert.NotNull(service.AccessToken);
            Console.WriteLine(service.AccessToken);
        }

        [Test]
        public void SalesforceRestServiceQuery()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            string response = service.Query("SELECT name from Account");
            Assert.IsNotEmpty(response);
            Console.WriteLine(response);
        }

        [Test]
        public void SalesforceRestServiceQueryStrongType()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            QueryResponse<Account> response = service.Query<Account>("SELECT id, name from Account");
            Assert.True(response.Done);
            Assert.True(response.TotalSize > 0);
            foreach (var record in response.Records)
            {
                Console.WriteLine(record.Name);
            }
        }

        [Test]
        public void SalesforceRestServiceQueryStrongTypeFail()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            Assert.Throws<InvalidCastException>(() => service.Query<Account>("SELECT name from NonExistingTable"));
        }

        [Test]
        public void SalesforceRestServiceGetVersions()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            var response = service.GetVersions();
            Assert.IsNotEmpty(response);
            foreach (var version in response)
            {
                Console.WriteLine(version.Version);
            }
        }

        [Test]
        public void SalesforceRestServiceDescribeJson()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            string response = service.DescribeJson("Account");
            Assert.IsNotEmpty(response);
            Console.WriteLine(response);
        }

        [Test]
        public void SalesforceRestServiceDescribe()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            DescribeResponse response = service.Describe("Account");
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Fields);
            Assert.IsNotNull(response.Urls);
            Assert.IsNotNull(response.ChildRelationships);
            Console.WriteLine(response.Name);
            Console.WriteLine(response.Undeletable);
            Console.WriteLine(response.Fields.Count);
            Console.WriteLine(response.Urls.Describe);
        }

        [Test]
        public void SalesforceRestServiceDescribeGlobal()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            DescribeGlobalResponse response = service.DescribeGlobal();
            Assert.IsNotNull(response);
            Assert.NotNull(response.SObjects);
            Assert.True(response.SObjects.Count > 0);
            Assert.IsNotNull(response.SObjects[0].Urls);
            Console.WriteLine(response.Encoding);
            Console.WriteLine(response.MaxBatchSize);
            Console.WriteLine(response.SObjects[0].Name);
        }
    }
}

