using System;
using NUnit.Framework;
using SalesforceSharp.Responses;

namespace SalesforceSharp.Test
{
	[TestFixture]
	public class SalesforceRestServiceTest
	{
        const string ConsumerKey = "";
        const string ConsumerSecret = "";
        const string RefreshToken = "";

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
            Console.WriteLine(response.Name);
            Console.WriteLine(response.Undeletable);
            Console.WriteLine(response.Fields.Count);
            Console.WriteLine(response.Urls.Describe);
        }
    }
}

