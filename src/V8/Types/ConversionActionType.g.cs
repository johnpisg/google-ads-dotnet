// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/conversion_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/conversion_action_type.proto</summary>
  public static partial class ConversionActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/conversion_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9jb252ZXJzaW9uX2Fj",
            "dGlvbl90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVt",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLpCAoYQ29udmVyc2lv",
            "bkFjdGlvblR5cGVFbnVtIswIChRDb252ZXJzaW9uQWN0aW9uVHlwZRIPCgtV",
            "TlNQRUNJRklFRBAAEgsKB1VOS05PV04QARILCgdBRF9DQUxMEAISEQoNQ0xJ",
            "Q0tfVE9fQ0FMTBADEhgKFEdPT0dMRV9QTEFZX0RPV05MT0FEEAQSHwobR09P",
            "R0xFX1BMQVlfSU5fQVBQX1BVUkNIQVNFEAUSEAoMVVBMT0FEX0NBTExTEAYS",
            "EQoNVVBMT0FEX0NMSUNLUxAHEgsKB1dFQlBBR0UQCBIQCgxXRUJTSVRFX0NB",
            "TEwQCRIdChlTVE9SRV9TQUxFU19ESVJFQ1RfVVBMT0FEEAoSDwoLU1RPUkVf",
            "U0FMRVMQCxIfChtGSVJFQkFTRV9BTkRST0lEX0ZJUlNUX09QRU4QDBIkCiBG",
            "SVJFQkFTRV9BTkRST0lEX0lOX0FQUF9QVVJDSEFTRRANEhsKF0ZJUkVCQVNF",
            "X0FORFJPSURfQ1VTVE9NEA4SGwoXRklSRUJBU0VfSU9TX0ZJUlNUX09QRU4Q",
            "DxIgChxGSVJFQkFTRV9JT1NfSU5fQVBQX1BVUkNIQVNFEBASFwoTRklSRUJB",
            "U0VfSU9TX0NVU1RPTRAREjAKLFRISVJEX1BBUlRZX0FQUF9BTkFMWVRJQ1Nf",
            "QU5EUk9JRF9GSVJTVF9PUEVOEBISNQoxVEhJUkRfUEFSVFlfQVBQX0FOQUxZ",
            "VElDU19BTkRST0lEX0lOX0FQUF9QVVJDSEFTRRATEiwKKFRISVJEX1BBUlRZ",
            "X0FQUF9BTkFMWVRJQ1NfQU5EUk9JRF9DVVNUT00QFBIsCihUSElSRF9QQVJU",
            "WV9BUFBfQU5BTFlUSUNTX0lPU19GSVJTVF9PUEVOEBUSMQotVEhJUkRfUEFS",
            "VFlfQVBQX0FOQUxZVElDU19JT1NfSU5fQVBQX1BVUkNIQVNFEBYSKAokVEhJ",
            "UkRfUEFSVFlfQVBQX0FOQUxZVElDU19JT1NfQ1VTVE9NEBcSIAocQU5EUk9J",
            "RF9BUFBfUFJFX1JFR0lTVFJBVElPThAYEiMKH0FORFJPSURfSU5TVEFMTFNf",
            "QUxMX09USEVSX0FQUFMQGRIVChFGTE9PRExJR0hUX0FDVElPThAaEhoKFkZM",
            "T09ETElHSFRfVFJBTlNBQ1RJT04QGxIRCg1HT09HTEVfSE9TVEVEEBwSFAoQ",
            "TEVBRF9GT1JNX1NVQk1JVBAdEg4KClNBTEVTRk9SQ0UQHhISCg5TRUFSQ0hf",
            "QURTXzM2MBAfEiQKIFNNQVJUX0NBTVBBSUdOX0FEX0NMSUNLU19UT19DQUxM",
            "ECASJQohU01BUlRfQ0FNUEFJR05fTUFQX0NMSUNLU19UT19DQUxMECESIQod",
            "U01BUlRfQ0FNUEFJR05fTUFQX0RJUkVDVElPTlMQIhIgChxTTUFSVF9DQU1Q",
            "QUlHTl9UUkFDS0VEX0NBTExTECMSEAoMU1RPUkVfVklTSVRTECRC7gEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtc0IZQ29udmVyc2lvbkFj",
            "dGlvblR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjgvZW51bXM7ZW51bXOiAgNHQUGq",
            "Ah1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WOC5FbnVtc8oCHUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFY4XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "Vjg6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.ConversionActionTypeEnum), global::Google.Ads.GoogleAds.V8.Enums.ConversionActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.ConversionActionTypeEnum.Types.ConversionActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible types of a conversion action.
  /// </summary>
  public sealed partial class ConversionActionTypeEnum : pb::IMessage<ConversionActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionActionTypeEnum> _parser = new pb::MessageParser<ConversionActionTypeEnum>(() => new ConversionActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.ConversionActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum(ConversionActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum Clone() {
      return new ConversionActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionActionTypeEnum other) {
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
    public void MergeFrom(ConversionActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible types of a conversion action.
      /// </summary>
      public enum ConversionActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversions that occur when a user clicks on an ad's call extension.
        /// </summary>
        [pbr::OriginalName("AD_CALL")] AdCall = 2,
        /// <summary>
        /// Conversions that occur when a user on a mobile device clicks a phone
        /// number.
        /// </summary>
        [pbr::OriginalName("CLICK_TO_CALL")] ClickToCall = 3,
        /// <summary>
        /// Conversions that occur when a user downloads a mobile app from the Google
        /// Play Store.
        /// </summary>
        [pbr::OriginalName("GOOGLE_PLAY_DOWNLOAD")] GooglePlayDownload = 4,
        /// <summary>
        /// Conversions that occur when a user makes a purchase in an app through
        /// Android billing.
        /// </summary>
        [pbr::OriginalName("GOOGLE_PLAY_IN_APP_PURCHASE")] GooglePlayInAppPurchase = 5,
        /// <summary>
        /// Call conversions that are tracked by the advertiser and uploaded.
        /// </summary>
        [pbr::OriginalName("UPLOAD_CALLS")] UploadCalls = 6,
        /// <summary>
        /// Conversions that are tracked by the advertiser and uploaded with
        /// attributed clicks.
        /// </summary>
        [pbr::OriginalName("UPLOAD_CLICKS")] UploadClicks = 7,
        /// <summary>
        /// Conversions that occur on a webpage.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 8,
        /// <summary>
        /// Conversions that occur when a user calls a dynamically-generated phone
        /// number from an advertiser's website.
        /// </summary>
        [pbr::OriginalName("WEBSITE_CALL")] WebsiteCall = 9,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant
        /// data uploads.
        /// Only customers on the allowlist can use store sales direct upload types.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_DIRECT_UPLOAD")] StoreSalesDirectUpload = 10,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant
        /// data uploads and/or from in-store purchases using cards from payment
        /// networks.
        /// Only customers on the allowlist can use store sales types.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("STORE_SALES")] StoreSales = 11,
        /// <summary>
        /// Android app first open conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_FIRST_OPEN")] FirebaseAndroidFirstOpen = 12,
        /// <summary>
        /// Android app in app purchase conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_IN_APP_PURCHASE")] FirebaseAndroidInAppPurchase = 13,
        /// <summary>
        /// Android app custom conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_CUSTOM")] FirebaseAndroidCustom = 14,
        /// <summary>
        /// iOS app first open conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_FIRST_OPEN")] FirebaseIosFirstOpen = 15,
        /// <summary>
        /// iOS app in app purchase conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_IN_APP_PURCHASE")] FirebaseIosInAppPurchase = 16,
        /// <summary>
        /// iOS app custom conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_CUSTOM")] FirebaseIosCustom = 17,
        /// <summary>
        /// Android app first open conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_FIRST_OPEN")] ThirdPartyAppAnalyticsAndroidFirstOpen = 18,
        /// <summary>
        /// Android app in app purchase conversions tracked via Third Party App
        /// Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_IN_APP_PURCHASE")] ThirdPartyAppAnalyticsAndroidInAppPurchase = 19,
        /// <summary>
        /// Android app custom conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_CUSTOM")] ThirdPartyAppAnalyticsAndroidCustom = 20,
        /// <summary>
        /// iOS app first open conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_FIRST_OPEN")] ThirdPartyAppAnalyticsIosFirstOpen = 21,
        /// <summary>
        /// iOS app in app purchase conversions tracked via Third Party App
        /// Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_IN_APP_PURCHASE")] ThirdPartyAppAnalyticsIosInAppPurchase = 22,
        /// <summary>
        /// iOS app custom conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_CUSTOM")] ThirdPartyAppAnalyticsIosCustom = 23,
        /// <summary>
        /// Conversions that occur when a user pre-registers a mobile app from the
        /// Google Play Store. Read only.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_PRE_REGISTRATION")] AndroidAppPreRegistration = 24,
        /// <summary>
        /// Conversions that track all Google Play downloads which aren't tracked
        /// by an app-specific type. Read only.
        /// </summary>
        [pbr::OriginalName("ANDROID_INSTALLS_ALL_OTHER_APPS")] AndroidInstallsAllOtherApps = 25,
        /// <summary>
        /// Floodlight activity that counts the number of times that users have
        /// visited a particular webpage after seeing or clicking on one of
        /// an advertiser's ads. Read only.
        /// </summary>
        [pbr::OriginalName("FLOODLIGHT_ACTION")] FloodlightAction = 26,
        /// <summary>
        /// Floodlight activity that tracks the number of sales made or the number
        /// of items purchased. Can also capture the total value of each sale.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("FLOODLIGHT_TRANSACTION")] FloodlightTransaction = 27,
        /// <summary>
        /// Conversions that track local actions from Google's products and
        /// services after interacting with an ad. Read only.
        /// </summary>
        [pbr::OriginalName("GOOGLE_HOSTED")] GoogleHosted = 28,
        /// <summary>
        /// Conversions reported when a user submits a lead form. Read only.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_SUBMIT")] LeadFormSubmit = 29,
        /// <summary>
        /// Conversions that come from Salesforce. Read only.
        /// </summary>
        [pbr::OriginalName("SALESFORCE")] Salesforce = 30,
        /// <summary>
        /// Conversions imported from Search Ads 360 Floodlight data. Read only.
        /// </summary>
        [pbr::OriginalName("SEARCH_ADS_360")] SearchAds360 = 31,
        /// <summary>
        /// Call conversions that occur on Smart campaign Ads without call tracking
        /// setup, using Smart campaign custom criteria. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_AD_CLICKS_TO_CALL")] SmartCampaignAdClicksToCall = 32,
        /// <summary>
        /// The user clicks on a call element within Google Maps. Smart campaign
        /// only. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_MAP_CLICKS_TO_CALL")] SmartCampaignMapClicksToCall = 33,
        /// <summary>
        /// The user requests directions to a business location within Google Maps.
        /// Smart campaign only. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_MAP_DIRECTIONS")] SmartCampaignMapDirections = 34,
        /// <summary>
        /// Call conversions that occur on Smart campaign Ads with call tracking
        /// setup, using Smart campaign custom criteria. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_TRACKED_CALLS")] SmartCampaignTrackedCalls = 35,
        /// <summary>
        /// Conversions that occur when a user visits an advertiser's retail store.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("STORE_VISITS")] StoreVisits = 36,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
