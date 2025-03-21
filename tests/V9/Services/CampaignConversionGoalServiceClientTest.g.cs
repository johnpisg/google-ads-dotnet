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
    public sealed class GeneratedCampaignConversionGoalServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCampaignConversionGoalsRequestObject()
        {
            moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
                ValidateOnly = true,
            };
            MutateCampaignConversionGoalsResponse expectedResponse = new MutateCampaignConversionGoalsResponse
            {
                Results =
                {
                    new MutateCampaignConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignConversionGoalServiceClient client = new CampaignConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignConversionGoalsResponse response = client.MutateCampaignConversionGoals(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignConversionGoalsRequestObjectAsync()
        {
            moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
                ValidateOnly = true,
            };
            MutateCampaignConversionGoalsResponse expectedResponse = new MutateCampaignConversionGoalsResponse
            {
                Results =
                {
                    new MutateCampaignConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignConversionGoalServiceClient client = new CampaignConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignConversionGoalsResponse responseCallSettings = await client.MutateCampaignConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignConversionGoalsResponse responseCancellationToken = await client.MutateCampaignConversionGoalsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignConversionGoals()
        {
            moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
            };
            MutateCampaignConversionGoalsResponse expectedResponse = new MutateCampaignConversionGoalsResponse
            {
                Results =
                {
                    new MutateCampaignConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignConversionGoalServiceClient client = new CampaignConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignConversionGoalsResponse response = client.MutateCampaignConversionGoals(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignConversionGoalsAsync()
        {
            moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CampaignConversionGoalService.CampaignConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
            };
            MutateCampaignConversionGoalsResponse expectedResponse = new MutateCampaignConversionGoalsResponse
            {
                Results =
                {
                    new MutateCampaignConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCampaignConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignConversionGoalServiceClient client = new CampaignConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignConversionGoalsResponse responseCallSettings = await client.MutateCampaignConversionGoalsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignConversionGoalsResponse responseCancellationToken = await client.MutateCampaignConversionGoalsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
