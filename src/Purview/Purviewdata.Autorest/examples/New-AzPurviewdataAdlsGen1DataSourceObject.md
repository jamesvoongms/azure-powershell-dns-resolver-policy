### Example 1: List all DNS Resolver Policies under the subscription 
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

This command gets all DNS Resolver Policies under the subscription.

### Example 2: List all DNS Resolver Policies under the resource group 
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

This command gets all DNS Resolver Policies under the resource group.

### Example 3: Get single DNS Resolver by name 
```powershell
Get-AzDnsResolverPolicy -ResourceGroupName powershell-test-rg -Name psdnsresolverpolicyname33nmy1fz
```

```output
Location Name                            Type                                  Etag
-------- ----                            ----                                  ----
westus2  psdnsresolverpolicyname33nmy1fz Microsoft.Network/dnsResolverPolicies "0000c2d4-0000-0800-0000-604013880000"
```

This command gets a single DNS Resolver Policy by name.
