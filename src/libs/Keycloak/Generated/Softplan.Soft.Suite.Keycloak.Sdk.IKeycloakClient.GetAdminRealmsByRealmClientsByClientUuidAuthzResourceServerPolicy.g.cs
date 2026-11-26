#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="permission"></param>
        /// <param name="policyId"></param>
        /// <param name="resource"></param>
        /// <param name="resourceType"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.AbstractPolicyRepresentation>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPolicyAsync(
            string realm,
            string clientUuid,
            string? fields = default,
            int? first = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            bool? permission = default,
            string? policyId = default,
            string? resource = default,
            string? resourceType = default,
            string? scope = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="first"></param>
        /// <param name="max">
        /// Default Value: 100
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="permission"></param>
        /// <param name="policyId"></param>
        /// <param name="resource"></param>
        /// <param name="resourceType"></param>
        /// <param name="scope"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.AbstractPolicyRepresentation>>> GetAdminRealmsByRealmClientsByClientUuidAuthzResourceServerPolicyAsResponseAsync(
            string realm,
            string clientUuid,
            string? fields = default,
            int? first = default,
            int? max = default,
            string? name = default,
            string? owner = default,
            bool? permission = default,
            string? policyId = default,
            string? resource = default,
            string? resourceType = default,
            string? scope = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}