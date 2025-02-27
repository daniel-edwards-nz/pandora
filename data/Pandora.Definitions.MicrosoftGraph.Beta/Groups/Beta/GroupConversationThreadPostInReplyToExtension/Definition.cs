// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupConversationThreadPostInReplyToExtension;

internal class Definition : ResourceDefinition
{
    public string Name => "GroupConversationThreadPostInReplyToExtension";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionOperation(),
        new DeleteGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionByIdOperation(),
        new GetGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionByIdOperation(),
        new GetGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionCountOperation(),
        new ListGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionsOperation(),
        new UpdateGroupByIdConversationByIdThreadByIdPostByIdInReplyToExtensionByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
