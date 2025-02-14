// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// This class contains the minimal job details required to navigate to the
    /// desired drill down.
    /// </summary>
    public partial class JobEntity
    {
        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>
        public JobEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobEntity class.
        /// </summary>

        /// <param name="jobId">The job id.
        /// </param>

        /// <param name="jobFriendlyName">The job display name.
        /// </param>

        /// <param name="targetObjectId">The object id.
        /// </param>

        /// <param name="targetObjectName">The object name.
        /// </param>

        /// <param name="targetInstanceType">The workflow affected object type.
        /// </param>

        /// <param name="jobScenarioName">The job name. Enum type ScenarioName.
        /// </param>
        public JobEntity(string jobId = default(string), string jobFriendlyName = default(string), string targetObjectId = default(string), string targetObjectName = default(string), string targetInstanceType = default(string), string jobScenarioName = default(string))

        {
            this.JobId = jobId;
            this.JobFriendlyName = jobFriendlyName;
            this.TargetObjectId = targetObjectId;
            this.TargetObjectName = targetObjectName;
            this.TargetInstanceType = targetInstanceType;
            this.JobScenarioName = jobScenarioName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the job id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobId")]
        public string JobId {get; set; }

        /// <summary>
        /// Gets or sets the job display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobFriendlyName")]
        public string JobFriendlyName {get; set; }

        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetObjectId")]
        public string TargetObjectId {get; set; }

        /// <summary>
        /// Gets or sets the object name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetObjectName")]
        public string TargetObjectName {get; set; }

        /// <summary>
        /// Gets or sets the workflow affected object type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetInstanceType")]
        public string TargetInstanceType {get; set; }

        /// <summary>
        /// Gets or sets the job name. Enum type ScenarioName.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobScenarioName")]
        public string JobScenarioName {get; set; }
    }
}