#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IClientRoleMappingsClient
    {
        /// <summary>
        /// Add client-level roles to the user or group role mapping
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmUsersByUserIdRoleMappingsClientsByClientIdAsync(
            string realm,
            string userId,
            string clientId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add client-level roles to the user or group role mapping
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmUsersByUserIdRoleMappingsClientsByClientIdAsResponseAsync(
            string realm,
            string userId,
            string clientId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}