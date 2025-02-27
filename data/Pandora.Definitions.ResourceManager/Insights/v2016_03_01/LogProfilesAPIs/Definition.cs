using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2016_03_01.LogProfilesAPIs;

internal class Definition : ResourceDefinition
{
    public string Name => "LogProfilesAPIs";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new LogProfilesUpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(LogProfilePropertiesModel),
        typeof(LogProfileResourceModel),
        typeof(LogProfileResourcePatchModel),
        typeof(RetentionPolicyModel),
    };
}
