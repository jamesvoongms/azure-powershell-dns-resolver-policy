// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Request body for savings plan purchase</summary>
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanPurchaseRequestTypeConverter))]
    public partial class SavingsPlanPurchaseRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SavingsPlanPurchaseRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SavingsPlanPurchaseRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SavingsPlanPurchaseRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SavingsPlanPurchaseRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SavingsPlanPurchaseRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InternalSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).InternalSkuName = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISkuName) content.GetValueForProperty("InternalSkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).InternalSkuName, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SkuNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Properties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Properties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestProperties) content.GetValueForProperty("Properties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Properties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("Commitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Commitment = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ICommitment) content.GetValueForProperty("Commitment",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Commitment, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.CommitmentTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingPlan = (string) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingPlan, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Term = (string) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Term, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeType = (string) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentGrain = (string) content.GetValueForProperty("CommitmentGrain",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentGrain, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentCurrencyCode = (string) content.GetValueForProperty("CommitmentCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentAmount = (double?) content.GetValueForProperty("CommitmentAmount",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SavingsPlanPurchaseRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InternalSkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).InternalSkuName = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISkuName) content.GetValueForProperty("InternalSkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).InternalSkuName, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SkuNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Properties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Properties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestProperties) content.GetValueForProperty("Properties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Properties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SavingsPlanPurchaseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("Commitment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Commitment = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ICommitment) content.GetValueForProperty("Commitment",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Commitment, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.CommitmentTypeConverter.ConvertFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingPlan = (string) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingPlan, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Term = (string) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).Term, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeType = (string) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentGrain = (string) content.GetValueForProperty("CommitmentGrain",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentGrain, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentCurrencyCode = (string) content.GetValueForProperty("CommitmentCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("CommitmentAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentAmount = (double?) content.GetValueForProperty("CommitmentAmount",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISavingsPlanPurchaseRequestInternal)this).CommitmentAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    }
    /// Request body for savings plan purchase
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanPurchaseRequestTypeConverter))]
    public partial interface ISavingsPlanPurchaseRequest

    {

    }
}