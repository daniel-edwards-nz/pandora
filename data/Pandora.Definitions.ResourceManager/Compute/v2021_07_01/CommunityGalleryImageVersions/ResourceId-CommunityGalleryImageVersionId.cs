using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2021_07_01.CommunityGalleryImageVersions;

internal class CommunityGalleryImageVersionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{locationName}/communityGalleries/{communityGalleryName}/images/{imageName}/versions/{versionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftCompute", "Microsoft.Compute"),
        ResourceIDSegment.Static("staticLocations", "locations"),
        ResourceIDSegment.UserSpecified("locationName"),
        ResourceIDSegment.Static("staticCommunityGalleries", "communityGalleries"),
        ResourceIDSegment.UserSpecified("communityGalleryName"),
        ResourceIDSegment.Static("staticImages", "images"),
        ResourceIDSegment.UserSpecified("imageName"),
        ResourceIDSegment.Static("staticVersions", "versions"),
        ResourceIDSegment.UserSpecified("versionName"),
    };
}
