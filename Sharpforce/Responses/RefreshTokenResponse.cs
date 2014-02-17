using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

namespace Sharpforce.Responses
{
    [DebuggerDisplay("StatusCode={StatusCode}; ErrorCode={ErrorCode}; Message={Message}; AccessToken={AccessToken}")]
    public class RefreshTokenResponse
    {
        public string Id { get; set; }
        [JsonProperty("issued_at")]
        public string IssuedAt { get; set; }
        public string Scope { get; set; }
        [JsonProperty("instance_url")]
        public string InstanceUrl { get; set; }
        public string Signature { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public override string ToString()
        {
            return string.Format("StatusCode={0}; ErrorCode={1}; Message={2}; AccessToken={3}", StatusCode, Error, ErrorDescription, AccessToken);
        }
    }
}