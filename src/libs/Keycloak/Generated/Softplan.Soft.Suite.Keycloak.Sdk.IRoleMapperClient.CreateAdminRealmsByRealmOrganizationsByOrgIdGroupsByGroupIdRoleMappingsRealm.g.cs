#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IRoleMapperClient
    {
        /// <summary>
        /// Add realm-level role mappings to the user
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsRealmAsync(
            string realm,
            string orgId,
            string groupId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add realm-level role mappings to the user
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdRoleMappingsRealmAsResponseAsync(
            string realm,
            string orgId,
            string groupId,

            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation> request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}