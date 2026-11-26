#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set up a new password for the user.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmUsersByUserIdResetPasswordAsync(
            string realm,
            string userId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.CredentialRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set up a new password for the user.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmUsersByUserIdResetPasswordAsResponseAsync(
            string realm,
            string userId,

            global::Softplan.Soft.Suite.Keycloak.Sdk.CredentialRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set up a new password for the user.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="userLabel"></param>
        /// <param name="createdDate"></param>
        /// <param name="secretData"></param>
        /// <param name="credentialData"></param>
        /// <param name="priority"></param>
        /// <param name="value"></param>
        /// <param name="temporary"></param>
        /// <param name="federationLink"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmUsersByUserIdResetPasswordAsync(
            string realm,
            string userId,
            string? id = default,
            string? type = default,
            string? userLabel = default,
            long? createdDate = default,
            string? secretData = default,
            string? credentialData = default,
            int? priority = default,
            string? value = default,
            bool? temporary = default,
            string? federationLink = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}