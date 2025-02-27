using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.PerformConnectivityCheck;

internal class Definition : ResourceDefinition
{
    public string Name => "PerformConnectivityCheck";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AsyncOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ConnectionStatusConstant),
        typeof(ConnectivityCheckProtocolConstant),
        typeof(IssueTypeConstant),
        typeof(MethodConstant),
        typeof(OriginConstant),
        typeof(PreferredIPVersionConstant),
        typeof(SeverityConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ConnectivityCheckRequestModel),
        typeof(ConnectivityCheckRequestDestinationModel),
        typeof(ConnectivityCheckRequestProtocolConfigurationModel),
        typeof(ConnectivityCheckRequestProtocolConfigurationHTTPConfigurationModel),
        typeof(ConnectivityCheckRequestSourceModel),
        typeof(ConnectivityCheckResponseModel),
        typeof(ConnectivityHopModel),
        typeof(ConnectivityIssueModel),
        typeof(HTTPHeaderModel),
    };
}
