// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/account_budget_proposal_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/account_budget_proposal_error.proto</summary>
  public static partial class AccountBudgetProposalErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/account_budget_proposal_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountBudgetProposalErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvYWNjb3VudF9idWRn",
            "ZXRfcHJvcG9zYWxfZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY3LmVycm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKYBwoe",
            "QWNjb3VudEJ1ZGdldFByb3Bvc2FsRXJyb3JFbnVtIvUGChpBY2NvdW50QnVk",
            "Z2V0UHJvcG9zYWxFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIaChZGSUVMRF9NQVNLX05PVF9BTExPV0VEEAISEwoPSU1NVVRBQkxFX0ZJ",
            "RUxEEAMSGgoWUkVRVUlSRURfRklFTERfTUlTU0lORxAEEiMKH0NBTk5PVF9D",
            "QU5DRUxfQVBQUk9WRURfUFJPUE9TQUwQBRIjCh9DQU5OT1RfUkVNT1ZFX1VO",
            "QVBQUk9WRURfQlVER0VUEAYSIAocQ0FOTk9UX1JFTU9WRV9SVU5OSU5HX0JV",
            "REdFVBAHEiAKHENBTk5PVF9FTkRfVU5BUFBST1ZFRF9CVURHRVQQCBIeChpD",
            "QU5OT1RfRU5EX0lOQUNUSVZFX0JVREdFVBAJEhgKFEJVREdFVF9OQU1FX1JF",
            "UVVJUkVEEAoSHAoYQ0FOTk9UX1VQREFURV9PTERfQlVER0VUEAsSFgoSQ0FO",
            "Tk9UX0VORF9JTl9QQVNUEAwSGgoWQ0FOTk9UX0VYVEVORF9FTkRfVElNRRAN",
            "EiIKHlBVUkNIQVNFX09SREVSX05VTUJFUl9SRVFVSVJFRBAOEiIKHlBFTkRJ",
            "TkdfVVBEQVRFX1BST1BPU0FMX0VYSVNUUxAPEj0KOU1VTFRJUExFX0JVREdF",
            "VFNfTk9UX0FMTE9XRURfRk9SX1VOQVBQUk9WRURfQklMTElOR19TRVRVUBAQ",
            "Ei8KK0NBTk5PVF9VUERBVEVfU1RBUlRfVElNRV9GT1JfU1RBUlRFRF9CVURH",
            "RVQQERI2CjJTUEVORElOR19MSU1JVF9MT1dFUl9USEFOX0FDQ1JVRURfQ09T",
            "VF9OT1RfQUxMT1dFRBASEhMKD1VQREFURV9JU19OT19PUBATEiMKH0VORF9U",
            "SU1FX01VU1RfRk9MTE9XX1NUQVJUX1RJTUUQFBI1CjFCVURHRVRfREFURV9S",
            "QU5HRV9JTkNPTVBBVElCTEVfV0lUSF9CSUxMSU5HX1NFVFVQEBUSEgoOTk9U",
            "X0FVVEhPUklaRUQQFhIZChVJTlZBTElEX0JJTExJTkdfU0VUVVAQFxIcChhP",
            "VkVSTEFQU19FWElTVElOR19CVURHRVQQGBIkCiBDQU5OT1RfQ1JFQVRFX0JV",
            "REdFVF9USFJPVUdIX0FQSRAZQvoBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjcuZXJyb3JzQh9BY2NvdW50QnVkZ2V0UHJvcG9zYWxFcnJvclByb3Rv",
            "UAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92Ny9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjcuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjdcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OkVycm9y",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.AccountBudgetProposalErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.AccountBudgetProposalErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.AccountBudgetProposalErrorEnum.Types.AccountBudgetProposalError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible account budget proposal errors.
  /// </summary>
  public sealed partial class AccountBudgetProposalErrorEnum : pb::IMessage<AccountBudgetProposalErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccountBudgetProposalErrorEnum> _parser = new pb::MessageParser<AccountBudgetProposalErrorEnum>(() => new AccountBudgetProposalErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccountBudgetProposalErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.AccountBudgetProposalErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum(AccountBudgetProposalErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccountBudgetProposalErrorEnum Clone() {
      return new AccountBudgetProposalErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccountBudgetProposalErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccountBudgetProposalErrorEnum other) {
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
    public void MergeFrom(AccountBudgetProposalErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AccountBudgetProposalErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible account budget proposal errors.
      /// </summary>
      public enum AccountBudgetProposalError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The field mask must be empty for create/end/remove proposals.
        /// </summary>
        [pbr::OriginalName("FIELD_MASK_NOT_ALLOWED")] FieldMaskNotAllowed = 2,
        /// <summary>
        /// The field cannot be set because of the proposal type.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 3,
        /// <summary>
        /// The field is required because of the proposal type.
        /// </summary>
        [pbr::OriginalName("REQUIRED_FIELD_MISSING")] RequiredFieldMissing = 4,
        /// <summary>
        /// Proposals that have been approved cannot be cancelled.
        /// </summary>
        [pbr::OriginalName("CANNOT_CANCEL_APPROVED_PROPOSAL")] CannotCancelApprovedProposal = 5,
        /// <summary>
        /// Budgets that haven't been approved cannot be removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_UNAPPROVED_BUDGET")] CannotRemoveUnapprovedBudget = 6,
        /// <summary>
        /// Budgets that are currently running cannot be removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_RUNNING_BUDGET")] CannotRemoveRunningBudget = 7,
        /// <summary>
        /// Budgets that haven't been approved cannot be truncated.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_UNAPPROVED_BUDGET")] CannotEndUnapprovedBudget = 8,
        /// <summary>
        /// Only budgets that are currently running can be truncated.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_INACTIVE_BUDGET")] CannotEndInactiveBudget = 9,
        /// <summary>
        /// All budgets must have names.
        /// </summary>
        [pbr::OriginalName("BUDGET_NAME_REQUIRED")] BudgetNameRequired = 10,
        /// <summary>
        /// Expired budgets cannot be edited after a sufficient amount of time has
        /// passed.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_OLD_BUDGET")] CannotUpdateOldBudget = 11,
        /// <summary>
        /// It is not permissible a propose a new budget that ends in the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_END_IN_PAST")] CannotEndInPast = 12,
        /// <summary>
        /// An expired budget cannot be extended to overlap with the running budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXTEND_END_TIME")] CannotExtendEndTime = 13,
        /// <summary>
        /// A purchase order number is required.
        /// </summary>
        [pbr::OriginalName("PURCHASE_ORDER_NUMBER_REQUIRED")] PurchaseOrderNumberRequired = 14,
        /// <summary>
        /// Budgets that have a pending update cannot be updated.
        /// </summary>
        [pbr::OriginalName("PENDING_UPDATE_PROPOSAL_EXISTS")] PendingUpdateProposalExists = 15,
        /// <summary>
        /// Cannot propose more than one budget when the corresponding billing setup
        /// hasn't been approved.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_BUDGETS_NOT_ALLOWED_FOR_UNAPPROVED_BILLING_SETUP")] MultipleBudgetsNotAllowedForUnapprovedBillingSetup = 16,
        /// <summary>
        /// Cannot update the start time of a budget that has already started.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_START_TIME_FOR_STARTED_BUDGET")] CannotUpdateStartTimeForStartedBudget = 17,
        /// <summary>
        /// Cannot update the spending limit of a budget with an amount lower than
        /// what has already been spent.
        /// </summary>
        [pbr::OriginalName("SPENDING_LIMIT_LOWER_THAN_ACCRUED_COST_NOT_ALLOWED")] SpendingLimitLowerThanAccruedCostNotAllowed = 18,
        /// <summary>
        /// Cannot propose a budget update without actually changing any fields.
        /// </summary>
        [pbr::OriginalName("UPDATE_IS_NO_OP")] UpdateIsNoOp = 19,
        /// <summary>
        /// The end time must come after the start time.
        /// </summary>
        [pbr::OriginalName("END_TIME_MUST_FOLLOW_START_TIME")] EndTimeMustFollowStartTime = 20,
        /// <summary>
        /// The budget's date range must fall within the date range of its billing
        /// setup.
        /// </summary>
        [pbr::OriginalName("BUDGET_DATE_RANGE_INCOMPATIBLE_WITH_BILLING_SETUP")] BudgetDateRangeIncompatibleWithBillingSetup = 21,
        /// <summary>
        /// The user is not authorized to mutate budgets for the given billing setup.
        /// </summary>
        [pbr::OriginalName("NOT_AUTHORIZED")] NotAuthorized = 22,
        /// <summary>
        /// Mutates are not allowed for the given billing setup.
        /// </summary>
        [pbr::OriginalName("INVALID_BILLING_SETUP")] InvalidBillingSetup = 23,
        /// <summary>
        /// Budget creation failed as it overlaps with an pending budget proposal
        /// or an approved budget.
        /// </summary>
        [pbr::OriginalName("OVERLAPS_EXISTING_BUDGET")] OverlapsExistingBudget = 24,
        /// <summary>
        /// The control setting in user's payments profile doesn't allow budget
        /// creation through API. Log in to Google Ads to create budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_BUDGET_THROUGH_API")] CannotCreateBudgetThroughApi = 25,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
