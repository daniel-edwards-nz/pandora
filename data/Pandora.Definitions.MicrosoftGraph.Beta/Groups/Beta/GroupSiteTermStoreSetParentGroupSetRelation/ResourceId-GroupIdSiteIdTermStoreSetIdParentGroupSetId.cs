// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Groups.Beta.GroupSiteTermStoreSetParentGroupSetRelation;

internal class GroupIdSiteIdTermStoreSetIdParentGroupSetId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/groups/{groupId}/sites/{siteId}/termStore/sets/{setId}/parentGroup/sets/{setId1}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticGroups", "groups"),
        ResourceIDSegment.UserSpecified("groupId"),
        ResourceIDSegment.Static("staticSites", "sites"),
        ResourceIDSegment.UserSpecified("siteId"),
        ResourceIDSegment.Static("staticTermStore", "termStore"),
        ResourceIDSegment.Static("staticSets", "sets"),
        ResourceIDSegment.UserSpecified("setId"),
        ResourceIDSegment.Static("staticParentGroup", "parentGroup"),
        ResourceIDSegment.Static("staticSets", "sets"),
        ResourceIDSegment.UserSpecified("setId1")
    };
}
