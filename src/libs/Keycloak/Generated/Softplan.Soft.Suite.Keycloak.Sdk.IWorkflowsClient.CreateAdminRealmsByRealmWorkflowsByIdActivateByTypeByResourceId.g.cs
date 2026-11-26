#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Activate workflow for resource<br/>
        /// Activate the workflow for the given resource type and identifier. Optionally schedule the first step using the notBefore parameter.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="type"></param>
        /// <param name="notBefore"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmWorkflowsByIdActivateByTypeByResourceIdAsync(
            string resourceId,
            object type,
            string realm,
            string id,
            string? notBefore = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Activate workflow for resource<br/>
        /// Activate the workflow for the given resource type and identifier. Optionally schedule the first step using the notBefore parameter.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="type"></param>
        /// <param name="notBefore"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmWorkflowsByIdActivateByTypeByResourceIdAsResponseAsync(
            string resourceId,
            object type,
            string realm,
            string id,
            string? notBefore = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}