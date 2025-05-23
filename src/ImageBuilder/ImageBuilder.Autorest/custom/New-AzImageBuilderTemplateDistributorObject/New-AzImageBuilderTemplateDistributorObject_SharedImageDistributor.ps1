
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ImageTemplateDistributor.
.Description
Create an in-memory object for ImageTemplateDistributor.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.ImageTemplateSharedImageDistributor
.Link
https://learn.microsoft.com/powershell/module/az.ImageBuilder/new-azimagebuildertemplatedistributorobject
#>
function New-AzImageBuilderTemplateDistributorObject_SharedImageDistributor {
    [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.ImageTemplateSharedImageDistributor')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Flag that indicates whether created image version should be excluded from latest. Omit to use the default (false).")]
        [bool]
        $ExcludeFromLatest,
        [Parameter(Mandatory, HelpMessage="Resource Id of the Azure Compute Gallery image.")]
        [string]
        $GalleryImageId,
        [Parameter(HelpMessage="[Deprecated] A list of regions that the image will be replicated to. This list can be specified only if targetRegions is not specified. This field is deprecated - use targetRegions instead.")]
        [string[]]
        $ReplicationRegion,
        [Parameter(HelpMessage="[Deprecated] Storage account type to be used to store the shared image. Omit to use the default (Standard_LRS). This field can be specified only if replicationRegions is specified. This field is deprecated - use targetRegions instead.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PSArgumentCompleterAttribute("Standard_LRS", "Standard_ZRS", "Premium_LRS")]
        [string]
        $StorageAccountType,
        [Parameter(HelpMessage="The target regions where the distributed Image Version is going to be replicated to. This object supersedes replicationRegions and can be specified only if replicationRegions is not specified.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.ITargetRegion[]]
        $TargetRegion,
        [Parameter(HelpMessage="Describes how to generate new x.y.z version number for distribution.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IDistributeVersioner]
        $Versioning,
        [Parameter(HelpMessage="Tags that will be applied to the artifact once it has been created/updated by the distributor.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateDistributorArtifactTags]
        $ArtifactTag,
        [Parameter(Mandatory, HelpMessage="The name to be used for the associated RunOutput.")]
        [string]
        $RunOutputName,
        [Parameter(Mandatory, HelpMessage="Distribute via Shared Image Gallery.")]
        [Switch]
        $SharedImageDistributor
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.ImageTemplateSharedImageDistributor]::New()

        if ($PSBoundParameters.ContainsKey('ExcludeFromLatest')) {
            $Object.ExcludeFromLatest = $ExcludeFromLatest
        }
        if ($PSBoundParameters.ContainsKey('GalleryImageId')) {
            $Object.GalleryImageId = $GalleryImageId
        }
        if ($PSBoundParameters.ContainsKey('ReplicationRegion')) {
            $Object.ReplicationRegion = $ReplicationRegion
        }
        if ($PSBoundParameters.ContainsKey('StorageAccountType')) {
            $Object.StorageAccountType = $StorageAccountType
        }
        if ($PSBoundParameters.ContainsKey('TargetRegion')) {
            $Object.TargetRegion = $TargetRegion
        }
        if ($PSBoundParameters.ContainsKey('Versioning')) {
            $Object.Versioning = $Versioning
        }
        if ($PSBoundParameters.ContainsKey('ArtifactTag')) {
            $Object.ArtifactTag = $ArtifactTag
        }
        if ($PSBoundParameters.ContainsKey('RunOutputName')) {
            $Object.RunOutputName = $RunOutputName
        }
        return $Object
    }
}

