// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/mime_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/mime_type.proto</summary>
  public static partial class MimeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/mime_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MimeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9taW1lX3R5cGUucHJv",
            "dG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LmVudW1zGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvItwBCgxNaW1lVHlwZUVudW0iywEKCE1pbWVU",
            "eXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEg4KCklNQUdFX0pQ",
            "RUcQAhINCglJTUFHRV9HSUYQAxINCglJTUFHRV9QTkcQBBIJCgVGTEFTSBAF",
            "Eg0KCVRFWFRfSFRNTBAGEgcKA1BERhAHEgoKBk1TV09SRBAIEgsKB01TRVhD",
            "RUwQCRIHCgNSVEYQChINCglBVURJT19XQVYQCxINCglBVURJT19NUDMQDBIQ",
            "CgxIVE1MNV9BRF9aSVAQDULiAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY4LmVudW1zQg1NaW1lVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OC9lbnVtcztl",
            "bnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY4LkVudW1zygId",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjhcRW51bXPqAiFHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWODo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.MimeTypeEnum), global::Google.Ads.GoogleAds.V8.Enums.MimeTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.MimeTypeEnum.Types.MimeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the mime types.
  /// </summary>
  public sealed partial class MimeTypeEnum : pb::IMessage<MimeTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MimeTypeEnum> _parser = new pb::MessageParser<MimeTypeEnum>(() => new MimeTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MimeTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.MimeTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MimeTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MimeTypeEnum(MimeTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MimeTypeEnum Clone() {
      return new MimeTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MimeTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MimeTypeEnum other) {
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
    public void MergeFrom(MimeTypeEnum other) {
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
    /// <summary>Container for nested types declared in the MimeTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The mime type
      /// </summary>
      public enum MimeType {
        /// <summary>
        /// The mime type has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// MIME type of image/jpeg.
        /// </summary>
        [pbr::OriginalName("IMAGE_JPEG")] ImageJpeg = 2,
        /// <summary>
        /// MIME type of image/gif.
        /// </summary>
        [pbr::OriginalName("IMAGE_GIF")] ImageGif = 3,
        /// <summary>
        /// MIME type of image/png.
        /// </summary>
        [pbr::OriginalName("IMAGE_PNG")] ImagePng = 4,
        /// <summary>
        /// MIME type of application/x-shockwave-flash.
        /// </summary>
        [pbr::OriginalName("FLASH")] Flash = 5,
        /// <summary>
        /// MIME type of text/html.
        /// </summary>
        [pbr::OriginalName("TEXT_HTML")] TextHtml = 6,
        /// <summary>
        /// MIME type of application/pdf.
        /// </summary>
        [pbr::OriginalName("PDF")] Pdf = 7,
        /// <summary>
        /// MIME type of application/msword.
        /// </summary>
        [pbr::OriginalName("MSWORD")] Msword = 8,
        /// <summary>
        /// MIME type of application/vnd.ms-excel.
        /// </summary>
        [pbr::OriginalName("MSEXCEL")] Msexcel = 9,
        /// <summary>
        /// MIME type of application/rtf.
        /// </summary>
        [pbr::OriginalName("RTF")] Rtf = 10,
        /// <summary>
        /// MIME type of audio/wav.
        /// </summary>
        [pbr::OriginalName("AUDIO_WAV")] AudioWav = 11,
        /// <summary>
        /// MIME type of audio/mp3.
        /// </summary>
        [pbr::OriginalName("AUDIO_MP3")] AudioMp3 = 12,
        /// <summary>
        /// MIME type of application/x-html5-ad-zip.
        /// </summary>
        [pbr::OriginalName("HTML5_AD_ZIP")] Html5AdZip = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
