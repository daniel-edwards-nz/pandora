using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceBus.v2021_06_01_preview.Subscriptions;

internal class ListByTopicOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new TopicId();

    public override Type NestedItemType() => typeof(SBSubscriptionModel);

    public override Type? OptionsObject() => typeof(ListByTopicOperation.ListByTopicOptions);

    public override string? UriSuffix() => "/subscriptions";

    internal class ListByTopicOptions
    {
        [QueryStringName("$skip")]
        [Optional]
        public int Skip { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
