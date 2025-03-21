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
    public sealed class GeneratedSmartCampaignSettingServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetSmartCampaignSettingRequestObject()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting response = client.GetSmartCampaignSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSettingRequestObjectAsync()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting responseCallSettings = await client.GetSmartCampaignSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSetting responseCancellationToken = await client.GetSmartCampaignSettingAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSmartCampaignSetting()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting response = client.GetSmartCampaignSetting(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSettingAsync()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting responseCallSettings = await client.GetSmartCampaignSettingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSetting responseCancellationToken = await client.GetSmartCampaignSettingAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSmartCampaignSettingResourceNames()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting response = client.GetSmartCampaignSetting(request.ResourceNameAsSmartCampaignSettingName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSettingResourceNamesAsync()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::SmartCampaignSetting expectedResponse = new gagvr::SmartCampaignSetting
            {
                ResourceNameAsSmartCampaignSettingName = gagvr::SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                PhoneNumber = new gagvr::SmartCampaignSetting.Types.PhoneNumber(),
                FinalUrl = "final_url01c3df1e",
                BusinessName = "business_nameba1c7bb8",
                BusinessLocationId = 7879742372906296557L,
                AdvertisingLanguageCode = "advertising_language_coded5ffed87",
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSetting responseCallSettings = await client.GetSmartCampaignSettingAsync(request.ResourceNameAsSmartCampaignSettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSetting responseCancellationToken = await client.GetSmartCampaignSettingAsync(request.ResourceNameAsSmartCampaignSettingName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSmartCampaignSettingsRequestObject()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateSmartCampaignSettingsResponse expectedResponse = new MutateSmartCampaignSettingsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateSmartCampaignSettingResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateSmartCampaignSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateSmartCampaignSettingsResponse response = client.MutateSmartCampaignSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSmartCampaignSettingsRequestObjectAsync()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateSmartCampaignSettingsResponse expectedResponse = new MutateSmartCampaignSettingsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateSmartCampaignSettingResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateSmartCampaignSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSmartCampaignSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateSmartCampaignSettingsResponse responseCallSettings = await client.MutateSmartCampaignSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSmartCampaignSettingsResponse responseCancellationToken = await client.MutateSmartCampaignSettingsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSmartCampaignSettings()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
            };
            MutateSmartCampaignSettingsResponse expectedResponse = new MutateSmartCampaignSettingsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateSmartCampaignSettingResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateSmartCampaignSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateSmartCampaignSettingsResponse response = client.MutateSmartCampaignSettings(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSmartCampaignSettingsAsync()
        {
            moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSettingService.SmartCampaignSettingServiceClient>(moq::MockBehavior.Strict);
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
            };
            MutateSmartCampaignSettingsResponse expectedResponse = new MutateSmartCampaignSettingsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateSmartCampaignSettingResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateSmartCampaignSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSmartCampaignSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSettingServiceClient client = new SmartCampaignSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateSmartCampaignSettingsResponse responseCallSettings = await client.MutateSmartCampaignSettingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSmartCampaignSettingsResponse responseCancellationToken = await client.MutateSmartCampaignSettingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
