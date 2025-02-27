using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NetworkCloud.v2023_07_01.Networkclouds;


internal class L2NetworkPropertiesModel
{
    [JsonPropertyName("associatedResourceIds")]
    public List<string>? AssociatedResourceIds { get; set; }

    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("detailedStatus")]
    public L2NetworkDetailedStatusConstant? DetailedStatus { get; set; }

    [JsonPropertyName("detailedStatusMessage")]
    public string? DetailedStatusMessage { get; set; }

    [JsonPropertyName("hybridAksClustersAssociatedIds")]
    public List<string>? HybridAksClustersAssociatedIds { get; set; }

    [JsonPropertyName("hybridAksPluginType")]
    public HybridAksPluginTypeConstant? HybridAksPluginType { get; set; }

    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    [JsonPropertyName("l2IsolationDomainId")]
    [Required]
    public string L2IsolationDomainId { get; set; }

    [JsonPropertyName("provisioningState")]
    public L2NetworkProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("virtualMachinesAssociatedIds")]
    public List<string>? VirtualMachinesAssociatedIds { get; set; }
}
