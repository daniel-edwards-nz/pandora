using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Migrate.v2020_07_07.RunAsAccounts;

internal class Definition : ResourceDefinition
{
    public string Name => "RunAsAccounts";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetAllRunAsAccountsInSiteOperation(),
        new GetRunAsAccountOperation(),
    };
}
