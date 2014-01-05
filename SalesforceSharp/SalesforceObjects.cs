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
        /// AcceptedEventRelation Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Account
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Account/describe", SObject = "/services/data/v29.0/sobjects/Account", RowTemplate = "/services/data/v29.0/sobjects/Account/{ID}")]
    public partial class Account
    {
        /// <summary>
        /// Account Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AccountContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountContactRole/describe", SObject = "/services/data/v29.0/sobjects/AccountContactRole", RowTemplate = "/services/data/v29.0/sobjects/AccountContactRole/{ID}")]
    public partial class AccountContactRole
    {
        /// <summary>
        /// AccountContactRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AccountFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountFeed/describe", SObject = "/services/data/v29.0/sobjects/AccountFeed", RowTemplate = "/services/data/v29.0/sobjects/AccountFeed/{ID}")]
    public partial class AccountFeed
    {
        /// <summary>
        /// AccountFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AccountHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountHistory/describe", SObject = "/services/data/v29.0/sobjects/AccountHistory", RowTemplate = "/services/data/v29.0/sobjects/AccountHistory/{ID}")]
    public partial class AccountHistory
    {
        /// <summary>
        /// AccountHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AccountPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountPartner/describe", SObject = "/services/data/v29.0/sobjects/AccountPartner", RowTemplate = "/services/data/v29.0/sobjects/AccountPartner/{ID}")]
    public partial class AccountPartner
    {
        /// <summary>
        /// AccountPartner Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AccountShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AccountShare/describe", SObject = "/services/data/v29.0/sobjects/AccountShare", RowTemplate = "/services/data/v29.0/sobjects/AccountShare/{ID}")]
    public partial class AccountShare
    {
        /// <summary>
        /// AccountShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ActivityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ActivityHistory/describe", SObject = "/services/data/v29.0/sobjects/ActivityHistory", RowTemplate = "/services/data/v29.0/sobjects/ActivityHistory/{ID}")]
    public partial class ActivityHistory
    {
        /// <summary>
        /// ActivityHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AdditionalNumber
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AdditionalNumber/describe", SObject = "/services/data/v29.0/sobjects/AdditionalNumber", RowTemplate = "/services/data/v29.0/sobjects/AdditionalNumber/{ID}")]
    public partial class AdditionalNumber
    {
        /// <summary>
        /// AdditionalNumber Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AggregateResult
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AggregateResult/describe", SObject = "/services/data/v29.0/sobjects/AggregateResult", RowTemplate = "/services/data/v29.0/sobjects/AggregateResult/{ID}")]
    public partial class AggregateResult
    {
        /// <summary>
        /// AggregateResult Id
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
        /// ApexClass Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexComponent/describe", SObject = "/services/data/v29.0/sobjects/ApexComponent", RowTemplate = "/services/data/v29.0/sobjects/ApexComponent/{ID}")]
    public partial class ApexComponent
    {
        /// <summary>
        /// ApexComponent Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexLog
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexLog/describe", SObject = "/services/data/v29.0/sobjects/ApexLog", RowTemplate = "/services/data/v29.0/sobjects/ApexLog/{ID}")]
    public partial class ApexLog
    {
        /// <summary>
        /// ApexLog Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexPage
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexPage/describe", SObject = "/services/data/v29.0/sobjects/ApexPage", RowTemplate = "/services/data/v29.0/sobjects/ApexPage/{ID}")]
    public partial class ApexPage
    {
        /// <summary>
        /// ApexPage Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexTestQueueItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTestQueueItem/describe", SObject = "/services/data/v29.0/sobjects/ApexTestQueueItem", RowTemplate = "/services/data/v29.0/sobjects/ApexTestQueueItem/{ID}")]
    public partial class ApexTestQueueItem
    {
        /// <summary>
        /// ApexTestQueueItem Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexTestResult
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTestResult/describe", SObject = "/services/data/v29.0/sobjects/ApexTestResult", RowTemplate = "/services/data/v29.0/sobjects/ApexTestResult/{ID}")]
    public partial class ApexTestResult
    {
        /// <summary>
        /// ApexTestResult Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ApexTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ApexTrigger/describe", SObject = "/services/data/v29.0/sobjects/ApexTrigger", RowTemplate = "/services/data/v29.0/sobjects/ApexTrigger/{ID}")]
    public partial class ApexTrigger
    {
        /// <summary>
        /// ApexTrigger Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AppMenuItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AppMenuItem/describe", SObject = "/services/data/v29.0/sobjects/AppMenuItem", RowTemplate = "/services/data/v29.0/sobjects/AppMenuItem/{ID}")]
    public partial class AppMenuItem
    {
        /// <summary>
        /// AppMenuItem Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Approval
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Approval/describe", SObject = "/services/data/v29.0/sobjects/Approval", RowTemplate = "/services/data/v29.0/sobjects/Approval/{ID}")]
    public partial class Approval
    {
        /// <summary>
        /// Approval Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Asset
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Asset/describe", SObject = "/services/data/v29.0/sobjects/Asset", RowTemplate = "/services/data/v29.0/sobjects/Asset/{ID}")]
    public partial class Asset
    {
        /// <summary>
        /// Asset Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AssetFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AssetFeed/describe", SObject = "/services/data/v29.0/sobjects/AssetFeed", RowTemplate = "/services/data/v29.0/sobjects/AssetFeed/{ID}")]
    public partial class AssetFeed
    {
        /// <summary>
        /// AssetFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AssignmentRule
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AssignmentRule/describe", SObject = "/services/data/v29.0/sobjects/AssignmentRule", RowTemplate = "/services/data/v29.0/sobjects/AssignmentRule/{ID}")]
    public partial class AssignmentRule
    {
        /// <summary>
        /// AssignmentRule Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AsyncApexJob
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AsyncApexJob/describe", SObject = "/services/data/v29.0/sobjects/AsyncApexJob", RowTemplate = "/services/data/v29.0/sobjects/AsyncApexJob/{ID}")]
    public partial class AsyncApexJob
    {
        /// <summary>
        /// AsyncApexJob Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AttachedContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AttachedContentDocument/describe", SObject = "/services/data/v29.0/sobjects/AttachedContentDocument", RowTemplate = "/services/data/v29.0/sobjects/AttachedContentDocument/{ID}")]
    public partial class AttachedContentDocument
    {
        /// <summary>
        /// AttachedContentDocument Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Attachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Attachment/describe", SObject = "/services/data/v29.0/sobjects/Attachment", RowTemplate = "/services/data/v29.0/sobjects/Attachment/{ID}")]
    public partial class Attachment
    {
        /// <summary>
        /// Attachment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AuthProvider
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AuthProvider/describe", SObject = "/services/data/v29.0/sobjects/AuthProvider", RowTemplate = "/services/data/v29.0/sobjects/AuthProvider/{ID}")]
    public partial class AuthProvider
    {
        /// <summary>
        /// AuthProvider Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for AuthSession
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/AuthSession/describe", SObject = "/services/data/v29.0/sobjects/AuthSession", RowTemplate = "/services/data/v29.0/sobjects/AuthSession/{ID}")]
    public partial class AuthSession
    {
        /// <summary>
        /// AuthSession Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for BrandTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BrandTemplate/describe", SObject = "/services/data/v29.0/sobjects/BrandTemplate", RowTemplate = "/services/data/v29.0/sobjects/BrandTemplate/{ID}")]
    public partial class BrandTemplate
    {
        /// <summary>
        /// BrandTemplate Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for BusinessHours
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BusinessHours/describe", SObject = "/services/data/v29.0/sobjects/BusinessHours", RowTemplate = "/services/data/v29.0/sobjects/BusinessHours/{ID}")]
    public partial class BusinessHours
    {
        /// <summary>
        /// BusinessHours Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for BusinessProcess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/BusinessProcess/describe", SObject = "/services/data/v29.0/sobjects/BusinessProcess", RowTemplate = "/services/data/v29.0/sobjects/BusinessProcess/{ID}")]
    public partial class BusinessProcess
    {
        /// <summary>
        /// BusinessProcess Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CallCenter
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CallCenter/describe", SObject = "/services/data/v29.0/sobjects/CallCenter", RowTemplate = "/services/data/v29.0/sobjects/CallCenter/{ID}")]
    public partial class CallCenter
    {
        /// <summary>
        /// CallCenter Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Campaign
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Campaign/describe", SObject = "/services/data/v29.0/sobjects/Campaign", RowTemplate = "/services/data/v29.0/sobjects/Campaign/{ID}")]
    public partial class Campaign
    {
        /// <summary>
        /// Campaign Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CampaignFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignFeed/describe", SObject = "/services/data/v29.0/sobjects/CampaignFeed", RowTemplate = "/services/data/v29.0/sobjects/CampaignFeed/{ID}")]
    public partial class CampaignFeed
    {
        /// <summary>
        /// CampaignFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CampaignMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignMember/describe", SObject = "/services/data/v29.0/sobjects/CampaignMember", RowTemplate = "/services/data/v29.0/sobjects/CampaignMember/{ID}")]
    public partial class CampaignMember
    {
        /// <summary>
        /// CampaignMember Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CampaignMemberStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignMemberStatus/describe", SObject = "/services/data/v29.0/sobjects/CampaignMemberStatus", RowTemplate = "/services/data/v29.0/sobjects/CampaignMemberStatus/{ID}")]
    public partial class CampaignMemberStatus
    {
        /// <summary>
        /// CampaignMemberStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CampaignShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CampaignShare/describe", SObject = "/services/data/v29.0/sobjects/CampaignShare", RowTemplate = "/services/data/v29.0/sobjects/CampaignShare/{ID}")]
    public partial class CampaignShare
    {
        /// <summary>
        /// CampaignShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Case
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Case/describe", SObject = "/services/data/v29.0/sobjects/Case", RowTemplate = "/services/data/v29.0/sobjects/Case/{ID}")]
    public partial class Case
    {
        /// <summary>
        /// Case Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseComment/describe", SObject = "/services/data/v29.0/sobjects/CaseComment", RowTemplate = "/services/data/v29.0/sobjects/CaseComment/{ID}")]
    public partial class CaseComment
    {
        /// <summary>
        /// CaseComment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseContactRole/describe", SObject = "/services/data/v29.0/sobjects/CaseContactRole", RowTemplate = "/services/data/v29.0/sobjects/CaseContactRole/{ID}")]
    public partial class CaseContactRole
    {
        /// <summary>
        /// CaseContactRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseFeed/describe", SObject = "/services/data/v29.0/sobjects/CaseFeed", RowTemplate = "/services/data/v29.0/sobjects/CaseFeed/{ID}")]
    public partial class CaseFeed
    {
        /// <summary>
        /// CaseFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseHistory/describe", SObject = "/services/data/v29.0/sobjects/CaseHistory", RowTemplate = "/services/data/v29.0/sobjects/CaseHistory/{ID}")]
    public partial class CaseHistory
    {
        /// <summary>
        /// CaseHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseShare/describe", SObject = "/services/data/v29.0/sobjects/CaseShare", RowTemplate = "/services/data/v29.0/sobjects/CaseShare/{ID}")]
    public partial class CaseShare
    {
        /// <summary>
        /// CaseShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseSolution
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseSolution/describe", SObject = "/services/data/v29.0/sobjects/CaseSolution", RowTemplate = "/services/data/v29.0/sobjects/CaseSolution/{ID}")]
    public partial class CaseSolution
    {
        /// <summary>
        /// CaseSolution Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseStatus/describe", SObject = "/services/data/v29.0/sobjects/CaseStatus", RowTemplate = "/services/data/v29.0/sobjects/CaseStatus/{ID}")]
    public partial class CaseStatus
    {
        /// <summary>
        /// CaseStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseTeamMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamMember/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamMember", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamMember/{ID}")]
    public partial class CaseTeamMember
    {
        /// <summary>
        /// CaseTeamMember Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseTeamRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamRole/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamRole", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamRole/{ID}")]
    public partial class CaseTeamRole
    {
        /// <summary>
        /// CaseTeamRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseTeamTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplate/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplate", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplate/{ID}")]
    public partial class CaseTeamTemplate
    {
        /// <summary>
        /// CaseTeamTemplate Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseTeamTemplateMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplateMember/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplateMember", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplateMember/{ID}")]
    public partial class CaseTeamTemplateMember
    {
        /// <summary>
        /// CaseTeamTemplateMember Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CaseTeamTemplateRecord
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord/describe", SObject = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord", RowTemplate = "/services/data/v29.0/sobjects/CaseTeamTemplateRecord/{ID}")]
    public partial class CaseTeamTemplateRecord
    {
        /// <summary>
        /// CaseTeamTemplateRecord Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CategoryData
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CategoryData/describe", SObject = "/services/data/v29.0/sobjects/CategoryData", RowTemplate = "/services/data/v29.0/sobjects/CategoryData/{ID}")]
    public partial class CategoryData
    {
        /// <summary>
        /// CategoryData Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CategoryNode
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CategoryNode/describe", SObject = "/services/data/v29.0/sobjects/CategoryNode", RowTemplate = "/services/data/v29.0/sobjects/CategoryNode/{ID}")]
    public partial class CategoryNode
    {
        /// <summary>
        /// CategoryNode Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ChatterActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ChatterActivity/describe", SObject = "/services/data/v29.0/sobjects/ChatterActivity", RowTemplate = "/services/data/v29.0/sobjects/ChatterActivity/{ID}")]
    public partial class ChatterActivity
    {
        /// <summary>
        /// ChatterActivity Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ClientBrowser
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ClientBrowser/describe", SObject = "/services/data/v29.0/sobjects/ClientBrowser", RowTemplate = "/services/data/v29.0/sobjects/ClientBrowser/{ID}")]
    public partial class ClientBrowser
    {
        /// <summary>
        /// ClientBrowser Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CollaborationGroup
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroup/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroup", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroup/{ID}")]
    public partial class CollaborationGroup
    {
        /// <summary>
        /// CollaborationGroup Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CollaborationGroupFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupFeed/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupFeed", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupFeed/{ID}")]
    public partial class CollaborationGroupFeed
    {
        /// <summary>
        /// CollaborationGroupFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CollaborationGroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupMember/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupMember", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupMember/{ID}")]
    public partial class CollaborationGroupMember
    {
        /// <summary>
        /// CollaborationGroupMember Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CollaborationGroupMemberRequest
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest/describe", SObject = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest", RowTemplate = "/services/data/v29.0/sobjects/CollaborationGroupMemberRequest/{ID}")]
    public partial class CollaborationGroupMemberRequest
    {
        /// <summary>
        /// CollaborationGroupMemberRequest Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CollaborationInvitation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CollaborationInvitation/describe", SObject = "/services/data/v29.0/sobjects/CollaborationInvitation", RowTemplate = "/services/data/v29.0/sobjects/CollaborationInvitation/{ID}")]
    public partial class CollaborationInvitation
    {
        /// <summary>
        /// CollaborationInvitation Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CombinedAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CombinedAttachment/describe", SObject = "/services/data/v29.0/sobjects/CombinedAttachment", RowTemplate = "/services/data/v29.0/sobjects/CombinedAttachment/{ID}")]
    public partial class CombinedAttachment
    {
        /// <summary>
        /// CombinedAttachment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Community
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Community/describe", SObject = "/services/data/v29.0/sobjects/Community", RowTemplate = "/services/data/v29.0/sobjects/Community/{ID}")]
    public partial class Community
    {
        /// <summary>
        /// Community Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Contact
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Contact/describe", SObject = "/services/data/v29.0/sobjects/Contact", RowTemplate = "/services/data/v29.0/sobjects/Contact/{ID}")]
    public partial class Contact
    {
        /// <summary>
        /// Contact Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContactFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactFeed/describe", SObject = "/services/data/v29.0/sobjects/ContactFeed", RowTemplate = "/services/data/v29.0/sobjects/ContactFeed/{ID}")]
    public partial class ContactFeed
    {
        /// <summary>
        /// ContactFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContactHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactHistory/describe", SObject = "/services/data/v29.0/sobjects/ContactHistory", RowTemplate = "/services/data/v29.0/sobjects/ContactHistory/{ID}")]
    public partial class ContactHistory
    {
        /// <summary>
        /// ContactHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContactShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContactShare/describe", SObject = "/services/data/v29.0/sobjects/ContactShare", RowTemplate = "/services/data/v29.0/sobjects/ContactShare/{ID}")]
    public partial class ContactShare
    {
        /// <summary>
        /// ContactShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentDocument
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocument/describe", SObject = "/services/data/v29.0/sobjects/ContentDocument", RowTemplate = "/services/data/v29.0/sobjects/ContentDocument/{ID}")]
    public partial class ContentDocument
    {
        /// <summary>
        /// ContentDocument Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentDocumentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentFeed/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentFeed", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentFeed/{ID}")]
    public partial class ContentDocumentFeed
    {
        /// <summary>
        /// ContentDocumentFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentDocumentHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentHistory/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentHistory", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentHistory/{ID}")]
    public partial class ContentDocumentHistory
    {
        /// <summary>
        /// ContentDocumentHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentDocumentLink
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentDocumentLink/describe", SObject = "/services/data/v29.0/sobjects/ContentDocumentLink", RowTemplate = "/services/data/v29.0/sobjects/ContentDocumentLink/{ID}")]
    public partial class ContentDocumentLink
    {
        /// <summary>
        /// ContentDocumentLink Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentVersion
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentVersion/describe", SObject = "/services/data/v29.0/sobjects/ContentVersion", RowTemplate = "/services/data/v29.0/sobjects/ContentVersion/{ID}")]
    public partial class ContentVersion
    {
        /// <summary>
        /// ContentVersion Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentVersionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentVersionHistory/describe", SObject = "/services/data/v29.0/sobjects/ContentVersionHistory", RowTemplate = "/services/data/v29.0/sobjects/ContentVersionHistory/{ID}")]
    public partial class ContentVersionHistory
    {
        /// <summary>
        /// ContentVersionHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentWorkspace
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentWorkspace/describe", SObject = "/services/data/v29.0/sobjects/ContentWorkspace", RowTemplate = "/services/data/v29.0/sobjects/ContentWorkspace/{ID}")]
    public partial class ContentWorkspace
    {
        /// <summary>
        /// ContentWorkspace Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContentWorkspaceDoc
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContentWorkspaceDoc/describe", SObject = "/services/data/v29.0/sobjects/ContentWorkspaceDoc", RowTemplate = "/services/data/v29.0/sobjects/ContentWorkspaceDoc/{ID}")]
    public partial class ContentWorkspaceDoc
    {
        /// <summary>
        /// ContentWorkspaceDoc Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Contract
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Contract/describe", SObject = "/services/data/v29.0/sobjects/Contract", RowTemplate = "/services/data/v29.0/sobjects/Contract/{ID}")]
    public partial class Contract
    {
        /// <summary>
        /// Contract Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContractContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractContactRole/describe", SObject = "/services/data/v29.0/sobjects/ContractContactRole", RowTemplate = "/services/data/v29.0/sobjects/ContractContactRole/{ID}")]
    public partial class ContractContactRole
    {
        /// <summary>
        /// ContractContactRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContractFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractFeed/describe", SObject = "/services/data/v29.0/sobjects/ContractFeed", RowTemplate = "/services/data/v29.0/sobjects/ContractFeed/{ID}")]
    public partial class ContractFeed
    {
        /// <summary>
        /// ContractFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContractHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractHistory/describe", SObject = "/services/data/v29.0/sobjects/ContractHistory", RowTemplate = "/services/data/v29.0/sobjects/ContractHistory/{ID}")]
    public partial class ContractHistory
    {
        /// <summary>
        /// ContractHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ContractStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ContractStatus/describe", SObject = "/services/data/v29.0/sobjects/ContractStatus", RowTemplate = "/services/data/v29.0/sobjects/ContractStatus/{ID}")]
    public partial class ContractStatus
    {
        /// <summary>
        /// ContractStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CronJobDetail
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CronJobDetail/describe", SObject = "/services/data/v29.0/sobjects/CronJobDetail", RowTemplate = "/services/data/v29.0/sobjects/CronJobDetail/{ID}")]
    public partial class CronJobDetail
    {
        /// <summary>
        /// CronJobDetail Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for CronTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/CronTrigger/describe", SObject = "/services/data/v29.0/sobjects/CronTrigger", RowTemplate = "/services/data/v29.0/sobjects/CronTrigger/{ID}")]
    public partial class CronTrigger
    {
        /// <summary>
        /// CronTrigger Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Dashboard
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Dashboard/describe", SObject = "/services/data/v29.0/sobjects/Dashboard", RowTemplate = "/services/data/v29.0/sobjects/Dashboard/{ID}")]
    public partial class Dashboard
    {
        /// <summary>
        /// Dashboard Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DashboardComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardComponent/describe", SObject = "/services/data/v29.0/sobjects/DashboardComponent", RowTemplate = "/services/data/v29.0/sobjects/DashboardComponent/{ID}")]
    public partial class DashboardComponent
    {
        /// <summary>
        /// DashboardComponent Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DashboardComponentFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardComponentFeed/describe", SObject = "/services/data/v29.0/sobjects/DashboardComponentFeed", RowTemplate = "/services/data/v29.0/sobjects/DashboardComponentFeed/{ID}")]
    public partial class DashboardComponentFeed
    {
        /// <summary>
        /// DashboardComponentFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DashboardFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DashboardFeed/describe", SObject = "/services/data/v29.0/sobjects/DashboardFeed", RowTemplate = "/services/data/v29.0/sobjects/DashboardFeed/{ID}")]
    public partial class DashboardFeed
    {
        /// <summary>
        /// DashboardFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DeclinedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DeclinedEventRelation/describe", SObject = "/services/data/v29.0/sobjects/DeclinedEventRelation", RowTemplate = "/services/data/v29.0/sobjects/DeclinedEventRelation/{ID}")]
    public partial class DeclinedEventRelation
    {
        /// <summary>
        /// DeclinedEventRelation Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Document
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Document/describe", SObject = "/services/data/v29.0/sobjects/Document", RowTemplate = "/services/data/v29.0/sobjects/Document/{ID}")]
    public partial class Document
    {
        /// <summary>
        /// Document Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DocumentAttachmentMap
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DocumentAttachmentMap/describe", SObject = "/services/data/v29.0/sobjects/DocumentAttachmentMap", RowTemplate = "/services/data/v29.0/sobjects/DocumentAttachmentMap/{ID}")]
    public partial class DocumentAttachmentMap
    {
        /// <summary>
        /// DocumentAttachmentMap Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Domain
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Domain/describe", SObject = "/services/data/v29.0/sobjects/Domain", RowTemplate = "/services/data/v29.0/sobjects/Domain/{ID}")]
    public partial class Domain
    {
        /// <summary>
        /// Domain Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for DomainSite
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/DomainSite/describe", SObject = "/services/data/v29.0/sobjects/DomainSite", RowTemplate = "/services/data/v29.0/sobjects/DomainSite/{ID}")]
    public partial class DomainSite
    {
        /// <summary>
        /// DomainSite Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EmailServicesAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailServicesAddress/describe", SObject = "/services/data/v29.0/sobjects/EmailServicesAddress", RowTemplate = "/services/data/v29.0/sobjects/EmailServicesAddress/{ID}")]
    public partial class EmailServicesAddress
    {
        /// <summary>
        /// EmailServicesAddress Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EmailServicesFunction
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailServicesFunction/describe", SObject = "/services/data/v29.0/sobjects/EmailServicesFunction", RowTemplate = "/services/data/v29.0/sobjects/EmailServicesFunction/{ID}")]
    public partial class EmailServicesFunction
    {
        /// <summary>
        /// EmailServicesFunction Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EmailStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailStatus/describe", SObject = "/services/data/v29.0/sobjects/EmailStatus", RowTemplate = "/services/data/v29.0/sobjects/EmailStatus/{ID}")]
    public partial class EmailStatus
    {
        /// <summary>
        /// EmailStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EmailTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EmailTemplate/describe", SObject = "/services/data/v29.0/sobjects/EmailTemplate", RowTemplate = "/services/data/v29.0/sobjects/EmailTemplate/{ID}")]
    public partial class EmailTemplate
    {
        /// <summary>
        /// EmailTemplate Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EntitySubscription
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EntitySubscription/describe", SObject = "/services/data/v29.0/sobjects/EntitySubscription", RowTemplate = "/services/data/v29.0/sobjects/EntitySubscription/{ID}")]
    public partial class EntitySubscription
    {
        /// <summary>
        /// EntitySubscription Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Event
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Event/describe", SObject = "/services/data/v29.0/sobjects/Event", RowTemplate = "/services/data/v29.0/sobjects/Event/{ID}")]
    public partial class Event
    {
        /// <summary>
        /// Event Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EventFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EventFeed/describe", SObject = "/services/data/v29.0/sobjects/EventFeed", RowTemplate = "/services/data/v29.0/sobjects/EventFeed/{ID}")]
    public partial class EventFeed
    {
        /// <summary>
        /// EventFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for EventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/EventRelation/describe", SObject = "/services/data/v29.0/sobjects/EventRelation", RowTemplate = "/services/data/v29.0/sobjects/EventRelation/{ID}")]
    public partial class EventRelation
    {
        /// <summary>
        /// EventRelation Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedComment/describe", SObject = "/services/data/v29.0/sobjects/FeedComment", RowTemplate = "/services/data/v29.0/sobjects/FeedComment/{ID}")]
    public partial class FeedComment
    {
        /// <summary>
        /// FeedComment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedItem/describe", SObject = "/services/data/v29.0/sobjects/FeedItem", RowTemplate = "/services/data/v29.0/sobjects/FeedItem/{ID}")]
    public partial class FeedItem
    {
        /// <summary>
        /// FeedItem Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedLike
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedLike/describe", SObject = "/services/data/v29.0/sobjects/FeedLike", RowTemplate = "/services/data/v29.0/sobjects/FeedLike/{ID}")]
    public partial class FeedLike
    {
        /// <summary>
        /// FeedLike Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedPollChoice
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedPollChoice/describe", SObject = "/services/data/v29.0/sobjects/FeedPollChoice", RowTemplate = "/services/data/v29.0/sobjects/FeedPollChoice/{ID}")]
    public partial class FeedPollChoice
    {
        /// <summary>
        /// FeedPollChoice Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedPollVote
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedPollVote/describe", SObject = "/services/data/v29.0/sobjects/FeedPollVote", RowTemplate = "/services/data/v29.0/sobjects/FeedPollVote/{ID}")]
    public partial class FeedPollVote
    {
        /// <summary>
        /// FeedPollVote Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FeedTrackedChange
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FeedTrackedChange/describe", SObject = "/services/data/v29.0/sobjects/FeedTrackedChange", RowTemplate = "/services/data/v29.0/sobjects/FeedTrackedChange/{ID}")]
    public partial class FeedTrackedChange
    {
        /// <summary>
        /// FeedTrackedChange Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FieldPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FieldPermissions/describe", SObject = "/services/data/v29.0/sobjects/FieldPermissions", RowTemplate = "/services/data/v29.0/sobjects/FieldPermissions/{ID}")]
    public partial class FieldPermissions
    {
        /// <summary>
        /// FieldPermissions Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for FiscalYearSettings
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/FiscalYearSettings/describe", SObject = "/services/data/v29.0/sobjects/FiscalYearSettings", RowTemplate = "/services/data/v29.0/sobjects/FiscalYearSettings/{ID}")]
    public partial class FiscalYearSettings
    {
        /// <summary>
        /// FiscalYearSettings Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Folder
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Folder/describe", SObject = "/services/data/v29.0/sobjects/Folder", RowTemplate = "/services/data/v29.0/sobjects/Folder/{ID}")]
    public partial class Folder
    {
        /// <summary>
        /// Folder Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ForecastShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ForecastShare/describe", SObject = "/services/data/v29.0/sobjects/ForecastShare", RowTemplate = "/services/data/v29.0/sobjects/ForecastShare/{ID}")]
    public partial class ForecastShare
    {
        /// <summary>
        /// ForecastShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Group
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Group/describe", SObject = "/services/data/v29.0/sobjects/Group", RowTemplate = "/services/data/v29.0/sobjects/Group/{ID}")]
    public partial class Group
    {
        /// <summary>
        /// Group Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for GroupMember
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/GroupMember/describe", SObject = "/services/data/v29.0/sobjects/GroupMember", RowTemplate = "/services/data/v29.0/sobjects/GroupMember/{ID}")]
    public partial class GroupMember
    {
        /// <summary>
        /// GroupMember Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for HashtagDefinition
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/HashtagDefinition/describe", SObject = "/services/data/v29.0/sobjects/HashtagDefinition", RowTemplate = "/services/data/v29.0/sobjects/HashtagDefinition/{ID}")]
    public partial class HashtagDefinition
    {
        /// <summary>
        /// HashtagDefinition Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Holiday
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Holiday/describe", SObject = "/services/data/v29.0/sobjects/Holiday", RowTemplate = "/services/data/v29.0/sobjects/Holiday/{ID}")]
    public partial class Holiday
    {
        /// <summary>
        /// Holiday Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Idea
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Idea/describe", SObject = "/services/data/v29.0/sobjects/Idea", RowTemplate = "/services/data/v29.0/sobjects/Idea/{ID}")]
    public partial class Idea
    {
        /// <summary>
        /// Idea Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for IdeaComment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/IdeaComment/describe", SObject = "/services/data/v29.0/sobjects/IdeaComment", RowTemplate = "/services/data/v29.0/sobjects/IdeaComment/{ID}")]
    public partial class IdeaComment
    {
        /// <summary>
        /// IdeaComment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Lead
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Lead/describe", SObject = "/services/data/v29.0/sobjects/Lead", RowTemplate = "/services/data/v29.0/sobjects/Lead/{ID}")]
    public partial class Lead
    {
        /// <summary>
        /// Lead Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LeadFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadFeed/describe", SObject = "/services/data/v29.0/sobjects/LeadFeed", RowTemplate = "/services/data/v29.0/sobjects/LeadFeed/{ID}")]
    public partial class LeadFeed
    {
        /// <summary>
        /// LeadFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LeadHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadHistory/describe", SObject = "/services/data/v29.0/sobjects/LeadHistory", RowTemplate = "/services/data/v29.0/sobjects/LeadHistory/{ID}")]
    public partial class LeadHistory
    {
        /// <summary>
        /// LeadHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LeadShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadShare/describe", SObject = "/services/data/v29.0/sobjects/LeadShare", RowTemplate = "/services/data/v29.0/sobjects/LeadShare/{ID}")]
    public partial class LeadShare
    {
        /// <summary>
        /// LeadShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LeadStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LeadStatus/describe", SObject = "/services/data/v29.0/sobjects/LeadStatus", RowTemplate = "/services/data/v29.0/sobjects/LeadStatus/{ID}")]
    public partial class LeadStatus
    {
        /// <summary>
        /// LeadStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LoginHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LoginHistory/describe", SObject = "/services/data/v29.0/sobjects/LoginHistory", RowTemplate = "/services/data/v29.0/sobjects/LoginHistory/{ID}")]
    public partial class LoginHistory
    {
        /// <summary>
        /// LoginHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for LoginIp
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/LoginIp/describe", SObject = "/services/data/v29.0/sobjects/LoginIp", RowTemplate = "/services/data/v29.0/sobjects/LoginIp/{ID}")]
    public partial class LoginIp
    {
        /// <summary>
        /// LoginIp Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for MailmergeTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/MailmergeTemplate/describe", SObject = "/services/data/v29.0/sobjects/MailmergeTemplate", RowTemplate = "/services/data/v29.0/sobjects/MailmergeTemplate/{ID}")]
    public partial class MailmergeTemplate
    {
        /// <summary>
        /// MailmergeTemplate Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Name
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Name/describe", SObject = "/services/data/v29.0/sobjects/Name", RowTemplate = "/services/data/v29.0/sobjects/Name/{ID}")]
    public partial class Name
    {
        /// <summary>
        /// Name Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Note
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Note/describe", SObject = "/services/data/v29.0/sobjects/Note", RowTemplate = "/services/data/v29.0/sobjects/Note/{ID}")]
    public partial class Note
    {
        /// <summary>
        /// Note Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for NoteAndAttachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/NoteAndAttachment/describe", SObject = "/services/data/v29.0/sobjects/NoteAndAttachment", RowTemplate = "/services/data/v29.0/sobjects/NoteAndAttachment/{ID}")]
    public partial class NoteAndAttachment
    {
        /// <summary>
        /// NoteAndAttachment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ObjectPermissions
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ObjectPermissions/describe", SObject = "/services/data/v29.0/sobjects/ObjectPermissions", RowTemplate = "/services/data/v29.0/sobjects/ObjectPermissions/{ID}")]
    public partial class ObjectPermissions
    {
        /// <summary>
        /// ObjectPermissions Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpenActivity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpenActivity/describe", SObject = "/services/data/v29.0/sobjects/OpenActivity", RowTemplate = "/services/data/v29.0/sobjects/OpenActivity/{ID}")]
    public partial class OpenActivity
    {
        /// <summary>
        /// OpenActivity Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Opportunity
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Opportunity/describe", SObject = "/services/data/v29.0/sobjects/Opportunity", RowTemplate = "/services/data/v29.0/sobjects/Opportunity/{ID}")]
    public partial class Opportunity
    {
        /// <summary>
        /// Opportunity Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityCompetitor
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityCompetitor/describe", SObject = "/services/data/v29.0/sobjects/OpportunityCompetitor", RowTemplate = "/services/data/v29.0/sobjects/OpportunityCompetitor/{ID}")]
    public partial class OpportunityCompetitor
    {
        /// <summary>
        /// OpportunityCompetitor Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityContactRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityContactRole/describe", SObject = "/services/data/v29.0/sobjects/OpportunityContactRole", RowTemplate = "/services/data/v29.0/sobjects/OpportunityContactRole/{ID}")]
    public partial class OpportunityContactRole
    {
        /// <summary>
        /// OpportunityContactRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityFeed/describe", SObject = "/services/data/v29.0/sobjects/OpportunityFeed", RowTemplate = "/services/data/v29.0/sobjects/OpportunityFeed/{ID}")]
    public partial class OpportunityFeed
    {
        /// <summary>
        /// OpportunityFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityFieldHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityFieldHistory/describe", SObject = "/services/data/v29.0/sobjects/OpportunityFieldHistory", RowTemplate = "/services/data/v29.0/sobjects/OpportunityFieldHistory/{ID}")]
    public partial class OpportunityFieldHistory
    {
        /// <summary>
        /// OpportunityFieldHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityHistory/describe", SObject = "/services/data/v29.0/sobjects/OpportunityHistory", RowTemplate = "/services/data/v29.0/sobjects/OpportunityHistory/{ID}")]
    public partial class OpportunityHistory
    {
        /// <summary>
        /// OpportunityHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityLineItem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityLineItem/describe", SObject = "/services/data/v29.0/sobjects/OpportunityLineItem", RowTemplate = "/services/data/v29.0/sobjects/OpportunityLineItem/{ID}")]
    public partial class OpportunityLineItem
    {
        /// <summary>
        /// OpportunityLineItem Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityPartner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityPartner/describe", SObject = "/services/data/v29.0/sobjects/OpportunityPartner", RowTemplate = "/services/data/v29.0/sobjects/OpportunityPartner/{ID}")]
    public partial class OpportunityPartner
    {
        /// <summary>
        /// OpportunityPartner Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityShare/describe", SObject = "/services/data/v29.0/sobjects/OpportunityShare", RowTemplate = "/services/data/v29.0/sobjects/OpportunityShare/{ID}")]
    public partial class OpportunityShare
    {
        /// <summary>
        /// OpportunityShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OpportunityStage
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OpportunityStage/describe", SObject = "/services/data/v29.0/sobjects/OpportunityStage", RowTemplate = "/services/data/v29.0/sobjects/OpportunityStage/{ID}")]
    public partial class OpportunityStage
    {
        /// <summary>
        /// OpportunityStage Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for OrgWideEmailAddress
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/OrgWideEmailAddress/describe", SObject = "/services/data/v29.0/sobjects/OrgWideEmailAddress", RowTemplate = "/services/data/v29.0/sobjects/OrgWideEmailAddress/{ID}")]
    public partial class OrgWideEmailAddress
    {
        /// <summary>
        /// OrgWideEmailAddress Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Organization
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Organization/describe", SObject = "/services/data/v29.0/sobjects/Organization", RowTemplate = "/services/data/v29.0/sobjects/Organization/{ID}")]
    public partial class Organization
    {
        /// <summary>
        /// Organization Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Partner
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Partner/describe", SObject = "/services/data/v29.0/sobjects/Partner", RowTemplate = "/services/data/v29.0/sobjects/Partner/{ID}")]
    public partial class Partner
    {
        /// <summary>
        /// Partner Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PartnerRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PartnerRole/describe", SObject = "/services/data/v29.0/sobjects/PartnerRole", RowTemplate = "/services/data/v29.0/sobjects/PartnerRole/{ID}")]
    public partial class PartnerRole
    {
        /// <summary>
        /// PartnerRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Period
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Period/describe", SObject = "/services/data/v29.0/sobjects/Period", RowTemplate = "/services/data/v29.0/sobjects/Period/{ID}")]
    public partial class Period
    {
        /// <summary>
        /// Period Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PermissionSet
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSet/describe", SObject = "/services/data/v29.0/sobjects/PermissionSet", RowTemplate = "/services/data/v29.0/sobjects/PermissionSet/{ID}")]
    public partial class PermissionSet
    {
        /// <summary>
        /// PermissionSet Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PermissionSetAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetAssignment/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetAssignment", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetAssignment/{ID}")]
    public partial class PermissionSetAssignment
    {
        /// <summary>
        /// PermissionSetAssignment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PermissionSetLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetLicense/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetLicense", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetLicense/{ID}")]
    public partial class PermissionSetLicense
    {
        /// <summary>
        /// PermissionSetLicense Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PermissionSetLicenseAssign
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign/describe", SObject = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign", RowTemplate = "/services/data/v29.0/sobjects/PermissionSetLicenseAssign/{ID}")]
    public partial class PermissionSetLicenseAssign
    {
        /// <summary>
        /// PermissionSetLicenseAssign Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Pricebook2
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Pricebook2/describe", SObject = "/services/data/v29.0/sobjects/Pricebook2", RowTemplate = "/services/data/v29.0/sobjects/Pricebook2/{ID}")]
    public partial class Pricebook2
    {
        /// <summary>
        /// Pricebook2 Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Pricebook2History
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Pricebook2History/describe", SObject = "/services/data/v29.0/sobjects/Pricebook2History", RowTemplate = "/services/data/v29.0/sobjects/Pricebook2History/{ID}")]
    public partial class Pricebook2History
    {
        /// <summary>
        /// Pricebook2History Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PricebookEntry
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PricebookEntry/describe", SObject = "/services/data/v29.0/sobjects/PricebookEntry", RowTemplate = "/services/data/v29.0/sobjects/PricebookEntry/{ID}")]
    public partial class PricebookEntry
    {
        /// <summary>
        /// PricebookEntry Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ProcessInstance
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstance/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstance", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstance/{ID}")]
    public partial class ProcessInstance
    {
        /// <summary>
        /// ProcessInstance Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ProcessInstanceHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceHistory/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceHistory", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceHistory/{ID}")]
    public partial class ProcessInstanceHistory
    {
        /// <summary>
        /// ProcessInstanceHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ProcessInstanceStep
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceStep/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceStep", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceStep/{ID}")]
    public partial class ProcessInstanceStep
    {
        /// <summary>
        /// ProcessInstanceStep Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ProcessInstanceWorkitem
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem/describe", SObject = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem", RowTemplate = "/services/data/v29.0/sobjects/ProcessInstanceWorkitem/{ID}")]
    public partial class ProcessInstanceWorkitem
    {
        /// <summary>
        /// ProcessInstanceWorkitem Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Product2
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Product2/describe", SObject = "/services/data/v29.0/sobjects/Product2", RowTemplate = "/services/data/v29.0/sobjects/Product2/{ID}")]
    public partial class Product2
    {
        /// <summary>
        /// Product2 Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Product2Feed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Product2Feed/describe", SObject = "/services/data/v29.0/sobjects/Product2Feed", RowTemplate = "/services/data/v29.0/sobjects/Product2Feed/{ID}")]
    public partial class Product2Feed
    {
        /// <summary>
        /// Product2Feed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Profile
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Profile/describe", SObject = "/services/data/v29.0/sobjects/Profile", RowTemplate = "/services/data/v29.0/sobjects/Profile/{ID}")]
    public partial class Profile
    {
        /// <summary>
        /// Profile Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for PushTopic
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/PushTopic/describe", SObject = "/services/data/v29.0/sobjects/PushTopic", RowTemplate = "/services/data/v29.0/sobjects/PushTopic/{ID}")]
    public partial class PushTopic
    {
        /// <summary>
        /// PushTopic Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for QueueSobject
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/QueueSobject/describe", SObject = "/services/data/v29.0/sobjects/QueueSobject", RowTemplate = "/services/data/v29.0/sobjects/QueueSobject/{ID}")]
    public partial class QueueSobject
    {
        /// <summary>
        /// QueueSobject Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for RecentlyViewed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/RecentlyViewed/describe", SObject = "/services/data/v29.0/sobjects/RecentlyViewed", RowTemplate = "/services/data/v29.0/sobjects/RecentlyViewed/{ID}")]
    public partial class RecentlyViewed
    {
        /// <summary>
        /// RecentlyViewed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for RecordType
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/RecordType/describe", SObject = "/services/data/v29.0/sobjects/RecordType", RowTemplate = "/services/data/v29.0/sobjects/RecordType/{ID}")]
    public partial class RecordType
    {
        /// <summary>
        /// RecordType Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Report
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Report/describe", SObject = "/services/data/v29.0/sobjects/Report", RowTemplate = "/services/data/v29.0/sobjects/Report/{ID}")]
    public partial class Report
    {
        /// <summary>
        /// Report Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for ReportFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/ReportFeed/describe", SObject = "/services/data/v29.0/sobjects/ReportFeed", RowTemplate = "/services/data/v29.0/sobjects/ReportFeed/{ID}")]
    public partial class ReportFeed
    {
        /// <summary>
        /// ReportFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SetupEntityAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SetupEntityAccess/describe", SObject = "/services/data/v29.0/sobjects/SetupEntityAccess", RowTemplate = "/services/data/v29.0/sobjects/SetupEntityAccess/{ID}")]
    public partial class SetupEntityAccess
    {
        /// <summary>
        /// SetupEntityAccess Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Site
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Site/describe", SObject = "/services/data/v29.0/sobjects/Site", RowTemplate = "/services/data/v29.0/sobjects/Site/{ID}")]
    public partial class Site
    {
        /// <summary>
        /// Site Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SiteFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SiteFeed/describe", SObject = "/services/data/v29.0/sobjects/SiteFeed", RowTemplate = "/services/data/v29.0/sobjects/SiteFeed/{ID}")]
    public partial class SiteFeed
    {
        /// <summary>
        /// SiteFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SiteHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SiteHistory/describe", SObject = "/services/data/v29.0/sobjects/SiteHistory", RowTemplate = "/services/data/v29.0/sobjects/SiteHistory/{ID}")]
    public partial class SiteHistory
    {
        /// <summary>
        /// SiteHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Solution
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Solution/describe", SObject = "/services/data/v29.0/sobjects/Solution", RowTemplate = "/services/data/v29.0/sobjects/Solution/{ID}")]
    public partial class Solution
    {
        /// <summary>
        /// Solution Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SolutionFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionFeed/describe", SObject = "/services/data/v29.0/sobjects/SolutionFeed", RowTemplate = "/services/data/v29.0/sobjects/SolutionFeed/{ID}")]
    public partial class SolutionFeed
    {
        /// <summary>
        /// SolutionFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SolutionHistory
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionHistory/describe", SObject = "/services/data/v29.0/sobjects/SolutionHistory", RowTemplate = "/services/data/v29.0/sobjects/SolutionHistory/{ID}")]
    public partial class SolutionHistory
    {
        /// <summary>
        /// SolutionHistory Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for SolutionStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/SolutionStatus/describe", SObject = "/services/data/v29.0/sobjects/SolutionStatus", RowTemplate = "/services/data/v29.0/sobjects/SolutionStatus/{ID}")]
    public partial class SolutionStatus
    {
        /// <summary>
        /// SolutionStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for StaticResource
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/StaticResource/describe", SObject = "/services/data/v29.0/sobjects/StaticResource", RowTemplate = "/services/data/v29.0/sobjects/StaticResource/{ID}")]
    public partial class StaticResource
    {
        /// <summary>
        /// StaticResource Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Task
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Task/describe", SObject = "/services/data/v29.0/sobjects/Task", RowTemplate = "/services/data/v29.0/sobjects/Task/{ID}")]
    public partial class Task
    {
        /// <summary>
        /// Task Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for TaskFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskFeed/describe", SObject = "/services/data/v29.0/sobjects/TaskFeed", RowTemplate = "/services/data/v29.0/sobjects/TaskFeed/{ID}")]
    public partial class TaskFeed
    {
        /// <summary>
        /// TaskFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for TaskPriority
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskPriority/describe", SObject = "/services/data/v29.0/sobjects/TaskPriority", RowTemplate = "/services/data/v29.0/sobjects/TaskPriority/{ID}")]
    public partial class TaskPriority
    {
        /// <summary>
        /// TaskPriority Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for TaskStatus
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TaskStatus/describe", SObject = "/services/data/v29.0/sobjects/TaskStatus", RowTemplate = "/services/data/v29.0/sobjects/TaskStatus/{ID}")]
    public partial class TaskStatus
    {
        /// <summary>
        /// TaskStatus Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Topic
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Topic/describe", SObject = "/services/data/v29.0/sobjects/Topic", RowTemplate = "/services/data/v29.0/sobjects/Topic/{ID}")]
    public partial class Topic
    {
        /// <summary>
        /// Topic Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for TopicAssignment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TopicAssignment/describe", SObject = "/services/data/v29.0/sobjects/TopicAssignment", RowTemplate = "/services/data/v29.0/sobjects/TopicAssignment/{ID}")]
    public partial class TopicAssignment
    {
        /// <summary>
        /// TopicAssignment Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for TopicFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/TopicFeed/describe", SObject = "/services/data/v29.0/sobjects/TopicFeed", RowTemplate = "/services/data/v29.0/sobjects/TopicFeed/{ID}")]
    public partial class TopicFeed
    {
        /// <summary>
        /// TopicFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UndecidedEventRelation
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UndecidedEventRelation/describe", SObject = "/services/data/v29.0/sobjects/UndecidedEventRelation", RowTemplate = "/services/data/v29.0/sobjects/UndecidedEventRelation/{ID}")]
    public partial class UndecidedEventRelation
    {
        /// <summary>
        /// UndecidedEventRelation Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for User
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/User/describe", SObject = "/services/data/v29.0/sobjects/User", RowTemplate = "/services/data/v29.0/sobjects/User/{ID}")]
    public partial class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserFeed/describe", SObject = "/services/data/v29.0/sobjects/UserFeed", RowTemplate = "/services/data/v29.0/sobjects/UserFeed/{ID}")]
    public partial class UserFeed
    {
        /// <summary>
        /// UserFeed Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserLicense
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserLicense/describe", SObject = "/services/data/v29.0/sobjects/UserLicense", RowTemplate = "/services/data/v29.0/sobjects/UserLicense/{ID}")]
    public partial class UserLicense
    {
        /// <summary>
        /// UserLicense Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserLogin
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserLogin/describe", SObject = "/services/data/v29.0/sobjects/UserLogin", RowTemplate = "/services/data/v29.0/sobjects/UserLogin/{ID}")]
    public partial class UserLogin
    {
        /// <summary>
        /// UserLogin Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserPreference
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserPreference/describe", SObject = "/services/data/v29.0/sobjects/UserPreference", RowTemplate = "/services/data/v29.0/sobjects/UserPreference/{ID}")]
    public partial class UserPreference
    {
        /// <summary>
        /// UserPreference Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserProfile
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserProfile/describe", SObject = "/services/data/v29.0/sobjects/UserProfile", RowTemplate = "/services/data/v29.0/sobjects/UserProfile/{ID}")]
    public partial class UserProfile
    {
        /// <summary>
        /// UserProfile Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserRecordAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserRecordAccess/describe", SObject = "/services/data/v29.0/sobjects/UserRecordAccess", RowTemplate = "/services/data/v29.0/sobjects/UserRecordAccess/{ID}")]
    public partial class UserRecordAccess
    {
        /// <summary>
        /// UserRecordAccess Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserRole
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserRole/describe", SObject = "/services/data/v29.0/sobjects/UserRole", RowTemplate = "/services/data/v29.0/sobjects/UserRole/{ID}")]
    public partial class UserRole
    {
        /// <summary>
        /// UserRole Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for UserShare
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/UserShare/describe", SObject = "/services/data/v29.0/sobjects/UserShare", RowTemplate = "/services/data/v29.0/sobjects/UserShare/{ID}")]
    public partial class UserShare
    {
        /// <summary>
        /// UserShare Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for Vote
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/Vote/describe", SObject = "/services/data/v29.0/sobjects/Vote", RowTemplate = "/services/data/v29.0/sobjects/Vote/{ID}")]
    public partial class Vote
    {
        /// <summary>
        /// Vote Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

    /// <summary>
    /// POCO for WebLink
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
    [SalesforceObject(Describe = "/services/data/v29.0/sobjects/WebLink/describe", SObject = "/services/data/v29.0/sobjects/WebLink", RowTemplate = "/services/data/v29.0/sobjects/WebLink/{ID}")]
    public partial class WebLink
    {
        /// <summary>
        /// WebLink Id
        /// </summary>
        [StringLength(18)]
        public string Id { get; set; }
    }

}

// ReSharper restore PartialTypeWithSinglePart
// ReSharper restore UnusedMember.Local

