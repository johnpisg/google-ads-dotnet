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
    public sealed class GeneratedCustomerCustomizerServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCustomerCustomizersRequestObject()
        {
            moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient> mockGrpcClient = new moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerCustomizersResponse expectedResponse = new MutateCustomerCustomizersResponse
            {
                Results =
                {
                    new MutateCustomerCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerCustomizerServiceClient client = new CustomerCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerCustomizersResponse response = client.MutateCustomerCustomizers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerCustomizersRequestObjectAsync()
        {
            moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient> mockGrpcClient = new moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerCustomizersResponse expectedResponse = new MutateCustomerCustomizersResponse
            {
                Results =
                {
                    new MutateCustomerCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerCustomizerServiceClient client = new CustomerCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerCustomizersResponse responseCallSettings = await client.MutateCustomerCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerCustomizersResponse responseCancellationToken = await client.MutateCustomerCustomizersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerCustomizers()
        {
            moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient> mockGrpcClient = new moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
            };
            MutateCustomerCustomizersResponse expectedResponse = new MutateCustomerCustomizersResponse
            {
                Results =
                {
                    new MutateCustomerCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerCustomizerServiceClient client = new CustomerCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerCustomizersResponse response = client.MutateCustomerCustomizers(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerCustomizersAsync()
        {
            moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient> mockGrpcClient = new moq::Mock<CustomerCustomizerService.CustomerCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
            };
            MutateCustomerCustomizersResponse expectedResponse = new MutateCustomerCustomizersResponse
            {
                Results =
                {
                    new MutateCustomerCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerCustomizerServiceClient client = new CustomerCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerCustomizersResponse responseCallSettings = await client.MutateCustomerCustomizersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerCustomizersResponse responseCancellationToken = await client.MutateCustomerCustomizersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
