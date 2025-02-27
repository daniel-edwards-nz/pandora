using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_12_01.DppFeatureSupport;


internal class SupportedFeatureModel
{
    [JsonPropertyName("exposureControlledFeatures")]
    public List<string>? ExposureControlledFeatures { get; set; }

    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    [JsonPropertyName("supportStatus")]
    public FeatureSupportStatusConstant? SupportStatus { get; set; }
}
