## SalesforceClient - Salesforce REST API client for .NET and Xamarin iOS/Android

This project is on early stage with basic functionality at this point.

It implements a simple client for the [Salesforce REST API][1] using [RestSharp][2] and targeting multiple platforms.

### Features

* Supports .NET, Xamarin iOS, Xamarin Android
* Supported Salesforce APIs: Versions, Query
* Auto-generated C# classes (POCOs) for Salesforce objects

```csharp
// Instantiate the client using a RefreshToken
var service = new SalesforceClient("ConsumerKey", "ConsumerSecret", "RefreshToken");

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
	Console.WriteLine("ErrorCode={0}; StatusCode={1}; Message={2}", e.ErrorCode, e.StatusCode, e.Message);
	// Output:
	// ErrorCode=INVALID_FIELD_FOR_INSERT_UPDATE; 
	// StatusCode=BadRequest; 
	// Message=Unable to create/update fields: Name. Please check the security settings of this field and verify that it is read/write for your profile or permission set.
	
	// TODO: handle exception
}
```
  [1]: http://www.salesforce.com/us/developer/docs/api_rest/Content/resources_list.htm
  [2]: http://restsharp.org
