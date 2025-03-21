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
    public sealed class GeneratedSmartCampaignSearchTermViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetSmartCampaignSearchTermViewRequestObject()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView response = client.GetSmartCampaignSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSearchTermViewRequestObjectAsync()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView responseCallSettings = await client.GetSmartCampaignSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSearchTermView responseCancellationToken = await client.GetSmartCampaignSearchTermViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSmartCampaignSearchTermView()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView response = client.GetSmartCampaignSearchTermView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSearchTermViewAsync()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView responseCallSettings = await client.GetSmartCampaignSearchTermViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSearchTermView responseCancellationToken = await client.GetSmartCampaignSearchTermViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSmartCampaignSearchTermViewResourceNames()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView response = client.GetSmartCampaignSearchTermView(request.ResourceNameAsSmartCampaignSearchTermViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSmartCampaignSearchTermViewResourceNamesAsync()
        {
            moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            gagvr::SmartCampaignSearchTermView expectedResponse = new gagvr::SmartCampaignSearchTermView
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gagvr::SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
                SearchTerm = "search_term6c01a1df",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetSmartCampaignSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SmartCampaignSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSearchTermViewServiceClient client = new SmartCampaignSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SmartCampaignSearchTermView responseCallSettings = await client.GetSmartCampaignSearchTermViewAsync(request.ResourceNameAsSmartCampaignSearchTermViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SmartCampaignSearchTermView responseCancellationToken = await client.GetSmartCampaignSearchTermViewAsync(request.ResourceNameAsSmartCampaignSearchTermViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
