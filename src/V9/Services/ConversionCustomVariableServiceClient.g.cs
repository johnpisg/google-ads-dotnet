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
    /// <summary>Settings for <see cref="ConversionCustomVariableServiceClient"/> instances.</summary>
    public sealed partial class ConversionCustomVariableServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionCustomVariableServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionCustomVariableServiceSettings"/>.</returns>
        public static ConversionCustomVariableServiceSettings GetDefault() => new ConversionCustomVariableServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionCustomVariableServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionCustomVariableServiceSettings()
        {
        }

        private ConversionCustomVariableServiceSettings(ConversionCustomVariableServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConversionCustomVariableSettings = existing.GetConversionCustomVariableSettings;
            MutateConversionCustomVariablesSettings = existing.MutateConversionCustomVariablesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionCustomVariableServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionCustomVariableServiceClient.GetConversionCustomVariable</c> and
        /// <c>ConversionCustomVariableServiceClient.GetConversionCustomVariableAsync</c>.
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
        public gaxgrpc::CallSettings GetConversionCustomVariableSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionCustomVariableServiceClient.MutateConversionCustomVariables</c> and
        /// <c>ConversionCustomVariableServiceClient.MutateConversionCustomVariablesAsync</c>.
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
        public gaxgrpc::CallSettings MutateConversionCustomVariablesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionCustomVariableServiceSettings"/> object.</returns>
        public ConversionCustomVariableServiceSettings Clone() => new ConversionCustomVariableServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionCustomVariableServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ConversionCustomVariableServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionCustomVariableServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionCustomVariableServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionCustomVariableServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ConversionCustomVariableServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ConversionCustomVariableServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionCustomVariableServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionCustomVariableServiceClient Build()
        {
            ConversionCustomVariableServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionCustomVariableServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionCustomVariableServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionCustomVariableServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionCustomVariableServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionCustomVariableServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionCustomVariableServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionCustomVariableServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ConversionCustomVariableServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionCustomVariableServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionCustomVariableService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion custom variables.
    /// </remarks>
    public abstract partial class ConversionCustomVariableServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionCustomVariableService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionCustomVariableService scopes.</summary>
        /// <remarks>
        /// The default ConversionCustomVariableService scopes are:
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
        /// Asynchronously creates a <see cref="ConversionCustomVariableServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionCustomVariableServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionCustomVariableServiceClient"/>.</returns>
        public static stt::Task<ConversionCustomVariableServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionCustomVariableServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionCustomVariableServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionCustomVariableServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionCustomVariableServiceClient"/>.</returns>
        public static ConversionCustomVariableServiceClient Create() =>
            new ConversionCustomVariableServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionCustomVariableServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionCustomVariableServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionCustomVariableServiceClient"/>.</returns>
        internal static ConversionCustomVariableServiceClient Create(grpccore::CallInvoker callInvoker, ConversionCustomVariableServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionCustomVariableService.ConversionCustomVariableServiceClient grpcClient = new ConversionCustomVariableService.ConversionCustomVariableServiceClient(callInvoker);
            return new ConversionCustomVariableServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionCustomVariableService client</summary>
        public virtual ConversionCustomVariableService.ConversionCustomVariableServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        public virtual gagvr::ConversionCustomVariable GetConversionCustomVariable(GetConversionCustomVariableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(GetConversionCustomVariableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(GetConversionCustomVariableRequest request, st::CancellationToken cancellationToken) =>
            GetConversionCustomVariableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionCustomVariable GetConversionCustomVariable(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionCustomVariable(new GetConversionCustomVariableRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionCustomVariableAsync(new GetConversionCustomVariableRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetConversionCustomVariableAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionCustomVariable GetConversionCustomVariable(gagvr::ConversionCustomVariableName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionCustomVariable(new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(gagvr::ConversionCustomVariableName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionCustomVariableAsync(new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        /// Required. The resource name of the conversion custom variable to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(gagvr::ConversionCustomVariableName resourceName, st::CancellationToken cancellationToken) =>
            GetConversionCustomVariableAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionCustomVariablesResponse MutateConversionCustomVariables(MutateConversionCustomVariablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionCustomVariablesResponse> MutateConversionCustomVariablesAsync(MutateConversionCustomVariablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionCustomVariablesResponse> MutateConversionCustomVariablesAsync(MutateConversionCustomVariablesRequest request, st::CancellationToken cancellationToken) =>
            MutateConversionCustomVariablesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion custom variables are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion custom
        /// variables.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionCustomVariablesResponse MutateConversionCustomVariables(string customerId, scg::IEnumerable<ConversionCustomVariableOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionCustomVariables(new MutateConversionCustomVariablesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion custom variables are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion custom
        /// variables.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionCustomVariablesResponse> MutateConversionCustomVariablesAsync(string customerId, scg::IEnumerable<ConversionCustomVariableOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionCustomVariablesAsync(new MutateConversionCustomVariablesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion custom variables are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion custom
        /// variables.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionCustomVariablesResponse> MutateConversionCustomVariablesAsync(string customerId, scg::IEnumerable<ConversionCustomVariableOperation> operations, st::CancellationToken cancellationToken) =>
            MutateConversionCustomVariablesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionCustomVariableService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion custom variables.
    /// </remarks>
    public sealed partial class ConversionCustomVariableServiceClientImpl : ConversionCustomVariableServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConversionCustomVariableRequest, gagvr::ConversionCustomVariable> _callGetConversionCustomVariable;

        private readonly gaxgrpc::ApiCall<MutateConversionCustomVariablesRequest, MutateConversionCustomVariablesResponse> _callMutateConversionCustomVariables;

        /// <summary>
        /// Constructs a client wrapper for the ConversionCustomVariableService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionCustomVariableServiceSettings"/> used within this client.
        /// </param>
        public ConversionCustomVariableServiceClientImpl(ConversionCustomVariableService.ConversionCustomVariableServiceClient grpcClient, ConversionCustomVariableServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionCustomVariableServiceSettings effectiveSettings = settings ?? ConversionCustomVariableServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetConversionCustomVariable = clientHelper.BuildApiCall<GetConversionCustomVariableRequest, gagvr::ConversionCustomVariable>(grpcClient.GetConversionCustomVariableAsync, grpcClient.GetConversionCustomVariable, effectiveSettings.GetConversionCustomVariableSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetConversionCustomVariable);
            Modify_GetConversionCustomVariableApiCall(ref _callGetConversionCustomVariable);
            _callMutateConversionCustomVariables = clientHelper.BuildApiCall<MutateConversionCustomVariablesRequest, MutateConversionCustomVariablesResponse>(grpcClient.MutateConversionCustomVariablesAsync, grpcClient.MutateConversionCustomVariables, effectiveSettings.MutateConversionCustomVariablesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateConversionCustomVariables);
            Modify_MutateConversionCustomVariablesApiCall(ref _callMutateConversionCustomVariables);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConversionCustomVariableApiCall(ref gaxgrpc::ApiCall<GetConversionCustomVariableRequest, gagvr::ConversionCustomVariable> call);

        partial void Modify_MutateConversionCustomVariablesApiCall(ref gaxgrpc::ApiCall<MutateConversionCustomVariablesRequest, MutateConversionCustomVariablesResponse> call);

        partial void OnConstruction(ConversionCustomVariableService.ConversionCustomVariableServiceClient grpcClient, ConversionCustomVariableServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionCustomVariableService client</summary>
        public override ConversionCustomVariableService.ConversionCustomVariableServiceClient GrpcClient { get; }

        partial void Modify_GetConversionCustomVariableRequest(ref GetConversionCustomVariableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateConversionCustomVariablesRequest(ref MutateConversionCustomVariablesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        public override gagvr::ConversionCustomVariable GetConversionCustomVariable(GetConversionCustomVariableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionCustomVariableRequest(ref request, ref callSettings);
            return _callGetConversionCustomVariable.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested conversion custom variable.
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
        public override stt::Task<gagvr::ConversionCustomVariable> GetConversionCustomVariableAsync(GetConversionCustomVariableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionCustomVariableRequest(ref request, ref callSettings);
            return _callGetConversionCustomVariable.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateConversionCustomVariablesResponse MutateConversionCustomVariables(MutateConversionCustomVariablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionCustomVariablesRequest(ref request, ref callSettings);
            return _callMutateConversionCustomVariables.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates conversion custom variables. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ConversionCustomVariableError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateConversionCustomVariablesResponse> MutateConversionCustomVariablesAsync(MutateConversionCustomVariablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionCustomVariablesRequest(ref request, ref callSettings);
            return _callMutateConversionCustomVariables.Async(request, callSettings);
        }
    }
}
