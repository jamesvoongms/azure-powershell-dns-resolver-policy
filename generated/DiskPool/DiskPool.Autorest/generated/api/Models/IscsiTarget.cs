// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Response for iSCSI Target requests.</summary>
    public partial class IscsiTarget :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTarget,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ProxyResource();

        /// <summary>Mode for Target connectivity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string AclMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).AclMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).AclMode = value ; }

        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Endpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Endpoint = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Lun; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Lun = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ManagedBy" /> property.</summary>
        private string _managedBy;

        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ManagedBy { get => this._managedBy; }

        /// <summary>Backing field for <see cref="ManagedByExtended" /> property.</summary>
        private System.Collections.Generic.List<string> _managedByExtended;

        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ManagedByExtended { get => this._managedByExtended; }

        /// <summary>Internal Acessors for ManagedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.ManagedBy { get => this._managedBy; set { {_managedBy = value;} } }

        /// <summary>Internal Acessors for ManagedByExtended</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.ManagedByExtended { get => this._managedByExtended; set { {_managedByExtended = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetProperties Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IscsiTargetProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Session</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.Session { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Session; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Session = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadata Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.SystemMetadata()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedByType = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>The port used by iSCSI Target portal group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public int? Port { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Port; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Port = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetProperties _property;

        /// <summary>Properties for iSCSI Target operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IscsiTargetProperties()); set => this._property = value; }

        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Session { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Session; }

        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).StaticAcls; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).StaticAcls = value ?? null /* arrayOf */; }

        /// <summary>Operational status of the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).Status = value ; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadata _systemData;

        /// <summary>Resource metadata required by ARM RPC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadata SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.SystemMetadata()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).CreatedByType; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadataInternal)SystemData).LastModifiedByType; }

        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public string TargetIqn { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).TargetIqn; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetPropertiesInternal)Property).TargetIqn = value ; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="IscsiTarget" /> instance.</summary>
        public IscsiTarget()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Response for iSCSI Target requests.
    public partial interface IIscsiTarget :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource
    {
        /// <summary>Mode for Target connectivity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mode for Target connectivity.",
        SerializedName = @"aclMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string AclMode { get; set; }
        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of private IPv4 addresses to connect to the iSCSI Target.",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Endpoint { get; set; }
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of LUNs to be exposed through iSCSI Target.",
        SerializedName = @"luns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource id. Indicates if this resource is managed by another Azure resource.",
        SerializedName = @"managedBy",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedBy { get;  }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Azure resource ids that manage this resource.",
        SerializedName = @"managedByExtended",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ManagedByExtended { get;  }
        /// <summary>The port used by iSCSI Target portal group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port used by iSCSI Target portal group.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get; set; }
        /// <summary>State of the operation on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"State of the operation on the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Invalid", "Succeeded", "Failed", "Canceled", "Pending", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of identifiers for active sessions on the iSCSI target",
        SerializedName = @"sessions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Session { get;  }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Access Control List (ACL) for an iSCSI Target; defines LUN masking policy",
        SerializedName = @"staticAcls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get; set; }
        /// <summary>Operational status of the iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operational status of the iSCSI Target.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Invalid", "Unknown", "Healthy", "Unhealthy", "Updating", "Running", "Stopped", "Stopped (deallocated)")]
        string Status { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get;  }
        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"iSCSI Target IQN (iSCSI Qualified Name); example: ""iqn.2005-03.org.iscsi:server"".",
        SerializedName = @"targetIqn",
        PossibleTypes = new [] { typeof(string) })]
        string TargetIqn { get; set; }

    }
    /// Response for iSCSI Target requests.
    internal partial interface IIscsiTargetInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResourceInternal
    {
        /// <summary>Mode for Target connectivity.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string AclMode { get; set; }
        /// <summary>List of private IPv4 addresses to connect to the iSCSI Target.</summary>
        System.Collections.Generic.List<string> Endpoint { get; set; }
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        string ManagedBy { get; set; }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        System.Collections.Generic.List<string> ManagedByExtended { get; set; }
        /// <summary>The port used by iSCSI Target portal group.</summary>
        int? Port { get; set; }
        /// <summary>Properties for iSCSI Target operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetProperties Property { get; set; }
        /// <summary>State of the operation on the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Invalid", "Succeeded", "Failed", "Canceled", "Pending", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>List of identifiers for active sessions on the iSCSI target</summary>
        System.Collections.Generic.List<string> Session { get; set; }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get; set; }
        /// <summary>Operational status of the iSCSI Target.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("Invalid", "Unknown", "Healthy", "Unhealthy", "Updating", "Running", "Stopped", "Stopped (deallocated)")]
        string Status { get; set; }
        /// <summary>Resource metadata required by ARM RPC</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ISystemMetadata SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server".
        /// </summary>
        string TargetIqn { get; set; }

    }
}