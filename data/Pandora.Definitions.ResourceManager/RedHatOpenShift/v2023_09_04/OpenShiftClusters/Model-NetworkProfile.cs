using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RedHatOpenShift.v2023_09_04.OpenShiftClusters;


internal class NetworkProfileModel
{
    [JsonPropertyName("outboundType")]
    public OutboundTypeConstant? OutboundType { get; set; }

    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    [JsonPropertyName("preconfiguredNSG")]
    public PreconfiguredNSGConstant? PreconfiguredNSG { get; set; }

    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }
}
