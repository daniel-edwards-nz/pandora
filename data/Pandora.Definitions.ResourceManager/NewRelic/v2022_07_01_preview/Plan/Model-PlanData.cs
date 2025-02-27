using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NewRelic.v2022_07_01_preview.Plan;


internal class PlanDataModel
{
    [JsonPropertyName("billingCycle")]
    public BillingCycleConstant? BillingCycle { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("effectiveDate")]
    public DateTime? EffectiveDate { get; set; }

    [JsonPropertyName("planDetails")]
    public string? PlanDetails { get; set; }

    [JsonPropertyName("usageType")]
    public UsageTypeConstant? UsageType { get; set; }
}
