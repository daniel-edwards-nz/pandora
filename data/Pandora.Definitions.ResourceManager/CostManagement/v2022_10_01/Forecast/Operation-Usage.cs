using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2022_10_01.Forecast;

internal class UsageOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.NoContent,
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(ForecastDefinitionModel);

    public override ResourceID? ResourceId() => new ScopeId();

    public override Type? ResponseObject() => typeof(ForecastResultModel);

    public override Type? OptionsObject() => typeof(UsageOperation.UsageOptions);

    public override string? UriSuffix() => "/providers/Microsoft.CostManagement/forecast";

    internal class UsageOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
