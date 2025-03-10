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
    public sealed class GeneratedCustomizerAttributeServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCustomizerAttributesRequestObject()
        {
            moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient> mockGrpcClient = new moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient>(moq::MockBehavior.Strict);
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomizerAttributesResponse expectedResponse = new MutateCustomizerAttributesResponse
            {
                Results =
                {
                    new MutateCustomizerAttributeResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomizerAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomizerAttributeServiceClient client = new CustomizerAttributeServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomizerAttributesResponse response = client.MutateCustomizerAttributes(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomizerAttributesRequestObjectAsync()
        {
            moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient> mockGrpcClient = new moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient>(moq::MockBehavior.Strict);
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomizerAttributesResponse expectedResponse = new MutateCustomizerAttributesResponse
            {
                Results =
                {
                    new MutateCustomizerAttributeResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomizerAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomizerAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomizerAttributeServiceClient client = new CustomizerAttributeServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomizerAttributesResponse responseCallSettings = await client.MutateCustomizerAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomizerAttributesResponse responseCancellationToken = await client.MutateCustomizerAttributesAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomizerAttributes()
        {
            moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient> mockGrpcClient = new moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient>(moq::MockBehavior.Strict);
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
            };
            MutateCustomizerAttributesResponse expectedResponse = new MutateCustomizerAttributesResponse
            {
                Results =
                {
                    new MutateCustomizerAttributeResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomizerAttributes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomizerAttributeServiceClient client = new CustomizerAttributeServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomizerAttributesResponse response = client.MutateCustomizerAttributes(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomizerAttributesAsync()
        {
            moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient> mockGrpcClient = new moq::Mock<CustomizerAttributeService.CustomizerAttributeServiceClient>(moq::MockBehavior.Strict);
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
            };
            MutateCustomizerAttributesResponse expectedResponse = new MutateCustomizerAttributesResponse
            {
                Results =
                {
                    new MutateCustomizerAttributeResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomizerAttributesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomizerAttributesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomizerAttributeServiceClient client = new CustomizerAttributeServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomizerAttributesResponse responseCallSettings = await client.MutateCustomizerAttributesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomizerAttributesResponse responseCancellationToken = await client.MutateCustomizerAttributesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
