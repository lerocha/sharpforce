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
		}

        [Test]
        public void SalesforceRestServiceQuery()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            string response = service.Query("SELECT name from Account");
            Assert.IsNotEmpty(response);
        }

        [Test]
        public void SalesforceRestServiceQueryStrongType()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            QueryResponse<Account> response = service.Query<Account>("SELECT name from Account");
            Assert.True(response.Done);
            Assert.True(response.TotalSize > 0);
        }

        [Test]
        public void SalesforceRestServiceQueryStrongTypeFail()
        {
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            QueryResponse<Account> response = service.Query<Account>("SELECT name from NonExistingTable");
            Assert.IsNotEmpty(response.Error);
            Assert.False(response.Done);
            Assert.True(response.TotalSize == 0);
        }
    }
}

