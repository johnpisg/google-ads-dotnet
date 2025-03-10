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
    public sealed class GeneratedAssetGroupServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAssetGroupRequestObject()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup response = client.GetAssetGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupRequestObjectAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup responseCallSettings = await client.GetAssetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroup responseCancellationToken = await client.GetAssetGroupAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetGroup()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup response = client.GetAssetGroup(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup responseCallSettings = await client.GetAssetGroupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroup responseCancellationToken = await client.GetAssetGroupAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetGroupResourceNames()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup response = client.GetAssetGroup(request.ResourceNameAsAssetGroupName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupResourceNamesAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            gagvr::AssetGroup expectedResponse = new gagvr::AssetGroup
            {
                ResourceNameAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                Status = gagve::AssetGroupStatusEnum.Types.AssetGroupStatus.Removed,
                Path1 = "path1b90d47d5",
                Path2 = "path252fc32c8",
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroup responseCallSettings = await client.GetAssetGroupAsync(request.ResourceNameAsAssetGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroup responseCancellationToken = await client.GetAssetGroupAsync(request.ResourceNameAsAssetGroupName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetGroupsRequestObject()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = true,
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupsResponse response = client.MutateAssetGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupsRequestObjectAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = true,
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupsResponse responseCallSettings = await client.MutateAssetGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupsResponse responseCancellationToken = await client.MutateAssetGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetGroups()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupsResponse response = client.MutateAssetGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupsAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupsResponse responseCallSettings = await client.MutateAssetGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupsResponse responseCancellationToken = await client.MutateAssetGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
