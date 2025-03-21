// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>CampaignExtensionSetting</c> resource.</summary>
    public sealed partial class CampaignExtensionSettingName : gax::IResourceName, sys::IEquatable<CampaignExtensionSettingName>
    {
        /// <summary>The possible contents of <see cref="CampaignExtensionSettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
            /// </summary>
            CustomerCampaignExtensionType = 1,
        }

        private static gax::PathTemplate s_customerCampaignExtensionType = new gax::PathTemplate("customers/{customer_id}/campaignExtensionSettings/{campaign_id_extension_type}");

        /// <summary>
        /// Creates a <see cref="CampaignExtensionSettingName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignExtensionSettingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignExtensionSettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignExtensionSettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignExtensionSettingName"/> with the pattern
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignExtensionSettingName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignExtensionSettingName FromCustomerCampaignExtensionType(string customerId, string campaignId, string extensionTypeId) =>
            new CampaignExtensionSettingName(ResourceNameType.CustomerCampaignExtensionType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), extensionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignExtensionSettingName"/> with
        /// pattern <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignExtensionSettingName"/> with pattern
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string extensionTypeId) =>
            FormatCustomerCampaignExtensionType(customerId, campaignId, extensionTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignExtensionSettingName"/> with
        /// pattern <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignExtensionSettingName"/> with pattern
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>.
        /// </returns>
        public static string FormatCustomerCampaignExtensionType(string customerId, string campaignId, string extensionTypeId) =>
            s_customerCampaignExtensionType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CampaignExtensionSettingName"/> if successful.</returns>
        public static CampaignExtensionSettingName Parse(string campaignExtensionSettingName) =>
            Parse(campaignExtensionSettingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignExtensionSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignExtensionSettingName"/> if successful.</returns>
        public static CampaignExtensionSettingName Parse(string campaignExtensionSettingName, bool allowUnparsed) =>
            TryParse(campaignExtensionSettingName, allowUnparsed, out CampaignExtensionSettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignExtensionSettingName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExtensionSettingName, out CampaignExtensionSettingName result) =>
            TryParse(campaignExtensionSettingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignExtensionSettingName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExtensionSettingName, bool allowUnparsed, out CampaignExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExtensionSettingName, nameof(campaignExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignExtensionType.TryParseName(campaignExtensionSettingName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignExtensionType(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignExtensionSettingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private CampaignExtensionSettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string extensionTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            ExtensionTypeId = extensionTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignExtensionSettingName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionTypeId">The <c>ExtensionType</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignExtensionSettingName(string customerId, string campaignId, string extensionTypeId) : this(ResourceNameType.CustomerCampaignExtensionType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), extensionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionTypeId, nameof(extensionTypeId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>ExtensionType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExtensionTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignExtensionType: return s_customerCampaignExtensionType.Expand(CustomerId, $"{CampaignId}~{ExtensionTypeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignExtensionSettingName);

        /// <inheritdoc/>
        public bool Equals(CampaignExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignExtensionSettingName a, CampaignExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignExtensionSettingName a, CampaignExtensionSettingName b) => !(a == b);
    }

    public partial class CampaignExtensionSetting
    {
        /// <summary>
        /// <see cref="CampaignExtensionSettingName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CampaignExtensionSettingName ResourceNameAsCampaignExtensionSettingName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignExtensionSettingName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExtensionFeedItemName"/>-typed view over the <see cref="ExtensionFeedItems"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ExtensionFeedItemName> ExtensionFeedItemsAsExtensionFeedItemNames
        {
            get => new gax::ResourceNameList<ExtensionFeedItemName>(ExtensionFeedItems, s => string.IsNullOrEmpty(s) ? null : ExtensionFeedItemName.Parse(s, allowUnparsed: true));
        }
    }
}
