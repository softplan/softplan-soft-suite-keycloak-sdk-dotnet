#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Updates the membership type of the member with the specified id
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdMembershipTypeAsync(
            string memberId,
            string realm,
            string orgId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.MembershipType request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the membership type of the member with the specified id
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmOrganizationsByOrgIdMembersByMemberIdMembershipTypeAsResponseAsync(
            string memberId,
            string realm,
            string orgId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.MembershipType request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}