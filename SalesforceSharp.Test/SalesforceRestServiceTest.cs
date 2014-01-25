using System;
using System.Configuration;
using System.Net;
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

	    private const string ContactId = "003i000000W2RMDAA3";

		[Test]
        public void SalesforceRestServiceConstructor()
		{
            // Arrange
            // Act
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Assert
            Assert.NotNull(service.AccessToken);

            Console.WriteLine(service.AccessToken);
        }

        [Test]
        public void SalesforceRestServiceQuery()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            string response = service.Query("SELECT name from Account");

            // Assert
            Assert.IsNotEmpty(response);

            Console.WriteLine(response);
        }

        [Test]
        public void SalesforceRestServiceQueryStrongType()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            QueryResponse<Account> response = service.Query<Account>("SELECT id, name from Account");

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
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
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            QueryResponse<Account> response = service.Query<Account>("SELECT id, name from NonExistingTable");

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(response.Done);
            Assert.AreEqual(0, response.TotalSize);
        }

        [Test]
        public void SalesforceRestServiceGetVersions()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.GetVersions();

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotEmpty(response.Data);

            foreach (var version in response.Data)
            {
                Console.WriteLine(version.Version);
            }
        }

        [Test]
        public void SalesforceRestServiceDescribeJson()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            string response = service.DescribeJson("Account");

            // Assert
            Assert.IsNotEmpty(response);

            Console.WriteLine(response);
        }

        [Test]
        public void SalesforceRestServiceDescribe()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.Describe("Account");

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response.Data.Fields);
            Assert.IsNotNull(response.Data.Urls);
            Assert.IsNotNull(response.Data.ChildRelationships);

            Console.WriteLine(response.Data.Name);
            Console.WriteLine(response.Data.Undeletable);
            Console.WriteLine(response.Data.Fields.Count);
            Console.WriteLine(response.Data.Urls.Describe);
        }

        [Test]
        public void SalesforceRestServiceDescribeFails()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.Describe("AccountError");

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            Assert.IsNull(response.Data);
        }

        [Test]
        public void SalesforceRestServiceDescribeGlobal()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            var response = service.DescribeGlobal();

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Data.SObjects);
            Assert.True(response.Data.SObjects.Count > 0);
            Assert.IsNotNull(response.Data.SObjects[0].Urls);

            Console.WriteLine(response.Data.Encoding);
            Console.WriteLine(response.Data.MaxBatchSize);
            Console.WriteLine(response.Data.SObjects[0].Name);
        }

	    [Test]
	    public void SalesforceRestServiceGetExistingObject()
	    {
            // Arrange
	        var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            SalesforceResponse<Contact> response = service.Get<Contact>(ContactId);
	        
            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Data);
	    }

	    [Test]
	    public void SalesforceRestServiceGetNonExistingObject()
	    {
            // Arrange
	        var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            SalesforceResponse<Contact> response = service.Get<Contact>("003iiiiiiiiiiiii");
	        
            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            Assert.Null(response.Data);
	    }

        [Test]
        public void SalesforceRestServiceUpdateExistingObject()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            var getResponse = service.Get<Contact>(ContactId);
            Console.WriteLine("Description=" + getResponse.Data.Description);
            var contact = new {Description = Guid.NewGuid()};
            Console.WriteLine("Description=" + contact.Description);

            // Act
            var response = service.Update<Contact>(contact, getResponse.Data.Id);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void SalesforceRestServiceUpdateNonExistingObject()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.Update<Contact>(new { Description = Guid.NewGuid() }, "InvalidID");

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}

