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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="BiddingStrategySimulationServiceClient"/> instances.</summary>
    public sealed partial class BiddingStrategySimulationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BiddingStrategySimulationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BiddingStrategySimulationServiceSettings"/>.</returns>
        public static BiddingStrategySimulationServiceSettings GetDefault() => new BiddingStrategySimulationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingStrategySimulationServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingStrategySimulationServiceSettings()
        {
        }

        private BiddingStrategySimulationServiceSettings(BiddingStrategySimulationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBiddingStrategySimulationSettings = existing.GetBiddingStrategySimulationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingStrategySimulationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategySimulationServiceClient.GetBiddingStrategySimulation</c> and
        /// <c>BiddingStrategySimulationServiceClient.GetBiddingStrategySimulationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBiddingStrategySimulationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BiddingStrategySimulationServiceSettings"/> object.</returns>
        public BiddingStrategySimulationServiceSettings Clone() => new BiddingStrategySimulationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BiddingStrategySimulationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class BiddingStrategySimulationServiceClientBuilder : gaxgrpc::ClientBuilderBase<BiddingStrategySimulationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BiddingStrategySimulationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BiddingStrategySimulationServiceClientBuilder()
        {
            UseJwtAccessWithScopes = BiddingStrategySimulationServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BiddingStrategySimulationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BiddingStrategySimulationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BiddingStrategySimulationServiceClient Build()
        {
            BiddingStrategySimulationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BiddingStrategySimulationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BiddingStrategySimulationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BiddingStrategySimulationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BiddingStrategySimulationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BiddingStrategySimulationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BiddingStrategySimulationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BiddingStrategySimulationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            BiddingStrategySimulationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BiddingStrategySimulationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BiddingStrategySimulationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch bidding strategy simulations.
    /// </remarks>
    public abstract partial class BiddingStrategySimulationServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingStrategySimulationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BiddingStrategySimulationService scopes.</summary>
        /// <remarks>
        /// The default BiddingStrategySimulationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingStrategySimulationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategySimulationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BiddingStrategySimulationServiceClient"/>.</returns>
        public static stt::Task<BiddingStrategySimulationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BiddingStrategySimulationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BiddingStrategySimulationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategySimulationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BiddingStrategySimulationServiceClient"/>.</returns>
        public static BiddingStrategySimulationServiceClient Create() =>
            new BiddingStrategySimulationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BiddingStrategySimulationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BiddingStrategySimulationServiceSettings"/>.</param>
        /// <returns>The created <see cref="BiddingStrategySimulationServiceClient"/>.</returns>
        internal static BiddingStrategySimulationServiceClient Create(grpccore::CallInvoker callInvoker, BiddingStrategySimulationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingStrategySimulationService.BiddingStrategySimulationServiceClient grpcClient = new BiddingStrategySimulationService.BiddingStrategySimulationServiceClient(callInvoker);
            return new BiddingStrategySimulationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC BiddingStrategySimulationService client</summary>
        public virtual BiddingStrategySimulationService.BiddingStrategySimulationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategySimulation GetBiddingStrategySimulation(GetBiddingStrategySimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(GetBiddingStrategySimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(GetBiddingStrategySimulationRequest request, st::CancellationToken cancellationToken) =>
            GetBiddingStrategySimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategySimulation GetBiddingStrategySimulation(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategySimulation(new GetBiddingStrategySimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategySimulationAsync(new GetBiddingStrategySimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetBiddingStrategySimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategySimulation GetBiddingStrategySimulation(gagvr::BiddingStrategySimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategySimulation(new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(gagvr::BiddingStrategySimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategySimulationAsync(new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(gagvr::BiddingStrategySimulationName resourceName, st::CancellationToken cancellationToken) =>
            GetBiddingStrategySimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BiddingStrategySimulationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch bidding strategy simulations.
    /// </remarks>
    public sealed partial class BiddingStrategySimulationServiceClientImpl : BiddingStrategySimulationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBiddingStrategySimulationRequest, gagvr::BiddingStrategySimulation> _callGetBiddingStrategySimulation;

        /// <summary>
        /// Constructs a client wrapper for the BiddingStrategySimulationService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BiddingStrategySimulationServiceSettings"/> used within this client.
        /// </param>
        public BiddingStrategySimulationServiceClientImpl(BiddingStrategySimulationService.BiddingStrategySimulationServiceClient grpcClient, BiddingStrategySimulationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            BiddingStrategySimulationServiceSettings effectiveSettings = settings ?? BiddingStrategySimulationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetBiddingStrategySimulation = clientHelper.BuildApiCall<GetBiddingStrategySimulationRequest, gagvr::BiddingStrategySimulation>(grpcClient.GetBiddingStrategySimulationAsync, grpcClient.GetBiddingStrategySimulation, effectiveSettings.GetBiddingStrategySimulationSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetBiddingStrategySimulation);
            Modify_GetBiddingStrategySimulationApiCall(ref _callGetBiddingStrategySimulation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBiddingStrategySimulationApiCall(ref gaxgrpc::ApiCall<GetBiddingStrategySimulationRequest, gagvr::BiddingStrategySimulation> call);

        partial void OnConstruction(BiddingStrategySimulationService.BiddingStrategySimulationServiceClient grpcClient, BiddingStrategySimulationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BiddingStrategySimulationService client</summary>
        public override BiddingStrategySimulationService.BiddingStrategySimulationServiceClient GrpcClient { get; }

        partial void Modify_GetBiddingStrategySimulationRequest(ref GetBiddingStrategySimulationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::BiddingStrategySimulation GetBiddingStrategySimulation(GetBiddingStrategySimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategySimulationRequest(ref request, ref callSettings);
            return _callGetBiddingStrategySimulation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested bidding strategy simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::BiddingStrategySimulation> GetBiddingStrategySimulationAsync(GetBiddingStrategySimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategySimulationRequest(ref request, ref callSettings);
            return _callGetBiddingStrategySimulation.Async(request, callSettings);
        }
    }
}
