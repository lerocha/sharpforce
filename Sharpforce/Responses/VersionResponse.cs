using System.Diagnostics;

namespace Sharpforce.Responses
{
    [DebuggerDisplay("Version={Version}; Label={Label}")]
    public class ApiVersion
    {
        public string Url { get; set; }
        public string Label { get; set; }
        public string Version { get; set; }
    }
}
