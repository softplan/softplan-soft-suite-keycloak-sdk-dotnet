#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Update a role by name
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmRolesByRoleNameAsync(
            string roleName,
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a role by name
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> PutAdminRealmsByRealmRolesByRoleNameAsResponseAsync(
            string roleName,
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.RoleRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a role by name
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="composite"></param>
        /// <param name="composites"></param>
        /// <param name="clientRole"></param>
        /// <param name="containerId"></param>
        /// <param name="attributes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminRealmsByRealmRolesByRoleNameAsync(
            string roleName,
            string realm,
            string? id = default,
            string? name = default,
            string? description = default,
            bool? composite = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.Composites? composites = default,
            bool? clientRole = default,
            string? containerId = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? attributes = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}