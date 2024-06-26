// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a job credential.
    /// </summary>
    public partial class JobCredentialProperties
    {
        /// <summary>
        /// Initializes a new instance of the JobCredentialProperties class.
        /// </summary>
        public JobCredentialProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobCredentialProperties class.
        /// </summary>

        /// <param name="username">The credential user name.
        /// </param>

        /// <param name="password">The credential password.
        /// </param>
        public JobCredentialProperties(string username, string password)

        {
            this.Username = username;
            this.Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the credential user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "username")]
        public string Username {get; set; }

        /// <summary>
        /// Gets or sets the credential password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Username == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Username");
            }
            if (this.Password == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Password");
            }


        }
    }
}