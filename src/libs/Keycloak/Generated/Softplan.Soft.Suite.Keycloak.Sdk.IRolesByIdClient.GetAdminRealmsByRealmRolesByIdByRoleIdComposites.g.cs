#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IRolesByIdClient
    {
        /// <summary>
        /// Get role's children Returns a set of role's children provided the role is a composite.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation>> GetAdminRealmsByRealmRolesByIdByRoleIdCompositesAsync(
            string roleId,
            string realm,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get role's children Returns a set of role's children provided the role is a composite.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation>>> GetAdminRealmsByRealmRolesByIdByRoleIdCompositesAsResponseAsync(
            string roleId,
            string realm,
            int? first = default,
            int? max = default,
            string? search = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}