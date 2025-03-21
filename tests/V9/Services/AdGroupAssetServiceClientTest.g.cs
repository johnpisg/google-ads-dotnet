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
    public sealed class GeneratedAdGroupAssetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupAssetRequestObject()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset response = client.GetAdGroupAsset(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAssetRequestObjectAsync()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset responseCallSettings = await client.GetAdGroupAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAsset responseCancellationToken = await client.GetAdGroupAssetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAsset()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset response = client.GetAdGroupAsset(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAssetAsync()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset responseCallSettings = await client.GetAdGroupAssetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAsset responseCancellationToken = await client.GetAdGroupAssetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAssetResourceNames()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset response = client.GetAdGroupAsset(request.ResourceNameAsAdGroupAssetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAssetResourceNamesAsync()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AdGroupAsset expectedResponse = new gagvr::AdGroupAsset
            {
                ResourceNameAsAdGroupAssetName = gagvr::AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER_ID]", "[ASSET_ID]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.Callout,
                Status = gagve::AssetLinkStatusEnum.Types.AssetLinkStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAsset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAsset responseCallSettings = await client.GetAdGroupAssetAsync(request.ResourceNameAsAdGroupAssetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAsset responseCancellationToken = await client.GetAdGroupAssetAsync(request.ResourceNameAsAdGroupAssetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAssetsRequestObject()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAssetsRequest request = new MutateAdGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupAssetsResponse expectedResponse = new MutateAdGroupAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateAdGroupAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAssetsResponse response = client.MutateAdGroupAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAssetsRequestObjectAsync()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAssetsRequest request = new MutateAdGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupAssetsResponse expectedResponse = new MutateAdGroupAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateAdGroupAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAssetsResponse responseCallSettings = await client.MutateAdGroupAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAssetsResponse responseCancellationToken = await client.MutateAdGroupAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAssets()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAssetsRequest request = new MutateAdGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAssetOperation(),
                },
            };
            MutateAdGroupAssetsResponse expectedResponse = new MutateAdGroupAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateAdGroupAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAssetsResponse response = client.MutateAdGroupAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAssetsAsync()
        {
            moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient> mockGrpcClient = new moq::Mock<AdGroupAssetService.AdGroupAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAssetsRequest request = new MutateAdGroupAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAssetOperation(),
                },
            };
            MutateAdGroupAssetsResponse expectedResponse = new MutateAdGroupAssetsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new MutateAdGroupAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAssetServiceClient client = new AdGroupAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAssetsResponse responseCallSettings = await client.MutateAdGroupAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAssetsResponse responseCancellationToken = await client.MutateAdGroupAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
