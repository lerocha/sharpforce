using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using NUnit.Framework;
using SalesforceClient.Responses;

namespace SalesforceClient.Test
{
	[TestFixture]
	public class SalesforceClientTest
	{
        private string ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        private string ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        private string RefreshToken = ConfigurationManager.AppSettings["RefreshToken"];

	    private const string ContactId = "003i000000W2RMDAA3";

		[Test]
        public void SalesforceClientConstructor()
		{
            // Arrange
            // Act
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Assert
            Assert.NotNull(service.AccessToken);
        }

        [Test]
        public void SalesforceClientConstructorFails()
        {
            // Arrange
            // Act
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken + "Wrong");

            // Assert
            Assert.Null(service.AccessToken);
        }

        [Test]
        public void SalesforceClientQueryStrongType()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            List<Account> accounts = service.Query<Account>("SELECT id, name from Account");

            // Assert
            Assert.NotNull(accounts);
            Assert.True(accounts.Count > 0);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.Name);
            }
        }

        [Test]
        public void SalesforceClientQueryStrongTypeFail()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Query<Account>("SELECT id, name from NonExistingTable"));
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientGetVersions()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            List<ApiVersion> versions = service.GetVersions();

            // Assert
            Assert.IsNotNull(versions);
            Assert.True(versions.Count > 0);

            foreach (var version in versions)
            {
                Console.WriteLine(version.Version);
            }
        }

        [Test]
        public void SalesforceClientDescribe()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.Describe("Account");

            // Assert
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
        public void SalesforceClientDescribeFails()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Describe("AccountError"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientDescribeGlobal()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            var response = service.DescribeGlobal();

            // Assert
            Assert.IsNotNull(response);
            Assert.NotNull(response.SObjects);
            Assert.True(response.SObjects.Count > 0);
            Assert.IsNotNull(response.SObjects[0].Urls);

            Console.WriteLine(response.Encoding);
            Console.WriteLine(response.MaxBatchSize);
            Console.WriteLine(response.SObjects[0].Name);
        }

        [Test]
        public void SalesforceClientAddAndDelete()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new
                          {
                              LastName = "TestContact",
                              FirstName = ticks,
                              Email = "testcontact+" + ticks + "@gmail.com"
                          };

            // Act
            var id = service.Add<Contact>(contact);

            // Assert
            Assert.NotNull(id);

            // Act
            service.Delete<Contact>(id);

            // Assert
        }

        [Test]
        public void SalesforceClientAddFails()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new
                          {
                              NonExistingField = "TestContact",
                              FirstName = ticks,
                              Email = "testcontact+" + ticks + "@gmail.com"
                          };

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Add<Contact>(contact));
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientDeleteFails()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Delete<Contact>("BadId"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientGetExistingObject()
	    {
            // Arrange
	        var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            Contact contact = service.Get<Contact>(ContactId);
	        
            // Assert
            Assert.NotNull(contact);
            Assert.AreEqual(ContactId, contact.Id);
	    }

	    [Test]
        public void SalesforceClientGetNonExistingObject()
	    {
            // Arrange
	        var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            
            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Get<Contact>("003iiiiiiiiiiiii"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientUpdateExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            Contact contact = service.Get<Contact>(ContactId);
            var updateContact = new {Description = Guid.NewGuid().ToString()};

            // Act
            service.Update<Contact>(updateContact, contact.Id);

            // Assert
            contact = service.Get<Contact>(ContactId); 
            Assert.AreEqual(updateContact.Description, contact.Description);
        }

        [Test]
        public void SalesforceClientUpdateNonExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Update<Contact>(new { Description = Guid.NewGuid() }, "InvalidID"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

	    [Test]
	    public void ReadmeTest()
	    {
            // Instantiate the client using a RefreshToken
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Execute a SOQL query
            List<Contact> contacts = service.Query<Contact>("SELECT id, name from Contact");

            // Iterate through the records returned.
            foreach (Contact account in contacts)
            {
                Console.WriteLine(account.Name);
            }

            // Create a new record
            var newContact = new
            {
                FirstName = "John",
                LastName = "Smith"
            };
            var id = service.Add<Contact>(newContact);

            // Read a record
            Contact contact = service.Get<Contact>(id);

            // Update a record
            var updateContact = new { Email = "jsmith@gmail.com" };
            service.Update<Contact>(updateContact, id);

            // Delete a record
            service.Delete<Contact>(id);

            // Error Handling
	        try
	        {
                service.Add<Contact>(new { Name = "Read-only property" });
            }
	        catch (SalesforceException e)
	        {
                Console.WriteLine("ErrorCode={0}; StatusCode={1}; Message={2}", 
                                   e.ErrorCode, e.StatusCode, e.Message);
                // Output:
                // ErrorCode=INVALID_FIELD_FOR_INSERT_UPDATE; 
                // StatusCode=BadRequest; 
                // Message=Unable to create/update fields: Name. Please check the security settings of this field
                //         and verify that it is read/write for your profile or permission set.
	            
                // TODO: handle the exception
	        }
        }
    }
}

