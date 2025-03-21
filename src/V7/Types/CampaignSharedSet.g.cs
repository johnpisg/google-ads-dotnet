// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/campaign_shared_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/campaign_shared_set.proto</summary>
  public static partial class CampaignSharedSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/campaign_shared_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSharedSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "c2hhcmVkX3NldC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVz",
            "b3VyY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9jYW1wYWln",
            "bl9zaGFyZWRfc2V0X3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLlAwoRQ2FtcGFpZ25TaGFyZWRT",
            "ZXQSSQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIy4EEF+kEsCipnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25TaGFyZWRTZXQSQAoIY2FtcGFpZ24Y",
            "BSABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBh",
            "aWduSACIAQESQwoKc2hhcmVkX3NldBgGIAEoCUIq4EEF+kEkCiJnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vU2hhcmVkU2V0SAGIAQESZwoGc3RhdHVzGAIg",
            "ASgOMlIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMuQ2FtcGFpZ25T",
            "aGFyZWRTZXRTdGF0dXNFbnVtLkNhbXBhaWduU2hhcmVkU2V0U3RhdHVzQgPg",
            "QQM6eepBdgoqZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduU2hh",
            "cmVkU2V0EkhjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9jYW1wYWlnblNoYXJl",
            "ZFNldHMve2NhbXBhaWduX2lkfX57c2hhcmVkX3NldF9pZH1CCwoJX2NhbXBh",
            "aWduQg0KC19zaGFyZWRfc2V0QoMCCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjcucmVzb3VyY2VzQhZDYW1wYWlnblNoYXJlZFNldFByb3RvUAFaSmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92Ny9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjcuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjdcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6",
            "OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.CampaignSharedSet), global::Google.Ads.GoogleAds.V7.Resources.CampaignSharedSet.Parser, new[]{ "ResourceName", "Campaign", "SharedSet", "Status" }, new[]{ "Campaign", "SharedSet" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CampaignSharedSets are used for managing the shared sets associated with a
  /// campaign.
  /// </summary>
  public sealed partial class CampaignSharedSet : pb::IMessage<CampaignSharedSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignSharedSet> _parser = new pb::MessageParser<CampaignSharedSet>(() => new CampaignSharedSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignSharedSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.CampaignSharedSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet(CampaignSharedSet other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      sharedSet_ = other.sharedSet_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSharedSet Clone() {
      return new CampaignSharedSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign shared set.
    /// Campaign shared set resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 5;
    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the campaign shared set belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? ""; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "shared_set" field.</summary>
    public const int SharedSetFieldNumber = 6;
    private string sharedSet_;
    /// <summary>
    /// Immutable. The shared set associated with the campaign. This may be a negative keyword
    /// shared set of another customer. This customer should be a manager of the
    /// other customer, otherwise the campaign shared set will exist but have no
    /// serving effect. Only negative keyword shared sets can be associated with
    /// Shopping campaigns. Only negative placement shared sets can be associated
    /// with Display mobile app campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SharedSet {
      get { return sharedSet_ ?? ""; }
      set {
        sharedSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "shared_set" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSharedSet {
      get { return sharedSet_ != null; }
    }
    /// <summary>Clears the value of the "shared_set" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSharedSet() {
      sharedSet_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus status_ = global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of this campaign shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignSharedSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignSharedSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (SharedSet != other.SharedSet) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasSharedSet) hash ^= SharedSet.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(42);
        output.WriteString(Campaign);
      }
      if (HasSharedSet) {
        output.WriteRawTag(50);
        output.WriteString(SharedSet);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(42);
        output.WriteString(Campaign);
      }
      if (HasSharedSet) {
        output.WriteRawTag(50);
        output.WriteString(SharedSet);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasSharedSet) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SharedSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignSharedSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasSharedSet) {
        SharedSet = other.SharedSet;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Unspecified) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus) input.ReadEnum();
            break;
          }
          case 42: {
            Campaign = input.ReadString();
            break;
          }
          case 50: {
            SharedSet = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus) input.ReadEnum();
            break;
          }
          case 42: {
            Campaign = input.ReadString();
            break;
          }
          case 50: {
            SharedSet = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
