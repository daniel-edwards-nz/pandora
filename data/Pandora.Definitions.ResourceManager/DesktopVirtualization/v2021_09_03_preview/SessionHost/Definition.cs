using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2021_09_03_preview.SessionHost;

internal class Definition : ResourceDefinition
{
    public string Name => "SessionHost";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(HealthCheckNameConstant),
        typeof(HealthCheckResultConstant),
        typeof(StatusConstant),
        typeof(UpdateStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SessionHostModel),
        typeof(SessionHostHealthCheckFailureDetailsModel),
        typeof(SessionHostHealthCheckReportModel),
        typeof(SessionHostPatchModel),
        typeof(SessionHostPatchPropertiesModel),
        typeof(SessionHostPropertiesModel),
    };
}
