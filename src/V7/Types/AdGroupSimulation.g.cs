// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/ad_group_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/ad_group_simulation.proto</summary>
  public static partial class AdGroupSimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/ad_group_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupSimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "c2ltdWxhdGlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVz",
            "b3VyY2VzGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9jb21tb24vc2ltdWxh",
            "dGlvbi5wcm90bxpCZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvc2lt",
            "dWxhdGlvbl9tb2RpZmljYXRpb25fbWV0aG9kLnByb3RvGjNnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92Ny9lbnVtcy9zaW11bGF0aW9uX3R5cGUucHJvdG8aH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVz",
            "b3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i7gcK",
            "EUFkR3JvdXBTaW11bGF0aW9uEkkKDXJlc291cmNlX25hbWUYASABKAlCMuBB",
            "A/pBLAoqZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBTaW11bGF0",
            "aW9uEh0KC2FkX2dyb3VwX2lkGAwgASgDQgPgQQNIAYgBARJTCgR0eXBlGAMg",
            "ASgOMkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMuU2ltdWxhdGlv",
            "blR5cGVFbnVtLlNpbXVsYXRpb25UeXBlQgPgQQMSfgoTbW9kaWZpY2F0aW9u",
            "X21ldGhvZBgEIAEoDjJcLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1z",
            "LlNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2RFbnVtLlNpbXVsYXRpb25N",
            "b2RpZmljYXRpb25NZXRob2RCA+BBAxIcCgpzdGFydF9kYXRlGA0gASgJQgPg",
            "QQNIAogBARIaCghlbmRfZGF0ZRgOIAEoCUID4EEDSAOIAQESXAoSY3BjX2Jp",
            "ZF9wb2ludF9saXN0GAggASgLMjkuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcu",
            "Y29tbW9uLkNwY0JpZFNpbXVsYXRpb25Qb2ludExpc3RCA+BBA0gAElwKEmNw",
            "dl9iaWRfcG9pbnRfbGlzdBgKIAEoCzI5Lmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY3LmNvbW1vbi5DcHZCaWRTaW11bGF0aW9uUG9pbnRMaXN0QgPgQQNIABJi",
            "ChV0YXJnZXRfY3BhX3BvaW50X2xpc3QYCSABKAsyPC5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52Ny5jb21tb24uVGFyZ2V0Q3BhU2ltdWxhdGlvblBvaW50TGlz",
            "dEID4EEDSAASZAoWdGFyZ2V0X3JvYXNfcG9pbnRfbGlzdBgLIAEoCzI9Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmNvbW1vbi5UYXJnZXRSb2FzU2ltdWxh",
            "dGlvblBvaW50TGlzdEID4EEDSAA6nwHqQZsBCipnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQWRHcm91cFNpbXVsYXRpb24SbWN1c3RvbWVycy97Y3VzdG9t",
            "ZXJfaWR9L2FkR3JvdXBTaW11bGF0aW9ucy97YWRfZ3JvdXBfaWR9fnt0eXBl",
            "fX57bW9kaWZpY2F0aW9uX21ldGhvZH1+e3N0YXJ0X2RhdGV9fntlbmRfZGF0",
            "ZX1CDAoKcG9pbnRfbGlzdEIOCgxfYWRfZ3JvdXBfaWRCDQoLX3N0YXJ0X2Rh",
            "dGVCCwoJX2VuZF9kYXRlQoMCCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djcucmVzb3VyY2VzQhZBZEdyb3VwU2ltdWxhdGlvblByb3RvUAFaSmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92Ny9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjcuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjdcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.AdGroupSimulation), global::Google.Ads.GoogleAds.V7.Resources.AdGroupSimulation.Parser, new[]{ "ResourceName", "AdGroupId", "Type", "ModificationMethod", "StartDate", "EndDate", "CpcBidPointList", "CpvBidPointList", "TargetCpaPointList", "TargetRoasPointList" }, new[]{ "PointList", "AdGroupId", "StartDate", "EndDate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad group simulation. Supported combinations of advertising
  /// channel type, simulation type and simulation modification method is
  /// detailed below respectively.
  ///
  /// 1. SEARCH - CPC_BID - DEFAULT
  /// 2. SEARCH - CPC_BID - UNIFORM
  /// 3. SEARCH - TARGET_CPA - UNIFORM
  /// 4. SEARCH - TARGET_ROAS - UNIFORM
  /// 5. DISPLAY - CPC_BID - DEFAULT
  /// 6. DISPLAY - CPC_BID - UNIFORM
  /// 7. DISPLAY - TARGET_CPA - UNIFORM
  /// 8. VIDEO - CPV_BID - DEFAULT
  /// 9. VIDEO - CPV_BID - UNIFORM
  /// </summary>
  public sealed partial class AdGroupSimulation : pb::IMessage<AdGroupSimulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupSimulation> _parser = new pb::MessageParser<AdGroupSimulation>(() => new AdGroupSimulation());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupSimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.AdGroupSimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupSimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupSimulation(AdGroupSimulation other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      adGroupId_ = other.adGroupId_;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          CpcBidPointList = other.CpcBidPointList.Clone();
          break;
        case PointListOneofCase.CpvBidPointList:
          CpvBidPointList = other.CpvBidPointList.Clone();
          break;
        case PointListOneofCase.TargetCpaPointList:
          TargetCpaPointList = other.TargetCpaPointList.Clone();
          break;
        case PointListOneofCase.TargetRoasPointList:
          TargetRoasPointList = other.TargetRoasPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupSimulation Clone() {
      return new AdGroupSimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the ad group simulation.
    /// Ad group simulation resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupSimulations/{ad_group_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_id" field.</summary>
    public const int AdGroupIdFieldNumber = 12;
    private long adGroupId_;
    /// <summary>
    /// Output only. Ad group id of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AdGroupId {
      get { if ((_hasBits0 & 1) != 0) { return adGroupId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        adGroupId_ = value;
      }
    }
    /// <summary>Gets whether the "ad_group_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroupId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "ad_group_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroupId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified;
    /// <summary>
    /// Output only. How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 13;
    private string startDate_;
    /// <summary>
    /// Output only. First day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDate {
      get { return startDate_ ?? ""; }
      set {
        startDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "start_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStartDate {
      get { return startDate_ != null; }
    }
    /// <summary>Clears the value of the "start_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStartDate() {
      startDate_ = null;
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 14;
    private string endDate_;
    /// <summary>
    /// Output only. Last day on which the simulation is based, in YYYY-MM-DD format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_ ?? ""; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "end_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEndDate {
      get { return endDate_ != null; }
    }
    /// <summary>Clears the value of the "end_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEndDate() {
      endDate_ = null;
    }

    /// <summary>Field number for the "cpc_bid_point_list" field.</summary>
    public const int CpcBidPointListFieldNumber = 8;
    /// <summary>
    /// Output only. Simulation points if the simulation type is CPC_BID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList CpcBidPointList {
      get { return pointListCase_ == PointListOneofCase.CpcBidPointList ? (global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.CpcBidPointList;
      }
    }

    /// <summary>Field number for the "cpv_bid_point_list" field.</summary>
    public const int CpvBidPointListFieldNumber = 10;
    /// <summary>
    /// Output only. Simulation points if the simulation type is CPV_BID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList CpvBidPointList {
      get { return pointListCase_ == PointListOneofCase.CpvBidPointList ? (global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.CpvBidPointList;
      }
    }

    /// <summary>Field number for the "target_cpa_point_list" field.</summary>
    public const int TargetCpaPointListFieldNumber = 9;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_CPA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetCpaPointList;
      }
    }

    /// <summary>Field number for the "target_roas_point_list" field.</summary>
    public const int TargetRoasPointListFieldNumber = 11;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_ROAS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList TargetRoasPointList {
      get { return pointListCase_ == PointListOneofCase.TargetRoasPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetRoasPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      CpcBidPointList = 8,
      CpvBidPointList = 10,
      TargetCpaPointList = 9,
      TargetRoasPointList = 11,
    }
    private PointListOneofCase pointListCase_ = PointListOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PointListOneofCase PointListCase {
      get { return pointListCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPointList() {
      pointListCase_ = PointListOneofCase.None;
      pointList_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupSimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupSimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupId != other.AdGroupId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(CpcBidPointList, other.CpcBidPointList)) return false;
      if (!object.Equals(CpvBidPointList, other.CpvBidPointList)) return false;
      if (!object.Equals(TargetCpaPointList, other.TargetCpaPointList)) return false;
      if (!object.Equals(TargetRoasPointList, other.TargetRoasPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasAdGroupId) hash ^= AdGroupId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
      if (HasStartDate) hash ^= StartDate.GetHashCode();
      if (HasEndDate) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) hash ^= CpcBidPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.CpvBidPointList) hash ^= CpvBidPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) hash ^= TargetCpaPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) hash ^= TargetRoasPointList.GetHashCode();
      hash ^= (int) pointListCase_;
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
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.CpvBidPointList) {
        output.WriteRawTag(82);
        output.WriteMessage(CpvBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(TargetRoasPointList);
      }
      if (HasAdGroupId) {
        output.WriteRawTag(96);
        output.WriteInt64(AdGroupId);
      }
      if (HasStartDate) {
        output.WriteRawTag(106);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(114);
        output.WriteString(EndDate);
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
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.CpvBidPointList) {
        output.WriteRawTag(82);
        output.WriteMessage(CpvBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(TargetRoasPointList);
      }
      if (HasAdGroupId) {
        output.WriteRawTag(96);
        output.WriteInt64(AdGroupId);
      }
      if (HasStartDate) {
        output.WriteRawTag(106);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(114);
        output.WriteString(EndDate);
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
      if (HasAdGroupId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AdGroupId);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (HasStartDate) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (HasEndDate) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.CpvBidPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CpvBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetRoasPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupSimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasAdGroupId) {
        AdGroupId = other.AdGroupId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        Type = other.Type;
      }
      if (other.ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.HasStartDate) {
        StartDate = other.StartDate;
      }
      if (other.HasEndDate) {
        EndDate = other.EndDate;
      }
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          if (CpcBidPointList == null) {
            CpcBidPointList = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
          }
          CpcBidPointList.MergeFrom(other.CpcBidPointList);
          break;
        case PointListOneofCase.CpvBidPointList:
          if (CpvBidPointList == null) {
            CpvBidPointList = new global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList();
          }
          CpvBidPointList.MergeFrom(other.CpvBidPointList);
          break;
        case PointListOneofCase.TargetCpaPointList:
          if (TargetCpaPointList == null) {
            TargetCpaPointList = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
          }
          TargetCpaPointList.MergeFrom(other.TargetCpaPointList);
          break;
        case PointListOneofCase.TargetRoasPointList:
          if (TargetRoasPointList == null) {
            TargetRoasPointList = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
          }
          TargetRoasPointList.MergeFrom(other.TargetRoasPointList);
          break;
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpvBidPointList) {
              subBuilder.MergeFrom(CpvBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpvBidPointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 96: {
            AdGroupId = input.ReadInt64();
            break;
          }
          case 106: {
            StartDate = input.ReadString();
            break;
          }
          case 114: {
            EndDate = input.ReadString();
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpvBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpvBidPointList) {
              subBuilder.MergeFrom(CpvBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpvBidPointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 96: {
            AdGroupId = input.ReadInt64();
            break;
          }
          case 106: {
            StartDate = input.ReadString();
            break;
          }
          case 114: {
            EndDate = input.ReadString();
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
