#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IScopeMappingsClient
    {
        /// <summary>
        /// Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.<br/>
        /// The method is really to show a comprehensive total view of realm-level roles associated with the client.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsRealmCompositeAsync(
            string realm,
            string clientScopeId,
            bool? briefRepresentation = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get effective realm-level roles associated with the client’s scope What this does is recurse any composite roles associated with the client’s scope and adds the roles to this lists.<br/>
        /// The method is really to show a comprehensive total view of realm-level roles associated with the client.
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="clientScopeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmClientTemplatesByClientScopeIdScopeMappingsRealmCompositeAsResponseAsync(
            string realm,
            string clientScopeId,
            bool? briefRepresentation = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}