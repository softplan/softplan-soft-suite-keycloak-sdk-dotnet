#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IProtocolMappersClient
    {
        /// <summary>
        /// Create a mapper
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsAsync(
            string realm,
            string clientScopeId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ProtocolMapperRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a mapper
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsAsResponseAsync(
            string realm,
            string clientScopeId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ProtocolMapperRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a mapper
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="protocol"></param>
        /// <param name="protocolMapper"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientTemplatesByClientScopeIdProtocolMappersModelsAsync(
            string realm,
            string clientScopeId,
            string? id = default,
            string? name = default,
            string? protocol = default,
            string? protocolMapper = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}