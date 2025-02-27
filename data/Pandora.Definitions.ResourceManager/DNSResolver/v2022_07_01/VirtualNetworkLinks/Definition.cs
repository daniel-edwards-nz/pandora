using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DNSResolver.v2022_07_01.VirtualNetworkLinks;

internal class Definition : ResourceDefinition
{
    public string Name => "VirtualNetworkLinks";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SubResourceModel),
        typeof(VirtualNetworkLinkModel),
        typeof(VirtualNetworkLinkPatchModel),
        typeof(VirtualNetworkLinkPatchPropertiesModel),
        typeof(VirtualNetworkLinkPropertiesModel),
    };
}
