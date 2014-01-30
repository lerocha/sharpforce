using System;

namespace Sharpforce.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SalesforceObjectAttribute : Attribute
    {
        public string Describe { get; set; }
        public string SObject { get; set; }
        public string RowTemplate { get; set; }
    }
}
