using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("Error={Error}")]
    public class SalesforceResponse
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }

    public class SalesforceResponse<T> : SalesforceResponse
    {
        public T Data { get; set; }

        public SalesforceResponse()
        {
        }

        public SalesforceResponse(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return string.Format("StatusCode={0}; ErrorCode={1}; ErrorMessage={2}; Data={3}", StatusCode, ErrorCode, ErrorMessage, Data);
        }
    }

    public class AddResponse : SalesforceResponse
    {
        public string Id { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Id={1}; Success={2}", base.ToString(), Id, Success);
        }
    }
}