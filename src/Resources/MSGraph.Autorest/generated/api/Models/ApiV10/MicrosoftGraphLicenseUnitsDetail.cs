// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>licenseUnitsDetail</summary>
    public partial class MicrosoftGraphLicenseUnitsDetail :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetail,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLicenseUnitsDetailInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private int? _enabled;

        /// <summary>
        /// The number of units that are enabled for the active subscription of the service SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Suspended" /> property.</summary>
        private int? _suspended;

        /// <summary>
        /// The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot
        /// be assigned but can still be reactivated before they are deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? Suspended { get => this._suspended; set => this._suspended = value; }

        /// <summary>Backing field for <see cref="Warning" /> property.</summary>
        private int? _warning;

        /// <summary>
        /// The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has
        /// a grace period to renew their subscription before it is cancelled (moved to a suspended state).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? Warning { get => this._warning; set => this._warning = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphLicenseUnitsDetail" /> instance.</summary>
        public MicrosoftGraphLicenseUnitsDetail()
        {

        }
    }
    /// licenseUnitsDetail
    public partial interface IMicrosoftGraphLicenseUnitsDetail :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// The number of units that are enabled for the active subscription of the service SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of units that are enabled for the active subscription of the service SKU.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(int) })]
        int? Enabled { get; set; }
        /// <summary>
        /// The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot
        /// be assigned but can still be reactivated before they are deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot be assigned but can still be reactivated before they are deleted.",
        SerializedName = @"suspended",
        PossibleTypes = new [] { typeof(int) })]
        int? Suspended { get; set; }
        /// <summary>
        /// The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has
        /// a grace period to renew their subscription before it is cancelled (moved to a suspended state).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has a grace period to renew their subscription before it is cancelled (moved to a suspended state).",
        SerializedName = @"warning",
        PossibleTypes = new [] { typeof(int) })]
        int? Warning { get; set; }

    }
    /// licenseUnitsDetail
    internal partial interface IMicrosoftGraphLicenseUnitsDetailInternal

    {
        /// <summary>
        /// The number of units that are enabled for the active subscription of the service SKU.
        /// </summary>
        int? Enabled { get; set; }
        /// <summary>
        /// The number of units that are suspended because the subscription of the service SKU has been cancelled. The units cannot
        /// be assigned but can still be reactivated before they are deleted.
        /// </summary>
        int? Suspended { get; set; }
        /// <summary>
        /// The number of units that are in warning status. When the subscription of the service SKU has expired, the customer has
        /// a grace period to renew their subscription before it is cancelled (moved to a suspended state).
        /// </summary>
        int? Warning { get; set; }

    }
}