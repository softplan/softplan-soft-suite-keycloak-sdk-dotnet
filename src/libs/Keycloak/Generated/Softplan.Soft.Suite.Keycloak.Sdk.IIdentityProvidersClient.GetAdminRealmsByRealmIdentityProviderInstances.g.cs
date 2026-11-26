#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// List identity providers
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="capability"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="realmOnly"></param>
        /// <param name="search"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.IdentityProviderRepresentation>> GetAdminRealmsByRealmIdentityProviderInstancesAsync(
            string realm,
            bool? briefRepresentation = default,
            string? capability = default,
            int? first = default,
            int? max = default,
            bool? realmOnly = default,
            string? search = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List identity providers
        /// </summary>
        /// <param name="briefRepresentation"></param>
        /// <param name="capability"></param>
        /// <param name="first"></param>
        /// <param name="max"></param>
        /// <param name="realmOnly"></param>
        /// <param name="search"></param>
        /// <param name="type"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.IdentityProviderRepresentation>>> GetAdminRealmsByRealmIdentityProviderInstancesAsResponseAsync(
            string realm,
            bool? briefRepresentation = default,
            string? capability = default,
            int? first = default,
            int? max = default,
            bool? realmOnly = default,
            string? search = default,
            string? type = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}