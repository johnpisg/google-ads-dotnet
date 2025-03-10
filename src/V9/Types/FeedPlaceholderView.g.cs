// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/feed_placeholder_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/feed_placeholder_view.proto</summary>
  public static partial class FeedPlaceholderViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/feed_placeholder_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedPlaceholderViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvZmVlZF9wbGFj",
            "ZWhvbGRlcl92aWV3LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52OS5y",
            "ZXNvdXJjZXMaNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y5L2VudW1zL3BsYWNl",
            "aG9sZGVyX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3Iu",
            "cHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8iuQIKE0ZlZWRQbGFjZWhvbGRlclZpZXcSSwoN",
            "cmVzb3VyY2VfbmFtZRgBIAEoCUI04EED+kEuCixnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vRmVlZFBsYWNlaG9sZGVyVmlldxJhChBwbGFjZWhvbGRlcl90",
            "eXBlGAIgASgOMkIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuUGxh",
            "Y2Vob2xkZXJUeXBlRW51bS5QbGFjZWhvbGRlclR5cGVCA+BBAzpy6kFvCixn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRmVlZFBsYWNlaG9sZGVyVmlldxI/",
            "Y3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vZmVlZFBsYWNlaG9sZGVyVmlld3Mv",
            "e3BsYWNlaG9sZGVyX3R5cGV9QoUCCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjkucmVzb3VyY2VzQhhGZWVkUGxhY2Vob2xkZXJWaWV3UHJvdG9QAVpK",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3Y5L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WOS5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWOVxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "OTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.FeedPlaceholderView), global::Google.Ads.GoogleAds.V9.Resources.FeedPlaceholderView.Parser, new[]{ "ResourceName", "PlaceholderType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A feed placeholder view.
  /// </summary>
  public sealed partial class FeedPlaceholderView : pb::IMessage<FeedPlaceholderView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedPlaceholderView> _parser = new pb::MessageParser<FeedPlaceholderView>(() => new FeedPlaceholderView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedPlaceholderView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.FeedPlaceholderViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedPlaceholderView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedPlaceholderView(FeedPlaceholderView other) : this() {
      resourceName_ = other.resourceName_;
      placeholderType_ = other.placeholderType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedPlaceholderView Clone() {
      return new FeedPlaceholderView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the feed placeholder view.
    /// Feed placeholder view resource names have the form:
    ///
    /// `customers/{customer_id}/feedPlaceholderViews/{placeholder_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "placeholder_type" field.</summary>
    public const int PlaceholderTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType placeholderType_ = global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified;
    /// <summary>
    /// Output only. The placeholder type of the feed placeholder view.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType PlaceholderType {
      get { return placeholderType_; }
      set {
        placeholderType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedPlaceholderView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedPlaceholderView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (PlaceholderType != other.PlaceholderType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (PlaceholderType != global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified) hash ^= PlaceholderType.GetHashCode();
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
      if (PlaceholderType != global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PlaceholderType);
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
      if (PlaceholderType != global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PlaceholderType);
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
      if (PlaceholderType != global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlaceholderType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedPlaceholderView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.PlaceholderType != global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType.Unspecified) {
        PlaceholderType = other.PlaceholderType;
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
            PlaceholderType = (global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType) input.ReadEnum();
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
            PlaceholderType = (global::Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types.PlaceholderType) input.ReadEnum();
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
