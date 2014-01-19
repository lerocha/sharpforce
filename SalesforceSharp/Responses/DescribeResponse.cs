using System.Collections.Generic;

namespace SalesforceSharp.Responses
{
    public class DescribeResponse
    {
        public string Name { get; set; }
        public List<Field> Fields { get; set; }
        public bool CustomSetting { get; set; }
        public bool Undeletable { get; set; }
        // TODO: add additional fields
        public string LabelPlural { get; set; }
        public Urls Urls { get; set; }
        public bool Searchable { get; set; }
    }

    public class Field
    {
        public int Length { get; set; }
        public string Name { get; set; }
        // TODO: add additional fields
    }

    public class Urls
    {
        public string UiEditableTemplate { get; set; }
        public string SObject { get; set; }
        public string UiDetailTemplate { get; set; }
        public string Describe { get; set; }
        public string RowTemplate { get; set; }
        public string UiNewRecord { get; set; }
    }
}
