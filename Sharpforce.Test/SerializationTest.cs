using System;
using NUnit.Framework;
using Sharpforce.Responses;

namespace Sharpforce.Test
{
    [TestFixture]
    public class SerializationTest
    {
        [Test]
        public void Serialize()
        {
            var contact = new Contact
            {
                LastName = "Rocha",
                FirstName = "Luis",
                Salutation = "Mr.",
                Phone = "(512) 757-6000",
            };

            var jsonRequest = contact.ToJson();
            Assert.AreEqual("{\n  \"LastName\": \"Rocha\",\n  \"FirstName\": \"Luis\",\n  \"Salutation\": \"Mr.\",\n  \"Phone\": \"(512) 757-6000\"\n}", jsonRequest.Replace("\r",""));
        }

        [Test]
        [Ignore("Disabling this test until we are able to exclude some properties only on serialization.")]
        public void SerializeIncludesOnlyNonNullAndUpdatableProperties()
        {
            var contact = new Contact
            {
                Id = "003i000000W2RMDAA3",
                LastName = "Rocha",
                FirstName = "Luis",
                Salutation = "Mr.",
                Name = "Luis Rocha",
                Phone = "(512) 757-6000",
                CreatedDate = "2014-01-04T23:45:29.000+0000",
                CreatedById = "005i0000002OPr5AAG",
                LastModifiedDate = "2014-02-16T18:30:03.000+0000",
                LastModifiedById = "005i0000002OPr5AAG",
                SystemModstamp = "2014-02-16T18:30:03.000+0000"
            };

            var jsonRequest = contact.ToJson();

            // Assert that updatable and non null properties are serialized.
            Assert.AreEqual("{\n  \"LastName\": \"Rocha\",\n  \"FirstName\": \"Luis\",\n  \"Salutation\": \"Mr.\",\n  \"Phone\": \"(512) 757-6000\"\n}", jsonRequest.Replace("\r",""));
        }

        [Test]
        public void DeserializeIncludesAllProperties()
        {
            const string json = @"{
	            ""Id"": ""003i000000W2RMDAA3"",
	            ""LastName"": ""Rocha"",
	            ""FirstName"": ""Luis"",
	            ""Name"": ""Luis Rocha"",
	            ""SystemModstamp"": ""2014-02-16T18:30:00.000+0000"",
            }";

            var contact = json.ToObject<Contact>();
            Assert.NotNull(contact);
            Assert.AreEqual("003i000000W2RMDAA3", contact.Id);
            Assert.AreEqual("Luis", contact.FirstName);
            Assert.AreEqual("Rocha", contact.LastName);
            Assert.AreEqual("Luis Rocha", contact.Name);
            Assert.AreEqual("2014-02-16T18:30:00.000+0000", contact.SystemModstamp);
        }

        [Test]
        public void DeserializeIsCaseInsensitive()
        {
            const string json = @"{
	            ""url"": ""https"",
	            ""label"": ""label"",
	            ""version"": ""version"",
            }";

            var version = json.ToObject<ApiVersion>();
            Assert.NotNull(version);
            Assert.AreEqual("https", version.Url);
            Assert.AreEqual("label", version.Label);
            Assert.AreEqual("version", version.Version);
        }

        [Test]
        public void DeserializeUsesPropertyNameOverride()
        {
            const string json = @"{
	            ""access_token"": ""access_token"",
	            ""issued_at"": ""issued_at"",
	            ""instance_url"": ""instance_url"",
            }";

            var response = json.ToObject<RefreshTokenResponse>();
            Assert.NotNull(response);
            Assert.AreEqual("access_token", response.AccessToken);
            Assert.AreEqual("issued_at", response.IssuedAt);
            Assert.AreEqual("instance_url", response.InstanceUrl);
        }
    }
}
