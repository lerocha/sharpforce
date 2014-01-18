## SalesforceSharp - Salesforce REST API client for .NET, Mono and Xamarin iOS/Android

This project is on early stage with basic functionality at this point.

It implements a simple [Salesforce REST API][1] client using [RestSharp][2] targeting multiple platforms.

### Features

* Supports .NET, Xamarin iOS, Xamarin Android
* Supported Salesforce APIs: Versions, Query
* Auto-generated C# classes (POCOs) for Salesforce objects

```csharp
// Instantiate the client using a RefreshToken
var service = new SalesforceRestService("ConsumerKey", "ConsumerSecret", "RefreshToken");

// Execute SOQL query and get a JSON response
string jsonResponse = service.Query("SELECT id, name from Account");

// Execute SOQL query and get a strong type response
QueryResponse<Account> response = service.Query<Account>("SELECT id, name from Account");

// Iterate through the records returned.
foreach (Account account in response.Records)
{
	Console.WriteLine(account.Name);
}
```
  [1]: http://www.salesforce.com/us/developer/docs/api_rest/Content/resources_list.htm
  [2]: http://restsharp.org
