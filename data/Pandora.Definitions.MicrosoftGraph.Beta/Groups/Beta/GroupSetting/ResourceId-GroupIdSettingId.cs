// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSetting;

internal class GroupIdSettingId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/settings/{directorySettingId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSettings", "settings"),
        ResourceIDSegment.UserSpecified("directorySettingId")
    };
}
