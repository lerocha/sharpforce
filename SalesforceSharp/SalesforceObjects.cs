 
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
//using Newtonsoft.Json;

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMember.Local

namespace SalesforceSharp 
{
    /// <summary>
    /// POCO for Account
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Account
	{
		public const string Describe = "/services/data/v26.0/sobjects/Account/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Account";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Account/{ID}";

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
	public partial class AccountContactRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/AccountContactRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AccountContactRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AccountContactRole/{ID}";

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
	public partial class AccountFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/AccountFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AccountFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AccountFeed/{ID}";

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
	public partial class AccountHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/AccountHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AccountHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AccountHistory/{ID}";

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
	public partial class AccountPartner
	{
		public const string Describe = "/services/data/v26.0/sobjects/AccountPartner/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AccountPartner";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AccountPartner/{ID}";

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
	public partial class AccountShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/AccountShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AccountShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AccountShare/{ID}";

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
	public partial class ActivityHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ActivityHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ActivityHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ActivityHistory/{ID}";

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
	public partial class AdditionalNumber
	{
		public const string Describe = "/services/data/v26.0/sobjects/AdditionalNumber/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AdditionalNumber";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AdditionalNumber/{ID}";

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
	public partial class AggregateResult
	{
		public const string Describe = "/services/data/v26.0/sobjects/AggregateResult/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AggregateResult";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AggregateResult/{ID}";

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
	public partial class ApexClass
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexClass/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexClass";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexClass/{ID}";

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
	public partial class ApexComponent
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexComponent/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexComponent";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexComponent/{ID}";

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
	public partial class ApexLog
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexLog/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexLog";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexLog/{ID}";

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
	public partial class ApexPage
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexPage/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexPage";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexPage/{ID}";

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
	public partial class ApexTestQueueItem
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexTestQueueItem/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexTestQueueItem";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexTestQueueItem/{ID}";

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
	public partial class ApexTestResult
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexTestResult/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexTestResult";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexTestResult/{ID}";

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
	public partial class ApexTrigger
	{
		public const string Describe = "/services/data/v26.0/sobjects/ApexTrigger/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ApexTrigger";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ApexTrigger/{ID}";

        /// <summary>
        /// ApexTrigger Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Approval
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Approval
	{
		public const string Describe = "/services/data/v26.0/sobjects/Approval/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Approval";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Approval/{ID}";

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
	public partial class Asset
	{
		public const string Describe = "/services/data/v26.0/sobjects/Asset/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Asset";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Asset/{ID}";

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
	public partial class AssetFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/AssetFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AssetFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AssetFeed/{ID}";

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
	public partial class AssignmentRule
	{
		public const string Describe = "/services/data/v26.0/sobjects/AssignmentRule/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AssignmentRule";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AssignmentRule/{ID}";

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
	public partial class AsyncApexJob
	{
		public const string Describe = "/services/data/v26.0/sobjects/AsyncApexJob/describe";
        public const string SObject = "/services/data/v26.0/sobjects/AsyncApexJob";
        public const string RowTemplate = "/services/data/v26.0/sobjects/AsyncApexJob/{ID}";

        /// <summary>
        /// AsyncApexJob Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Attachment
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Attachment
	{
		public const string Describe = "/services/data/v26.0/sobjects/Attachment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Attachment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Attachment/{ID}";

        /// <summary>
        /// Attachment Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for BrandTemplate
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class BrandTemplate
	{
		public const string Describe = "/services/data/v26.0/sobjects/BrandTemplate/describe";
        public const string SObject = "/services/data/v26.0/sobjects/BrandTemplate";
        public const string RowTemplate = "/services/data/v26.0/sobjects/BrandTemplate/{ID}";

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
	public partial class BusinessHours
	{
		public const string Describe = "/services/data/v26.0/sobjects/BusinessHours/describe";
        public const string SObject = "/services/data/v26.0/sobjects/BusinessHours";
        public const string RowTemplate = "/services/data/v26.0/sobjects/BusinessHours/{ID}";

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
	public partial class BusinessProcess
	{
		public const string Describe = "/services/data/v26.0/sobjects/BusinessProcess/describe";
        public const string SObject = "/services/data/v26.0/sobjects/BusinessProcess";
        public const string RowTemplate = "/services/data/v26.0/sobjects/BusinessProcess/{ID}";

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
	public partial class CallCenter
	{
		public const string Describe = "/services/data/v26.0/sobjects/CallCenter/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CallCenter";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CallCenter/{ID}";

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
	public partial class Campaign
	{
		public const string Describe = "/services/data/v26.0/sobjects/Campaign/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Campaign";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Campaign/{ID}";

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
	public partial class CampaignFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/CampaignFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CampaignFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CampaignFeed/{ID}";

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
	public partial class CampaignMember
	{
		public const string Describe = "/services/data/v26.0/sobjects/CampaignMember/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CampaignMember";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CampaignMember/{ID}";

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
	public partial class CampaignMemberStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/CampaignMemberStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CampaignMemberStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CampaignMemberStatus/{ID}";

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
	public partial class CampaignShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/CampaignShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CampaignShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CampaignShare/{ID}";

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
	public partial class Case
	{
		public const string Describe = "/services/data/v26.0/sobjects/Case/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Case";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Case/{ID}";

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
	public partial class CaseComment
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseComment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseComment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseComment/{ID}";

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
	public partial class CaseContactRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseContactRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseContactRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseContactRole/{ID}";

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
	public partial class CaseFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseFeed/{ID}";

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
	public partial class CaseHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseHistory/{ID}";

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
	public partial class CaseShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseShare/{ID}";

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
	public partial class CaseSolution
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseSolution/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseSolution";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseSolution/{ID}";

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
	public partial class CaseStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseStatus/{ID}";

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
	public partial class CaseTeamMember
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseTeamMember/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseTeamMember";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseTeamMember/{ID}";

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
	public partial class CaseTeamRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseTeamRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseTeamRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseTeamRole/{ID}";

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
	public partial class CaseTeamTemplate
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseTeamTemplate/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseTeamTemplate";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseTeamTemplate/{ID}";

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
	public partial class CaseTeamTemplateMember
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseTeamTemplateMember/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseTeamTemplateMember";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseTeamTemplateMember/{ID}";

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
	public partial class CaseTeamTemplateRecord
	{
		public const string Describe = "/services/data/v26.0/sobjects/CaseTeamTemplateRecord/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CaseTeamTemplateRecord";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CaseTeamTemplateRecord/{ID}";

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
	public partial class CategoryData
	{
		public const string Describe = "/services/data/v26.0/sobjects/CategoryData/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CategoryData";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CategoryData/{ID}";

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
	public partial class CategoryNode
	{
		public const string Describe = "/services/data/v26.0/sobjects/CategoryNode/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CategoryNode";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CategoryNode/{ID}";

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
	public partial class ChatterActivity
	{
		public const string Describe = "/services/data/v26.0/sobjects/ChatterActivity/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ChatterActivity";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ChatterActivity/{ID}";

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
	public partial class ClientBrowser
	{
		public const string Describe = "/services/data/v26.0/sobjects/ClientBrowser/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ClientBrowser";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ClientBrowser/{ID}";

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
	public partial class CollaborationGroup
	{
		public const string Describe = "/services/data/v26.0/sobjects/CollaborationGroup/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CollaborationGroup";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CollaborationGroup/{ID}";

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
	public partial class CollaborationGroupFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/CollaborationGroupFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CollaborationGroupFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CollaborationGroupFeed/{ID}";

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
	public partial class CollaborationGroupMember
	{
		public const string Describe = "/services/data/v26.0/sobjects/CollaborationGroupMember/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CollaborationGroupMember";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CollaborationGroupMember/{ID}";

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
	public partial class CollaborationGroupMemberRequest
	{
		public const string Describe = "/services/data/v26.0/sobjects/CollaborationGroupMemberRequest/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CollaborationGroupMemberRequest";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CollaborationGroupMemberRequest/{ID}";

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
	public partial class CollaborationInvitation
	{
		public const string Describe = "/services/data/v26.0/sobjects/CollaborationInvitation/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CollaborationInvitation";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CollaborationInvitation/{ID}";

        /// <summary>
        /// CollaborationInvitation Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Community
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Community
	{
		public const string Describe = "/services/data/v26.0/sobjects/Community/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Community";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Community/{ID}";

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
	public partial class Contact
	{
		public const string Describe = "/services/data/v26.0/sobjects/Contact/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Contact";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Contact/{ID}";

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
	public partial class ContactFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContactFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContactFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContactFeed/{ID}";

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
	public partial class ContactHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContactHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContactHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContactHistory/{ID}";

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
	public partial class ContactShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContactShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContactShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContactShare/{ID}";

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
	public partial class ContentDocument
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentDocument/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentDocument";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentDocument/{ID}";

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
	public partial class ContentDocumentFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentDocumentFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentDocumentFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentDocumentFeed/{ID}";

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
	public partial class ContentDocumentHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentDocumentHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentDocumentHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentDocumentHistory/{ID}";

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
	public partial class ContentDocumentLink
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentDocumentLink/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentDocumentLink";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentDocumentLink/{ID}";

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
	public partial class ContentVersion
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentVersion/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentVersion";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentVersion/{ID}";

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
	public partial class ContentVersionHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentVersionHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentVersionHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentVersionHistory/{ID}";

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
	public partial class ContentWorkspace
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentWorkspace/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentWorkspace";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentWorkspace/{ID}";

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
	public partial class ContentWorkspaceDoc
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContentWorkspaceDoc/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContentWorkspaceDoc";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContentWorkspaceDoc/{ID}";

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
	public partial class Contract
	{
		public const string Describe = "/services/data/v26.0/sobjects/Contract/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Contract";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Contract/{ID}";

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
	public partial class ContractContactRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContractContactRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContractContactRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContractContactRole/{ID}";

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
	public partial class ContractFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContractFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContractFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContractFeed/{ID}";

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
	public partial class ContractHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContractHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContractHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContractHistory/{ID}";

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
	public partial class ContractStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/ContractStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ContractStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ContractStatus/{ID}";

        /// <summary>
        /// ContractStatus Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for CronTrigger
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class CronTrigger
	{
		public const string Describe = "/services/data/v26.0/sobjects/CronTrigger/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CronTrigger";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CronTrigger/{ID}";

        /// <summary>
        /// CronTrigger Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for CustomConsoleComponent
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class CustomConsoleComponent
	{
		public const string Describe = "/services/data/v26.0/sobjects/CustomConsoleComponent/describe";
        public const string SObject = "/services/data/v26.0/sobjects/CustomConsoleComponent";
        public const string RowTemplate = "/services/data/v26.0/sobjects/CustomConsoleComponent/{ID}";

        /// <summary>
        /// CustomConsoleComponent Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Dashboard
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Dashboard
	{
		public const string Describe = "/services/data/v26.0/sobjects/Dashboard/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Dashboard";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Dashboard/{ID}";

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
	public partial class DashboardComponent
	{
		public const string Describe = "/services/data/v26.0/sobjects/DashboardComponent/describe";
        public const string SObject = "/services/data/v26.0/sobjects/DashboardComponent";
        public const string RowTemplate = "/services/data/v26.0/sobjects/DashboardComponent/{ID}";

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
	public partial class DashboardComponentFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/DashboardComponentFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/DashboardComponentFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/DashboardComponentFeed/{ID}";

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
	public partial class DashboardFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/DashboardFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/DashboardFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/DashboardFeed/{ID}";

        /// <summary>
        /// DashboardFeed Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Document
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Document
	{
		public const string Describe = "/services/data/v26.0/sobjects/Document/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Document";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Document/{ID}";

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
	public partial class DocumentAttachmentMap
	{
		public const string Describe = "/services/data/v26.0/sobjects/DocumentAttachmentMap/describe";
        public const string SObject = "/services/data/v26.0/sobjects/DocumentAttachmentMap";
        public const string RowTemplate = "/services/data/v26.0/sobjects/DocumentAttachmentMap/{ID}";

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
	public partial class Domain
	{
		public const string Describe = "/services/data/v26.0/sobjects/Domain/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Domain";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Domain/{ID}";

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
	public partial class DomainSite
	{
		public const string Describe = "/services/data/v26.0/sobjects/DomainSite/describe";
        public const string SObject = "/services/data/v26.0/sobjects/DomainSite";
        public const string RowTemplate = "/services/data/v26.0/sobjects/DomainSite/{ID}";

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
	public partial class EmailServicesAddress
	{
		public const string Describe = "/services/data/v26.0/sobjects/EmailServicesAddress/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EmailServicesAddress";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EmailServicesAddress/{ID}";

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
	public partial class EmailServicesFunction
	{
		public const string Describe = "/services/data/v26.0/sobjects/EmailServicesFunction/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EmailServicesFunction";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EmailServicesFunction/{ID}";

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
	public partial class EmailStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/EmailStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EmailStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EmailStatus/{ID}";

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
	public partial class EmailTemplate
	{
		public const string Describe = "/services/data/v26.0/sobjects/EmailTemplate/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EmailTemplate";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EmailTemplate/{ID}";

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
	public partial class EntitySubscription
	{
		public const string Describe = "/services/data/v26.0/sobjects/EntitySubscription/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EntitySubscription";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EntitySubscription/{ID}";

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
	public partial class Event
	{
		public const string Describe = "/services/data/v26.0/sobjects/Event/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Event";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Event/{ID}";

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
	public partial class EventFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/EventFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EventFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EventFeed/{ID}";

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
	public partial class EventRelation
	{
		public const string Describe = "/services/data/v26.0/sobjects/EventRelation/describe";
        public const string SObject = "/services/data/v26.0/sobjects/EventRelation";
        public const string RowTemplate = "/services/data/v26.0/sobjects/EventRelation/{ID}";

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
	public partial class FeedComment
	{
		public const string Describe = "/services/data/v26.0/sobjects/FeedComment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FeedComment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FeedComment/{ID}";

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
	public partial class FeedItem
	{
		public const string Describe = "/services/data/v26.0/sobjects/FeedItem/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FeedItem";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FeedItem/{ID}";

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
	public partial class FeedLike
	{
		public const string Describe = "/services/data/v26.0/sobjects/FeedLike/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FeedLike";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FeedLike/{ID}";

        /// <summary>
        /// FeedLike Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for FeedTrackedChange
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class FeedTrackedChange
	{
		public const string Describe = "/services/data/v26.0/sobjects/FeedTrackedChange/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FeedTrackedChange";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FeedTrackedChange/{ID}";

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
	public partial class FieldPermissions
	{
		public const string Describe = "/services/data/v26.0/sobjects/FieldPermissions/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FieldPermissions";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FieldPermissions/{ID}";

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
	public partial class FiscalYearSettings
	{
		public const string Describe = "/services/data/v26.0/sobjects/FiscalYearSettings/describe";
        public const string SObject = "/services/data/v26.0/sobjects/FiscalYearSettings";
        public const string RowTemplate = "/services/data/v26.0/sobjects/FiscalYearSettings/{ID}";

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
	public partial class Folder
	{
		public const string Describe = "/services/data/v26.0/sobjects/Folder/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Folder";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Folder/{ID}";

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
	public partial class ForecastShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/ForecastShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ForecastShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ForecastShare/{ID}";

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
	public partial class Group
	{
		public const string Describe = "/services/data/v26.0/sobjects/Group/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Group";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Group/{ID}";

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
	public partial class GroupMember
	{
		public const string Describe = "/services/data/v26.0/sobjects/GroupMember/describe";
        public const string SObject = "/services/data/v26.0/sobjects/GroupMember";
        public const string RowTemplate = "/services/data/v26.0/sobjects/GroupMember/{ID}";

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
	public partial class HashtagDefinition
	{
		public const string Describe = "/services/data/v26.0/sobjects/HashtagDefinition/describe";
        public const string SObject = "/services/data/v26.0/sobjects/HashtagDefinition";
        public const string RowTemplate = "/services/data/v26.0/sobjects/HashtagDefinition/{ID}";

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
	public partial class Holiday
	{
		public const string Describe = "/services/data/v26.0/sobjects/Holiday/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Holiday";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Holiday/{ID}";

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
	public partial class Idea
	{
		public const string Describe = "/services/data/v26.0/sobjects/Idea/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Idea";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Idea/{ID}";

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
	public partial class IdeaComment
	{
		public const string Describe = "/services/data/v26.0/sobjects/IdeaComment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/IdeaComment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/IdeaComment/{ID}";

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
	public partial class Lead
	{
		public const string Describe = "/services/data/v26.0/sobjects/Lead/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Lead";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Lead/{ID}";

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
	public partial class LeadFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/LeadFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LeadFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LeadFeed/{ID}";

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
	public partial class LeadHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/LeadHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LeadHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LeadHistory/{ID}";

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
	public partial class LeadShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/LeadShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LeadShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LeadShare/{ID}";

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
	public partial class LeadStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/LeadStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LeadStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LeadStatus/{ID}";

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
	public partial class LoginHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/LoginHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LoginHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LoginHistory/{ID}";

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
	public partial class LoginIp
	{
		public const string Describe = "/services/data/v26.0/sobjects/LoginIp/describe";
        public const string SObject = "/services/data/v26.0/sobjects/LoginIp";
        public const string RowTemplate = "/services/data/v26.0/sobjects/LoginIp/{ID}";

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
	public partial class MailmergeTemplate
	{
		public const string Describe = "/services/data/v26.0/sobjects/MailmergeTemplate/describe";
        public const string SObject = "/services/data/v26.0/sobjects/MailmergeTemplate";
        public const string RowTemplate = "/services/data/v26.0/sobjects/MailmergeTemplate/{ID}";

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
	public partial class Name
	{
		public const string Describe = "/services/data/v26.0/sobjects/Name/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Name";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Name/{ID}";

        /// <summary>
        /// Name Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for NewsFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class NewsFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/NewsFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/NewsFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/NewsFeed/{ID}";

        /// <summary>
        /// NewsFeed Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Note
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Note
	{
		public const string Describe = "/services/data/v26.0/sobjects/Note/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Note";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Note/{ID}";

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
	public partial class NoteAndAttachment
	{
		public const string Describe = "/services/data/v26.0/sobjects/NoteAndAttachment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/NoteAndAttachment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/NoteAndAttachment/{ID}";

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
	public partial class ObjectPermissions
	{
		public const string Describe = "/services/data/v26.0/sobjects/ObjectPermissions/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ObjectPermissions";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ObjectPermissions/{ID}";

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
	public partial class OpenActivity
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpenActivity/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpenActivity";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpenActivity/{ID}";

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
	public partial class Opportunity
	{
		public const string Describe = "/services/data/v26.0/sobjects/Opportunity/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Opportunity";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Opportunity/{ID}";

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
	public partial class OpportunityCompetitor
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityCompetitor/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityCompetitor";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityCompetitor/{ID}";

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
	public partial class OpportunityContactRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityContactRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityContactRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityContactRole/{ID}";

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
	public partial class OpportunityFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityFeed/{ID}";

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
	public partial class OpportunityFieldHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityFieldHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityFieldHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityFieldHistory/{ID}";

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
	public partial class OpportunityHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityHistory/{ID}";

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
	public partial class OpportunityLineItem
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityLineItem/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityLineItem";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityLineItem/{ID}";

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
	public partial class OpportunityPartner
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityPartner/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityPartner";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityPartner/{ID}";

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
	public partial class OpportunityShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityShare/{ID}";

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
	public partial class OpportunityStage
	{
		public const string Describe = "/services/data/v26.0/sobjects/OpportunityStage/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OpportunityStage";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OpportunityStage/{ID}";

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
	public partial class OrgWideEmailAddress
	{
		public const string Describe = "/services/data/v26.0/sobjects/OrgWideEmailAddress/describe";
        public const string SObject = "/services/data/v26.0/sobjects/OrgWideEmailAddress";
        public const string RowTemplate = "/services/data/v26.0/sobjects/OrgWideEmailAddress/{ID}";

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
	public partial class Organization
	{
		public const string Describe = "/services/data/v26.0/sobjects/Organization/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Organization";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Organization/{ID}";

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
	public partial class Partner
	{
		public const string Describe = "/services/data/v26.0/sobjects/Partner/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Partner";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Partner/{ID}";

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
	public partial class PartnerRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/PartnerRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/PartnerRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/PartnerRole/{ID}";

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
	public partial class Period
	{
		public const string Describe = "/services/data/v26.0/sobjects/Period/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Period";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Period/{ID}";

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
	public partial class PermissionSet
	{
		public const string Describe = "/services/data/v26.0/sobjects/PermissionSet/describe";
        public const string SObject = "/services/data/v26.0/sobjects/PermissionSet";
        public const string RowTemplate = "/services/data/v26.0/sobjects/PermissionSet/{ID}";

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
	public partial class PermissionSetAssignment
	{
		public const string Describe = "/services/data/v26.0/sobjects/PermissionSetAssignment/describe";
        public const string SObject = "/services/data/v26.0/sobjects/PermissionSetAssignment";
        public const string RowTemplate = "/services/data/v26.0/sobjects/PermissionSetAssignment/{ID}";

        /// <summary>
        /// PermissionSetAssignment Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for Pricebook2
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class Pricebook2
	{
		public const string Describe = "/services/data/v26.0/sobjects/Pricebook2/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Pricebook2";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Pricebook2/{ID}";

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
	public partial class Pricebook2History
	{
		public const string Describe = "/services/data/v26.0/sobjects/Pricebook2History/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Pricebook2History";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Pricebook2History/{ID}";

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
	public partial class PricebookEntry
	{
		public const string Describe = "/services/data/v26.0/sobjects/PricebookEntry/describe";
        public const string SObject = "/services/data/v26.0/sobjects/PricebookEntry";
        public const string RowTemplate = "/services/data/v26.0/sobjects/PricebookEntry/{ID}";

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
	public partial class ProcessInstance
	{
		public const string Describe = "/services/data/v26.0/sobjects/ProcessInstance/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ProcessInstance";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ProcessInstance/{ID}";

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
	public partial class ProcessInstanceHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/ProcessInstanceHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ProcessInstanceHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ProcessInstanceHistory/{ID}";

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
	public partial class ProcessInstanceStep
	{
		public const string Describe = "/services/data/v26.0/sobjects/ProcessInstanceStep/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ProcessInstanceStep";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ProcessInstanceStep/{ID}";

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
	public partial class ProcessInstanceWorkitem
	{
		public const string Describe = "/services/data/v26.0/sobjects/ProcessInstanceWorkitem/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ProcessInstanceWorkitem";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ProcessInstanceWorkitem/{ID}";

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
	public partial class Product2
	{
		public const string Describe = "/services/data/v26.0/sobjects/Product2/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Product2";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Product2/{ID}";

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
	public partial class Product2Feed
	{
		public const string Describe = "/services/data/v26.0/sobjects/Product2Feed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Product2Feed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Product2Feed/{ID}";

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
	public partial class Profile
	{
		public const string Describe = "/services/data/v26.0/sobjects/Profile/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Profile";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Profile/{ID}";

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
	public partial class PushTopic
	{
		public const string Describe = "/services/data/v26.0/sobjects/PushTopic/describe";
        public const string SObject = "/services/data/v26.0/sobjects/PushTopic";
        public const string RowTemplate = "/services/data/v26.0/sobjects/PushTopic/{ID}";

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
	public partial class QueueSobject
	{
		public const string Describe = "/services/data/v26.0/sobjects/QueueSobject/describe";
        public const string SObject = "/services/data/v26.0/sobjects/QueueSobject";
        public const string RowTemplate = "/services/data/v26.0/sobjects/QueueSobject/{ID}";

        /// <summary>
        /// QueueSobject Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for RecordType
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class RecordType
	{
		public const string Describe = "/services/data/v26.0/sobjects/RecordType/describe";
        public const string SObject = "/services/data/v26.0/sobjects/RecordType";
        public const string RowTemplate = "/services/data/v26.0/sobjects/RecordType/{ID}";

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
	public partial class Report
	{
		public const string Describe = "/services/data/v26.0/sobjects/Report/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Report";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Report/{ID}";

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
	public partial class ReportFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/ReportFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/ReportFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/ReportFeed/{ID}";

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
	public partial class SetupEntityAccess
	{
		public const string Describe = "/services/data/v26.0/sobjects/SetupEntityAccess/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SetupEntityAccess";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SetupEntityAccess/{ID}";

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
	public partial class Site
	{
		public const string Describe = "/services/data/v26.0/sobjects/Site/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Site";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Site/{ID}";

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
	public partial class SiteFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/SiteFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SiteFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SiteFeed/{ID}";

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
	public partial class SiteHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/SiteHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SiteHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SiteHistory/{ID}";

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
	public partial class Solution
	{
		public const string Describe = "/services/data/v26.0/sobjects/Solution/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Solution";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Solution/{ID}";

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
	public partial class SolutionFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/SolutionFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SolutionFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SolutionFeed/{ID}";

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
	public partial class SolutionHistory
	{
		public const string Describe = "/services/data/v26.0/sobjects/SolutionHistory/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SolutionHistory";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SolutionHistory/{ID}";

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
	public partial class SolutionStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/SolutionStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/SolutionStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/SolutionStatus/{ID}";

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
	public partial class StaticResource
	{
		public const string Describe = "/services/data/v26.0/sobjects/StaticResource/describe";
        public const string SObject = "/services/data/v26.0/sobjects/StaticResource";
        public const string RowTemplate = "/services/data/v26.0/sobjects/StaticResource/{ID}";

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
	public partial class Task
	{
		public const string Describe = "/services/data/v26.0/sobjects/Task/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Task";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Task/{ID}";

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
	public partial class TaskFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/TaskFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/TaskFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/TaskFeed/{ID}";

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
	public partial class TaskPriority
	{
		public const string Describe = "/services/data/v26.0/sobjects/TaskPriority/describe";
        public const string SObject = "/services/data/v26.0/sobjects/TaskPriority";
        public const string RowTemplate = "/services/data/v26.0/sobjects/TaskPriority/{ID}";

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
	public partial class TaskStatus
	{
		public const string Describe = "/services/data/v26.0/sobjects/TaskStatus/describe";
        public const string SObject = "/services/data/v26.0/sobjects/TaskStatus";
        public const string RowTemplate = "/services/data/v26.0/sobjects/TaskStatus/{ID}";

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
	public partial class Topic
	{
		public const string Describe = "/services/data/v26.0/sobjects/Topic/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Topic";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Topic/{ID}";

        /// <summary>
        /// Topic Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for User
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class User
	{
		public const string Describe = "/services/data/v26.0/sobjects/User/describe";
        public const string SObject = "/services/data/v26.0/sobjects/User";
        public const string RowTemplate = "/services/data/v26.0/sobjects/User/{ID}";

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
	public partial class UserFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserFeed/{ID}";

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
	public partial class UserLicense
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserLicense/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserLicense";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserLicense/{ID}";

        /// <summary>
        /// UserLicense Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for UserPreference
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class UserPreference
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserPreference/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserPreference";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserPreference/{ID}";

        /// <summary>
        /// UserPreference Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for UserProfileFeed
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class UserProfileFeed
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserProfileFeed/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserProfileFeed";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserProfileFeed/{ID}";

        /// <summary>
        /// UserProfileFeed Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

    /// <summary>
    /// POCO for UserRecordAccess
    /// </summary>
    [DebuggerDisplay("Id={Id}")]
	public partial class UserRecordAccess
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserRecordAccess/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserRecordAccess";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserRecordAccess/{ID}";

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
	public partial class UserRole
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserRole/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserRole";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserRole/{ID}";

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
	public partial class UserShare
	{
		public const string Describe = "/services/data/v26.0/sobjects/UserShare/describe";
        public const string SObject = "/services/data/v26.0/sobjects/UserShare";
        public const string RowTemplate = "/services/data/v26.0/sobjects/UserShare/{ID}";

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
	public partial class Vote
	{
		public const string Describe = "/services/data/v26.0/sobjects/Vote/describe";
        public const string SObject = "/services/data/v26.0/sobjects/Vote";
        public const string RowTemplate = "/services/data/v26.0/sobjects/Vote/{ID}";

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
	public partial class WebLink
	{
		public const string Describe = "/services/data/v26.0/sobjects/WebLink/describe";
        public const string SObject = "/services/data/v26.0/sobjects/WebLink";
        public const string RowTemplate = "/services/data/v26.0/sobjects/WebLink/{ID}";

        /// <summary>
        /// WebLink Id
        /// </summary>
		[StringLength(18)]
		public string Id { get; set; }
	}

}

// ReSharper restore PartialTypeWithSinglePart
// ReSharper restore UnusedMember.Local
 
