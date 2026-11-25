#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IIdentityProvidersClient
    {
        /// <summary>
        /// Add a mapper to identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmIdentityProviderInstancesByAliasMappersAsync(
            string realm,
            string alias,

            global::Softplan.Soft.Suite.Keycloak.Sdk.IdentityProviderMapperRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a mapper to identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmIdentityProviderInstancesByAliasMappersAsResponseAsync(
            string realm,
            string alias,

            global::Softplan.Soft.Suite.Keycloak.Sdk.IdentityProviderMapperRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a mapper to identity provider
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="alias"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="identityProviderAlias"></param>
        /// <param name="identityProviderMapper"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmIdentityProviderInstancesByAliasMappersAsync(
            string realm,
            string alias,
            string? id = default,
            string? name = default,
            string? identityProviderAlias = default,
            string? identityProviderMapper = default,
            global::System.Collections.Generic.Dictionary<string, string>? config = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}