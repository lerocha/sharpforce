
//using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Newtonsoft.Json;


// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMember.Local

namespace Sharpforce
{
    /// <summary>
    /// POCO for AcceptedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AcceptedEventRelation
    {
        /// <summary>
        /// Event Relation ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event Relation ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Relation ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Relation ID")]
        public string RelationId { get; private set; }

        /// <summary>
        /// Event ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event ID")]
        public string EventId { get; private set; }

        /// <summary>
        /// Response Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Response Date")]
        public string RespondedDate { get; private set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Response { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

    }

    /// <summary>
    /// POCO for Account
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Account
    {
        /// <summary>
        /// Account ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Master Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Record ID")]
        public string MasterRecordId { get; private set; }

        /// <summary>
        /// Account Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Account Name")]
        public string Name { get; set; }

        /// <summary>
        /// Account Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Type")]
        public string Type { get; set; }

        /// <summary>
        /// Parent Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent Account ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Billing Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Billing Street")]
        public string BillingStreet { get; set; }

        /// <summary>
        /// Billing City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        /// <summary>
        /// Billing State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Billing State/Province")]
        public string BillingState { get; set; }

        /// <summary>
        /// Billing Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Billing Zip/Postal Code")]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// Billing Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Billing Country")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// Billing Latitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Billing Latitude")]
        public string BillingLatitude { get; set; }

        /// <summary>
        /// Billing Longitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Billing Longitude")]
        public string BillingLongitude { get; set; }

        /// <summary>
        /// Shipping Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Shipping Street")]
        public string ShippingStreet { get; set; }

        /// <summary>
        /// Shipping City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Shipping City")]
        public string ShippingCity { get; set; }

        /// <summary>
        /// Shipping State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Shipping State/Province")]
        public string ShippingState { get; set; }

        /// <summary>
        /// Shipping Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Shipping Zip/Postal Code")]
        public string ShippingPostalCode { get; set; }

        /// <summary>
        /// Shipping Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Shipping Country")]
        public string ShippingCountry { get; set; }

        /// <summary>
        /// Shipping Latitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Shipping Latitude")]
        public string ShippingLatitude { get; set; }

        /// <summary>
        /// Shipping Longitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Shipping Longitude")]
        public string ShippingLongitude { get; set; }

        /// <summary>
        /// Account Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Account Fax (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Account Number (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Website (url type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Website { get; set; }

        /// <summary>
        /// SIC Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "SIC Code")]
        public string Sic { get; set; }

        /// <summary>
        /// Industry (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Industry { get; set; }

        /// <summary>
        /// Annual Revenue (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Annual Revenue")]
        public string AnnualRevenue { get; set; }

        /// <summary>
        /// Employees (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Employees")]
        public string NumberOfEmployees { get; set; }

        /// <summary>
        /// Ownership (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Ownership { get; set; }

        /// <summary>
        /// Ticker Symbol (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Ticker Symbol")]
        public string TickerSymbol { get; set; }

        /// <summary>
        /// Account Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        //[Display(Name = "Account Description")]
        public string Description { get; set; }

        /// <summary>
        /// Account Rating (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Account Site (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Account Site")]
        public string Site { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Data.com Key (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Data.com Key")]
        public string Jigsaw { get; set; }

        /// <summary>
        /// Jigsaw Company ID (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Jigsaw Company ID")]
        public string JigsawCompanyId { get; private set; }

        /// <summary>
        /// Account Source (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Account Source")]
        public string AccountSource { get; set; }

        /// <summary>
        /// SIC Description (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "SIC Description")]
        public string SicDesc { get; set; }

        /// <summary>
        /// Customer Priority (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Customer Priority")]
        public string CustomerPriority__c { get; set; }

        /// <summary>
        /// SLA (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "SLA")]
        public string SLA__c { get; set; }

        /// <summary>
        /// Active (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Active")]
        public string Active__c { get; set; }

        /// <summary>
        /// Number of Locations (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Number of Locations")]
        public string NumberofLocations__c { get; set; }

        /// <summary>
        /// Upsell Opportunity (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Upsell Opportunity")]
        public string UpsellOpportunity__c { get; set; }

        /// <summary>
        /// SLA Serial Number (string type in Salesforce)
        /// </summary>
        //[StringLength(10)]
        //[Display(Name = "SLA Serial Number")]
        public string SLASerialNumber__c { get; set; }

        /// <summary>
        /// SLA Expiration Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "SLA Expiration Date")]
        public string SLAExpirationDate__c { get; set; }

    }

    /// <summary>
    /// POCO for AccountContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AccountContactRole
    {
        /// <summary>
        /// Contact Role ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Role ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for AccountFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AccountFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for AccountHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AccountHistory
    {
        /// <summary>
        /// Account History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for AccountPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AccountPartner
    {
        /// <summary>
        /// Account Partner ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account Partner ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountFromId { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountToId { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Role { get; private set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Reverse Partner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reverse Partner ID")]
        public string ReversePartnerId { get; private set; }

    }

    /// <summary>
    /// POCO for AccountShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AccountShare
    {
        /// <summary>
        /// Account Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Account Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account Access")]
        public string AccountAccessLevel { get; private set; }

        /// <summary>
        /// Opportunity Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity Access")]
        public string OpportunityAccessLevel { get; private set; }

        /// <summary>
        /// Case Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Access")]
        public string CaseAccessLevel { get; private set; }

        /// <summary>
        /// Contact Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Access")]
        public string ContactAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for ActivityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ActivityHistory
    {
        /// <summary>
        /// Activity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Activity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Contact/Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact/Lead ID")]
        public string WhoId { get; private set; }

        /// <summary>
        /// Opportunity/Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity/Account ID")]
        public string WhatId { get; private set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Subject { get; private set; }

        /// <summary>
        /// Task (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Task")]
        public bool? IsTask { get; private set; }

        /// <summary>
        /// Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date")]
        public string ActivityDate { get; private set; }

        /// <summary>
        /// Assigned To ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Assigned To ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Priority { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Type")]
        public string ActivityType { get; private set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// All Day Event (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "All Day Event")]
        public bool? IsAllDayEvent { get; private set; }

        /// <summary>
        /// Public (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Public")]
        public bool? IsVisibleInSelfService { get; private set; }

        /// <summary>
        /// Duration (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Duration")]
        public string DurationInMinutes { get; private set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Location { get; private set; }

        /// <summary>
        /// Comments (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comments")]
        public string Description { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Call Duration (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Duration")]
        public string CallDurationInSeconds { get; private set; }

        /// <summary>
        /// Call Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Type")]
        public string CallType { get; private set; }

        /// <summary>
        /// Call Result (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Result")]
        public string CallDisposition { get; private set; }

        /// <summary>
        /// Call Object Identifier (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Object Identifier")]
        public string CallObject { get; private set; }

        /// <summary>
        /// Reminder Date/Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reminder Date/Time")]
        public string ReminderDateTime { get; private set; }

        /// <summary>
        /// Reminder Set (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reminder Set")]
        public bool? IsReminderSet { get; private set; }

        /// <summary>
        /// End (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "End")]
        public string EndDateTime { get; private set; }

        /// <summary>
        /// Start (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start")]
        public string StartDateTime { get; private set; }

    }

    /// <summary>
    /// POCO for AdditionalNumber
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AdditionalNumber
    {
        /// <summary>
        /// Additional Directory Number ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Additional Directory Number ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Call Center ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Call Center ID")]
        public string CallCenterId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for AggregateResult
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AggregateResult
    {
        /// <summary>
        /// Aggregate Result ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Aggregate Result ID")]
        public string Id { get; private set; }

    }

    /// <summary>
    /// POCO for ApexClass
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexClass
    {
        /// <summary>
        /// Class ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Class ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Api Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Api Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Is Valid (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Body CRC (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Body CRC")]
        public string BodyCrc { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000000)]
        public string Body { get; set; }

        /// <summary>
        /// Size Without Comments (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Size Without Comments")]
        public string LengthWithoutComments { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ApexComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexComponent
    {
        /// <summary>
        /// Component ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Component ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Api Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Api Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Label")]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// Controller Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Controller Type")]
        public string ControllerType { get; set; }

        /// <summary>
        /// Controller Key (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Controller Key")]
        public string ControllerKey { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1048576)]
        public string Markup { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ApexLog
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexLog
    {
        /// <summary>
        /// Log ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Log ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Log User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Log User ID")]
        public string LogUserId { get; private set; }

        /// <summary>
        /// Log Size (bytes) (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Log Size (bytes)")]
        public string LogLength { get; private set; }

        /// <summary>
        /// Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Request Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Request Type")]
        public string Request { get; private set; }

        /// <summary>
        /// Operation (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Operation { get; private set; }

        /// <summary>
        /// Application (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Application { get; private set; }

        /// <summary>
        /// Status (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Duration (ms) (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Duration (ms)")]
        public string DurationMilliseconds { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Start Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start Time")]
        public string StartTime { get; private set; }

        /// <summary>
        /// Location (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Location { get; private set; }

    }

    /// <summary>
    /// POCO for ApexPage
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexPage
    {
        /// <summary>
        /// Page ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Page ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Api Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Api Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Label")]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// Controller Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Controller Type")]
        public string ControllerType { get; set; }

        /// <summary>
        /// Controller Key (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Controller Key")]
        public string ControllerKey { get; set; }

        /// <summary>
        /// Available for Salesforce mobile apps (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Available for Salesforce mobile apps")]
        public bool? IsAvailableInTouch { get; set; }

        /// <summary>
        /// Require CSRF protection on GET requests (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Require CSRF protection on GET requests")]
        public bool? IsConfirmationTokenRequired { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1048576)]
        public string Markup { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ApexTestQueueItem
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexTestQueueItem
    {
        /// <summary>
        /// Apex Test Queue Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Test Queue Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Class ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Class ID")]
        public string ApexClassId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Status Detail (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Status Detail")]
        public string ExtendedStatus { get; private set; }

        /// <summary>
        /// Apex Job ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Job ID")]
        public string ParentJobId { get; private set; }

    }

    /// <summary>
    /// POCO for ApexTestResult
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexTestResult
    {
        /// <summary>
        /// Apex Test Result ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Test Result ID")]
        public string Id { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Time Started (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Time Started")]
        public string TestTimestamp { get; private set; }

        /// <summary>
        /// Pass/Fail (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Pass/Fail")]
        public string Outcome { get; private set; }

        /// <summary>
        /// Class ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Class ID")]
        public string ApexClassId { get; private set; }

        /// <summary>
        /// Method Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Method Name")]
        public string MethodName { get; private set; }

        /// <summary>
        /// Error Message (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Error Message")]
        public string Message { get; private set; }

        /// <summary>
        /// Stack Trace (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Stack Trace")]
        public string StackTrace { get; private set; }

        /// <summary>
        /// Apex Job ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Job ID")]
        public string AsyncApexJobId { get; private set; }

        /// <summary>
        /// Apex Test Queue Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Test Queue Item ID")]
        public string QueueItemId { get; private set; }

        /// <summary>
        /// Log ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Log ID")]
        public string ApexLogId { get; private set; }

    }

    /// <summary>
    /// POCO for ApexTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ApexTrigger
    {
        /// <summary>
        /// Trigger ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Trigger ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Custom Object Definition ID (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Custom Object Definition ID")]
        public string TableEnumOrId { get; set; }

        /// <summary>
        /// BeforeInsert (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "BeforeInsert")]
        public bool? UsageBeforeInsert { get; set; }

        /// <summary>
        /// AfterInsert (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AfterInsert")]
        public bool? UsageAfterInsert { get; set; }

        /// <summary>
        /// BeforeUpdate (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "BeforeUpdate")]
        public bool? UsageBeforeUpdate { get; set; }

        /// <summary>
        /// AfterUpdate (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AfterUpdate")]
        public bool? UsageAfterUpdate { get; set; }

        /// <summary>
        /// BeforeDelete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "BeforeDelete")]
        public bool? UsageBeforeDelete { get; set; }

        /// <summary>
        /// AfterDelete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AfterDelete")]
        public bool? UsageAfterDelete { get; set; }

        /// <summary>
        /// IsBulk (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "IsBulk")]
        public bool? UsageIsBulk { get; set; }

        /// <summary>
        /// AfterUndelete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AfterUndelete")]
        public bool? UsageAfterUndelete { get; set; }

        /// <summary>
        /// Api Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Api Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Is Valid (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Body CRC (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Body CRC")]
        public string BodyCrc { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000000)]
        public string Body { get; set; }

        /// <summary>
        /// Size Without Comments (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Size Without Comments")]
        public string LengthWithoutComments { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for AppMenuItem
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AppMenuItem
    {
        /// <summary>
        /// AppMenuItem ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "AppMenuItem ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Developer Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Developer Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Label { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Start Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start Url")]
        public string StartUrl { get; private set; }

        /// <summary>
        /// Mobile Start Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Mobile Start Url")]
        public string MobileStartUrl { get; private set; }

        /// <summary>
        /// Logo Image URL (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Logo Image URL")]
        public string LogoUrl { get; private set; }

        /// <summary>
        /// Icon Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Icon Url")]
        public string IconUrl { get; private set; }

        /// <summary>
        /// Info URL (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Info URL")]
        public string InfoUrl { get; private set; }

        /// <summary>
        /// IsUsingAdminAuthorization (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public bool? IsUsingAdminAuthorization { get; private set; }

        /// <summary>
        /// Mobile device OS platform (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Mobile device OS platform")]
        public string MobilePlatform { get; private set; }

        /// <summary>
        /// Minimum required mobile device OS version (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Minimum required mobile device OS version")]
        public string MobileMinOsVer { get; private set; }

        /// <summary>
        /// Type of mobile device (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Type of mobile device")]
        public string MobileDeviceType { get; private set; }

        /// <summary>
        /// App requires a registered mobile device (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "App requires a registered mobile device")]
        public bool? IsRegisteredDeviceOnly { get; private set; }

        /// <summary>
        /// Version of the mobile app (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Version of the mobile app")]
        public string MobileAppVer { get; private set; }

        /// <summary>
        /// Date the mobile app was most recently installed (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date the mobile app was most recently installed")]
        public string MobileAppInstalledDate { get; private set; }

        /// <summary>
        /// Most recently installed version of the mobile app (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Most recently installed version of the mobile app")]
        public string MobileAppInstalledVersion { get; private set; }

        /// <summary>
        /// ID for the related mobile app binary (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ID for the related mobile app binary")]
        public string MobileAppBinaryId { get; private set; }

        /// <summary>
        /// URL to install the mobile app (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "URL to install the mobile app")]
        public string MobileAppInstallUrl { get; private set; }

        /// <summary>
        /// App Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "App Type")]
        public string Type { get; private set; }

    }

    /// <summary>
    /// POCO for Approval
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Approval
    {
        /// <summary>
        /// Approval ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Approval ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Request Comment (string type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Request Comment")]
        public string RequestComment { get; set; }

        /// <summary>
        /// Approve/Reject Comment (string type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Approve/Reject Comment")]
        public string ApproveComment { get; set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Asset
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Asset
    {
        /// <summary>
        /// Asset ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Asset ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Account ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// Product ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Product ID")]
        public string Product2Id { get; set; }

        /// <summary>
        /// Competitor Asset (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Competitor Asset")]
        public bool? IsCompetitorProduct { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Asset Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Asset Name")]
        public string Name { get; set; }

        /// <summary>
        /// Serial Number (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Install Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Install Date")]
        public string InstallDate { get; set; }

        /// <summary>
        /// Purchase Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Purchase Date")]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Usage End Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Usage End Date")]
        public string UsageEndDate { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Price (currency type in Salesforce)
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Quantity (double type in Salesforce)
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

    }

    /// <summary>
    /// POCO for AssetFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AssetFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for AssignmentRule
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AssignmentRule
    {
        /// <summary>
        /// Rule ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Rule ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// SObject Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "SObject Type")]
        public string SobjectType { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public bool? Active { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for AsyncApexJob
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AsyncApexJob
    {
        /// <summary>
        /// Apex Job ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Job ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Job Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job Type")]
        public string JobType { get; private set; }

        /// <summary>
        /// Class ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Class ID")]
        public string ApexClassId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Batches Processed (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Batches Processed")]
        public string JobItemsProcessed { get; private set; }

        /// <summary>
        /// Total Batches (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Batches")]
        public string TotalJobItems { get; private set; }

        /// <summary>
        /// Failures (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Failures")]
        public string NumberOfErrors { get; private set; }

        /// <summary>
        /// Completion Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Completion Date")]
        public string CompletedDate { get; private set; }

        /// <summary>
        /// Apex Method (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Method")]
        public string MethodName { get; private set; }

        /// <summary>
        /// Status Detail (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Status Detail")]
        public string ExtendedStatus { get; private set; }

        /// <summary>
        /// Apex Job ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Apex Job ID")]
        public string ParentJobId { get; private set; }

        /// <summary>
        /// Last ID processed and committed (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last ID processed and committed")]
        public string LastProcessed { get; private set; }

        /// <summary>
        /// Offset of last ID processed and committed (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Offset of last ID processed and committed")]
        public string LastProcessedOffset { get; private set; }

    }

    /// <summary>
    /// POCO for AttachedContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AttachedContentDocument
    {
        /// <summary>
        /// Content Document Link Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Document Link Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string LinkedEntityId { get; private set; }

        /// <summary>
        /// ContentDocument ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string ContentDocumentId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Content Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Modified Date")]
        public string LastModifiedDate { get; private set; }

    }

    /// <summary>
    /// POCO for Attachment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Attachment
    {
        /// <summary>
        /// Attachment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Attachment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// File Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "File Name")]
        public string Name { get; set; }

        /// <summary>
        /// Private (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Content Type (string type in Salesforce)
        /// </summary>
        //[StringLength(120)]
        //[Display(Name = "Content Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Body Length (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Body Length")]
        public string BodyLength { get; private set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(500)]
        public string Description { get; set; }

    }

    /// <summary>
    /// POCO for AuthProvider
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AuthProvider
    {
        /// <summary>
        /// Auth. Provider ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Auth. Provider ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Provider Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Provider Type")]
        public string ProviderType { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(32)]
        //[Display(Name = "Name")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// URL Suffix (string type in Salesforce)
        /// </summary>
        //[StringLength(32)]
        //[Display(Name = "URL Suffix")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Class ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Class ID")]
        public string RegistrationHandlerId { get; set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "User ID")]
        public string ExecutionUserId { get; set; }

        /// <summary>
        /// Consumer Key (string type in Salesforce)
        /// </summary>
        //[StringLength(256)]
        //[Display(Name = "Consumer Key")]
        public string ConsumerKey { get; set; }

        /// <summary>
        /// Consumer Secret (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Consumer Secret")]
        public string ConsumerSecret { get; private set; }

        /// <summary>
        /// Custom Error URL (string type in Salesforce)
        /// </summary>
        //[StringLength(500)]
        //[Display(Name = "Custom Error URL")]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Authorize Endpoint URL (url type in Salesforce)
        /// </summary>
        //[StringLength(1024)]
        //[Display(Name = "Authorize Endpoint URL")]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// Token Endpoint URL (url type in Salesforce)
        /// </summary>
        //[StringLength(1024)]
        //[Display(Name = "Token Endpoint URL")]
        public string TokenUrl { get; set; }

        /// <summary>
        /// User Info Endpoint URL (url type in Salesforce)
        /// </summary>
        //[StringLength(1024)]
        //[Display(Name = "User Info Endpoint URL")]
        public string UserInfoUrl { get; set; }

        /// <summary>
        /// Default Scopes (string type in Salesforce)
        /// </summary>
        //[StringLength(256)]
        //[Display(Name = "Default Scopes")]
        public string DefaultScopes { get; set; }

    }

    /// <summary>
    /// POCO for AuthSession
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class AuthSession
    {
        /// <summary>
        /// Auth Session ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Auth Session ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UsersId { get; private set; }

        /// <summary>
        /// Created (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Updated (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Updated")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Valid For (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Valid For")]
        public string NumSecondsValid { get; private set; }

        /// <summary>
        /// User Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Type")]
        public string UserType { get; private set; }

        /// <summary>
        /// Source IP (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Source IP")]
        public string SourceIp { get; private set; }

        /// <summary>
        /// Login (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login")]
        public string LoginType { get; private set; }

        /// <summary>
        /// Session Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Session Type")]
        public string SessionType { get; private set; }

        /// <summary>
        /// Session Security Level (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Session Security Level")]
        public string SessionSecurityLevel { get; private set; }

    }

    /// <summary>
    /// POCO for BrandTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class BrandTemplate
    {
        /// <summary>
        /// Letterhead ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Letterhead ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Brand Template Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Brand Template Name")]
        public string Name { get; set; }

        /// <summary>
        /// Letterhead Unique Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Letterhead Unique Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Value (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Value { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for BusinessHours
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class BusinessHours
    {
        /// <summary>
        /// Business Hours ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Business Hours ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Business Hours Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Business Hours Name")]
        public string Name { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Default Business Hours (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Default Business Hours")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Sunday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Sunday Start")]
        public string SundayStartTime { get; set; }

        /// <summary>
        /// Sunday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Sunday End")]
        public string SundayEndTime { get; set; }

        /// <summary>
        /// Monday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Monday Start")]
        public string MondayStartTime { get; set; }

        /// <summary>
        /// Monday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Monday End")]
        public string MondayEndTime { get; set; }

        /// <summary>
        /// Tuesday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Tuesday Start")]
        public string TuesdayStartTime { get; set; }

        /// <summary>
        /// Tuesday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Tuesday End")]
        public string TuesdayEndTime { get; set; }

        /// <summary>
        /// Wednesday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Wednesday Start")]
        public string WednesdayStartTime { get; set; }

        /// <summary>
        /// Wednesday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Wednesday End")]
        public string WednesdayEndTime { get; set; }

        /// <summary>
        /// Thursday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Thursday Start")]
        public string ThursdayStartTime { get; set; }

        /// <summary>
        /// Thursday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Thursday End")]
        public string ThursdayEndTime { get; set; }

        /// <summary>
        /// Friday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Friday Start")]
        public string FridayStartTime { get; set; }

        /// <summary>
        /// Friday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Friday End")]
        public string FridayEndTime { get; set; }

        /// <summary>
        /// Saturday Start (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Saturday Start")]
        public string SaturdayStartTime { get; set; }

        /// <summary>
        /// Saturday End (time type in Salesforce)
        /// </summary>
        //[Display(Name = "Saturday End")]
        public string SaturdayEndTime { get; set; }

        /// <summary>
        /// Time Zone (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Time Zone")]
        public string TimeZoneSidKey { get; set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for BusinessProcess
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class BusinessProcess
    {
        /// <summary>
        /// Business Process ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Business Process ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Entity Enumeration Or ID (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Entity Enumeration Or ID")]
        public string TableEnumOrId { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CallCenter
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CallCenter
    {
        /// <summary>
        /// Call Center ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Center ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Internal Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Internal Name")]
        public string InternalName { get; private set; }

        /// <summary>
        /// Version (double type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Version { get; private set; }

        /// <summary>
        /// CTI Adapter URL (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "CTI Adapter URL")]
        public string AdapterUrl { get; private set; }

        /// <summary>
        /// Custom Settings (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Custom Settings")]
        public string CustomSettings { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for Campaign
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Campaign
    {
        /// <summary>
        /// Campaign ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Parent Campaign ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent Campaign ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Start Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Date")]
        public string StartDate { get; set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "End Date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Expected Revenue (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Expected Revenue")]
        public string ExpectedRevenue { get; set; }

        /// <summary>
        /// Budgeted Cost (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Budgeted Cost")]
        public string BudgetedCost { get; set; }

        /// <summary>
        /// Actual Cost (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Actual Cost")]
        public string ActualCost { get; set; }

        /// <summary>
        /// Expected Response (%) (percent type in Salesforce)
        /// </summary>
        //[Display(Name = "Expected Response (%)")]
        public string ExpectedResponse { get; set; }

        /// <summary>
        /// Num Sent (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Num Sent")]
        public string NumberSent { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Total Leads (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Leads")]
        public string NumberOfLeads { get; private set; }

        /// <summary>
        /// Converted Leads (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted Leads")]
        public string NumberOfConvertedLeads { get; private set; }

        /// <summary>
        /// Total Contacts (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Contacts")]
        public string NumberOfContacts { get; private set; }

        /// <summary>
        /// Total Responses (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Responses")]
        public string NumberOfResponses { get; private set; }

        /// <summary>
        /// Num Total Opportunities (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Num Total Opportunities")]
        public string NumberOfOpportunities { get; private set; }

        /// <summary>
        /// Num Won Opportunities (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Num Won Opportunities")]
        public string NumberOfWonOpportunities { get; private set; }

        /// <summary>
        /// Total Value Opportunities (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Value Opportunities")]
        public string AmountAllOpportunities { get; private set; }

        /// <summary>
        /// Total Value Won Opportunities (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Value Won Opportunities")]
        public string AmountWonOpportunities { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Record Type ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Record Type ID")]
        public string CampaignMemberRecordTypeId { get; set; }

    }

    /// <summary>
    /// POCO for CampaignFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CampaignFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for CampaignMember
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CampaignMember
    {
        /// <summary>
        /// Campaign Member ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign Member ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Campaign ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign ID")]
        public string CampaignId { get; private set; }

        /// <summary>
        /// Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead ID")]
        public string LeadId { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Responded (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Responded")]
        public bool? HasResponded { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// First Responded Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "First Responded Date")]
        public string FirstRespondedDate { get; private set; }

    }

    /// <summary>
    /// POCO for CampaignMemberStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CampaignMemberStatus
    {
        /// <summary>
        /// Campaign Member Status ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign Member Status ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Campaign ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign ID")]
        public string CampaignId { get; private set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Label { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Responded (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Responded")]
        public bool? HasResponded { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CampaignShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CampaignShare
    {
        /// <summary>
        /// Campaign Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Campaign ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign ID")]
        public string CampaignId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Campaign Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Campaign Access")]
        public string CampaignAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for Case
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Case
    {
        /// <summary>
        /// Case ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Case Number (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Number")]
        public string CaseNumber { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Account ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// Asset ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Asset ID")]
        public string AssetId { get; set; }

        /// <summary>
        /// Parent Case ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent Case ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Name")]
        public string SuppliedName { get; set; }

        /// <summary>
        /// Email Address (email type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Email Address")]
        public string SuppliedEmail { get; set; }

        /// <summary>
        /// Phone (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Phone")]
        public string SuppliedPhone { get; set; }

        /// <summary>
        /// Company (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Company")]
        public string SuppliedCompany { get; set; }

        /// <summary>
        /// Case Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Case Type")]
        public string Type { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Case Reason (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Case Reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Case Origin (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Case Origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Subject (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Closed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed Date")]
        public string ClosedDate { get; private set; }

        /// <summary>
        /// Escalated (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Escalated")]
        public bool? IsEscalated { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Engineering Req Number (string type in Salesforce)
        /// </summary>
        //[StringLength(12)]
        //[Display(Name = "Engineering Req Number")]
        public string EngineeringReqNumber__c { get; set; }

        /// <summary>
        /// SLA Violation (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "SLA Violation")]
        public string SLAViolation__c { get; set; }

        /// <summary>
        /// Product (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Product")]
        public string Product__c { get; set; }

        /// <summary>
        /// Potential Liability (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Potential Liability")]
        public string PotentialLiability__c { get; set; }

    }

    /// <summary>
    /// POCO for CaseComment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseComment
    {
        /// <summary>
        /// Case Comment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Comment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Published (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Body")]
        public string CommentBody { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for CaseContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseContactRole
    {
        /// <summary>
        /// Contact Role ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Role ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string CasesId { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for CaseFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for CaseHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseHistory
    {
        /// <summary>
        /// Case History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string CaseId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for CaseShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseShare
    {
        /// <summary>
        /// Case Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string CaseId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Case Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Access")]
        public string CaseAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for CaseSolution
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseSolution
    {
        /// <summary>
        /// Case Solution ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Solution ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string CaseId { get; private set; }

        /// <summary>
        /// Solution ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution ID")]
        public string SolutionId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for CaseStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseStatus
    {
        /// <summary>
        /// Case Status Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case Status Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Is Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CaseTeamMember
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseTeamMember
    {
        /// <summary>
        /// Team Member Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Member Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Member ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Member ID")]
        public string MemberId { get; private set; }

        /// <summary>
        /// Team Template Member ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Template Member ID")]
        public string TeamTemplateMemberId { get; private set; }

        /// <summary>
        /// Team Role ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Team Role ID")]
        public string TeamRoleId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CaseTeamRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseTeamRole
    {
        /// <summary>
        /// Team Role Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Role Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Access Level (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Access Level")]
        public string AccessLevel { get; set; }

        /// <summary>
        /// Visible in Customer Portal (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Visible in Customer Portal")]
        public bool? PreferencesVisibleInCSP { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseTeamTemplate
    {
        /// <summary>
        /// Team Template Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Template Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(300)]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplateMember
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseTeamTemplateMember
    {
        /// <summary>
        /// Team Template Member Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Template Member Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Team Template ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Template ID")]
        public string TeamTemplateId { get; private set; }

        /// <summary>
        /// Member ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Member ID")]
        public string MemberId { get; private set; }

        /// <summary>
        /// Team Role ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Team Role ID")]
        public string TeamRoleId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplateRecord
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CaseTeamTemplateRecord
    {
        /// <summary>
        /// Predefined Team Record Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Predefined Team Record Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Case ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Case ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Team Template ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Team Template ID")]
        public string TeamTemplateId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CategoryData
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CategoryData
    {
        /// <summary>
        /// Category Data ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Category Data ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Category Node ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Category Node ID")]
        public string CategoryNodeId { get; set; }

        /// <summary>
        /// SObject ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "SObject ID")]
        public string RelatedSobjectId { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CategoryNode
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CategoryNode
    {
        /// <summary>
        /// Category Node ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Category Node ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent Category Node ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent Category Node ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Name")]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Subcategory Sort Style (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Subcategory Sort Style")]
        public string SortStyle { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ChatterActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ChatterActivity
    {
        /// <summary>
        /// Chatter Activity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Chatter Activity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Post Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Post Count")]
        public string PostCount { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Comment Received Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Received Count")]
        public string CommentReceivedCount { get; private set; }

        /// <summary>
        /// Like Received Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Received Count")]
        public string LikeReceivedCount { get; private set; }

        /// <summary>
        /// Influence Raw Rank (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Influence Raw Rank")]
        public string InfluenceRawRank { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ClientBrowser
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ClientBrowser
    {
        /// <summary>
        /// Client Browser ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Client Browser ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UsersId { get; private set; }

        /// <summary>
        /// Full User Agent (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Full User Agent")]
        public string FullUserAgent { get; private set; }

        /// <summary>
        /// Proxy Info (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Proxy Info")]
        public string ProxyInfo { get; private set; }

        /// <summary>
        /// Last Update (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Update")]
        public string LastUpdate { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

    }

    /// <summary>
    /// POCO for CollaborationGroup
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CollaborationGroup
    {
        /// <summary>
        /// Chatter Group Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Chatter Group Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// Member Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Member Count")]
        public string MemberCount { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Access Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Access Type")]
        public string CollaborationType { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Url for full-sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for full-sized Photo")]
        public string FullPhotoUrl { get; private set; }

        /// <summary>
        /// Url for Thumbnail sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for Thumbnail sized Photo")]
        public string SmallPhotoUrl { get; private set; }

        /// <summary>
        /// Last Feed Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Feed Modified Date")]
        public string LastFeedModifiedDate { get; private set; }

        /// <summary>
        /// Information Title (string type in Salesforce)
        /// </summary>
        //[StringLength(30)]
        //[Display(Name = "Information Title")]
        public string InformationTitle { get; set; }

        /// <summary>
        /// Information (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        //[Display(Name = "Information")]
        public string InformationBody { get; set; }

        /// <summary>
        /// Has Private Fields Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Private Fields Access")]
        public bool? HasPrivateFieldsAccess { get; private set; }

        /// <summary>
        /// Allow Customers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Allow Customers")]
        public bool? CanHaveGuests { get; set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Is Archived (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Is Auto Archive Disabled (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Auto Archive Disabled")]
        public bool? IsAutoArchiveDisabled { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CollaborationGroupFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CollaborationGroupMember
    {
        /// <summary>
        /// Chatter Group Member Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Chatter Group Member Id")]
        public string Id { get; private set; }

        /// <summary>
        /// CollaborationGroup ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "CollaborationGroup ID")]
        public string CollaborationGroupId { get; private set; }

        /// <summary>
        /// Member ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Member ID")]
        public string MemberId { get; private set; }

        /// <summary>
        /// Chatter Role (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Chatter Role")]
        public string CollaborationRole { get; set; }

        /// <summary>
        /// Notification Frequency (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Notification Frequency")]
        public string NotificationFrequency { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupMemberRequest
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CollaborationGroupMemberRequest
    {
        /// <summary>
        /// Chatter Group Member Request Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Chatter Group Member Request Id")]
        public string Id { get; private set; }

        /// <summary>
        /// CollaborationGroup ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "CollaborationGroup ID")]
        public string CollaborationGroupId { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string RequesterId { get; private set; }

        /// <summary>
        /// Response Message (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Response Message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CollaborationInvitation
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CollaborationInvitation
    {
        /// <summary>
        /// Chatter Invitation Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Chatter Invitation Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Shared Entity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Shared Entity ID")]
        public string SharedEntityId { get; private set; }

        /// <summary>
        /// Inviter User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Inviter User ID")]
        public string InviterId { get; private set; }

        /// <summary>
        /// Invited Email (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Invited Email")]
        public string InvitedUserEmail { get; private set; }

        /// <summary>
        /// Invited Email (Normalized) (email type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Invited Email (Normalized)")]
        public string InvitedUserEmailNormalized { get; private set; }

        /// <summary>
        /// Invitation Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Invitation Status")]
        public string Status { get; private set; }

        /// <summary>
        /// Optional Message (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Optional Message")]
        public string OptionalMessage { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CombinedAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CombinedAttachment
    {
        /// <summary>
        /// Combined Attachment Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Combined Attachment Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Type")]
        public string RecordType { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Created (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Content Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for Community
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Community
    {
        /// <summary>
        /// Zone ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Zone ID")]
        public string Id { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Active")]
        public bool? IsActive { get; private set; }

    }

    /// <summary>
    /// POCO for Contact
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Contact
    {
        /// <summary>
        /// Contact ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact ID")]
        public string Id { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Master Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Record ID")]
        public string MasterRecordId { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Account ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Salutation (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Salutation { get; set; }

        /// <summary>
        /// Full Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Full Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Other Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Other Street")]
        public string OtherStreet { get; set; }

        /// <summary>
        /// Other City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Other City")]
        public string OtherCity { get; set; }

        /// <summary>
        /// Other State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Other State/Province")]
        public string OtherState { get; set; }

        /// <summary>
        /// Other Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Other Zip/Postal Code")]
        public string OtherPostalCode { get; set; }

        /// <summary>
        /// Other Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Other Country")]
        public string OtherCountry { get; set; }

        /// <summary>
        /// Other Latitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Other Latitude")]
        public string OtherLatitude { get; set; }

        /// <summary>
        /// Other Longitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Other Longitude")]
        public string OtherLongitude { get; set; }

        /// <summary>
        /// Mailing Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Mailing Street")]
        public string MailingStreet { get; set; }

        /// <summary>
        /// Mailing City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Mailing City")]
        public string MailingCity { get; set; }

        /// <summary>
        /// Mailing State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Mailing State/Province")]
        public string MailingState { get; set; }

        /// <summary>
        /// Mailing Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Mailing Zip/Postal Code")]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// Mailing Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Mailing Country")]
        public string MailingCountry { get; set; }

        /// <summary>
        /// Mailing Latitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Mailing Latitude")]
        public string MailingLatitude { get; set; }

        /// <summary>
        /// Mailing Longitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Mailing Longitude")]
        public string MailingLongitude { get; set; }

        /// <summary>
        /// Business Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Business Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Business Fax (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Business Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// Mobile Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Home Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Other Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Other Phone")]
        public string OtherPhone { get; set; }

        /// <summary>
        /// Asst. Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Asst. Phone")]
        public string AssistantPhone { get; set; }

        /// <summary>
        /// Reports To ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Reports To ID")]
        public string ReportsToId { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(128)]
        public string Title { get; set; }

        /// <summary>
        /// Department (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Department { get; set; }

        /// <summary>
        /// Assistant's Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Assistant's Name")]
        public string AssistantName { get; set; }

        /// <summary>
        /// Lead Source (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Lead Source")]
        public string LeadSource { get; set; }

        /// <summary>
        /// Birthdate (date type in Salesforce)
        /// </summary>
        public string Birthdate { get; set; }

        /// <summary>
        /// Contact Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        //[Display(Name = "Contact Description")]
        public string Description { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Last Stay-in-Touch Request Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Stay-in-Touch Request Date")]
        public string LastCURequestDate { get; private set; }

        /// <summary>
        /// Last Stay-in-Touch Save Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Stay-in-Touch Save Date")]
        public string LastCUUpdateDate { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Email Bounced Reason (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Email Bounced Reason")]
        public string EmailBouncedReason { get; set; }

        /// <summary>
        /// Email Bounced Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Email Bounced Date")]
        public string EmailBouncedDate { get; set; }

        /// <summary>
        /// Is Email Bounced (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Email Bounced")]
        public bool? IsEmailBounced { get; private set; }

        /// <summary>
        /// Data.com Key (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Data.com Key")]
        public string Jigsaw { get; set; }

        /// <summary>
        /// Jigsaw Contact ID (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Jigsaw Contact ID")]
        public string JigsawContactId { get; private set; }

        /// <summary>
        /// Level (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Level")]
        public string Level__c { get; set; }

        /// <summary>
        /// Languages (string type in Salesforce)
        /// </summary>
        //[StringLength(100)]
        //[Display(Name = "Languages")]
        public string Languages__c { get; set; }

    }

    /// <summary>
    /// POCO for ContactFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContactFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for ContactHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContactHistory
    {
        /// <summary>
        /// Contact History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for ContactShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContactShare
    {
        /// <summary>
        /// Contact Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Contact Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Access")]
        public string ContactAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for ContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentDocument
    {
        /// <summary>
        /// ContentDocument ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Is Archived (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string ArchivedById { get; private set; }

        /// <summary>
        /// Archived Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Archived Date")]
        public string ArchivedDate { get; private set; }

        /// <summary>
        /// Is Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Publish Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Publish Status")]
        public string PublishStatus { get; private set; }

        /// <summary>
        /// Latest Published Version ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Latest Published Version ID")]
        public string LatestPublishedVersionId { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for ContentDocumentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentDocumentFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for ContentDocumentHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentDocumentHistory
    {
        /// <summary>
        /// Content Document ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Document ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// ContentDocument ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string ContentDocumentId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for ContentDocumentLink
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentDocumentLink
    {
        /// <summary>
        /// ContentDocumentLink ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocumentLink ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Linked Entity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Linked Entity ID")]
        public string LinkedEntityId { get; private set; }

        /// <summary>
        /// ContentDocument ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string ContentDocumentId { get; private set; }

        /// <summary>
        /// Is Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Share Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Share Type")]
        public string ShareType { get; set; }

    }

    /// <summary>
    /// POCO for ContentVersion
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentVersion
    {
        /// <summary>
        /// ContentVersion ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentVersion ID")]
        public string Id { get; private set; }

        /// <summary>
        /// ContentDocument ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string ContentDocumentId { get; private set; }

        /// <summary>
        /// Is Latest (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Latest")]
        public bool? IsLatest { get; private set; }

        /// <summary>
        /// Content URL (url type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Content URL")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Version Number (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Version Number")]
        public string VersionNumber { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Reason For Change (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reason For Change")]
        public string ReasonForChange { get; private set; }

        /// <summary>
        /// Path On Client (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Path On Client")]
        public string PathOnClient { get; private set; }

        /// <summary>
        /// Rating Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Rating Count")]
        public string RatingCount { get; private set; }

        /// <summary>
        /// Is Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Content Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Modified Date")]
        public string ContentModifiedDate { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string ContentModifiedById { get; private set; }

        /// <summary>
        /// Positive Rating Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Positive Rating Count")]
        public string PositiveRatingCount { get; private set; }

        /// <summary>
        /// Negative Rating Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Negative Rating Count")]
        public string NegativeRatingCount { get; private set; }

        /// <summary>
        /// Featured Content Boost (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Featured Content Boost")]
        public string FeaturedContentBoost { get; private set; }

        /// <summary>
        /// Featured Content Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Featured Content Date")]
        public string FeaturedContentDate { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Tags (textarea type in Salesforce)
        /// </summary>
        //[StringLength(2000)]
        //[Display(Name = "Tags")]
        public string TagCsv { get; set; }

        /// <summary>
        /// File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "File Type")]
        public string FileType { get; private set; }

        /// <summary>
        /// Publish Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Publish Status")]
        public string PublishStatus { get; private set; }

        /// <summary>
        /// Version Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Version Data")]
        public string VersionData { get; private set; }

        /// <summary>
        /// Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// First Publish Location ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "First Publish Location ID")]
        public string FirstPublishLocationId { get; private set; }

        /// <summary>
        /// Content Origin (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Origin")]
        public string Origin { get; private set; }

        /// <summary>
        /// Checksum (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Checksum { get; private set; }

    }

    /// <summary>
    /// POCO for ContentVersionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentVersionHistory
    {
        /// <summary>
        /// Content Version ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Version ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// ContentVersion ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentVersion ID")]
        public string ContentVersionId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for ContentWorkspace
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentWorkspace
    {
        /// <summary>
        /// Library ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Library ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Tag Model (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Tag Model")]
        public string TagModel { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Record Type ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record Type ID")]
        public string DefaultRecordTypeId { get; private set; }

        /// <summary>
        /// Restrict Content Types (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Restrict Content Types")]
        public bool? IsRestrictContentTypes { get; private set; }

        /// <summary>
        /// Restrict Linked Content Types (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Restrict Linked Content Types")]
        public bool? IsRestrictLinkedContentTypes { get; private set; }

    }

    /// <summary>
    /// POCO for ContentWorkspaceDoc
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContentWorkspaceDoc
    {
        /// <summary>
        /// Library Document ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Library Document ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Library ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Library ID")]
        public string ContentWorkspaceId { get; private set; }

        /// <summary>
        /// ContentDocument ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentDocument ID")]
        public string ContentDocumentId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Is Owning Library (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Owning Library")]
        public bool? IsOwner { get; private set; }

        /// <summary>
        /// Is Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for Contract
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Contract
    {
        /// <summary>
        /// Contract ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Account ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// Owner Expiration Notice (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Owner Expiration Notice")]
        public string OwnerExpirationNotice { get; set; }

        /// <summary>
        /// Contract Start Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Contract Start Date")]
        public string StartDate { get; set; }

        /// <summary>
        /// Contract End Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract End Date")]
        public string EndDate { get; private set; }

        /// <summary>
        /// Billing Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Billing Street")]
        public string BillingStreet { get; set; }

        /// <summary>
        /// Billing City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        /// <summary>
        /// Billing State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Billing State/Province")]
        public string BillingState { get; set; }

        /// <summary>
        /// Billing Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Billing Zip/Postal Code")]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// Billing Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Billing Country")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// Billing Latitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Billing Latitude")]
        public string BillingLatitude { get; set; }

        /// <summary>
        /// Billing Longitude (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Billing Longitude")]
        public string BillingLongitude { get; set; }

        /// <summary>
        /// Contract Term (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Contract Term")]
        public string ContractTerm { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Company Signed By ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Company Signed By ID")]
        public string CompanySignedId { get; set; }

        /// <summary>
        /// Company Signed Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Company Signed Date")]
        public string CompanySignedDate { get; set; }

        /// <summary>
        /// Customer Signed By ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Customer Signed By ID")]
        public string CustomerSignedId { get; set; }

        /// <summary>
        /// Customer Signed Title (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Customer Signed Title")]
        public string CustomerSignedTitle { get; set; }

        /// <summary>
        /// Customer Signed Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Customer Signed Date")]
        public string CustomerSignedDate { get; set; }

        /// <summary>
        /// Special Terms (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Special Terms")]
        public string SpecialTerms { get; set; }

        /// <summary>
        /// Activated By ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Activated By ID")]
        public string ActivatedById { get; set; }

        /// <summary>
        /// Activated Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Activated Date")]
        public string ActivatedDate { get; set; }

        /// <summary>
        /// Status Category (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Status Category")]
        public string StatusCode { get; private set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Contract Number (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract Number")]
        public string ContractNumber { get; private set; }

        /// <summary>
        /// Last Approved Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Approved Date")]
        public string LastApprovedDate { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for ContractContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContractContactRole
    {
        /// <summary>
        /// Contact Role ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Role ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Contract ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract ID")]
        public string ContractId { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for ContractFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContractFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for ContractHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContractHistory
    {
        /// <summary>
        /// Contract History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Contract ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract ID")]
        public string ContractId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for ContractStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ContractStatus
    {
        /// <summary>
        /// Contract Status Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contract Status Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Status Code (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Status Code")]
        public string StatusCode { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for CronJobDetail
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CronJobDetail
    {
        /// <summary>
        /// Job ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Job Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Type")]
        public string JobType { get; private set; }

    }

    /// <summary>
    /// POCO for CronTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class CronTrigger
    {
        /// <summary>
        /// Scheduled Job ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Scheduled Job ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Job ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job ID")]
        public string CronJobDetailId { get; private set; }

        /// <summary>
        /// Next Run Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Next Run Time")]
        public string NextFireTime { get; private set; }

        /// <summary>
        /// Previous Run Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Previous Run Time")]
        public string PreviousFireTime { get; private set; }

        /// <summary>
        /// Job State (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job State")]
        public string State { get; private set; }

        /// <summary>
        /// Start Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start Time")]
        public string StartTime { get; private set; }

        /// <summary>
        /// End Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "End Time")]
        public string EndTime { get; private set; }

        /// <summary>
        /// Cron Expression (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Cron Expression")]
        public string CronExpression { get; private set; }

        /// <summary>
        /// Java Time Zone Id (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Java Time Zone Id")]
        public string TimeZoneSidKey { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Job Fired Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Job Fired Count")]
        public string TimesTriggered { get; private set; }

    }

    /// <summary>
    /// POCO for Dashboard
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Dashboard
    {
        /// <summary>
        /// Dashboard ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Folder ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Folder ID")]
        public string FolderId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Dashboard Unique Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard Unique Name")]
        public string DeveloperName { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Left Size (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Left Size")]
        public string LeftSize { get; private set; }

        /// <summary>
        /// Middle Size (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Middle Size")]
        public string MiddleSize { get; private set; }

        /// <summary>
        /// Right Size (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Right Size")]
        public string RightSize { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Running User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Running User ID")]
        public string RunningUserId { get; private set; }

        /// <summary>
        /// Title Color (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Title Color")]
        public string TitleColor { get; private set; }

        /// <summary>
        /// Title Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Title Size")]
        public string TitleSize { get; private set; }

        /// <summary>
        /// Text Color (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Text Color")]
        public string TextColor { get; private set; }

        /// <summary>
        /// Starting Color (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Starting Color")]
        public string BackgroundStart { get; private set; }

        /// <summary>
        /// Ending Color (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Ending Color")]
        public string BackgroundEnd { get; private set; }

        /// <summary>
        /// Background Fade Direction (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Background Fade Direction")]
        public string BackgroundDirection { get; private set; }

        /// <summary>
        /// Dashboard Running User (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard Running User")]
        public string Type { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for DashboardComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DashboardComponent
    {
        /// <summary>
        /// Dashboard Component ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard Component ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Dashboard Component Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard Component Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Dashboard ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Dashboard ID")]
        public string DashboardId { get; private set; }

    }

    /// <summary>
    /// POCO for DashboardComponentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DashboardComponentFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for DashboardFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DashboardFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for DeclinedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DeclinedEventRelation
    {
        /// <summary>
        /// Event Relation ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event Relation ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Relation ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Relation ID")]
        public string RelationId { get; private set; }

        /// <summary>
        /// Event ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event ID")]
        public string EventId { get; private set; }

        /// <summary>
        /// Response Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Response Date")]
        public string RespondedDate { get; private set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Response { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

    }

    /// <summary>
    /// POCO for Document
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Document
    {
        /// <summary>
        /// Document ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Document ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Folder ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Folder ID")]
        public string FolderId { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Document Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Document Name")]
        public string Name { get; set; }

        /// <summary>
        /// Document Unique Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Document Unique Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// MIME Type (string type in Salesforce)
        /// </summary>
        //[StringLength(120)]
        //[Display(Name = "MIME Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// File Extension (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "File Extension")]
        public string Type { get; set; }

        /// <summary>
        /// Externally Available (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Externally Available")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Body Length (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Body Length")]
        public string BodyLength { get; private set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Url (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Url { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Keywords (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Keywords { get; set; }

        /// <summary>
        /// Internal Use Only (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Internal Use Only")]
        public bool? IsInternalUseOnly { get; set; }

        /// <summary>
        /// Author ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Author ID")]
        public string AuthorId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Document Content Searchable (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Document Content Searchable")]
        public bool? IsBodySearchable { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for DocumentAttachmentMap
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DocumentAttachmentMap
    {
        /// <summary>
        /// Document Entity Map Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Document Entity Map Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Entity ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Entity ID")]
        public string ParentId { get; set; }

        /// <summary>
        /// Document ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Document ID")]
        public string DocumentId { get; set; }

        /// <summary>
        /// Attachment Sequence (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Attachment Sequence")]
        public string DocumentSequence { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

    }

    /// <summary>
    /// POCO for Domain
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Domain
    {
        /// <summary>
        /// Domain ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Domain ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Domain Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Domain Type")]
        public string DomainType { get; private set; }

        /// <summary>
        /// Domain Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Domain Name")]
        public string Domain2 { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for DomainSite
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class DomainSite
    {
        /// <summary>
        /// Custom URL ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Custom URL ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Domain ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Domain ID")]
        public string DomainId { get; private set; }

        /// <summary>
        /// Site ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site ID")]
        public string SiteId { get; private set; }

        /// <summary>
        /// Path (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Path")]
        public string PathPrefix { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for EmailServicesAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EmailServicesAddress
    {
        /// <summary>
        /// Address ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Address ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Email address (string type in Salesforce)
        /// </summary>
        //[StringLength(64)]
        //[Display(Name = "Email address")]
        public string LocalPart { get; set; }

        /// <summary>
        /// Email address domain (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Email address domain")]
        public string EmailDomainName { get; private set; }

        /// <summary>
        /// Accept Email From (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Accept Email From")]
        public string AuthorizedSenders { get; set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "User ID")]
        public string RunAsUserId { get; set; }

        /// <summary>
        /// Service ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Service ID")]
        public string FunctionId { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for EmailServicesFunction
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EmailServicesFunction
    {
        /// <summary>
        /// Service ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Service ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Email Service Name (string type in Salesforce)
        /// </summary>
        //[StringLength(64)]
        //[Display(Name = "Email Service Name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// Accept Email From (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Accept Email From")]
        public string AuthorizedSenders { get; set; }

        /// <summary>
        /// Advanced Email Security Settings (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Advanced Email Security Settings")]
        public bool? IsAuthenticationRequired { get; set; }

        /// <summary>
        /// TLS Required (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "TLS Required")]
        public bool? IsTlsRequired { get; set; }

        /// <summary>
        /// Accept Attachments (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Accept Attachments")]
        public string AttachmentOption { get; set; }

        /// <summary>
        /// Class ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Class ID")]
        public string ApexClassId { get; set; }

        /// <summary>
        /// Over Email Rate Limit Action (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Over Email Rate Limit Action")]
        public string OverLimitAction { get; set; }

        /// <summary>
        /// Deactivated Email Service Action (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Deactivated Email Service Action")]
        public string FunctionInactiveAction { get; set; }

        /// <summary>
        /// Deactivated Email Address Action (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Deactivated Email Address Action")]
        public string AddressInactiveAction { get; set; }

        /// <summary>
        /// Unauthenticated Sender Action (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Unauthenticated Sender Action")]
        public string AuthenticationFailureAction { get; set; }

        /// <summary>
        /// Unauthorized Sender Action (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Unauthorized Sender Action")]
        public string AuthorizationFailureAction { get; set; }

        /// <summary>
        /// Enable Error Routing (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Enable Error Routing")]
        public bool? IsErrorRoutingEnabled { get; set; }

        /// <summary>
        /// Route Error Emails to This Email Address (email type in Salesforce)
        /// </summary>
        //[StringLength(270)]
        //[Display(Name = "Route Error Emails to This Email Address")]
        public string ErrorRoutingAddress { get; set; }

        /// <summary>
        /// Convert Text Attachments to Binary Attachments (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Convert Text Attachments to Binary Attachments")]
        public bool? IsTextAttachmentsAsBinary { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for EmailStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EmailStatus
    {
        /// <summary>
        /// Email Status ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Email Status ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Activity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Activity ID")]
        public string TaskId { get; private set; }

        /// <summary>
        /// Contact/Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact/Lead ID")]
        public string WhoId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// # Times Opened (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "# Times Opened")]
        public string TimesOpened { get; private set; }

        /// <summary>
        /// Date Opened (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date Opened")]
        public string FirstOpenDate { get; private set; }

        /// <summary>
        /// Last Opened (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Opened")]
        public string LastOpenDate { get; private set; }

        /// <summary>
        /// Email Template Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Email Template Name")]
        public string EmailTemplateName { get; private set; }

    }

    /// <summary>
    /// POCO for EmailTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EmailTemplate
    {
        /// <summary>
        /// Email Template ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Email Template ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Email Template Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Email Template Name")]
        public string Name { get; set; }

        /// <summary>
        /// Template Unique Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Template Unique Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Folder ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Folder ID")]
        public string FolderId { get; set; }

        /// <summary>
        /// Letterhead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Letterhead ID")]
        public string BrandTemplateId { get; private set; }

        /// <summary>
        /// Style (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Style")]
        public string TemplateStyle { get; private set; }

        /// <summary>
        /// Available For Use (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Available For Use")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Template Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Template Type")]
        public string TemplateType { get; private set; }

        /// <summary>
        /// Encoding (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Encoding { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// Subject (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// HTML Value (textarea type in Salesforce)
        /// </summary>
        //[StringLength(384000)]
        //[Display(Name = "HTML Value")]
        public string HtmlValue { get; set; }

        /// <summary>
        /// Email Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(384000)]
        //[Display(Name = "Email Body")]
        public string Body { get; set; }

        /// <summary>
        /// Times Used (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Times Used")]
        public string TimesUsed { get; private set; }

        /// <summary>
        /// Last Used Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Used Date")]
        public string LastUsedDate { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// API Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "API Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1048576)]
        public string Markup { get; set; }

    }

    /// <summary>
    /// POCO for EntitySubscription
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EntitySubscription
    {
        /// <summary>
        /// Entity Subscription ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Entity Subscription ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Subscriber ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Subscriber ID")]
        public string SubscriberId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for Event
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Event
    {
        /// <summary>
        /// Activity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Activity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Contact/Lead ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact/Lead ID")]
        public string WhoId { get; set; }

        /// <summary>
        /// Opportunity/Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Opportunity/Account ID")]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Location { get; set; }

        /// <summary>
        /// All Day Event (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "All Day Event")]
        public bool? IsAllDayEvent { get; set; }

        /// <summary>
        /// Due Date Time (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Due Date Time")]
        public string ActivityDateTime { get; set; }

        /// <summary>
        /// Due Date Only (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Due Date Only")]
        public string ActivityDate { get; set; }

        /// <summary>
        /// Duration (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Duration")]
        public string DurationInMinutes { get; set; }

        /// <summary>
        /// Start Date Time (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Date Time")]
        public string StartDateTime { get; set; }

        /// <summary>
        /// End Date Time (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "End Date Time")]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Assigned To ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Assigned To ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Private (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Show Time As (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Show Time As")]
        public string ShowAs { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Is Child (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Child")]
        public bool? IsChild { get; private set; }

        /// <summary>
        /// Is Group Event (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Group Event")]
        public bool? IsGroupEvent { get; private set; }

        /// <summary>
        /// Group Event Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Group Event Type")]
        public string GroupEventType { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Archived (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Archived")]
        public bool? IsArchived { get; private set; }

        /// <summary>
        /// Recurrence Activity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Recurrence Activity ID")]
        public string RecurrenceActivityId { get; private set; }

        /// <summary>
        /// Create Recurring Series of Events (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Create Recurring Series of Events")]
        public bool? IsRecurrence { get; private set; }

        /// <summary>
        /// Start Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Date")]
        public string RecurrenceStartDateTime { get; set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "End Date")]
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// Recurrence Time Zone (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Time Zone")]
        public string RecurrenceTimeZoneSidKey { get; set; }

        /// <summary>
        /// Recurrence Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Type")]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// Recurrence Interval (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Interval")]
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// Recurrence Day of Week Mask (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Week Mask")]
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// Recurrence Day of Month (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Month")]
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// Recurrence Instance (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Instance")]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// Recurrence Month of Year (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Month of Year")]
        public string RecurrenceMonthOfYear { get; set; }

        /// <summary>
        /// Reminder Date/Time (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Reminder Date/Time")]
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// Reminder Set (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Reminder Set")]
        public bool? IsReminderSet { get; set; }

    }

    /// <summary>
    /// POCO for EventFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EventFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for EventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class EventRelation
    {
        /// <summary>
        /// Event Relation ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event Relation ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Relation ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Relation ID")]
        public string RelationId { get; private set; }

        /// <summary>
        /// Event ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event ID")]
        public string EventId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Response Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Response Date")]
        public string RespondedDate { get; set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Response { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for FeedComment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedComment
    {
        /// <summary>
        /// Feed Comment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Comment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedItemId { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Comment Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Body")]
        public string CommentBody { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

        /// <summary>
        /// Comment Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Type")]
        public string CommentType { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

    }

    /// <summary>
    /// POCO for FeedItem
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedItem
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for FeedLike
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedLike
    {
        /// <summary>
        /// Feed Like ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Like ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedItemId { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedEntityId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for FeedPollChoice
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedPollChoice
    {
        /// <summary>
        /// Feed Poll Choice ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Poll Choice ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedItemId { get; private set; }

        /// <summary>
        /// Position (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Position { get; private set; }

        /// <summary>
        /// ChoiceBody (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string ChoiceBody { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for FeedPollVote
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedPollVote
    {
        /// <summary>
        /// Feed Poll Vote ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Poll Vote ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedItemId { get; private set; }

        /// <summary>
        /// Feed Poll Choice ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Poll Choice ID")]
        public string ChoiceId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for FeedTrackedChange
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FeedTrackedChange
    {
        /// <summary>
        /// Feed Tracked Change ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Tracked Change ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Feed Item ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string FeedItemId { get; private set; }

        /// <summary>
        /// Field (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Field")]
        public string FieldName { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for FieldPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FieldPermissions
    {
        /// <summary>
        /// Field Permissions ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Field Permissions ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Sobject Type Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sobject Type Name")]
        public string SobjectType { get; private set; }

        /// <summary>
        /// Field Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Field Name")]
        public string Field { get; private set; }

        /// <summary>
        /// Edit Field (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Field")]
        public bool? PermissionsEdit { get; set; }

        /// <summary>
        /// Read Field (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Read Field")]
        public bool? PermissionsRead { get; set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for FiscalYearSettings
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class FiscalYearSettings
    {
        /// <summary>
        /// Fiscal Year Settings ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Year Settings ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Period ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Period ID")]
        public string PeriodId { get; private set; }

        /// <summary>
        /// Start Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start Date")]
        public string StartDate { get; private set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "End Date")]
        public string EndDate { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Is Standard Year (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Standard Year")]
        public bool? IsStandardYear { get; private set; }

        /// <summary>
        /// Year Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Year Type")]
        public string YearType { get; private set; }

        /// <summary>
        /// Quarter Name Scheme (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Quarter Name Scheme")]
        public string QuarterLabelScheme { get; private set; }

        /// <summary>
        /// Period Name Scheme (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Period Name Scheme")]
        public string PeriodLabelScheme { get; private set; }

        /// <summary>
        /// Week Name Scheme (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Week Name Scheme")]
        public string WeekLabelScheme { get; private set; }

        /// <summary>
        /// Quarter Prefix (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Quarter Prefix")]
        public string QuarterPrefix { get; private set; }

        /// <summary>
        /// Period Prefix (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Period Prefix")]
        public string PeriodPrefix { get; private set; }

        /// <summary>
        /// Week Start Day (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Week Start Day")]
        public string WeekStartDay { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Folder
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Folder
    {
        /// <summary>
        /// Folder ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Folder ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// Folder Unique Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Folder Unique Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Access Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Access Type")]
        public string AccessType { get; set; }

        /// <summary>
        /// Read Only (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Read Only")]
        public bool? IsReadonly { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ForecastShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ForecastShare
    {
        /// <summary>
        /// Forecast Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Forecast Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User Role ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Role ID")]
        public string UserRoleId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Forecast Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Forecast Access")]
        public string AccessLevel { get; private set; }

        /// <summary>
        /// Submit Allowed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Submit Allowed")]
        public bool? CanSubmit { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for Group
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Group
    {
        /// <summary>
        /// Group ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Group ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// Developer Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Related ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related ID")]
        public string RelatedId { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Email { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Send Email to Members (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Send Email to Members")]
        public bool? DoesSendEmailToMembers { get; set; }

        /// <summary>
        /// Include Bosses (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Include Bosses")]
        public bool? DoesIncludeBosses { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for GroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class GroupMember
    {
        /// <summary>
        /// Group Member ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Group Member ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Group ID")]
        public string GroupId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for HashtagDefinition
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class HashtagDefinition
    {
        /// <summary>
        /// Hashtag Definition ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Hashtag Definition ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Normalized Hashtag Text (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Normalized Hashtag Text")]
        public string NameNorm { get; private set; }

        /// <summary>
        /// Hashtag Text (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Hashtag Text")]
        public string Name { get; private set; }

        /// <summary>
        /// Hashtag Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Hashtag Count")]
        public string HashtagCount { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Holiday
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Holiday
    {
        /// <summary>
        /// Holiday ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Holiday ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Holiday Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Holiday Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// All Day (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "All Day")]
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// Holiday Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Holiday Date")]
        public string ActivityDate { get; set; }

        /// <summary>
        /// Start Time In Minutes From Midnight (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Time In Minutes From Midnight")]
        public string StartTimeInMinutes { get; set; }

        /// <summary>
        /// End Time In Minutes From Midnight (int type in Salesforce)
        /// </summary>
        //[Display(Name = "End Time In Minutes From Midnight")]
        public string EndTimeInMinutes { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Recurring Holiday (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurring Holiday")]
        public bool? IsRecurrence { get; set; }

        /// <summary>
        /// Start Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Date")]
        public string RecurrenceStartDate { get; set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "End Date")]
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// Recurrence Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Type")]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// Recurrence Interval (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Interval")]
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// Recurrence Day of Week Mask (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Week Mask")]
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// Recurrence Day of Month (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Month")]
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// Recurrence Instance (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Instance")]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// Recurrence Month of Year (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Month of Year")]
        public string RecurrenceMonthOfYear { get; set; }

    }

    /// <summary>
    /// POCO for Idea
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Idea
    {
        /// <summary>
        /// Idea ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Idea ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Record Type ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record Type ID")]
        public string RecordTypeId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Zone ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Zone ID")]
        public string CommunityId { get; private set; }

        /// <summary>
        /// Idea Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        //[Display(Name = "Idea Body")]
        public string Body { get; set; }

        /// <summary>
        /// Number of Comments (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Number of Comments")]
        public string NumComments { get; private set; }

        /// <summary>
        /// Vote Score (double type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Vote Score")]
        public string VoteScore { get; private set; }

        /// <summary>
        /// Vote Total (double type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Vote Total")]
        public string VoteTotal { get; private set; }

        /// <summary>
        /// Categories (multipicklist type in Salesforce)
        /// </summary>
        //[StringLength(4099)]
        public string Categories { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Last Idea Comment Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Idea Comment Date")]
        public string LastCommentDate { get; private set; }

        /// <summary>
        /// Idea Comment ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Idea Comment ID")]
        public string LastCommentId { get; private set; }

        /// <summary>
        /// Idea ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Idea ID")]
        public string ParentIdeaId { get; private set; }

        /// <summary>
        /// IsHtml (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public bool? IsHtml { get; private set; }

        /// <summary>
        /// Is Merged (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Merged")]
        public bool? IsMerged { get; private set; }

        /// <summary>
        /// Url of Creator's Profile Photo (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url of Creator's Profile Photo")]
        public string CreatorFullPhotoUrl { get; private set; }

        /// <summary>
        /// Url of Creator's Thumbnail Photo (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url of Creator's Thumbnail Photo")]
        public string CreatorSmallPhotoUrl { get; private set; }

        /// <summary>
        /// Name of Creator (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Name of Creator")]
        public string CreatorName { get; private set; }

    }

    /// <summary>
    /// POCO for IdeaComment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class IdeaComment
    {
        /// <summary>
        /// Idea Comment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Idea Comment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Idea ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Idea ID")]
        public string IdeaId { get; private set; }

        /// <summary>
        /// Zone ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Zone ID")]
        public string CommunityId { get; private set; }

        /// <summary>
        /// Comment Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Comment Body")]
        public string CommentBody { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// IsHtml (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public bool? IsHtml { get; private set; }

        /// <summary>
        /// Url of Creator's Profile Photo (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url of Creator's Profile Photo")]
        public string CreatorFullPhotoUrl { get; private set; }

        /// <summary>
        /// Url of Creator's Thumbnail Photo (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url of Creator's Thumbnail Photo")]
        public string CreatorSmallPhotoUrl { get; private set; }

        /// <summary>
        /// Name of Creator (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Name of Creator")]
        public string CreatorName { get; private set; }

        /// <summary>
        /// Up Votes (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Up Votes")]
        public string UpVotes { get; private set; }

    }

    /// <summary>
    /// POCO for Lead
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Lead
    {
        /// <summary>
        /// Lead ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Master Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Record ID")]
        public string MasterRecordId { get; private set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Salutation (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Salutation { get; set; }

        /// <summary>
        /// Full Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Full Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(128)]
        public string Title { get; set; }

        /// <summary>
        /// Company (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Company { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "State/Province")]
        public string State { get; set; }

        /// <summary>
        /// Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Zip/Postal Code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Country { get; set; }

        /// <summary>
        /// Latitude (double type in Salesforce)
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude (double type in Salesforce)
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Mobile Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Website (url type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Website { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Lead Source (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Lead Source")]
        public string LeadSource { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Industry (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Industry { get; set; }

        /// <summary>
        /// Rating (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Rating { get; set; }

        /// <summary>
        /// Annual Revenue (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Annual Revenue")]
        public string AnnualRevenue { get; set; }

        /// <summary>
        /// Employees (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Employees")]
        public string NumberOfEmployees { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Converted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted")]
        public bool? IsConverted { get; private set; }

        /// <summary>
        /// Converted Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted Date")]
        public string ConvertedDate { get; private set; }

        /// <summary>
        /// Converted Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted Account ID")]
        public string ConvertedAccountId { get; private set; }

        /// <summary>
        /// Converted Contact ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted Contact ID")]
        public string ConvertedContactId { get; private set; }

        /// <summary>
        /// Converted Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Converted Opportunity ID")]
        public string ConvertedOpportunityId { get; private set; }

        /// <summary>
        /// Unread By Owner (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Unread By Owner")]
        public bool? IsUnreadByOwner { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Data.com Key (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Data.com Key")]
        public string Jigsaw { get; set; }

        /// <summary>
        /// Jigsaw Contact ID (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Jigsaw Contact ID")]
        public string JigsawContactId { get; private set; }

        /// <summary>
        /// Email Bounced Reason (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Email Bounced Reason")]
        public string EmailBouncedReason { get; set; }

        /// <summary>
        /// Email Bounced Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Email Bounced Date")]
        public string EmailBouncedDate { get; set; }

        /// <summary>
        /// SIC Code (string type in Salesforce)
        /// </summary>
        //[StringLength(15)]
        //[Display(Name = "SIC Code")]
        public string SICCode__c { get; set; }

        /// <summary>
        /// Product Interest (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Product Interest")]
        public string ProductInterest__c { get; set; }

        /// <summary>
        /// Primary (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Primary")]
        public string Primary__c { get; set; }

        /// <summary>
        /// Current Generator(s) (string type in Salesforce)
        /// </summary>
        //[StringLength(100)]
        //[Display(Name = "Current Generator(s)")]
        public string CurrentGenerators__c { get; set; }

        /// <summary>
        /// Number of Locations (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Number of Locations")]
        public string NumberofLocations__c { get; set; }

    }

    /// <summary>
    /// POCO for LeadFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LeadFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for LeadHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LeadHistory
    {
        /// <summary>
        /// Lead History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead ID")]
        public string LeadId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for LeadShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LeadShare
    {
        /// <summary>
        /// Lead Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead ID")]
        public string LeadId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Lead Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead Access")]
        public string LeadAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for LeadStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LeadStatus
    {
        /// <summary>
        /// Lead Status Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Lead Status Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Is Converted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Converted")]
        public bool? IsConverted { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for LoginHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LoginHistory
    {
        /// <summary>
        /// Login History Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login History Id")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UserId { get; private set; }

        /// <summary>
        /// Login Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login Time")]
        public string LoginTime { get; private set; }

        /// <summary>
        /// Login Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login Type")]
        public string LoginType { get; private set; }

        /// <summary>
        /// Source IP (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Source IP")]
        public string SourceIp { get; private set; }

        /// <summary>
        /// Login URL (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login URL")]
        public string LoginUrl { get; private set; }

        /// <summary>
        /// Browser (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Browser { get; private set; }

        /// <summary>
        /// Platform (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Platform { get; private set; }

        /// <summary>
        /// Status (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Application (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Application { get; private set; }

        /// <summary>
        /// Client Version (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Client Version")]
        public string ClientVersion { get; private set; }

        /// <summary>
        /// API Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "API Type")]
        public string ApiType { get; private set; }

        /// <summary>
        /// API Version (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "API Version")]
        public string ApiVersion { get; private set; }

    }

    /// <summary>
    /// POCO for LoginIp
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class LoginIp
    {
        /// <summary>
        /// Login IP ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Login IP ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UsersId { get; private set; }

        /// <summary>
        /// Source IP (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Source IP")]
        public string SourceIp { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// IsAuthenticated (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public bool? IsAuthenticated { get; private set; }

        /// <summary>
        /// Challenge SentDate (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Challenge SentDate")]
        public string ChallengeSentDate { get; private set; }

        /// <summary>
        /// Challenge Method (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Challenge Method")]
        public string ChallengeMethod { get; private set; }

    }

    /// <summary>
    /// POCO for MailmergeTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class MailmergeTemplate
    {
        /// <summary>
        /// Mail Merge Template ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Mail Merge Template ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// File (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "File")]
        public string Filename { get; private set; }

        /// <summary>
        /// Body Length (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Body Length")]
        public string BodyLength { get; private set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Last Used Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Used Date")]
        public string LastUsedDate { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Name
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Name
    {
        /// <summary>
        /// ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Name")]
        public string Name2 { get; private set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Name")]
        public string LastName { get; private set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "First Name")]
        public string FirstName { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Alias { get; private set; }

        /// <summary>
        /// Role ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Role ID")]
        public string UserRoleId { get; private set; }

        /// <summary>
        /// Record Type ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record Type ID")]
        public string RecordTypeId { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Active")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Profile ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Profile ID")]
        public string ProfileId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// E-mail (email type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "E-mail")]
        public string Email { get; private set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Phone { get; private set; }

        /// <summary>
        /// Username (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Username { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for Note
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Note
    {
        /// <summary>
        /// Note Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Note Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// Private (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Body { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for NoteAndAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class NoteAndAttachment
    {
        /// <summary>
        /// Note or Attachment Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Note or Attachment Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Is Note (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Note")]
        public bool? IsNote { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Private (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Private")]
        public bool? IsPrivate { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ObjectPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ObjectPermissions
    {
        /// <summary>
        /// ObjectPermissions ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ObjectPermissions ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Sobject Type Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sobject Type Name")]
        public string SobjectType { get; private set; }

        /// <summary>
        /// Create Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create Records")]
        public bool? PermissionsCreate { get; set; }

        /// <summary>
        /// Read Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Read Records")]
        public bool? PermissionsRead { get; set; }

        /// <summary>
        /// Edit Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Records")]
        public bool? PermissionsEdit { get; set; }

        /// <summary>
        /// Delete Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Delete Records")]
        public bool? PermissionsDelete { get; set; }

        /// <summary>
        /// Read All Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Read All Records")]
        public bool? PermissionsViewAllRecords { get; set; }

        /// <summary>
        /// Edit All Records (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit All Records")]
        public bool? PermissionsModifyAllRecords { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for OpenActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpenActivity
    {
        /// <summary>
        /// Activity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Activity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Contact/Lead ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact/Lead ID")]
        public string WhoId { get; private set; }

        /// <summary>
        /// Opportunity/Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity/Account ID")]
        public string WhatId { get; private set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Subject { get; private set; }

        /// <summary>
        /// Task (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Task")]
        public bool? IsTask { get; private set; }

        /// <summary>
        /// Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date")]
        public string ActivityDate { get; private set; }

        /// <summary>
        /// Assigned To ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Assigned To ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Priority { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Type")]
        public string ActivityType { get; private set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// All Day Event (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "All Day Event")]
        public bool? IsAllDayEvent { get; private set; }

        /// <summary>
        /// Public (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Public")]
        public bool? IsVisibleInSelfService { get; private set; }

        /// <summary>
        /// Duration (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Duration")]
        public string DurationInMinutes { get; private set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Location { get; private set; }

        /// <summary>
        /// Comments (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comments")]
        public string Description { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Call Duration (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Duration")]
        public string CallDurationInSeconds { get; private set; }

        /// <summary>
        /// Call Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Type")]
        public string CallType { get; private set; }

        /// <summary>
        /// Call Result (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Result")]
        public string CallDisposition { get; private set; }

        /// <summary>
        /// Call Object Identifier (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Call Object Identifier")]
        public string CallObject { get; private set; }

        /// <summary>
        /// Reminder Date/Time (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reminder Date/Time")]
        public string ReminderDateTime { get; private set; }

        /// <summary>
        /// Reminder Set (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reminder Set")]
        public bool? IsReminderSet { get; private set; }

        /// <summary>
        /// End (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "End")]
        public string EndDateTime { get; private set; }

        /// <summary>
        /// Start (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start")]
        public string StartDateTime { get; private set; }

    }

    /// <summary>
    /// POCO for Opportunity
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Opportunity
    {
        /// <summary>
        /// Opportunity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Account ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// Private (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Stage (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Stage")]
        public string StageName { get; set; }

        /// <summary>
        /// Amount (currency type in Salesforce)
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Probability (%) (percent type in Salesforce)
        /// </summary>
        //[Display(Name = "Probability (%)")]
        public string Probability { get; set; }

        /// <summary>
        /// Expected Amount (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Expected Amount")]
        public string ExpectedRevenue { get; private set; }

        /// <summary>
        /// Quantity (double type in Salesforce)
        /// </summary>
        //[Display(Name = "Quantity")]
        public string TotalOpportunityQuantity { get; set; }

        /// <summary>
        /// Close Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Close Date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// Opportunity Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Opportunity Type")]
        public string Type { get; set; }

        /// <summary>
        /// Next Step (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Next Step")]
        public string NextStep { get; set; }

        /// <summary>
        /// Lead Source (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Lead Source")]
        public string LeadSource { get; set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Won (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Won")]
        public bool? IsWon { get; private set; }

        /// <summary>
        /// Forecast Category (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Forecast Category")]
        public string ForecastCategory { get; private set; }

        /// <summary>
        /// Forecast Category (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Forecast Category")]
        public string ForecastCategoryName { get; set; }

        /// <summary>
        /// Campaign ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Campaign ID")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Has Line Item (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Line Item")]
        public bool? HasOpportunityLineItem { get; private set; }

        /// <summary>
        /// Price Book ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Activity (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Activity")]
        public string LastActivityDate { get; private set; }

        /// <summary>
        /// Fiscal Quarter (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Quarter")]
        public string FiscalQuarter { get; private set; }

        /// <summary>
        /// Fiscal Year (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Year")]
        public string FiscalYear { get; private set; }

        /// <summary>
        /// Fiscal Period (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Period")]
        public string Fiscal { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Delivery/Installation Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Delivery/Installation Status")]
        public string DeliveryInstallationStatus__c { get; set; }

        /// <summary>
        /// Tracking Number (string type in Salesforce)
        /// </summary>
        //[StringLength(12)]
        //[Display(Name = "Tracking Number")]
        public string TrackingNumber__c { get; set; }

        /// <summary>
        /// Order Number (string type in Salesforce)
        /// </summary>
        //[StringLength(8)]
        //[Display(Name = "Order Number")]
        public string OrderNumber__c { get; set; }

        /// <summary>
        /// Current Generator(s) (string type in Salesforce)
        /// </summary>
        //[StringLength(100)]
        //[Display(Name = "Current Generator(s)")]
        public string CurrentGenerators__c { get; set; }

        /// <summary>
        /// Main Competitor(s) (string type in Salesforce)
        /// </summary>
        //[StringLength(100)]
        //[Display(Name = "Main Competitor(s)")]
        public string MainCompetitors__c { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityCompetitor
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityCompetitor
    {
        /// <summary>
        /// Opportunity: Competitor ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity: Competitor ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Competitor Name (combobox type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Competitor Name")]
        public string CompetitorName { get; set; }

        /// <summary>
        /// Strengths (string type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Strengths { get; set; }

        /// <summary>
        /// Weaknesses (string type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Weaknesses { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityContactRole
    {
        /// <summary>
        /// Contact Role ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Role ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityFieldHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityFieldHistory
    {
        /// <summary>
        /// Opportunity History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityHistory
    {
        /// <summary>
        /// Opportunity History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Stage Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Stage Name")]
        public string StageName { get; private set; }

        /// <summary>
        /// Amount (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Amount { get; private set; }

        /// <summary>
        /// Expected Revenue (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Expected Revenue")]
        public string ExpectedRevenue { get; private set; }

        /// <summary>
        /// Close Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Close Date")]
        public string CloseDate { get; private set; }

        /// <summary>
        /// Probability (percent type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Probability { get; private set; }

        /// <summary>
        /// To ForecastCategory (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "To ForecastCategory")]
        public string ForecastCategory { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityLineItem
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityLineItem
    {
        /// <summary>
        /// Line Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Line Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Price Book Entry ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book Entry ID")]
        public string PricebookEntryId { get; private set; }

        /// <summary>
        /// Quantity (double type in Salesforce)
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Total Price (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Total Price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// Sales Price (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "Sales Price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// List Price (currency type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "List Price")]
        public string ListPrice { get; private set; }

        /// <summary>
        /// Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Date")]
        public string ServiceDate { get; set; }

        /// <summary>
        /// Line Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Line Description")]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityPartner
    {
        /// <summary>
        /// Opportunity Partner ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity Partner ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountToId { get; private set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Role { get; private set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Reverse Partner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reverse Partner ID")]
        public string ReversePartnerId { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityShare
    {
        /// <summary>
        /// Opportunity Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// Opportunity Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity Access")]
        public string OpportunityAccessLevel { get; private set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for OpportunityStage
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OpportunityStage
    {
        /// <summary>
        /// Opportunity Stage ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity Stage ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Is Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Active")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Won (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Won")]
        public bool? IsWon { get; private set; }

        /// <summary>
        /// Forecast Category (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Forecast Category")]
        public string ForecastCategory { get; private set; }

        /// <summary>
        /// Forecast Category Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Forecast Category Name")]
        public string ForecastCategoryName { get; private set; }

        /// <summary>
        /// Probability (%) (percent type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Probability (%)")]
        public string DefaultProbability { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for OrgWideEmailAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class OrgWideEmailAddress
    {
        /// <summary>
        /// Organization-wide From Email Address ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Organization-wide From Email Address ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Email Address (email type in Salesforce)
        /// </summary>
        //[StringLength(270)]
        //[Display(Name = "Email Address")]
        public string Address { get; set; }

        /// <summary>
        /// Display Name (string type in Salesforce)
        /// </summary>
        //[StringLength(300)]
        //[Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Allow All Profiles (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Allow All Profiles")]
        public bool? IsAllowAllProfiles { get; set; }

    }

    /// <summary>
    /// POCO for Organization
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Organization
    {
        /// <summary>
        /// Organization ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Organization ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Division (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Division { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "State/Province")]
        public string State { get; set; }

        /// <summary>
        /// Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Zip/Postal Code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Country { get; private set; }

        /// <summary>
        /// Latitude (double type in Salesforce)
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude (double type in Salesforce)
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// Primary Contact (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Primary Contact")]
        public string PrimaryContact { get; set; }

        /// <summary>
        /// Locale (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Locale")]
        public string DefaultLocaleSidKey { get; set; }

        /// <summary>
        /// Language (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Language")]
        public string LanguageLocaleKey { get; set; }

        /// <summary>
        /// Info Emails (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Info Emails")]
        public bool? ReceivesInfoEmails { get; set; }

        /// <summary>
        /// Info Emails Admin (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Info Emails Admin")]
        public bool? ReceivesAdminInfoEmails { get; set; }

        /// <summary>
        /// RequireOpportunityProducts (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "RequireOpportunityProducts")]
        public bool? PreferencesRequireOpportunityProducts { get; set; }

        /// <summary>
        /// S1BrowserEnabled (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "S1BrowserEnabled")]
        public bool? PreferencesS1BrowserEnabled { get; set; }

        /// <summary>
        /// Fiscal Year Starts In (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Year Starts In")]
        public string FiscalYearStartMonth { get; private set; }

        /// <summary>
        /// Fiscal Year Name by Start (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Year Name by Start")]
        public bool? UsesStartDateAsFiscalYearName { get; private set; }

        /// <summary>
        /// Default Account Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Account Access")]
        public string DefaultAccountAccess { get; private set; }

        /// <summary>
        /// Default Contact Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Contact Access")]
        public string DefaultContactAccess { get; private set; }

        /// <summary>
        /// Default Opportunity Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Opportunity Access")]
        public string DefaultOpportunityAccess { get; private set; }

        /// <summary>
        /// Default Lead Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Lead Access")]
        public string DefaultLeadAccess { get; private set; }

        /// <summary>
        /// Default Case Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Case Access")]
        public string DefaultCaseAccess { get; private set; }

        /// <summary>
        /// Default Calendar Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Calendar Access")]
        public string DefaultCalendarAccess { get; private set; }

        /// <summary>
        /// Default Price Book Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Price Book Access")]
        public string DefaultPricebookAccess { get; private set; }

        /// <summary>
        /// Default Campaign Access (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Campaign Access")]
        public string DefaultCampaignAccess { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Compliance BCC Email (email type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Compliance BCC Email")]
        public string ComplianceBccEmail { get; private set; }

        /// <summary>
        /// UI Skin (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "UI Skin")]
        public string UiSkin { get; set; }

        /// <summary>
        /// Trial Expiration Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Trial Expiration Date")]
        public string TrialExpirationDate { get; private set; }

        /// <summary>
        /// Edition (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edition")]
        public string OrganizationType { get; private set; }

        /// <summary>
        /// Web to Cases Default Origin (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Web to Cases Default Origin")]
        public string WebToCaseDefaultOrigin { get; set; }

        /// <summary>
        /// Monthly Page Views Used (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Monthly Page Views Used")]
        public string MonthlyPageViewsUsed { get; private set; }

        /// <summary>
        /// Monthly Page Views Allowed (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Monthly Page Views Allowed")]
        public string MonthlyPageViewsEntitlement { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for Partner
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Partner
    {
        /// <summary>
        /// Partner ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Partner ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Opportunity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Opportunity ID")]
        public string OpportunityId { get; private set; }

        /// <summary>
        /// Account From ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account From ID")]
        public string AccountFromId { get; private set; }

        /// <summary>
        /// Account To ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account To ID")]
        public string AccountToId { get; private set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Role { get; private set; }

        /// <summary>
        /// Primary (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Primary")]
        public bool? IsPrimary { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Reverse Partner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reverse Partner ID")]
        public string ReversePartnerId { get; private set; }

    }

    /// <summary>
    /// POCO for PartnerRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PartnerRole
    {
        /// <summary>
        /// Partner Role Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Partner Role Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Reverse Role (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reverse Role")]
        public string ReverseRole { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Period
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Period
    {
        /// <summary>
        /// Period ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Period ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Fiscal Year Settings ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Fiscal Year Settings ID")]
        public string FiscalYearSettingsId { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

        /// <summary>
        /// Start Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Start Date")]
        public string StartDate { get; private set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "End Date")]
        public string EndDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Is Forecast Period (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Forecast Period")]
        public bool? IsForecastPeriod { get; private set; }

        /// <summary>
        /// Quarter Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Quarter Name")]
        public string QuarterLabel { get; private set; }

        /// <summary>
        /// Period Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Period Name")]
        public string PeriodLabel { get; private set; }

        /// <summary>
        /// Number (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Number { get; private set; }

    }

    /// <summary>
    /// POCO for PermissionSet
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PermissionSet
    {
        /// <summary>
        /// PermissionSet ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "PermissionSet ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Permission Set Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Permission Set Name")]
        public string Name { get; set; }

        /// <summary>
        /// Permission Set Label (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Permission Set Label")]
        public string Label { get; set; }

        /// <summary>
        /// User License ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User License ID")]
        public string UserLicenseId { get; private set; }

        /// <summary>
        /// Profile ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Profile ID")]
        public string ProfileId { get; private set; }

        /// <summary>
        /// Is Owned By Profile (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Owned By Profile")]
        public bool? IsOwnedByProfile { get; private set; }

        /// <summary>
        /// Edit Tasks (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Tasks")]
        public bool? PermissionsEditTask { get; set; }

        /// <summary>
        /// Edit Events (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Events")]
        public bool? PermissionsEditEvent { get; set; }

        /// <summary>
        /// Manage Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Users")]
        public bool? PermissionsManageUsers { get; set; }

        /// <summary>
        /// Modify All Data (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Modify All Data")]
        public bool? PermissionsModifyAllData { get; set; }

        /// <summary>
        /// Manage Cases (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Cases")]
        public bool? PermissionsManageCases { get; set; }

        /// <summary>
        /// Mass Edits from Lists (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Mass Edits from Lists")]
        public bool? PermissionsMassInlineEdit { get; set; }

        /// <summary>
        /// Manage Articles (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Articles")]
        public bool? PermissionsEditKnowledge { get; set; }

        /// <summary>
        /// Manage Salesforce Knowledge (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Salesforce Knowledge")]
        public bool? PermissionsManageKnowledge { get; set; }

        /// <summary>
        /// Manage Published Solutions (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Published Solutions")]
        public bool? PermissionsManageSolutions { get; set; }

        /// <summary>
        /// Customize Application (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Customize Application")]
        public bool? PermissionsCustomizeApplication { get; set; }

        /// <summary>
        /// Edit Read Only Fields (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Read Only Fields")]
        public bool? PermissionsEditReadonlyFields { get; set; }

        /// <summary>
        /// Run Reports (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Run Reports")]
        public bool? PermissionsRunReports { get; set; }

        /// <summary>
        /// View Setup and Configuration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View Setup and Configuration")]
        public bool? PermissionsViewSetup { get; set; }

        /// <summary>
        /// Transfer Record (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Record")]
        public bool? PermissionsTransferAnyEntity { get; set; }

        /// <summary>
        /// Report Builder (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Report Builder")]
        public bool? PermissionsNewReportBuilder { get; set; }

        /// <summary>
        /// Import Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Import Leads")]
        public bool? PermissionsImportLeads { get; set; }

        /// <summary>
        /// Manage Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Leads")]
        public bool? PermissionsManageLeads { get; set; }

        /// <summary>
        /// Transfer Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Leads")]
        public bool? PermissionsTransferAnyLead { get; set; }

        /// <summary>
        /// View All Data (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View All Data")]
        public bool? PermissionsViewAllData { get; set; }

        /// <summary>
        /// Manage Public Documents (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Public Documents")]
        public bool? PermissionsEditPublicDocuments { get; set; }

        /// <summary>
        /// Send Stay-in-Touch Requests (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Send Stay-in-Touch Requests")]
        public bool? PermissionsSendSitRequests { get; set; }

        /// <summary>
        /// Manage Connected Apps (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Connected Apps")]
        public bool? PermissionsManageRemoteAccess { get; set; }

        /// <summary>
        /// Drag-and-Drop Dashboard Builder (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Drag-and-Drop Dashboard Builder")]
        public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

        /// <summary>
        /// Manage Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Categories")]
        public bool? PermissionsManageCategories { get; set; }

        /// <summary>
        /// Convert Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Convert Leads")]
        public bool? PermissionsConvertLeads { get; set; }

        /// <summary>
        /// Password Never Expires (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Password Never Expires")]
        public bool? PermissionsPasswordNeverExpires { get; set; }

        /// <summary>
        /// Use Team Reassignment Wizards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Team Reassignment Wizards")]
        public bool? PermissionsUseTeamReassignWizards { get; set; }

        /// <summary>
        /// Download AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Download AppExchange Packages")]
        public bool? PermissionsInstallPackaging { get; set; }

        /// <summary>
        /// Upload AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Upload AppExchange Packages")]
        public bool? PermissionsPublishPackaging { get; set; }

        /// <summary>
        /// Edit Opportunity Product Sales Price (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Opportunity Product Sales Price")]
        public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

        /// <summary>
        /// Create AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create AppExchange Packages")]
        public bool? PermissionsCreatePackaging { get; set; }

        /// <summary>
        /// Bulk API Hard Delete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Bulk API Hard Delete")]
        public bool? PermissionsBulkApiHardDelete { get; set; }

        /// <summary>
        /// Import Solutions (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Import Solutions")]
        public bool? PermissionsSolutionImport { get; set; }

        /// <summary>
        /// Manage Call Centers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Call Centers")]
        public bool? PermissionsManageCallCenters { get; set; }

        /// <summary>
        /// Manage Synonyms (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Synonyms")]
        public bool? PermissionsManageSynonyms { get; set; }

        /// <summary>
        /// Manage Email Client Configurations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Email Client Configurations")]
        public bool? PermissionsManageEmailClientConfig { get; set; }

        /// <summary>
        /// Send Outbound Messages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Send Outbound Messages")]
        public bool? PermissionsEnableNotifications { get; set; }

        /// <summary>
        /// Manage Data Integrations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Data Integrations")]
        public bool? PermissionsManageDataIntegrations { get; set; }

        /// <summary>
        /// Deliver Uploaded Files and Personal Content (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Deliver Uploaded Files and Personal Content")]
        public bool? PermissionsDistributeFromPersWksp { get; set; }

        /// <summary>
        /// View Data Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View Data Categories")]
        public bool? PermissionsViewDataCategories { get; set; }

        /// <summary>
        /// Manage Data Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Data Categories")]
        public bool? PermissionsManageDataCategories { get; set; }

        /// <summary>
        /// Author Apex (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Author Apex")]
        public bool? PermissionsAuthorApex { get; set; }

        /// <summary>
        /// Manage Mobile Configurations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Mobile Configurations")]
        public bool? PermissionsManageMobile { get; set; }

        /// <summary>
        /// API Enabled (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "API Enabled")]
        public bool? PermissionsApiEnabled { get; set; }

        /// <summary>
        /// Manage Custom Report Types (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Custom Report Types")]
        public bool? PermissionsManageCustomReportTypes { get; set; }

        /// <summary>
        /// Edit Case Comments (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Case Comments")]
        public bool? PermissionsEditCaseComments { get; set; }

        /// <summary>
        /// Transfer Cases (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Cases")]
        public bool? PermissionsTransferAnyCase { get; set; }

        /// <summary>
        /// Manage Analytic Snapshots (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Analytic Snapshots")]
        public bool? PermissionsManageAnalyticSnapshots { get; set; }

        /// <summary>
        /// Schedule Reports (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Schedule Reports")]
        public bool? PermissionsScheduleReports { get; set; }

        /// <summary>
        /// Manage Business Hours Holidays (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Business Hours Holidays")]
        public bool? PermissionsManageBusinessHourHolidays { get; set; }

        /// <summary>
        /// Manage Dynamic Dashboards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Dynamic Dashboards")]
        public bool? PermissionsManageDynamicDashboards { get; set; }

        /// <summary>
        /// Show Custom Sidebar On All Pages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Custom Sidebar On All Pages")]
        public bool? PermissionsCustomSidebarOnAllPages { get; set; }

        /// <summary>
        /// Manage Force.com Flow (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Force.com Flow")]
        public bool? PermissionsManageInteraction { get; set; }

        /// <summary>
        /// View My Team's Dashboards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View My Team's Dashboards")]
        public bool? PermissionsViewMyTeamsDashboards { get; set; }

        /// <summary>
        /// Reset User Passwords and Unlock Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Reset User Passwords and Unlock Users")]
        public bool? PermissionsResetPasswords { get; set; }

        /// <summary>
        /// Require Force.com Flow User Feature License (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Require Force.com Flow User Feature License")]
        public bool? PermissionsFlowUFLRequired { get; set; }

        /// <summary>
        /// Insert System Field Values for Chatter Feeds (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Insert System Field Values for Chatter Feeds")]
        public bool? PermissionsCanInsertFeedSystemFields { get; set; }

        /// <summary>
        /// Manage Knowledge Article Import/Export (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Knowledge Article Import/Export")]
        public bool? PermissionsManageKnowledgeImportExport { get; set; }

        /// <summary>
        /// Manage Email Templates (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Email Templates")]
        public bool? PermissionsEmailTemplateManagement { get; set; }

        /// <summary>
        /// Email Administration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Email Administration")]
        public bool? PermissionsEmailAdministration { get; set; }

        /// <summary>
        /// Manage Chatter Messages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Chatter Messages")]
        public bool? PermissionsManageChatterMessages { get; set; }

        /// <summary>
        /// Create and Share Links to Chatter Files (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create and Share Links to Chatter Files")]
        public bool? PermissionsChatterFileLink { get; set; }

        /// <summary>
        /// Use Case Feed (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Case Feed")]
        public bool? PermissionsViewCaseInteraction { get; set; }

        /// <summary>
        /// Manage Auth. Providers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Auth. Providers")]
        public bool? PermissionsManageAuthProviders { get; set; }

        /// <summary>
        /// Run Flows (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Run Flows")]
        public bool? PermissionsRunFlow { get; set; }

        /// <summary>
        /// View All Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View All Users")]
        public bool? PermissionsViewAllUsers { get; set; }

        /// <summary>
        /// Knowledge One (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Knowledge One")]
        public bool? PermissionsAllowUniversalSearch { get; set; }

        /// <summary>
        /// Connect Organization to Environment Hub (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Connect Organization to Environment Hub")]
        public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

        /// <summary>
        /// Enable Work.com Calibration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Enable Work.com Calibration")]
        public bool? PermissionsWorkCalibrationUser { get; set; }

        /// <summary>
        /// Enable Work.com (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Enable Work.com")]
        public bool? PermissionsWorkDotComUserPerm { get; set; }

        /// <summary>
        /// Sales Console (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Sales Console")]
        public bool? PermissionsSalesConsole { get; set; }

        /// <summary>
        /// Use Identity Connect (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Identity Connect")]
        public bool? PermissionsIdentityConnect { get; set; }

        /// <summary>
        /// Allow View Knowledge (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Allow View Knowledge")]
        public bool? PermissionsAllowViewKnowledge { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

    }

    /// <summary>
    /// POCO for PermissionSetAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PermissionSetAssignment
    {
        /// <summary>
        /// PermissionSetAssignment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "PermissionSetAssignment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// PermissionSet ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "PermissionSet ID")]
        public string PermissionSetId { get; private set; }

        /// <summary>
        /// Assignee ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Assignee ID")]
        public string AssigneeId { get; private set; }

        /// <summary>
        /// Date Assigned (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date Assigned")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for PermissionSetLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PermissionSetLicense
    {
        /// <summary>
        /// Permission Set License ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Permission Set License ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Developer Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Developer Name")]
        public string DeveloperName { get; private set; }

        /// <summary>
        /// Master Language (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Language")]
        public string Language { get; private set; }

        /// <summary>
        /// Permission Set License Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Permission Set License Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Permission Set License Key (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Permission Set License Key")]
        public string PermissionSetLicenseKey { get; private set; }

        /// <summary>
        /// Total Licenses (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Total Licenses")]
        public string TotalLicenses { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Expiration Date (date type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Expiration Date")]
        public string ExpirationDate { get; private set; }

        /// <summary>
        /// Edit Tasks (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edit Tasks")]
        public bool? MaximumPermissionsEditTask { get; private set; }

        /// <summary>
        /// Edit Events (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edit Events")]
        public bool? MaximumPermissionsEditEvent { get; private set; }

        /// <summary>
        /// Manage Users (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Users")]
        public bool? MaximumPermissionsManageUsers { get; private set; }

        /// <summary>
        /// Modify All Data (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Modify All Data")]
        public bool? MaximumPermissionsModifyAllData { get; private set; }

        /// <summary>
        /// Manage Cases (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Cases")]
        public bool? MaximumPermissionsManageCases { get; private set; }

        /// <summary>
        /// Mass Edits from Lists (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Mass Edits from Lists")]
        public bool? MaximumPermissionsMassInlineEdit { get; private set; }

        /// <summary>
        /// Manage Articles (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Articles")]
        public bool? MaximumPermissionsEditKnowledge { get; private set; }

        /// <summary>
        /// Manage Salesforce Knowledge (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Salesforce Knowledge")]
        public bool? MaximumPermissionsManageKnowledge { get; private set; }

        /// <summary>
        /// Manage Published Solutions (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Published Solutions")]
        public bool? MaximumPermissionsManageSolutions { get; private set; }

        /// <summary>
        /// Customize Application (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Customize Application")]
        public bool? MaximumPermissionsCustomizeApplication { get; private set; }

        /// <summary>
        /// Edit Read Only Fields (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edit Read Only Fields")]
        public bool? MaximumPermissionsEditReadonlyFields { get; private set; }

        /// <summary>
        /// Run Reports (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Run Reports")]
        public bool? MaximumPermissionsRunReports { get; private set; }

        /// <summary>
        /// View Setup and Configuration (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "View Setup and Configuration")]
        public bool? MaximumPermissionsViewSetup { get; private set; }

        /// <summary>
        /// Transfer Record (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Transfer Record")]
        public bool? MaximumPermissionsTransferAnyEntity { get; private set; }

        /// <summary>
        /// Report Builder (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Report Builder")]
        public bool? MaximumPermissionsNewReportBuilder { get; private set; }

        /// <summary>
        /// Import Leads (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Import Leads")]
        public bool? MaximumPermissionsImportLeads { get; private set; }

        /// <summary>
        /// Manage Leads (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Leads")]
        public bool? MaximumPermissionsManageLeads { get; private set; }

        /// <summary>
        /// Transfer Leads (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Transfer Leads")]
        public bool? MaximumPermissionsTransferAnyLead { get; private set; }

        /// <summary>
        /// View All Data (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "View All Data")]
        public bool? MaximumPermissionsViewAllData { get; private set; }

        /// <summary>
        /// Manage Public Documents (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Public Documents")]
        public bool? MaximumPermissionsEditPublicDocuments { get; private set; }

        /// <summary>
        /// Send Stay-in-Touch Requests (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Send Stay-in-Touch Requests")]
        public bool? MaximumPermissionsSendSitRequests { get; private set; }

        /// <summary>
        /// Manage Connected Apps (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Connected Apps")]
        public bool? MaximumPermissionsManageRemoteAccess { get; private set; }

        /// <summary>
        /// Drag-and-Drop Dashboard Builder (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Drag-and-Drop Dashboard Builder")]
        public bool? MaximumPermissionsCanUseNewDashboardBuilder { get; private set; }

        /// <summary>
        /// Manage Categories (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Categories")]
        public bool? MaximumPermissionsManageCategories { get; private set; }

        /// <summary>
        /// Convert Leads (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Convert Leads")]
        public bool? MaximumPermissionsConvertLeads { get; private set; }

        /// <summary>
        /// Password Never Expires (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Password Never Expires")]
        public bool? MaximumPermissionsPasswordNeverExpires { get; private set; }

        /// <summary>
        /// Use Team Reassignment Wizards (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Use Team Reassignment Wizards")]
        public bool? MaximumPermissionsUseTeamReassignWizards { get; private set; }

        /// <summary>
        /// Download AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Download AppExchange Packages")]
        public bool? MaximumPermissionsInstallPackaging { get; private set; }

        /// <summary>
        /// Upload AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Upload AppExchange Packages")]
        public bool? MaximumPermissionsPublishPackaging { get; private set; }

        /// <summary>
        /// Edit Opportunity Product Sales Price (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edit Opportunity Product Sales Price")]
        public bool? MaximumPermissionsEditOppLineItemUnitPrice { get; private set; }

        /// <summary>
        /// Create AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Create AppExchange Packages")]
        public bool? MaximumPermissionsCreatePackaging { get; private set; }

        /// <summary>
        /// Bulk API Hard Delete (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Bulk API Hard Delete")]
        public bool? MaximumPermissionsBulkApiHardDelete { get; private set; }

        /// <summary>
        /// Import Solutions (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Import Solutions")]
        public bool? MaximumPermissionsSolutionImport { get; private set; }

        /// <summary>
        /// Manage Call Centers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Call Centers")]
        public bool? MaximumPermissionsManageCallCenters { get; private set; }

        /// <summary>
        /// Manage Synonyms (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Synonyms")]
        public bool? MaximumPermissionsManageSynonyms { get; private set; }

        /// <summary>
        /// Manage Email Client Configurations (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Email Client Configurations")]
        public bool? MaximumPermissionsManageEmailClientConfig { get; private set; }

        /// <summary>
        /// Send Outbound Messages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Send Outbound Messages")]
        public bool? MaximumPermissionsEnableNotifications { get; private set; }

        /// <summary>
        /// Manage Data Integrations (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Data Integrations")]
        public bool? MaximumPermissionsManageDataIntegrations { get; private set; }

        /// <summary>
        /// Deliver Uploaded Files and Personal Content (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deliver Uploaded Files and Personal Content")]
        public bool? MaximumPermissionsDistributeFromPersWksp { get; private set; }

        /// <summary>
        /// View Data Categories (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "View Data Categories")]
        public bool? MaximumPermissionsViewDataCategories { get; private set; }

        /// <summary>
        /// Manage Data Categories (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Data Categories")]
        public bool? MaximumPermissionsManageDataCategories { get; private set; }

        /// <summary>
        /// Author Apex (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Author Apex")]
        public bool? MaximumPermissionsAuthorApex { get; private set; }

        /// <summary>
        /// Manage Mobile Configurations (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Mobile Configurations")]
        public bool? MaximumPermissionsManageMobile { get; private set; }

        /// <summary>
        /// API Enabled (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "API Enabled")]
        public bool? MaximumPermissionsApiEnabled { get; private set; }

        /// <summary>
        /// Manage Custom Report Types (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Custom Report Types")]
        public bool? MaximumPermissionsManageCustomReportTypes { get; private set; }

        /// <summary>
        /// Edit Case Comments (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Edit Case Comments")]
        public bool? MaximumPermissionsEditCaseComments { get; private set; }

        /// <summary>
        /// Transfer Cases (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Transfer Cases")]
        public bool? MaximumPermissionsTransferAnyCase { get; private set; }

        /// <summary>
        /// Manage Analytic Snapshots (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Analytic Snapshots")]
        public bool? MaximumPermissionsManageAnalyticSnapshots { get; private set; }

        /// <summary>
        /// Schedule Reports (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Schedule Reports")]
        public bool? MaximumPermissionsScheduleReports { get; private set; }

        /// <summary>
        /// Manage Business Hours Holidays (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Business Hours Holidays")]
        public bool? MaximumPermissionsManageBusinessHourHolidays { get; private set; }

        /// <summary>
        /// Manage Dynamic Dashboards (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Dynamic Dashboards")]
        public bool? MaximumPermissionsManageDynamicDashboards { get; private set; }

        /// <summary>
        /// Show Custom Sidebar On All Pages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Show Custom Sidebar On All Pages")]
        public bool? MaximumPermissionsCustomSidebarOnAllPages { get; private set; }

        /// <summary>
        /// Manage Force.com Flow (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Force.com Flow")]
        public bool? MaximumPermissionsManageInteraction { get; private set; }

        /// <summary>
        /// View My Team's Dashboards (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "View My Team's Dashboards")]
        public bool? MaximumPermissionsViewMyTeamsDashboards { get; private set; }

        /// <summary>
        /// Reset User Passwords and Unlock Users (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reset User Passwords and Unlock Users")]
        public bool? MaximumPermissionsResetPasswords { get; private set; }

        /// <summary>
        /// Require Force.com Flow User Feature License (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Require Force.com Flow User Feature License")]
        public bool? MaximumPermissionsFlowUFLRequired { get; private set; }

        /// <summary>
        /// Insert System Field Values for Chatter Feeds (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Insert System Field Values for Chatter Feeds")]
        public bool? MaximumPermissionsCanInsertFeedSystemFields { get; private set; }

        /// <summary>
        /// Manage Knowledge Article Import/Export (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Knowledge Article Import/Export")]
        public bool? MaximumPermissionsManageKnowledgeImportExport { get; private set; }

        /// <summary>
        /// Manage Email Templates (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Email Templates")]
        public bool? MaximumPermissionsEmailTemplateManagement { get; private set; }

        /// <summary>
        /// Email Administration (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Email Administration")]
        public bool? MaximumPermissionsEmailAdministration { get; private set; }

        /// <summary>
        /// Manage Chatter Messages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Chatter Messages")]
        public bool? MaximumPermissionsManageChatterMessages { get; private set; }

        /// <summary>
        /// Create and Share Links to Chatter Files (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Create and Share Links to Chatter Files")]
        public bool? MaximumPermissionsChatterFileLink { get; private set; }

        /// <summary>
        /// Use Case Feed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Use Case Feed")]
        public bool? MaximumPermissionsViewCaseInteraction { get; private set; }

        /// <summary>
        /// Manage Auth. Providers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Manage Auth. Providers")]
        public bool? MaximumPermissionsManageAuthProviders { get; private set; }

        /// <summary>
        /// Run Flows (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Run Flows")]
        public bool? MaximumPermissionsRunFlow { get; private set; }

        /// <summary>
        /// View All Users (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "View All Users")]
        public bool? MaximumPermissionsViewAllUsers { get; private set; }

        /// <summary>
        /// Knowledge One (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Knowledge One")]
        public bool? MaximumPermissionsAllowUniversalSearch { get; private set; }

        /// <summary>
        /// Connect Organization to Environment Hub (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Connect Organization to Environment Hub")]
        public bool? MaximumPermissionsConnectOrgToEnvironmentHub { get; private set; }

        /// <summary>
        /// Enable Work.com Calibration (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Work.com Calibration")]
        public bool? MaximumPermissionsWorkCalibrationUser { get; private set; }

        /// <summary>
        /// Enable Work.com (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Work.com")]
        public bool? MaximumPermissionsWorkDotComUserPerm { get; private set; }

        /// <summary>
        /// Sales Console (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sales Console")]
        public bool? MaximumPermissionsSalesConsole { get; private set; }

        /// <summary>
        /// Use Identity Connect (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Use Identity Connect")]
        public bool? MaximumPermissionsIdentityConnect { get; private set; }

        /// <summary>
        /// Allow View Knowledge (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Allow View Knowledge")]
        public bool? MaximumPermissionsAllowViewKnowledge { get; private set; }

        /// <summary>
        /// Used Licenses (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Used Licenses")]
        public string UsedLicenses { get; private set; }

    }

    /// <summary>
    /// POCO for PermissionSetLicenseAssign
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PermissionSetLicenseAssign
    {
        /// <summary>
        /// Permission Set License Assignment ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Permission Set License Assignment ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Date Assigned (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Date Assigned")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Permission Set License ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Permission Set License ID")]
        public string PermissionSetLicenseId { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string AssigneeId { get; private set; }

    }

    /// <summary>
    /// POCO for Pricebook2
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Pricebook2
    {
        /// <summary>
        /// Price Book ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Price Book Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Price Book Name")]
        public string Name { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Is Standard Price Book (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Standard Price Book")]
        public bool? IsStandard { get; private set; }

    }

    /// <summary>
    /// POCO for Pricebook2History
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Pricebook2History
    {
        /// <summary>
        /// Price Book History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Price Book ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for PricebookEntry
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PricebookEntry
    {
        /// <summary>
        /// Price Book Entry ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book Entry ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Product Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Product Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Price Book ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Price Book ID")]
        public string Pricebook2Id { get; private set; }

        /// <summary>
        /// Product ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Product ID")]
        public string Product2Id { get; private set; }

        /// <summary>
        /// List Price (currency type in Salesforce)
        /// </summary>
        //[Display(Name = "List Price")]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Use Standard Price (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Standard Price")]
        public bool? UseStandardPrice { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Product Code (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Product Code")]
        public string ProductCode { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for ProcessInstance
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ProcessInstance
    {
        /// <summary>
        /// Process Instance ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Target Object ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Target Object ID")]
        public string TargetObjectId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Status { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ProcessInstanceHistory
    {
        /// <summary>
        /// Process Instance History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Is Pending (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Pending")]
        public bool? IsPending { get; private set; }

        /// <summary>
        /// Process Instance ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance ID")]
        public string ProcessInstanceId { get; private set; }

        /// <summary>
        /// Target Object ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Target Object ID")]
        public string TargetObjectId { get; private set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Status")]
        public string StepStatus { get; private set; }

        /// <summary>
        /// Original Actor ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Original Actor ID")]
        public string OriginalActorId { get; private set; }

        /// <summary>
        /// Actor ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Actor ID")]
        public string ActorId { get; private set; }

        /// <summary>
        /// RemindersSent (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string RemindersSent { get; private set; }

        /// <summary>
        /// Comments (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Comments { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceStep
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ProcessInstanceStep
    {
        /// <summary>
        /// Process Instance Step ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance Step ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Process Instance ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance ID")]
        public string ProcessInstanceId { get; private set; }

        /// <summary>
        /// Step Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Step Status")]
        public string StepStatus { get; private set; }

        /// <summary>
        /// Original Actor ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Original Actor ID")]
        public string OriginalActorId { get; private set; }

        /// <summary>
        /// Actor ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Actor ID")]
        public string ActorId { get; private set; }

        /// <summary>
        /// Comments (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Comments { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceWorkitem
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ProcessInstanceWorkitem
    {
        /// <summary>
        /// Process Instance Workitem ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Process Instance Workitem ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Process Instance ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Process Instance ID")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Original Actor ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Original Actor ID")]
        public string OriginalActorId { get; set; }

        /// <summary>
        /// Actor ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Actor ID")]
        public string ActorId { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Product2
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Product2
    {
        /// <summary>
        /// Product ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Product ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Product Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Product Name")]
        public string Name { get; set; }

        /// <summary>
        /// Product Code (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Product Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(4000)]
        //[Display(Name = "Product Description")]
        public string Description { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Product Family (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Product Family")]
        public string Family { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

    }

    /// <summary>
    /// POCO for Product2Feed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Product2Feed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for Profile
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Profile
    {
        /// <summary>
        /// Profile ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Profile ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Edit Tasks (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Tasks")]
        public bool? PermissionsEditTask { get; set; }

        /// <summary>
        /// Edit Events (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Events")]
        public bool? PermissionsEditEvent { get; set; }

        /// <summary>
        /// Manage Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Users")]
        public bool? PermissionsManageUsers { get; set; }

        /// <summary>
        /// Modify All Data (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Modify All Data")]
        public bool? PermissionsModifyAllData { get; set; }

        /// <summary>
        /// Manage Cases (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Cases")]
        public bool? PermissionsManageCases { get; set; }

        /// <summary>
        /// Mass Edits from Lists (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Mass Edits from Lists")]
        public bool? PermissionsMassInlineEdit { get; set; }

        /// <summary>
        /// Manage Articles (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Articles")]
        public bool? PermissionsEditKnowledge { get; set; }

        /// <summary>
        /// Manage Salesforce Knowledge (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Salesforce Knowledge")]
        public bool? PermissionsManageKnowledge { get; set; }

        /// <summary>
        /// Manage Published Solutions (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Published Solutions")]
        public bool? PermissionsManageSolutions { get; set; }

        /// <summary>
        /// Customize Application (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Customize Application")]
        public bool? PermissionsCustomizeApplication { get; set; }

        /// <summary>
        /// Edit Read Only Fields (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Read Only Fields")]
        public bool? PermissionsEditReadonlyFields { get; set; }

        /// <summary>
        /// Run Reports (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Run Reports")]
        public bool? PermissionsRunReports { get; set; }

        /// <summary>
        /// View Setup and Configuration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View Setup and Configuration")]
        public bool? PermissionsViewSetup { get; set; }

        /// <summary>
        /// Transfer Record (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Record")]
        public bool? PermissionsTransferAnyEntity { get; set; }

        /// <summary>
        /// Report Builder (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Report Builder")]
        public bool? PermissionsNewReportBuilder { get; set; }

        /// <summary>
        /// Import Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Import Leads")]
        public bool? PermissionsImportLeads { get; set; }

        /// <summary>
        /// Manage Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Leads")]
        public bool? PermissionsManageLeads { get; set; }

        /// <summary>
        /// Transfer Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Leads")]
        public bool? PermissionsTransferAnyLead { get; set; }

        /// <summary>
        /// View All Data (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View All Data")]
        public bool? PermissionsViewAllData { get; set; }

        /// <summary>
        /// Manage Public Documents (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Public Documents")]
        public bool? PermissionsEditPublicDocuments { get; set; }

        /// <summary>
        /// Send Stay-in-Touch Requests (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Send Stay-in-Touch Requests")]
        public bool? PermissionsSendSitRequests { get; set; }

        /// <summary>
        /// Manage Connected Apps (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Connected Apps")]
        public bool? PermissionsManageRemoteAccess { get; set; }

        /// <summary>
        /// Drag-and-Drop Dashboard Builder (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Drag-and-Drop Dashboard Builder")]
        public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

        /// <summary>
        /// Manage Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Categories")]
        public bool? PermissionsManageCategories { get; set; }

        /// <summary>
        /// Convert Leads (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Convert Leads")]
        public bool? PermissionsConvertLeads { get; set; }

        /// <summary>
        /// Password Never Expires (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Password Never Expires")]
        public bool? PermissionsPasswordNeverExpires { get; set; }

        /// <summary>
        /// Use Team Reassignment Wizards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Team Reassignment Wizards")]
        public bool? PermissionsUseTeamReassignWizards { get; set; }

        /// <summary>
        /// Download AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Download AppExchange Packages")]
        public bool? PermissionsInstallMultiforce { get; set; }

        /// <summary>
        /// Upload AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Upload AppExchange Packages")]
        public bool? PermissionsPublishMultiforce { get; set; }

        /// <summary>
        /// Edit Opportunity Product Sales Price (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Opportunity Product Sales Price")]
        public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

        /// <summary>
        /// Create AppExchange Packages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create AppExchange Packages")]
        public bool? PermissionsCreateMultiforce { get; set; }

        /// <summary>
        /// Bulk API Hard Delete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Bulk API Hard Delete")]
        public bool? PermissionsBulkApiHardDelete { get; set; }

        /// <summary>
        /// Import Solutions (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Import Solutions")]
        public bool? PermissionsSolutionImport { get; set; }

        /// <summary>
        /// Manage Call Centers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Call Centers")]
        public bool? PermissionsManageCallCenters { get; set; }

        /// <summary>
        /// Manage Synonyms (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Synonyms")]
        public bool? PermissionsManageSynonyms { get; set; }

        /// <summary>
        /// Manage Email Client Configurations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Email Client Configurations")]
        public bool? PermissionsManageEmailClientConfig { get; set; }

        /// <summary>
        /// Send Outbound Messages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Send Outbound Messages")]
        public bool? PermissionsEnableNotifications { get; set; }

        /// <summary>
        /// Manage Data Integrations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Data Integrations")]
        public bool? PermissionsManageDataIntegrations { get; set; }

        /// <summary>
        /// Deliver Uploaded Files and Personal Content (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Deliver Uploaded Files and Personal Content")]
        public bool? PermissionsDistributeFromPersWksp { get; set; }

        /// <summary>
        /// View Data Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View Data Categories")]
        public bool? PermissionsViewDataCategories { get; set; }

        /// <summary>
        /// Manage Data Categories (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Data Categories")]
        public bool? PermissionsManageDataCategories { get; set; }

        /// <summary>
        /// Author Apex (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Author Apex")]
        public bool? PermissionsAuthorApex { get; set; }

        /// <summary>
        /// Manage Mobile Configurations (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Mobile Configurations")]
        public bool? PermissionsManageMobile { get; set; }

        /// <summary>
        /// API Enabled (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "API Enabled")]
        public bool? PermissionsApiEnabled { get; set; }

        /// <summary>
        /// Manage Custom Report Types (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Custom Report Types")]
        public bool? PermissionsManageCustomReportTypes { get; set; }

        /// <summary>
        /// Edit Case Comments (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Edit Case Comments")]
        public bool? PermissionsEditCaseComments { get; set; }

        /// <summary>
        /// Transfer Cases (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Transfer Cases")]
        public bool? PermissionsTransferAnyCase { get; set; }

        /// <summary>
        /// Manage Analytic Snapshots (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Analytic Snapshots")]
        public bool? PermissionsManageAnalyticSnapshots { get; set; }

        /// <summary>
        /// Schedule Reports (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Schedule Reports")]
        public bool? PermissionsScheduleReports { get; set; }

        /// <summary>
        /// Manage Business Hours Holidays (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Business Hours Holidays")]
        public bool? PermissionsManageBusinessHourHolidays { get; set; }

        /// <summary>
        /// Manage Dynamic Dashboards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Dynamic Dashboards")]
        public bool? PermissionsManageDynamicDashboards { get; set; }

        /// <summary>
        /// Show Custom Sidebar On All Pages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Custom Sidebar On All Pages")]
        public bool? PermissionsCustomSidebarOnAllPages { get; set; }

        /// <summary>
        /// Manage Force.com Flow (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Force.com Flow")]
        public bool? PermissionsManageInteraction { get; set; }

        /// <summary>
        /// View My Team's Dashboards (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View My Team's Dashboards")]
        public bool? PermissionsViewMyTeamsDashboards { get; set; }

        /// <summary>
        /// Reset User Passwords and Unlock Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Reset User Passwords and Unlock Users")]
        public bool? PermissionsResetPasswords { get; set; }

        /// <summary>
        /// Require Force.com Flow User Feature License (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Require Force.com Flow User Feature License")]
        public bool? PermissionsFlowUFLRequired { get; set; }

        /// <summary>
        /// Insert System Field Values for Chatter Feeds (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Insert System Field Values for Chatter Feeds")]
        public bool? PermissionsCanInsertFeedSystemFields { get; set; }

        /// <summary>
        /// Manage Knowledge Article Import/Export (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Knowledge Article Import/Export")]
        public bool? PermissionsManageKnowledgeImportExport { get; set; }

        /// <summary>
        /// Manage Email Templates (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Email Templates")]
        public bool? PermissionsEmailTemplateManagement { get; set; }

        /// <summary>
        /// Email Administration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Email Administration")]
        public bool? PermissionsEmailAdministration { get; set; }

        /// <summary>
        /// Manage Chatter Messages (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Chatter Messages")]
        public bool? PermissionsManageChatterMessages { get; set; }

        /// <summary>
        /// Create and Share Links to Chatter Files (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create and Share Links to Chatter Files")]
        public bool? PermissionsChatterFileLink { get; set; }

        /// <summary>
        /// Use Case Feed (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Case Feed")]
        public bool? PermissionsViewCaseInteraction { get; set; }

        /// <summary>
        /// Manage Auth. Providers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Manage Auth. Providers")]
        public bool? PermissionsManageAuthProviders { get; set; }

        /// <summary>
        /// Run Flows (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Run Flows")]
        public bool? PermissionsRunFlow { get; set; }

        /// <summary>
        /// View All Users (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "View All Users")]
        public bool? PermissionsViewAllUsers { get; set; }

        /// <summary>
        /// Knowledge One (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Knowledge One")]
        public bool? PermissionsAllowUniversalSearch { get; set; }

        /// <summary>
        /// Connect Organization to Environment Hub (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Connect Organization to Environment Hub")]
        public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

        /// <summary>
        /// Enable Work.com Calibration (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Enable Work.com Calibration")]
        public bool? PermissionsWorkCalibrationUser { get; set; }

        /// <summary>
        /// Enable Work.com (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Enable Work.com")]
        public bool? PermissionsWorkDotComUserPerm { get; set; }

        /// <summary>
        /// Sales Console (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Sales Console")]
        public bool? PermissionsSalesConsole { get; set; }

        /// <summary>
        /// Use Identity Connect (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Use Identity Connect")]
        public bool? PermissionsIdentityConnect { get; set; }

        /// <summary>
        /// Allow View Knowledge (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Allow View Knowledge")]
        public bool? PermissionsAllowViewKnowledge { get; set; }

        /// <summary>
        /// User License ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User License ID")]
        public string UserLicenseId { get; private set; }

        /// <summary>
        /// User Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Type")]
        public string UserType { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for PushTopic
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class PushTopic
    {
        /// <summary>
        /// Push Topic ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Push Topic ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Topic Name (string type in Salesforce)
        /// </summary>
        //[StringLength(25)]
        //[Display(Name = "Topic Name")]
        public string Name { get; set; }

        /// <summary>
        /// SOQL Query (string type in Salesforce)
        /// </summary>
        //[StringLength(1300)]
        //[Display(Name = "SOQL Query")]
        public string Query { get; set; }

        /// <summary>
        /// API Version (double type in Salesforce)
        /// </summary>
        //[Display(Name = "API Version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Is Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Notify For Fields (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Notify For Fields")]
        public string NotifyForFields { get; set; }

        /// <summary>
        /// Notify For Operations (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Notify For Operations")]
        public string NotifyForOperations { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(400)]
        public string Description { get; set; }

        /// <summary>
        /// Create (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Create")]
        public bool? NotifyForOperationCreate { get; set; }

        /// <summary>
        /// Update (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Update")]
        public bool? NotifyForOperationUpdate { get; set; }

        /// <summary>
        /// Delete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Delete")]
        public bool? NotifyForOperationDelete { get; set; }

        /// <summary>
        /// Undelete (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Undelete")]
        public bool? NotifyForOperationUndelete { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for QueueSobject
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class QueueSobject
    {
        /// <summary>
        /// Queue Sobject ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Queue Sobject ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Group ID")]
        public string QueueId { get; private set; }

        /// <summary>
        /// Sobject Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sobject Type")]
        public string SobjectType { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for RecentlyViewed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class RecentlyViewed
    {
        /// <summary>
        /// Recently Viewed ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Recently Viewed ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Name")]
        public string LastName { get; private set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "First Name")]
        public string FirstName { get; private set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Alias { get; private set; }

        /// <summary>
        /// Role ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Role ID")]
        public string UserRoleId { get; private set; }

        /// <summary>
        /// Record Type ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record Type ID")]
        public string RecordTypeId { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Active")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Profile ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Profile ID")]
        public string ProfileId { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// E-mail (email type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "E-mail")]
        public string Email { get; private set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Phone { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for RecordType
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class RecordType
    {
        /// <summary>
        /// Record Type ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record Type ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Record Type Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Record Type Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Business Process ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Business Process ID")]
        public string BusinessProcessId { get; set; }

        /// <summary>
        /// Sobject Type Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sobject Type Name")]
        public string SobjectType { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Report
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Report
    {
        /// <summary>
        /// Report ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Report ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Report Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Report Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Report Unique Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Report Unique Name")]
        public string DeveloperName { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Last Run (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Run")]
        public string LastRunDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Format (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Format { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for ReportFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class ReportFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for SetupEntityAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SetupEntityAccess
    {
        /// <summary>
        /// SetupEntityAccess ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "SetupEntityAccess ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Setup Entity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Setup Entity ID")]
        public string SetupEntityId { get; private set; }

        /// <summary>
        /// Setup Entity Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Setup Entity Type")]
        public string SetupEntityType { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Site
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Site
    {
        /// <summary>
        /// Site ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Site Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Site Subdomain Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Subdomain Prefix")]
        public string Subdomain { get; private set; }

        /// <summary>
        /// Default Web Address (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Default Web Address")]
        public string UrlPathPrefix { get; private set; }

        /// <summary>
        /// Site Status (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Status")]
        public string Status { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string AdminId { get; private set; }

        /// <summary>
        /// Enable Feeds (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Feeds")]
        public bool? OptionsEnableFeeds { get; private set; }

        /// <summary>
        /// Enable Standard Home Page (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Standard Home Page")]
        public bool? OptionsAllowHomePage { get; private set; }

        /// <summary>
        /// Enable Standard Ideas Pages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Standard Ideas Pages")]
        public bool? OptionsAllowStandardIdeasPages { get; private set; }

        /// <summary>
        /// Enable Standard Lookup Pages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Standard Lookup Pages")]
        public bool? OptionsAllowStandardSearch { get; private set; }

        /// <summary>
        /// Enable Standard Search Pages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Standard Search Pages")]
        public bool? OptionsAllowStandardLookups { get; private set; }

        /// <summary>
        /// Enable Standard Answers Pages (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Enable Standard Answers Pages")]
        public bool? OptionsAllowStandardAnswersPages { get; private set; }

        /// <summary>
        /// Site Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Description")]
        public string Description { get; private set; }

        /// <summary>
        /// Site Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Analytics Tracking Code (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Analytics Tracking Code")]
        public string AnalyticsTrackingCode { get; private set; }

        /// <summary>
        /// Site Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site Type")]
        public string SiteType { get; private set; }

        /// <summary>
        /// Daily Bandwidth Limit (MB) (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Daily Bandwidth Limit (MB)")]
        public string DailyBandwidthLimit { get; private set; }

        /// <summary>
        /// Daily Bandwidth Used (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Daily Bandwidth Used")]
        public string DailyBandwidthUsed { get; private set; }

        /// <summary>
        /// Daily Request Time Limit (min) (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Daily Request Time Limit (min)")]
        public string DailyRequestTimeLimit { get; private set; }

        /// <summary>
        /// Daily Request Time Used (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Daily Request Time Used")]
        public string DailyRequestTimeUsed { get; private set; }

        /// <summary>
        /// Monthly Page Views Allowed (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Monthly Page Views Allowed")]
        public string MonthlyPageViewsEntitlement { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for SiteFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SiteFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for SiteHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SiteHistory
    {
        /// <summary>
        /// Custom Site ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Custom Site ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Site ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Site ID")]
        public string SiteId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for Solution
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Solution
    {
        /// <summary>
        /// Solution ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Solution Number (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution Number")]
        public string SolutionNumber { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Title")]
        public string SolutionName { get; set; }

        /// <summary>
        /// Visible in Self-Service Portal (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Visible in Self-Service Portal")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Visible in Public Knowledge Base (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Visible in Public Knowledge Base")]
        public bool? IsPublishedInPublicKb { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Reviewed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Reviewed")]
        public bool? IsReviewed { get; private set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        //[Display(Name = "Description")]
        public string SolutionNote { get; set; }

        /// <summary>
        /// Owner ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Owner ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Num Related Cases (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Num Related Cases")]
        public string TimesUsed { get; private set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

        /// <summary>
        /// Is Html (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Html")]
        public bool? IsHtml { get; private set; }

    }

    /// <summary>
    /// POCO for SolutionFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SolutionFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for SolutionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SolutionHistory
    {
        /// <summary>
        /// Solution History ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution History ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Solution ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution ID")]
        public string SolutionId { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Changed Field (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Changed Field")]
        public string Field { get; private set; }

        /// <summary>
        /// Old Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Old Value")]
        public string OldValue { get; private set; }

        /// <summary>
        /// New Value (anyType type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "New Value")]
        public string NewValue { get; private set; }

    }

    /// <summary>
    /// POCO for SolutionStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class SolutionStatus
    {
        /// <summary>
        /// Solution Status Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Solution Status Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Is Reviewed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Reviewed")]
        public bool? IsReviewed { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for StaticResource
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class StaticResource
    {
        /// <summary>
        /// Static Resource ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Static Resource ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// MIME Type (string type in Salesforce)
        /// </summary>
        //[StringLength(120)]
        //[Display(Name = "MIME Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Size")]
        public string BodyLength { get; private set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Cache Control (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Cache Control")]
        public string CacheControl { get; set; }

    }

    /// <summary>
    /// POCO for Task
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Task
    {
        /// <summary>
        /// Activity ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Activity ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Contact/Lead ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Contact/Lead ID")]
        public string WhoId { get; set; }

        /// <summary>
        /// Opportunity/Account ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Opportunity/Account ID")]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// Due Date Only (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Due Date Only")]
        public string ActivityDate { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// Assigned To ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Assigned To ID")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Archived (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Archived")]
        public bool? IsArchived { get; private set; }

        /// <summary>
        /// Call Duration (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Call Duration")]
        public string CallDurationInSeconds { get; set; }

        /// <summary>
        /// Call Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Call Type")]
        public string CallType { get; set; }

        /// <summary>
        /// Call Result (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Call Result")]
        public string CallDisposition { get; set; }

        /// <summary>
        /// Call Object Identifier (string type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        //[Display(Name = "Call Object Identifier")]
        public string CallObject { get; set; }

        /// <summary>
        /// Reminder Date/Time (datetime type in Salesforce)
        /// </summary>
        //[Display(Name = "Reminder Date/Time")]
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// Reminder Set (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Reminder Set")]
        public bool? IsReminderSet { get; set; }

        /// <summary>
        /// Recurrence Activity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Recurrence Activity ID")]
        public string RecurrenceActivityId { get; private set; }

        /// <summary>
        /// Create Recurring Series of Tasks (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Create Recurring Series of Tasks")]
        public bool? IsRecurrence { get; private set; }

        /// <summary>
        /// Start Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "Start Date")]
        public string RecurrenceStartDateOnly { get; set; }

        /// <summary>
        /// End Date (date type in Salesforce)
        /// </summary>
        //[Display(Name = "End Date")]
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// Recurrence Time Zone (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Time Zone")]
        public string RecurrenceTimeZoneSidKey { get; set; }

        /// <summary>
        /// Recurrence Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Type")]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// Recurrence Interval (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Interval")]
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// Recurrence Day of Week Mask (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Week Mask")]
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// Recurrence Day of Month (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Recurrence Day of Month")]
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// Recurrence Instance (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Instance")]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// Recurrence Month of Year (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Recurrence Month of Year")]
        public string RecurrenceMonthOfYear { get; set; }

    }

    /// <summary>
    /// POCO for TaskFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class TaskFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for TaskPriority
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class TaskPriority
    {
        /// <summary>
        /// Task Priority Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Task Priority Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Is High Priority (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is High Priority")]
        public bool? IsHighPriority { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for TaskStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class TaskStatus
    {
        /// <summary>
        /// Task Status Value ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Task Status Value ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Master Label (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Master Label")]
        public string MasterLabel { get; private set; }

        /// <summary>
        /// Sort Order (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sort Order")]
        public string SortOrder { get; private set; }

        /// <summary>
        /// Is Default (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Default")]
        public bool? IsDefault { get; private set; }

        /// <summary>
        /// Is Closed (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Is Closed")]
        public bool? IsClosed { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for Topic
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Topic
    {
        /// <summary>
        /// Topic ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Topic ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(99)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Talking About (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Talking About")]
        public string TalkingAbout { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for TopicAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class TopicAssignment
    {
        /// <summary>
        /// Topic Assignment Id (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Topic Assignment Id")]
        public string Id { get; private set; }

        /// <summary>
        /// Topic ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Topic ID")]
        public string TopicId { get; private set; }

        /// <summary>
        /// Entity ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Entity ID")]
        public string EntityId { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for TopicFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class TopicFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for UndecidedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UndecidedEventRelation
    {
        /// <summary>
        /// Event Relation ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event Relation ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Relation ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Relation ID")]
        public string RelationId { get; private set; }

        /// <summary>
        /// Event ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Event ID")]
        public string EventId { get; private set; }

        /// <summary>
        /// Response Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Response Date")]
        public string RespondedDate { get; private set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Response { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Type { get; private set; }

    }

    /// <summary>
    /// POCO for User
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class User
    {
        /// <summary>
        /// User ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Username (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Username { get; set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Full Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Full Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Company Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Division (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Division { get; set; }

        /// <summary>
        /// Department (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Department { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        //[StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State/Province (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "State/Province")]
        public string State { get; set; }

        /// <summary>
        /// Zip/Postal Code (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Zip/Postal Code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Country { get; set; }

        /// <summary>
        /// Latitude (double type in Salesforce)
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude (double type in Salesforce)
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// E-mail (email type in Salesforce)
        /// </summary>
        //[StringLength(128)]
        //[Display(Name = "E-mail")]
        public string Email { get; set; }

        /// <summary>
        /// AutoBcc (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AutoBcc")]
        public bool? EmailPreferencesAutoBcc { get; set; }

        /// <summary>
        /// AutoBccStayInTouch (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "AutoBccStayInTouch")]
        public bool? EmailPreferencesAutoBccStayInTouch { get; set; }

        /// <summary>
        /// StayInTouchReminder (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "StayInTouchReminder")]
        public bool? EmailPreferencesStayInTouchReminder { get; set; }

        /// <summary>
        /// Email Sender Address (email type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Email Sender Address")]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Email Sender Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Email Sender Name")]
        public string SenderName { get; set; }

        /// <summary>
        /// Email Signature (string type in Salesforce)
        /// </summary>
        //[StringLength(1333)]
        //[Display(Name = "Email Signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Stay-in-Touch Email Subject (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Stay-in-Touch Email Subject")]
        public string StayInTouchSubject { get; set; }

        /// <summary>
        /// Stay-in-Touch Email Signature (string type in Salesforce)
        /// </summary>
        //[StringLength(512)]
        //[Display(Name = "Stay-in-Touch Email Signature")]
        public string StayInTouchSignature { get; set; }

        /// <summary>
        /// Stay-in-Touch Email Note (string type in Salesforce)
        /// </summary>
        //[StringLength(512)]
        //[Display(Name = "Stay-in-Touch Email Note")]
        public string StayInTouchNote { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// Cell (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Cell")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        //[StringLength(8)]
        public string Alias { get; set; }

        /// <summary>
        /// Nickname (string type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Nickname")]
        public string CommunityNickname { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Time Zone (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Time Zone")]
        public string TimeZoneSidKey { get; set; }

        /// <summary>
        /// Role ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Role ID")]
        public string UserRoleId { get; set; }

        /// <summary>
        /// Locale (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Locale")]
        public string LocaleSidKey { get; set; }

        /// <summary>
        /// Info Emails (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Info Emails")]
        public bool? ReceivesInfoEmails { get; set; }

        /// <summary>
        /// Admin Info Emails (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Admin Info Emails")]
        public bool? ReceivesAdminInfoEmails { get; set; }

        /// <summary>
        /// Email Encoding (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Email Encoding")]
        public string EmailEncodingKey { get; set; }

        /// <summary>
        /// Profile ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Profile ID")]
        public string ProfileId { get; set; }

        /// <summary>
        /// User Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Type")]
        public string UserType { get; private set; }

        /// <summary>
        /// Language (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Language")]
        public string LanguageLocaleKey { get; set; }

        /// <summary>
        /// Employee Number (string type in Salesforce)
        /// </summary>
        //[StringLength(20)]
        //[Display(Name = "Employee Number")]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// Delegated Approver ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Delegated Approver ID")]
        public string DelegatedApproverId { get; set; }

        /// <summary>
        /// Manager ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Manager ID")]
        public string ManagerId { get; set; }

        /// <summary>
        /// Last Login (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Login")]
        public string LastLoginDate { get; private set; }

        /// <summary>
        /// Last Password Change or Reset (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Password Change or Reset")]
        public string LastPasswordChangeDate { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Offline Edition Trial Expiration Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Offline Edition Trial Expiration Date")]
        public string OfflineTrialExpirationDate { get; private set; }

        /// <summary>
        /// Sales Anywhere Trial Expiration Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Sales Anywhere Trial Expiration Date")]
        public string OfflinePdaTrialExpirationDate { get; private set; }

        /// <summary>
        /// Marketing User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Marketing User")]
        public bool? UserPermissionsMarketingUser { get; set; }

        /// <summary>
        /// Offline User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Offline User")]
        public bool? UserPermissionsOfflineUser { get; set; }

        /// <summary>
        /// Auto-login To Call Center (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Auto-login To Call Center")]
        public bool? UserPermissionsCallCenterAutoLogin { get; set; }

        /// <summary>
        /// Apex Mobile User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Apex Mobile User")]
        public bool? UserPermissionsMobileUser { get; set; }

        /// <summary>
        /// Salesforce CRM Content User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Salesforce CRM Content User")]
        public bool? UserPermissionsSFContentUser { get; set; }

        /// <summary>
        /// Knowledge User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Knowledge User")]
        public bool? UserPermissionsKnowledgeUser { get; set; }

        /// <summary>
        /// Force.com Flow User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Force.com Flow User")]
        public bool? UserPermissionsInteractionUser { get; set; }

        /// <summary>
        /// Service Cloud User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Service Cloud User")]
        public bool? UserPermissionsSupportUser { get; set; }

        /// <summary>
        /// Site.com Contributor User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Site.com Contributor User")]
        public bool? UserPermissionsSiteforceContributorUser { get; set; }

        /// <summary>
        /// Site.com Publisher User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Site.com Publisher User")]
        public bool? UserPermissionsSiteforcePublisherUser { get; set; }

        /// <summary>
        /// Chatter Answers User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Chatter Answers User")]
        public bool? UserPermissionsChatterAnswersUser { get; set; }

        /// <summary>
        /// Work.com User (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Work.com User")]
        public bool? UserPermissionsWorkDotComUserFeature { get; set; }

        /// <summary>
        /// Allow Forecasting (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Allow Forecasting")]
        public bool? ForecastEnabled { get; set; }

        /// <summary>
        /// ActivityRemindersPopup (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ActivityRemindersPopup")]
        public bool? UserPreferencesActivityRemindersPopup { get; set; }

        /// <summary>
        /// EventRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "EventRemindersCheckboxDefault")]
        public bool? UserPreferencesEventRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// TaskRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "TaskRemindersCheckboxDefault")]
        public bool? UserPreferencesTaskRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// ReminderSoundOff (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ReminderSoundOff")]
        public bool? UserPreferencesReminderSoundOff { get; set; }

        /// <summary>
        /// DisableAllFeedsEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableAllFeedsEmail")]
        public bool? UserPreferencesDisableAllFeedsEmail { get; set; }

        /// <summary>
        /// DisableFollowersEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableFollowersEmail")]
        public bool? UserPreferencesDisableFollowersEmail { get; set; }

        /// <summary>
        /// DisableProfilePostEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableProfilePostEmail")]
        public bool? UserPreferencesDisableProfilePostEmail { get; set; }

        /// <summary>
        /// DisableChangeCommentEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableChangeCommentEmail")]
        public bool? UserPreferencesDisableChangeCommentEmail { get; set; }

        /// <summary>
        /// DisableLaterCommentEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableLaterCommentEmail")]
        public bool? UserPreferencesDisableLaterCommentEmail { get; set; }

        /// <summary>
        /// DisProfPostCommentEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisProfPostCommentEmail")]
        public bool? UserPreferencesDisProfPostCommentEmail { get; set; }

        /// <summary>
        /// ContentNoEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ContentNoEmail")]
        public bool? UserPreferencesContentNoEmail { get; set; }

        /// <summary>
        /// ContentEmailAsAndWhen (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ContentEmailAsAndWhen")]
        public bool? UserPreferencesContentEmailAsAndWhen { get; set; }

        /// <summary>
        /// ApexPagesDeveloperMode (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ApexPagesDeveloperMode")]
        public bool? UserPreferencesApexPagesDeveloperMode { get; set; }

        /// <summary>
        /// HideCSNGetChatterMobileTask (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "HideCSNGetChatterMobileTask")]
        public bool? UserPreferencesHideCSNGetChatterMobileTask { get; set; }

        /// <summary>
        /// DisableMentionsPostEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableMentionsPostEmail")]
        public bool? UserPreferencesDisableMentionsPostEmail { get; set; }

        /// <summary>
        /// DisMentionsCommentEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisMentionsCommentEmail")]
        public bool? UserPreferencesDisMentionsCommentEmail { get; set; }

        /// <summary>
        /// HideCSNDesktopTask (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "HideCSNDesktopTask")]
        public bool? UserPreferencesHideCSNDesktopTask { get; set; }

        /// <summary>
        /// HideChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "HideChatterOnboardingSplash")]
        public bool? UserPreferencesHideChatterOnboardingSplash { get; set; }

        /// <summary>
        /// HideSecondChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "HideSecondChatterOnboardingSplash")]
        public bool? UserPreferencesHideSecondChatterOnboardingSplash { get; set; }

        /// <summary>
        /// DisCommentAfterLikeEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisCommentAfterLikeEmail")]
        public bool? UserPreferencesDisCommentAfterLikeEmail { get; set; }

        /// <summary>
        /// DisableLikeEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableLikeEmail")]
        public bool? UserPreferencesDisableLikeEmail { get; set; }

        /// <summary>
        /// DisableMessageEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableMessageEmail")]
        public bool? UserPreferencesDisableMessageEmail { get; set; }

        /// <summary>
        /// OptOutOfTouch (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "OptOutOfTouch")]
        public bool? UserPreferencesOptOutOfTouch { get; set; }

        /// <summary>
        /// DisableBookmarkEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableBookmarkEmail")]
        public bool? UserPreferencesDisableBookmarkEmail { get; set; }

        /// <summary>
        /// DisableSharePostEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableSharePostEmail")]
        public bool? UserPreferencesDisableSharePostEmail { get; set; }

        /// <summary>
        /// EnableAutoSubForFeeds (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "EnableAutoSubForFeeds")]
        public bool? UserPreferencesEnableAutoSubForFeeds { get; set; }

        /// <summary>
        /// DisableFileShareNotificationsForApi (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableFileShareNotificationsForApi")]
        public bool? UserPreferencesDisableFileShareNotificationsForApi { get; set; }

        /// <summary>
        /// ShowTitleToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowTitleToExternalUsers")]
        public bool? UserPreferencesShowTitleToExternalUsers { get; set; }

        /// <summary>
        /// ShowManagerToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowManagerToExternalUsers")]
        public bool? UserPreferencesShowManagerToExternalUsers { get; set; }

        /// <summary>
        /// ShowEmailToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowEmailToExternalUsers")]
        public bool? UserPreferencesShowEmailToExternalUsers { get; set; }

        /// <summary>
        /// ShowWorkPhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowWorkPhoneToExternalUsers")]
        public bool? UserPreferencesShowWorkPhoneToExternalUsers { get; set; }

        /// <summary>
        /// ShowMobilePhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowMobilePhoneToExternalUsers")]
        public bool? UserPreferencesShowMobilePhoneToExternalUsers { get; set; }

        /// <summary>
        /// ShowFaxToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowFaxToExternalUsers")]
        public bool? UserPreferencesShowFaxToExternalUsers { get; set; }

        /// <summary>
        /// ShowStreetAddressToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowStreetAddressToExternalUsers")]
        public bool? UserPreferencesShowStreetAddressToExternalUsers { get; set; }

        /// <summary>
        /// ShowCityToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowCityToExternalUsers")]
        public bool? UserPreferencesShowCityToExternalUsers { get; set; }

        /// <summary>
        /// ShowStateToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowStateToExternalUsers")]
        public bool? UserPreferencesShowStateToExternalUsers { get; set; }

        /// <summary>
        /// ShowPostalCodeToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowPostalCodeToExternalUsers")]
        public bool? UserPreferencesShowPostalCodeToExternalUsers { get; set; }

        /// <summary>
        /// ShowCountryToExternalUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowCountryToExternalUsers")]
        public bool? UserPreferencesShowCountryToExternalUsers { get; set; }

        /// <summary>
        /// ShowProfilePicToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowProfilePicToGuestUsers")]
        public bool? UserPreferencesShowProfilePicToGuestUsers { get; set; }

        /// <summary>
        /// ShowTitleToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowTitleToGuestUsers")]
        public bool? UserPreferencesShowTitleToGuestUsers { get; set; }

        /// <summary>
        /// ShowCityToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowCityToGuestUsers")]
        public bool? UserPreferencesShowCityToGuestUsers { get; set; }

        /// <summary>
        /// ShowStateToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowStateToGuestUsers")]
        public bool? UserPreferencesShowStateToGuestUsers { get; set; }

        /// <summary>
        /// ShowPostalCodeToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowPostalCodeToGuestUsers")]
        public bool? UserPreferencesShowPostalCodeToGuestUsers { get; set; }

        /// <summary>
        /// ShowCountryToGuestUsers (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "ShowCountryToGuestUsers")]
        public bool? UserPreferencesShowCountryToGuestUsers { get; set; }

        /// <summary>
        /// DisableFeedbackEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableFeedbackEmail")]
        public bool? UserPreferencesDisableFeedbackEmail { get; set; }

        /// <summary>
        /// DisableCoachingEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableCoachingEmail")]
        public bool? UserPreferencesDisableCoachingEmail { get; set; }

        /// <summary>
        /// DisableGoalEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableGoalEmail")]
        public bool? UserPreferencesDisableGoalEmail { get; set; }

        /// <summary>
        /// DisableWorkEmail (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "DisableWorkEmail")]
        public bool? UserPreferencesDisableWorkEmail { get; set; }

        /// <summary>
        /// HideS1BrowserUI (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "HideS1BrowserUI")]
        public bool? UserPreferencesHideS1BrowserUI { get; set; }

        /// <summary>
        /// Contact ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact ID")]
        public string ContactId { get; private set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Call Center ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Call Center ID")]
        public string CallCenterId { get; set; }

        /// <summary>
        /// Extension (phone type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        public string Extension { get; set; }

        /// <summary>
        /// SAML Federation ID (string type in Salesforce)
        /// </summary>
        //[StringLength(512)]
        //[Display(Name = "SAML Federation ID")]
        public string FederationIdentifier { get; set; }

        /// <summary>
        /// About Me (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        //[Display(Name = "About Me")]
        public string AboutMe { get; set; }

        /// <summary>
        /// Url for full-sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for full-sized Photo")]
        public string FullPhotoUrl { get; private set; }

        /// <summary>
        /// Url for Thumbnail sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for Thumbnail sized Photo")]
        public string SmallPhotoUrl { get; private set; }

        /// <summary>
        /// Chatter Email Highlights Frequency (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Chatter Email Highlights Frequency")]
        public string DigestFrequency { get; set; }

        /// <summary>
        /// Default Notification Frequency when Joining Groups (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Default Notification Frequency when Joining Groups")]
        public string DefaultGroupNotificationFrequency { get; set; }

        /// <summary>
        /// Last Viewed Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Viewed Date")]
        public string LastViewedDate { get; private set; }

        /// <summary>
        /// Last Referenced Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Referenced Date")]
        public string LastReferencedDate { get; private set; }

    }

    /// <summary>
    /// POCO for UserFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserFeed
    {
        /// <summary>
        /// Feed Item ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Feed Item Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Feed Item Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Comment Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Comment Count")]
        public string CommentCount { get; private set; }

        /// <summary>
        /// Like Count (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Like Count")]
        public string LikeCount { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Body { get; private set; }

        /// <summary>
        /// Link Url (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Link Url")]
        public string LinkUrl { get; private set; }

        /// <summary>
        /// Related Record ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Related Record ID")]
        public string RelatedRecordId { get; private set; }

        /// <summary>
        /// Content Data (base64 type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Data")]
        public string ContentData { get; private set; }

        /// <summary>
        /// Content File Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Name")]
        public string ContentFileName { get; private set; }

        /// <summary>
        /// Content Description (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Description")]
        public string ContentDescription { get; private set; }

        /// <summary>
        /// Content File Type (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content File Type")]
        public string ContentType { get; private set; }

        /// <summary>
        /// Content Size (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Content Size")]
        public string ContentSize { get; private set; }

        /// <summary>
        /// InsertedBy ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "InsertedBy ID")]
        public string InsertedById { get; private set; }

    }

    /// <summary>
    /// POCO for UserLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserLicense
    {
        /// <summary>
        /// User License ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User License ID")]
        public string Id { get; private set; }

        /// <summary>
        /// License Def. ID (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "License Def. ID")]
        public string LicenseDefinitionKey { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Monthly Logins Used (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Monthly Logins Used")]
        public string MonthlyLoginsUsed { get; private set; }

        /// <summary>
        /// Monthly Logins Allotted (int type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Monthly Logins Allotted")]
        public string MonthlyLoginsEntitlement { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for UserLogin
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserLogin
    {
        /// <summary>
        /// User Login ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Login ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UserId { get; private set; }

        /// <summary>
        /// Is Frozen (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Frozen")]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// Is Password Locked (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Is Password Locked")]
        public bool? IsPasswordLocked { get; set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

    }

    /// <summary>
    /// POCO for UserPreference
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserPreference
    {
        /// <summary>
        /// User Preference ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Preference ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UserId { get; private set; }

        /// <summary>
        /// Preference (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Preference { get; private set; }

        /// <summary>
        /// Value (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Value { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for UserProfile
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserProfile
    {
        /// <summary>
        /// User ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Last Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Name")]
        public string LastName { get; private set; }

        /// <summary>
        /// First Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "First Name")]
        public string FirstName { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Name { get; private set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Title { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string ManagerId { get; private set; }

        /// <summary>
        /// Company Name (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Company Name")]
        public string CompanyName { get; private set; }

        /// <summary>
        /// About Me (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "About Me")]
        public string AboutMe { get; private set; }

        /// <summary>
        /// E-mail (email type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "E-mail")]
        public string Email { get; private set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Phone { get; private set; }

        /// <summary>
        /// Cell (phone type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Cell")]
        public string MobilePhone { get; private set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Fax { get; private set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Street { get; private set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string City { get; private set; }

        /// <summary>
        /// State/Province (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "State/Province")]
        public string State { get; private set; }

        /// <summary>
        /// Zip/Postal Code (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Zip/Postal Code")]
        public string PostalCode { get; private set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Country { get; private set; }

        /// <summary>
        /// Latitude (double type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Latitude { get; private set; }

        /// <summary>
        /// Longitude (double type in Salesforce)
        /// </summary>
        [JsonIgnore]
        public string Longitude { get; private set; }

        /// <summary>
        /// User Photo has a badge overlay (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Photo has a badge overlay")]
        public bool? IsBadged { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Active")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// ActivityRemindersPopup (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ActivityRemindersPopup")]
        public bool? UserPreferencesActivityRemindersPopup { get; private set; }

        /// <summary>
        /// EventRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "EventRemindersCheckboxDefault")]
        public bool? UserPreferencesEventRemindersCheckboxDefault { get; private set; }

        /// <summary>
        /// TaskRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "TaskRemindersCheckboxDefault")]
        public bool? UserPreferencesTaskRemindersCheckboxDefault { get; private set; }

        /// <summary>
        /// ReminderSoundOff (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ReminderSoundOff")]
        public bool? UserPreferencesReminderSoundOff { get; private set; }

        /// <summary>
        /// DisableAllFeedsEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableAllFeedsEmail")]
        public bool? UserPreferencesDisableAllFeedsEmail { get; private set; }

        /// <summary>
        /// DisableFollowersEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableFollowersEmail")]
        public bool? UserPreferencesDisableFollowersEmail { get; private set; }

        /// <summary>
        /// DisableProfilePostEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableProfilePostEmail")]
        public bool? UserPreferencesDisableProfilePostEmail { get; private set; }

        /// <summary>
        /// DisableChangeCommentEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableChangeCommentEmail")]
        public bool? UserPreferencesDisableChangeCommentEmail { get; private set; }

        /// <summary>
        /// DisableLaterCommentEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableLaterCommentEmail")]
        public bool? UserPreferencesDisableLaterCommentEmail { get; private set; }

        /// <summary>
        /// DisProfPostCommentEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisProfPostCommentEmail")]
        public bool? UserPreferencesDisProfPostCommentEmail { get; private set; }

        /// <summary>
        /// ContentNoEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentNoEmail")]
        public bool? UserPreferencesContentNoEmail { get; private set; }

        /// <summary>
        /// ContentEmailAsAndWhen (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ContentEmailAsAndWhen")]
        public bool? UserPreferencesContentEmailAsAndWhen { get; private set; }

        /// <summary>
        /// ApexPagesDeveloperMode (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ApexPagesDeveloperMode")]
        public bool? UserPreferencesApexPagesDeveloperMode { get; private set; }

        /// <summary>
        /// HideCSNGetChatterMobileTask (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "HideCSNGetChatterMobileTask")]
        public bool? UserPreferencesHideCSNGetChatterMobileTask { get; private set; }

        /// <summary>
        /// DisableMentionsPostEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableMentionsPostEmail")]
        public bool? UserPreferencesDisableMentionsPostEmail { get; private set; }

        /// <summary>
        /// DisMentionsCommentEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisMentionsCommentEmail")]
        public bool? UserPreferencesDisMentionsCommentEmail { get; private set; }

        /// <summary>
        /// HideCSNDesktopTask (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "HideCSNDesktopTask")]
        public bool? UserPreferencesHideCSNDesktopTask { get; private set; }

        /// <summary>
        /// HideChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "HideChatterOnboardingSplash")]
        public bool? UserPreferencesHideChatterOnboardingSplash { get; private set; }

        /// <summary>
        /// HideSecondChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "HideSecondChatterOnboardingSplash")]
        public bool? UserPreferencesHideSecondChatterOnboardingSplash { get; private set; }

        /// <summary>
        /// DisCommentAfterLikeEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisCommentAfterLikeEmail")]
        public bool? UserPreferencesDisCommentAfterLikeEmail { get; private set; }

        /// <summary>
        /// DisableLikeEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableLikeEmail")]
        public bool? UserPreferencesDisableLikeEmail { get; private set; }

        /// <summary>
        /// DisableMessageEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableMessageEmail")]
        public bool? UserPreferencesDisableMessageEmail { get; private set; }

        /// <summary>
        /// OptOutOfTouch (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "OptOutOfTouch")]
        public bool? UserPreferencesOptOutOfTouch { get; private set; }

        /// <summary>
        /// DisableBookmarkEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableBookmarkEmail")]
        public bool? UserPreferencesDisableBookmarkEmail { get; private set; }

        /// <summary>
        /// DisableSharePostEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableSharePostEmail")]
        public bool? UserPreferencesDisableSharePostEmail { get; private set; }

        /// <summary>
        /// EnableAutoSubForFeeds (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "EnableAutoSubForFeeds")]
        public bool? UserPreferencesEnableAutoSubForFeeds { get; private set; }

        /// <summary>
        /// DisableFileShareNotificationsForApi (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableFileShareNotificationsForApi")]
        public bool? UserPreferencesDisableFileShareNotificationsForApi { get; private set; }

        /// <summary>
        /// ShowTitleToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowTitleToExternalUsers")]
        public bool? UserPreferencesShowTitleToExternalUsers { get; private set; }

        /// <summary>
        /// ShowManagerToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowManagerToExternalUsers")]
        public bool? UserPreferencesShowManagerToExternalUsers { get; private set; }

        /// <summary>
        /// ShowEmailToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowEmailToExternalUsers")]
        public bool? UserPreferencesShowEmailToExternalUsers { get; private set; }

        /// <summary>
        /// ShowWorkPhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowWorkPhoneToExternalUsers")]
        public bool? UserPreferencesShowWorkPhoneToExternalUsers { get; private set; }

        /// <summary>
        /// ShowMobilePhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowMobilePhoneToExternalUsers")]
        public bool? UserPreferencesShowMobilePhoneToExternalUsers { get; private set; }

        /// <summary>
        /// ShowFaxToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowFaxToExternalUsers")]
        public bool? UserPreferencesShowFaxToExternalUsers { get; private set; }

        /// <summary>
        /// ShowStreetAddressToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowStreetAddressToExternalUsers")]
        public bool? UserPreferencesShowStreetAddressToExternalUsers { get; private set; }

        /// <summary>
        /// ShowCityToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowCityToExternalUsers")]
        public bool? UserPreferencesShowCityToExternalUsers { get; private set; }

        /// <summary>
        /// ShowStateToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowStateToExternalUsers")]
        public bool? UserPreferencesShowStateToExternalUsers { get; private set; }

        /// <summary>
        /// ShowPostalCodeToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowPostalCodeToExternalUsers")]
        public bool? UserPreferencesShowPostalCodeToExternalUsers { get; private set; }

        /// <summary>
        /// ShowCountryToExternalUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowCountryToExternalUsers")]
        public bool? UserPreferencesShowCountryToExternalUsers { get; private set; }

        /// <summary>
        /// ShowProfilePicToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowProfilePicToGuestUsers")]
        public bool? UserPreferencesShowProfilePicToGuestUsers { get; private set; }

        /// <summary>
        /// ShowTitleToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowTitleToGuestUsers")]
        public bool? UserPreferencesShowTitleToGuestUsers { get; private set; }

        /// <summary>
        /// ShowCityToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowCityToGuestUsers")]
        public bool? UserPreferencesShowCityToGuestUsers { get; private set; }

        /// <summary>
        /// ShowStateToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowStateToGuestUsers")]
        public bool? UserPreferencesShowStateToGuestUsers { get; private set; }

        /// <summary>
        /// ShowPostalCodeToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowPostalCodeToGuestUsers")]
        public bool? UserPreferencesShowPostalCodeToGuestUsers { get; private set; }

        /// <summary>
        /// ShowCountryToGuestUsers (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "ShowCountryToGuestUsers")]
        public bool? UserPreferencesShowCountryToGuestUsers { get; private set; }

        /// <summary>
        /// DisableFeedbackEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableFeedbackEmail")]
        public bool? UserPreferencesDisableFeedbackEmail { get; private set; }

        /// <summary>
        /// DisableCoachingEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableCoachingEmail")]
        public bool? UserPreferencesDisableCoachingEmail { get; private set; }

        /// <summary>
        /// DisableGoalEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableGoalEmail")]
        public bool? UserPreferencesDisableGoalEmail { get; private set; }

        /// <summary>
        /// DisableWorkEmail (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "DisableWorkEmail")]
        public bool? UserPreferencesDisableWorkEmail { get; private set; }

        /// <summary>
        /// HideS1BrowserUI (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "HideS1BrowserUI")]
        public bool? UserPreferencesHideS1BrowserUI { get; private set; }

        /// <summary>
        /// Url for full-sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for full-sized Photo")]
        public string FullPhotoUrl { get; private set; }

        /// <summary>
        /// Url for Thumbnail sized Photo (url type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Url for Thumbnail sized Photo")]
        public string SmallPhotoUrl { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for UserRecordAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserRecordAccess
    {
        /// <summary>
        /// User Record Access ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Record Access ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UserId { get; private set; }

        /// <summary>
        /// Record ID (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Record ID")]
        public string RecordId { get; private set; }

        /// <summary>
        /// Has Read Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Read Access")]
        public bool? HasReadAccess { get; private set; }

        /// <summary>
        /// Has Edit Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Edit Access")]
        public bool? HasEditAccess { get; private set; }

        /// <summary>
        /// Has Delete Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Delete Access")]
        public bool? HasDeleteAccess { get; private set; }

        /// <summary>
        /// Has Transfer Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has Transfer Access")]
        public bool? HasTransferAccess { get; private set; }

        /// <summary>
        /// Has All Access (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Has All Access")]
        public bool? HasAllAccess { get; private set; }

        /// <summary>
        /// Maximum Access Level (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Maximum Access Level")]
        public string MaxAccessLevel { get; private set; }

    }

    /// <summary>
    /// POCO for UserRole
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserRole
    {
        /// <summary>
        /// Role ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Role ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Parent Role ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Parent Role ID")]
        public string ParentRoleId { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Description")]
        public string RollupDescription { get; set; }

        /// <summary>
        /// Opportunity Access Level for Account Owner (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Opportunity Access Level for Account Owner")]
        public string OpportunityAccessForAccountOwner { get; set; }

        /// <summary>
        /// Case Access Level for Account Owner (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Case Access Level for Account Owner")]
        public string CaseAccessForAccountOwner { get; set; }

        /// <summary>
        /// Contact Access Level for Account Owner (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Contact Access Level for Account Owner")]
        public string ContactAccessForAccountOwner { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "User ID")]
        public string ForecastUserId { get; set; }

        /// <summary>
        /// May Forecast Manager Share (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "May Forecast Manager Share")]
        public bool? MayForecastManagerShare { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

        /// <summary>
        /// Developer Name (string type in Salesforce)
        /// </summary>
        //[StringLength(80)]
        //[Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Account ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Account ID")]
        public string PortalAccountId { get; private set; }

        /// <summary>
        /// Portal Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Portal Type")]
        public string PortalType { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string PortalAccountOwnerId { get; private set; }

    }

    /// <summary>
    /// POCO for UserShare
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class UserShare
    {
        /// <summary>
        /// User Share ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User Share ID")]
        public string Id { get; private set; }

        /// <summary>
        /// User ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User ID")]
        public string UserId { get; private set; }

        /// <summary>
        /// User/Group ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "User/Group ID")]
        public string UserOrGroupId { get; private set; }

        /// <summary>
        /// User Access Level (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "User Access Level")]
        public string UserAccessLevel { get; set; }

        /// <summary>
        /// Row Cause (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Row Cause")]
        public string RowCause { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Active")]
        public bool? IsActive { get; private set; }

    }

    /// <summary>
    /// POCO for Vote
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class Vote
    {
        /// <summary>
        /// Vote ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Vote ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Deleted (boolean type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Deleted")]
        public bool? IsDeleted { get; private set; }

        /// <summary>
        /// Parent ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Parent ID")]
        public string ParentId { get; private set; }

        /// <summary>
        /// Vote Type (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Vote Type")]
        public string Type { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

    /// <summary>
    /// POCO for WebLink
    /// </summary>
    [DebuggerDisplay("Id={Id}; Name={Name}")]
    public partial class WebLink
    {
        /// <summary>
        /// Custom Link ID (id type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Custom Link ID")]
        public string Id { get; private set; }

        /// <summary>
        /// Page Or sObject Type Name (picklist type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Page Or sObject Type Name")]
        public string PageOrSobjectType { get; private set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        //[StringLength(240)]
        public string Name { get; set; }

        /// <summary>
        /// Protected Component (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Protected Component")]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// URL (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1048576)]
        //[Display(Name = "URL")]
        public string Url { get; set; }

        /// <summary>
        /// Link Encoding (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Link Encoding")]
        public string EncodingKey { get; set; }

        /// <summary>
        /// Content Source (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Content Source")]
        public string LinkType { get; set; }

        /// <summary>
        /// Behavior (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Behavior")]
        public string OpenType { get; set; }

        /// <summary>
        /// Height (in pixels) (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Height (in pixels)")]
        public string Height { get; set; }

        /// <summary>
        /// Width (in pixels) (int type in Salesforce)
        /// </summary>
        //[Display(Name = "Width (in pixels)")]
        public string Width { get; set; }

        /// <summary>
        /// Show Address Bar (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Address Bar")]
        public bool? ShowsLocation { get; set; }

        /// <summary>
        /// Show Scrollbars (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Scrollbars")]
        public bool? HasScrollbars { get; set; }

        /// <summary>
        /// Show Toolbars (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Toolbars")]
        public bool? HasToolbar { get; set; }

        /// <summary>
        /// Show Menu Bar (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Menu Bar")]
        public bool? HasMenubar { get; set; }

        /// <summary>
        /// Show Status Bar (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Show Status Bar")]
        public bool? ShowsStatus { get; set; }

        /// <summary>
        /// Resizeable (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Resizeable")]
        public bool? IsResizable { get; set; }

        /// <summary>
        /// Window Position (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Window Position")]
        public string Position { get; set; }

        /// <summary>
        /// Custom S-Control ID (reference type in Salesforce)
        /// </summary>
        //[StringLength(18)]
        //[Display(Name = "Custom S-Control ID")]
        public string ScontrolId { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        //[StringLength(240)]
        //[Display(Name = "Label")]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        //[StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Display Type (picklist type in Salesforce)
        /// </summary>
        //[StringLength(40)]
        //[Display(Name = "Display Type")]
        public string DisplayType { get; set; }

        /// <summary>
        /// Require Row Selection (boolean type in Salesforce)
        /// </summary>
        //[Display(Name = "Require Row Selection")]
        public bool? RequireRowSelection { get; set; }

        /// <summary>
        /// Namespace Prefix (string type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Namespace Prefix")]
        public string NamespacePrefix { get; private set; }

        /// <summary>
        /// Created Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created Date")]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Created By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Created By ID")]
        public string CreatedById { get; private set; }

        /// <summary>
        /// Last Modified Date (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; private set; }

        /// <summary>
        /// Last Modified By ID (reference type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "Last Modified By ID")]
        public string LastModifiedById { get; private set; }

        /// <summary>
        /// System Modstamp (datetime type in Salesforce)
        /// </summary>
        [JsonIgnore]
        //[Display(Name = "System Modstamp")]
        public string SystemModstamp { get; private set; }

    }

}

// ReSharper restore PartialTypeWithSinglePart
// ReSharper restore UnusedMember.Local

