#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow<br/>
        /// Get the workflow representation. Optionally exclude the workflow id from the response.
        /// </summary>
        /// <param name="includeId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation> GetAdminRealmsByRealmWorkflowsByIdAsync(
            string realm,
            string id,
            bool? includeId = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workflow<br/>
        /// Get the workflow representation. Optionally exclude the workflow id from the response.
        /// </summary>
        /// <param name="includeId"></param>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation>> GetAdminRealmsByRealmWorkflowsByIdAsResponseAsync(
            string realm,
            string id,
            bool? includeId = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}