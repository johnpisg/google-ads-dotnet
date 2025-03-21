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
    public sealed class GeneratedAssetSetAssetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateAssetSetAssetsRequestObject()
        {
            moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient> mockGrpcClient = new moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetSetAssetsResponse expectedResponse = new MutateAssetSetAssetsResponse
            {
                Results =
                {
                    new MutateAssetSetAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetSetAssetServiceClient client = new AssetSetAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetAssetsResponse response = client.MutateAssetSetAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetSetAssetsRequestObjectAsync()
        {
            moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient> mockGrpcClient = new moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetSetAssetsResponse expectedResponse = new MutateAssetSetAssetsResponse
            {
                Results =
                {
                    new MutateAssetSetAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetSetAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetSetAssetServiceClient client = new AssetSetAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetAssetsResponse responseCallSettings = await client.MutateAssetSetAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetSetAssetsResponse responseCancellationToken = await client.MutateAssetSetAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetSetAssets()
        {
            moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient> mockGrpcClient = new moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
            };
            MutateAssetSetAssetsResponse expectedResponse = new MutateAssetSetAssetsResponse
            {
                Results =
                {
                    new MutateAssetSetAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetSetAssetServiceClient client = new AssetSetAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetAssetsResponse response = client.MutateAssetSetAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetSetAssetsAsync()
        {
            moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient> mockGrpcClient = new moq::Mock<AssetSetAssetService.AssetSetAssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
            };
            MutateAssetSetAssetsResponse expectedResponse = new MutateAssetSetAssetsResponse
            {
                Results =
                {
                    new MutateAssetSetAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetSetAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetSetAssetServiceClient client = new AssetSetAssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetAssetsResponse responseCallSettings = await client.MutateAssetSetAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetSetAssetsResponse responseCancellationToken = await client.MutateAssetSetAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
