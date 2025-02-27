using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Search.v2023_11_01.Usages;

internal class UsageBySubscriptionSkuOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new UsageId();

    public override Type? ResponseObject() => typeof(QuotaUsageResultModel);

    public override Type? OptionsObject() => typeof(UsageBySubscriptionSkuOperation.UsageBySubscriptionSkuOptions);

    internal class UsageBySubscriptionSkuOptions
    {
        [HeaderName("x-ms-client-request-id")]
        [Optional]
        public string XMsClientRequestId { get; set; }
    }
}
