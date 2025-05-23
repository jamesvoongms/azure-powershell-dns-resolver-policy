// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Extensions;

    /// <summary>
    /// ManagementConfiguration properties supported by the OperationsManagement resource provider.
    /// </summary>
    public partial class ManagementConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IManagementConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IManagementConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        /// <summary>The applicationId of the appliance for this Management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Origin(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.PropertyOrigin.Owned)]
        public string ApplicationId { get => this._applicationId; set => this._applicationId = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IManagementConfigurationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IArmTemplateParameter> _parameter;

        /// <summary>Parameters to run the ARM template</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Origin(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IArmTemplateParameter> Parameter { get => this._parameter; set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ParentResourceType" /> property.</summary>
        private string _parentResourceType;

        /// <summary>The type of the parent resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Origin(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.PropertyOrigin.Owned)]
        public string ParentResourceType { get => this._parentResourceType; set => this._parentResourceType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state for the ManagementConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Origin(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IAny _template;

        /// <summary>The Json object containing the ARM template to deploy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Origin(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IAny Template { get => (this._template = this._template ?? new Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.Any()); set => this._template = value; }

        /// <summary>Creates an new <see cref="ManagementConfigurationProperties" /> instance.</summary>
        public ManagementConfigurationProperties()
        {

        }
    }
    /// ManagementConfiguration properties supported by the OperationsManagement resource provider.
    public partial interface IManagementConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.IJsonSerializable
    {
        /// <summary>The applicationId of the appliance for this Management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The applicationId of the appliance for this Management.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationId { get; set; }
        /// <summary>Parameters to run the ARM template</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parameters to run the ARM template",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IArmTemplateParameter) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IArmTemplateParameter> Parameter { get; set; }
        /// <summary>The type of the parent resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the parent resource.",
        SerializedName = @"parentResourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ParentResourceType { get; set; }
        /// <summary>The provisioning state for the ManagementConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state for the ManagementConfiguration.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The Json object containing the ARM template to deploy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Json object containing the ARM template to deploy",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IAny Template { get; set; }

    }
    /// ManagementConfiguration properties supported by the OperationsManagement resource provider.
    internal partial interface IManagementConfigurationPropertiesInternal

    {
        /// <summary>The applicationId of the appliance for this Management.</summary>
        string ApplicationId { get; set; }
        /// <summary>Parameters to run the ARM template</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IArmTemplateParameter> Parameter { get; set; }
        /// <summary>The type of the parent resource.</summary>
        string ParentResourceType { get; set; }
        /// <summary>The provisioning state for the ManagementConfiguration.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The Json object containing the ARM template to deploy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MonitoringSolutions.Models.IAny Template { get; set; }

    }
}