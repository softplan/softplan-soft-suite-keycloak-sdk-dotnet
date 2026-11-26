#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IRealmsAdminClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmUsersManagementPermissionsAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference>> PutAdminRealmsByRealmUsersManagementPermissionsAsResponseAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="enabled"></param>
        /// <param name="resource"></param>
        /// <param name="scopePermissions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmUsersManagementPermissionsAsync(
            string realm,
            bool? enabled = default,
            string? resource = default,
            global::System.Collections.Generic.Dictionary<string, string>? scopePermissions = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}