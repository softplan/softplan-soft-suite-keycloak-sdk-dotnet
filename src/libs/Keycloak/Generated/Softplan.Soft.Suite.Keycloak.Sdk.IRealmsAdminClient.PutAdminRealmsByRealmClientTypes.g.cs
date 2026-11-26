#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        /// Update a client type<br/>
        /// This endpoint allows you to update a realm level client type
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientTypesAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ClientTypesRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a client type<br/>
        /// This endpoint allows you to update a realm level client type
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmClientTypesAsResponseAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ClientTypesRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a client type<br/>
        /// This endpoint allows you to update a realm level client type
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="clientTypes"></param>
        /// <param name="globalClientTypes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmClientTypesAsync(
            string realm,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientTypeRepresentation>? clientTypes = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ClientTypeRepresentation>? globalClientTypes = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}