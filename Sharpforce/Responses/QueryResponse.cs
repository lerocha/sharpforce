using System.Collections.Generic;
using System.Diagnostics;

namespace Sharpforce.Responses
{
    [DebuggerDisplay("Done={Done}; TotalSize={TotalSize}")]
    public class QueryResponse<T> : SalesforceResponse
    {
        public int TotalSize { get; set; }
        public bool Done { get; set; }
        public List<T> Records { get; set; }
    }
}
