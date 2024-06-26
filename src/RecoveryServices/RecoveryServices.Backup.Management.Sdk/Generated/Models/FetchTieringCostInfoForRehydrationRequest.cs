// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for fetching cost info of rehydration
    /// </summary>
    [Newtonsoft.Json.JsonObject("FetchTieringCostInfoForRehydrationRequest")]
    public partial class FetchTieringCostInfoForRehydrationRequest : FetchTieringCostInfoRequest
    {
        /// <summary>
        /// Initializes a new instance of the FetchTieringCostInfoForRehydrationRequest class.
        /// </summary>
        public FetchTieringCostInfoForRehydrationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FetchTieringCostInfoForRehydrationRequest class.
        /// </summary>

        /// <param name="sourceTierType">Source tier for the request
        /// Possible values include: &#39;Invalid&#39;, &#39;InstantRP&#39;, &#39;HardenedRP&#39;, &#39;ArchivedRP&#39;</param>

        /// <param name="targetTierType">target tier for the request
        /// Possible values include: &#39;Invalid&#39;, &#39;InstantRP&#39;, &#39;HardenedRP&#39;, &#39;ArchivedRP&#39;</param>

        /// <param name="containerName">Name of the protected item container
        /// </param>

        /// <param name="protectedItemName">Name of the protectedItemName
        /// </param>

        /// <param name="recoveryPointId">ID of the backup copy for rehydration cost info needs to be fetched.
        /// </param>

        /// <param name="rehydrationPriority">Rehydration Priority
        /// Possible values include: &#39;Standard&#39;, &#39;High&#39;</param>
        public FetchTieringCostInfoForRehydrationRequest(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string containerName, string protectedItemName, string recoveryPointId, string rehydrationPriority)

        : base(sourceTierType, targetTierType)
        {
            this.ContainerName = containerName;
            this.ProtectedItemName = protectedItemName;
            this.RecoveryPointId = recoveryPointId;
            this.RehydrationPriority = rehydrationPriority;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the protected item container
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "containerName")]
        public string ContainerName {get; set; }

        /// <summary>
        /// Gets or sets name of the protectedItemName
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedItemName")]
        public string ProtectedItemName {get; set; }

        /// <summary>
        /// Gets or sets iD of the backup copy for rehydration cost info needs to be
        /// fetched.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId {get; set; }

        /// <summary>
        /// Gets or sets rehydration Priority Possible values include: &#39;Standard&#39;, &#39;High&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rehydrationPriority")]
        public string RehydrationPriority {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.ContainerName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ContainerName");
            }
            if (this.ProtectedItemName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ProtectedItemName");
            }
            if (this.RecoveryPointId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RecoveryPointId");
            }
            if (this.RehydrationPriority == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "RehydrationPriority");
            }




        }
    }
}