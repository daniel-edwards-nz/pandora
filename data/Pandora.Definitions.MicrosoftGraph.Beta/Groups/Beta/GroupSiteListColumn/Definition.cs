// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSiteListColumn;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupSiteListColumn";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdSiteByIdListByIdColumnOperation(),
        new DeleteGroupByIdSiteByIdListByIdColumnByIdOperation(),
        new GetGroupByIdSiteByIdListByIdColumnByIdOperation(),
        new GetGroupByIdSiteByIdListByIdColumnCountOperation(),
        new ListGroupByIdSiteByIdListByIdColumnsOperation(),
        new UpdateGroupByIdSiteByIdListByIdColumnByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
