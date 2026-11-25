#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.UPConfig> PutAdminRealmsByRealmUsersProfileAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.UPConfig request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.UPConfig>> PutAdminRealmsByRealmUsersProfileAsResponseAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.UPConfig request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the configuration for the user profile
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="attributes"></param>
        /// <param name="groups"></param>
        /// <param name="unmanagedAttributePolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.UPConfig> PutAdminRealmsByRealmUsersProfileAsync(
            string realm,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPAttribute>? attributes = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.UPGroup>? groups = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.UnmanagedAttributePolicy? unmanagedAttributePolicy = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}