using System.Diagnostics;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("AccessToken={AccessToken}; Error={Error}")]
    public class RefreshTokenResponse : SalesforceResponse
    {
        public string Id { get; set; }
        public string IssuedAt { get; set; }
        public string Scope { get; set; }
        public string InstanceUrl { get; set; }
        public string Signature { get; set; }
        public string AccessToken { get; set; }
    }
}