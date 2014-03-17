using System.Diagnostics;
using System.Net;

namespace Sharpforce.Responses
{
    [DebuggerDisplay("StatusCode={StatusCode}; ErrorCode={ErrorCode}; Message={Message}")]
    public class SalesforceResponse
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }
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
            return string.Format("StatusCode={0}; ErrorCode={1}; Message={2}; Data={3}", StatusCode, ErrorCode, Message, Data);
        }
    }
}