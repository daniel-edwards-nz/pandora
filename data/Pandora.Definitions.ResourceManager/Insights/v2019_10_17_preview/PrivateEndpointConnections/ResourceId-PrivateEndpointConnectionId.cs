using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2019_10_17_preview.PrivateEndpointConnections;

internal class PrivateEndpointConnectionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{privateLinkScopeName}/privateEndpointConnections/{privateEndpointConnectionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftInsights", "Microsoft.Insights"),
        ResourceIDSegment.Static("staticPrivateLinkScopes", "privateLinkScopes"),
        ResourceIDSegment.UserSpecified("privateLinkScopeName"),
        ResourceIDSegment.Static("staticPrivateEndpointConnections", "privateEndpointConnections"),
        ResourceIDSegment.UserSpecified("privateEndpointConnectionName"),
    };
}
