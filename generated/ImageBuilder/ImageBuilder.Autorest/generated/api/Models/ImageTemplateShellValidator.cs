// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Extensions;

    /// <summary>
    /// Runs the specified shell script during the validation phase (Linux). Corresponds to Packer shell provisioner. Exactly
    /// one of 'scriptUri' or 'inline' can be specified.
    /// </summary>
    public partial class ImageTemplateShellValidator :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateShellValidator,
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateShellValidatorInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidator"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidator __imageTemplateInVMValidator = new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.ImageTemplateInVMValidator();

        /// <summary>Backing field for <see cref="Inline" /> property.</summary>
        private System.Collections.Generic.List<string> _inline;

        /// <summary>Array of shell commands to execute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Inline { get => this._inline; set => this._inline = value; }

        /// <summary>Friendly Name to provide context on what this validation step does</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidatorInternal)__imageTemplateInVMValidator).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidatorInternal)__imageTemplateInVMValidator).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ScriptUri" /> property.</summary>
        private string _scriptUri;

        /// <summary>
        /// URI of the shell script to be run for validation. It can be a github link, Azure Storage URI, etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public string ScriptUri { get => this._scriptUri; set => this._scriptUri = value; }

        /// <summary>Backing field for <see cref="Sha256Checksum" /> property.</summary>
        private string _sha256Checksum;

        /// <summary>SHA256 checksum of the shell script provided in the scriptUri field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public string Sha256Checksum { get => this._sha256Checksum; set => this._sha256Checksum = value; }

        /// <summary>
        /// The type of validation you want to use on the Image. For example, "Shell" can be shell validation
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Inherited)]
        public string Type { get => "Shell"; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidatorInternal)__imageTemplateInVMValidator).Type = "Shell"; }

        /// <summary>Creates an new <see cref="ImageTemplateShellValidator" /> instance.</summary>
        public ImageTemplateShellValidator()
        {
            this.__imageTemplateInVMValidator.Type = "Shell";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__imageTemplateInVMValidator), __imageTemplateInVMValidator);
            await eventListener.AssertObjectIsValid(nameof(__imageTemplateInVMValidator), __imageTemplateInVMValidator);
        }
    }
    /// Runs the specified shell script during the validation phase (Linux). Corresponds to Packer shell provisioner. Exactly
    /// one of 'scriptUri' or 'inline' can be specified.
    public partial interface IImageTemplateShellValidator :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidator
    {
        /// <summary>Array of shell commands to execute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of shell commands to execute",
        SerializedName = @"inline",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Inline { get; set; }
        /// <summary>
        /// URI of the shell script to be run for validation. It can be a github link, Azure Storage URI, etc
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URI of the shell script to be run for validation. It can be a github link, Azure Storage URI, etc",
        SerializedName = @"scriptUri",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptUri { get; set; }
        /// <summary>SHA256 checksum of the shell script provided in the scriptUri field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SHA256 checksum of the shell script provided in the scriptUri field",
        SerializedName = @"sha256Checksum",
        PossibleTypes = new [] { typeof(string) })]
        string Sha256Checksum { get; set; }

    }
    /// Runs the specified shell script during the validation phase (Linux). Corresponds to Packer shell provisioner. Exactly
    /// one of 'scriptUri' or 'inline' can be specified.
    internal partial interface IImageTemplateShellValidatorInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateInVMValidatorInternal
    {
        /// <summary>Array of shell commands to execute</summary>
        System.Collections.Generic.List<string> Inline { get; set; }
        /// <summary>
        /// URI of the shell script to be run for validation. It can be a github link, Azure Storage URI, etc
        /// </summary>
        string ScriptUri { get; set; }
        /// <summary>SHA256 checksum of the shell script provided in the scriptUri field</summary>
        string Sha256Checksum { get; set; }

    }
}