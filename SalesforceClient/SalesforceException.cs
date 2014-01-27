using System;
using System.Net;

namespace SalesforceClient
{
    public class SalesforceException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorCode { get; set; }

        public SalesforceException()
        {
        }

        public SalesforceException(string message)
            : base(message)
        {
        }

        public SalesforceException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public SalesforceException(string message, HttpStatusCode statusCode, string errorCode, Exception inner)
            : base(message, inner)
        {
            StatusCode = statusCode;
            ErrorCode = errorCode;
        }
    }
}
