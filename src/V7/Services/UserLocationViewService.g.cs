// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/services/user_location_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/services/user_location_view_service.proto</summary>
  public static partial class UserLocationViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/services/user_location_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserLocationViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9zZXJ2aWNlcy91c2VyX2xvY2F0",
            "aW9uX3ZpZXdfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djcuc2VydmljZXMaOmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L3Jlc291cmNl",
            "cy91c2VyX2xvY2F0aW9uX3ZpZXcucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvImYKGkdldFVzZXJMb2NhdGlvblZpZXdSZXF1ZXN0EkgKDXJlc291",
            "cmNlX25hbWUYASABKAlCMeBBAvpBKwopZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL1VzZXJMb2NhdGlvblZpZXcyuAIKF1VzZXJMb2NhdGlvblZpZXdTZXJ2",
            "aWNlEtUBChNHZXRVc2VyTG9jYXRpb25WaWV3EjwuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjcuc2VydmljZXMuR2V0VXNlckxvY2F0aW9uVmlld1JlcXVlc3Qa",
            "My5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5yZXNvdXJjZXMuVXNlckxvY2F0",
            "aW9uVmlldyJLgtPkkwI1EjMvdjcve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJz",
            "LyovdXNlckxvY2F0aW9uVmlld3MvKn3aQQ1yZXNvdXJjZV9uYW1lGkXKQRhn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdodHRwczovL3d3dy5nb29nbGVh",
            "cGlzLmNvbS9hdXRoL2Fkd29yZHNCgwIKJGNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Ny5zZXJ2aWNlc0IcVXNlckxvY2F0aW9uVmlld1NlcnZpY2VQcm90",
            "b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjcvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WNy5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFY3XFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "Vjc6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Resources.UserLocationViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Services.GetUserLocationViewRequest), global::Google.Ads.GoogleAds.V7.Services.GetUserLocationViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [UserLocationViewService.GetUserLocationView][google.ads.googleads.v7.services.UserLocationViewService.GetUserLocationView].
  /// </summary>
  public sealed partial class GetUserLocationViewRequest : pb::IMessage<GetUserLocationViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetUserLocationViewRequest> _parser = new pb::MessageParser<GetUserLocationViewRequest>(() => new GetUserLocationViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetUserLocationViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Services.UserLocationViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUserLocationViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUserLocationViewRequest(GetUserLocationViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUserLocationViewRequest Clone() {
      return new GetUserLocationViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the user location view to fetch.
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
      return Equals(other as GetUserLocationViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetUserLocationViewRequest other) {
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
    public void MergeFrom(GetUserLocationViewRequest other) {
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
