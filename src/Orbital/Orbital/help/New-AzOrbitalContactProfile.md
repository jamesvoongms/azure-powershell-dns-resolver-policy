---
external help file: Az.Orbital-help.xml
Module Name: Az.Orbital
online version: https://learn.microsoft.com/powershell/module/az.orbital/new-azorbitalcontactprofile
schema: 2.0.0
---

# New-AzOrbitalContactProfile

## SYNOPSIS
create a contact profile.

## SYNTAX

### CreateExpanded (Default)
```
New-AzOrbitalContactProfile -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 -Link <IContactProfileLink[]> -Location <String> -NetworkConfigurationSubnetId <String>
 [-AutoTrackingConfiguration <String>] [-EventHubUri <String>] [-MinimumElevationDegree <Single>]
 [-MinimumViableContactDuration <String>] [-Tag <Hashtable>]
 [-ThirdPartyConfiguration <IContactProfileThirdPartyConfiguration[]>] [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzOrbitalContactProfile -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 -JsonFilePath <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzOrbitalContactProfile -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 -JsonString <String> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
create a contact profile.

## EXAMPLES

### Example 1: Creates or updates a contact profile.
```powershell
$linkChannel = New-AzOrbitalContactProfileLinkChannelObject -BandwidthMHz 15 -CenterFrequencyMHz 8160 -EndPointIPAddress 10.0.1.0 -EndPointName AQUA_VM -EndPointPort 51103 -EndPointProtocol TCP -Name channel1 -DecodingConfiguration na -DemodulationConfiguration na -EncodingConfiguration na -ModulationConfiguration aqua_direct_broadcast

$profileLink = New-AzOrbitalContactProfileLinkObject -Channel $linkChannel -Direction Downlink -Name RHCP_Downlink -Polarization RHCP -EirpdBw 0 -GainOverTemperature 0

New-AzOrbitalContactProfile -Name azps-orbital-contactprofile -ResourceGroupName azpstest-gp -Location westus2 -AutoTrackingConfiguration xBand -EventHubUri /subscriptions/11111111-2222-3333-4444-123456789101/resourceGroups/azpstest-gp/providers/Microsoft.EventHub/namespaces/eventhub-test -Link $profileLink -MinimumElevationDegree 5 -MinimumViableContactDuration PT1M -NetworkConfigurationSubnetId /subscriptions/11111111-2222-3333-4444-123456789101/resourceGroups/azpstest-gp/providers/Microsoft.Network/virtualNetworks/orbital-virtualnetwork/subnets/orbital-vn
```

```output
Name                        Location ProvisioningState ResourceGroupName
----                        -------- ----------------- -----------------
azps-orbital-contactprofile westus2  succeeded         azpstest-gp
```

Creates or updates a contact profile.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoTrackingConfiguration
Auto-tracking configuration.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventHubUri
ARM resource identifier of the Event Hub used for telemetry.
Requires granting Orbital Resource Provider the rights to send telemetry into the hub.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Link
Links of the Contact Profile.
Describes RF links, modem processing, and IP endpoints.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfileLink[]
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumElevationDegree
Minimum viable elevation for the contact in decimal degrees.
Used for listing the available contacts with a spacecraft at a given ground station.

```yaml
Type: System.Single
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumViableContactDuration
Minimum viable contact duration in ISO 8601 format.
Used for listing the available contacts with a spacecraft at a given ground station.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Contact Profile name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ContactProfileName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkConfigurationSubnetId
ARM resource identifier of the subnet delegated to the Microsoft.Orbital/orbitalGateways.
Needs to be at least a class C subnet, and should not have any IP created in it.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThirdPartyConfiguration
Third-party mission configuration of the Contact Profile.
Describes RF links, modem processing, and IP endpoints.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfileThirdPartyConfiguration[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfile

## NOTES

## RELATED LINKS
