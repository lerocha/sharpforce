## Sharpforce - Salesforce REST API client for .NET and Xamarin iOS/Android

It implements a simple client for the [Salesforce REST API][1] using [RestSharp][2] and targeting multiple platforms.

### Features

* Supports .NET, Xamarin iOS, Xamarin Android
* Supported Salesforce APIs: Versions, Query, CRUD
* Auto-generated C# classes (POCOs) for Salesforce objects

```csharp
// Instantiate the client using a RefreshToken
var service = new SalesforceClient("ConsumerKey", "ConsumerSecret", "RefreshToken");

// Execute a SOQL query
IList<Contact> contacts = service.Query<Contact>("SELECT id, name from Contact");

// Iterate through the records returned.
foreach (Contact account in contacts)
{
	Console.WriteLine(account.Name);
}

// Add a new record using annonymous object
var id = service.Add<Contact>(new { FirstName = "John", LastName = "Smith" });

// Add a new record using POCO object
id = service.Add<Contact>(new Contact { FirstName = "John", LastName = "Smith" });

// Read a record
Contact contact = service.Get<Contact>(id);

// Update a record using annonymous object
service.Update<Contact>(new { Email = "jsmith@gmail.com" }, id);

// Update a record using POCO object (null values are not serialized)
service.Update<Contact>(new Contact{ Email = "jsmith@gmail.com" }, id);

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
```
  [1]: http://www.salesforce.com/us/developer/docs/api_rest/Content/resources_list.htm
  [2]: http://restsharp.org
