// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/field_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/field_error.proto</summary>
  public static partial class FieldErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/field_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvZmllbGRfZXJyb3Iu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVycm9ycxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byLYAQoORmllbGRFcnJvckVudW0ixQEK",
            "CkZpZWxkRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoI",
            "UkVRVUlSRUQQAhITCg9JTU1VVEFCTEVfRklFTEQQAxIRCg1JTlZBTElEX1ZB",
            "TFVFEAQSFwoTVkFMVUVfTVVTVF9CRV9VTlNFVBAFEhoKFlJFUVVJUkVEX05P",
            "TkVNUFRZX0xJU1QQBhIbChdGSUVMRF9DQU5OT1RfQkVfQ0xFQVJFRBAHEhEK",
            "DUJMT0NLRURfVkFMVUUQCULqAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY3LmVycm9yc0IPRmllbGRFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ny9lcnJv",
            "cnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjcuRXJy",
            "b3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdcRXJyb3Jz6gIiR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6Vjc6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.FieldErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.FieldErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.FieldErrorEnum.Types.FieldError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible field errors.
  /// </summary>
  public sealed partial class FieldErrorEnum : pb::IMessage<FieldErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FieldErrorEnum> _parser = new pb::MessageParser<FieldErrorEnum>(() => new FieldErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FieldErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.FieldErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum(FieldErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FieldErrorEnum Clone() {
      return new FieldErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FieldErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FieldErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FieldErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FieldErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible field errors.
      /// </summary>
      public enum FieldError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The required field was not present.
        /// </summary>
        [pbr::OriginalName("REQUIRED")] Required = 2,
        /// <summary>
        /// The field attempted to be mutated is immutable.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 3,
        /// <summary>
        /// The field's value is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE")] InvalidValue = 4,
        /// <summary>
        /// The field cannot be set.
        /// </summary>
        [pbr::OriginalName("VALUE_MUST_BE_UNSET")] ValueMustBeUnset = 5,
        /// <summary>
        /// The required repeated field was empty.
        /// </summary>
        [pbr::OriginalName("REQUIRED_NONEMPTY_LIST")] RequiredNonemptyList = 6,
        /// <summary>
        /// The field cannot be cleared.
        /// </summary>
        [pbr::OriginalName("FIELD_CANNOT_BE_CLEARED")] FieldCannotBeCleared = 7,
        /// <summary>
        /// The field's value is on a deny-list for this field.
        /// </summary>
        [pbr::OriginalName("BLOCKED_VALUE")] BlockedValue = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
