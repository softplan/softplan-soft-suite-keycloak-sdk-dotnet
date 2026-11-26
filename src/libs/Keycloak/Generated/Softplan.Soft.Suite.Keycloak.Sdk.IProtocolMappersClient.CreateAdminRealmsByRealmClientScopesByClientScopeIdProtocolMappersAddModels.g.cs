#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IProtocolMappersClient
    {
        /// <summary>
        /// Create multiple mappers
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmClientScopesByClientScopeIdProtocolMappersAddModelsAsync(
            string realm,
            string clientScopeId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ProtocolMapperRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create multiple mappers
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmClientScopesByClientScopeIdProtocolMappersAddModelsAsResponseAsync(
            string realm,
            string clientScopeId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ProtocolMapperRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}