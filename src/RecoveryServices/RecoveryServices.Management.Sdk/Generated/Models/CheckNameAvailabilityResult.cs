// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using System.Linq;

    /// <summary>
    /// Response for check name availability API. Resource provider will set
    /// availability as true | false.
    /// </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult class.
        /// </summary>
        public CheckNameAvailabilityResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult class.
        /// </summary>

        /// <param name="nameAvailable">
        /// </param>

        /// <param name="reason">
        /// </param>

        /// <param name="message">
        /// </param>
        public CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))

        {
            this.NameAvailable = nameAvailable;
            this.Reason = reason;
            this.Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reason")]
        public string Reason {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get; set; }
    }
}