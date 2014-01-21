﻿using System.Diagnostics;

namespace SalesforceSharp.Responses
{
    [DebuggerDisplay("Version={Version}; Label={Label}")]
    public class VersionResponse
    {
        public string Url { get; set; }
        public string Label { get; set; }
        public string Version { get; set; }
    }
}