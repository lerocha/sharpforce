
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
//using Newtonsoft.Json;
using SalesforceSharp.Attributes;

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMember.Local

namespace SalesforceSharp
{
    /// <summary>
    /// POCO for AcceptedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AcceptedEventRelation/describe", SObject = "/services/data/v29.0/sobjects/AcceptedEventRelation", RowTemplate = "/services/data/v29.0/sobjects/AcceptedEventRelation/{ID}")]
    public partial class AcceptedEventRelation
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// RelationId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelationId { get; set; }

        /// <summary>
        /// EventId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string EventId { get; set; }

        /// <summary>
        /// RespondedDate (datetime type in Salesforce)
        /// </summary>
        public string RespondedDate { get; set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Response { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [StringLength(50)]
        public string Type { get; set; }

    }

    /// <summary>
    /// POCO for Account
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Account/describe", SObject = "/services/data/v29.0/sobjects/Account", RowTemplate = "/services/data/v29.0/sobjects/Account/{ID}")]
    public partial class Account
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// MasterRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MasterRecordId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// BillingStreet (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string BillingStreet { get; set; }

        /// <summary>
        /// BillingCity (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string BillingCity { get; set; }

        /// <summary>
        /// BillingState (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string BillingState { get; set; }

        /// <summary>
        /// BillingPostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// BillingCountry (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string BillingCountry { get; set; }

        /// <summary>
        /// BillingLatitude (double type in Salesforce)
        /// </summary>
        public string BillingLatitude { get; set; }

        /// <summary>
        /// BillingLongitude (double type in Salesforce)
        /// </summary>
        public string BillingLongitude { get; set; }

        /// <summary>
        /// ShippingStreet (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ShippingStreet { get; set; }

        /// <summary>
        /// ShippingCity (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ShippingCity { get; set; }

        /// <summary>
        /// ShippingState (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string ShippingState { get; set; }

        /// <summary>
        /// ShippingPostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string ShippingPostalCode { get; set; }

        /// <summary>
        /// ShippingCountry (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string ShippingCountry { get; set; }

        /// <summary>
        /// ShippingLatitude (double type in Salesforce)
        /// </summary>
        public string ShippingLatitude { get; set; }

        /// <summary>
        /// ShippingLongitude (double type in Salesforce)
        /// </summary>
        public string ShippingLongitude { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// AccountNumber (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Website (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Website { get; set; }

        /// <summary>
        /// Sic (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string Sic { get; set; }

        /// <summary>
        /// Industry (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Industry { get; set; }

        /// <summary>
        /// AnnualRevenue (currency type in Salesforce)
        /// </summary>
        public string AnnualRevenue { get; set; }

        /// <summary>
        /// NumberOfEmployees (int type in Salesforce)
        /// </summary>
        public string NumberOfEmployees { get; set; }

        /// <summary>
        /// Ownership (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Ownership { get; set; }

        /// <summary>
        /// TickerSymbol (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string TickerSymbol { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// Rating (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Rating { get; set; }

        /// <summary>
        /// Site (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Site { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// Jigsaw (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string Jigsaw { get; set; }

        /// <summary>
        /// JigsawCompanyId (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string JigsawCompanyId { get; set; }

        /// <summary>
        /// AccountSource (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccountSource { get; set; }

        /// <summary>
        /// SicDesc (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SicDesc { get; set; }

        /// <summary>
        /// CustomerPriority__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CustomerPriority__c { get; set; }

        /// <summary>
        /// SLA__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string SLA__c { get; set; }

        /// <summary>
        /// Active__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Active__c { get; set; }

        /// <summary>
        /// NumberofLocations__c (double type in Salesforce)
        /// </summary>
        public string NumberofLocations__c { get; set; }

        /// <summary>
        /// UpsellOpportunity__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string UpsellOpportunity__c { get; set; }

        /// <summary>
        /// SLASerialNumber__c (string type in Salesforce)
        /// </summary>
        [StringLength(10)]
        public string SLASerialNumber__c { get; set; }

        /// <summary>
        /// SLAExpirationDate__c (date type in Salesforce)
        /// </summary>
        public string SLAExpirationDate__c { get; set; }

    }

    /// <summary>
    /// POCO for AccountContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountContactRole/describe", SObject = "/services/data/v29.0/sobjects/AccountContactRole", RowTemplate = "/services/data/v29.0/sobjects/AccountContactRole/{ID}")]
    public partial class AccountContactRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for AccountFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountFeed/describe", SObject = "/services/data/v29.0/sobjects/AccountFeed", RowTemplate = "/services/data/v29.0/sobjects/AccountFeed/{ID}")]
    public partial class AccountFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for AccountHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountHistory/describe", SObject = "/services/data/v29.0/sobjects/AccountHistory", RowTemplate = "/services/data/v29.0/sobjects/AccountHistory/{ID}")]
    public partial class AccountHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for AccountPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountPartner/describe", SObject = "/services/data/v29.0/sobjects/AccountPartner", RowTemplate = "/services/data/v29.0/sobjects/AccountPartner/{ID}")]
    public partial class AccountPartner
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountFromId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountFromId { get; set; }

        /// <summary>
        /// AccountToId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountToId { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ReversePartnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ReversePartnerId { get; set; }

    }

    /// <summary>
    /// POCO for AccountShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountShare/describe", SObject = "/services/data/v29.0/sobjects/AccountShare", RowTemplate = "/services/data/v29.0/sobjects/AccountShare/{ID}")]
    public partial class AccountShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// AccountAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccountAccessLevel { get; set; }

        /// <summary>
        /// OpportunityAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OpportunityAccessLevel { get; set; }

        /// <summary>
        /// CaseAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CaseAccessLevel { get; set; }

        /// <summary>
        /// ContactAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ContactAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for ActivityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ActivityHistory/describe", SObject = "/services/data/v29.0/sobjects/ActivityHistory", RowTemplate = "/services/data/v29.0/sobjects/ActivityHistory/{ID}")]
    public partial class ActivityHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// WhoId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhoId { get; set; }

        /// <summary>
        /// WhatId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Subject { get; set; }

        /// <summary>
        /// IsTask (boolean type in Salesforce)
        /// </summary>
        public bool? IsTask { get; set; }

        /// <summary>
        /// ActivityDate (date type in Salesforce)
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// ActivityType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ActivityType { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// IsAllDayEvent (boolean type in Salesforce)
        /// </summary>
        public bool? IsAllDayEvent { get; set; }

        /// <summary>
        /// IsVisibleInSelfService (boolean type in Salesforce)
        /// </summary>
        public bool? IsVisibleInSelfService { get; set; }

        /// <summary>
        /// DurationInMinutes (int type in Salesforce)
        /// </summary>
        public string DurationInMinutes { get; set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Location { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CallDurationInSeconds (int type in Salesforce)
        /// </summary>
        public string CallDurationInSeconds { get; set; }

        /// <summary>
        /// CallType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CallType { get; set; }

        /// <summary>
        /// CallDisposition (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallDisposition { get; set; }

        /// <summary>
        /// CallObject (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallObject { get; set; }

        /// <summary>
        /// ReminderDateTime (datetime type in Salesforce)
        /// </summary>
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// IsReminderSet (boolean type in Salesforce)
        /// </summary>
        public bool? IsReminderSet { get; set; }

        /// <summary>
        /// EndDateTime (datetime type in Salesforce)
        /// </summary>
        public string EndDateTime { get; set; }

        /// <summary>
        /// StartDateTime (datetime type in Salesforce)
        /// </summary>
        public string StartDateTime { get; set; }

    }

    /// <summary>
    /// POCO for AdditionalNumber
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AdditionalNumber/describe", SObject = "/services/data/v29.0/sobjects/AdditionalNumber", RowTemplate = "/services/data/v29.0/sobjects/AdditionalNumber/{ID}")]
    public partial class AdditionalNumber
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CallCenterId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CallCenterId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for AggregateResult
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AggregateResult/describe", SObject = "/services/data/v29.0/sobjects/AggregateResult", RowTemplate = "/services/data/v29.0/sobjects/AggregateResult/{ID}")]
    public partial class AggregateResult
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

    }

    /// <summary>
    /// POCO for ApexClass
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexClass/describe", SObject = "/services/data/v29.0/sobjects/ApexClass", RowTemplate = "/services/data/v29.0/sobjects/ApexClass/{ID}")]
    public partial class ApexClass
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// IsValid (boolean type in Salesforce)
        /// </summary>
        public bool? IsValid { get; set; }

