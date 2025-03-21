// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/campaign_experiment_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/campaign_experiment_error.proto</summary>
  public static partial class CampaignExperimentErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/campaign_experiment_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExperimentErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvY2FtcGFpZ25fZXhw",
            "ZXJpbWVudF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcu",
            "ZXJyb3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoAEChtDYW1w",
            "YWlnbkV4cGVyaW1lbnRFcnJvckVudW0i4AMKF0NhbXBhaWduRXhwZXJpbWVu",
            "dEVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhIKDkRVUExJ",
            "Q0FURV9OQU1FEAISFgoSSU5WQUxJRF9UUkFOU0lUSU9OEAMSLworQ0FOTk9U",
            "X0NSRUFURV9FWFBFUklNRU5UX1dJVEhfU0hBUkVEX0JVREdFVBAEEjYKMkNB",
            "Tk5PVF9DUkVBVEVfRVhQRVJJTUVOVF9GT1JfUkVNT1ZFRF9CQVNFX0NBTVBB",
            "SUdOEAUSMwovQ0FOTk9UX0NSRUFURV9FWFBFUklNRU5UX0ZPUl9OT05fUFJP",
            "UE9TRURfRFJBRlQQBhIlCiFDVVNUT01FUl9DQU5OT1RfQ1JFQVRFX0VYUEVS",
            "SU1FTlQQBxIlCiFDQU1QQUlHTl9DQU5OT1RfQ1JFQVRFX0VYUEVSSU1FTlQQ",
            "CBIpCiVFWFBFUklNRU5UX0RVUkFUSU9OU19NVVNUX05PVF9PVkVSTEFQEAkS",
            "OAo0RVhQRVJJTUVOVF9EVVJBVElPTl9NVVNUX0JFX1dJVEhJTl9DQU1QQUlH",
            "Tl9EVVJBVElPThAKEioKJkNBTk5PVF9NVVRBVEVfRVhQRVJJTUVOVF9EVUVf",
            "VE9fU1RBVFVTEAtC9wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5l",
            "cnJvcnNCHENhbXBhaWduRXhwZXJpbWVudEVycm9yUHJvdG9QAVpEZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3Y3L2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WNy5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWN1xFcnJvcnPq",
            "AiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNzo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.CampaignExperimentErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.CampaignExperimentErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.CampaignExperimentErrorEnum.Types.CampaignExperimentError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign experiment errors.
  /// </summary>
  public sealed partial class CampaignExperimentErrorEnum : pb::IMessage<CampaignExperimentErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignExperimentErrorEnum> _parser = new pb::MessageParser<CampaignExperimentErrorEnum>(() => new CampaignExperimentErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignExperimentErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.CampaignExperimentErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum(CampaignExperimentErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExperimentErrorEnum Clone() {
      return new CampaignExperimentErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignExperimentErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignExperimentErrorEnum other) {
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
    public void MergeFrom(CampaignExperimentErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignExperimentErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign experiment errors.
      /// </summary>
      public enum CampaignExperimentError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active campaign or experiment with this name already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 2,
        /// <summary>
        /// Experiment cannot be updated from the current state to the
        /// requested target state. For example, an experiment can only graduate
        /// if its status is ENABLED.
        /// </summary>
        [pbr::OriginalName("INVALID_TRANSITION")] InvalidTransition = 3,
        /// <summary>
        /// Cannot create an experiment from a campaign using an explicitly shared
        /// budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_WITH_SHARED_BUDGET")] CannotCreateExperimentWithSharedBudget = 4,
        /// <summary>
        /// Cannot create an experiment for a removed base campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_FOR_REMOVED_BASE_CAMPAIGN")] CannotCreateExperimentForRemovedBaseCampaign = 5,
        /// <summary>
        /// Cannot create an experiment from a draft, which has a status other than
        /// proposed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_EXPERIMENT_FOR_NON_PROPOSED_DRAFT")] CannotCreateExperimentForNonProposedDraft = 6,
        /// <summary>
        /// This customer is not allowed to create an experiment.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CANNOT_CREATE_EXPERIMENT")] CustomerCannotCreateExperiment = 7,
        /// <summary>
        /// This campaign is not allowed to create an experiment.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_CREATE_EXPERIMENT")] CampaignCannotCreateExperiment = 8,
        /// <summary>
        /// Trying to set an experiment duration which overlaps with another
        /// experiment.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_DURATIONS_MUST_NOT_OVERLAP")] ExperimentDurationsMustNotOverlap = 9,
        /// <summary>
        /// All non-removed experiments must start and end within their campaign's
        /// duration.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_DURATION_MUST_BE_WITHIN_CAMPAIGN_DURATION")] ExperimentDurationMustBeWithinCampaignDuration = 10,
        /// <summary>
        /// The experiment cannot be modified because its status is in a terminal
        /// state, such as REMOVED.
        /// </summary>
        [pbr::OriginalName("CANNOT_MUTATE_EXPERIMENT_DUE_TO_STATUS")] CannotMutateExperimentDueToStatus = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
