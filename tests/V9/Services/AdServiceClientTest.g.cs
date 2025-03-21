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

using gagvc = Google.Ads.GoogleAds.V9.Common;
using gagve = Google.Ads.GoogleAds.V9.Enums;
using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdRequestObject()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad response = client.GetAd(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdRequestObjectAsync()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Ad>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad responseCallSettings = await client.GetAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Ad responseCancellationToken = await client.GetAdAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAd()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad response = client.GetAd(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdAsync()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Ad>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad responseCallSettings = await client.GetAdAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Ad responseCancellationToken = await client.GetAdAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdResourceNames()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad response = client.GetAd(request.ResourceNameAsAdName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdResourceNamesAsync()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
            };
            gagvr::Ad expectedResponse = new gagvr::Ad
            {
                Type = gagve::AdTypeEnum.Types.AdType.ResponsiveDisplayAd,
                TextAd = new gagvc::TextAdInfo(),
                ExpandedTextAd = new gagvc::ExpandedTextAdInfo(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                ExpandedDynamicSearchAd = new gagvc::ExpandedDynamicSearchAdInfo(),
                HotelAd = new gagvc::HotelAdInfo(),
                ShoppingSmartAd = new gagvc::ShoppingSmartAdInfo(),
                ShoppingProductAd = new gagvc::ShoppingProductAdInfo(),
                DevicePreference = gagve::DeviceEnum.Types.Device.Desktop,
                GmailAd = new gagvc::GmailAdInfo(),
                ImageAd = new gagvc::ImageAdInfo(),
                VideoAd = new gagvc::VideoAdInfo(),
                ResponsiveSearchAd = new gagvc::ResponsiveSearchAdInfo(),
                UrlCollections =
                {
                    new gagvc::UrlCollection(),
                },
                SystemManagedResourceSource = gagve::SystemManagedResourceSourceEnum.Types.SystemManagedResourceSource.AdVariations,
                LegacyResponsiveDisplayAd = new gagvc::LegacyResponsiveDisplayAdInfo(),
                AppAd = new gagvc::AppAdInfo(),
                LegacyAppInstallAd = new gagvc::LegacyAppInstallAdInfo(),
                ResponsiveDisplayAd = new gagvc::ResponsiveDisplayAdInfo(),
                LocalAd = new gagvc::LocalAdInfo(),
                DisplayUploadAd = new gagvc::DisplayUploadAdInfo(),
                AppEngagementAd = new gagvc::AppEngagementAdInfo(),
                FinalAppUrls =
                {
                    new gagvc::FinalAppUrl(),
                },
                ShoppingComparisonListingAd = new gagvc::ShoppingComparisonListingAdInfo(),
                ResourceNameAsAdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                VideoResponsiveAd = new gagvc::VideoResponsiveAdInfo(),
                Id = -6774108720365892680L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                TrackingUrlTemplate = "tracking_url_template157f152a",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                DisplayUrl = "display_url12de0d0c",
                AddedByGoogleAds = true,
                AdName = gagvr::AdName.FromCustomerAd("[CUSTOMER_ID]", "[AD_ID]"),
                SmartCampaignAd = new gagvc::SmartCampaignAdInfo(),
                CallAd = new gagvc::CallAdInfo(),
                AppPreRegistrationAd = new gagvc::AppPreRegistrationAdInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Ad>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Ad responseCallSettings = await client.GetAdAsync(request.ResourceNameAsAdName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Ad responseCancellationToken = await client.GetAdAsync(request.ResourceNameAsAdName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdsRequestObject()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations = { new AdOperation(), },
                ValidateOnly = true,
                PartialFailure = false,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse
            {
                Results =
                {
                    new MutateAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse response = client.MutateAds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdsRequestObjectAsync()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations = { new AdOperation(), },
                ValidateOnly = true,
                PartialFailure = false,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse
            {
                Results =
                {
                    new MutateAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse responseCallSettings = await client.MutateAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdsResponse responseCancellationToken = await client.MutateAdsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAds()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations = { new AdOperation(), },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse
            {
                Results =
                {
                    new MutateAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse response = client.MutateAds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdsAsync()
        {
            moq::Mock<AdService.AdServiceClient> mockGrpcClient = new moq::Mock<AdService.AdServiceClient>(moq::MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations = { new AdOperation(), },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse
            {
                Results =
                {
                    new MutateAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse responseCallSettings = await client.MutateAdsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdsResponse responseCancellationToken = await client.MutateAdsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
