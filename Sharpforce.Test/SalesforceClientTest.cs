using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using NUnit.Framework;
using Sharpforce.Responses;

namespace Sharpforce.Test
{
	[TestFixture]
	public class SalesforceClientTest
	{
        private readonly string _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
        private readonly string _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        private readonly string _refreshToken = ConfigurationManager.AppSettings["RefreshToken"];

	    private const string ContactId = "003i000000W2RMDAA3";

		[Test]
        public void SalesforceClientConstructor()
		{
            // Arrange
            // Act
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Assert
            Assert.NotNull(service.AccessToken);
        }

        [Test]
        public void SalesforceClientConstructorFails()
        {
            // Arrange
            // Act
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken + "Wrong");

            // Assert
            Assert.Null(service.AccessToken);
        }

        [Test]
        public void SalesforceClientQuery()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            IList<Account> accounts = service.Query<Account>("SELECT id, name from Account");

            // Assert
            Assert.NotNull(accounts);
            Assert.True(accounts.Count > 0);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.Name);
            }
        }

        [Test]
        public void SalesforceClientQueryValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(()=>service.Query<Account>(null));
        }

        [Test]
        public void SalesforceClientQueryFail()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Query<Account>("SELECT id, name from NonExistingTable"));
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientGetVersions()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            IList<ApiVersion> versions = service.GetVersions();

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
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

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
        public void SalesforceClientDescribeValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Describe(null));
        }

        [Test]
        public void SalesforceClientDescribeFails()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Describe("AccountError"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientDescribeGlobal()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            
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
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
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
        public void SalesforceClientAdd()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new Contact
            {
                LastName = "TestContact",
                FirstName = ticks.ToString(),
                Email = "testcontact+" + ticks + "@gmail.com"
            };

            // Act
            var id = service.Add<Contact>(contact);

            // Assert
            Assert.NotNull(id);
            Assert.AreEqual(id, contact.Id);
        }

        [Test]
        public void SalesforceClientAddValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Add<Account>(null));
        }

        [Test]
        public void SalesforceClientAddFails()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
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
        public void SalesforceClientDeleteValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Delete<Account>(null));
        }

        [Test]
        public void SalesforceClientDeleteFails()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Delete<Contact>("BadId"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientGetExistingObject()
	    {
            // Arrange
	        var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            
            // Act
            Contact contact = service.Get<Contact>(ContactId);
	        
            // Assert
            Assert.NotNull(contact);
            Assert.AreEqual(ContactId, contact.Id);
	    }

        [Test]
        public void SalesforceClientGetValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Get<Account>(null));
        }

        [Test]
        public void SalesforceClientGetNonExistingObject()
	    {
            // Arrange
	        var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            
            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Get<Contact>("003iiiiiiiiiiiii"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientUpdateExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            Contact contact = service.Get<Contact>(ContactId);
            var updateContact = new {Description = Guid.NewGuid().ToString()};

            // Act
            service.Update<Contact>(updateContact, contact.Id);

            // Assert
            contact = service.Get<Contact>(ContactId); 
            Assert.AreEqual(updateContact.Description, contact.Description);
        }

        [Test]
        public void SalesforceClientUpdateEntireObject()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);
            Contact contact = service.Get<Contact>(ContactId);
            contact.Description = Guid.NewGuid().ToString();

            // Act
            service.Update<Contact>(contact);

            // Assert
            var updatedContact = service.Get<Contact>(ContactId);
            Assert.AreEqual(contact.Description, updatedContact.Description);
        }

        [Test]
        public void SalesforceClientUpdateValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Update<Account>(null, "id"));
        }

        [Test]
        public void SalesforceClientUpdateValidatesNullId()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Update<Account>(new Account(), null));
        }

        [Test]
        public void SalesforceClientUpdateNonExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            // Act
            // Assert
            var exception = Assert.Throws<SalesforceException>(() => service.Update<Contact>(new { Description = Guid.NewGuid() }, "InvalidID"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

	    [Test]
	    public void ReadmeTest()
	    {
            // Instantiate the client using a RefreshToken
            var service = new SalesforceClient(_consumerKey, _consumerSecret, _refreshToken);

            //-----------------------------------------------------------------------------
            // Queries
            //-----------------------------------------------------------------------------

            // Execute a SOQL query
            IList<Contact> contacts = service.Query<Contact>("SELECT id, name from Contact");

            // Iterate through the records returned.
            foreach (Contact account in contacts)
            {
                Console.WriteLine(account.Name);
            }

            //-----------------------------------------------------------------------------
            // CRUD Operations
            //-----------------------------------------------------------------------------

            // Add a new record using annonymous object
	        var id = service.Add<Contact>(new { FirstName = "John", LastName = "Smith" });

            // Add a new record using POCO object
            id = service.Add<Contact>(new Contact { FirstName = "John", LastName = "Smith" });

            // Read a record
            Contact contact = service.Get<Contact>(id);

            // Update a record using POCO object (null values are not serialized)
            contact.Email = "jsmith@gmail.com";
            service.Update<Contact>(contact);

            // Update a record using annonymous object
            service.Update<Contact>(new { Email = "jsmith@yahoo.com" }, id);

            // Delete a record
            service.Delete<Contact>(id);

            //-----------------------------------------------------------------------------
            // Error Handling
            //-----------------------------------------------------------------------------

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

