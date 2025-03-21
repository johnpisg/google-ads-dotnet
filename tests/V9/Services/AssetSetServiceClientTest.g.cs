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
    public sealed class GeneratedAssetSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateAssetSetsRequestObject()
        {
            moq::Mock<AssetSetService.AssetSetServiceClient> mockGrpcClient = new moq::Mock<AssetSetService.AssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetSetsResponse expectedResponse = new MutateAssetSetsResponse
            {
                Results =
                {
                    new MutateAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetSetServiceClient client = new AssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetsResponse response = client.MutateAssetSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetSetsRequestObjectAsync()
        {
            moq::Mock<AssetSetService.AssetSetServiceClient> mockGrpcClient = new moq::Mock<AssetSetService.AssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetSetsResponse expectedResponse = new MutateAssetSetsResponse
            {
                Results =
                {
                    new MutateAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetSetServiceClient client = new AssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetsResponse responseCallSettings = await client.MutateAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetSetsResponse responseCancellationToken = await client.MutateAssetSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetSets()
        {
            moq::Mock<AssetSetService.AssetSetServiceClient> mockGrpcClient = new moq::Mock<AssetSetService.AssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetOperation(),
                },
            };
            MutateAssetSetsResponse expectedResponse = new MutateAssetSetsResponse
            {
                Results =
                {
                    new MutateAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetSetServiceClient client = new AssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetsResponse response = client.MutateAssetSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetSetsAsync()
        {
            moq::Mock<AssetSetService.AssetSetServiceClient> mockGrpcClient = new moq::Mock<AssetSetService.AssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetSetOperation(),
                },
            };
            MutateAssetSetsResponse expectedResponse = new MutateAssetSetsResponse
            {
                Results =
                {
                    new MutateAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetSetServiceClient client = new AssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetSetsResponse responseCallSettings = await client.MutateAssetSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetSetsResponse responseCancellationToken = await client.MutateAssetSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
