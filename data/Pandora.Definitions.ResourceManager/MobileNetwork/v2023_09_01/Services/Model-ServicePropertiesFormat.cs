using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_09_01.Services;


internal class ServicePropertiesFormatModel
{
    [MinItems(1)]
    [JsonPropertyName("pccRules")]
    [Required]
    public List<PccRuleConfigurationModel> PccRules { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("servicePrecedence")]
    [Required]
    public int ServicePrecedence { get; set; }

    [JsonPropertyName("serviceQosPolicy")]
    public QosPolicyModel? ServiceQosPolicy { get; set; }
}
