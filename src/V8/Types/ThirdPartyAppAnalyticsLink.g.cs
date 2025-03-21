// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/third_party_app_analytics_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/third_party_app_analytics_link.proto</summary>
  public static partial class ThirdPartyAppAnalyticsLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/third_party_app_analytics_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ThirdPartyAppAnalyticsLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvdGhpcmRfcGFy",
            "dHlfYXBwX2FuYWx5dGljc19saW5rLnByb3RvEiFnb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52OC5yZXNvdXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8irgIKGlRoaXJkUGFydHlBcHBBbmFseXRpY3NM",
            "aW5rElIKDXJlc291cmNlX25hbWUYASABKAlCO+BBBfpBNQozZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL1RoaXJkUGFydHlBcHBBbmFseXRpY3NMaW5rEiMK",
            "EXNoYXJlYWJsZV9saW5rX2lkGAMgASgJQgPgQQNIAIgBATqAAepBfQozZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL1RoaXJkUGFydHlBcHBBbmFseXRpY3NM",
            "aW5rEkZjdXN0b21lcnMve2N1c3RvbWVyX2lkfS90aGlyZFBhcnR5QXBwQW5h",
            "bHl0aWNzTGlua3Mve2N1c3RvbWVyX2xpbmtfaWR9QhQKEl9zaGFyZWFibGVf",
            "bGlua19pZEKMAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LnJlc291",
            "cmNlc0IfVGhpcmRQYXJ0eUFwcEFuYWx5dGljc0xpbmtQcm90b1ABWkpnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjgvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlY4LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFY4XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY4OjpS",
            "ZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.ThirdPartyAppAnalyticsLink), global::Google.Ads.GoogleAds.V8.Resources.ThirdPartyAppAnalyticsLink.Parser, new[]{ "ResourceName", "ShareableLinkId" }, new[]{ "ShareableLinkId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A data sharing connection, allowing the import of third party app analytics
  /// into a Google Ads Customer.
  /// </summary>
  public sealed partial class ThirdPartyAppAnalyticsLink : pb::IMessage<ThirdPartyAppAnalyticsLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ThirdPartyAppAnalyticsLink> _parser = new pb::MessageParser<ThirdPartyAppAnalyticsLink>(() => new ThirdPartyAppAnalyticsLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ThirdPartyAppAnalyticsLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.ThirdPartyAppAnalyticsLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLink(ThirdPartyAppAnalyticsLink other) : this() {
      resourceName_ = other.resourceName_;
      shareableLinkId_ = other.shareableLinkId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ThirdPartyAppAnalyticsLink Clone() {
      return new ThirdPartyAppAnalyticsLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the third party app analytics link.
    /// Third party app analytics link resource names have the form:
    ///
    /// `customers/{customer_id}/thirdPartyAppAnalyticsLinks/{account_link_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shareable_link_id" field.</summary>
    public const int ShareableLinkIdFieldNumber = 3;
    private string shareableLinkId_;
    /// <summary>
    /// Output only. The shareable link ID that should be provided to the third party when
    /// setting up app analytics. This is able to be regenerated using regenerate
    /// method in the ThirdPartyAppAnalyticsLinkService.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ShareableLinkId {
      get { return shareableLinkId_ ?? ""; }
      set {
        shareableLinkId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "shareable_link_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasShareableLinkId {
      get { return shareableLinkId_ != null; }
    }
    /// <summary>Clears the value of the "shareable_link_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearShareableLinkId() {
      shareableLinkId_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ThirdPartyAppAnalyticsLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ThirdPartyAppAnalyticsLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ShareableLinkId != other.ShareableLinkId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasShareableLinkId) hash ^= ShareableLinkId.GetHashCode();
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
      if (HasShareableLinkId) {
        output.WriteRawTag(26);
        output.WriteString(ShareableLinkId);
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
      if (HasShareableLinkId) {
        output.WriteRawTag(26);
        output.WriteString(ShareableLinkId);
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
      if (HasShareableLinkId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShareableLinkId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ThirdPartyAppAnalyticsLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasShareableLinkId) {
        ShareableLinkId = other.ShareableLinkId;
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
          case 26: {
            ShareableLinkId = input.ReadString();
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
          case 26: {
            ShareableLinkId = input.ReadString();
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
