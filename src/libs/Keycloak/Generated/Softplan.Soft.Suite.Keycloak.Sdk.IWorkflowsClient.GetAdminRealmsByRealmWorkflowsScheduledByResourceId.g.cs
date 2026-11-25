#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List scheduled workflows for resource<br/>
        /// Return workflows that have scheduled steps for the given resource identifier.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation> GetAdminRealmsByRealmWorkflowsScheduledByResourceIdAsync(
            string resourceId,
            string realm,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List scheduled workflows for resource<br/>
        /// Return workflows that have scheduled steps for the given resource identifier.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation>> GetAdminRealmsByRealmWorkflowsScheduledByResourceIdAsResponseAsync(
            string resourceId,
            string realm,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}