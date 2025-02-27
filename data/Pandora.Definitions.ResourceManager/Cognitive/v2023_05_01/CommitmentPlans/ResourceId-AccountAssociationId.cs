using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.CommitmentPlans;

internal class AccountAssociationId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{accountAssociationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftCognitiveServices", "Microsoft.CognitiveServices"),
        ResourceIDSegment.Static("staticCommitmentPlans", "commitmentPlans"),
        ResourceIDSegment.UserSpecified("commitmentPlanName"),
        ResourceIDSegment.Static("staticAccountAssociations", "accountAssociations"),
        ResourceIDSegment.UserSpecified("accountAssociationName"),
    };
}
