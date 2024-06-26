// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for GovernanceAssignmentsOperations
    /// </summary>
    public static partial class GovernanceAssignmentsOperationsExtensions
    {
        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        public static Microsoft.Rest.Azure.IPage<GovernanceAssignment> List(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName)
        {
                return ((IGovernanceAssignmentsOperations)operations).ListAsync(scope, assessmentName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<GovernanceAssignment>> ListAsync(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(scope, assessmentName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        public static GovernanceAssignment Get(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey)
        {
                return ((IGovernanceAssignmentsOperations)operations).GetAsync(scope, assessmentName, assignmentKey).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a specific governanceAssignment for the requested scope by AssignmentKey
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<GovernanceAssignment> GetAsync(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(scope, assessmentName, assignmentKey, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates a governance assignment on the given subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        public static GovernanceAssignment CreateOrUpdate(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey, GovernanceAssignment governanceAssignment)
        {
                return ((IGovernanceAssignmentsOperations)operations).CreateOrUpdateAsync(scope, assessmentName, assignmentKey, governanceAssignment).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a governance assignment on the given subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<GovernanceAssignment> CreateOrUpdateAsync(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey, GovernanceAssignment governanceAssignment, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, assessmentName, assignmentKey, governanceAssignment, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a GovernanceAssignment over a given scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        public static void Delete(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey)
        {
                ((IGovernanceAssignmentsOperations)operations).DeleteAsync(scope, assessmentName, assignmentKey).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a GovernanceAssignment over a given scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='scope'>
        /// The scope of the Governance assignments. Valid scopes are: subscription (format: &#39;subscriptions/{subscriptionId}&#39;), or security connector (format: &#39;subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName})&#39;
        /// </param>
        /// <param name='assessmentName'>
        /// The Assessment Key - A unique key for the assessment type
        /// </param>
        /// <param name='assignmentKey'>
        /// The governance assignment key - the assessment key of the required governance assignment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IGovernanceAssignmentsOperations operations, string scope, string assessmentName, string assignmentKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(scope, assessmentName, assignmentKey, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<GovernanceAssignment> ListNext(this IGovernanceAssignmentsOperations operations, string nextPageLink)
        {
                return ((IGovernanceAssignmentsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get governance assignments on all of your resources inside a scope
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<GovernanceAssignment>> ListNextAsync(this IGovernanceAssignmentsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
