using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachineScaleSets;


internal class VirtualMachineScaleSetUpdateOSProfileModel
{
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    [JsonPropertyName("linuxConfiguration")]
    public LinuxConfigurationModel? LinuxConfiguration { get; set; }

    [JsonPropertyName("secrets")]
    public List<VaultSecretGroupModel>? Secrets { get; set; }

    [JsonPropertyName("windowsConfiguration")]
    public WindowsConfigurationModel? WindowsConfiguration { get; set; }
}
