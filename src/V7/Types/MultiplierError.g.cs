// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/multiplier_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/multiplier_error.proto</summary>
  public static partial class MultiplierErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/multiplier_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultiplierErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvbXVsdGlwbGllcl9l",
            "cnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZXJyb3JzGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIs8EChNNdWx0aXBsaWVyRXJy",
            "b3JFbnVtIrcECg9NdWx0aXBsaWVyRXJyb3ISDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESFwoTTVVMVElQTElFUl9UT09fSElHSBACEhYKEk1VTFRJ",
            "UExJRVJfVE9PX0xPVxADEh4KGlRPT19NQU5ZX0ZSQUNUSU9OQUxfRElHSVRT",
            "EAQSLworTVVMVElQTElFUl9OT1RfQUxMT1dFRF9GT1JfQklERElOR19TVFJB",
            "VEVHWRAFEjMKL01VTFRJUExJRVJfTk9UX0FMTE9XRURfV0hFTl9CQVNFX0JJ",
            "RF9JU19NSVNTSU5HEAYSGwoXTk9fTVVMVElQTElFUl9TUEVDSUZJRUQQBxIw",
            "CixNVUxUSVBMSUVSX0NBVVNFU19CSURfVE9fRVhDRUVEX0RBSUxZX0JVREdF",
            "VBAIEjIKLk1VTFRJUExJRVJfQ0FVU0VTX0JJRF9UT19FWENFRURfTU9OVEhM",
            "WV9CVURHRVQQCRIxCi1NVUxUSVBMSUVSX0NBVVNFU19CSURfVE9fRVhDRUVE",
            "X0NVU1RPTV9CVURHRVQQChIzCi9NVUxUSVBMSUVSX0NBVVNFU19CSURfVE9f",
            "RVhDRUVEX01BWF9BTExPV0VEX0JJRBALEjEKLUJJRF9MRVNTX1RIQU5fTUlO",
            "X0FMTE9XRURfQklEX1dJVEhfTVVMVElQTElFUhAMEjEKLU1VTFRJUExJRVJf",
            "QU5EX0JJRERJTkdfU1RSQVRFR1lfVFlQRV9NSVNNQVRDSBANQu8BCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZXJyb3JzQhRNdWx0aXBsaWVyRXJy",
            "b3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjcvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlY3LkVycm9yc8oCHkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFY3XEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY3",
            "OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.MultiplierErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.MultiplierErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.MultiplierErrorEnum.Types.MultiplierError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible multiplier errors.
  /// </summary>
  public sealed partial class MultiplierErrorEnum : pb::IMessage<MultiplierErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultiplierErrorEnum> _parser = new pb::MessageParser<MultiplierErrorEnum>(() => new MultiplierErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultiplierErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.MultiplierErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum(MultiplierErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum Clone() {
      return new MultiplierErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultiplierErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultiplierErrorEnum other) {
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
    public void MergeFrom(MultiplierErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MultiplierErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible multiplier errors.
      /// </summary>
      public enum MultiplierError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Multiplier value is too high
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_TOO_HIGH")] MultiplierTooHigh = 2,
        /// <summary>
        /// Multiplier value is too low
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_TOO_LOW")] MultiplierTooLow = 3,
        /// <summary>
        /// Too many fractional digits
        /// </summary>
        [pbr::OriginalName("TOO_MANY_FRACTIONAL_DIGITS")] TooManyFractionalDigits = 4,
        /// <summary>
        /// A multiplier cannot be set for this bidding strategy
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_NOT_ALLOWED_FOR_BIDDING_STRATEGY")] MultiplierNotAllowedForBiddingStrategy = 5,
        /// <summary>
        /// A multiplier cannot be set when there is no base bid (e.g., content max
        /// cpc)
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_NOT_ALLOWED_WHEN_BASE_BID_IS_MISSING")] MultiplierNotAllowedWhenBaseBidIsMissing = 6,
        /// <summary>
        /// A bid multiplier must be specified
        /// </summary>
        [pbr::OriginalName("NO_MULTIPLIER_SPECIFIED")] NoMultiplierSpecified = 7,
        /// <summary>
        /// Multiplier causes bid to exceed daily budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_DAILY_BUDGET")] MultiplierCausesBidToExceedDailyBudget = 8,
        /// <summary>
        /// Multiplier causes bid to exceed monthly budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_MONTHLY_BUDGET")] MultiplierCausesBidToExceedMonthlyBudget = 9,
        /// <summary>
        /// Multiplier causes bid to exceed custom budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_CUSTOM_BUDGET")] MultiplierCausesBidToExceedCustomBudget = 10,
        /// <summary>
        /// Multiplier causes bid to exceed maximum allowed bid
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_MAX_ALLOWED_BID")] MultiplierCausesBidToExceedMaxAllowedBid = 11,
        /// <summary>
        /// Multiplier causes bid to become less than the minimum bid allowed
        /// </summary>
        [pbr::OriginalName("BID_LESS_THAN_MIN_ALLOWED_BID_WITH_MULTIPLIER")] BidLessThanMinAllowedBidWithMultiplier = 12,
        /// <summary>
        /// Multiplier type (cpc vs. cpm) needs to match campaign's bidding strategy
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_AND_BIDDING_STRATEGY_TYPE_MISMATCH")] MultiplierAndBiddingStrategyTypeMismatch = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
