using System.Diagnostics;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("Error={Error}")]
    public class SalesforceResponse
    {
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
    }

    public class SalesforceResponse<T> : SalesforceResponse
    {
        public T Value { get; set; }

        public SalesforceResponse()
        {
        }

        public SalesforceResponse(T value)
        {
            Value = value;
        }
    }
}