//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.0.4.0 (NJsonSchema v10.0.21.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace OpenWater.ApiClient.Media
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class DetailsResponse 
    {
        internal DetailsResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public DetailsResponse(string url)
        {
              Url = @url;
        }
    
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateRequest 
    {
        internal CreateRequest() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateRequest(string fileName, string fileUrl)
        {
              FileUrl = @fileUrl;
              FileName = @fileName;
        }
    
        [Newtonsoft.Json.JsonProperty("fileUrl", Required = Newtonsoft.Json.Required.Always)]
        public string FileUrl { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.Always)]
        public string FileName { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CreateResponse 
    {
        internal CreateResponse() { }
    
        [Newtonsoft.Json.JsonConstructor]
        public CreateResponse(int mediaId, string url)
        {
              MediaId = @mediaId;
              Url = @url;
        }
    
        [Newtonsoft.Json.JsonProperty("mediaId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MediaId { get; internal set; }
    
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; internal set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum RoundSubmissionStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotStarted")]
        NotStarted = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Incomplete")]
        Incomplete = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PendingApproval")]
        PendingApproval = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Disapproved")]
        Disapproved = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InCart")]
        InCart = 5,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JudgeScorecardInfoStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotScored")]
        NotScored = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum RoundSubmissionStatusRequestStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotStarted")]
        NotStarted = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Incomplete")]
        Incomplete = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PendingApproval")]
        PendingApproval = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Disapproved")]
        Disapproved = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InCart")]
        InCart = 5,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum DetailsResponseJobState
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Undefined")]
        Undefined = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Uncommited")]
        Uncommited = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Awaiting")]
        Awaiting = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Scheduled")]
        Scheduled = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Enqueued")]
        Enqueued = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Processing")]
        Processing = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Succeeded")]
        Succeeded = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Deleted")]
        Deleted = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Failed")]
        Failed = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum BillingLineItemModelTargetType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Coupon")]
        Coupon = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ApplicationJudgement")]
        ApplicationJudgement = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Submission")]
        Submission = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PaymentModelMethod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Check")]
        Check = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OnSite")]
        OnSite = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PayPalExpress")]
        PayPalExpress = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TouchNet")]
        TouchNet = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChasePaymentech")]
        ChasePaymentech = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StripeJs")]
        StripeJs = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"QuickPay")]
        QuickPay = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum BillingLineItemListItemModelTargetType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Coupon")]
        Coupon = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ApplicationJudgement")]
        ApplicationJudgement = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Submission")]
        Submission = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PaymentListItemModelMethod
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Check")]
        Check = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OnSite")]
        OnSite = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CreditCard")]
        CreditCard = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PayPalExpress")]
        PayPalExpress = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TouchNet")]
        TouchNet = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChasePaymentech")]
        ChasePaymentech = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StripeJs")]
        StripeJs = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"QuickPay")]
        QuickPay = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JudgeScorecardListItemModelStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"NotScored")]
        NotScored = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Complete")]
        Complete = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ApplicationNameFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum DropDownListFieldModelPreFillType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"None")]
        None = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UsStates")]
        UsStates = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CanadaProvinces")]
        CanadaProvinces = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Countries")]
        Countries = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UsStatesAndCanadaProvinces")]
        UsStatesAndCanadaProvinces = 4,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EmailFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EmailFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MultilineTextFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MultilineTextFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TextFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TextFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum UrlFieldModelSize
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Large")]
        Large = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Medium")]
        Medium = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Small")]
        Small = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum UrlFieldModelTextLengthCountMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Characters")]
        Characters = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Words")]
        Words = 1,
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108