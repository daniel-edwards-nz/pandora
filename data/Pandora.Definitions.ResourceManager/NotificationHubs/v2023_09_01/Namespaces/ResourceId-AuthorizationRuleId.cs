using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NotificationHubs.v2023_09_01.Namespaces;

internal class AuthorizationRuleId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftNotificationHubs", "Microsoft.NotificationHubs"),
        ResourceIDSegment.Static("staticNamespaces", "namespaces"),
        ResourceIDSegment.UserSpecified("namespaceName"),
        ResourceIDSegment.Static("staticAuthorizationRules", "authorizationRules"),
        ResourceIDSegment.UserSpecified("authorizationRuleName"),
    };
}
