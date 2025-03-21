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
    public sealed class GeneratedBiddingSeasonalityAdjustmentServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetBiddingSeasonalityAdjustmentRequestObject()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment response = client.GetBiddingSeasonalityAdjustment(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingSeasonalityAdjustmentRequestObjectAsync()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingSeasonalityAdjustment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment responseCallSettings = await client.GetBiddingSeasonalityAdjustmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingSeasonalityAdjustment responseCancellationToken = await client.GetBiddingSeasonalityAdjustmentAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingSeasonalityAdjustment()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment response = client.GetBiddingSeasonalityAdjustment(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingSeasonalityAdjustmentAsync()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingSeasonalityAdjustment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment responseCallSettings = await client.GetBiddingSeasonalityAdjustmentAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingSeasonalityAdjustment responseCancellationToken = await client.GetBiddingSeasonalityAdjustmentAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingSeasonalityAdjustmentResourceNames()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment response = client.GetBiddingSeasonalityAdjustment(request.ResourceNameAsBiddingSeasonalityAdjustmentName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingSeasonalityAdjustmentResourceNamesAsync()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingSeasonalityAdjustment expectedResponse = new gagvr::BiddingSeasonalityAdjustment
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                SeasonalityAdjustmentId = -1683551218662038398L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingSeasonalityAdjustmentName = gagvr::BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                ConversionRateModifier = 6.428816791664124E+17,
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Shopping,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingSeasonalityAdjustmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingSeasonalityAdjustment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingSeasonalityAdjustment responseCallSettings = await client.GetBiddingSeasonalityAdjustmentAsync(request.ResourceNameAsBiddingSeasonalityAdjustmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingSeasonalityAdjustment responseCancellationToken = await client.GetBiddingSeasonalityAdjustmentAsync(request.ResourceNameAsBiddingSeasonalityAdjustmentName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBiddingSeasonalityAdjustmentsRequestObject()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateBiddingSeasonalityAdjustmentsResponse expectedResponse = new MutateBiddingSeasonalityAdjustmentsResponse
            {
                Results =
                {
                    new MutateBiddingSeasonalityAdjustmentsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingSeasonalityAdjustments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingSeasonalityAdjustmentsResponse response = client.MutateBiddingSeasonalityAdjustments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBiddingSeasonalityAdjustmentsRequestObjectAsync()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateBiddingSeasonalityAdjustmentsResponse expectedResponse = new MutateBiddingSeasonalityAdjustmentsResponse
            {
                Results =
                {
                    new MutateBiddingSeasonalityAdjustmentsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingSeasonalityAdjustmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingSeasonalityAdjustmentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingSeasonalityAdjustmentsResponse responseCallSettings = await client.MutateBiddingSeasonalityAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingSeasonalityAdjustmentsResponse responseCancellationToken = await client.MutateBiddingSeasonalityAdjustmentsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBiddingSeasonalityAdjustments()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
            };
            MutateBiddingSeasonalityAdjustmentsResponse expectedResponse = new MutateBiddingSeasonalityAdjustmentsResponse
            {
                Results =
                {
                    new MutateBiddingSeasonalityAdjustmentsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingSeasonalityAdjustments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingSeasonalityAdjustmentsResponse response = client.MutateBiddingSeasonalityAdjustments(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBiddingSeasonalityAdjustmentsAsync()
        {
            moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient> mockGrpcClient = new moq::Mock<BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
            };
            MutateBiddingSeasonalityAdjustmentsResponse expectedResponse = new MutateBiddingSeasonalityAdjustmentsResponse
            {
                Results =
                {
                    new MutateBiddingSeasonalityAdjustmentsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingSeasonalityAdjustmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingSeasonalityAdjustmentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingSeasonalityAdjustmentServiceClient client = new BiddingSeasonalityAdjustmentServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingSeasonalityAdjustmentsResponse responseCallSettings = await client.MutateBiddingSeasonalityAdjustmentsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingSeasonalityAdjustmentsResponse responseCancellationToken = await client.MutateBiddingSeasonalityAdjustmentsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
