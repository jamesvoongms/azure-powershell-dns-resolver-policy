// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Information describing the type of billing plan for this reservation.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReservationOrderBillingPlanInformationTypeConverter))]
    public partial class ReservationOrderBillingPlanInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReservationOrderBillingPlanInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReservationOrderBillingPlanInformation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReservationOrderBillingPlanInformation" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ReservationOrderBillingPlanInformation" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReservationOrderBillingPlanInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).PricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice) content.GetValueForProperty("PricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).PricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).StartDate = (global::System.DateTime?) content.GetValueForProperty("StartDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).StartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).NextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("NextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).NextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Transaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).Transaction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>) content.GetValueForProperty("Transaction",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).Transaction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PaymentDetailTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReservationOrderBillingPlanInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).PricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice) content.GetValueForProperty("PricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).PricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).StartDate = (global::System.DateTime?) content.GetValueForProperty("StartDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).StartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).NextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("NextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).NextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Transaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).Transaction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>) content.GetValueForProperty("Transaction",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformationInternal)this).Transaction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PaymentDetailTypeConverter.ConvertFrom));
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
    /// Information describing the type of billing plan for this reservation.
    [System.ComponentModel.TypeConverter(typeof(ReservationOrderBillingPlanInformationTypeConverter))]
    public partial interface IReservationOrderBillingPlanInformation

    {

    }
}