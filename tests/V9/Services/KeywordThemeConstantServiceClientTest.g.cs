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
    public sealed class GeneratedKeywordThemeConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordThemeConstantRequestObject()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant response = client.GetKeywordThemeConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordThemeConstantRequestObjectAsync()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordThemeConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant responseCallSettings = await client.GetKeywordThemeConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordThemeConstant responseCancellationToken = await client.GetKeywordThemeConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordThemeConstant()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant response = client.GetKeywordThemeConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordThemeConstantAsync()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordThemeConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant responseCallSettings = await client.GetKeywordThemeConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordThemeConstant responseCancellationToken = await client.GetKeywordThemeConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordThemeConstantResourceNames()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant response = client.GetKeywordThemeConstant(request.ResourceNameAsKeywordThemeConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordThemeConstantResourceNamesAsync()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            gagvr::KeywordThemeConstant expectedResponse = new gagvr::KeywordThemeConstant
            {
                ResourceNameAsKeywordThemeConstantName = gagvr::KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetKeywordThemeConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordThemeConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordThemeConstant responseCallSettings = await client.GetKeywordThemeConstantAsync(request.ResourceNameAsKeywordThemeConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordThemeConstant responseCancellationToken = await client.GetKeywordThemeConstantAsync(request.ResourceNameAsKeywordThemeConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void SuggestKeywordThemeConstantsRequestObject()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestKeywordThemeConstantsRequest request = new SuggestKeywordThemeConstantsRequest
            {
                QueryText = "query_text3b0c4d80",
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
            };
            SuggestKeywordThemeConstantsResponse expectedResponse = new SuggestKeywordThemeConstantsResponse
            {
                KeywordThemeConstants =
                {
                    new gagvr::KeywordThemeConstant(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestKeywordThemeConstants(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestKeywordThemeConstantsResponse response = client.SuggestKeywordThemeConstants(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task SuggestKeywordThemeConstantsRequestObjectAsync()
        {
            moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient> mockGrpcClient = new moq::Mock<KeywordThemeConstantService.KeywordThemeConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestKeywordThemeConstantsRequest request = new SuggestKeywordThemeConstantsRequest
            {
                QueryText = "query_text3b0c4d80",
                CountryCode = "country_code8debec55",
                LanguageCode = "language_code2f6c7160",
            };
            SuggestKeywordThemeConstantsResponse expectedResponse = new SuggestKeywordThemeConstantsResponse
            {
                KeywordThemeConstants =
                {
                    new gagvr::KeywordThemeConstant(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestKeywordThemeConstantsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestKeywordThemeConstantsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordThemeConstantServiceClient client = new KeywordThemeConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestKeywordThemeConstantsResponse responseCallSettings = await client.SuggestKeywordThemeConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            SuggestKeywordThemeConstantsResponse responseCancellationToken = await client.SuggestKeywordThemeConstantsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
