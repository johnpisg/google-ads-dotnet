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
using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDetailedDemographicServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetDetailedDemographicRequestObject()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic response = client.GetDetailedDemographic(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDetailedDemographicRequestObjectAsync()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailedDemographic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic responseCallSettings = await client.GetDetailedDemographicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailedDemographic responseCancellationToken = await client.GetDetailedDemographicAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDetailedDemographic()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic response = client.GetDetailedDemographic(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDetailedDemographicAsync()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailedDemographic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic responseCallSettings = await client.GetDetailedDemographicAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailedDemographic responseCancellationToken = await client.GetDetailedDemographicAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDetailedDemographicResourceNames()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographic(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic response = client.GetDetailedDemographic(request.ResourceNameAsDetailedDemographicName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDetailedDemographicResourceNamesAsync()
        {
            moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient> mockGrpcClient = new moq::Mock<DetailedDemographicService.DetailedDemographicServiceClient>(moq::MockBehavior.Strict);
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            gagvr::DetailedDemographic expectedResponse = new gagvr::DetailedDemographic
            {
                ResourceNameAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                Id = -6774108720365892680L,
                DetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                ParentAsDetailedDemographicName = gagvr::DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetDetailedDemographicAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailedDemographic>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailedDemographicServiceClient client = new DetailedDemographicServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailedDemographic responseCallSettings = await client.GetDetailedDemographicAsync(request.ResourceNameAsDetailedDemographicName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailedDemographic responseCancellationToken = await client.GetDetailedDemographicAsync(request.ResourceNameAsDetailedDemographicName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
