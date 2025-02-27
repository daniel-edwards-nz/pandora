using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachineScaleSets;


internal class AdditionalCapabilitiesModel
{
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}
