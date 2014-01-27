using System.Collections.Generic;
using System.Diagnostics;

namespace SalesforceClient.Responses
{
    [DebuggerDisplay("Name={Name}")]
    public class DescribeResponse
    {
        public string Name { get; set; }
        public List<Field> Fields { get; set; }
        public bool CustomSetting { get; set; }
        public bool Undeletable { get; set; }
        public bool Mergeable { get; set; }
        public bool Replicateable { get; set; }
        public bool Triggerable { get; set; }
        public bool FeedEnabled { get; set; }
        public bool Retrieveable { get; set; }
        public string SearchLayoutable { get; set; }
        public string LookupLayoutable { get; set; }
        public string Listviewable { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public List<RecordTypeInfo> RecordTypeInfos { get; set; }
        public bool Queryable { get; set; }
        public bool Deletable { get; set; }
        public bool Updateable { get; set; }
        public bool Createable { get; set; }
        public List<ChildRelationship> ChildRelationships { get; set; }
        public string Label { get; set; }
        public bool Custom { get; set; }
        public string KeyPrefix { get; set; }
        public bool Layoutable { get; set; }
        public bool Activateable { get; set; }
        public string LabelPlural { get; set; }
        public Urls Urls { get; set; }
        public bool Searchable { get; set; }
    }

    [DebuggerDisplay("Name={Name}")]
    public class RecordTypeInfo
    {
        public string Name { get; set; }
        public string RecordTypeId { get; set; }
        public bool DefaultRecordTypeMapping { get; set; }
        public bool Available { get; set; }
    }

    [DebuggerDisplay("Field={Field}; RelationshipName={RelationshipName}")]
    public class ChildRelationship
    {
        public string Field { get; set; }
        public string RelationshipName { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public string ChildSObject { get; set; }
        public bool CascadeDelete { get; set; }
    }

    [DebuggerDisplay("Name={Name}; Type={Type}")]
    public class Field
    {
        public int Length { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
        public string RelationshipName { get; set; }
        public bool Unique { get; set; }
        public string InlineHelpText { get; set; }
        public bool WriteRequiresMasterRead { get; set; }
        public bool DeprecatedAndHidden { get; set; }
        public bool Updateable { get; set; }
        public bool Createable { get; set; }
        public string CalculatedFormula { get; set; }
        public string DefaultValueFormula { get; set; }
        public bool DefaultedOnCreate { get; set; }
        public int Digits { get; set; }
        public bool Groupable { get; set; }
        public bool Permissionable { get; set; }
        public List<string> ReferenceTo { get; set; }
        public string RelationshipOrder { get; set; }
        public string SoapType { get; set; }
        public bool AutoNumber { get; set; }
        public string ControllerName { get; set; }
        public bool ExternalId { get; set; }
        public bool IDLookup { get; set; }
        public List<string> PicklistValues { get; set; }
        public int ByteLength { get; set; }
        public string Label { get; set; }
        public int Precision { get; set; }
        public bool NameField { get; set; }
        public bool Sortable { get; set; }
        public bool Filterable { get; set; }
        public bool CaseSensitive { get; set; }
        public bool RestrictedPicklist { get; set; }
        public bool Calculated { get; set; }
        public int Scale { get; set; }
        public bool Nillable { get; set; }
        public bool NamePointing { get; set; }
        public bool Custom { get; set; }
        public bool HtmlFormatted { get; set; }
        public bool DependentPicklist { get; set; }
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
