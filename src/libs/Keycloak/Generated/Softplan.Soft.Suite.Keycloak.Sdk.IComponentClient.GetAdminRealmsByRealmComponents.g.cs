#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IComponentClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        /// <param name="providerId"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ComponentRepresentation>> GetAdminRealmsByRealmComponentsAsync(
            string realm,
            string? name = default,
            string? parent = default,
            string? providerId = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        /// <param name="providerId"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.ComponentRepresentation>>> GetAdminRealmsByRealmComponentsAsResponseAsync(
            string realm,
            string? name = default,
            string? parent = default,
            string? providerId = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}