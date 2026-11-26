#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IClientScopesClient
    {
        /// <summary>
        /// Get representation of the client scope
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientScopeRepresentation> GetAdminRealmsByRealmClientTemplatesByClientScopeIdAsync(
            string realm,
            string clientScopeId,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get representation of the client scope
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientScopeRepresentation>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdAsResponseAsync(
            string realm,
            string clientScopeId,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}