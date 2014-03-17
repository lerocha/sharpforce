using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using NUnit.Framework;
using Sharpforce.Responses;

namespace Sharpforce.Test
{
    [TestFixture]
    public class SalesforceClientTest : AbstractSalesforceClientTest
    {
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
        public void SalesforceClientQuery()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

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
        public void SalesforceClientQueryAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            IList<Account> accounts = service.QueryAsync<Account>("SELECT id, name from Account").Result;

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
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Query<Account>(null));
        }

        [Test]
        public void SalesforceClientQueryFail()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception =
                Assert.Throws<SalesforceException>(() => service.Query<Account>("SELECT id, name from NonExistingTable"));
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientQueryAsyncFail()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var accounts = service.QueryAsync<Account>("SELECT id, name from NonExistingTable").Result;
            Assert.IsNull(accounts);
        }

        [Test]
        public void SalesforceClientGetVersions()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

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
        public void SalesforceClientGetVersionsAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            IList<ApiVersion> versions = service.GetVersionsAsync().Result;

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
        public void SalesforceClientDescribeAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.DescribeAsync("Account").Result;

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
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Describe(null));
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
        public void SalesforceClientDescribeAsyncFails()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var result = service.DescribeAsync("AccountError").Result;
            Assert.IsNull(result);
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
        public void SalesforceClientDescribeGlobalAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            var response = service.DescribeGlobalAsync().Result;

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
        public void SalesforceClientAddAndDeleteAsync()
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
            var addResponse = service.AddAsync<Contact>(contact).Result;

            // Assert
            Assert.NotNull(addResponse.Id);

            // Act
            var response = service.DeleteAsync<Contact>(addResponse.Id).Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void SalesforceClientAdd()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
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
        public void SalesforceClientAddAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            var ticks = DateTime.UtcNow.Ticks;
            var contact = new Contact
                          {
                              LastName = "TestContact",
                              FirstName = ticks.ToString(),
                              Email = "testcontact+" + ticks + "@gmail.com"
                          };

            // Act
            var response = service.AddAsync<Contact>(contact).Result;

            // Assert
            Assert.NotNull(response);
            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, contact.Id);
        }

        [Test]
        public void SalesforceClientAddValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Add<Account>(null));
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
        public void SalesforceClientAddAsyncFails()
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
            var id = service.AddAsync<Contact>(contact).Result;
            Assert.IsNull(id);
        }

        [Test]
        public void SalesforceClientDeleteValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Delete<Account>(null));
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
        public void SalesforceClientDeleteAsyncFails()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var response = service.DeleteAsync<Contact>("BadId").Result;
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
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
        public void SalesforceClientGetAsync()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            Contact contact = service.GetAsync<Contact>(ContactId).Result;

            // Assert
            Assert.NotNull(contact);
            Assert.AreEqual(ContactId, contact.Id);
        }

        [Test]
        public void SalesforceClientGetValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Get<Account>(null));
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
        public void SalesforceClientGetAsyncNonExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var contact = service.GetAsync<Contact>("003iiiiiiiiiiiii").Result;
            Assert.IsNull(contact);
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
        public void SalesforceClientUpdateAsyncExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            Contact contact = service.Get<Contact>(ContactId);
            var updateContact = new {Description = Guid.NewGuid().ToString()};

            // Act
            var response = service.UpdateAsync<Contact>(updateContact, contact.Id).Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void SalesforceClientUpdateEntireObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            var contact = new Contact {Id = ContactId, Description = Guid.NewGuid().ToString()};

            // Act
            service.Update<Contact>(contact);

            // Assert
            var updatedContact = service.Get<Contact>(ContactId);
            Assert.AreEqual(contact.Description, updatedContact.Description);
        }

        [Test]
        public void SalesforceClientUpdateAsyncEntireObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);
            var contact = new Contact {Id = ContactId, Description = Guid.NewGuid().ToString()};

            // Act
            var response = service.UpdateAsync<Contact>(contact).Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void SalesforceClientUpdateValidatesNull()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Update<Account>(null, "id"));
        }

        [Test]
        public void SalesforceClientUpdateValidatesNullId()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => service.Update<Account>(new Account(), null));
        }

        [Test]
        public void SalesforceClientUpdateNonExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var exception =
                Assert.Throws<SalesforceException>(
                    () => service.Update<Contact>(new {Description = Guid.NewGuid()}, "InvalidID"));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
        }

        [Test]
        public void SalesforceClientUpdateAsyncNonExistingObject()
        {
            // Arrange
            var service = new SalesforceClient(ConsumerKey, ConsumerSecret, RefreshToken);

            // Act
            // Assert
            var response = service.UpdateAsync<Contact>(new {Description = Guid.NewGuid()}, "InvalidID").Result;
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}

