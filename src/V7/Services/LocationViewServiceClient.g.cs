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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
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

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="LocationViewServiceClient"/> instances.</summary>
    public sealed partial class LocationViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LocationViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LocationViewServiceSettings"/>.</returns>
        public static LocationViewServiceSettings GetDefault() => new LocationViewServiceSettings();

        /// <summary>Constructs a new <see cref="LocationViewServiceSettings"/> object with default settings.</summary>
        public LocationViewServiceSettings()
        {
        }

        private LocationViewServiceSettings(LocationViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLocationViewSettings = existing.GetLocationViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LocationViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocationViewServiceClient.GetLocationView</c> and <c>LocationViewServiceClient.GetLocationViewAsync</c>.
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
        public gaxgrpc::CallSettings GetLocationViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LocationViewServiceSettings"/> object.</returns>
        public LocationViewServiceSettings Clone() => new LocationViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LocationViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class LocationViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<LocationViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LocationViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LocationViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = LocationViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref LocationViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LocationViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LocationViewServiceClient Build()
        {
            LocationViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LocationViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LocationViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LocationViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LocationViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LocationViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LocationViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LocationViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LocationViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LocationViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LocationViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch location views.
    /// </remarks>
    public abstract partial class LocationViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the LocationViewService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LocationViewService scopes.</summary>
        /// <remarks>
        /// The default LocationViewService scopes are:
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
        /// Asynchronously creates a <see cref="LocationViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="LocationViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LocationViewServiceClient"/>.</returns>
        public static stt::Task<LocationViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LocationViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LocationViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="LocationViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LocationViewServiceClient"/>.</returns>
        public static LocationViewServiceClient Create() => new LocationViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LocationViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LocationViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="LocationViewServiceClient"/>.</returns>
        internal static LocationViewServiceClient Create(grpccore::CallInvoker callInvoker, LocationViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LocationViewService.LocationViewServiceClient grpcClient = new LocationViewService.LocationViewServiceClient(callInvoker);
            return new LocationViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LocationViewService client</summary>
        public virtual LocationViewService.LocationViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LocationView GetLocationView(GetLocationViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(GetLocationViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(GetLocationViewRequest request, st::CancellationToken cancellationToken) =>
            GetLocationViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LocationView GetLocationView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLocationView(new GetLocationViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLocationViewAsync(new GetLocationViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetLocationViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LocationView GetLocationView(gagvr::LocationViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLocationView(new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(gagvr::LocationViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLocationViewAsync(new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the location view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LocationView> GetLocationViewAsync(gagvr::LocationViewName resourceName, st::CancellationToken cancellationToken) =>
            GetLocationViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LocationViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch location views.
    /// </remarks>
    public sealed partial class LocationViewServiceClientImpl : LocationViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLocationViewRequest, gagvr::LocationView> _callGetLocationView;

        /// <summary>
        /// Constructs a client wrapper for the LocationViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LocationViewServiceSettings"/> used within this client.</param>
        public LocationViewServiceClientImpl(LocationViewService.LocationViewServiceClient grpcClient, LocationViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LocationViewServiceSettings effectiveSettings = settings ?? LocationViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetLocationView = clientHelper.BuildApiCall<GetLocationViewRequest, gagvr::LocationView>(grpcClient.GetLocationViewAsync, grpcClient.GetLocationView, effectiveSettings.GetLocationViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetLocationView);
            Modify_GetLocationViewApiCall(ref _callGetLocationView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLocationViewApiCall(ref gaxgrpc::ApiCall<GetLocationViewRequest, gagvr::LocationView> call);

        partial void OnConstruction(LocationViewService.LocationViewServiceClient grpcClient, LocationViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LocationViewService client</summary>
        public override LocationViewService.LocationViewServiceClient GrpcClient { get; }

        partial void Modify_GetLocationViewRequest(ref GetLocationViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::LocationView GetLocationView(GetLocationViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLocationViewRequest(ref request, ref callSettings);
            return _callGetLocationView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested location view in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::LocationView> GetLocationViewAsync(GetLocationViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLocationViewRequest(ref request, ref callSettings);
            return _callGetLocationView.Async(request, callSettings);
        }
    }
}
