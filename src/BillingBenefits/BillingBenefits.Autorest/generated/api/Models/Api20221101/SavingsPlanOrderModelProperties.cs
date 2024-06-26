// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Savings plan order properties</summary>
    public partial class SavingsPlanOrderModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BenefitStartTime" /> property.</summary>
        private global::System.DateTime? _benefitStartTime;

        /// <summary>This is the DateTime when the savings plan benefit started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public global::System.DateTime? BenefitStartTime { get => this._benefitStartTime; set => this._benefitStartTime = value; }

        /// <summary>Backing field for <see cref="BillingAccountId" /> property.</summary>
        private string _billingAccountId;

        /// <summary>
        /// Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement
        /// customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string BillingAccountId { get => this._billingAccountId; }

        /// <summary>Backing field for <see cref="BillingPlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? _billingPlan;

        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get => this._billingPlan; set => this._billingPlan = value; }

        /// <summary>Backing field for <see cref="BillingProfileId" /> property.</summary>
        private string _billingProfileId;

        /// <summary>
        /// Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led
        /// customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string BillingProfileId { get => this._billingProfileId; }

        /// <summary>Backing field for <see cref="BillingScopeId" /> property.</summary>
        private string _billingScopeId;

        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string BillingScopeId { get => this._billingScopeId; set => this._billingScopeId = value; }

        /// <summary>Backing field for <see cref="CustomerId" /> property.</summary>
        private string _customerId;

        /// <summary>
        /// Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string CustomerId { get => this._customerId; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="ExpiryDateTime" /> property.</summary>
        private global::System.DateTime? _expiryDateTime;

        /// <summary>Expiry date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public global::System.DateTime? ExpiryDateTime { get => this._expiryDateTime; }

        /// <summary>Backing field for <see cref="ExtendedStatusInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo _extendedStatusInfo;

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo ExtendedStatusInfo { get => (this._extendedStatusInfo = this._extendedStatusInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ExtendedStatusInfo()); }

        /// <summary>The message giving detailed information about the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string ExtendedStatusInfoMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfoInternal)ExtendedStatusInfo).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfoInternal)ExtendedStatusInfo).Message = value ?? null; }

        /// <summary>Status code providing additional information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string ExtendedStatusInfoStatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfoInternal)ExtendedStatusInfo).StatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfoInternal)ExtendedStatusInfo).StatusCode = value ?? null; }

        /// <summary>Internal Acessors for BillingAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.BillingAccountId { get => this._billingAccountId; set { {_billingAccountId = value;} } }

        /// <summary>Internal Acessors for BillingProfileId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.BillingProfileId { get => this._billingProfileId; set { {_billingProfileId = value;} } }

        /// <summary>Internal Acessors for CustomerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.CustomerId { get => this._customerId; set { {_customerId = value;} } }

        /// <summary>Internal Acessors for ExpiryDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.ExpiryDateTime { get => this._expiryDateTime; set { {_expiryDateTime = value;} } }

        /// <summary>Internal Acessors for ExtendedStatusInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.ExtendedStatusInfo { get => (this._extendedStatusInfo = this._extendedStatusInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ExtendedStatusInfo()); set { {_extendedStatusInfo = value;} } }

        /// <summary>Internal Acessors for PlanInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.PlanInformation { get => (this._planInformation = this._planInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.BillingPlanInformation()); set { {_planInformation = value;} } }

        /// <summary>Internal Acessors for PlanInformationPricingCurrencyTotal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.PlanInformationPricingCurrencyTotal { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotal; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotal = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PlanInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation _planInformation;

        /// <summary>Information describing the type of billing plan for this savings plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation PlanInformation { get => (this._planInformation = this._planInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.BillingPlanInformation()); set => this._planInformation = value; }

        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public global::System.DateTime? PlanInformationNextPaymentDueDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).NextPaymentDueDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).NextPaymentDueDate = value ?? default(global::System.DateTime); }

        /// <summary>Date when the billing plan has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public global::System.DateTime? PlanInformationStartDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).StartDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).StartDate = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] PlanInformationTransaction { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).Transaction; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).Transaction = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public double? PricingCurrencyTotalAmount { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotalAmount; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotalAmount = value ?? default(double); }

        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string PricingCurrencyTotalCurrencyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotalCurrencyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformationInternal)PlanInformation).PricingCurrencyTotalCurrencyCode = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SavingsPlan" /> property.</summary>
        private string[] _savingsPlan;

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string[] SavingsPlan { get => this._savingsPlan; set => this._savingsPlan = value; }

        /// <summary>Backing field for <see cref="Term" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? _term;

        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get => this._term; set => this._term = value; }

        /// <summary>Creates an new <see cref="SavingsPlanOrderModelProperties" /> instance.</summary>
        public SavingsPlanOrderModelProperties()
        {

        }
    }
    /// Savings plan order properties
    public partial interface ISavingsPlanOrderModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>This is the DateTime when the savings plan benefit started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is the DateTime when the savings plan benefit started.",
        SerializedName = @"benefitStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BenefitStartTime { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement
        /// customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement customers.",
        SerializedName = @"billingAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingAccountId { get;  }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led
        /// customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led customers.",
        SerializedName = @"billingProfileId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingProfileId { get;  }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing the benefit",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers.",
        SerializedName = @"customerId",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerId { get;  }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Expiry date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Expiry date time",
        SerializedName = @"expiryDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpiryDateTime { get;  }
        /// <summary>The message giving detailed information about the status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message giving detailed information about the status code.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedStatusInfoMessage { get; set; }
        /// <summary>Status code providing additional information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status code providing additional information.",
        SerializedName = @"statusCode",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedStatusInfoStatusCode { get; set; }
        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.",
        SerializedName = @"nextPaymentDueDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PlanInformationNextPaymentDueDate { get; set; }
        /// <summary>Date when the billing plan has started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date when the billing plan has started.",
        SerializedName = @"startDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PlanInformationStartDate { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"transactions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] PlanInformationTransaction { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amount",
        PossibleTypes = new [] { typeof(double) })]
        double? PricingCurrencyTotalAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ISO 4217 3-letter currency code for the currency used by this purchase record.",
        SerializedName = @"currencyCode",
        PossibleTypes = new [] { typeof(string) })]
        string PricingCurrencyTotalCurrencyCode { get; set; }
        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"savingsPlans",
        PossibleTypes = new [] { typeof(string) })]
        string[] SavingsPlan { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent benefit term in ISO 8601 format.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
    /// Savings plan order properties
    internal partial interface ISavingsPlanOrderModelPropertiesInternal

    {
        /// <summary>This is the DateTime when the savings plan benefit started.</summary>
        global::System.DateTime? BenefitStartTime { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the billing account where the savings plan is applied. Present only for Enterprise Agreement
        /// customers.
        /// </summary>
        string BillingAccountId { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the billing profile where the savings plan is applied. Present only for Field-led or Customer-led
        /// customers.
        /// </summary>
        string BillingProfileId { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        string BillingScopeId { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the customer where the savings plan is applied. Present only for Partner-led customers.
        /// </summary>
        string CustomerId { get; set; }
        /// <summary>Display name</summary>
        string DisplayName { get; set; }
        /// <summary>Expiry date time</summary>
        global::System.DateTime? ExpiryDateTime { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo ExtendedStatusInfo { get; set; }
        /// <summary>The message giving detailed information about the status code.</summary>
        string ExtendedStatusInfoMessage { get; set; }
        /// <summary>Status code providing additional information.</summary>
        string ExtendedStatusInfoStatusCode { get; set; }
        /// <summary>Information describing the type of billing plan for this savings plan.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation PlanInformation { get; set; }
        /// <summary>
        /// For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off.
        /// </summary>
        global::System.DateTime? PlanInformationNextPaymentDueDate { get; set; }
        /// <summary>Amount of money to be paid for the Order. Tax is not included.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice PlanInformationPricingCurrencyTotal { get; set; }
        /// <summary>Date when the billing plan has started.</summary>
        global::System.DateTime? PlanInformationStartDate { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[] PlanInformationTransaction { get; set; }

        double? PricingCurrencyTotalAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        string PricingCurrencyTotalCurrencyCode { get; set; }
        /// <summary>Provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState? ProvisioningState { get; set; }

        string[] SavingsPlan { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
}