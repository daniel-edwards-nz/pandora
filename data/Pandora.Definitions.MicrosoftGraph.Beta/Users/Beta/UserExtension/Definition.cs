// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Users.Beta.UserExtension;

internal class Definition : ResourceDefinition
{
    public string Name => "UserExtension";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateUserByIdExtensionOperation(),
        new DeleteUserByIdExtensionByIdOperation(),
        new GetUserByIdExtensionByIdOperation(),
        new GetUserByIdExtensionCountOperation(),
        new ListUserByIdExtensionsOperation(),
        new UpdateUserByIdExtensionByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
