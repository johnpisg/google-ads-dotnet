// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/click_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/click_type.proto</summary>
  public static partial class ClickTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/click_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9jbGlja190eXBlLnBy",
            "b3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVtcxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byKmDAoNQ2xpY2tUeXBlRW51bSKUDAoJQ2xp",
            "Y2tUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhAKDEFQUF9E",
            "RUVQTElOSxACEg8KC0JSRUFEQ1JVTUJTEAMSEgoOQlJPQURCQU5EX1BMQU4Q",
            "BBIRCg1DQUxMX1RSQUNLSU5HEAUSCQoFQ0FMTFMQBhIaChZDTElDS19PTl9F",
            "TkdBR0VNRU5UX0FEEAcSEgoOR0VUX0RJUkVDVElPTlMQCBIWChJMT0NBVElP",
            "Tl9FWFBBTlNJT04QCRIYChRMT0NBVElPTl9GT1JNQVRfQ0FMTBAKEh4KGkxP",
            "Q0FUSU9OX0ZPUk1BVF9ESVJFQ1RJT05TEAsSGQoVTE9DQVRJT05fRk9STUFU",
            "X0lNQUdFEAwSIAocTE9DQVRJT05fRk9STUFUX0xBTkRJTkdfUEFHRRANEhcK",
            "E0xPQ0FUSU9OX0ZPUk1BVF9NQVAQDhIeChpMT0NBVElPTl9GT1JNQVRfU1RP",
            "UkVfSU5GTxAPEhgKFExPQ0FUSU9OX0ZPUk1BVF9URVhUEBASGAoUTU9CSUxF",
            "X0NBTExfVFJBQ0tJTkcQERIQCgxPRkZFUl9QUklOVFMQEhIJCgVPVEhFUhAT",
            "EhwKGFBST0RVQ1RfRVhURU5TSU9OX0NMSUNLUxAUEh0KGVBST0RVQ1RfTElT",
            "VElOR19BRF9DTElDS1MQFRINCglTSVRFTElOS1MQFhIRCg1TVE9SRV9MT0NB",
            "VE9SEBcSDgoKVVJMX0NMSUNLUxAZEhoKFlZJREVPX0FQUF9TVE9SRV9DTElD",
            "S1MQGhIfChtWSURFT19DQUxMX1RPX0FDVElPTl9DTElDS1MQGxIlCiFWSURF",
            "T19DQVJEX0FDVElPTl9IRUFETElORV9DTElDS1MQHBIYChRWSURFT19FTkRf",
            "Q0FQX0NMSUNLUxAdEhgKFFZJREVPX1dFQlNJVEVfQ0xJQ0tTEB4SFAoQVklT",
            "VUFMX1NJVEVMSU5LUxAfEhEKDVdJUkVMRVNTX1BMQU4QIBIcChhQUk9EVUNU",
            "X0xJU1RJTkdfQURfTE9DQUwQIRIpCiVQUk9EVUNUX0xJU1RJTkdfQURfTVVM",
            "VElDSEFOTkVMX0xPQ0FMECISKgomUFJPRFVDVF9MSVNUSU5HX0FEX01VTFRJ",
            "Q0hBTk5FTF9PTkxJTkUQIxIeChpQUk9EVUNUX0xJU1RJTkdfQURTX0NPVVBP",
            "ThAkEiMKH1BST0RVQ1RfTElTVElOR19BRF9UUkFOU0FDVEFCTEUQJRIbChdQ",
            "Uk9EVUNUX0FEX0FQUF9ERUVQTElOSxAmEh0KGVNIT1dDQVNFX0FEX0NBVEVH",
            "T1JZX0xJTksQJxIlCiFTSE9XQ0FTRV9BRF9MT0NBTF9TVE9SRUZST05UX0xJ",
            "TksQKBIjCh9TSE9XQ0FTRV9BRF9PTkxJTkVfUFJPRFVDVF9MSU5LECoSIgoe",
            "U0hPV0NBU0VfQURfTE9DQUxfUFJPRFVDVF9MSU5LECsSFwoTUFJPTU9USU9O",
            "X0VYVEVOU0lPThAsEiEKHVNXSVBFQUJMRV9HQUxMRVJZX0FEX0hFQURMSU5F",
            "EC0SHwobU1dJUEVBQkxFX0dBTExFUllfQURfU1dJUEVTEC4SIQodU1dJUEVB",
            "QkxFX0dBTExFUllfQURfU0VFX01PUkUQLxIlCiFTV0lQRUFCTEVfR0FMTEVS",
            "WV9BRF9TSVRFTElOS19PTkUQMBIlCiFTV0lQRUFCTEVfR0FMTEVSWV9BRF9T",
            "SVRFTElOS19UV08QMRInCiNTV0lQRUFCTEVfR0FMTEVSWV9BRF9TSVRFTElO",
            "S19USFJFRRAyEiYKIlNXSVBFQUJMRV9HQUxMRVJZX0FEX1NJVEVMSU5LX0ZP",
            "VVIQMxImCiJTV0lQRUFCTEVfR0FMTEVSWV9BRF9TSVRFTElOS19GSVZFEDQS",
            "DwoLSE9URUxfUFJJQ0UQNRITCg9QUklDRV9FWFRFTlNJT04QNhInCiNIT1RF",
            "TF9CT09LX09OX0dPT0dMRV9ST09NX1NFTEVDVElPThA3Eh8KG1NIT1BQSU5H",
            "X0NPTVBBUklTT05fTElTVElORxA4QuMBCiFjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjcuZW51bXNCDkNsaWNrVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ny9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY3LkVu",
            "dW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdcRW51bXPqAiFHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWNzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.ClickTypeEnum), global::Google.Ads.GoogleAds.V7.Enums.ClickTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.ClickTypeEnum.Types.ClickType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of Google Ads click types.
  /// </summary>
  public sealed partial class ClickTypeEnum : pb::IMessage<ClickTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClickTypeEnum> _parser = new pb::MessageParser<ClickTypeEnum>(() => new ClickTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClickTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.ClickTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum(ClickTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClickTypeEnum Clone() {
      return new ClickTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClickTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClickTypeEnum other) {
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
    public void MergeFrom(ClickTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ClickTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates Google Ads click types.
      /// </summary>
      public enum ClickType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// App engagement ad deep link.
        /// </summary>
        [pbr::OriginalName("APP_DEEPLINK")] AppDeeplink = 2,
        /// <summary>
        /// Breadcrumbs.
        /// </summary>
        [pbr::OriginalName("BREADCRUMBS")] Breadcrumbs = 3,
        /// <summary>
        /// Broadband Plan.
        /// </summary>
        [pbr::OriginalName("BROADBAND_PLAN")] BroadbandPlan = 4,
        /// <summary>
        /// Manually dialed phone calls.
        /// </summary>
        [pbr::OriginalName("CALL_TRACKING")] CallTracking = 5,
        /// <summary>
        /// Phone calls.
        /// </summary>
        [pbr::OriginalName("CALLS")] Calls = 6,
        /// <summary>
        /// Click on engagement ad.
        /// </summary>
        [pbr::OriginalName("CLICK_ON_ENGAGEMENT_AD")] ClickOnEngagementAd = 7,
        /// <summary>
        /// Driving direction.
        /// </summary>
        [pbr::OriginalName("GET_DIRECTIONS")] GetDirections = 8,
        /// <summary>
        /// Get location details.
        /// </summary>
        [pbr::OriginalName("LOCATION_EXPANSION")] LocationExpansion = 9,
        /// <summary>
        /// Call.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_CALL")] LocationFormatCall = 10,
        /// <summary>
        /// Directions.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_DIRECTIONS")] LocationFormatDirections = 11,
        /// <summary>
        /// Image(s).
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_IMAGE")] LocationFormatImage = 12,
        /// <summary>
        /// Go to landing page.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_LANDING_PAGE")] LocationFormatLandingPage = 13,
        /// <summary>
        /// Map.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_MAP")] LocationFormatMap = 14,
        /// <summary>
        /// Go to store info.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_STORE_INFO")] LocationFormatStoreInfo = 15,
        /// <summary>
        /// Text.
        /// </summary>
        [pbr::OriginalName("LOCATION_FORMAT_TEXT")] LocationFormatText = 16,
        /// <summary>
        /// Mobile phone calls.
        /// </summary>
        [pbr::OriginalName("MOBILE_CALL_TRACKING")] MobileCallTracking = 17,
        /// <summary>
        /// Print offer.
        /// </summary>
        [pbr::OriginalName("OFFER_PRINTS")] OfferPrints = 18,
        /// <summary>
        /// Other.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 19,
        /// <summary>
        /// Product plusbox offer.
        /// </summary>
        [pbr::OriginalName("PRODUCT_EXTENSION_CLICKS")] ProductExtensionClicks = 20,
        /// <summary>
        /// Shopping - Product - Online.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_CLICKS")] ProductListingAdClicks = 21,
        /// <summary>
        /// Sitelink.
        /// </summary>
        [pbr::OriginalName("SITELINKS")] Sitelinks = 22,
        /// <summary>
        /// Show nearby locations.
        /// </summary>
        [pbr::OriginalName("STORE_LOCATOR")] StoreLocator = 23,
        /// <summary>
        /// Headline.
        /// </summary>
        [pbr::OriginalName("URL_CLICKS")] UrlClicks = 25,
        /// <summary>
        /// App store.
        /// </summary>
        [pbr::OriginalName("VIDEO_APP_STORE_CLICKS")] VideoAppStoreClicks = 26,
        /// <summary>
        /// Call-to-Action overlay.
        /// </summary>
        [pbr::OriginalName("VIDEO_CALL_TO_ACTION_CLICKS")] VideoCallToActionClicks = 27,
        /// <summary>
        /// Cards.
        /// </summary>
        [pbr::OriginalName("VIDEO_CARD_ACTION_HEADLINE_CLICKS")] VideoCardActionHeadlineClicks = 28,
        /// <summary>
        /// End cap.
        /// </summary>
        [pbr::OriginalName("VIDEO_END_CAP_CLICKS")] VideoEndCapClicks = 29,
        /// <summary>
        /// Website.
        /// </summary>
        [pbr::OriginalName("VIDEO_WEBSITE_CLICKS")] VideoWebsiteClicks = 30,
        /// <summary>
        /// Visual Sitelinks.
        /// </summary>
        [pbr::OriginalName("VISUAL_SITELINKS")] VisualSitelinks = 31,
        /// <summary>
        /// Wireless Plan.
        /// </summary>
        [pbr::OriginalName("WIRELESS_PLAN")] WirelessPlan = 32,
        /// <summary>
        /// Shopping - Product - Local.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_LOCAL")] ProductListingAdLocal = 33,
        /// <summary>
        /// Shopping - Product - MultiChannel Local.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_MULTICHANNEL_LOCAL")] ProductListingAdMultichannelLocal = 34,
        /// <summary>
        /// Shopping - Product - MultiChannel Online.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_MULTICHANNEL_ONLINE")] ProductListingAdMultichannelOnline = 35,
        /// <summary>
        /// Shopping - Product - Coupon.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_ADS_COUPON")] ProductListingAdsCoupon = 36,
        /// <summary>
        /// Shopping - Product - Sell on Google.
        /// </summary>
        [pbr::OriginalName("PRODUCT_LISTING_AD_TRANSACTABLE")] ProductListingAdTransactable = 37,
        /// <summary>
        /// Shopping - Product - App engagement ad deep link.
        /// </summary>
        [pbr::OriginalName("PRODUCT_AD_APP_DEEPLINK")] ProductAdAppDeeplink = 38,
        /// <summary>
        /// Shopping - Showcase - Category.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_CATEGORY_LINK")] ShowcaseAdCategoryLink = 39,
        /// <summary>
        /// Shopping - Showcase - Local storefront.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_LOCAL_STOREFRONT_LINK")] ShowcaseAdLocalStorefrontLink = 40,
        /// <summary>
        /// Shopping - Showcase - Online product.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_ONLINE_PRODUCT_LINK")] ShowcaseAdOnlineProductLink = 42,
        /// <summary>
        /// Shopping - Showcase - Local product.
        /// </summary>
        [pbr::OriginalName("SHOWCASE_AD_LOCAL_PRODUCT_LINK")] ShowcaseAdLocalProductLink = 43,
        /// <summary>
        /// Promotion Extension.
        /// </summary>
        [pbr::OriginalName("PROMOTION_EXTENSION")] PromotionExtension = 44,
        /// <summary>
        /// Ad Headline.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_HEADLINE")] SwipeableGalleryAdHeadline = 45,
        /// <summary>
        /// Swipes.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SWIPES")] SwipeableGalleryAdSwipes = 46,
        /// <summary>
        /// See More.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SEE_MORE")] SwipeableGalleryAdSeeMore = 47,
        /// <summary>
        /// Sitelink 1.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_ONE")] SwipeableGalleryAdSitelinkOne = 48,
        /// <summary>
        /// Sitelink 2.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_TWO")] SwipeableGalleryAdSitelinkTwo = 49,
        /// <summary>
        /// Sitelink 3.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_THREE")] SwipeableGalleryAdSitelinkThree = 50,
        /// <summary>
        /// Sitelink 4.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_FOUR")] SwipeableGalleryAdSitelinkFour = 51,
        /// <summary>
        /// Sitelink 5.
        /// </summary>
        [pbr::OriginalName("SWIPEABLE_GALLERY_AD_SITELINK_FIVE")] SwipeableGalleryAdSitelinkFive = 52,
        /// <summary>
        /// Hotel price.
        /// </summary>
        [pbr::OriginalName("HOTEL_PRICE")] HotelPrice = 53,
        /// <summary>
        /// Price Extension.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION")] PriceExtension = 54,
        /// <summary>
        /// Book on Google hotel room selection.
        /// </summary>
        [pbr::OriginalName("HOTEL_BOOK_ON_GOOGLE_ROOM_SELECTION")] HotelBookOnGoogleRoomSelection = 55,
        /// <summary>
        /// Shopping - Comparison Listing.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING")] ShoppingComparisonListing = 56,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
