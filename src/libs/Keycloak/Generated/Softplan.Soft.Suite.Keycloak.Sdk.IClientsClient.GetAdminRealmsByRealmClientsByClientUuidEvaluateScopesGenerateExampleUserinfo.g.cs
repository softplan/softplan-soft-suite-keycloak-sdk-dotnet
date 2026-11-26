#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IClientsClient
    {
        /// <summary>
        /// Create JSON with payload of example user info
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesGenerateExampleUserinfoAsync(
            string realm,
            string clientUuid,
            string? scope = default,
            string? userId = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create JSON with payload of example user info
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="userId"></param>
        /// <param name="realm"></param>
        /// <param name="clientUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<string>> GetAdminRealmsByRealmClientsByClientUuidEvaluateScopesGenerateExampleUserinfoAsResponseAsync(
            string realm,
            string clientUuid,
            string? scope = default,
            string? userId = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}