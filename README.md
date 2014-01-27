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
List<Account> accounts = service.Query<Account>("SELECT id, name from Account");

// Iterate through the records returned.
foreach (Account account in accounts)
{
	Console.WriteLine(account.Name);
}
```
  [1]: http://www.salesforce.com/us/developer/docs/api_rest/Content/resources_list.htm
  [2]: http://restsharp.org
