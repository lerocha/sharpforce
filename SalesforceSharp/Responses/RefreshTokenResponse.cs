using System.Diagnostics;
using System.Net;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("StatusCode={StatusCode}; ErrorCode={ErrorCode}; Message={Message}; AccessToken={AccessToken}")]
    public class RefreshTokenResponse
    {
        public string Id { get; set; }
        public string IssuedAt { get; set; }
        public string Scope { get; set; }
        public string InstanceUrl { get; set; }
        public string Signature { get; set; }
        public string AccessToken { get; set; }
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public override string ToString()
        {
            return string.Format("StatusCode={0}; ErrorCode={1}; Message={2}; AccessToken={3}", StatusCode, Error, ErrorDescription, AccessToken);
        }
    }
}