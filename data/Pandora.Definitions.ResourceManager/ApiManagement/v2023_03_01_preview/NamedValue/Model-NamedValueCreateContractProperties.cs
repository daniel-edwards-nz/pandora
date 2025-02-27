using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.NamedValue;


internal class NamedValueCreateContractPropertiesModel
{
    [JsonPropertyName("displayName")]
    [Required]
    public string DisplayName { get; set; }

    [JsonPropertyName("keyVault")]
    public KeyVaultContractCreatePropertiesModel? KeyVault { get; set; }

    [JsonPropertyName("secret")]
    public bool? Secret { get; set; }

    [MaxItems(32)]
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
