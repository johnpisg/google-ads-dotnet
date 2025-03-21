// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/resources/customer_extension_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/resources/customer_extension_setting.proto</summary>
  public static partial class CustomerExtensionSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/resources/customer_extension_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerExtensionSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "ZXh0ZW5zaW9uX3NldHRpbmcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY4LnJlc291cmNlcxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjgvZW51bXMv",
            "ZXh0ZW5zaW9uX3NldHRpbmdfZGV2aWNlLnByb3RvGjJnb29nbGUvYWRzL2dv",
            "b2dsZWFkcy92OC9lbnVtcy9leHRlbnNpb25fdHlwZS5wcm90bxofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byL2AwoYQ3Vz",
            "dG9tZXJFeHRlbnNpb25TZXR0aW5nElAKDXJlc291cmNlX25hbWUYASABKAlC",
            "OeBBBfpBMwoxZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyRXh0",
            "ZW5zaW9uU2V0dGluZxJbCg5leHRlbnNpb25fdHlwZRgCIAEoDjI+Lmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY4LmVudW1zLkV4dGVuc2lvblR5cGVFbnVtLkV4",
            "dGVuc2lvblR5cGVCA+BBBRJNChRleHRlbnNpb25fZmVlZF9pdGVtcxgFIAMo",
            "CUIv+kEsCipnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRXh0ZW5zaW9uRmVl",
            "ZEl0ZW0SYAoGZGV2aWNlGAQgASgOMlAuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djguZW51bXMuRXh0ZW5zaW9uU2V0dGluZ0RldmljZUVudW0uRXh0ZW5zaW9u",
            "U2V0dGluZ0RldmljZTp66kF3CjFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "Q3VzdG9tZXJFeHRlbnNpb25TZXR0aW5nEkJjdXN0b21lcnMve2N1c3RvbWVy",
            "X2lkfS9jdXN0b21lckV4dGVuc2lvblNldHRpbmdzL3tleHRlbnNpb25fdHlw",
            "ZX1CigIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5yZXNvdXJjZXNC",
            "HUN1c3RvbWVyRXh0ZW5zaW9uU2V0dGluZ1Byb3RvUAFaSmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OC9y",
            "ZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjguUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjhcUmVz",
            "b3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjg6OlJlc291cmNl",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Resources.CustomerExtensionSetting), global::Google.Ads.GoogleAds.V8.Resources.CustomerExtensionSetting.Parser, new[]{ "ResourceName", "ExtensionType", "ExtensionFeedItems", "Device" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customer extension setting.
  /// </summary>
  public sealed partial class CustomerExtensionSetting : pb::IMessage<CustomerExtensionSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerExtensionSetting> _parser = new pb::MessageParser<CustomerExtensionSetting>(() => new CustomerExtensionSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerExtensionSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Resources.CustomerExtensionSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting(CustomerExtensionSetting other) : this() {
      resourceName_ = other.resourceName_;
      extensionType_ = other.extensionType_;
      extensionFeedItems_ = other.extensionFeedItems_.Clone();
      device_ = other.device_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerExtensionSetting Clone() {
      return new CustomerExtensionSetting(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer extension setting.
    /// CustomerExtensionSetting resource names have the form:
    ///
    /// `customers/{customer_id}/customerExtensionSettings/{extension_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extension_type" field.</summary>
    public const int ExtensionTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType extensionType_ = global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified;
    /// <summary>
    /// Immutable. The extension type of the customer extension setting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType ExtensionType {
      get { return extensionType_; }
      set {
        extensionType_ = value;
      }
    }

    /// <summary>Field number for the "extension_feed_items" field.</summary>
    public const int ExtensionFeedItemsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_extensionFeedItems_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> extensionFeedItems_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The resource names of the extension feed items to serve under the customer.
    /// ExtensionFeedItem resource names have the form:
    ///
    /// `customers/{customer_id}/extensionFeedItems/{feed_item_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ExtensionFeedItems {
      get { return extensionFeedItems_; }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice device_ = global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified;
    /// <summary>
    /// The device for which the extensions will serve. Optional.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice Device {
      get { return device_; }
      set {
        device_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerExtensionSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerExtensionSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ExtensionType != other.ExtensionType) return false;
      if(!extensionFeedItems_.Equals(other.extensionFeedItems_)) return false;
      if (Device != other.Device) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (ExtensionType != global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) hash ^= ExtensionType.GetHashCode();
      hash ^= extensionFeedItems_.GetHashCode();
      if (Device != global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) hash ^= Device.GetHashCode();
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Device);
      }
      extensionFeedItems_.WriteTo(output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Device);
      }
      extensionFeedItems_.WriteTo(ref output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtensionType);
      }
      size += extensionFeedItems_.CalculateSize(_repeated_extensionFeedItems_codec);
      if (Device != global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Device);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerExtensionSetting other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.ExtensionType != global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        ExtensionType = other.ExtensionType;
      }
      extensionFeedItems_.Add(other.extensionFeedItems_);
      if (other.Device != global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        Device = other.Device;
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
            ExtensionType = (global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 32: {
            Device = (global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 42: {
            extensionFeedItems_.AddEntriesFrom(input, _repeated_extensionFeedItems_codec);
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
            ExtensionType = (global::Google.Ads.GoogleAds.V8.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 32: {
            Device = (global::Google.Ads.GoogleAds.V8.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 42: {
            extensionFeedItems_.AddEntriesFrom(ref input, _repeated_extensionFeedItems_codec);
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
