// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/services/product_bidding_category_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/services/product_bidding_category_constant_service.proto</summary>
  public static partial class ProductBiddingCategoryConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/services/product_bidding_category_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductBiddingCategoryConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9zZXJ2aWNlcy9wcm9kdWN0X2Jp",
            "ZGRpbmdfY2F0ZWdvcnlfY29uc3RhbnRfc2VydmljZS5wcm90bxIgZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjguc2VydmljZXMaSWdvb2dsZS9hZHMvZ29vZ2xl",
            "YWRzL3Y4L3Jlc291cmNlcy9wcm9kdWN0X2JpZGRpbmdfY2F0ZWdvcnlfY29u",
            "c3RhbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dv",
            "b2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIoIBCihHZXRQ",
            "cm9kdWN0QmlkZGluZ0NhdGVnb3J5Q29uc3RhbnRSZXF1ZXN0ElYKDXJlc291",
            "cmNlX25hbWUYASABKAlCP+BBAvpBOQo3Z29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL1Byb2R1Y3RCaWRkaW5nQ2F0ZWdvcnlDb25zdGFudDLyAgolUHJvZHVj",
            "dEJpZGRpbmdDYXRlZ29yeUNvbnN0YW50U2VydmljZRKBAgohR2V0UHJvZHVj",
            "dEJpZGRpbmdDYXRlZ29yeUNvbnN0YW50EkouZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjguc2VydmljZXMuR2V0UHJvZHVjdEJpZGRpbmdDYXRlZ29yeUNvbnN0",
            "YW50UmVxdWVzdBpBLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LnJlc291cmNl",
            "cy5Qcm9kdWN0QmlkZGluZ0NhdGVnb3J5Q29uc3RhbnQiTYLT5JMCNxI1L3Y4",
            "L3tyZXNvdXJjZV9uYW1lPXByb2R1Y3RCaWRkaW5nQ2F0ZWdvcnlDb25zdGFu",
            "dHMvKn3aQQ1yZXNvdXJjZV9uYW1lGkXKQRhnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb23SQSdodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Fkd29y",
            "ZHNCkQIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5zZXJ2aWNlc0Iq",
            "UHJvZHVjdEJpZGRpbmdDYXRlZ29yeUNvbnN0YW50U2VydmljZVByb3RvUAFa",
            "SGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92OC9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlY4LlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjhcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWODo6",
            "U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V8.Resources.ProductBiddingCategoryConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Services.GetProductBiddingCategoryConstantRequest), global::Google.Ads.GoogleAds.V8.Services.GetProductBiddingCategoryConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ProductBiddingCategoryConstantService.GetProductBiddingCategoryConstant][google.ads.googleads.v8.services.ProductBiddingCategoryConstantService.GetProductBiddingCategoryConstant].
  /// </summary>
  public sealed partial class GetProductBiddingCategoryConstantRequest : pb::IMessage<GetProductBiddingCategoryConstantRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetProductBiddingCategoryConstantRequest> _parser = new pb::MessageParser<GetProductBiddingCategoryConstantRequest>(() => new GetProductBiddingCategoryConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetProductBiddingCategoryConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Services.ProductBiddingCategoryConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProductBiddingCategoryConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProductBiddingCategoryConstantRequest(GetProductBiddingCategoryConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetProductBiddingCategoryConstantRequest Clone() {
      return new GetProductBiddingCategoryConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the Product Bidding Category to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetProductBiddingCategoryConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetProductBiddingCategoryConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetProductBiddingCategoryConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
