using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2017_08_01_preview.IotSecuritySolutions;

internal class IoTSecuritySolutionsListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new SubscriptionId();

    public override Type NestedItemType() => typeof(IoTSecuritySolutionModelModel);

    public override Type? OptionsObject() => typeof(IoTSecuritySolutionsListOperation.IoTSecuritySolutionsListOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Security/iotSecuritySolutions";

    internal class IoTSecuritySolutionsListOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
