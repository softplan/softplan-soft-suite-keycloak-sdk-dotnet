#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmWorkflowsAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKHttpResponse> CreateAdminRealmsByRealmWorkflowsAsResponseAsync(
            string realm,

            global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowRepresentation request,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow from the provided representation.
        /// </summary>
        /// <param name="realm"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="on"></param>
        /// <param name="schedule"></param>
        /// <param name="concurrency"></param>
        /// <param name="if"></param>
        /// <param name="steps"></param>
        /// <param name="state"></param>
        /// <param name="with"></param>
        /// <param name="cancelInProgress"></param>
        /// <param name="restartInProgress"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminRealmsByRealmWorkflowsAsync(
            string realm,
            string? id = default,
            string? name = default,
            bool? enabled = default,
            string? on = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowScheduleRepresentation? schedule = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowConcurrencyRepresentation? concurrency = default,
            string? @if = default,
            global::System.Collections.Generic.IList<global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowStepRepresentation>? steps = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.WorkflowStateRepresentation? state = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? with = default,
            string? cancelInProgress = default,
            string? restartInProgress = default,
            global::Softplan.Soft.Suite.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}