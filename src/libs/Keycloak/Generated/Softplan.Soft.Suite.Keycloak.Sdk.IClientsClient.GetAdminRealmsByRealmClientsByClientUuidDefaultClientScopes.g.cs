#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Get default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientScopeRepresentation>> GetAdminRealmsByRealmClientsByClientUuidDefaultClientScopesAsync(
            string realm,
            string clientUuid,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get default client scopes.  Only name and ids are returned.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientScopeRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidDefaultClientScopesAsResponseAsync(
            string realm,
            string clientUuid,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}