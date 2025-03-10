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
    public sealed class GeneratedAssetGroupAssetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAssetGroupAssetRequestObject()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset response = client.GetAssetGroupAsset(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupAssetRequestObjectAsync()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset responseCallSettings = await client.GetAssetGroupAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroupAsset responseCancellationToken = await client.GetAssetGroupAssetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetGroupAsset()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset response = client.GetAssetGroupAsset(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupAssetAsync()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset responseCallSettings = await client.GetAssetGroupAssetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroupAsset responseCancellationToken = await client.GetAssetGroupAssetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetGroupAssetResourceNames()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset response = client.GetAssetGroupAsset(request.ResourceNameAsAssetGroupAssetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetGroupAssetResourceNamesAsync()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetGroupAsset expectedResponse = new gagvr::AssetGroupAsset
            {
                ResourceNameAsAssetGroupAssetName = gagvr::AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AssetGroupAsAssetGroupName = gagvr::AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                PolicySummary = new gagvc::PolicySummary(),
            };
            mockGrpcClient.Setup(x => x.GetAssetGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetGroupAsset responseCallSettings = await client.GetAssetGroupAssetAsync(request.ResourceNameAsAssetGroupAssetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetGroupAsset responseCancellationToken = await client.GetAssetGroupAssetAsync(request.ResourceNameAsAssetGroupAssetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetGroupAssetsRequestObject()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAssetGroupAssetsResponse expectedResponse = new MutateAssetGroupAssetsResponse
            {
                Results =
                {
                    new MutateAssetGroupAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupAssetsResponse response = client.MutateAssetGroupAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupAssetsRequestObjectAsync()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAssetGroupAssetsResponse expectedResponse = new MutateAssetGroupAssetsResponse
            {
                Results =
                {
                    new MutateAssetGroupAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupAssetsResponse responseCallSettings = await client.MutateAssetGroupAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupAssetsResponse responseCancellationToken = await client.MutateAssetGroupAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetGroupAssets()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
            };
            MutateAssetGroupAssetsResponse expectedResponse = new MutateAssetGroupAssetsResponse
            {
                Results =
                {
                    new MutateAssetGroupAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupAssetsResponse response = client.MutateAssetGroupAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupAssetsAsync()
        {
            moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AssetGroupAssetService.AssetGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
            };
            MutateAssetGroupAssetsResponse expectedResponse = new MutateAssetGroupAssetsResponse
            {
                Results =
                {
                    new MutateAssetGroupAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupAssetServiceClient client = new AssetGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupAssetsResponse responseCallSettings = await client.MutateAssetGroupAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupAssetsResponse responseCancellationToken = await client.MutateAssetGroupAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
