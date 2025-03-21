// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/lead_form_post_submit_call_to_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/lead_form_post_submit_call_to_action_type.proto</summary>
  public static partial class LeadFormPostSubmitCallToActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/lead_form_post_submit_call_to_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LeadFormPostSubmitCallToActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9sZWFkX2Zvcm1fcG9z",
            "dF9zdWJtaXRfY2FsbF90b19hY3Rpb25fdHlwZS5wcm90bxIdZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjcuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8iqAEKJkxlYWRGb3JtUG9zdFN1Ym1pdENhbGxUb0FjdGlvblR5cGVF",
            "bnVtIn4KIkxlYWRGb3JtUG9zdFN1Ym1pdENhbGxUb0FjdGlvblR5cGUSDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDgoKVklTSVRfU0lURRACEgwK",
            "CERPV05MT0FEEAMSDgoKTEVBUk5fTU9SRRAEEgwKCFNIT1BfTk9XEAVC/AEK",
            "IWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVtc0InTGVhZEZvcm1Q",
            "b3N0U3VibWl0Q2FsbFRvQWN0aW9uVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ny9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY3LkVu",
            "dW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdcRW51bXPqAiFHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWNzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.LeadFormPostSubmitCallToActionTypeEnum), global::Google.Ads.GoogleAds.V7.Enums.LeadFormPostSubmitCallToActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.LeadFormPostSubmitCallToActionTypeEnum.Types.LeadFormPostSubmitCallToActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the type of post-submit call-to-action phrases for a lead form.
  /// </summary>
  public sealed partial class LeadFormPostSubmitCallToActionTypeEnum : pb::IMessage<LeadFormPostSubmitCallToActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LeadFormPostSubmitCallToActionTypeEnum> _parser = new pb::MessageParser<LeadFormPostSubmitCallToActionTypeEnum>(() => new LeadFormPostSubmitCallToActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LeadFormPostSubmitCallToActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.LeadFormPostSubmitCallToActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormPostSubmitCallToActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormPostSubmitCallToActionTypeEnum(LeadFormPostSubmitCallToActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormPostSubmitCallToActionTypeEnum Clone() {
      return new LeadFormPostSubmitCallToActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LeadFormPostSubmitCallToActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LeadFormPostSubmitCallToActionTypeEnum other) {
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
    public void MergeFrom(LeadFormPostSubmitCallToActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the LeadFormPostSubmitCallToActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the type of post-submit call-to-action phrases for a lead
      /// form.
      /// </summary>
      public enum LeadFormPostSubmitCallToActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Visit site.
        /// </summary>
        [pbr::OriginalName("VISIT_SITE")] VisitSite = 2,
        /// <summary>
        /// Download.
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 3,
        /// <summary>
        /// Learn more.
        /// </summary>
        [pbr::OriginalName("LEARN_MORE")] LearnMore = 4,
        /// <summary>
        /// Shop now.
        /// </summary>
        [pbr::OriginalName("SHOP_NOW")] ShopNow = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
