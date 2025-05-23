// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.PowerShell;

    /// <summary>Resource information with extended details.</summary>
    [System.ComponentModel.TypeConverter(typeof(VaultTypeConverter))]
    public partial class Vault
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Vault"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVault" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVault DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Vault(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Vault"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVault" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVault DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Vault(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Vault" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Vault" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVault FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Vault"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Vault(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.VaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AccessPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).AccessPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry>) content.GetValueForProperty("AccessPolicy",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).AccessPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry>(__y, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.AccessPolicyEntryTypeConverter.ConvertFrom));
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("EnabledForDeployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDeployment = (bool?) content.GetValueForProperty("EnabledForDeployment",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDeployment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnabledForDiskEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDiskEncryption = (bool?) content.GetValueForProperty("EnabledForDiskEncryption",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDiskEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnabledForTemplateDeployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForTemplateDeployment = (bool?) content.GetValueForProperty("EnabledForTemplateDeployment",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForTemplateDeployment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableSoftDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnableSoftDelete = (bool?) content.GetValueForProperty("EnableSoftDelete",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnableSoftDelete, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnablePurgeProtection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnablePurgeProtection = (bool?) content.GetValueForProperty("EnablePurgeProtection",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnablePurgeProtection, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Vault"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Vault(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.VaultPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IResourceAutoGeneratedInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).CreateMode = (string) content.GetValueForProperty("CreateMode",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).CreateMode, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AccessPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).AccessPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry>) content.GetValueForProperty("AccessPolicy",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).AccessPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry>(__y, Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.AccessPolicyEntryTypeConverter.ConvertFrom));
            }
            if (content.Contains("Uri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Uri = (string) content.GetValueForProperty("Uri",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).Uri, global::System.Convert.ToString);
            }
            if (content.Contains("EnabledForDeployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDeployment = (bool?) content.GetValueForProperty("EnabledForDeployment",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDeployment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnabledForDiskEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDiskEncryption = (bool?) content.GetValueForProperty("EnabledForDiskEncryption",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForDiskEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnabledForTemplateDeployment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForTemplateDeployment = (bool?) content.GetValueForProperty("EnabledForTemplateDeployment",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnabledForTemplateDeployment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableSoftDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnableSoftDelete = (bool?) content.GetValueForProperty("EnableSoftDelete",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnableSoftDelete, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnablePurgeProtection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnablePurgeProtection = (bool?) content.GetValueForProperty("EnablePurgeProtection",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).EnablePurgeProtection, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SkuFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultInternal)this).SkuName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Resource information with extended details.
    [System.ComponentModel.TypeConverter(typeof(VaultTypeConverter))]
    public partial interface IVault

    {

    }
}