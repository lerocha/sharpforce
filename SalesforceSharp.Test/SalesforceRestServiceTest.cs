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
        }

        [Test]
        public void SalesforceRestServiceConstructorFails()
        {
            // Arrange
            // Act
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken + "Wrong");

            // Assert
            Assert.Null(service.AccessToken);
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
            Assert.IsNotNull(response.Fields);
            Assert.IsNotNull(response.Urls);
            Assert.IsNotNull(response.ChildRelationships);

            Console.WriteLine(response.Name);
            Console.WriteLine(response.Undeletable);
            Console.WriteLine(response.Fields.Count);
            Console.WriteLine(response.Urls.Describe);
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
            Assert.NotNull(response.SObjects);
            Assert.True(response.SObjects.Count > 0);
            Assert.IsNotNull(response.SObjects[0].Urls);

            Console.WriteLine(response.Encoding);
            Console.WriteLine(response.MaxBatchSize);
            Console.WriteLine(response.SObjects[0].Name);
        }

        [Test]
        public void SalesforceRestServiceAddAndDelete()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new
                          {
                              LastName = "TestContact",
                              FirstName = ticks,
                              Email = "testcontact+" + ticks + "@gmail.com"
                          };

            // Act
            var response = service.Add<Contact>(contact);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.True(response.Success);
            Assert.NotNull(response.Id);

            // Act
            var deleteResponse = service.Delete<Contact>(response.Id);

            // Assert
            Assert.NotNull(deleteResponse);
            Assert.AreEqual(HttpStatusCode.NoContent, deleteResponse.StatusCode);
        }

        [Test]
        public void SalesforceRestServiceAddFails()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new
                          {
                              NonExistingField = "TestContact",
                              FirstName = ticks,
                              Email = "testcontact+" + ticks + "@gmail.com"
                          };

            // Act
            var response = service.Add<Contact>(contact);

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.False(response.Success);
            Assert.Null(response.Id);
        }

        [Test]
        public void SalesforceRestServiceDeleteFails()
        {
            // Arrange
            var service = new SalesforceRestService(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.Delete<Contact>("BadId");

            // Assert
            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
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

