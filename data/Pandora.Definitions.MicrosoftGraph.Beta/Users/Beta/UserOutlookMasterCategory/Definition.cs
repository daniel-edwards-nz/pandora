// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserOutlookMasterCategory;

internal class Definition : ResourceDefinition
{
    public string Name => "UserOutlookMasterCategory";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdOutlookMasterCategoryOperation(),
        new DeleteUserByIdOutlookMasterCategoryByIdOperation(),
        new GetUserByIdOutlookMasterCategoryByIdOperation(),
        new GetUserByIdOutlookMasterCategoryCountOperation(),
        new ListUserByIdOutlookMasterCategoriesOperation(),
        new UpdateUserByIdOutlookMasterCategoryByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
