#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmIdentityProviderInstancesByAliasManagementPermissionsAsync(
            string realm,
            string alias,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference>> PutAdminRealmsByRealmIdentityProviderInstancesByAliasManagementPermissionsAsResponseAsync(
            string realm,
            string alias,

            global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Return object stating whether client Authorization permissions have been initialized or not and a reference
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="enabled"></param>
        /// <param name="resource"></param>
        /// <param name="scopePermissions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.ManagementPermissionReference> PutAdminRealmsByRealmIdentityProviderInstancesByAliasManagementPermissionsAsync(
            string realm,
            string alias,
            bool? enabled = default,
            string? resource = default,
            global::System.Collections.Generic.Dictionary<string, string>? scopePermissions = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}