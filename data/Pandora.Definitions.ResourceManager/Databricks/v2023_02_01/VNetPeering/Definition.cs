using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Databricks.v2023_02_01.VNetPeering;

internal class Definition : ResourceDefinition
{
    public string Name => "VNetPeering";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByWorkspaceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(PeeringProvisioningStateConstant),
        typeof(PeeringStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AddressSpaceModel),
        typeof(VirtualNetworkPeeringModel),
        typeof(VirtualNetworkPeeringPropertiesFormatModel),
        typeof(VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetworkModel),
        typeof(VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetworkModel),
    };
}
