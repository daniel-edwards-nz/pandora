using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SystemCenterVirtualMachineManager.v2023_10_07.Clouds;


internal class CloudPropertiesModel
{
    [JsonPropertyName("cloudCapacity")]
    public CloudCapacityModel? CloudCapacity { get; set; }

    [JsonPropertyName("cloudName")]
    public string? CloudName { get; set; }

    [JsonPropertyName("inventoryItemId")]
    public string? InventoryItemId { get; set; }

    [JsonPropertyName("provisioningState")]
    public ProvisioningStateConstant? ProvisioningState { get; set; }

    [JsonPropertyName("storageQoSPolicies")]
    public List<StorageQoSPolicyModel>? StorageQoSPolicies { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    [JsonPropertyName("vmmServerId")]
    public string? VMmServerId { get; set; }
}
