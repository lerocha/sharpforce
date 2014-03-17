using System.Collections.Generic;

namespace Sharpforce.Responses
{
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