        /// <summary>
        /// BodyCrc (double type in Salesforce)
        /// </summary>
        public string BodyCrc { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000000)]
        public string Body { get; set; }

        /// <summary>
        /// LengthWithoutComments (int type in Salesforce)
        /// </summary>
        public string LengthWithoutComments { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ApexComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexComponent/describe", SObject = "/services/data/v29.0/sobjects/ApexComponent", RowTemplate = "/services/data/v29.0/sobjects/ApexComponent/{ID}")]
    public partial class ApexComponent
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// ControllerType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ControllerType { get; set; }

        /// <summary>
        /// ControllerKey (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ControllerKey { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        [StringLength(1048576)]
        public string Markup { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ApexLog
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexLog/describe", SObject = "/services/data/v29.0/sobjects/ApexLog", RowTemplate = "/services/data/v29.0/sobjects/ApexLog/{ID}")]
    public partial class ApexLog
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// LogUserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LogUserId { get; set; }

        /// <summary>
        /// LogLength (int type in Salesforce)
        /// </summary>
        public string LogLength { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Request (string type in Salesforce)
        /// </summary>
        [StringLength(16)]
        public string Request { get; set; }

        /// <summary>
        /// Operation (string type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Operation { get; set; }

        /// <summary>
        /// Application (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string Application { get; set; }

        /// <summary>
        /// Status (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Status { get; set; }

        /// <summary>
        /// DurationMilliseconds (int type in Salesforce)
        /// </summary>
        public string DurationMilliseconds { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// StartTime (datetime type in Salesforce)
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Location (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Location { get; set; }

    }

    /// <summary>
    /// POCO for ApexPage
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexPage/describe", SObject = "/services/data/v29.0/sobjects/ApexPage", RowTemplate = "/services/data/v29.0/sobjects/ApexPage/{ID}")]
    public partial class ApexPage
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// ControllerType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ControllerType { get; set; }

        /// <summary>
        /// ControllerKey (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ControllerKey { get; set; }

        /// <summary>
        /// IsAvailableInTouch (boolean type in Salesforce)
        /// </summary>
        public bool? IsAvailableInTouch { get; set; }

        /// <summary>
        /// IsConfirmationTokenRequired (boolean type in Salesforce)
        /// </summary>
        public bool? IsConfirmationTokenRequired { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        [StringLength(1048576)]
        public string Markup { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ApexTestQueueItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTestQueueItem/describe", SObject = "/services/data/v29.0/sobjects/ApexTestQueueItem", RowTemplate = "/services/data/v29.0/sobjects/ApexTestQueueItem/{ID}")]
    public partial class ApexTestQueueItem
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// ApexClassId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ApexClassId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// ExtendedStatus (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ExtendedStatus { get; set; }

        /// <summary>
        /// ParentJobId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentJobId { get; set; }

    }

    /// <summary>
    /// POCO for ApexTestResult
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTestResult/describe", SObject = "/services/data/v29.0/sobjects/ApexTestResult", RowTemplate = "/services/data/v29.0/sobjects/ApexTestResult/{ID}")]
    public partial class ApexTestResult
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// TestTimestamp (datetime type in Salesforce)
        /// </summary>
        public string TestTimestamp { get; set; }

        /// <summary>
        /// Outcome (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Outcome { get; set; }

        /// <summary>
        /// ApexClassId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ApexClassId { get; set; }

        /// <summary>
        /// MethodName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MethodName { get; set; }

        /// <summary>
        /// Message (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Message { get; set; }

        /// <summary>
        /// StackTrace (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string StackTrace { get; set; }

        /// <summary>
        /// AsyncApexJobId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AsyncApexJobId { get; set; }

        /// <summary>
        /// QueueItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string QueueItemId { get; set; }

        /// <summary>
        /// ApexLogId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ApexLogId { get; set; }

    }

    /// <summary>
    /// POCO for ApexTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTrigger/describe", SObject = "/services/data/v29.0/sobjects/ApexTrigger", RowTemplate = "/services/data/v29.0/sobjects/ApexTrigger/{ID}")]
    public partial class ApexTrigger
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// TableEnumOrId (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TableEnumOrId { get; set; }

        /// <summary>
        /// UsageBeforeInsert (boolean type in Salesforce)
        /// </summary>
        public bool? UsageBeforeInsert { get; set; }

        /// <summary>
        /// UsageAfterInsert (boolean type in Salesforce)
        /// </summary>
        public bool? UsageAfterInsert { get; set; }

        /// <summary>
        /// UsageBeforeUpdate (boolean type in Salesforce)
        /// </summary>
        public bool? UsageBeforeUpdate { get; set; }

        /// <summary>
        /// UsageAfterUpdate (boolean type in Salesforce)
        /// </summary>
        public bool? UsageAfterUpdate { get; set; }

        /// <summary>
        /// UsageBeforeDelete (boolean type in Salesforce)
        /// </summary>
        public bool? UsageBeforeDelete { get; set; }

        /// <summary>
        /// UsageAfterDelete (boolean type in Salesforce)
        /// </summary>
        public bool? UsageAfterDelete { get; set; }

        /// <summary>
        /// UsageIsBulk (boolean type in Salesforce)
        /// </summary>
        public bool? UsageIsBulk { get; set; }

        /// <summary>
        /// UsageAfterUndelete (boolean type in Salesforce)
        /// </summary>
        public bool? UsageAfterUndelete { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// IsValid (boolean type in Salesforce)
        /// </summary>
        public bool? IsValid { get; set; }

        /// <summary>
        /// BodyCrc (double type in Salesforce)
        /// </summary>
        public string BodyCrc { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000000)]
        public string Body { get; set; }

        /// <summary>
        /// LengthWithoutComments (int type in Salesforce)
        /// </summary>
        public string LengthWithoutComments { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for AppMenuItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AppMenuItem/describe", SObject = "/services/data/v29.0/sobjects/AppMenuItem", RowTemplate = "/services/data/v29.0/sobjects/AppMenuItem/{ID}")]
    public partial class AppMenuItem
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        [StringLength(250)]
        public string Label { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(250)]
        public string Description { get; set; }

        /// <summary>
        /// StartUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string StartUrl { get; set; }

        /// <summary>
        /// MobileStartUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileStartUrl { get; set; }

        /// <summary>
        /// LogoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// IconUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string IconUrl { get; set; }

        /// <summary>
        /// InfoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string InfoUrl { get; set; }

        /// <summary>
        /// IsUsingAdminAuthorization (boolean type in Salesforce)
        /// </summary>
        public bool? IsUsingAdminAuthorization { get; set; }

        /// <summary>
        /// MobilePlatform (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobilePlatform { get; set; }

        /// <summary>
        /// MobileMinOsVer (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileMinOsVer { get; set; }

        /// <summary>
        /// MobileDeviceType (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileDeviceType { get; set; }

        /// <summary>
        /// IsRegisteredDeviceOnly (boolean type in Salesforce)
        /// </summary>
        public bool? IsRegisteredDeviceOnly { get; set; }

        /// <summary>
        /// MobileAppVer (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileAppVer { get; set; }

        /// <summary>
        /// MobileAppInstalledDate (datetime type in Salesforce)
        /// </summary>
        public string MobileAppInstalledDate { get; set; }

        /// <summary>
        /// MobileAppInstalledVersion (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileAppInstalledVersion { get; set; }

        /// <summary>
        /// MobileAppBinaryId (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileAppBinaryId { get; set; }

        /// <summary>
        /// MobileAppInstallUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MobileAppInstallUrl { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Type { get; set; }

    }

    /// <summary>
    /// POCO for Approval
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Approval/describe", SObject = "/services/data/v29.0/sobjects/Approval", RowTemplate = "/services/data/v29.0/sobjects/Approval/{ID}")]
    public partial class Approval
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// RequestComment (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string RequestComment { get; set; }

        /// <summary>
        /// ApproveComment (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Asset
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Asset/describe", SObject = "/services/data/v29.0/sobjects/Asset", RowTemplate = "/services/data/v29.0/sobjects/Asset/{ID}")]
    public partial class Asset
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// Product2Id (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Product2Id { get; set; }

        /// <summary>
        /// IsCompetitorProduct (boolean type in Salesforce)
        /// </summary>
        public bool? IsCompetitorProduct { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// SerialNumber (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// InstallDate (date type in Salesforce)
        /// </summary>
        public string InstallDate { get; set; }

        /// <summary>
        /// PurchaseDate (date type in Salesforce)
        /// </summary>
        public string PurchaseDate { get; set; }

        /// <summary>
        /// UsageEndDate (date type in Salesforce)
        /// </summary>
        public string UsageEndDate { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
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
        [StringLength(32000)]
        public string Description { get; set; }

    }

    /// <summary>
    /// POCO for AssetFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AssetFeed/describe", SObject = "/services/data/v29.0/sobjects/AssetFeed", RowTemplate = "/services/data/v29.0/sobjects/AssetFeed/{ID}")]
    public partial class AssetFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for AssignmentRule
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AssignmentRule/describe", SObject = "/services/data/v29.0/sobjects/AssignmentRule", RowTemplate = "/services/data/v29.0/sobjects/AssignmentRule/{ID}")]
    public partial class AssignmentRule
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// SobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SobjectType { get; set; }

        /// <summary>
        /// Active (boolean type in Salesforce)
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for AsyncApexJob
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AsyncApexJob/describe", SObject = "/services/data/v29.0/sobjects/AsyncApexJob", RowTemplate = "/services/data/v29.0/sobjects/AsyncApexJob/{ID}")]
    public partial class AsyncApexJob
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// JobType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string JobType { get; set; }

        /// <summary>
        /// ApexClassId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ApexClassId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// JobItemsProcessed (int type in Salesforce)
        /// </summary>
        public string JobItemsProcessed { get; set; }

        /// <summary>
        /// TotalJobItems (int type in Salesforce)
        /// </summary>
        public string TotalJobItems { get; set; }

        /// <summary>
        /// NumberOfErrors (int type in Salesforce)
        /// </summary>
        public string NumberOfErrors { get; set; }

        /// <summary>
        /// CompletedDate (datetime type in Salesforce)
        /// </summary>
        public string CompletedDate { get; set; }

        /// <summary>
        /// MethodName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MethodName { get; set; }

        /// <summary>
        /// ExtendedStatus (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ExtendedStatus { get; set; }

        /// <summary>
        /// ParentJobId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentJobId { get; set; }

        /// <summary>
        /// LastProcessed (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string LastProcessed { get; set; }

        /// <summary>
        /// LastProcessedOffset (int type in Salesforce)
        /// </summary>
        public string LastProcessedOffset { get; set; }

    }

    /// <summary>
    /// POCO for AttachedContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AttachedContentDocument/describe", SObject = "/services/data/v29.0/sobjects/AttachedContentDocument", RowTemplate = "/services/data/v29.0/sobjects/AttachedContentDocument/{ID}")]
    public partial class AttachedContentDocument
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LinkedEntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LinkedEntityId { get; set; }

        /// <summary>
        /// ContentDocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentDocumentId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

    }

    /// <summary>
    /// POCO for Attachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Attachment/describe", SObject = "/services/data/v29.0/sobjects/Attachment", RowTemplate = "/services/data/v29.0/sobjects/Attachment/{ID}")]
    public partial class Attachment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// IsPrivate (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// BodyLength (int type in Salesforce)
        /// </summary>
        public string BodyLength { get; set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(500)]
        public string Description { get; set; }

    }

    /// <summary>
    /// POCO for AuthProvider
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AuthProvider/describe", SObject = "/services/data/v29.0/sobjects/AuthProvider", RowTemplate = "/services/data/v29.0/sobjects/AuthProvider/{ID}")]
    public partial class AuthProvider
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// ProviderType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ProviderType { get; set; }

        /// <summary>
        /// FriendlyName (string type in Salesforce)
        /// </summary>
        [StringLength(32)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(32)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// RegistrationHandlerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RegistrationHandlerId { get; set; }

        /// <summary>
        /// ExecutionUserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ExecutionUserId { get; set; }

        /// <summary>
        /// ConsumerKey (string type in Salesforce)
        /// </summary>
        [StringLength(256)]
        public string ConsumerKey { get; set; }

        /// <summary>
        /// ConsumerSecret (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string ConsumerSecret { get; set; }

        /// <summary>
        /// ErrorUrl (string type in Salesforce)
        /// </summary>
        [StringLength(500)]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// AuthorizeUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// TokenUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// UserInfoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string UserInfoUrl { get; set; }

        /// <summary>
        /// DefaultScopes (string type in Salesforce)
        /// </summary>
        [StringLength(256)]
        public string DefaultScopes { get; set; }

    }

    /// <summary>
    /// POCO for AuthSession
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AuthSession/describe", SObject = "/services/data/v29.0/sobjects/AuthSession", RowTemplate = "/services/data/v29.0/sobjects/AuthSession/{ID}")]
    public partial class AuthSession
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UsersId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UsersId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// NumSecondsValid (int type in Salesforce)
        /// </summary>
        public string NumSecondsValid { get; set; }

        /// <summary>
        /// UserType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UserType { get; set; }

        /// <summary>
        /// SourceIp (string type in Salesforce)
        /// </summary>
        [StringLength(39)]
        public string SourceIp { get; set; }

        /// <summary>
        /// LoginType (picklist type in Salesforce)
        /// </summary>
        [StringLength(1)]
        public string LoginType { get; set; }

        /// <summary>
        /// SessionType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SessionType { get; set; }

        /// <summary>
        /// SessionSecurityLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SessionSecurityLevel { get; set; }

    }

    /// <summary>
    /// POCO for BrandTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BrandTemplate/describe", SObject = "/services/data/v29.0/sobjects/BrandTemplate", RowTemplate = "/services/data/v29.0/sobjects/BrandTemplate/{ID}")]
    public partial class BrandTemplate
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Value (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Value { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for BusinessHours
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BusinessHours/describe", SObject = "/services/data/v29.0/sobjects/BusinessHours", RowTemplate = "/services/data/v29.0/sobjects/BusinessHours/{ID}")]
    public partial class BusinessHours
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// SundayStartTime (time type in Salesforce)
        /// </summary>
        public string SundayStartTime { get; set; }

        /// <summary>
        /// SundayEndTime (time type in Salesforce)
        /// </summary>
        public string SundayEndTime { get; set; }

        /// <summary>
        /// MondayStartTime (time type in Salesforce)
        /// </summary>
        public string MondayStartTime { get; set; }

        /// <summary>
        /// MondayEndTime (time type in Salesforce)
        /// </summary>
        public string MondayEndTime { get; set; }

        /// <summary>
        /// TuesdayStartTime (time type in Salesforce)
        /// </summary>
        public string TuesdayStartTime { get; set; }

        /// <summary>
        /// TuesdayEndTime (time type in Salesforce)
        /// </summary>
        public string TuesdayEndTime { get; set; }

        /// <summary>
        /// WednesdayStartTime (time type in Salesforce)
        /// </summary>
        public string WednesdayStartTime { get; set; }

        /// <summary>
        /// WednesdayEndTime (time type in Salesforce)
        /// </summary>
        public string WednesdayEndTime { get; set; }

        /// <summary>
        /// ThursdayStartTime (time type in Salesforce)
        /// </summary>
        public string ThursdayStartTime { get; set; }

        /// <summary>
        /// ThursdayEndTime (time type in Salesforce)
        /// </summary>
        public string ThursdayEndTime { get; set; }

        /// <summary>
        /// FridayStartTime (time type in Salesforce)
        /// </summary>
        public string FridayStartTime { get; set; }

        /// <summary>
        /// FridayEndTime (time type in Salesforce)
        /// </summary>
        public string FridayEndTime { get; set; }

        /// <summary>
        /// SaturdayStartTime (time type in Salesforce)
        /// </summary>
        public string SaturdayStartTime { get; set; }

        /// <summary>
        /// SaturdayEndTime (time type in Salesforce)
        /// </summary>
        public string SaturdayEndTime { get; set; }

        /// <summary>
        /// TimeZoneSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TimeZoneSidKey { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for BusinessProcess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BusinessProcess/describe", SObject = "/services/data/v29.0/sobjects/BusinessProcess", RowTemplate = "/services/data/v29.0/sobjects/BusinessProcess/{ID}")]
    public partial class BusinessProcess
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// TableEnumOrId (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TableEnumOrId { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CallCenter
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CallCenter/describe", SObject = "/services/data/v29.0/sobjects/CallCenter", RowTemplate = "/services/data/v29.0/sobjects/CallCenter/{ID}")]
    public partial class CallCenter
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// InternalName (string type in Salesforce)
        /// </summary>
        [StringLength(240)]
        public string InternalName { get; set; }

        /// <summary>
        /// Version (double type in Salesforce)
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// AdapterUrl (string type in Salesforce)
        /// </summary>
        [StringLength(2000)]
        public string AdapterUrl { get; set; }

        /// <summary>
        /// CustomSettings (string type in Salesforce)
        /// </summary>
        [StringLength(3000)]
        public string CustomSettings { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for Campaign
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Campaign/describe", SObject = "/services/data/v29.0/sobjects/Campaign", RowTemplate = "/services/data/v29.0/sobjects/Campaign/{ID}")]
    public partial class Campaign
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// StartDate (date type in Salesforce)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate (date type in Salesforce)
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// ExpectedRevenue (currency type in Salesforce)
        /// </summary>
        public string ExpectedRevenue { get; set; }

        /// <summary>
        /// BudgetedCost (currency type in Salesforce)
        /// </summary>
        public string BudgetedCost { get; set; }

        /// <summary>
        /// ActualCost (currency type in Salesforce)
        /// </summary>
        public string ActualCost { get; set; }

        /// <summary>
        /// ExpectedResponse (percent type in Salesforce)
        /// </summary>
        public string ExpectedResponse { get; set; }

        /// <summary>
        /// NumberSent (double type in Salesforce)
        /// </summary>
        public string NumberSent { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// NumberOfLeads (int type in Salesforce)
        /// </summary>
        public string NumberOfLeads { get; set; }

        /// <summary>
        /// NumberOfConvertedLeads (int type in Salesforce)
        /// </summary>
        public string NumberOfConvertedLeads { get; set; }

        /// <summary>
        /// NumberOfContacts (int type in Salesforce)
        /// </summary>
        public string NumberOfContacts { get; set; }

        /// <summary>
        /// NumberOfResponses (int type in Salesforce)
        /// </summary>
        public string NumberOfResponses { get; set; }

        /// <summary>
        /// NumberOfOpportunities (int type in Salesforce)
        /// </summary>
        public string NumberOfOpportunities { get; set; }

        /// <summary>
        /// NumberOfWonOpportunities (int type in Salesforce)
        /// </summary>
        public string NumberOfWonOpportunities { get; set; }

        /// <summary>
        /// AmountAllOpportunities (currency type in Salesforce)
        /// </summary>
        public string AmountAllOpportunities { get; set; }

        /// <summary>
        /// AmountWonOpportunities (currency type in Salesforce)
        /// </summary>
        public string AmountWonOpportunities { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// CampaignMemberRecordTypeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CampaignMemberRecordTypeId { get; set; }

    }

    /// <summary>
    /// POCO for CampaignFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignFeed/describe", SObject = "/services/data/v29.0/sobjects/CampaignFeed", RowTemplate = "/services/data/v29.0/sobjects/CampaignFeed/{ID}")]
    public partial class CampaignFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for CampaignMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignMember/describe", SObject = "/services/data/v29.0/sobjects/CampaignMember", RowTemplate = "/services/data/v29.0/sobjects/CampaignMember/{ID}")]
    public partial class CampaignMember
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CampaignId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// LeadId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LeadId { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// HasResponded (boolean type in Salesforce)
        /// </summary>
        public bool? HasResponded { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// FirstRespondedDate (date type in Salesforce)
        /// </summary>
        public string FirstRespondedDate { get; set; }

    }

    /// <summary>
    /// POCO for CampaignMemberStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignMemberStatus/describe", SObject = "/services/data/v29.0/sobjects/CampaignMemberStatus", RowTemplate = "/services/data/v29.0/sobjects/CampaignMemberStatus/{ID}")]
    public partial class CampaignMemberStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CampaignId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        [StringLength(765)]
        public string Label { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// HasResponded (boolean type in Salesforce)
        /// </summary>
        public bool? HasResponded { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CampaignShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignShare/describe", SObject = "/services/data/v29.0/sobjects/CampaignShare", RowTemplate = "/services/data/v29.0/sobjects/CampaignShare/{ID}")]
    public partial class CampaignShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CampaignId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// CampaignAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CampaignAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for Case
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Case/describe", SObject = "/services/data/v29.0/sobjects/Case", RowTemplate = "/services/data/v29.0/sobjects/Case/{ID}")]
    public partial class Case
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CaseNumber (string type in Salesforce)
        /// </summary>
        [StringLength(30)]
        public string CaseNumber { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// AssetId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AssetId { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SuppliedName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SuppliedName { get; set; }

        /// <summary>
        /// SuppliedEmail (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SuppliedEmail { get; set; }

        /// <summary>
        /// SuppliedPhone (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SuppliedPhone { get; set; }

        /// <summary>
        /// SuppliedCompany (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SuppliedCompany { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Reason (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Reason { get; set; }

        /// <summary>
        /// Origin (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Origin { get; set; }

        /// <summary>
        /// Subject (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// ClosedDate (datetime type in Salesforce)
        /// </summary>
        public string ClosedDate { get; set; }

        /// <summary>
        /// IsEscalated (boolean type in Salesforce)
        /// </summary>
        public bool? IsEscalated { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// EngineeringReqNumber__c (string type in Salesforce)
        /// </summary>
        [StringLength(12)]
        public string EngineeringReqNumber__c { get; set; }

        /// <summary>
        /// SLAViolation__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string SLAViolation__c { get; set; }

        /// <summary>
        /// Product__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Product__c { get; set; }

        /// <summary>
        /// PotentialLiability__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string PotentialLiability__c { get; set; }

    }

    /// <summary>
    /// POCO for CaseComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseComment/describe", SObject = "/services/data/v29.0/sobjects/CaseComment", RowTemplate = "/services/data/v29.0/sobjects/CaseComment/{ID}")]
    public partial class CaseComment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// IsPublished (boolean type in Salesforce)
        /// </summary>
        public bool? IsPublished { get; set; }

        /// <summary>
        /// CommentBody (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string CommentBody { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for CaseContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseContactRole/describe", SObject = "/services/data/v29.0/sobjects/CaseContactRole", RowTemplate = "/services/data/v29.0/sobjects/CaseContactRole/{ID}")]
    public partial class CaseContactRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CasesId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CasesId { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for CaseFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseFeed/describe", SObject = "/services/data/v29.0/sobjects/CaseFeed", RowTemplate = "/services/data/v29.0/sobjects/CaseFeed/{ID}")]
    public partial class CaseFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for CaseHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseHistory/describe", SObject = "/services/data/v29.0/sobjects/CaseHistory", RowTemplate = "/services/data/v29.0/sobjects/CaseHistory/{ID}")]
    public partial class CaseHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CaseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CaseId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for CaseShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseShare/describe", SObject = "/services/data/v29.0/sobjects/CaseShare", RowTemplate = "/services/data/v29.0/sobjects/CaseShare/{ID}")]
    public partial class CaseShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CaseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CaseId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// CaseAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CaseAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for CaseSolution
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseSolution/describe", SObject = "/services/data/v29.0/sobjects/CaseSolution", RowTemplate = "/services/data/v29.0/sobjects/CaseSolution/{ID}")]
    public partial class CaseSolution
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CaseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CaseId { get; set; }

        /// <summary>
        /// SolutionId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SolutionId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for CaseStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseStatus/describe", SObject = "/services/data/v29.0/sobjects/CaseStatus", RowTemplate = "/services/data/v29.0/sobjects/CaseStatus/{ID}")]
    public partial class CaseStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CaseTeamMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamMember/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamMember", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamMember/{ID}")]
    public partial class CaseTeamMember
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// MemberId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MemberId { get; set; }

        /// <summary>
        /// TeamTemplateMemberId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TeamTemplateMemberId { get; set; }

        /// <summary>
        /// TeamRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TeamRoleId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CaseTeamRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamRole/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamRole", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamRole/{ID}")]
    public partial class CaseTeamRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// AccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// PreferencesVisibleInCSP (boolean type in Salesforce)
        /// </summary>
        public bool? PreferencesVisibleInCSP { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplate/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplate", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplate/{ID}")]
    public partial class CaseTeamTemplate
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(300)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplateMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplateMember/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplateMember", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplateMember/{ID}")]
    public partial class CaseTeamTemplateMember
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// TeamTemplateId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TeamTemplateId { get; set; }

        /// <summary>
        /// MemberId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MemberId { get; set; }

        /// <summary>
        /// TeamRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TeamRoleId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CaseTeamTemplateRecord
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord/{ID}")]
    public partial class CaseTeamTemplateRecord
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// TeamTemplateId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TeamTemplateId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CategoryData
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CategoryData/describe", SObject = "/services/data/v29.0/sobjects/CategoryData", RowTemplate = "/services/data/v29.0/sobjects/CategoryData/{ID}")]
    public partial class CategoryData
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CategoryNodeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CategoryNodeId { get; set; }

        /// <summary>
        /// RelatedSobjectId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedSobjectId { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CategoryNode
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CategoryNode/describe", SObject = "/services/data/v29.0/sobjects/CategoryNode", RowTemplate = "/services/data/v29.0/sobjects/CategoryNode/{ID}")]
    public partial class CategoryNode
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// SortStyle (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SortStyle { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ChatterActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ChatterActivity/describe", SObject = "/services/data/v29.0/sobjects/ChatterActivity", RowTemplate = "/services/data/v29.0/sobjects/ChatterActivity/{ID}")]
    public partial class ChatterActivity
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// PostCount (int type in Salesforce)
        /// </summary>
        public string PostCount { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// CommentReceivedCount (int type in Salesforce)
        /// </summary>
        public string CommentReceivedCount { get; set; }

        /// <summary>
        /// LikeReceivedCount (int type in Salesforce)
        /// </summary>
        public string LikeReceivedCount { get; set; }

        /// <summary>
        /// InfluenceRawRank (int type in Salesforce)
        /// </summary>
        public string InfluenceRawRank { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ClientBrowser
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ClientBrowser/describe", SObject = "/services/data/v29.0/sobjects/ClientBrowser", RowTemplate = "/services/data/v29.0/sobjects/ClientBrowser/{ID}")]
    public partial class ClientBrowser
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UsersId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UsersId { get; set; }

        /// <summary>
        /// FullUserAgent (string type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string FullUserAgent { get; set; }

        /// <summary>
        /// ProxyInfo (string type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string ProxyInfo { get; set; }

        /// <summary>
        /// LastUpdate (datetime type in Salesforce)
        /// </summary>
        public string LastUpdate { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationGroup
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroup/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroup", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroup/{ID}")]
    public partial class CollaborationGroup
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// MemberCount (int type in Salesforce)
        /// </summary>
        public string MemberCount { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CollaborationType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CollaborationType { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// FullPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string FullPhotoUrl { get; set; }

        /// <summary>
        /// SmallPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string SmallPhotoUrl { get; set; }

        /// <summary>
        /// LastFeedModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastFeedModifiedDate { get; set; }

        /// <summary>
        /// InformationTitle (string type in Salesforce)
        /// </summary>
        [StringLength(30)]
        public string InformationTitle { get; set; }

        /// <summary>
        /// InformationBody (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string InformationBody { get; set; }

        /// <summary>
        /// HasPrivateFieldsAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasPrivateFieldsAccess { get; set; }

        /// <summary>
        /// CanHaveGuests (boolean type in Salesforce)
        /// </summary>
        public bool? CanHaveGuests { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// IsArchived (boolean type in Salesforce)
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// IsAutoArchiveDisabled (boolean type in Salesforce)
        /// </summary>
        public bool? IsAutoArchiveDisabled { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupFeed/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupFeed", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupFeed/{ID}")]
    public partial class CollaborationGroupFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupMember/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupMember", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupMember/{ID}")]
    public partial class CollaborationGroupMember
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CollaborationGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// MemberId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MemberId { get; set; }

        /// <summary>
        /// CollaborationRole (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CollaborationRole { get; set; }

        /// <summary>
        /// NotificationFrequency (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string NotificationFrequency { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationGroupMemberRequest
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest/{ID}")]
    public partial class CollaborationGroupMemberRequest
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CollaborationGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// RequesterId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RequesterId { get; set; }

        /// <summary>
        /// ResponseMessage (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CollaborationInvitation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationInvitation/describe", SObject = "/services/data/v29.0/sobjects/CollaborationInvitation", RowTemplate = "/services/data/v29.0/sobjects/CollaborationInvitation/{ID}")]
    public partial class CollaborationInvitation
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SharedEntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SharedEntityId { get; set; }

        /// <summary>
        /// InviterId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InviterId { get; set; }

        /// <summary>
        /// InvitedUserEmail (string type in Salesforce)
        /// </summary>
        [StringLength(240)]
        public string InvitedUserEmail { get; set; }

        /// <summary>
        /// InvitedUserEmailNormalized (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string InvitedUserEmailNormalized { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// OptionalMessage (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OptionalMessage { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CombinedAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CombinedAttachment/describe", SObject = "/services/data/v29.0/sobjects/CombinedAttachment", RowTemplate = "/services/data/v29.0/sobjects/CombinedAttachment/{ID}")]
    public partial class CombinedAttachment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// RecordType (string type in Salesforce)
        /// </summary>
        [StringLength(30)]
        public string RecordType { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for Community
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Community/describe", SObject = "/services/data/v29.0/sobjects/Community", RowTemplate = "/services/data/v29.0/sobjects/Community/{ID}")]
    public partial class Community
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

    }

    /// <summary>
    /// POCO for Contact
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Contact/describe", SObject = "/services/data/v29.0/sobjects/Contact", RowTemplate = "/services/data/v29.0/sobjects/Contact/{ID}")]
    public partial class Contact
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// MasterRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MasterRecordId { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Salutation (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Salutation { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string Name { get; set; }

        /// <summary>
        /// OtherStreet (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OtherStreet { get; set; }

        /// <summary>
        /// OtherCity (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OtherCity { get; set; }

        /// <summary>
        /// OtherState (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string OtherState { get; set; }

        /// <summary>
        /// OtherPostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string OtherPostalCode { get; set; }

        /// <summary>
        /// OtherCountry (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string OtherCountry { get; set; }

        /// <summary>
        /// OtherLatitude (double type in Salesforce)
        /// </summary>
        public string OtherLatitude { get; set; }

        /// <summary>
        /// OtherLongitude (double type in Salesforce)
        /// </summary>
        public string OtherLongitude { get; set; }

        /// <summary>
        /// MailingStreet (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MailingStreet { get; set; }

        /// <summary>
        /// MailingCity (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MailingCity { get; set; }

        /// <summary>
        /// MailingState (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string MailingState { get; set; }

        /// <summary>
        /// MailingPostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// MailingCountry (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// MailingLatitude (double type in Salesforce)
        /// </summary>
        public string MailingLatitude { get; set; }

        /// <summary>
        /// MailingLongitude (double type in Salesforce)
        /// </summary>
        public string MailingLongitude { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// MobilePhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// HomePhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string HomePhone { get; set; }

        /// <summary>
        /// OtherPhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OtherPhone { get; set; }

        /// <summary>
        /// AssistantPhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AssistantPhone { get; set; }

        /// <summary>
        /// ReportsToId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ReportsToId { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Title { get; set; }

        /// <summary>
        /// Department (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Department { get; set; }

        /// <summary>
        /// AssistantName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AssistantName { get; set; }

        /// <summary>
        /// LeadSource (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LeadSource { get; set; }

        /// <summary>
        /// Birthdate (date type in Salesforce)
        /// </summary>
        public string Birthdate { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// LastCURequestDate (datetime type in Salesforce)
        /// </summary>
        public string LastCURequestDate { get; set; }

        /// <summary>
        /// LastCUUpdateDate (datetime type in Salesforce)
        /// </summary>
        public string LastCUUpdateDate { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// EmailBouncedReason (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string EmailBouncedReason { get; set; }

        /// <summary>
        /// EmailBouncedDate (datetime type in Salesforce)
        /// </summary>
        public string EmailBouncedDate { get; set; }

        /// <summary>
        /// IsEmailBounced (boolean type in Salesforce)
        /// </summary>
        public bool? IsEmailBounced { get; set; }

        /// <summary>
        /// Jigsaw (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string Jigsaw { get; set; }

        /// <summary>
        /// JigsawContactId (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string JigsawContactId { get; set; }

        /// <summary>
        /// Level__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Level__c { get; set; }

        /// <summary>
        /// Languages__c (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string Languages__c { get; set; }

    }

    /// <summary>
    /// POCO for ContactFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactFeed/describe", SObject = "/services/data/v29.0/sobjects/ContactFeed", RowTemplate = "/services/data/v29.0/sobjects/ContactFeed/{ID}")]
    public partial class ContactFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for ContactHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactHistory/describe", SObject = "/services/data/v29.0/sobjects/ContactHistory", RowTemplate = "/services/data/v29.0/sobjects/ContactHistory/{ID}")]
    public partial class ContactHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for ContactShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactShare/describe", SObject = "/services/data/v29.0/sobjects/ContactShare", RowTemplate = "/services/data/v29.0/sobjects/ContactShare/{ID}")]
    public partial class ContactShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// ContactAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ContactAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for ContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocument/describe", SObject = "/services/data/v29.0/sobjects/ContentDocument", RowTemplate = "/services/data/v29.0/sobjects/ContentDocument/{ID}")]
    public partial class ContentDocument
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// IsArchived (boolean type in Salesforce)
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// ArchivedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ArchivedById { get; set; }

        /// <summary>
        /// ArchivedDate (date type in Salesforce)
        /// </summary>
        public string ArchivedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// PublishStatus (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PublishStatus { get; set; }

        /// <summary>
        /// LatestPublishedVersionId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LatestPublishedVersionId { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for ContentDocumentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentFeed/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentFeed", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentFeed/{ID}")]
    public partial class ContentDocumentFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for ContentDocumentHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentHistory/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentHistory", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentHistory/{ID}")]
    public partial class ContentDocumentHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContentDocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentDocumentId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for ContentDocumentLink
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentLink/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentLink", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentLink/{ID}")]
    public partial class ContentDocumentLink
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// LinkedEntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LinkedEntityId { get; set; }

        /// <summary>
        /// ContentDocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentDocumentId { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// ShareType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ShareType { get; set; }

    }

    /// <summary>
    /// POCO for ContentVersion
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentVersion/describe", SObject = "/services/data/v29.0/sobjects/ContentVersion", RowTemplate = "/services/data/v29.0/sobjects/ContentVersion/{ID}")]
    public partial class ContentVersion
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ContentDocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentDocumentId { get; set; }

        /// <summary>
        /// IsLatest (boolean type in Salesforce)
        /// </summary>
        public bool? IsLatest { get; set; }

        /// <summary>
        /// ContentUrl (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentUrl { get; set; }

        /// <summary>
        /// VersionNumber (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string VersionNumber { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// ReasonForChange (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ReasonForChange { get; set; }

        /// <summary>
        /// PathOnClient (string type in Salesforce)
        /// </summary>
        [StringLength(500)]
        public string PathOnClient { get; set; }

        /// <summary>
        /// RatingCount (int type in Salesforce)
        /// </summary>
        public string RatingCount { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContentModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string ContentModifiedDate { get; set; }

        /// <summary>
        /// ContentModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentModifiedById { get; set; }

        /// <summary>
        /// PositiveRatingCount (int type in Salesforce)
        /// </summary>
        public string PositiveRatingCount { get; set; }

        /// <summary>
        /// NegativeRatingCount (int type in Salesforce)
        /// </summary>
        public string NegativeRatingCount { get; set; }

        /// <summary>
        /// FeaturedContentBoost (int type in Salesforce)
        /// </summary>
        public string FeaturedContentBoost { get; set; }

        /// <summary>
        /// FeaturedContentDate (date type in Salesforce)
        /// </summary>
        public string FeaturedContentDate { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// TagCsv (textarea type in Salesforce)
        /// </summary>
        [StringLength(2000)]
        public string TagCsv { get; set; }

        /// <summary>
        /// FileType (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string FileType { get; set; }

        /// <summary>
        /// PublishStatus (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PublishStatus { get; set; }

        /// <summary>
        /// VersionData (base64 type in Salesforce)
        /// </summary>
        public string VersionData { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// FirstPublishLocationId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FirstPublishLocationId { get; set; }

        /// <summary>
        /// Origin (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Origin { get; set; }

        /// <summary>
        /// Checksum (string type in Salesforce)
        /// </summary>
        [StringLength(50)]
        public string Checksum { get; set; }

    }

    /// <summary>
    /// POCO for ContentVersionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentVersionHistory/describe", SObject = "/services/data/v29.0/sobjects/ContentVersionHistory", RowTemplate = "/services/data/v29.0/sobjects/ContentVersionHistory/{ID}")]
    public partial class ContentVersionHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContentVersionId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentVersionId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for ContentWorkspace
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentWorkspace/describe", SObject = "/services/data/v29.0/sobjects/ContentWorkspace", RowTemplate = "/services/data/v29.0/sobjects/ContentWorkspace/{ID}")]
    public partial class ContentWorkspace
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// TagModel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TagModel { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// DefaultRecordTypeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string DefaultRecordTypeId { get; set; }

        /// <summary>
        /// IsRestrictContentTypes (boolean type in Salesforce)
        /// </summary>
        public bool? IsRestrictContentTypes { get; set; }

        /// <summary>
        /// IsRestrictLinkedContentTypes (boolean type in Salesforce)
        /// </summary>
        public bool? IsRestrictLinkedContentTypes { get; set; }

    }

    /// <summary>
    /// POCO for ContentWorkspaceDoc
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentWorkspaceDoc/describe", SObject = "/services/data/v29.0/sobjects/ContentWorkspaceDoc", RowTemplate = "/services/data/v29.0/sobjects/ContentWorkspaceDoc/{ID}")]
    public partial class ContentWorkspaceDoc
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ContentWorkspaceId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentWorkspaceId { get; set; }

        /// <summary>
        /// ContentDocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContentDocumentId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsOwner (boolean type in Salesforce)
        /// </summary>
        public bool? IsOwner { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for Contract
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Contract/describe", SObject = "/services/data/v29.0/sobjects/Contract", RowTemplate = "/services/data/v29.0/sobjects/Contract/{ID}")]
    public partial class Contract
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// OwnerExpirationNotice (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OwnerExpirationNotice { get; set; }

        /// <summary>
        /// StartDate (date type in Salesforce)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate (date type in Salesforce)
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// BillingStreet (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string BillingStreet { get; set; }

        /// <summary>
        /// BillingCity (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string BillingCity { get; set; }

        /// <summary>
        /// BillingState (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string BillingState { get; set; }

        /// <summary>
        /// BillingPostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// BillingCountry (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string BillingCountry { get; set; }

        /// <summary>
        /// BillingLatitude (double type in Salesforce)
        /// </summary>
        public string BillingLatitude { get; set; }

        /// <summary>
        /// BillingLongitude (double type in Salesforce)
        /// </summary>
        public string BillingLongitude { get; set; }

        /// <summary>
        /// ContractTerm (int type in Salesforce)
        /// </summary>
        public string ContractTerm { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// CompanySignedId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CompanySignedId { get; set; }

        /// <summary>
        /// CompanySignedDate (date type in Salesforce)
        /// </summary>
        public string CompanySignedDate { get; set; }

        /// <summary>
        /// CustomerSignedId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CustomerSignedId { get; set; }

        /// <summary>
        /// CustomerSignedTitle (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CustomerSignedTitle { get; set; }

        /// <summary>
        /// CustomerSignedDate (date type in Salesforce)
        /// </summary>
        public string CustomerSignedDate { get; set; }

        /// <summary>
        /// SpecialTerms (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string SpecialTerms { get; set; }

        /// <summary>
        /// ActivatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ActivatedById { get; set; }

        /// <summary>
        /// ActivatedDate (datetime type in Salesforce)
        /// </summary>
        public string ActivatedDate { get; set; }

        /// <summary>
        /// StatusCode (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContractNumber (string type in Salesforce)
        /// </summary>
        [StringLength(30)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// LastApprovedDate (datetime type in Salesforce)
        /// </summary>
        public string LastApprovedDate { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for ContractContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractContactRole/describe", SObject = "/services/data/v29.0/sobjects/ContractContactRole", RowTemplate = "/services/data/v29.0/sobjects/ContractContactRole/{ID}")]
    public partial class ContractContactRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ContractId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContractId { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for ContractFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractFeed/describe", SObject = "/services/data/v29.0/sobjects/ContractFeed", RowTemplate = "/services/data/v29.0/sobjects/ContractFeed/{ID}")]
    public partial class ContractFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for ContractHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractHistory/describe", SObject = "/services/data/v29.0/sobjects/ContractHistory", RowTemplate = "/services/data/v29.0/sobjects/ContractHistory/{ID}")]
    public partial class ContractHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ContractId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContractId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for ContractStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractStatus/describe", SObject = "/services/data/v29.0/sobjects/ContractStatus", RowTemplate = "/services/data/v29.0/sobjects/ContractStatus/{ID}")]
    public partial class ContractStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// StatusCode (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StatusCode { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for CronJobDetail
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CronJobDetail/describe", SObject = "/services/data/v29.0/sobjects/CronJobDetail", RowTemplate = "/services/data/v29.0/sobjects/CronJobDetail/{ID}")]
    public partial class CronJobDetail
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// JobType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string JobType { get; set; }

    }

    /// <summary>
    /// POCO for CronTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CronTrigger/describe", SObject = "/services/data/v29.0/sobjects/CronTrigger", RowTemplate = "/services/data/v29.0/sobjects/CronTrigger/{ID}")]
    public partial class CronTrigger
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CronJobDetailId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CronJobDetailId { get; set; }

        /// <summary>
        /// NextFireTime (datetime type in Salesforce)
        /// </summary>
        public string NextFireTime { get; set; }

        /// <summary>
        /// PreviousFireTime (datetime type in Salesforce)
        /// </summary>
        public string PreviousFireTime { get; set; }

        /// <summary>
        /// State (string type in Salesforce)
        /// </summary>
        [StringLength(16)]
        public string State { get; set; }

        /// <summary>
        /// StartTime (datetime type in Salesforce)
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// EndTime (datetime type in Salesforce)
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// CronExpression (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CronExpression { get; set; }

        /// <summary>
        /// TimeZoneSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TimeZoneSidKey { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// TimesTriggered (int type in Salesforce)
        /// </summary>
        public string TimesTriggered { get; set; }

    }

    /// <summary>
    /// POCO for Dashboard
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Dashboard/describe", SObject = "/services/data/v29.0/sobjects/Dashboard", RowTemplate = "/services/data/v29.0/sobjects/Dashboard/{ID}")]
    public partial class Dashboard
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// FolderId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FolderId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// LeftSize (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LeftSize { get; set; }

        /// <summary>
        /// MiddleSize (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MiddleSize { get; set; }

        /// <summary>
        /// RightSize (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RightSize { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// RunningUserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RunningUserId { get; set; }

        /// <summary>
        /// TitleColor (int type in Salesforce)
        /// </summary>
        public string TitleColor { get; set; }

        /// <summary>
        /// TitleSize (int type in Salesforce)
        /// </summary>
        public string TitleSize { get; set; }

        /// <summary>
        /// TextColor (int type in Salesforce)
        /// </summary>
        public string TextColor { get; set; }

        /// <summary>
        /// BackgroundStart (int type in Salesforce)
        /// </summary>
        public string BackgroundStart { get; set; }

        /// <summary>
        /// BackgroundEnd (int type in Salesforce)
        /// </summary>
        public string BackgroundEnd { get; set; }

        /// <summary>
        /// BackgroundDirection (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string BackgroundDirection { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for DashboardComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardComponent/describe", SObject = "/services/data/v29.0/sobjects/DashboardComponent", RowTemplate = "/services/data/v29.0/sobjects/DashboardComponent/{ID}")]
    public partial class DashboardComponent
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// DashboardId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string DashboardId { get; set; }

    }

    /// <summary>
    /// POCO for DashboardComponentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardComponentFeed/describe", SObject = "/services/data/v29.0/sobjects/DashboardComponentFeed", RowTemplate = "/services/data/v29.0/sobjects/DashboardComponentFeed/{ID}")]
    public partial class DashboardComponentFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for DashboardFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardFeed/describe", SObject = "/services/data/v29.0/sobjects/DashboardFeed", RowTemplate = "/services/data/v29.0/sobjects/DashboardFeed/{ID}")]
    public partial class DashboardFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for DeclinedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DeclinedEventRelation/describe", SObject = "/services/data/v29.0/sobjects/DeclinedEventRelation", RowTemplate = "/services/data/v29.0/sobjects/DeclinedEventRelation/{ID}")]
    public partial class DeclinedEventRelation
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// RelationId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelationId { get; set; }

        /// <summary>
        /// EventId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string EventId { get; set; }

        /// <summary>
        /// RespondedDate (datetime type in Salesforce)
        /// </summary>
        public string RespondedDate { get; set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Response { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [StringLength(50)]
        public string Type { get; set; }

    }

    /// <summary>
    /// POCO for Document
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Document/describe", SObject = "/services/data/v29.0/sobjects/Document", RowTemplate = "/services/data/v29.0/sobjects/Document/{ID}")]
    public partial class Document
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FolderId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FolderId { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// IsPublic (boolean type in Salesforce)
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// BodyLength (int type in Salesforce)
        /// </summary>
        public string BodyLength { get; set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Url (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Url { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Keywords (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Keywords { get; set; }

        /// <summary>
        /// IsInternalUseOnly (boolean type in Salesforce)
        /// </summary>
        public bool? IsInternalUseOnly { get; set; }

        /// <summary>
        /// AuthorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AuthorId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsBodySearchable (boolean type in Salesforce)
        /// </summary>
        public bool? IsBodySearchable { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for DocumentAttachmentMap
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DocumentAttachmentMap/describe", SObject = "/services/data/v29.0/sobjects/DocumentAttachmentMap", RowTemplate = "/services/data/v29.0/sobjects/DocumentAttachmentMap/{ID}")]
    public partial class DocumentAttachmentMap
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// DocumentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string DocumentId { get; set; }

        /// <summary>
        /// DocumentSequence (int type in Salesforce)
        /// </summary>
        public string DocumentSequence { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

    }

    /// <summary>
    /// POCO for Domain
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Domain/describe", SObject = "/services/data/v29.0/sobjects/Domain", RowTemplate = "/services/data/v29.0/sobjects/Domain/{ID}")]
    public partial class Domain
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// DomainType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DomainType { get; set; }

        /// <summary>
        /// Domain (string type in Salesforce)
        /// </summary>
        [StringLength(765)]
        public string Domain2 { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for DomainSite
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DomainSite/describe", SObject = "/services/data/v29.0/sobjects/DomainSite", RowTemplate = "/services/data/v29.0/sobjects/DomainSite/{ID}")]
    public partial class DomainSite
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// DomainId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string DomainId { get; set; }

        /// <summary>
        /// SiteId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SiteId { get; set; }

        /// <summary>
        /// PathPrefix (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for EmailServicesAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailServicesAddress/describe", SObject = "/services/data/v29.0/sobjects/EmailServicesAddress", RowTemplate = "/services/data/v29.0/sobjects/EmailServicesAddress/{ID}")]
    public partial class EmailServicesAddress
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// LocalPart (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string LocalPart { get; set; }

        /// <summary>
        /// EmailDomainName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string EmailDomainName { get; set; }

        /// <summary>
        /// AuthorizedSenders (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string AuthorizedSenders { get; set; }

        /// <summary>
        /// RunAsUserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RunAsUserId { get; set; }

        /// <summary>
        /// FunctionId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FunctionId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for EmailServicesFunction
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailServicesFunction/describe", SObject = "/services/data/v29.0/sobjects/EmailServicesFunction", RowTemplate = "/services/data/v29.0/sobjects/EmailServicesFunction/{ID}")]
    public partial class EmailServicesFunction
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// FunctionName (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string FunctionName { get; set; }

        /// <summary>
        /// AuthorizedSenders (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string AuthorizedSenders { get; set; }

        /// <summary>
        /// IsAuthenticationRequired (boolean type in Salesforce)
        /// </summary>
        public bool? IsAuthenticationRequired { get; set; }

        /// <summary>
        /// IsTlsRequired (boolean type in Salesforce)
        /// </summary>
        public bool? IsTlsRequired { get; set; }

        /// <summary>
        /// AttachmentOption (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AttachmentOption { get; set; }

        /// <summary>
        /// ApexClassId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ApexClassId { get; set; }

        /// <summary>
        /// OverLimitAction (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OverLimitAction { get; set; }

        /// <summary>
        /// FunctionInactiveAction (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FunctionInactiveAction { get; set; }

        /// <summary>
        /// AddressInactiveAction (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AddressInactiveAction { get; set; }

        /// <summary>
        /// AuthenticationFailureAction (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AuthenticationFailureAction { get; set; }

        /// <summary>
        /// AuthorizationFailureAction (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AuthorizationFailureAction { get; set; }

        /// <summary>
        /// IsErrorRoutingEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? IsErrorRoutingEnabled { get; set; }

        /// <summary>
        /// ErrorRoutingAddress (email type in Salesforce)
        /// </summary>
        [StringLength(270)]
        public string ErrorRoutingAddress { get; set; }

        /// <summary>
        /// IsTextAttachmentsAsBinary (boolean type in Salesforce)
        /// </summary>
        public bool? IsTextAttachmentsAsBinary { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for EmailStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailStatus/describe", SObject = "/services/data/v29.0/sobjects/EmailStatus", RowTemplate = "/services/data/v29.0/sobjects/EmailStatus/{ID}")]
    public partial class EmailStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// TaskId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TaskId { get; set; }

        /// <summary>
        /// WhoId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhoId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// TimesOpened (int type in Salesforce)
        /// </summary>
        public string TimesOpened { get; set; }

        /// <summary>
        /// FirstOpenDate (datetime type in Salesforce)
        /// </summary>
        public string FirstOpenDate { get; set; }

        /// <summary>
        /// LastOpenDate (datetime type in Salesforce)
        /// </summary>
        public string LastOpenDate { get; set; }

        /// <summary>
        /// EmailTemplateName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string EmailTemplateName { get; set; }

    }

    /// <summary>
    /// POCO for EmailTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailTemplate/describe", SObject = "/services/data/v29.0/sobjects/EmailTemplate", RowTemplate = "/services/data/v29.0/sobjects/EmailTemplate/{ID}")]
    public partial class EmailTemplate
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// FolderId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FolderId { get; set; }

        /// <summary>
        /// BrandTemplateId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// TemplateStyle (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TemplateStyle { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// TemplateType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Encoding (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Encoding { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// Subject (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// HtmlValue (textarea type in Salesforce)
        /// </summary>
        [StringLength(384000)]
        public string HtmlValue { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(384000)]
        public string Body { get; set; }

        /// <summary>
        /// TimesUsed (int type in Salesforce)
        /// </summary>
        public string TimesUsed { get; set; }

        /// <summary>
        /// LastUsedDate (datetime type in Salesforce)
        /// </summary>
        public string LastUsedDate { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Markup (textarea type in Salesforce)
        /// </summary>
        [StringLength(1048576)]
        public string Markup { get; set; }

    }

    /// <summary>
    /// POCO for EntitySubscription
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EntitySubscription/describe", SObject = "/services/data/v29.0/sobjects/EntitySubscription", RowTemplate = "/services/data/v29.0/sobjects/EntitySubscription/{ID}")]
    public partial class EntitySubscription
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SubscriberId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for Event
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Event/describe", SObject = "/services/data/v29.0/sobjects/Event", RowTemplate = "/services/data/v29.0/sobjects/Event/{ID}")]
    public partial class Event
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// WhoId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhoId { get; set; }

        /// <summary>
        /// WhatId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Location { get; set; }

        /// <summary>
        /// IsAllDayEvent (boolean type in Salesforce)
        /// </summary>
        public bool? IsAllDayEvent { get; set; }

        /// <summary>
        /// ActivityDateTime (datetime type in Salesforce)
        /// </summary>
        public string ActivityDateTime { get; set; }

        /// <summary>
        /// ActivityDate (date type in Salesforce)
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// DurationInMinutes (int type in Salesforce)
        /// </summary>
        public string DurationInMinutes { get; set; }

        /// <summary>
        /// StartDateTime (datetime type in Salesforce)
        /// </summary>
        public string StartDateTime { get; set; }

        /// <summary>
        /// EndDateTime (datetime type in Salesforce)
        /// </summary>
        public string EndDateTime { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// IsPrivate (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// ShowAs (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ShowAs { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// IsChild (boolean type in Salesforce)
        /// </summary>
        public bool? IsChild { get; set; }

        /// <summary>
        /// IsGroupEvent (boolean type in Salesforce)
        /// </summary>
        public bool? IsGroupEvent { get; set; }

        /// <summary>
        /// GroupEventType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string GroupEventType { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsArchived (boolean type in Salesforce)
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// RecurrenceActivityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RecurrenceActivityId { get; set; }

        /// <summary>
        /// IsRecurrence (boolean type in Salesforce)
        /// </summary>
        public bool? IsRecurrence { get; set; }

        /// <summary>
        /// RecurrenceStartDateTime (datetime type in Salesforce)
        /// </summary>
        public string RecurrenceStartDateTime { get; set; }

        /// <summary>
        /// RecurrenceEndDateOnly (date type in Salesforce)
        /// </summary>
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// RecurrenceTimeZoneSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceTimeZoneSidKey { get; set; }

        /// <summary>
        /// RecurrenceType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// RecurrenceInterval (int type in Salesforce)
        /// </summary>
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// RecurrenceDayOfWeekMask (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// RecurrenceDayOfMonth (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// RecurrenceInstance (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// RecurrenceMonthOfYear (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceMonthOfYear { get; set; }

        /// <summary>
        /// ReminderDateTime (datetime type in Salesforce)
        /// </summary>
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// IsReminderSet (boolean type in Salesforce)
        /// </summary>
        public bool? IsReminderSet { get; set; }

    }

    /// <summary>
    /// POCO for EventFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EventFeed/describe", SObject = "/services/data/v29.0/sobjects/EventFeed", RowTemplate = "/services/data/v29.0/sobjects/EventFeed/{ID}")]
    public partial class EventFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for EventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EventRelation/describe", SObject = "/services/data/v29.0/sobjects/EventRelation", RowTemplate = "/services/data/v29.0/sobjects/EventRelation/{ID}")]
    public partial class EventRelation
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// RelationId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelationId { get; set; }

        /// <summary>
        /// EventId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string EventId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// RespondedDate (datetime type in Salesforce)
        /// </summary>
        public string RespondedDate { get; set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Response { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for FeedComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedComment/describe", SObject = "/services/data/v29.0/sobjects/FeedComment", RowTemplate = "/services/data/v29.0/sobjects/FeedComment/{ID}")]
    public partial class FeedComment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FeedItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedItemId { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CommentBody (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string CommentBody { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

        /// <summary>
        /// CommentType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CommentType { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

    }

    /// <summary>
    /// POCO for FeedItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedItem/describe", SObject = "/services/data/v29.0/sobjects/FeedItem", RowTemplate = "/services/data/v29.0/sobjects/FeedItem/{ID}")]
    public partial class FeedItem
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for FeedLike
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedLike/describe", SObject = "/services/data/v29.0/sobjects/FeedLike", RowTemplate = "/services/data/v29.0/sobjects/FeedLike/{ID}")]
    public partial class FeedLike
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FeedItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedItemId { get; set; }

        /// <summary>
        /// FeedEntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedEntityId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for FeedPollChoice
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedPollChoice/describe", SObject = "/services/data/v29.0/sobjects/FeedPollChoice", RowTemplate = "/services/data/v29.0/sobjects/FeedPollChoice/{ID}")]
    public partial class FeedPollChoice
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FeedItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedItemId { get; set; }

        /// <summary>
        /// Position (int type in Salesforce)
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// ChoiceBody (textarea type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string ChoiceBody { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for FeedPollVote
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedPollVote/describe", SObject = "/services/data/v29.0/sobjects/FeedPollVote", RowTemplate = "/services/data/v29.0/sobjects/FeedPollVote/{ID}")]
    public partial class FeedPollVote
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FeedItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedItemId { get; set; }

        /// <summary>
        /// ChoiceId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ChoiceId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for FeedTrackedChange
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedTrackedChange/describe", SObject = "/services/data/v29.0/sobjects/FeedTrackedChange", RowTemplate = "/services/data/v29.0/sobjects/FeedTrackedChange/{ID}")]
    public partial class FeedTrackedChange
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FeedItemId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FeedItemId { get; set; }

        /// <summary>
        /// FieldName (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string FieldName { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for FieldPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FieldPermissions/describe", SObject = "/services/data/v29.0/sobjects/FieldPermissions", RowTemplate = "/services/data/v29.0/sobjects/FieldPermissions/{ID}")]
    public partial class FieldPermissions
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SobjectType { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Field { get; set; }

        /// <summary>
        /// PermissionsEdit (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEdit { get; set; }

        /// <summary>
        /// PermissionsRead (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRead { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for FiscalYearSettings
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FiscalYearSettings/describe", SObject = "/services/data/v29.0/sobjects/FiscalYearSettings", RowTemplate = "/services/data/v29.0/sobjects/FiscalYearSettings/{ID}")]
    public partial class FiscalYearSettings
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// PeriodId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PeriodId { get; set; }

        /// <summary>
        /// StartDate (date type in Salesforce)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate (date type in Salesforce)
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// IsStandardYear (boolean type in Salesforce)
        /// </summary>
        public bool? IsStandardYear { get; set; }

        /// <summary>
        /// YearType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string YearType { get; set; }

        /// <summary>
        /// QuarterLabelScheme (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string QuarterLabelScheme { get; set; }

        /// <summary>
        /// PeriodLabelScheme (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PeriodLabelScheme { get; set; }

        /// <summary>
        /// WeekLabelScheme (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string WeekLabelScheme { get; set; }

        /// <summary>
        /// QuarterPrefix (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string QuarterPrefix { get; set; }

        /// <summary>
        /// PeriodPrefix (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PeriodPrefix { get; set; }

        /// <summary>
        /// WeekStartDay (int type in Salesforce)
        /// </summary>
        public string WeekStartDay { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Folder
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Folder/describe", SObject = "/services/data/v29.0/sobjects/Folder", RowTemplate = "/services/data/v29.0/sobjects/Folder/{ID}")]
    public partial class Folder
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// AccessType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccessType { get; set; }

        /// <summary>
        /// IsReadonly (boolean type in Salesforce)
        /// </summary>
        public bool? IsReadonly { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ForecastShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ForecastShare/describe", SObject = "/services/data/v29.0/sobjects/ForecastShare", RowTemplate = "/services/data/v29.0/sobjects/ForecastShare/{ID}")]
    public partial class ForecastShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserRoleId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// AccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AccessLevel { get; set; }

        /// <summary>
        /// CanSubmit (boolean type in Salesforce)
        /// </summary>
        public bool? CanSubmit { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for Group
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Group/describe", SObject = "/services/data/v29.0/sobjects/Group", RowTemplate = "/services/data/v29.0/sobjects/Group/{ID}")]
    public partial class Group
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// RelatedId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Email { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// DoesSendEmailToMembers (boolean type in Salesforce)
        /// </summary>
        public bool? DoesSendEmailToMembers { get; set; }

        /// <summary>
        /// DoesIncludeBosses (boolean type in Salesforce)
        /// </summary>
        public bool? DoesIncludeBosses { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for GroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/GroupMember/describe", SObject = "/services/data/v29.0/sobjects/GroupMember", RowTemplate = "/services/data/v29.0/sobjects/GroupMember/{ID}")]
    public partial class GroupMember
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// GroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string GroupId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for HashtagDefinition
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/HashtagDefinition/describe", SObject = "/services/data/v29.0/sobjects/HashtagDefinition", RowTemplate = "/services/data/v29.0/sobjects/HashtagDefinition/{ID}")]
    public partial class HashtagDefinition
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NameNorm (string type in Salesforce)
        /// </summary>
        [StringLength(765)]
        public string NameNorm { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(765)]
        public string Name { get; set; }

        /// <summary>
        /// HashtagCount (int type in Salesforce)
        /// </summary>
        public string HashtagCount { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Holiday
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Holiday/describe", SObject = "/services/data/v29.0/sobjects/Holiday", RowTemplate = "/services/data/v29.0/sobjects/Holiday/{ID}")]
    public partial class Holiday
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// IsAllDay (boolean type in Salesforce)
        /// </summary>
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// ActivityDate (date type in Salesforce)
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// StartTimeInMinutes (int type in Salesforce)
        /// </summary>
        public string StartTimeInMinutes { get; set; }

        /// <summary>
        /// EndTimeInMinutes (int type in Salesforce)
        /// </summary>
        public string EndTimeInMinutes { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsRecurrence (boolean type in Salesforce)
        /// </summary>
        public bool? IsRecurrence { get; set; }

        /// <summary>
        /// RecurrenceStartDate (date type in Salesforce)
        /// </summary>
        public string RecurrenceStartDate { get; set; }

        /// <summary>
        /// RecurrenceEndDateOnly (date type in Salesforce)
        /// </summary>
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// RecurrenceType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// RecurrenceInterval (int type in Salesforce)
        /// </summary>
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// RecurrenceDayOfWeekMask (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// RecurrenceDayOfMonth (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// RecurrenceInstance (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// RecurrenceMonthOfYear (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceMonthOfYear { get; set; }

    }

    /// <summary>
    /// POCO for Idea
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Idea/describe", SObject = "/services/data/v29.0/sobjects/Idea", RowTemplate = "/services/data/v29.0/sobjects/Idea/{ID}")]
    public partial class Idea
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// RecordTypeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RecordTypeId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// CommunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CommunityId { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Body { get; set; }

        /// <summary>
        /// NumComments (int type in Salesforce)
        /// </summary>
        public string NumComments { get; set; }

        /// <summary>
        /// VoteScore (double type in Salesforce)
        /// </summary>
        public string VoteScore { get; set; }

        /// <summary>
        /// VoteTotal (double type in Salesforce)
        /// </summary>
        public string VoteTotal { get; set; }

        /// <summary>
        /// Categories (multipicklist type in Salesforce)
        /// </summary>
        [StringLength(4099)]
        public string Categories { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// LastCommentDate (datetime type in Salesforce)
        /// </summary>
        public string LastCommentDate { get; set; }

        /// <summary>
        /// LastCommentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastCommentId { get; set; }

        /// <summary>
        /// ParentIdeaId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentIdeaId { get; set; }

        /// <summary>
        /// IsHtml (boolean type in Salesforce)
        /// </summary>
        public bool? IsHtml { get; set; }

        /// <summary>
        /// IsMerged (boolean type in Salesforce)
        /// </summary>
        public bool? IsMerged { get; set; }

        /// <summary>
        /// CreatorFullPhotoUrl (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CreatorFullPhotoUrl { get; set; }

        /// <summary>
        /// CreatorSmallPhotoUrl (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CreatorSmallPhotoUrl { get; set; }

        /// <summary>
        /// CreatorName (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string CreatorName { get; set; }

    }

    /// <summary>
    /// POCO for IdeaComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/IdeaComment/describe", SObject = "/services/data/v29.0/sobjects/IdeaComment", RowTemplate = "/services/data/v29.0/sobjects/IdeaComment/{ID}")]
    public partial class IdeaComment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IdeaId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string IdeaId { get; set; }

        /// <summary>
        /// CommunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CommunityId { get; set; }

        /// <summary>
        /// CommentBody (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string CommentBody { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// IsHtml (boolean type in Salesforce)
        /// </summary>
        public bool? IsHtml { get; set; }

        /// <summary>
        /// CreatorFullPhotoUrl (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CreatorFullPhotoUrl { get; set; }

        /// <summary>
        /// CreatorSmallPhotoUrl (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CreatorSmallPhotoUrl { get; set; }

        /// <summary>
        /// CreatorName (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string CreatorName { get; set; }

        /// <summary>
        /// UpVotes (int type in Salesforce)
        /// </summary>
        public string UpVotes { get; set; }

    }

    /// <summary>
    /// POCO for Lead
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Lead/describe", SObject = "/services/data/v29.0/sobjects/Lead", RowTemplate = "/services/data/v29.0/sobjects/Lead/{ID}")]
    public partial class Lead
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// MasterRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string MasterRecordId { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Salutation (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Salutation { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string Name { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Title { get; set; }

        /// <summary>
        /// Company (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Company { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string State { get; set; }

        /// <summary>
        /// PostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
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
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// MobilePhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Website (url type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Website { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// LeadSource (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LeadSource { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Industry (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Industry { get; set; }

        /// <summary>
        /// Rating (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Rating { get; set; }

        /// <summary>
        /// AnnualRevenue (currency type in Salesforce)
        /// </summary>
        public string AnnualRevenue { get; set; }

        /// <summary>
        /// NumberOfEmployees (int type in Salesforce)
        /// </summary>
        public string NumberOfEmployees { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// IsConverted (boolean type in Salesforce)
        /// </summary>
        public bool? IsConverted { get; set; }

        /// <summary>
        /// ConvertedDate (date type in Salesforce)
        /// </summary>
        public string ConvertedDate { get; set; }

        /// <summary>
        /// ConvertedAccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ConvertedAccountId { get; set; }

        /// <summary>
        /// ConvertedContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ConvertedContactId { get; set; }

        /// <summary>
        /// ConvertedOpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ConvertedOpportunityId { get; set; }

        /// <summary>
        /// IsUnreadByOwner (boolean type in Salesforce)
        /// </summary>
        public bool? IsUnreadByOwner { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// Jigsaw (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string Jigsaw { get; set; }

        /// <summary>
        /// JigsawContactId (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string JigsawContactId { get; set; }

        /// <summary>
        /// EmailBouncedReason (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string EmailBouncedReason { get; set; }

        /// <summary>
        /// EmailBouncedDate (datetime type in Salesforce)
        /// </summary>
        public string EmailBouncedDate { get; set; }

        /// <summary>
        /// SICCode__c (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string SICCode__c { get; set; }

        /// <summary>
        /// ProductInterest__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ProductInterest__c { get; set; }

        /// <summary>
        /// Primary__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Primary__c { get; set; }

        /// <summary>
        /// CurrentGenerators__c (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        /// <summary>
        /// NumberofLocations__c (double type in Salesforce)
        /// </summary>
        public string NumberofLocations__c { get; set; }

    }

    /// <summary>
    /// POCO for LeadFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadFeed/describe", SObject = "/services/data/v29.0/sobjects/LeadFeed", RowTemplate = "/services/data/v29.0/sobjects/LeadFeed/{ID}")]
    public partial class LeadFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for LeadHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadHistory/describe", SObject = "/services/data/v29.0/sobjects/LeadHistory", RowTemplate = "/services/data/v29.0/sobjects/LeadHistory/{ID}")]
    public partial class LeadHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LeadId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LeadId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for LeadShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadShare/describe", SObject = "/services/data/v29.0/sobjects/LeadShare", RowTemplate = "/services/data/v29.0/sobjects/LeadShare/{ID}")]
    public partial class LeadShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// LeadId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LeadId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// LeadAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LeadAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for LeadStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadStatus/describe", SObject = "/services/data/v29.0/sobjects/LeadStatus", RowTemplate = "/services/data/v29.0/sobjects/LeadStatus/{ID}")]
    public partial class LeadStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// IsConverted (boolean type in Salesforce)
        /// </summary>
        public bool? IsConverted { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for LoginHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LoginHistory/describe", SObject = "/services/data/v29.0/sobjects/LoginHistory", RowTemplate = "/services/data/v29.0/sobjects/LoginHistory/{ID}")]
    public partial class LoginHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserId { get; set; }

        /// <summary>
        /// LoginTime (datetime type in Salesforce)
        /// </summary>
        public string LoginTime { get; set; }

        /// <summary>
        /// LoginType (picklist type in Salesforce)
        /// </summary>
        [StringLength(1)]
        public string LoginType { get; set; }

        /// <summary>
        /// SourceIp (string type in Salesforce)
        /// </summary>
        [StringLength(39)]
        public string SourceIp { get; set; }

        /// <summary>
        /// LoginUrl (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// Browser (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string Browser { get; set; }

        /// <summary>
        /// Platform (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string Platform { get; set; }

        /// <summary>
        /// Status (string type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Status { get; set; }

        /// <summary>
        /// Application (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string Application { get; set; }

        /// <summary>
        /// ClientVersion (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// ApiType (string type in Salesforce)
        /// </summary>
        [StringLength(64)]
        public string ApiType { get; set; }

        /// <summary>
        /// ApiVersion (string type in Salesforce)
        /// </summary>
        [StringLength(32)]
        public string ApiVersion { get; set; }

    }

    /// <summary>
    /// POCO for LoginIp
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LoginIp/describe", SObject = "/services/data/v29.0/sobjects/LoginIp", RowTemplate = "/services/data/v29.0/sobjects/LoginIp/{ID}")]
    public partial class LoginIp
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UsersId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UsersId { get; set; }

        /// <summary>
        /// SourceIp (string type in Salesforce)
        /// </summary>
        [StringLength(39)]
        public string SourceIp { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsAuthenticated (boolean type in Salesforce)
        /// </summary>
        public bool? IsAuthenticated { get; set; }

        /// <summary>
        /// ChallengeSentDate (datetime type in Salesforce)
        /// </summary>
        public string ChallengeSentDate { get; set; }

        /// <summary>
        /// ChallengeMethod (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ChallengeMethod { get; set; }

    }

    /// <summary>
    /// POCO for MailmergeTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/MailmergeTemplate/describe", SObject = "/services/data/v29.0/sobjects/MailmergeTemplate", RowTemplate = "/services/data/v29.0/sobjects/MailmergeTemplate/{ID}")]
    public partial class MailmergeTemplate
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Filename (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Filename { get; set; }

        /// <summary>
        /// BodyLength (int type in Salesforce)
        /// </summary>
        public string BodyLength { get; set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// LastUsedDate (datetime type in Salesforce)
        /// </summary>
        public string LastUsedDate { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Name
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Name/describe", SObject = "/services/data/v29.0/sobjects/Name", RowTemplate = "/services/data/v29.0/sobjects/Name/{ID}")]
    public partial class Name
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name2 { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        [StringLength(8)]
        public string Alias { get; set; }

        /// <summary>
        /// UserRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserRoleId { get; set; }

        /// <summary>
        /// RecordTypeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RecordTypeId { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// ProfileId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Username (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Username { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for Note
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Note/describe", SObject = "/services/data/v29.0/sobjects/Note", RowTemplate = "/services/data/v29.0/sobjects/Note/{ID}")]
    public partial class Note
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// IsPrivate (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Body { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for NoteAndAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/NoteAndAttachment/describe", SObject = "/services/data/v29.0/sobjects/NoteAndAttachment", RowTemplate = "/services/data/v29.0/sobjects/NoteAndAttachment/{ID}")]
    public partial class NoteAndAttachment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// IsNote (boolean type in Salesforce)
        /// </summary>
        public bool? IsNote { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// IsPrivate (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ObjectPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ObjectPermissions/describe", SObject = "/services/data/v29.0/sobjects/ObjectPermissions", RowTemplate = "/services/data/v29.0/sobjects/ObjectPermissions/{ID}")]
    public partial class ObjectPermissions
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SobjectType { get; set; }

        /// <summary>
        /// PermissionsCreate (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCreate { get; set; }

        /// <summary>
        /// PermissionsRead (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRead { get; set; }

        /// <summary>
        /// PermissionsEdit (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEdit { get; set; }

        /// <summary>
        /// PermissionsDelete (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsDelete { get; set; }

        /// <summary>
        /// PermissionsViewAllRecords (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewAllRecords { get; set; }

        /// <summary>
        /// PermissionsModifyAllRecords (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsModifyAllRecords { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for OpenActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpenActivity/describe", SObject = "/services/data/v29.0/sobjects/OpenActivity", RowTemplate = "/services/data/v29.0/sobjects/OpenActivity/{ID}")]
    public partial class OpenActivity
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// WhoId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhoId { get; set; }

        /// <summary>
        /// WhatId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Subject { get; set; }

        /// <summary>
        /// IsTask (boolean type in Salesforce)
        /// </summary>
        public bool? IsTask { get; set; }

        /// <summary>
        /// ActivityDate (date type in Salesforce)
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// ActivityType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ActivityType { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// IsAllDayEvent (boolean type in Salesforce)
        /// </summary>
        public bool? IsAllDayEvent { get; set; }

        /// <summary>
        /// IsVisibleInSelfService (boolean type in Salesforce)
        /// </summary>
        public bool? IsVisibleInSelfService { get; set; }

        /// <summary>
        /// DurationInMinutes (int type in Salesforce)
        /// </summary>
        public string DurationInMinutes { get; set; }

        /// <summary>
        /// Location (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Location { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CallDurationInSeconds (int type in Salesforce)
        /// </summary>
        public string CallDurationInSeconds { get; set; }

        /// <summary>
        /// CallType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CallType { get; set; }

        /// <summary>
        /// CallDisposition (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallDisposition { get; set; }

        /// <summary>
        /// CallObject (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallObject { get; set; }

        /// <summary>
        /// ReminderDateTime (datetime type in Salesforce)
        /// </summary>
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// IsReminderSet (boolean type in Salesforce)
        /// </summary>
        public bool? IsReminderSet { get; set; }

        /// <summary>
        /// EndDateTime (datetime type in Salesforce)
        /// </summary>
        public string EndDateTime { get; set; }

        /// <summary>
        /// StartDateTime (datetime type in Salesforce)
        /// </summary>
        public string StartDateTime { get; set; }

    }

    /// <summary>
    /// POCO for Opportunity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Opportunity/describe", SObject = "/services/data/v29.0/sobjects/Opportunity", RowTemplate = "/services/data/v29.0/sobjects/Opportunity/{ID}")]
    public partial class Opportunity
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// IsPrivate (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// StageName (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StageName { get; set; }

        /// <summary>
        /// Amount (currency type in Salesforce)
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Probability (percent type in Salesforce)
        /// </summary>
        public string Probability { get; set; }

        /// <summary>
        /// ExpectedRevenue (currency type in Salesforce)
        /// </summary>
        public string ExpectedRevenue { get; set; }

        /// <summary>
        /// TotalOpportunityQuantity (double type in Salesforce)
        /// </summary>
        public string TotalOpportunityQuantity { get; set; }

        /// <summary>
        /// CloseDate (date type in Salesforce)
        /// </summary>
        public string CloseDate { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// NextStep (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NextStep { get; set; }

        /// <summary>
        /// LeadSource (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LeadSource { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// IsWon (boolean type in Salesforce)
        /// </summary>
        public bool? IsWon { get; set; }

        /// <summary>
        /// ForecastCategory (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ForecastCategory { get; set; }

        /// <summary>
        /// ForecastCategoryName (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ForecastCategoryName { get; set; }

        /// <summary>
        /// CampaignId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CampaignId { get; set; }

        /// <summary>
        /// HasOpportunityLineItem (boolean type in Salesforce)
        /// </summary>
        public bool? HasOpportunityLineItem { get; set; }

        /// <summary>
        /// Pricebook2Id (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Pricebook2Id { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastActivityDate (date type in Salesforce)
        /// </summary>
        public string LastActivityDate { get; set; }

        /// <summary>
        /// FiscalQuarter (int type in Salesforce)
        /// </summary>
        public string FiscalQuarter { get; set; }

        /// <summary>
        /// FiscalYear (int type in Salesforce)
        /// </summary>
        public string FiscalYear { get; set; }

        /// <summary>
        /// Fiscal (string type in Salesforce)
        /// </summary>
        [StringLength(6)]
        public string Fiscal { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// DeliveryInstallationStatus__c (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string DeliveryInstallationStatus__c { get; set; }

        /// <summary>
        /// TrackingNumber__c (string type in Salesforce)
        /// </summary>
        [StringLength(12)]
        public string TrackingNumber__c { get; set; }

        /// <summary>
        /// OrderNumber__c (string type in Salesforce)
        /// </summary>
        [StringLength(8)]
        public string OrderNumber__c { get; set; }

        /// <summary>
        /// CurrentGenerators__c (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        /// <summary>
        /// MainCompetitors__c (string type in Salesforce)
        /// </summary>
        [StringLength(100)]
        public string MainCompetitors__c { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityCompetitor
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityCompetitor/describe", SObject = "/services/data/v29.0/sobjects/OpportunityCompetitor", RowTemplate = "/services/data/v29.0/sobjects/OpportunityCompetitor/{ID}")]
    public partial class OpportunityCompetitor
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// CompetitorName (combobox type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CompetitorName { get; set; }

        /// <summary>
        /// Strengths (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Strengths { get; set; }

        /// <summary>
        /// Weaknesses (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Weaknesses { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityContactRole/describe", SObject = "/services/data/v29.0/sobjects/OpportunityContactRole", RowTemplate = "/services/data/v29.0/sobjects/OpportunityContactRole/{ID}")]
    public partial class OpportunityContactRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityFeed/describe", SObject = "/services/data/v29.0/sobjects/OpportunityFeed", RowTemplate = "/services/data/v29.0/sobjects/OpportunityFeed/{ID}")]
    public partial class OpportunityFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityFieldHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityFieldHistory/describe", SObject = "/services/data/v29.0/sobjects/OpportunityFieldHistory", RowTemplate = "/services/data/v29.0/sobjects/OpportunityFieldHistory/{ID}")]
    public partial class OpportunityFieldHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityHistory/describe", SObject = "/services/data/v29.0/sobjects/OpportunityHistory", RowTemplate = "/services/data/v29.0/sobjects/OpportunityHistory/{ID}")]
    public partial class OpportunityHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// StageName (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StageName { get; set; }

        /// <summary>
        /// Amount (currency type in Salesforce)
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// ExpectedRevenue (currency type in Salesforce)
        /// </summary>
        public string ExpectedRevenue { get; set; }

        /// <summary>
        /// CloseDate (date type in Salesforce)
        /// </summary>
        public string CloseDate { get; set; }

        /// <summary>
        /// Probability (percent type in Salesforce)
        /// </summary>
        public string Probability { get; set; }

        /// <summary>
        /// ForecastCategory (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ForecastCategory { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityLineItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityLineItem/describe", SObject = "/services/data/v29.0/sobjects/OpportunityLineItem", RowTemplate = "/services/data/v29.0/sobjects/OpportunityLineItem/{ID}")]
    public partial class OpportunityLineItem
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// PricebookEntryId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PricebookEntryId { get; set; }

        /// <summary>
        /// Quantity (double type in Salesforce)
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// TotalPrice (currency type in Salesforce)
        /// </summary>
        public string TotalPrice { get; set; }

        /// <summary>
        /// UnitPrice (currency type in Salesforce)
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// ListPrice (currency type in Salesforce)
        /// </summary>
        public string ListPrice { get; set; }

        /// <summary>
        /// ServiceDate (date type in Salesforce)
        /// </summary>
        public string ServiceDate { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityPartner/describe", SObject = "/services/data/v29.0/sobjects/OpportunityPartner", RowTemplate = "/services/data/v29.0/sobjects/OpportunityPartner/{ID}")]
    public partial class OpportunityPartner
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// AccountToId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountToId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ReversePartnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ReversePartnerId { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityShare/describe", SObject = "/services/data/v29.0/sobjects/OpportunityShare", RowTemplate = "/services/data/v29.0/sobjects/OpportunityShare/{ID}")]
    public partial class OpportunityShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// OpportunityAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OpportunityAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for OpportunityStage
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityStage/describe", SObject = "/services/data/v29.0/sobjects/OpportunityStage", RowTemplate = "/services/data/v29.0/sobjects/OpportunityStage/{ID}")]
    public partial class OpportunityStage
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// IsWon (boolean type in Salesforce)
        /// </summary>
        public bool? IsWon { get; set; }

        /// <summary>
        /// ForecastCategory (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ForecastCategory { get; set; }

        /// <summary>
        /// ForecastCategoryName (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ForecastCategoryName { get; set; }

        /// <summary>
        /// DefaultProbability (percent type in Salesforce)
        /// </summary>
        public string DefaultProbability { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for OrgWideEmailAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OrgWideEmailAddress/describe", SObject = "/services/data/v29.0/sobjects/OrgWideEmailAddress", RowTemplate = "/services/data/v29.0/sobjects/OrgWideEmailAddress/{ID}")]
    public partial class OrgWideEmailAddress
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Address (email type in Salesforce)
        /// </summary>
        [StringLength(270)]
        public string Address { get; set; }

        /// <summary>
        /// DisplayName (string type in Salesforce)
        /// </summary>
        [StringLength(300)]
        public string DisplayName { get; set; }

        /// <summary>
        /// IsAllowAllProfiles (boolean type in Salesforce)
        /// </summary>
        public bool? IsAllowAllProfiles { get; set; }

    }

    /// <summary>
    /// POCO for Organization
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Organization/describe", SObject = "/services/data/v29.0/sobjects/Organization", RowTemplate = "/services/data/v29.0/sobjects/Organization/{ID}")]
    public partial class Organization
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Division (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Division { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string State { get; set; }

        /// <summary>
        /// PostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
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
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// PrimaryContact (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string PrimaryContact { get; set; }

        /// <summary>
        /// DefaultLocaleSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultLocaleSidKey { get; set; }

        /// <summary>
        /// LanguageLocaleKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LanguageLocaleKey { get; set; }

        /// <summary>
        /// ReceivesInfoEmails (boolean type in Salesforce)
        /// </summary>
        public bool? ReceivesInfoEmails { get; set; }

        /// <summary>
        /// ReceivesAdminInfoEmails (boolean type in Salesforce)
        /// </summary>
        public bool? ReceivesAdminInfoEmails { get; set; }

        /// <summary>
        /// PreferencesRequireOpportunityProducts (boolean type in Salesforce)
        /// </summary>
        public bool? PreferencesRequireOpportunityProducts { get; set; }

        /// <summary>
        /// PreferencesS1BrowserEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? PreferencesS1BrowserEnabled { get; set; }

        /// <summary>
        /// FiscalYearStartMonth (int type in Salesforce)
        /// </summary>
        public string FiscalYearStartMonth { get; set; }

        /// <summary>
        /// UsesStartDateAsFiscalYearName (boolean type in Salesforce)
        /// </summary>
        public bool? UsesStartDateAsFiscalYearName { get; set; }

        /// <summary>
        /// DefaultAccountAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultAccountAccess { get; set; }

        /// <summary>
        /// DefaultContactAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultContactAccess { get; set; }

        /// <summary>
        /// DefaultOpportunityAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultOpportunityAccess { get; set; }

        /// <summary>
        /// DefaultLeadAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultLeadAccess { get; set; }

        /// <summary>
        /// DefaultCaseAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultCaseAccess { get; set; }

        /// <summary>
        /// DefaultCalendarAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultCalendarAccess { get; set; }

        /// <summary>
        /// DefaultPricebookAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultPricebookAccess { get; set; }

        /// <summary>
        /// DefaultCampaignAccess (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultCampaignAccess { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// ComplianceBccEmail (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string ComplianceBccEmail { get; set; }

        /// <summary>
        /// UiSkin (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UiSkin { get; set; }

        /// <summary>
        /// TrialExpirationDate (datetime type in Salesforce)
        /// </summary>
        public string TrialExpirationDate { get; set; }

        /// <summary>
        /// OrganizationType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OrganizationType { get; set; }

        /// <summary>
        /// WebToCaseDefaultOrigin (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string WebToCaseDefaultOrigin { get; set; }

        /// <summary>
        /// MonthlyPageViewsUsed (int type in Salesforce)
        /// </summary>
        public string MonthlyPageViewsUsed { get; set; }

        /// <summary>
        /// MonthlyPageViewsEntitlement (int type in Salesforce)
        /// </summary>
        public string MonthlyPageViewsEntitlement { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for Partner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Partner/describe", SObject = "/services/data/v29.0/sobjects/Partner", RowTemplate = "/services/data/v29.0/sobjects/Partner/{ID}")]
    public partial class Partner
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OpportunityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OpportunityId { get; set; }

        /// <summary>
        /// AccountFromId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountFromId { get; set; }

        /// <summary>
        /// AccountToId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountToId { get; set; }

        /// <summary>
        /// Role (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Role { get; set; }

        /// <summary>
        /// IsPrimary (boolean type in Salesforce)
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ReversePartnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ReversePartnerId { get; set; }

    }

    /// <summary>
    /// POCO for PartnerRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PartnerRole/describe", SObject = "/services/data/v29.0/sobjects/PartnerRole", RowTemplate = "/services/data/v29.0/sobjects/PartnerRole/{ID}")]
    public partial class PartnerRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// ReverseRole (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ReverseRole { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Period
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Period/describe", SObject = "/services/data/v29.0/sobjects/Period", RowTemplate = "/services/data/v29.0/sobjects/Period/{ID}")]
    public partial class Period
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// FiscalYearSettingsId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string FiscalYearSettingsId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// StartDate (date type in Salesforce)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// EndDate (date type in Salesforce)
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsForecastPeriod (boolean type in Salesforce)
        /// </summary>
        public bool? IsForecastPeriod { get; set; }

        /// <summary>
        /// QuarterLabel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string QuarterLabel { get; set; }

        /// <summary>
        /// PeriodLabel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PeriodLabel { get; set; }

        /// <summary>
        /// Number (int type in Salesforce)
        /// </summary>
        public string Number { get; set; }

    }

    /// <summary>
    /// POCO for PermissionSet
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSet/describe", SObject = "/services/data/v29.0/sobjects/PermissionSet", RowTemplate = "/services/data/v29.0/sobjects/PermissionSet/{ID}")]
    public partial class PermissionSet
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Label (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Label { get; set; }

        /// <summary>
        /// UserLicenseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserLicenseId { get; set; }

        /// <summary>
        /// ProfileId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProfileId { get; set; }

        /// <summary>
        /// IsOwnedByProfile (boolean type in Salesforce)
        /// </summary>
        public bool? IsOwnedByProfile { get; set; }

        /// <summary>
        /// PermissionsEditTask (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditTask { get; set; }

        /// <summary>
        /// PermissionsEditEvent (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditEvent { get; set; }

        /// <summary>
        /// PermissionsManageUsers (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageUsers { get; set; }

        /// <summary>
        /// PermissionsModifyAllData (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsModifyAllData { get; set; }

        /// <summary>
        /// PermissionsManageCases (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCases { get; set; }

        /// <summary>
        /// PermissionsMassInlineEdit (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsMassInlineEdit { get; set; }

        /// <summary>
        /// PermissionsEditKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditKnowledge { get; set; }

        /// <summary>
        /// PermissionsManageKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageKnowledge { get; set; }

        /// <summary>
        /// PermissionsManageSolutions (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageSolutions { get; set; }

        /// <summary>
        /// PermissionsCustomizeApplication (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCustomizeApplication { get; set; }

        /// <summary>
        /// PermissionsEditReadonlyFields (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditReadonlyFields { get; set; }

        /// <summary>
        /// PermissionsRunReports (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRunReports { get; set; }

        /// <summary>
        /// PermissionsViewSetup (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewSetup { get; set; }

        /// <summary>
        /// PermissionsTransferAnyEntity (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyEntity { get; set; }

        /// <summary>
        /// PermissionsNewReportBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsNewReportBuilder { get; set; }

        /// <summary>
        /// PermissionsImportLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsImportLeads { get; set; }

        /// <summary>
        /// PermissionsManageLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageLeads { get; set; }

        /// <summary>
        /// PermissionsTransferAnyLead (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyLead { get; set; }

        /// <summary>
        /// PermissionsViewAllData (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewAllData { get; set; }

        /// <summary>
        /// PermissionsEditPublicDocuments (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditPublicDocuments { get; set; }

        /// <summary>
        /// PermissionsSendSitRequests (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSendSitRequests { get; set; }

        /// <summary>
        /// PermissionsManageRemoteAccess (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageRemoteAccess { get; set; }

        /// <summary>
        /// PermissionsCanUseNewDashboardBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

        /// <summary>
        /// PermissionsManageCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCategories { get; set; }

        /// <summary>
        /// PermissionsConvertLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsConvertLeads { get; set; }

        /// <summary>
        /// PermissionsPasswordNeverExpires (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsPasswordNeverExpires { get; set; }

        /// <summary>
        /// PermissionsUseTeamReassignWizards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsUseTeamReassignWizards { get; set; }

        /// <summary>
        /// PermissionsInstallPackaging (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsInstallPackaging { get; set; }

        /// <summary>
        /// PermissionsPublishPackaging (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsPublishPackaging { get; set; }

        /// <summary>
        /// PermissionsEditOppLineItemUnitPrice (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

        /// <summary>
        /// PermissionsCreatePackaging (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCreatePackaging { get; set; }

        /// <summary>
        /// PermissionsBulkApiHardDelete (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsBulkApiHardDelete { get; set; }

        /// <summary>
        /// PermissionsSolutionImport (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSolutionImport { get; set; }

        /// <summary>
        /// PermissionsManageCallCenters (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCallCenters { get; set; }

        /// <summary>
        /// PermissionsManageSynonyms (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageSynonyms { get; set; }

        /// <summary>
        /// PermissionsManageEmailClientConfig (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageEmailClientConfig { get; set; }

        /// <summary>
        /// PermissionsEnableNotifications (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEnableNotifications { get; set; }

        /// <summary>
        /// PermissionsManageDataIntegrations (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDataIntegrations { get; set; }

        /// <summary>
        /// PermissionsDistributeFromPersWksp (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsDistributeFromPersWksp { get; set; }

        /// <summary>
        /// PermissionsViewDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewDataCategories { get; set; }

        /// <summary>
        /// PermissionsManageDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDataCategories { get; set; }

        /// <summary>
        /// PermissionsAuthorApex (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAuthorApex { get; set; }

        /// <summary>
        /// PermissionsManageMobile (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageMobile { get; set; }

        /// <summary>
        /// PermissionsApiEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsApiEnabled { get; set; }

        /// <summary>
        /// PermissionsManageCustomReportTypes (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCustomReportTypes { get; set; }

        /// <summary>
        /// PermissionsEditCaseComments (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditCaseComments { get; set; }

        /// <summary>
        /// PermissionsTransferAnyCase (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyCase { get; set; }

        /// <summary>
        /// PermissionsManageAnalyticSnapshots (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageAnalyticSnapshots { get; set; }

        /// <summary>
        /// PermissionsScheduleReports (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsScheduleReports { get; set; }

        /// <summary>
        /// PermissionsManageBusinessHourHolidays (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageBusinessHourHolidays { get; set; }

        /// <summary>
        /// PermissionsManageDynamicDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDynamicDashboards { get; set; }

        /// <summary>
        /// PermissionsCustomSidebarOnAllPages (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCustomSidebarOnAllPages { get; set; }

        /// <summary>
        /// PermissionsManageInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageInteraction { get; set; }

        /// <summary>
        /// PermissionsViewMyTeamsDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewMyTeamsDashboards { get; set; }

        /// <summary>
        /// PermissionsResetPasswords (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsResetPasswords { get; set; }

        /// <summary>
        /// PermissionsFlowUFLRequired (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsFlowUFLRequired { get; set; }

        /// <summary>
        /// PermissionsCanInsertFeedSystemFields (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCanInsertFeedSystemFields { get; set; }

        /// <summary>
        /// PermissionsManageKnowledgeImportExport (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageKnowledgeImportExport { get; set; }

        /// <summary>
        /// PermissionsEmailTemplateManagement (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEmailTemplateManagement { get; set; }

        /// <summary>
        /// PermissionsEmailAdministration (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEmailAdministration { get; set; }

        /// <summary>
        /// PermissionsManageChatterMessages (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageChatterMessages { get; set; }

        /// <summary>
        /// PermissionsChatterFileLink (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsChatterFileLink { get; set; }

        /// <summary>
        /// PermissionsViewCaseInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewCaseInteraction { get; set; }

        /// <summary>
        /// PermissionsManageAuthProviders (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageAuthProviders { get; set; }

        /// <summary>
        /// PermissionsRunFlow (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRunFlow { get; set; }

        /// <summary>
        /// PermissionsViewAllUsers (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewAllUsers { get; set; }

        /// <summary>
        /// PermissionsAllowUniversalSearch (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAllowUniversalSearch { get; set; }

        /// <summary>
        /// PermissionsConnectOrgToEnvironmentHub (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

        /// <summary>
        /// PermissionsWorkCalibrationUser (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsWorkCalibrationUser { get; set; }

        /// <summary>
        /// PermissionsWorkDotComUserPerm (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsWorkDotComUserPerm { get; set; }

        /// <summary>
        /// PermissionsSalesConsole (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSalesConsole { get; set; }

        /// <summary>
        /// PermissionsIdentityConnect (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsIdentityConnect { get; set; }

        /// <summary>
        /// PermissionsAllowViewKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAllowViewKnowledge { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

    }

    /// <summary>
    /// POCO for PermissionSetAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetAssignment/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetAssignment", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetAssignment/{ID}")]
    public partial class PermissionSetAssignment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// PermissionSetId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PermissionSetId { get; set; }

        /// <summary>
        /// AssigneeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AssigneeId { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for PermissionSetLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetLicense/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetLicense", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetLicense/{ID}")]
    public partial class PermissionSetLicense
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// Language (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Language { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// PermissionSetLicenseKey (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PermissionSetLicenseKey { get; set; }

        /// <summary>
        /// TotalLicenses (int type in Salesforce)
        /// </summary>
        public string TotalLicenses { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Status { get; set; }

        /// <summary>
        /// ExpirationDate (date type in Salesforce)
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// MaximumPermissionsEditTask (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditTask { get; set; }

        /// <summary>
        /// MaximumPermissionsEditEvent (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditEvent { get; set; }

        /// <summary>
        /// MaximumPermissionsManageUsers (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageUsers { get; set; }

        /// <summary>
        /// MaximumPermissionsModifyAllData (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsModifyAllData { get; set; }

        /// <summary>
        /// MaximumPermissionsManageCases (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageCases { get; set; }

        /// <summary>
        /// MaximumPermissionsMassInlineEdit (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsMassInlineEdit { get; set; }

        /// <summary>
        /// MaximumPermissionsEditKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditKnowledge { get; set; }

        /// <summary>
        /// MaximumPermissionsManageKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageKnowledge { get; set; }

        /// <summary>
        /// MaximumPermissionsManageSolutions (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageSolutions { get; set; }

        /// <summary>
        /// MaximumPermissionsCustomizeApplication (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsCustomizeApplication { get; set; }

        /// <summary>
        /// MaximumPermissionsEditReadonlyFields (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditReadonlyFields { get; set; }

        /// <summary>
        /// MaximumPermissionsRunReports (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsRunReports { get; set; }

        /// <summary>
        /// MaximumPermissionsViewSetup (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewSetup { get; set; }

        /// <summary>
        /// MaximumPermissionsTransferAnyEntity (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsTransferAnyEntity { get; set; }

        /// <summary>
        /// MaximumPermissionsNewReportBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsNewReportBuilder { get; set; }

        /// <summary>
        /// MaximumPermissionsImportLeads (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsImportLeads { get; set; }

        /// <summary>
        /// MaximumPermissionsManageLeads (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageLeads { get; set; }

        /// <summary>
        /// MaximumPermissionsTransferAnyLead (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsTransferAnyLead { get; set; }

        /// <summary>
        /// MaximumPermissionsViewAllData (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewAllData { get; set; }

        /// <summary>
        /// MaximumPermissionsEditPublicDocuments (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditPublicDocuments { get; set; }

        /// <summary>
        /// MaximumPermissionsSendSitRequests (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsSendSitRequests { get; set; }

        /// <summary>
        /// MaximumPermissionsManageRemoteAccess (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageRemoteAccess { get; set; }

        /// <summary>
        /// MaximumPermissionsCanUseNewDashboardBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsCanUseNewDashboardBuilder { get; set; }

        /// <summary>
        /// MaximumPermissionsManageCategories (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageCategories { get; set; }

        /// <summary>
        /// MaximumPermissionsConvertLeads (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsConvertLeads { get; set; }

        /// <summary>
        /// MaximumPermissionsPasswordNeverExpires (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsPasswordNeverExpires { get; set; }

        /// <summary>
        /// MaximumPermissionsUseTeamReassignWizards (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsUseTeamReassignWizards { get; set; }

        /// <summary>
        /// MaximumPermissionsInstallPackaging (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsInstallPackaging { get; set; }

        /// <summary>
        /// MaximumPermissionsPublishPackaging (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsPublishPackaging { get; set; }

        /// <summary>
        /// MaximumPermissionsEditOppLineItemUnitPrice (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditOppLineItemUnitPrice { get; set; }

        /// <summary>
        /// MaximumPermissionsCreatePackaging (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsCreatePackaging { get; set; }

        /// <summary>
        /// MaximumPermissionsBulkApiHardDelete (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsBulkApiHardDelete { get; set; }

        /// <summary>
        /// MaximumPermissionsSolutionImport (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsSolutionImport { get; set; }

        /// <summary>
        /// MaximumPermissionsManageCallCenters (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageCallCenters { get; set; }

        /// <summary>
        /// MaximumPermissionsManageSynonyms (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageSynonyms { get; set; }

        /// <summary>
        /// MaximumPermissionsManageEmailClientConfig (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageEmailClientConfig { get; set; }

        /// <summary>
        /// MaximumPermissionsEnableNotifications (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEnableNotifications { get; set; }

        /// <summary>
        /// MaximumPermissionsManageDataIntegrations (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageDataIntegrations { get; set; }

        /// <summary>
        /// MaximumPermissionsDistributeFromPersWksp (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsDistributeFromPersWksp { get; set; }

        /// <summary>
        /// MaximumPermissionsViewDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewDataCategories { get; set; }

        /// <summary>
        /// MaximumPermissionsManageDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageDataCategories { get; set; }

        /// <summary>
        /// MaximumPermissionsAuthorApex (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsAuthorApex { get; set; }

        /// <summary>
        /// MaximumPermissionsManageMobile (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageMobile { get; set; }

        /// <summary>
        /// MaximumPermissionsApiEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsApiEnabled { get; set; }

        /// <summary>
        /// MaximumPermissionsManageCustomReportTypes (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageCustomReportTypes { get; set; }

        /// <summary>
        /// MaximumPermissionsEditCaseComments (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEditCaseComments { get; set; }

        /// <summary>
        /// MaximumPermissionsTransferAnyCase (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsTransferAnyCase { get; set; }

        /// <summary>
        /// MaximumPermissionsManageAnalyticSnapshots (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageAnalyticSnapshots { get; set; }

        /// <summary>
        /// MaximumPermissionsScheduleReports (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsScheduleReports { get; set; }

        /// <summary>
        /// MaximumPermissionsManageBusinessHourHolidays (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageBusinessHourHolidays { get; set; }

        /// <summary>
        /// MaximumPermissionsManageDynamicDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageDynamicDashboards { get; set; }

        /// <summary>
        /// MaximumPermissionsCustomSidebarOnAllPages (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsCustomSidebarOnAllPages { get; set; }

        /// <summary>
        /// MaximumPermissionsManageInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageInteraction { get; set; }

        /// <summary>
        /// MaximumPermissionsViewMyTeamsDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewMyTeamsDashboards { get; set; }

        /// <summary>
        /// MaximumPermissionsResetPasswords (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsResetPasswords { get; set; }

        /// <summary>
        /// MaximumPermissionsFlowUFLRequired (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsFlowUFLRequired { get; set; }

        /// <summary>
        /// MaximumPermissionsCanInsertFeedSystemFields (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsCanInsertFeedSystemFields { get; set; }

        /// <summary>
        /// MaximumPermissionsManageKnowledgeImportExport (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageKnowledgeImportExport { get; set; }

        /// <summary>
        /// MaximumPermissionsEmailTemplateManagement (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEmailTemplateManagement { get; set; }

        /// <summary>
        /// MaximumPermissionsEmailAdministration (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsEmailAdministration { get; set; }

        /// <summary>
        /// MaximumPermissionsManageChatterMessages (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageChatterMessages { get; set; }

        /// <summary>
        /// MaximumPermissionsChatterFileLink (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsChatterFileLink { get; set; }

        /// <summary>
        /// MaximumPermissionsViewCaseInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewCaseInteraction { get; set; }

        /// <summary>
        /// MaximumPermissionsManageAuthProviders (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsManageAuthProviders { get; set; }

        /// <summary>
        /// MaximumPermissionsRunFlow (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsRunFlow { get; set; }

        /// <summary>
        /// MaximumPermissionsViewAllUsers (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsViewAllUsers { get; set; }

        /// <summary>
        /// MaximumPermissionsAllowUniversalSearch (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsAllowUniversalSearch { get; set; }

        /// <summary>
        /// MaximumPermissionsConnectOrgToEnvironmentHub (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsConnectOrgToEnvironmentHub { get; set; }

        /// <summary>
        /// MaximumPermissionsWorkCalibrationUser (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsWorkCalibrationUser { get; set; }

        /// <summary>
        /// MaximumPermissionsWorkDotComUserPerm (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsWorkDotComUserPerm { get; set; }

        /// <summary>
        /// MaximumPermissionsSalesConsole (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsSalesConsole { get; set; }

        /// <summary>
        /// MaximumPermissionsIdentityConnect (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsIdentityConnect { get; set; }

        /// <summary>
        /// MaximumPermissionsAllowViewKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? MaximumPermissionsAllowViewKnowledge { get; set; }

        /// <summary>
        /// UsedLicenses (int type in Salesforce)
        /// </summary>
        public string UsedLicenses { get; set; }

    }

    /// <summary>
    /// POCO for PermissionSetLicenseAssign
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign/{ID}")]
    public partial class PermissionSetLicenseAssign
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// PermissionSetLicenseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PermissionSetLicenseId { get; set; }

        /// <summary>
        /// AssigneeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AssigneeId { get; set; }

    }

    /// <summary>
    /// POCO for Pricebook2
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Pricebook2/describe", SObject = "/services/data/v29.0/sobjects/Pricebook2", RowTemplate = "/services/data/v29.0/sobjects/Pricebook2/{ID}")]
    public partial class Pricebook2
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// IsStandard (boolean type in Salesforce)
        /// </summary>
        public bool? IsStandard { get; set; }

    }

    /// <summary>
    /// POCO for Pricebook2History
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Pricebook2History/describe", SObject = "/services/data/v29.0/sobjects/Pricebook2History", RowTemplate = "/services/data/v29.0/sobjects/Pricebook2History/{ID}")]
    public partial class Pricebook2History
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Pricebook2Id (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Pricebook2Id { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for PricebookEntry
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PricebookEntry/describe", SObject = "/services/data/v29.0/sobjects/PricebookEntry", RowTemplate = "/services/data/v29.0/sobjects/PricebookEntry/{ID}")]
    public partial class PricebookEntry
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Pricebook2Id (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Pricebook2Id { get; set; }

        /// <summary>
        /// Product2Id (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Product2Id { get; set; }

        /// <summary>
        /// UnitPrice (currency type in Salesforce)
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// UseStandardPrice (boolean type in Salesforce)
        /// </summary>
        public bool? UseStandardPrice { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// ProductCode (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ProductCode { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for ProcessInstance
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstance/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstance", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstance/{ID}")]
    public partial class ProcessInstance
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// TargetObjectId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceHistory/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceHistory", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceHistory/{ID}")]
    public partial class ProcessInstanceHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsPending (boolean type in Salesforce)
        /// </summary>
        public bool? IsPending { get; set; }

        /// <summary>
        /// ProcessInstanceId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// TargetObjectId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// StepStatus (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StepStatus { get; set; }

        /// <summary>
        /// OriginalActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OriginalActorId { get; set; }

        /// <summary>
        /// ActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ActorId { get; set; }

        /// <summary>
        /// RemindersSent (int type in Salesforce)
        /// </summary>
        public string RemindersSent { get; set; }

        /// <summary>
        /// Comments (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Comments { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceStep
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceStep/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceStep", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceStep/{ID}")]
    public partial class ProcessInstanceStep
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ProcessInstanceId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// StepStatus (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string StepStatus { get; set; }

        /// <summary>
        /// OriginalActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OriginalActorId { get; set; }

        /// <summary>
        /// ActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ActorId { get; set; }

        /// <summary>
        /// Comments (string type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Comments { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for ProcessInstanceWorkitem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem/{ID}")]
    public partial class ProcessInstanceWorkitem
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ProcessInstanceId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// OriginalActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OriginalActorId { get; set; }

        /// <summary>
        /// ActorId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ActorId { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Product2
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Product2/describe", SObject = "/services/data/v29.0/sobjects/Product2", RowTemplate = "/services/data/v29.0/sobjects/Product2/{ID}")]
    public partial class Product2
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// ProductCode (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(4000)]
        public string Description { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Family (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Family { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

    }

    /// <summary>
    /// POCO for Product2Feed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Product2Feed/describe", SObject = "/services/data/v29.0/sobjects/Product2Feed", RowTemplate = "/services/data/v29.0/sobjects/Product2Feed/{ID}")]
    public partial class Product2Feed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for Profile
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Profile/describe", SObject = "/services/data/v29.0/sobjects/Profile", RowTemplate = "/services/data/v29.0/sobjects/Profile/{ID}")]
    public partial class Profile
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// PermissionsEditTask (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditTask { get; set; }

        /// <summary>
        /// PermissionsEditEvent (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditEvent { get; set; }

        /// <summary>
        /// PermissionsManageUsers (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageUsers { get; set; }

        /// <summary>
        /// PermissionsModifyAllData (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsModifyAllData { get; set; }

        /// <summary>
        /// PermissionsManageCases (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCases { get; set; }

        /// <summary>
        /// PermissionsMassInlineEdit (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsMassInlineEdit { get; set; }

        /// <summary>
        /// PermissionsEditKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditKnowledge { get; set; }

        /// <summary>
        /// PermissionsManageKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageKnowledge { get; set; }

        /// <summary>
        /// PermissionsManageSolutions (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageSolutions { get; set; }

        /// <summary>
        /// PermissionsCustomizeApplication (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCustomizeApplication { get; set; }

        /// <summary>
        /// PermissionsEditReadonlyFields (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditReadonlyFields { get; set; }

        /// <summary>
        /// PermissionsRunReports (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRunReports { get; set; }

        /// <summary>
        /// PermissionsViewSetup (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewSetup { get; set; }

        /// <summary>
        /// PermissionsTransferAnyEntity (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyEntity { get; set; }

        /// <summary>
        /// PermissionsNewReportBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsNewReportBuilder { get; set; }

        /// <summary>
        /// PermissionsImportLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsImportLeads { get; set; }

        /// <summary>
        /// PermissionsManageLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageLeads { get; set; }

        /// <summary>
        /// PermissionsTransferAnyLead (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyLead { get; set; }

        /// <summary>
        /// PermissionsViewAllData (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewAllData { get; set; }

        /// <summary>
        /// PermissionsEditPublicDocuments (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditPublicDocuments { get; set; }

        /// <summary>
        /// PermissionsSendSitRequests (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSendSitRequests { get; set; }

        /// <summary>
        /// PermissionsManageRemoteAccess (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageRemoteAccess { get; set; }

        /// <summary>
        /// PermissionsCanUseNewDashboardBuilder (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCanUseNewDashboardBuilder { get; set; }

        /// <summary>
        /// PermissionsManageCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCategories { get; set; }

        /// <summary>
        /// PermissionsConvertLeads (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsConvertLeads { get; set; }

        /// <summary>
        /// PermissionsPasswordNeverExpires (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsPasswordNeverExpires { get; set; }

        /// <summary>
        /// PermissionsUseTeamReassignWizards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsUseTeamReassignWizards { get; set; }

        /// <summary>
        /// PermissionsInstallMultiforce (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsInstallMultiforce { get; set; }

        /// <summary>
        /// PermissionsPublishMultiforce (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsPublishMultiforce { get; set; }

        /// <summary>
        /// PermissionsEditOppLineItemUnitPrice (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditOppLineItemUnitPrice { get; set; }

        /// <summary>
        /// PermissionsCreateMultiforce (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCreateMultiforce { get; set; }

        /// <summary>
        /// PermissionsBulkApiHardDelete (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsBulkApiHardDelete { get; set; }

        /// <summary>
        /// PermissionsSolutionImport (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSolutionImport { get; set; }

        /// <summary>
        /// PermissionsManageCallCenters (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCallCenters { get; set; }

        /// <summary>
        /// PermissionsManageSynonyms (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageSynonyms { get; set; }

        /// <summary>
        /// PermissionsManageEmailClientConfig (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageEmailClientConfig { get; set; }

        /// <summary>
        /// PermissionsEnableNotifications (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEnableNotifications { get; set; }

        /// <summary>
        /// PermissionsManageDataIntegrations (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDataIntegrations { get; set; }

        /// <summary>
        /// PermissionsDistributeFromPersWksp (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsDistributeFromPersWksp { get; set; }

        /// <summary>
        /// PermissionsViewDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewDataCategories { get; set; }

        /// <summary>
        /// PermissionsManageDataCategories (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDataCategories { get; set; }

        /// <summary>
        /// PermissionsAuthorApex (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAuthorApex { get; set; }

        /// <summary>
        /// PermissionsManageMobile (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageMobile { get; set; }

        /// <summary>
        /// PermissionsApiEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsApiEnabled { get; set; }

        /// <summary>
        /// PermissionsManageCustomReportTypes (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageCustomReportTypes { get; set; }

        /// <summary>
        /// PermissionsEditCaseComments (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEditCaseComments { get; set; }

        /// <summary>
        /// PermissionsTransferAnyCase (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsTransferAnyCase { get; set; }

        /// <summary>
        /// PermissionsManageAnalyticSnapshots (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageAnalyticSnapshots { get; set; }

        /// <summary>
        /// PermissionsScheduleReports (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsScheduleReports { get; set; }

        /// <summary>
        /// PermissionsManageBusinessHourHolidays (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageBusinessHourHolidays { get; set; }

        /// <summary>
        /// PermissionsManageDynamicDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageDynamicDashboards { get; set; }

        /// <summary>
        /// PermissionsCustomSidebarOnAllPages (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCustomSidebarOnAllPages { get; set; }

        /// <summary>
        /// PermissionsManageInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageInteraction { get; set; }

        /// <summary>
        /// PermissionsViewMyTeamsDashboards (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewMyTeamsDashboards { get; set; }

        /// <summary>
        /// PermissionsResetPasswords (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsResetPasswords { get; set; }

        /// <summary>
        /// PermissionsFlowUFLRequired (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsFlowUFLRequired { get; set; }

        /// <summary>
        /// PermissionsCanInsertFeedSystemFields (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsCanInsertFeedSystemFields { get; set; }

        /// <summary>
        /// PermissionsManageKnowledgeImportExport (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageKnowledgeImportExport { get; set; }

        /// <summary>
        /// PermissionsEmailTemplateManagement (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEmailTemplateManagement { get; set; }

        /// <summary>
        /// PermissionsEmailAdministration (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsEmailAdministration { get; set; }

        /// <summary>
        /// PermissionsManageChatterMessages (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageChatterMessages { get; set; }

        /// <summary>
        /// PermissionsChatterFileLink (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsChatterFileLink { get; set; }

        /// <summary>
        /// PermissionsViewCaseInteraction (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewCaseInteraction { get; set; }

        /// <summary>
        /// PermissionsManageAuthProviders (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsManageAuthProviders { get; set; }

        /// <summary>
        /// PermissionsRunFlow (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsRunFlow { get; set; }

        /// <summary>
        /// PermissionsViewAllUsers (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsViewAllUsers { get; set; }

        /// <summary>
        /// PermissionsAllowUniversalSearch (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAllowUniversalSearch { get; set; }

        /// <summary>
        /// PermissionsConnectOrgToEnvironmentHub (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsConnectOrgToEnvironmentHub { get; set; }

        /// <summary>
        /// PermissionsWorkCalibrationUser (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsWorkCalibrationUser { get; set; }

        /// <summary>
        /// PermissionsWorkDotComUserPerm (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsWorkDotComUserPerm { get; set; }

        /// <summary>
        /// PermissionsSalesConsole (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsSalesConsole { get; set; }

        /// <summary>
        /// PermissionsIdentityConnect (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsIdentityConnect { get; set; }

        /// <summary>
        /// PermissionsAllowViewKnowledge (boolean type in Salesforce)
        /// </summary>
        public bool? PermissionsAllowViewKnowledge { get; set; }

        /// <summary>
        /// UserLicenseId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserLicenseId { get; set; }

        /// <summary>
        /// UserType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UserType { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for PushTopic
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PushTopic/describe", SObject = "/services/data/v29.0/sobjects/PushTopic", RowTemplate = "/services/data/v29.0/sobjects/PushTopic/{ID}")]
    public partial class PushTopic
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(25)]
        public string Name { get; set; }

        /// <summary>
        /// Query (string type in Salesforce)
        /// </summary>
        [StringLength(1300)]
        public string Query { get; set; }

        /// <summary>
        /// ApiVersion (double type in Salesforce)
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// NotifyForFields (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string NotifyForFields { get; set; }

        /// <summary>
        /// NotifyForOperations (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string NotifyForOperations { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(400)]
        public string Description { get; set; }

        /// <summary>
        /// NotifyForOperationCreate (boolean type in Salesforce)
        /// </summary>
        public bool? NotifyForOperationCreate { get; set; }

        /// <summary>
        /// NotifyForOperationUpdate (boolean type in Salesforce)
        /// </summary>
        public bool? NotifyForOperationUpdate { get; set; }

        /// <summary>
        /// NotifyForOperationDelete (boolean type in Salesforce)
        /// </summary>
        public bool? NotifyForOperationDelete { get; set; }

        /// <summary>
        /// NotifyForOperationUndelete (boolean type in Salesforce)
        /// </summary>
        public bool? NotifyForOperationUndelete { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for QueueSobject
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/QueueSobject/describe", SObject = "/services/data/v29.0/sobjects/QueueSobject", RowTemplate = "/services/data/v29.0/sobjects/QueueSobject/{ID}")]
    public partial class QueueSobject
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// QueueId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string QueueId { get; set; }

        /// <summary>
        /// SobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SobjectType { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for RecentlyViewed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/RecentlyViewed/describe", SObject = "/services/data/v29.0/sobjects/RecentlyViewed", RowTemplate = "/services/data/v29.0/sobjects/RecentlyViewed/{ID}")]
    public partial class RecentlyViewed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        [StringLength(8)]
        public string Alias { get; set; }

        /// <summary>
        /// UserRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserRoleId { get; set; }

        /// <summary>
        /// RecordTypeId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RecordTypeId { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// ProfileId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for RecordType
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/RecordType/describe", SObject = "/services/data/v29.0/sobjects/RecordType", RowTemplate = "/services/data/v29.0/sobjects/RecordType/{ID}")]
    public partial class RecordType
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// BusinessProcessId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string BusinessProcessId { get; set; }

        /// <summary>
        /// SobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SobjectType { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Report
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Report/describe", SObject = "/services/data/v29.0/sobjects/Report", RowTemplate = "/services/data/v29.0/sobjects/Report/{ID}")]
    public partial class Report
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// LastRunDate (datetime type in Salesforce)
        /// </summary>
        public string LastRunDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// Format (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Format { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for ReportFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ReportFeed/describe", SObject = "/services/data/v29.0/sobjects/ReportFeed", RowTemplate = "/services/data/v29.0/sobjects/ReportFeed/{ID}")]
    public partial class ReportFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for SetupEntityAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SetupEntityAccess/describe", SObject = "/services/data/v29.0/sobjects/SetupEntityAccess", RowTemplate = "/services/data/v29.0/sobjects/SetupEntityAccess/{ID}")]
    public partial class SetupEntityAccess
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// SetupEntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SetupEntityId { get; set; }

        /// <summary>
        /// SetupEntityType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SetupEntityType { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Site
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Site/describe", SObject = "/services/data/v29.0/sobjects/Site", RowTemplate = "/services/data/v29.0/sobjects/Site/{ID}")]
    public partial class Site
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Subdomain (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Subdomain { get; set; }

        /// <summary>
        /// UrlPathPrefix (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UrlPathPrefix { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// AdminId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AdminId { get; set; }

        /// <summary>
        /// OptionsEnableFeeds (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsEnableFeeds { get; set; }

        /// <summary>
        /// OptionsAllowHomePage (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsAllowHomePage { get; set; }

        /// <summary>
        /// OptionsAllowStandardIdeasPages (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsAllowStandardIdeasPages { get; set; }

        /// <summary>
        /// OptionsAllowStandardSearch (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsAllowStandardSearch { get; set; }

        /// <summary>
        /// OptionsAllowStandardLookups (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsAllowStandardLookups { get; set; }

        /// <summary>
        /// OptionsAllowStandardAnswersPages (boolean type in Salesforce)
        /// </summary>
        public bool? OptionsAllowStandardAnswersPages { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// AnalyticsTrackingCode (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string AnalyticsTrackingCode { get; set; }

        /// <summary>
        /// SiteType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string SiteType { get; set; }

        /// <summary>
        /// DailyBandwidthLimit (int type in Salesforce)
        /// </summary>
        public string DailyBandwidthLimit { get; set; }

        /// <summary>
        /// DailyBandwidthUsed (int type in Salesforce)
        /// </summary>
        public string DailyBandwidthUsed { get; set; }

        /// <summary>
        /// DailyRequestTimeLimit (int type in Salesforce)
        /// </summary>
        public string DailyRequestTimeLimit { get; set; }

        /// <summary>
        /// DailyRequestTimeUsed (int type in Salesforce)
        /// </summary>
        public string DailyRequestTimeUsed { get; set; }

        /// <summary>
        /// MonthlyPageViewsEntitlement (int type in Salesforce)
        /// </summary>
        public string MonthlyPageViewsEntitlement { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for SiteFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SiteFeed/describe", SObject = "/services/data/v29.0/sobjects/SiteFeed", RowTemplate = "/services/data/v29.0/sobjects/SiteFeed/{ID}")]
    public partial class SiteFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for SiteHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SiteHistory/describe", SObject = "/services/data/v29.0/sobjects/SiteHistory", RowTemplate = "/services/data/v29.0/sobjects/SiteHistory/{ID}")]
    public partial class SiteHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// SiteId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SiteId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for Solution
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Solution/describe", SObject = "/services/data/v29.0/sobjects/Solution", RowTemplate = "/services/data/v29.0/sobjects/Solution/{ID}")]
    public partial class Solution
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// SolutionNumber (string type in Salesforce)
        /// </summary>
        [StringLength(30)]
        public string SolutionNumber { get; set; }

        /// <summary>
        /// SolutionName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string SolutionName { get; set; }

        /// <summary>
        /// IsPublished (boolean type in Salesforce)
        /// </summary>
        public bool? IsPublished { get; set; }

        /// <summary>
        /// IsPublishedInPublicKb (boolean type in Salesforce)
        /// </summary>
        public bool? IsPublishedInPublicKb { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// IsReviewed (boolean type in Salesforce)
        /// </summary>
        public bool? IsReviewed { get; set; }

        /// <summary>
        /// SolutionNote (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string SolutionNote { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// TimesUsed (int type in Salesforce)
        /// </summary>
        public string TimesUsed { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

        /// <summary>
        /// IsHtml (boolean type in Salesforce)
        /// </summary>
        public bool? IsHtml { get; set; }

    }

    /// <summary>
    /// POCO for SolutionFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionFeed/describe", SObject = "/services/data/v29.0/sobjects/SolutionFeed", RowTemplate = "/services/data/v29.0/sobjects/SolutionFeed/{ID}")]
    public partial class SolutionFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for SolutionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionHistory/describe", SObject = "/services/data/v29.0/sobjects/SolutionHistory", RowTemplate = "/services/data/v29.0/sobjects/SolutionHistory/{ID}")]
    public partial class SolutionHistory
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// SolutionId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string SolutionId { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Field (picklist type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Field { get; set; }

        /// <summary>
        /// OldValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string OldValue { get; set; }

        /// <summary>
        /// NewValue (anyType type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string NewValue { get; set; }

    }

    /// <summary>
    /// POCO for SolutionStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionStatus/describe", SObject = "/services/data/v29.0/sobjects/SolutionStatus", RowTemplate = "/services/data/v29.0/sobjects/SolutionStatus/{ID}")]
    public partial class SolutionStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// IsReviewed (boolean type in Salesforce)
        /// </summary>
        public bool? IsReviewed { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for StaticResource
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/StaticResource/describe", SObject = "/services/data/v29.0/sobjects/StaticResource", RowTemplate = "/services/data/v29.0/sobjects/StaticResource/{ID}")]
    public partial class StaticResource
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// BodyLength (int type in Salesforce)
        /// </summary>
        public string BodyLength { get; set; }

        /// <summary>
        /// Body (base64 type in Salesforce)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CacheControl (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CacheControl { get; set; }

    }

    /// <summary>
    /// POCO for Task
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Task/describe", SObject = "/services/data/v29.0/sobjects/Task", RowTemplate = "/services/data/v29.0/sobjects/Task/{ID}")]
    public partial class Task
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// WhoId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhoId { get; set; }

        /// <summary>
        /// WhatId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string WhatId { get; set; }

        /// <summary>
        /// Subject (combobox type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Subject { get; set; }

        /// <summary>
        /// ActivityDate (date type in Salesforce)
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// Status (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Status { get; set; }

        /// <summary>
        /// Priority (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Priority { get; set; }

        /// <summary>
        /// OwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(32000)]
        public string Description { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsArchived (boolean type in Salesforce)
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// CallDurationInSeconds (int type in Salesforce)
        /// </summary>
        public string CallDurationInSeconds { get; set; }

        /// <summary>
        /// CallType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CallType { get; set; }

        /// <summary>
        /// CallDisposition (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallDisposition { get; set; }

        /// <summary>
        /// CallObject (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string CallObject { get; set; }

        /// <summary>
        /// ReminderDateTime (datetime type in Salesforce)
        /// </summary>
        public string ReminderDateTime { get; set; }

        /// <summary>
        /// IsReminderSet (boolean type in Salesforce)
        /// </summary>
        public bool? IsReminderSet { get; set; }

        /// <summary>
        /// RecurrenceActivityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RecurrenceActivityId { get; set; }

        /// <summary>
        /// IsRecurrence (boolean type in Salesforce)
        /// </summary>
        public bool? IsRecurrence { get; set; }

        /// <summary>
        /// RecurrenceStartDateOnly (date type in Salesforce)
        /// </summary>
        public string RecurrenceStartDateOnly { get; set; }

        /// <summary>
        /// RecurrenceEndDateOnly (date type in Salesforce)
        /// </summary>
        public string RecurrenceEndDateOnly { get; set; }

        /// <summary>
        /// RecurrenceTimeZoneSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceTimeZoneSidKey { get; set; }

        /// <summary>
        /// RecurrenceType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// RecurrenceInterval (int type in Salesforce)
        /// </summary>
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// RecurrenceDayOfWeekMask (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfWeekMask { get; set; }

        /// <summary>
        /// RecurrenceDayOfMonth (int type in Salesforce)
        /// </summary>
        public string RecurrenceDayOfMonth { get; set; }

        /// <summary>
        /// RecurrenceInstance (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceInstance { get; set; }

        /// <summary>
        /// RecurrenceMonthOfYear (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecurrenceMonthOfYear { get; set; }

    }

    /// <summary>
    /// POCO for TaskFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskFeed/describe", SObject = "/services/data/v29.0/sobjects/TaskFeed", RowTemplate = "/services/data/v29.0/sobjects/TaskFeed/{ID}")]
    public partial class TaskFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for TaskPriority
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskPriority/describe", SObject = "/services/data/v29.0/sobjects/TaskPriority", RowTemplate = "/services/data/v29.0/sobjects/TaskPriority/{ID}")]
    public partial class TaskPriority
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// IsHighPriority (boolean type in Salesforce)
        /// </summary>
        public bool? IsHighPriority { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for TaskStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskStatus/describe", SObject = "/services/data/v29.0/sobjects/TaskStatus", RowTemplate = "/services/data/v29.0/sobjects/TaskStatus/{ID}")]
    public partial class TaskStatus
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// SortOrder (int type in Salesforce)
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// IsDefault (boolean type in Salesforce)
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// IsClosed (boolean type in Salesforce)
        /// </summary>
        public bool? IsClosed { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for Topic
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Topic/describe", SObject = "/services/data/v29.0/sobjects/Topic", RowTemplate = "/services/data/v29.0/sobjects/Topic/{ID}")]
    public partial class Topic
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(99)]
        public string Name { get; set; }

        /// <summary>
        /// Description (string type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// TalkingAbout (int type in Salesforce)
        /// </summary>
        public string TalkingAbout { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for TopicAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TopicAssignment/describe", SObject = "/services/data/v29.0/sobjects/TopicAssignment", RowTemplate = "/services/data/v29.0/sobjects/TopicAssignment/{ID}")]
    public partial class TopicAssignment
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// TopicId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string TopicId { get; set; }

        /// <summary>
        /// EntityId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string EntityId { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for TopicFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TopicFeed/describe", SObject = "/services/data/v29.0/sobjects/TopicFeed", RowTemplate = "/services/data/v29.0/sobjects/TopicFeed/{ID}")]
    public partial class TopicFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for UndecidedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UndecidedEventRelation/describe", SObject = "/services/data/v29.0/sobjects/UndecidedEventRelation", RowTemplate = "/services/data/v29.0/sobjects/UndecidedEventRelation/{ID}")]
    public partial class UndecidedEventRelation
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// RelationId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelationId { get; set; }

        /// <summary>
        /// EventId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string EventId { get; set; }

        /// <summary>
        /// RespondedDate (datetime type in Salesforce)
        /// </summary>
        public string RespondedDate { get; set; }

        /// <summary>
        /// Response (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Response { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Type (string type in Salesforce)
        /// </summary>
        [StringLength(50)]
        public string Type { get; set; }

    }

    /// <summary>
    /// POCO for User
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/User/describe", SObject = "/services/data/v29.0/sobjects/User", RowTemplate = "/services/data/v29.0/sobjects/User/{ID}")]
    public partial class User
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Username (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Username { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string Name { get; set; }

        /// <summary>
        /// CompanyName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Division (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Division { get; set; }

        /// <summary>
        /// Department (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Department { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string State { get; set; }

        /// <summary>
        /// PostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
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
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Email { get; set; }

        /// <summary>
        /// EmailPreferencesAutoBcc (boolean type in Salesforce)
        /// </summary>
        public bool? EmailPreferencesAutoBcc { get; set; }

        /// <summary>
        /// EmailPreferencesAutoBccStayInTouch (boolean type in Salesforce)
        /// </summary>
        public bool? EmailPreferencesAutoBccStayInTouch { get; set; }

        /// <summary>
        /// EmailPreferencesStayInTouchReminder (boolean type in Salesforce)
        /// </summary>
        public bool? EmailPreferencesStayInTouchReminder { get; set; }

        /// <summary>
        /// SenderEmail (email type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// SenderName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string SenderName { get; set; }

        /// <summary>
        /// Signature (string type in Salesforce)
        /// </summary>
        [StringLength(1333)]
        public string Signature { get; set; }

        /// <summary>
        /// StayInTouchSubject (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string StayInTouchSubject { get; set; }

        /// <summary>
        /// StayInTouchSignature (string type in Salesforce)
        /// </summary>
        [StringLength(512)]
        public string StayInTouchSignature { get; set; }

        /// <summary>
        /// StayInTouchNote (string type in Salesforce)
        /// </summary>
        [StringLength(512)]
        public string StayInTouchNote { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// MobilePhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Alias (string type in Salesforce)
        /// </summary>
        [StringLength(8)]
        public string Alias { get; set; }

        /// <summary>
        /// CommunityNickname (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CommunityNickname { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// TimeZoneSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string TimeZoneSidKey { get; set; }

        /// <summary>
        /// UserRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserRoleId { get; set; }

        /// <summary>
        /// LocaleSidKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LocaleSidKey { get; set; }

        /// <summary>
        /// ReceivesInfoEmails (boolean type in Salesforce)
        /// </summary>
        public bool? ReceivesInfoEmails { get; set; }

        /// <summary>
        /// ReceivesAdminInfoEmails (boolean type in Salesforce)
        /// </summary>
        public bool? ReceivesAdminInfoEmails { get; set; }

        /// <summary>
        /// EmailEncodingKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string EmailEncodingKey { get; set; }

        /// <summary>
        /// ProfileId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ProfileId { get; set; }

        /// <summary>
        /// UserType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UserType { get; set; }

        /// <summary>
        /// LanguageLocaleKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LanguageLocaleKey { get; set; }

        /// <summary>
        /// EmployeeNumber (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// DelegatedApproverId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string DelegatedApproverId { get; set; }

        /// <summary>
        /// ManagerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ManagerId { get; set; }

        /// <summary>
        /// LastLoginDate (datetime type in Salesforce)
        /// </summary>
        public string LastLoginDate { get; set; }

        /// <summary>
        /// LastPasswordChangeDate (datetime type in Salesforce)
        /// </summary>
        public string LastPasswordChangeDate { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// OfflineTrialExpirationDate (datetime type in Salesforce)
        /// </summary>
        public string OfflineTrialExpirationDate { get; set; }

        /// <summary>
        /// OfflinePdaTrialExpirationDate (datetime type in Salesforce)
        /// </summary>
        public string OfflinePdaTrialExpirationDate { get; set; }

        /// <summary>
        /// UserPermissionsMarketingUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsMarketingUser { get; set; }

        /// <summary>
        /// UserPermissionsOfflineUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsOfflineUser { get; set; }

        /// <summary>
        /// UserPermissionsCallCenterAutoLogin (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsCallCenterAutoLogin { get; set; }

        /// <summary>
        /// UserPermissionsMobileUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsMobileUser { get; set; }

        /// <summary>
        /// UserPermissionsSFContentUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsSFContentUser { get; set; }

        /// <summary>
        /// UserPermissionsKnowledgeUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsKnowledgeUser { get; set; }

        /// <summary>
        /// UserPermissionsInteractionUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsInteractionUser { get; set; }

        /// <summary>
        /// UserPermissionsSupportUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsSupportUser { get; set; }

        /// <summary>
        /// UserPermissionsSiteforceContributorUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsSiteforceContributorUser { get; set; }

        /// <summary>
        /// UserPermissionsSiteforcePublisherUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsSiteforcePublisherUser { get; set; }

        /// <summary>
        /// UserPermissionsChatterAnswersUser (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsChatterAnswersUser { get; set; }

        /// <summary>
        /// UserPermissionsWorkDotComUserFeature (boolean type in Salesforce)
        /// </summary>
        public bool? UserPermissionsWorkDotComUserFeature { get; set; }

        /// <summary>
        /// ForecastEnabled (boolean type in Salesforce)
        /// </summary>
        public bool? ForecastEnabled { get; set; }

        /// <summary>
        /// UserPreferencesActivityRemindersPopup (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesActivityRemindersPopup { get; set; }

        /// <summary>
        /// UserPreferencesEventRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesEventRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// UserPreferencesTaskRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesTaskRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// UserPreferencesReminderSoundOff (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesReminderSoundOff { get; set; }

        /// <summary>
        /// UserPreferencesDisableAllFeedsEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableAllFeedsEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableFollowersEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFollowersEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableProfilePostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableProfilePostEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableChangeCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableChangeCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableLaterCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableLaterCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisProfPostCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisProfPostCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesContentNoEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesContentNoEmail { get; set; }

        /// <summary>
        /// UserPreferencesContentEmailAsAndWhen (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesContentEmailAsAndWhen { get; set; }

        /// <summary>
        /// UserPreferencesApexPagesDeveloperMode (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesApexPagesDeveloperMode { get; set; }

        /// <summary>
        /// UserPreferencesHideCSNGetChatterMobileTask (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideCSNGetChatterMobileTask { get; set; }

        /// <summary>
        /// UserPreferencesDisableMentionsPostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableMentionsPostEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisMentionsCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisMentionsCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesHideCSNDesktopTask (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideCSNDesktopTask { get; set; }

        /// <summary>
        /// UserPreferencesHideChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideChatterOnboardingSplash { get; set; }

        /// <summary>
        /// UserPreferencesHideSecondChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideSecondChatterOnboardingSplash { get; set; }

        /// <summary>
        /// UserPreferencesDisCommentAfterLikeEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisCommentAfterLikeEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableLikeEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableLikeEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableMessageEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableMessageEmail { get; set; }

        /// <summary>
        /// UserPreferencesOptOutOfTouch (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesOptOutOfTouch { get; set; }

        /// <summary>
        /// UserPreferencesDisableBookmarkEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableBookmarkEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableSharePostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableSharePostEmail { get; set; }

        /// <summary>
        /// UserPreferencesEnableAutoSubForFeeds (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesEnableAutoSubForFeeds { get; set; }

        /// <summary>
        /// UserPreferencesDisableFileShareNotificationsForApi (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFileShareNotificationsForApi { get; set; }

        /// <summary>
        /// UserPreferencesShowTitleToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowTitleToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowManagerToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowManagerToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowEmailToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowEmailToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowWorkPhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowWorkPhoneToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowMobilePhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowMobilePhoneToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowFaxToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowFaxToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStreetAddressToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStreetAddressToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCityToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCityToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStateToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStateToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowPostalCodeToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowPostalCodeToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCountryToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCountryToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowProfilePicToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowProfilePicToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowTitleToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowTitleToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCityToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCityToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStateToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStateToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowPostalCodeToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowPostalCodeToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCountryToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCountryToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesDisableFeedbackEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFeedbackEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableCoachingEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableCoachingEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableGoalEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableGoalEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableWorkEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableWorkEmail { get; set; }

        /// <summary>
        /// UserPreferencesHideS1BrowserUI (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideS1BrowserUI { get; set; }

        /// <summary>
        /// ContactId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ContactId { get; set; }

        /// <summary>
        /// AccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string AccountId { get; set; }

        /// <summary>
        /// CallCenterId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CallCenterId { get; set; }

        /// <summary>
        /// Extension (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Extension { get; set; }

        /// <summary>
        /// FederationIdentifier (string type in Salesforce)
        /// </summary>
        [StringLength(512)]
        public string FederationIdentifier { get; set; }

        /// <summary>
        /// AboutMe (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string AboutMe { get; set; }

        /// <summary>
        /// FullPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string FullPhotoUrl { get; set; }

        /// <summary>
        /// SmallPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string SmallPhotoUrl { get; set; }

        /// <summary>
        /// DigestFrequency (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DigestFrequency { get; set; }

        /// <summary>
        /// DefaultGroupNotificationFrequency (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DefaultGroupNotificationFrequency { get; set; }

        /// <summary>
        /// LastViewedDate (datetime type in Salesforce)
        /// </summary>
        public string LastViewedDate { get; set; }

        /// <summary>
        /// LastReferencedDate (datetime type in Salesforce)
        /// </summary>
        public string LastReferencedDate { get; set; }

    }

    /// <summary>
    /// POCO for UserFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserFeed/describe", SObject = "/services/data/v29.0/sobjects/UserFeed", RowTemplate = "/services/data/v29.0/sobjects/UserFeed/{ID}")]
    public partial class UserFeed
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// CommentCount (int type in Salesforce)
        /// </summary>
        public string CommentCount { get; set; }

        /// <summary>
        /// LikeCount (int type in Salesforce)
        /// </summary>
        public string LikeCount { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Body (textarea type in Salesforce)
        /// </summary>
        [StringLength(5000)]
        public string Body { get; set; }

        /// <summary>
        /// LinkUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// RelatedRecordId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string RelatedRecordId { get; set; }

        /// <summary>
        /// ContentData (base64 type in Salesforce)
        /// </summary>
        public string ContentData { get; set; }

        /// <summary>
        /// ContentFileName (string type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string ContentFileName { get; set; }

        /// <summary>
        /// ContentDescription (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string ContentDescription { get; set; }

        /// <summary>
        /// ContentType (string type in Salesforce)
        /// </summary>
        [StringLength(120)]
        public string ContentType { get; set; }

        /// <summary>
        /// ContentSize (int type in Salesforce)
        /// </summary>
        public string ContentSize { get; set; }

        /// <summary>
        /// InsertedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string InsertedById { get; set; }

    }

    /// <summary>
    /// POCO for UserLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserLicense/describe", SObject = "/services/data/v29.0/sobjects/UserLicense", RowTemplate = "/services/data/v29.0/sobjects/UserLicense/{ID}")]
    public partial class UserLicense
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// LicenseDefinitionKey (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LicenseDefinitionKey { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// MonthlyLoginsUsed (int type in Salesforce)
        /// </summary>
        public string MonthlyLoginsUsed { get; set; }

        /// <summary>
        /// MonthlyLoginsEntitlement (int type in Salesforce)
        /// </summary>
        public string MonthlyLoginsEntitlement { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for UserLogin
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserLogin/describe", SObject = "/services/data/v29.0/sobjects/UserLogin", RowTemplate = "/services/data/v29.0/sobjects/UserLogin/{ID}")]
    public partial class UserLogin
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserId { get; set; }

        /// <summary>
        /// IsFrozen (boolean type in Salesforce)
        /// </summary>
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// IsPasswordLocked (boolean type in Salesforce)
        /// </summary>
        public bool? IsPasswordLocked { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

    }

    /// <summary>
    /// POCO for UserPreference
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserPreference/describe", SObject = "/services/data/v29.0/sobjects/UserPreference", RowTemplate = "/services/data/v29.0/sobjects/UserPreference/{ID}")]
    public partial class UserPreference
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserId { get; set; }

        /// <summary>
        /// Preference (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Preference { get; set; }

        /// <summary>
        /// Value (string type in Salesforce)
        /// </summary>
        [StringLength(1333)]
        public string Value { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for UserProfile
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserProfile/describe", SObject = "/services/data/v29.0/sobjects/UserProfile", RowTemplate = "/services/data/v29.0/sobjects/UserProfile/{ID}")]
    public partial class UserProfile
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// LastName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string LastName { get; set; }

        /// <summary>
        /// FirstName (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string FirstName { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(121)]
        public string Name { get; set; }

        /// <summary>
        /// Title (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Title { get; set; }

        /// <summary>
        /// ManagerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ManagerId { get; set; }

        /// <summary>
        /// CompanyName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string CompanyName { get; set; }

        /// <summary>
        /// AboutMe (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string AboutMe { get; set; }

        /// <summary>
        /// Email (email type in Salesforce)
        /// </summary>
        [StringLength(128)]
        public string Email { get; set; }

        /// <summary>
        /// Phone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Phone { get; set; }

        /// <summary>
        /// MobilePhone (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Fax (phone type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Fax { get; set; }

        /// <summary>
        /// Street (textarea type in Salesforce)
        /// </summary>
        [StringLength(255)]
        public string Street { get; set; }

        /// <summary>
        /// City (string type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string City { get; set; }

        /// <summary>
        /// State (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string State { get; set; }

        /// <summary>
        /// PostalCode (string type in Salesforce)
        /// </summary>
        [StringLength(20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
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
        /// IsBadged (boolean type in Salesforce)
        /// </summary>
        public bool? IsBadged { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// UserPreferencesActivityRemindersPopup (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesActivityRemindersPopup { get; set; }

        /// <summary>
        /// UserPreferencesEventRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesEventRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// UserPreferencesTaskRemindersCheckboxDefault (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesTaskRemindersCheckboxDefault { get; set; }

        /// <summary>
        /// UserPreferencesReminderSoundOff (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesReminderSoundOff { get; set; }

        /// <summary>
        /// UserPreferencesDisableAllFeedsEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableAllFeedsEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableFollowersEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFollowersEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableProfilePostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableProfilePostEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableChangeCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableChangeCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableLaterCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableLaterCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisProfPostCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisProfPostCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesContentNoEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesContentNoEmail { get; set; }

        /// <summary>
        /// UserPreferencesContentEmailAsAndWhen (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesContentEmailAsAndWhen { get; set; }

        /// <summary>
        /// UserPreferencesApexPagesDeveloperMode (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesApexPagesDeveloperMode { get; set; }

        /// <summary>
        /// UserPreferencesHideCSNGetChatterMobileTask (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideCSNGetChatterMobileTask { get; set; }

        /// <summary>
        /// UserPreferencesDisableMentionsPostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableMentionsPostEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisMentionsCommentEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisMentionsCommentEmail { get; set; }

        /// <summary>
        /// UserPreferencesHideCSNDesktopTask (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideCSNDesktopTask { get; set; }

        /// <summary>
        /// UserPreferencesHideChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideChatterOnboardingSplash { get; set; }

        /// <summary>
        /// UserPreferencesHideSecondChatterOnboardingSplash (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideSecondChatterOnboardingSplash { get; set; }

        /// <summary>
        /// UserPreferencesDisCommentAfterLikeEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisCommentAfterLikeEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableLikeEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableLikeEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableMessageEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableMessageEmail { get; set; }

        /// <summary>
        /// UserPreferencesOptOutOfTouch (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesOptOutOfTouch { get; set; }

        /// <summary>
        /// UserPreferencesDisableBookmarkEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableBookmarkEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableSharePostEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableSharePostEmail { get; set; }

        /// <summary>
        /// UserPreferencesEnableAutoSubForFeeds (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesEnableAutoSubForFeeds { get; set; }

        /// <summary>
        /// UserPreferencesDisableFileShareNotificationsForApi (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFileShareNotificationsForApi { get; set; }

        /// <summary>
        /// UserPreferencesShowTitleToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowTitleToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowManagerToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowManagerToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowEmailToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowEmailToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowWorkPhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowWorkPhoneToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowMobilePhoneToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowMobilePhoneToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowFaxToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowFaxToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStreetAddressToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStreetAddressToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCityToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCityToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStateToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStateToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowPostalCodeToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowPostalCodeToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCountryToExternalUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCountryToExternalUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowProfilePicToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowProfilePicToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowTitleToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowTitleToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCityToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCityToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowStateToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowStateToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowPostalCodeToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowPostalCodeToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesShowCountryToGuestUsers (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesShowCountryToGuestUsers { get; set; }

        /// <summary>
        /// UserPreferencesDisableFeedbackEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableFeedbackEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableCoachingEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableCoachingEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableGoalEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableGoalEmail { get; set; }

        /// <summary>
        /// UserPreferencesDisableWorkEmail (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesDisableWorkEmail { get; set; }

        /// <summary>
        /// UserPreferencesHideS1BrowserUI (boolean type in Salesforce)
        /// </summary>
        public bool? UserPreferencesHideS1BrowserUI { get; set; }

        /// <summary>
        /// FullPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string FullPhotoUrl { get; set; }

        /// <summary>
        /// SmallPhotoUrl (url type in Salesforce)
        /// </summary>
        [StringLength(1024)]
        public string SmallPhotoUrl { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for UserRecordAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserRecordAccess/describe", SObject = "/services/data/v29.0/sobjects/UserRecordAccess", RowTemplate = "/services/data/v29.0/sobjects/UserRecordAccess/{ID}")]
    public partial class UserRecordAccess
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserId { get; set; }

        /// <summary>
        /// RecordId (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RecordId { get; set; }

        /// <summary>
        /// HasReadAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasReadAccess { get; set; }

        /// <summary>
        /// HasEditAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasEditAccess { get; set; }

        /// <summary>
        /// HasDeleteAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasDeleteAccess { get; set; }

        /// <summary>
        /// HasTransferAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasTransferAccess { get; set; }

        /// <summary>
        /// HasAllAccess (boolean type in Salesforce)
        /// </summary>
        public bool? HasAllAccess { get; set; }

        /// <summary>
        /// MaxAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string MaxAccessLevel { get; set; }

    }

    /// <summary>
    /// POCO for UserRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserRole/describe", SObject = "/services/data/v29.0/sobjects/UserRole", RowTemplate = "/services/data/v29.0/sobjects/UserRole/{ID}")]
    public partial class UserRole
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// ParentRoleId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentRoleId { get; set; }

        /// <summary>
        /// RollupDescription (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string RollupDescription { get; set; }

        /// <summary>
        /// OpportunityAccessForAccountOwner (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OpportunityAccessForAccountOwner { get; set; }

        /// <summary>
        /// CaseAccessForAccountOwner (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string CaseAccessForAccountOwner { get; set; }

        /// <summary>
        /// ContactAccessForAccountOwner (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string ContactAccessForAccountOwner { get; set; }

        /// <summary>
        /// ForecastUserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ForecastUserId { get; set; }

        /// <summary>
        /// MayForecastManagerShare (boolean type in Salesforce)
        /// </summary>
        public bool? MayForecastManagerShare { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

        /// <summary>
        /// DeveloperName (string type in Salesforce)
        /// </summary>
        [StringLength(80)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// PortalAccountId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PortalAccountId { get; set; }

        /// <summary>
        /// PortalType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PortalType { get; set; }

        /// <summary>
        /// PortalAccountOwnerId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string PortalAccountOwnerId { get; set; }

    }

    /// <summary>
    /// POCO for UserShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserShare/describe", SObject = "/services/data/v29.0/sobjects/UserShare", RowTemplate = "/services/data/v29.0/sobjects/UserShare/{ID}")]
    public partial class UserShare
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// UserId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserId { get; set; }

        /// <summary>
        /// UserOrGroupId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string UserOrGroupId { get; set; }

        /// <summary>
        /// UserAccessLevel (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string UserAccessLevel { get; set; }

        /// <summary>
        /// RowCause (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string RowCause { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// IsActive (boolean type in Salesforce)
        /// </summary>
        public bool? IsActive { get; set; }

    }

    /// <summary>
    /// POCO for Vote
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Vote/describe", SObject = "/services/data/v29.0/sobjects/Vote", RowTemplate = "/services/data/v29.0/sobjects/Vote/{ID}")]
    public partial class Vote
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// IsDeleted (boolean type in Salesforce)
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// ParentId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ParentId { get; set; }

        /// <summary>
        /// Type (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Type { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

    /// <summary>
    /// POCO for WebLink
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/WebLink/describe", SObject = "/services/data/v29.0/sobjects/WebLink", RowTemplate = "/services/data/v29.0/sobjects/WebLink/{ID}")]
    public partial class WebLink
    {
        /// <summary>
        /// Id (id type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }

        /// <summary>
        /// PageOrSobjectType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string PageOrSobjectType { get; set; }

        /// <summary>
        /// Name (string type in Salesforce)
        /// </summary>
        [StringLength(240)]
        public string Name { get; set; }

        /// <summary>
        /// IsProtected (boolean type in Salesforce)
        /// </summary>
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Url (textarea type in Salesforce)
        /// </summary>
        [StringLength(1048576)]
        public string Url { get; set; }

        /// <summary>
        /// EncodingKey (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string EncodingKey { get; set; }

        /// <summary>
        /// LinkType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string LinkType { get; set; }

        /// <summary>
        /// OpenType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string OpenType { get; set; }

        /// <summary>
        /// Height (int type in Salesforce)
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// Width (int type in Salesforce)
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// ShowsLocation (boolean type in Salesforce)
        /// </summary>
        public bool? ShowsLocation { get; set; }

        /// <summary>
        /// HasScrollbars (boolean type in Salesforce)
        /// </summary>
        public bool? HasScrollbars { get; set; }

        /// <summary>
        /// HasToolbar (boolean type in Salesforce)
        /// </summary>
        public bool? HasToolbar { get; set; }

        /// <summary>
        /// HasMenubar (boolean type in Salesforce)
        /// </summary>
        public bool? HasMenubar { get; set; }

        /// <summary>
        /// ShowsStatus (boolean type in Salesforce)
        /// </summary>
        public bool? ShowsStatus { get; set; }

        /// <summary>
        /// IsResizable (boolean type in Salesforce)
        /// </summary>
        public bool? IsResizable { get; set; }

        /// <summary>
        /// Position (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string Position { get; set; }

        /// <summary>
        /// ScontrolId (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string ScontrolId { get; set; }

        /// <summary>
        /// MasterLabel (string type in Salesforce)
        /// </summary>
        [StringLength(240)]
        public string MasterLabel { get; set; }

        /// <summary>
        /// Description (textarea type in Salesforce)
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// DisplayType (picklist type in Salesforce)
        /// </summary>
        [StringLength(40)]
        public string DisplayType { get; set; }

        /// <summary>
        /// RequireRowSelection (boolean type in Salesforce)
        /// </summary>
        public bool? RequireRowSelection { get; set; }

        /// <summary>
        /// NamespacePrefix (string type in Salesforce)
        /// </summary>
        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        /// <summary>
        /// CreatedDate (datetime type in Salesforce)
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// CreatedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string CreatedById { get; set; }

        /// <summary>
        /// LastModifiedDate (datetime type in Salesforce)
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// LastModifiedById (reference type in Salesforce)
        /// </summary>
        [StringLength(18)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// SystemModstamp (datetime type in Salesforce)
        /// </summary>
        public string SystemModstamp { get; set; }

    }

}

// ReSharper restore PartialTypeWithSinglePart
// ReSharper restore UnusedMember.Local

