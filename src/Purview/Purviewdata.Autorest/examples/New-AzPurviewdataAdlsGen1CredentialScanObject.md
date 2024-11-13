### Example 1: List all DNS Resolver Domain Lists under the subscription 
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

This command gets all DNS Resolver Domain Lists under the subscription.

### Example 2: List all DNS Resolver Domain Lists under the resource group 
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

This command gets all DNS Resolver Domain Lists under the resource group.

### Example 3: Get single DNS Resolver by name 
```powershell
Get-AzDnsResolverDomainList -ResourceGroupName powershell-test-rg -Name psdnsresolverdomainlistname33nmy1fz
```

```output
Location Name                                Type                                     Etag
-------- ----                                ----                                     ----
westus2  psdnsresolverdomainlistname33nmy1fz Microsoft.Network/dnsResolverDomainLists "0000c2d4-0000-0800-0000-604013880000"
```

This command gets a single DNS Resolver Domain List by name.
