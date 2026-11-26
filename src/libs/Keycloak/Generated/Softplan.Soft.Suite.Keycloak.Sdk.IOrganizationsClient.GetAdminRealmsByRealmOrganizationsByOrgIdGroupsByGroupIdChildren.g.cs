#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get subgroups of this organization group<br/>
        /// Returns a paginated stream of subgroups that belong to this organization group
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.GroupRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdChildrenAsync(
            string realm,
            string orgId,
            string groupId,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subgroups of this organization group<br/>
        /// Returns a paginated stream of subgroups that belong to this organization group
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="subGroupsCount"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.GroupRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdGroupsByGroupIdChildrenAsResponseAsync(
            string realm,
            string orgId,
            string groupId,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? search = default,
            bool? subGroupsCount = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}