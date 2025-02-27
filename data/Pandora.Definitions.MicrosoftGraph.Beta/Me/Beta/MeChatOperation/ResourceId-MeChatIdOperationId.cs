// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeChatOperation;

internal class MeChatIdOperationId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/me/chats/{chatId}/operations/{teamsAsyncOperationId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticMe", "me"),
        ResourceIDSegment.Static("staticChats", "chats"),
        ResourceIDSegment.UserSpecified("chatId"),
        ResourceIDSegment.Static("staticOperations", "operations"),
        ResourceIDSegment.UserSpecified("teamsAsyncOperationId")
    };
}
