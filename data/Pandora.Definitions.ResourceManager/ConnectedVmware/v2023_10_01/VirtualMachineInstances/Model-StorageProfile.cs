using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ConnectedVmware.v2023_10_01.VirtualMachineInstances;


internal class StorageProfileModel
{
    [JsonPropertyName("disks")]
    public List<VirtualDiskModel>? Disks { get; set; }

    [JsonPropertyName("scsiControllers")]
    public List<VirtualSCSIControllerModel>? ScsiControllers { get; set; }
}
