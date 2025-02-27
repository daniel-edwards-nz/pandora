using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApplicationInsights.v2015_05_01.AnalyticsItemsAPIs;

internal class AnalyticsItemsDeleteOperation : Pandora.Definitions.Operations.DeleteOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override ResourceID? ResourceId() => new ProviderComponentId();

    public override Type? OptionsObject() => typeof(AnalyticsItemsDeleteOperation.AnalyticsItemsDeleteOptions);

    public override string? UriSuffix() => "/item";

    internal class AnalyticsItemsDeleteOptions
    {
        [QueryStringName("id")]
        [Optional]
        public string Id { get; set; }

        [QueryStringName("name")]
        [Optional]
        public string Name { get; set; }
    }
}
