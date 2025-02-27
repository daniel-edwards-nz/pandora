// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AuthenticationMethodsRegistrationCampaignModel
{
    [JsonPropertyName("enforceRegistrationAfterAllowedSnoozes")]
    public bool? EnforceRegistrationAfterAllowedSnoozes { get; set; }

    [JsonPropertyName("excludeTargets")]
    public List<ExcludeTargetModel>? ExcludeTargets { get; set; }

    [JsonPropertyName("includeTargets")]
    public List<AuthenticationMethodsRegistrationCampaignIncludeTargetModel>? IncludeTargets { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("snoozeDurationInDays")]
    public int? SnoozeDurationInDays { get; set; }

    [JsonPropertyName("state")]
    public AuthenticationMethodsRegistrationCampaignStateConstant? State { get; set; }
}
