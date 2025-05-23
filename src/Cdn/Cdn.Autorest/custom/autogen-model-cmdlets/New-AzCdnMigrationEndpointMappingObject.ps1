
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
Create an in-memory object for MigrationEndpointMapping.
.Description
Create an in-memory object for MigrationEndpointMapping.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.MigrationEndpointMapping
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-azcdnmigrationendpointmappingobject
#>
function New-AzCdnMigrationEndpointMappingObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.MigrationEndpointMapping')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Name of the classic CDN profile endpoint.")]
        [string]
        $MigratedFrom,
        [Parameter(HelpMessage="Name of the newly created migrated Azure Frontdoor Standard/Premium profile endpoint. This name will replace the name of the classic CDN endpoint resource.")]
        [string]
        $MigratedTo
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.MigrationEndpointMapping]::New()

        if ($PSBoundParameters.ContainsKey('MigratedFrom')) {
            $Object.MigratedFrom = $MigratedFrom
        }
        if ($PSBoundParameters.ContainsKey('MigratedTo')) {
            $Object.MigratedTo = $MigratedTo
        }
        return $Object
    }
}

