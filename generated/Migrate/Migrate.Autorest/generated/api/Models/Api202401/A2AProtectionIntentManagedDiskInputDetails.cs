// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Azure VM managed disk input details.</summary>
    public partial class A2AProtectionIntentManagedDiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfo _diskEncryptionInfo;

        /// <summary>The recovery disk encryption information (for one / single pass flows).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfo DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.DiskEncryptionInfo()); set => this._diskEncryptionInfo = value; }

        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoSecretIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier = value ?? null; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier = value ?? null; }

        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal.DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.DiskEncryptionInfo()); set { {_diskEncryptionInfo = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionInfoDiskEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal.DiskEncryptionInfoDiskEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for DiskEncryptionInfoKeyEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IKeyEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal.DiskEncryptionInfoKeyEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for PrimaryStagingStorageAccountCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal.PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.StorageAccountCustomDetails()); set { {_primaryStagingStorageAccountCustomInput = value;} } }

        /// <summary>Internal Acessors for RecoveryResourceGroupCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AProtectionIntentManagedDiskInputDetailsInternal.RecoveryResourceGroupCustomInput { get => (this._recoveryResourceGroupCustomInput = this._recoveryResourceGroupCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.RecoveryResourceGroupCustomDetails()); set { {_recoveryResourceGroupCustomInput = value;} } }

        /// <summary>
        /// Backing field for <see cref="PrimaryStagingStorageAccountCustomInput" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetails _primaryStagingStorageAccountCustomInput;

        /// <summary>The primary staging storage account input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.StorageAccountCustomDetails()); set => this._primaryStagingStorageAccountCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PrimaryStagingStorageAccountCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryDiskEncryptionSetId" /> property.</summary>
        private string _recoveryDiskEncryptionSetId;

        /// <summary>The recovery disk encryption set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryDiskEncryptionSetId { get => this._recoveryDiskEncryptionSetId; set => this._recoveryDiskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="RecoveryReplicaDiskAccountType" /> property.</summary>
        private string _recoveryReplicaDiskAccountType;

        /// <summary>
        /// The replica disk type. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryReplicaDiskAccountType { get => this._recoveryReplicaDiskAccountType; set => this._recoveryReplicaDiskAccountType = value; }

        /// <summary>Backing field for <see cref="RecoveryResourceGroupCustomInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetails _recoveryResourceGroupCustomInput;

        /// <summary>The recovery resource group input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetails RecoveryResourceGroupCustomInput { get => (this._recoveryResourceGroupCustomInput = this._recoveryResourceGroupCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.RecoveryResourceGroupCustomDetails()); set => this._recoveryResourceGroupCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryResourceGroupCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetailsInternal)RecoveryResourceGroupCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetailsInternal)RecoveryResourceGroupCustomInput).ResourceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryTargetDiskAccountType" /> property.</summary>
        private string _recoveryTargetDiskAccountType;

        /// <summary>
        /// The target disk type after failover. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryTargetDiskAccountType { get => this._recoveryTargetDiskAccountType; set => this._recoveryTargetDiskAccountType = value; }

        /// <summary>
        /// Creates an new <see cref="A2AProtectionIntentManagedDiskInputDetails" /> instance.
        /// </summary>
        public A2AProtectionIntentManagedDiskInputDetails()
        {

        }
    }
    /// Azure VM managed disk input details.
    public partial interface IA2AProtectionIntentManagedDiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM id for secret.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secret url / identifier.",
        SerializedName = @"secretIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The disk Id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key URL / identifier.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM Id for key.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The recovery disk encryption set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery disk encryption set Id.",
        SerializedName = @"recoveryDiskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryDiskEncryptionSetId { get; set; }
        /// <summary>
        /// The replica disk type. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replica disk type. Its an optional value and will be same as source disk type if not user provided.",
        SerializedName = @"recoveryReplicaDiskAccountType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryResourceGroupCustomInputResourceType { get; set; }
        /// <summary>
        /// The target disk type after failover. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target disk type after failover. Its an optional value and will be same as source disk type if not user provided.",
        SerializedName = @"recoveryTargetDiskAccountType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryTargetDiskAccountType { get; set; }

    }
    /// Azure VM managed disk input details.
    internal partial interface IA2AProtectionIntentManagedDiskInputDetailsInternal

    {
        /// <summary>The recovery disk encryption information (for one / single pass flows).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary>The recovery KeyVault reference for secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IDiskEncryptionKeyInfo DiskEncryptionInfoDiskEncryptionKeyInfo { get; set; }
        /// <summary>The recovery KeyVault reference for key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IKeyEncryptionKeyInfo DiskEncryptionInfoKeyEncryptionKeyInfo { get; set; }
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The disk Id.</summary>
        string DiskId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The primary staging storage account input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The recovery disk encryption set Id.</summary>
        string RecoveryDiskEncryptionSetId { get; set; }
        /// <summary>
        /// The replica disk type. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary>The recovery resource group input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IRecoveryResourceGroupCustomDetails RecoveryResourceGroupCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryResourceGroupCustomInputResourceType { get; set; }
        /// <summary>
        /// The target disk type after failover. Its an optional value and will be same as source disk type if not user provided.
        /// </summary>
        string RecoveryTargetDiskAccountType { get; set; }

    }
}