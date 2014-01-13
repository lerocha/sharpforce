using System.Diagnostics;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("Error={Error}")]
    public class SalesforceResponse
    {
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
    }
}